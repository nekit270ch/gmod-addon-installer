using System;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace SteamAddonDownloader
{
    public class SteamCMD
    {
        public static string DownloadAddons(string path, string[] ids)
        {
            var args = new StringBuilder("+\"login anonymous\" ");
            foreach(string id in ids)
            {
                args.Append($"+\"workshop_download_item 4000 {id}\" ");
            }
            args.Append("+quit");

            var sc = new Process();
            sc.StartInfo.FileName = path;
            sc.StartInfo.Arguments = args.ToString();
            sc.StartInfo.CreateNoWindow = true;
            sc.StartInfo.UseShellExecute = true;
            sc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            sc.Start();
            sc.WaitForExit();

            return Path.GetFullPath(Path.Combine(Path.GetDirectoryName(path), "steamapps\\workshop\\content\\4000"));
        }

        public static string DownloadAddon(string path, string id)
        {
            string addonsDir = DownloadAddons(path, new string[]{ id });
            return Directory.GetFiles(Path.Combine(addonsDir, id))[0];
        }
    }
}