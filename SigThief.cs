using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

public class PEFileInfo
{
    public static Dictionary<string, dynamic> GatherFileInfoWin(string binaryPath)
    {
        var flItms = new Dictionary<string, dynamic>();
        using (var binary = new FileStream(binaryPath, FileMode.Open, FileAccess.Read))
        using (var reader = new BinaryReader(binary))
        {
            binary.Seek(0x3C, SeekOrigin.Begin);
            flItms["buffer"] = 0;
            flItms["JMPtoCodeAddress"] = 0;
            flItms["dis_frm_pehdrs_sectble"] = 248;
            flItms["pe_header_location"] = reader.ReadInt32();

            // Start of COFF
            flItms["COFF_Start"] = flItms["pe_header_location"] + 4;
            binary.Seek(flItms["COFF_Start"], SeekOrigin.Begin);
            flItms["MachineType"] = reader.ReadUInt16();
            binary.Seek(flItms["COFF_Start"] + 2, SeekOrigin.Begin);
            flItms["NumberOfSections"] = reader.ReadUInt16();
            flItms["TimeDateStamp"] = reader.ReadUInt32();
            binary.Seek(flItms["COFF_Start"] + 16, SeekOrigin.Begin);
            flItms["SizeOfOptionalHeader"] = reader.ReadUInt16();
            flItms["Characteristics"] = reader.ReadUInt16();

            // Optional Header
            flItms["OptionalHeader_start"] = flItms["COFF_Start"] + 20;
            binary.Seek(flItms["OptionalHeader_start"], SeekOrigin.Begin);
            flItms["Magic"] = reader.ReadUInt16();
            flItms["MajorLinkerVersion"] = reader.ReadByte();
            flItms["MinorLinkerVersion"] = reader.ReadByte();
            flItms["SizeOfCode"] = reader.ReadUInt32();
            flItms["SizeOfInitializedData"] = reader.ReadUInt32();
            flItms["SizeOfUninitializedData"] = reader.ReadUInt32();
            flItms["AddressOfEntryPoint"] = reader.ReadUInt32();
            flItms["PatchLocation"] = flItms["AddressOfEntryPoint"];
            flItms["BaseOfCode"] = reader.ReadUInt32();

            if (flItms["Magic"] != 0x20B)
            {
                flItms["BaseOfData"] = reader.ReadUInt32();
            }

            // Windows-Specific Fields of Optional Header
            if (flItms["Magic"] == 0x20B)
            {
                flItms["ImageBase"] = reader.ReadUInt64();
            }
            else
            {
                flItms["ImageBase"] = reader.ReadUInt32();
            }

            flItms["SectionAlignment"] = reader.ReadUInt32();
            flItms["FileAlignment"] = reader.ReadUInt32();
            flItms["MajorOperatingSystemVersion"] = reader.ReadUInt16();
            flItms["MinorOperatingSystemVersion"] = reader.ReadUInt16();
            flItms["MajorImageVersion"] = reader.ReadUInt16();
            flItms["MinorImageVersion"] = reader.ReadUInt16();
            flItms["MajorSubsystemVersion"] = reader.ReadUInt16();
            flItms["MinorSubsystemVersion"] = reader.ReadUInt16();
            flItms["Win32VersionValue"] = reader.ReadUInt32();
            flItms["SizeOfImageLoc"] = binary.Position;
            flItms["SizeOfImage"] = reader.ReadUInt32();
            flItms["SizeOfHeaders"] = reader.ReadUInt32();
            flItms["CheckSum"] = reader.ReadUInt32();
            flItms["Subsystem"] = reader.ReadUInt16();
            flItms["DllCharacteristics"] = reader.ReadUInt16();

            if (flItms["Magic"] == 0x20B)
            {
                flItms["SizeOfStackReserve"] = reader.ReadUInt64();
                flItms["SizeOfStackCommit"] = reader.ReadUInt64();
                flItms["SizeOfHeapReserve"] = reader.ReadUInt64();
                flItms["SizeOfHeapCommit"] = reader.ReadUInt64();
            }
            else
            {
                flItms["SizeOfStackReserve"] = reader.ReadUInt32();
                flItms["SizeOfStackCommit"] = reader.ReadUInt32();
                flItms["SizeOfHeapReserve"] = reader.ReadUInt32();
                flItms["SizeOfHeapCommit"] = reader.ReadUInt32();
            }

            flItms["LoaderFlags"] = reader.ReadUInt32();
            flItms["NumberofRvaAndSizes"] = reader.ReadUInt32();

            // Data Directories
            flItms["ExportTableRVA"] = reader.ReadUInt32();
            flItms["ExportTableSize"] = reader.ReadUInt32();
            flItms["ImportTableLOCInPEOptHdrs"] = binary.Position;
            flItms["ImportTableRVA"] = reader.ReadUInt32();
            flItms["ImportTableSize"] = reader.ReadUInt32();
            flItms["ResourceTable"] = reader.ReadUInt64();
            flItms["ExceptionTable"] = reader.ReadUInt64();
            flItms["CertTableLOC"] = binary.Position;
            flItms["CertLOC"] = reader.ReadUInt32();
            flItms["CertSize"] = reader.ReadUInt32();
        }

        return flItms;
    }

    public byte[] CopyCert(string exe)
    {
        var flItms = GatherFileInfoWin(exe);

        if (flItms["CertLOC"] == 0 || flItms["CertSize"] == 0)
        {
            Console.WriteLine("Input file Not signed!");
            Environment.Exit(-1);
        }

        using (var f = new FileStream(exe, FileMode.Open, FileAccess.Read))
        {
            f.Seek((long)flItms["CertLOC"], SeekOrigin.Begin);
            var cert = new byte[(int)flItms["CertSize"]];
            f.Read(cert, 0, (int)flItms["CertSize"]);
            return cert;
        }
    }

    public void WriteCert(byte[] cert, string Inputexe, string output)
    {
        var flItms = GatherFileInfoWin(Inputexe);

        if (string.IsNullOrEmpty(output))
        {
            output = $"{Inputexe}_signed";
        }

        File.Copy(Inputexe, output, true);
        Console.WriteLine($"Output file: {output}");

        using (var g = new FileStream(Inputexe, FileMode.Open, FileAccess.Read))
        using (var f = new FileStream(output, FileMode.Open, FileAccess.Write))
        {
            var exeData = new byte[g.Length];
            g.Read(exeData, 0, exeData.Length);
            f.Write(exeData, 0, exeData.Length);

            f.Seek((long)flItms["CertTableLOC"], SeekOrigin.Begin);
            var exeLength = exeData.Length;
            f.Write(BitConverter.GetBytes(exeLength), 0, 4);
            f.Write(BitConverter.GetBytes(cert.Length), 0, 4);
            f.Seek(0, SeekOrigin.End);
            f.Write(cert, 0, cert.Length);
        }

        Console.WriteLine("Signature appended. \nFIN.");
    }

    public void OutputCert(string exe, string output)
    {
        var cert = CopyCert(exe);
        if (string.IsNullOrEmpty(output))
        {
            output = $"{exe}_sig";
        }

        Console.WriteLine($"Output file: {output}");

        File.WriteAllBytes(output, cert);

        Console.WriteLine("Signature ripped. \nFIN.");
    }
    public void CheckSig(string exe)
    {
        var flItms = GatherFileInfoWin(exe);

        if (flItms["CertLOC"] == 0 || flItms["CertSize"] == 0)
        {
            Console.WriteLine("Inputfile Not signed!");
        }
        else
        {
            Console.WriteLine("Inputfile is signed!");
        }
    }

    public void Truncate(string exe, string output)
    {
        var flItms = GatherFileInfoWin(exe);

        if (flItms["CertLOC"] == 0 || flItms["CertSize"] == 0)
        {
            Console.WriteLine("Inputfile Not signed!");
            Environment.Exit(-1);
        }
        else
        {
            Console.WriteLine("Inputfile is signed!");
        }

        if (string.IsNullOrEmpty(output))
        {
            output = $"{exe}_nosig";
        }

        Console.WriteLine($"Output file: {output}");

        File.Copy(exe, output, true);

        using (var binary = new FileStream(output, FileMode.Open, FileAccess.ReadWrite))
        {
            Console.WriteLine("Overwriting certificate table pointer and truncating binary");
            binary.Seek(-flItms["CertSize"], SeekOrigin.End);
            binary.SetLength(binary.Position);
            binary.Seek((long)flItms["CertTableLOC"], SeekOrigin.Begin);
            binary.Write(new byte[8], 0, 8); // Writing 8 zero bytes to erase the certificate table pointer
        }

        Console.WriteLine("Signature removed. \nFIN.");
    }

    public void SignFile(string exe, string sigfile, string output)
    {
        var flItms = GatherFileInfoWin(exe);
        var cert = File.ReadAllBytes(sigfile);

        if (string.IsNullOrEmpty(output))
        {
            output = $"{exe}_signed";
        }

        Console.WriteLine($"Output file: {output}");

        File.Copy(exe, output, true);

        using (var g = new FileStream(exe, FileMode.Open, FileAccess.Read))
        using (var f = new FileStream(output, FileMode.Open, FileAccess.Write))
        {
            var exeData = new byte[g.Length];
            g.Read(exeData, 0, exeData.Length);
            f.Write(exeData, 0, exeData.Length);

            f.Seek((long)flItms["CertTableLOC"], SeekOrigin.Begin);
            f.Write(BitConverter.GetBytes(exeData.Length), 0, 4);
            f.Write(BitConverter.GetBytes(cert.Length), 0, 4);
            f.Seek(0, SeekOrigin.End);
            f.Write(cert, 0, cert.Length);
        }

        Console.WriteLine("Signature appended. \nFIN.");
    }

}
