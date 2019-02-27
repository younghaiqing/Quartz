using log4net1;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerivesByQuartz
{
    public class Scheduler
    {
        private static IScheduler scheduler;
        public static IScheduler Current
        {
            get
            {
                if (scheduler == null)
                {
                    scheduler = StdSchedulerFactory.GetDefaultScheduler().Result;
                }
                return scheduler;
            }
        }

        /// <summary>
        /// 启动程序
        /// </summary>
        public void Start()
        {
            Current.Start();
        }

        /// <summary>
        /// 停止程序
        /// </summary>
        public void Stop()
        {
         //   LogManager1.getInstance().InfoFormat("停止服务");
            Current.Shutdown();
        }

        /// <summary>
        /// 重启程序
        /// </summary>
        public void Restart()
        {
          //  LogManager1.getInstance().InfoFormat("重新启动");
            Current.Shutdown();
            scheduler = null;
            Current.Start();
        }
    }
}
