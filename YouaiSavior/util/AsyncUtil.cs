
using System.Threading;

namespace YouaiSavior
{
    abstract public class AsyncUtil
    {
        public interface IAsyncCallback {
            /// <summary>
            /// 父类中只给一个回调。AsyncUtil子类可以继续添加
            /// </summary>
            /// <param name="info">返回结果体 自行转换</param>
            /// <param name="inCallThread">是否是在调用线程中</param>
            void OnEndCallback(object info, bool inCallThread);
        }

        public AsyncUtil() {
        }

        private SynchronizationContext m_SyncContext = null;
        protected IAsyncCallback mCallback;

        public abstract void ThreadFunc();

        public void Post(SendOrPostCallback func, object o) {
            m_SyncContext.Post(func, o);
        }

        public void Send(SendOrPostCallback func, object o)
        {
            m_SyncContext.Post(func, o);
        }

        public void Start(IAsyncCallback callback)
        {
            mCallback = callback;
            m_SyncContext = SynchronizationContext.Current;

            Thread th = new Thread(new ThreadStart(ThreadFunc));
            th.Start();
        }
    }
}
