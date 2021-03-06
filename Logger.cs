﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWatcherService
{
    class Logger
    {
        public LoggerOptions Options { get; set; }
        public Logger(LoggerOptions options)
        {
          
            Options = options;
            RecordEntry($"Файл лога {Path.GetFileName(Options.Path)} создан");

        }
        public async Task RecordEntry(string entry)
        {
            using (var writer = new StreamWriter(Options.Path, true))
            {
                await writer.WriteLineAsync($"{entry} {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")}");
                await writer.FlushAsync();
            }
        }
    }
}
