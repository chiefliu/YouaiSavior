using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using System.Threading;
using YouaiSavior.util;

namespace YouaiSavior
{
    public class AllanBody {
        public string Version { get; set; }
        public string Description { get; set; }
    }

    public class YouaiRelease
    {
        public string ClientVersion { get; set; }
        public string AddonVersion { get; set; }
        public AllanBody[] Body { get; set; }
        public string NgaTieLink { get; set; }
        public string[] WebDownloadUrls { get; set; }

        public void Print()
        {
            ALog.D("client version: " + ClientVersion);
            ALog.D("addon version: " + AddonVersion);
            foreach (AllanBody one in Body)
            {
                ALog.D("body: " + one.Version + ", " + one.Description);
            }

            foreach (string one in WebDownloadUrls)
            {
                ALog.D("download: " + one);
            }
        }
    }

    public class WebParser : AsyncUtil
    {

        private static YouaiRelease GetAllRelease()
        {
            YouaiRelease rel = new YouaiRelease();
            try
            {
                string json;
                using (var wc = new WebClient())
                {
                    wc.Headers.Add(HttpRequestHeader.UserAgent, "allan.jiang");
                    wc.Encoding = Encoding.GetEncoding("GB2312");
                    var url = "https://code.aliyun.com/allan.jiang/CNHDT_NEW/tags"; //TODO 修改
                    Thread.Sleep(10);
                    json = Encoding.UTF8.GetString(wc.DownloadData(url));
                    string[] ss = json.Split('\n');
                    bool isStart = false;
                    
                    string retJson = "";

                    foreach (string s in ss)
                    {
                        if (s != null && s.Contains("###start"))
                        {
                            isStart = true;
                            continue;
                        }
                        if (s != null && s.Contains("###end"))
                        {
                            break;
                        }
                        if (isStart)
                        {
                            retJson += s;
                        }
                    }

                    rel = JsonConvert.DeserializeObject<YouaiRelease>(retJson);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            ALog.D("after parser-----");
            rel.Print();
            return rel;
        }

        private void PostToMain(object rel) {
            mCallback.OnEndCallback(rel, true);
        }

        public override void ThreadFunc()
        {
            YouaiRelease ret = GetAllRelease();
            if(ret != null) ret.Print();
            Post(PostToMain, ret);
            mCallback.OnEndCallback(ret, false);
        }
    }
}
