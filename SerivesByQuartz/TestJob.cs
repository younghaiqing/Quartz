using log4net1;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerivesByQuartz
{
   public  class TestJob: IJob
    {
        public  Task Execute(IJobExecutionContext context)
        {

            return Task.Factory.StartNew(() => dd());

        }

        public void dd()
        {
            Console.WriteLine("Task调度作业开始");
            // LogManager1.getInstance().InfoFormat("Task调度作业开始");
            LogManager1.InfoFormat("Task调度作业开始");
        }

    }
}
