using MetroFramework.Forms;
using System;

using System.Windows.Forms;
using YouaiSavior.util;
using static YouaiSavior.AsyncUtil;

namespace YouaiSavior
{
    //System.Diagnostics.Process.Start("ExpLore", "C:\\window");
    public partial class MainForm : MetroForm, IGetPath, IAsyncCallback
    {
        private bool mShouldUpdateAddon = false;

        public void OnEndCallback(object info, bool inCallThread)
        {
            ALog.D("eee " + inCallThread);
            if (info is YouaiRelease) {

            }
            //TODO 升级按钮是否变动， 万能label按钮  万能label是否变动，
            //
        }

        public MainForm()
        {
            InitializeComponent();
            //1. 寻找wow位置
            string path = XmlConfigInstance.XML().Read("wow_path");
            if (path == null || "".Equals(path) || !Utils.IsWowPath(path))
            { //如果没有则查找
                WowPathFinder finder = new WowPathFinder();
                finder.StartFinder(this);
            }
            else
            {
                wowPath.Text = path;
            }
            //init
            ClientVersionLabel.Text = Properties.Settings.Default.local_client_version;
            //1. 比较配置文件插件版本和游戏目录插件版本
            mShouldUpdateAddon = false;
            string version_in_config = XmlConfigInstance.XML().Read("local_addon_version");
            string version_in_wow_interface = "v1"; //TODO
            AddonVersionLabel.Text = version_in_wow_interface;
            if (version_in_wow_interface.CompareTo(version_in_config) > 0)
            { //如果游戏中版本大
                XmlConfigInstance.XML().Write(version_in_wow_interface, "local_addon_version");
            }
            else if (version_in_wow_interface.CompareTo(version_in_config) == 0)
            {
            }
            else {
                mShouldUpdateAddon = true;
            }
            //1. 解析出目标网址信息
            AsyncUtil webPaser = new WebParser();
            
            webPaser.Start(this);
        }

        private void settingPicture_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            string readPath  = XmlConfigInstance.XML().Read("wow_path");
            if (readPath != null && readPath.Length > 0) {
                dialog.SelectedPath = readPath;
            }
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;//TODO 这里可以增加判断
                wowPath.Text = foldPath;
                XmlConfigInstance.XML().Write(foldPath, "wow_path");
            }
        }

        public void OnWowPathGetSucess(string[] paths)
        {
        }

        public void OnWowPathGetFailed()
        {
            wowPath.Text = "无法找到WOW目录，请自行设置。";
        }

        public void OnWowPathGetEach(string path)
        {
            wowPath.Text = path;
            XmlConfigInstance.XML().Write(path, "wow_path");
        }

        private void UpdateClientBtn_Click(object sender, EventArgs e)
        {

        }

        private void NgaBtn_Click(object sender, EventArgs e)
        {
            string link = XmlConfigInstance.XML().Read("nga_tie_link"); 
            System.Diagnostics.Process.Start(link ?? Utils.NGA_TIE_LINK);
        }

        private void WebLinkBtn1_Click(object sender, EventArgs e)
        {

        }

        private void WebLinkBtn2_Click(object sender, EventArgs e)
        {

        }

        private void HowToUseBtn_Click(object sender, EventArgs e)
        {

        }

        private void EverykeyBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
