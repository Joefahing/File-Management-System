using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcher
{
    public partial class Service1 : ServiceBase
    {

        FileSystemWatcher watcher;
        string logFilePath = @"C:\Program Files (x86)\uWindsor\FileManagementSystem\Log.txt";
        string trackFilePath = @"C:\Program Files (x86)\uWindsor\FileManagementSystem\Track.txt";

        public Service1()
        {
            InitializeComponent();
        }
      

        protected override void OnStart(string[] args)
        {

            //Creating path to connect to log file

            string trackFilePath = readDirectory();

            if (Directory.Exists(trackFilePath))
            {
                watcher = new FileSystemWatcher(trackFilePath);
                //Setting filter for events that will be notified
                watcher.NotifyFilter = NotifyFilters.LastWrite
                    | NotifyFilters.FileName
                    | NotifyFilters.CreationTime
                    | NotifyFilters.DirectoryName;
                watcher.Changed += new FileSystemEventHandler(OnChanged);
                watcher.Deleted += new FileSystemEventHandler(OnChanged);
                watcher.Created += new FileSystemEventHandler(OnChanged);
                watcher.Renamed += new RenamedEventHandler(OnRenamed);

                //Watches Subdirectories 
                watcher.IncludeSubdirectories = true;
                //Begin watching the event
                watcher.EnableRaisingEvents = true;
            }
            else
            {
                LogEvent("Fail Reading Path From Log File");
            }
        }
        
        protected override void OnStop()
        {
            watcher.EnableRaisingEvents = false;
            watcher.Dispose();
            LogEvent("Monitoring Stop");

             
        }

        //Listener
        void OnChanged(object sender, FileSystemEventArgs e)
        {
            //Changes will be output to windows event log 
            string message = string.Format("File: {0} {1}",
                       e.FullPath, e.ChangeType);
            LogEvent(message);

            //Changes will also be appended to a specific log file
            //string logFilePath = @"C:\Users\Joefa\Documents\Visual Studio 2017\Projects\FileWatcher\FileWatcher\bin\Release\Log.txt";

            //String message
            string logMessage = string.Format("{0} | {1}", e.FullPath, e.ChangeType);
            writeToFile(logMessage);
        }

        void OnRenamed(object source, RenamedEventArgs e)
        {
            //Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
            string message = string.Format("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
            LogEvent(message);

            //New name > oldName
            string logMessage = string.Format("{0} > {1} | Renamed", e.OldFullPath, e.FullPath);
            writeToFile(logMessage);
        }


        //Method create to write to log file 
        private void writeToFile(string message)
        {
            FileStream fs = new FileStream(logFilePath, FileMode.Append, FileAccess.Write);

            using(StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(message);
            }

        }

        private string readDirectory()
        {
            FileStream fs = new FileStream(trackFilePath, FileMode.OpenOrCreate, FileAccess.Read);
            string trackDirectoryName = "";

            using(StreamReader sr = new StreamReader(fs))
            {
                trackDirectoryName = sr.ReadLine();
            }

            return trackDirectoryName;
        }

        private void LogEvent(String message)
        {
            String eventSource = "File Monitor Service";
            DateTime dt = new DateTime();
            dt = System.DateTime.UtcNow;
            message = dt.ToLocalTime() + ": " + message;

            EventLog.WriteEntry(eventSource, message);
        }
    }
}
