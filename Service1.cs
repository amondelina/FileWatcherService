﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcherService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
            AutoLog = true;
            CanStop = true;
            CanPauseAndContinue = true;
           
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }

       
    }
}
