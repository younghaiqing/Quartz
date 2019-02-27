using log4net1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace SerivesByQuartz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //  LogManager1.getInstance().InfoFormat("{0}", "服务开始运行");
                LogManager1.InfoFormat("服务开始运行1111111");
                LogManager1.InfoFormat("服1111始运行1111111");
                HostFactory.Run(x =>
                {
                    x.Service<give>(s =>
                    {
                        s.ConstructUsing(name => new give());
                        s.WhenStarted(tc => tc.Start());
                        s.WhenStopped(tc => tc.Stop());
                        s.WhenShutdown(tc => tc.Shutdown());

                    });
                    x.RunAsLocalSystem();
                    x.SetDescription("测试服务");//服务描述
                    x.SetDisplayName("Test.Quart");//显示服务名
                    x.SetServiceName("TestQuart");//服务名称
                });
              //  LogManager1.getInstance().InfoFormat("服务启动完成");
                LogManager1.InfoFormat("服务启动完成");
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("服务启动失败,原因:{0}", ex.ToString()));
            }

            new Scheduler().Start();
            Console.ReadKey();
        }
        /// <summary>
        /// 服务要跑的内容
        /// </summary>
        class give
        {
            public void Start()
            {
                try
                {
                    new Scheduler().Start();//调度启动方法
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                Console.WriteLine("执行Start方法,启动成功");
               // LogManager1.getInstance().InfoFormat("Start");
            }
            public void Stop()
            {
                new Scheduler().Stop();//调度启动方法
               // LogManager1.getInstance().InfoFormat("Stop");
            }
            public void Shutdown()
            {
              //  LogManager1.getInstance().InfoFormat("Shutdown");
            }

            
        }
    }
}
