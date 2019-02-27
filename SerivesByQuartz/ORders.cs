using log4net1;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerivesByQuartz
{
    public class ORders : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            Task task = null;
            Console.WriteLine("wewr");
            return task;
        }


    }
}
