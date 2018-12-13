using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace MusicStore
{
    /// <summary>
    /// 对内存中的Guid值加锁处理，防止进程互斥
    /// </summary>
    public class LockHelp
    {
        public static Mutex _Mutex = new Mutex();
        private static readonly Dictionary<Guid, SemaphoreSlim> _Slim = new Dictionary<Guid, SemaphoreSlim>();
        private static readonly Dictionary<Guid, int> _Count = new Dictionary<Guid, int>();

        /// <summary>
        /// 加锁
        /// </summary>
        /// <param name="id">主键</param>
        public static void ThreadLock(Guid id)
        {
            _Mutex.WaitOne();
            SemaphoreSlim Slim;
            if (!_Slim.TryGetValue(id, out Slim))
            {
                Slim = new SemaphoreSlim(1);
                _Slim.Add(id, Slim);
                _Count.Add(id, 0);
            }
            _Count[id]++;
            _Mutex.ReleaseMutex();
            Slim.Wait();

        }
        /// <summary>
        /// 解锁
        /// </summary>
        /// <param name="id">主键</param>
        public static void ThreadUnLocked(Guid id)
        {

        }
    }
}