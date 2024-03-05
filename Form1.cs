
using Ressy;
using Ressy.HighLevel.Versions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toolbelt.Drawing;
using Vestris.ResourceLib;
using static Vestris.ResourceLib.Winver;


namespace SharpThief
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SelectFile.AllowDrop = true;
            SelectFile.DragEnter += new DragEventHandler(SelectFile_DragDrop);
            SelectFile.DragDrop += new DragEventHandler(SelectFile_DragEnter);
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable (*.exe)|*.exe";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileVersionInfo = FileVersionInfo.GetVersionInfo(openFileDialog.FileName);

                    txtOriginalFilename.Text = fileVersionInfo.InternalName ?? string.Empty;
                    txtDescription.Text = fileVersionInfo.FileDescription ?? string.Empty;
                    txtCompany.Text = fileVersionInfo.CompanyName ?? string.Empty;
                    txtProduct.Text = fileVersionInfo.ProductName ?? string.Empty;
                    txtCopyright.Text = fileVersionInfo.LegalCopyright ?? string.Empty;
                    txtTrademarks.Text = fileVersionInfo.LegalTrademarks ?? string.Empty;

                    var version = fileVersionInfo.FileMajorPart;
                    txtFileVersion.Text = $"{fileVersionInfo.FileMajorPart.ToString()}.{fileVersionInfo.FileMinorPart.ToString()}.{fileVersionInfo.FileBuildPart.ToString()}.{fileVersionInfo.FilePrivatePart.ToString()}";
                    txtProductVersion.Text = $"{fileVersionInfo.FileMajorPart.ToString()}.{fileVersionInfo.FileMinorPart.ToString()}.{fileVersionInfo.FileBuildPart.ToString()}.{fileVersionInfo.FilePrivatePart.ToString()}";
                }
            }
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Choose Icon";
                ofd.Filter = "Icons Files(*.exe;*.ico;)|*.exe;*.ico";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.FileName.ToLower().EndsWith(".exe"))
                    {
                        string ico = GetIcon(ofd.FileName);
                        //txtIcon.Text = ico;
                        toolStrip1.Text = ico;
                        toolStrip1.ForeColor = Color.DarkGreen;
                        picIcon.ImageLocation = ico;
                    }
                    else
                    {
                        //txtIcon.Text = ofd.FileName;
                        toolStrip1.Text = ofd.FileName;
                        toolStrip1.ForeColor = Color.DarkGreen;
                        picIcon.ImageLocation = ofd.FileName;
                    }
                }
            }
        }

        private void chkIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcon.Checked)
            {
                //txtIcon.Enabled = true;
                btnIcon.Enabled = true;
            }
            else
            {
                //txtIcon.Enabled = false;
                btnIcon.Enabled = false;
            }
        }
        private string GetIcon(string path)
        {
            try
            {
                string tempFile = Path.GetTempFileName() + ".ico";
                using (FileStream fs = new FileStream(tempFile, FileMode.Create))
                {
                    IconExtractor.Extract1stIconTo(path, fs);
                }
                return tempFile;
            }
            catch { }
            return "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Language();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Choose Icon";
                ofd.Filter = "Icons Files(*.exe;)|*.exe;";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    SelectFile.Tag = ofd.FileName;
                    SelectFile.Text = Path.GetFileName(ofd.FileName);
                    SelectFile.ForeColor = Color.Red;
                }
            }
        }
        private void WriteAssembly(string filename)
        {
            try
            {
                var portableExecutable = new PortableExecutable(filename);
                string[] Pdversion = txtProductVersion.Text.Split('.');
                string[] Flversion = txtFileVersion.Text.Split('.');

                var versionInfo = new VersionInfoBuilder()
                    .SetFileVersion(new Version(Convert.ToInt32(Flversion[0]), Convert.ToInt32(Flversion[1]), Convert.ToInt32(Flversion[2]), Convert.ToInt32(Flversion[3])))
                    .SetProductVersion(new Version(Convert.ToInt32(Pdversion[0]), Convert.ToInt32(Pdversion[1]), Convert.ToInt32(Pdversion[2]), Convert.ToInt32(Pdversion[3])))
                    .SetFileType(Ressy.HighLevel.Versions.FileType.Application)
                    .SetAttribute(VersionAttributeName.FileDescription, txtDescription.Text)
                    .SetAttribute(VersionAttributeName.CompanyName, txtCompany.Text)
                       //  .SetAttribute(VersionAttributeName.LegalTrademark, txtTrademarks.Text)
                    .SetAttribute(VersionAttributeName.OriginalFilename, txtOriginalFilename.Text)
                    .SetAttribute(VersionAttributeName.ProductName, txtProduct.Text)
                    .SetAttribute(VersionAttributeName.LegalCopyright, txtCopyright.Text)
               
                    .SetFileOperatingSystem(FileOperatingSystem.WindowsNT)
                     .SetFileSubType(Ressy.HighLevel.Versions.FileSubType.Unknown)
                    .Build();

                portableExecutable.SetVersionInfo(versionInfo);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Assembly: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               
                string tempPath = Path.GetTempPath();
                string randomFileName = Path.GetRandomFileName() + ".exe";
                string fullPath = Path.Combine(tempPath, randomFileName);

                File.WriteAllBytes(fullPath, File.ReadAllBytes(SelectFile.Tag.ToString()));

                //Console.WriteLine($"文件已成功写入: {fullPath}");

                using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
                {
                    saveFileDialog1.Filter = ".exe (*.exe)|*.exe";
                    saveFileDialog1.InitialDirectory = Application.StartupPath;
                    saveFileDialog1.OverwritePrompt = false;
                    saveFileDialog1.FileName = "Client";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {

                        if (chkIcon.Checked && !string.IsNullOrEmpty(toolStrip1.Text))
                        {
                            IconInjector.InjectIcon(fullPath, toolStrip1.Text);
                           
                        }
                        Thread.Sleep(500);
                        if (btnAssembly.Checked)
                        {
                            WriteAssembly(fullPath);
                        }
                        Thread.Sleep(500);
                        if (checkBox1.Checked)
                        {
                            var cert = new PEFileInfo().CopyCert(signatureFile.Tag.ToString());
                            new PEFileInfo().WriteCert(cert, fullPath, saveFileDialog1.FileName);
                        }
                        if (File.Exists(saveFileDialog1.FileName))
                        {
                            MessageBox.Show("Build sucessfully!", "Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Build Error!", "Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        File.Delete(fullPath);
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAssembly_CheckedChanged(object sender, EventArgs e)
        {
            if (btnAssembly.Checked)
            {
                btnClone.Enabled = true;
                txtProduct.Enabled = true;
                txtDescription.Enabled = true;
                txtCompany.Enabled = true;
                txtCopyright.Enabled = true;
                txtTrademarks.Enabled = true;
                txtOriginalFilename.Enabled = true;
                txtOriginalFilename.Enabled = true;
                txtProductVersion.Enabled = true;
                txtFileVersion.Enabled = true;
            }
            else
            {
                btnClone.Enabled = false;
                txtProduct.Enabled = false;
                txtDescription.Enabled = false;
                txtCompany.Enabled = false;
                txtCopyright.Enabled = false;
                txtTrademarks.Enabled = false;
                txtOriginalFilename.Enabled = false;
                txtOriginalFilename.Enabled = false;
                txtProductVersion.Enabled = false;
                txtFileVersion.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Choose Icon";
                ofd.Filter = "Icons Files(*.exe;)|*.exe;";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    //string ico = GetIcon(ofd.FileName);
                    //txtIcon.Text = ico;
                    signatureFile.Tag = ofd.FileName;
                    signatureFile.Text = Path.GetFileName(ofd.FileName);
                    signatureFile.ForeColor = Color.DarkGreen;


                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                signatureFile.Enabled = true;
            }
            else
            {
                signatureFile.Enabled = false;
            }
        }


        public void Language()
        {
            switch (Properties.Settings.Default.Language)
            {
                case "en-US":
                    {

                        chkIcon.Text = "Icon";
                        btnIcon.Text = "Select Icon";
                        checkBox1.Text = "SigThief";
                        signatureFile.Text = "Sig File";
                        SelectFile.Text = "SelectFile";
                        Build.Text = "Build";
                        btnAssembly.Text = "Build Info";
                        label8.Text = "Product:";
                        label7.Text = "Description:";
                        label9.Text = "Company:";
                        label10.Text = "Copyright:";
                        label11.Text = "Trademark:";
                        label12.Text = "Original:";
                        label13.Text = "ProductVersion:";
                        label14.Text = "FileVersion:";
                        btnClone.Text = "Clone";
                        Properties.Settings.Default.Save();
                        break;
                    }
                case "en-CN":
                    {
                        chkIcon.Text = "图标";
                        btnIcon.Text = "选择图标";
                        checkBox1.Text = "窃取签名";
                        signatureFile.Text = "签名文件";
                        SelectFile.Text = "选择文件";
                        Build.Text = "生成";
                        btnAssembly.Text = "生成程序信息";
                        label8.Text = "产品:";
                        label7.Text = "描述:";
                        label9.Text = "公司:";
                        label10.Text = "版权:";
                        label11.Text = "商标:";
                        label12.Text = "原始文件名:";
                        label13.Text = "产品版本号:";
                        label14.Text = "文件版本号:";
                        btnClone.Text = "克隆";
                        Properties.Settings.Default.Save();
                        break;
                    }
            }
        }

        private void chineseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = "en-CN";
            Language();
            Properties.Settings.Default.Save();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = "en-US";
            Language();

            Properties.Settings.Default.Save();
        }

        private void SelectFile_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                //MessageBox.Show("calc");
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    
                    SelectFile.Text = Path.GetFileName(file);
                    SelectFile.Tag = file;
                    SelectFile.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
    }
}
