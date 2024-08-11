using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SteamAddonDownloader;
using GWTool;

namespace GmodAddonInstaller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] possiblePaths = new string[]{
                @"C:\Program Files\Garrys Mod",
                @"C:\Program Files (x86)\Garrys Mod",
                @"C:\Games\Garrys Mod",
                @"D:\Games\Garrys Mod",
                @"C:\Program Files\Garry's Mod",
                @"C:\Program Files (x86)\Garry's Mod",
                @"C:\Games\Garry's Mod",
                @"D:\Games\Garry's Mod",
                @"C:\Program Files\GarrysMod",
                @"C:\Program Files (x86)\GarrysMod",
                @"C:\Games\GarrysMod",
                @"D:\Games\GarrysMod",
            };

            foreach(string possiblePath in possiblePaths)
            {
                if (Directory.Exists(possiblePath))
                {
                    TbGmodPath.Text = possiblePath;
                    break;
                }
            }
        }

        private void BtnSelectPath_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Title = "Выберите исполняемый файл Garry's mod";
            ofd.Filter = "Программы (*.exe)|*.exe";
            
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                TbGmodPath.Text = Path.GetDirectoryName(ofd.FileName);
            }
        }

        private void BtnInstall_Click(object sender, EventArgs e)
        {
            TbGmodPath.Enabled = false;
            TbAddonName.Enabled = false;
            BtnInstall.Enabled = false;

            string gmDir = Path.Combine(TbGmodPath.Text, "garrysmod", "addons");

            if (!Directory.Exists(gmDir))
            {
                MessageBox.Show("Указан неверный путь к Garry's mod", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TbGmodPath.Enabled = true;
                TbAddonName.Enabled = true;
                BtnInstall.Enabled = true;
                TbAddonName.Text = "";
                return;
            }

            var match = Regex.Match(TbAddonName.Text, @"\?id=([0-9]+)");
            
            if(!match.Success)
            {
                MessageBox.Show("Указана неверная ссылка на аддон", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TbGmodPath.Enabled = true;
                TbAddonName.Enabled = true;
                BtnInstall.Enabled = true;
                TbAddonName.Text = "";
                return;
            }

            string id = match.Groups[1].Value;

            Task.Run(()=>{
                string prgDir = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
                string steamCmdDir = Path.Combine(prgDir, "steamcmd");
                string steamCmdZip = Path.Combine(prgDir, "steamcmd.zip");
                string steamCmd = Path.Combine(steamCmdDir, "steamcmd.exe");

                if(!File.Exists(steamCmd))
                {
                    MessageBox.Show("Первая установка может занимать больше времени из-за скачивания необходимых файлов", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!Directory.Exists(steamCmdDir)) Directory.CreateDirectory(steamCmdDir);

                    try
                    {
                        new WebClient().DownloadFile("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip", steamCmdZip);
                        ZipFile.ExtractToDirectory(steamCmdZip, steamCmdDir);
                        File.Delete(steamCmdZip);
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка:\n" + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TbGmodPath.Enabled = true;
                        TbAddonName.Enabled = true;
                        BtnInstall.Enabled = true;
                        TbAddonName.Text = "";
                        return;
                    }
                }

                try
                {
                    string addonFile = SteamCMD.DownloadAddon(steamCmd, id);
                    GMADTool.Extract(addonFile, gmDir);
                }catch(Exception ex)
                {
                    MessageBox.Show("Произошла ошибка:\n" + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TbGmodPath.Enabled = true;
                    TbAddonName.Enabled = true;
                    BtnInstall.Enabled = true;
                    TbAddonName.Text = "";
                    return;
                }

                MessageBox.Show("Аддон успешно установлен", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TbGmodPath.Enabled = true;
                TbAddonName.Enabled = true;
                BtnInstall.Enabled = true;
                TbAddonName.Text = "";
            });
        }

        private void BtnOpenAddons_Click(object sender, EventArgs e)
        {
            string gmDir = Path.Combine(TbGmodPath.Text, "garrysmod", "addons");

            if (!Directory.Exists(gmDir))
            {
                MessageBox.Show("Указан неверный путь к Garry's mod", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var proc = new Process();
            proc.StartInfo.FileName = "explorer.exe";
            proc.StartInfo.Arguments = gmDir;
            proc.Start();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gmod Addon Installer 0.1 by nekit270\n\nУтилита для установки аддонов на Garry's Mod из мастерской Steam.");
        }
    }
}
