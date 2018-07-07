using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace YouaiSavior
{
    interface IGetPath {
        void OnWowPathGetEach(string path);
        void OnWowPathGetSucess(string[] paths);
        void OnWowPathGetFailed();
    }

    class WowPathFinder
    {
        private SynchronizationContext m_SyncContext = null;

        IGetPath mGetPath;

        private List<string> mWowPath;
        private bool mStartFind = false;

        public WowPathFinder() {
        }

        private void GetAllFilesInDirectory(string path, int MAXDEEP, int deep = 0)
        {
            if (!mStartFind) {
                return;
            }
            DirectoryInfo dir = new DirectoryInfo(path);
             
            List<FileInfo> listFiles = new List<FileInfo>(); //保存所有的文件信息
            DirectoryInfo[] directoryArray;
            try {
                directoryArray = dir.GetDirectories();
            } catch (UnauthorizedAccessException e) {
                return;
            }
            FileInfo[] fileInfoArray = dir.GetFiles();

            int hasWowCount = 0;

            foreach (FileInfo info in fileInfoArray) {
                if ("Wow.exe".Equals(info.Name) || "Wow-64.exe".Equals(info.Name)) {
                    hasWowCount++;
                    if (hasWowCount == 2) {
                        break;
                    }
                }
            }

            if (hasWowCount == 2) {
                mWowPath.Add(path);
                mStartFind = false;
                m_SyncContext.Post(OnSucessEachPost, path);
                return;
            }

            if (++deep == MAXDEEP +1) {
                return;
            }
            foreach (DirectoryInfo _directoryInfo in directoryArray)
            {
                GetAllFilesInDirectory(_directoryInfo.FullName, MAXDEEP, deep);//递归遍历  
            }
        }

        private void ThreadFunc()
        {
            DriveInfo[] allDirves = DriveInfo.GetDrives();
            mWowPath = new List<string>();

            mStartFind = true;

            //检索计算机上的所有逻辑驱动器名称 2曾遍历
            foreach (DriveInfo item in allDirves)
            {
                //Fixed 硬盘
                //Removable 可移动存储设备，如软盘驱动器或USB闪存驱动器。
                if (item.IsReady)
                {
                    GetAllFilesInDirectory(item.Name, 2);
                }
            }

            if (mWowPath.Count == 0) { //3曾遍历
                foreach (DriveInfo item in allDirves)
                {
                    //Fixed 硬盘
                    //Removable 可移动存储设备，如软盘驱动器或USB闪存驱动器。
                    if (item.IsReady)
                    {
                        GetAllFilesInDirectory(item.Name, 3);
                    }
                }
            }

            //在线程中更新UI（通过UI线程同步上下文m_SyncContext）
            if (mWowPath.Count == 0) {
                m_SyncContext.Post(OnFailedPost, null);
            } else
                m_SyncContext.Post(OnSucessAllPost, mWowPath);
            //...执行线程其他任务
        }

        public void OnSucessEachPost(object o)
        {
            mGetPath.OnWowPathGetEach((string) o);
        }

        public void OnSucessAllPost(object o) {
            List<string> list = (List<string>) o;
            string[] ss = list.ToArray();
            mGetPath.OnWowPathGetSucess(ss);
        }

        public void OnFailedPost(object o)
        {
            mGetPath.OnWowPathGetFailed();
        }

        public void StartFinder(IGetPath p) {
            m_SyncContext = SynchronizationContext.Current;
            mGetPath = p;
            Thread th = new Thread(new ThreadStart(ThreadFunc));
            th.Start();
        }
    }
}
