using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Configuration;
using System.Timers;

namespace MyWindowServicePlayGround
{
    public partial class MyWindowServicePlayGround : ServiceBase
    {
        private Task _playGroundServiceTask;

        public MyWindowServicePlayGround()
        {
            InitializeComponent();

            MyWindowsServicePlayGourndLog = new EventLog();

            if (!EventLog.SourceExists("My Windows Service Play Ground Service")) ;
            {
                EventLog.CreateEventSource("My Windows Service Play Ground Service", "MyWindowsServicePlayGourndLog");
            }

            MyWindowsServicePlayGourndLog.Source = "My Windows Service Play Ground Service";
            MyWindowsServicePlayGourndLog.Log = "";
        }

        protected override void OnStart(string[] args)
        {
            Thread.Sleep(10000);
            int playGoundServiceScanInterval = 3600000;
            if (!(string.IsNullOrEmpty(ConfigurationManager.AppSettings["PlayGoundServiceScanInterval"])))
            {
                if(!int.TryParse(ConfigurationManager.AppSettings["PlayGoundServiceScanInterval"],out playGoundServiceScanInterval))
                {
                    playGoundServiceScanInterval = 3600000;
                }
            }

            System.Timers.Timer taskScanTimer = new System.Timers.Timer();
            taskScanTimer.Interval = playGoundServiceScanInterval;
            taskScanTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTaskTimer);
            taskScanTimer.Start();
        }

        private void OnTaskTimer(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void OnStop()
        {
        }
    }
}
