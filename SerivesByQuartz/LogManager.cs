using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4net1
{
    /// <summary>
    /// 定义系统日志管理器
    /// </summary>
    public  class LogManager1
    {

        /// <summary>
        /// 参考文件：
        /// https://blog.csdn.net/qdluo/article/details/75501204
        /// https://blog.csdn.net/yhyhyhy/article/details/52743423
        /// https://blog.csdn.net/tongdengquan/article/details/52457248
        /// https://blog.csdn.net/binnygoal/article/details/79557746
        /// </summary>

        private static log4net.ILog logger = null;
        private static LogManager1 instance = new LogManager1();//一大部分减少多实例问题

        private LogManager1()
        {
            //第二种方式把直接把配置文件放在app.config中
            logger = log4net.LogManager.GetLogger("default");  // GetLogger("default");
        }

        
        //private LogManager1()
        //{
        //    //第一种方式把log4net.config文件放在提取出来，每次调用的时候进来
        //    // string configfile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log4net.config");
        //    // log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(configfile));
        //    logger = log4net.LogManager.GetLogger("default");  // GetLogger("default");
        //}


        /// <summary>
        /// 记录INFO级别信息
        /// </summary>
        /// <param name="info"></param>
        /// <param name="exception"></param>
        public void Info(string info, Exception exception = null)
        {
            if (exception == null) logger.Info(info);
            else logger.Info(info, exception);
        }

        /// <summary>
        /// 记录INFO级别信息
        /// </summary>
        /// <param name="info"></param>
        /// <param name="exception"></param>
        public void InfoObject(object info, Exception exception = null)
        {
            if (exception == null) logger.Info(info);
            else logger.Info(info, exception);
        }

        /// <summary>
        /// 格式化记录INFO级别信息
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void InfoFormat(string format, params object[] args)
        {
            logger.InfoFormat(format, args);
        }

        /// <summary>
        /// 记录错误信息
        /// </summary>
        /// <param name="info"></param>
        /// <param name="exception"></param>
        public static void Error(string info, Exception exception = null)
        {
            if (exception == null) logger.Error(info);
            else logger.Error(info, exception);
        }

        /// <summary>
        /// 格式化记录错误信息
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void ErrorFormat(string format, params object[] args)
        {
            logger.ErrorFormat(format, args);
        }

        /// <summary>
        /// 记录警告级别信息
        /// </summary>
        /// <param name="info"></param>
        /// <param name="exception"></param>
        public static void Warn(string info, Exception exception = null)
        {
            if (exception == null) logger.Warn(info);
            else logger.Warn(info, exception);
        }

        /// <summary>
        /// 格式化记录警告信息
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void WarnFormat(string format, params object[] args)
        {
            logger.WarnFormat(format, args);
        }

        /// <summary>
        /// 记录调试级别信息
        /// </summary>
        /// <param name="info"></param>
        /// <param name="exception"></param>
        public static void Debug(string info, Exception exception = null)
        {
            if (exception == null) logger.Debug(info);
            else logger.Debug(info, exception);
        }

        /// <summary>
        /// 格式化记录调试信息
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void DebugFormat(string format, params object[] args)
        {
            logger.DebugFormat(format, args);
        }

        /// <summary>
        /// 记录致命级别信息
        /// </summary>
        /// <param name="info"></param>
        /// <param name="exception"></param>
        public static void Fatal(string info, Exception exception = null)
        {
            if (exception == null) logger.Fatal(info);
            else logger.Fatal(info, exception);
        }

        /// <summary>
        /// 格式化记录致命信息
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public static void FatalFormat(string format, params object[] args)
        {
            logger.FatalFormat(format, args);
        }
    }
}
