using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading;


namespace FileWatcherInterface
{
    public partial class ImportFileControl : UserControl
    {
        private string trackFilePath {
            get
            {
                return directoryTextBox.Text;
            }
        }

        private string resultFilePath
        {
            get
            {
                return exportFileTextField.Text;
            }
        }


        //Directory has to be changed to relative directory 
        private string logFilePath
        {
            get
            {
                return @"C:\Program Files (x86)\uWindsor\FileManagementSystem\Log.txt";
            }
        }
        private string recordFilePath
        {
            get
            {
                return @"C:\Program Files (x86)\uWindsor\FileManagementSystem\Record.txt";
            }
        }

        private string targetFilePath
        {
            get
            {
                return @"C:\Program Files (x86)\uWindsor\FileManagementSystem\Track.txt";
            }
        }

   
        public ImportFileControl()
        {
            InitializeComponent();
        }


        private void ImportFileControl_Load(object sender, EventArgs e)
        {


            if (loadTextField())
            {
                openFile(trackFilePath, logFilePath);
                startWindowService();
            }
         
        }


        private void ImportFileControl_Leave(object sender, EventArgs e)
        {
            stopWindowService();
        }


        private void selectFileButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

          

            if(fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                directoryTextBox.Text = fbd.SelectedPath;

                //record the location of source and destination 
                openFile(fbd.SelectedPath, recordFilePath);
                writeToLog(resultFilePath, recordFilePath);

                openFile(fbd.SelectedPath, targetFilePath);
                writeToLog(fbd.SelectedPath, logFilePath);
                

                //Reboot window service
                stopWindowService();
                Task.Delay(1000).Wait();
                startWindowService();
                
                  
            }
        }

        private void exportFileButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                exportFileTextField.Text = fbd.SelectedPath;

                openFile(trackFilePath, recordFilePath);
                writeToLog(resultFilePath, recordFilePath);


            }
        }

              

        //Process and export the result of log file to another directory selected by user
        private void exportToFileButton_Click(object sender, EventArgs e)
        {
            if((!trackFilePath.Equals("") && !resultFilePath.Equals("")) 
                && (Directory.Exists(trackFilePath) && Directory.Exists(resultFilePath)))
            {
                processLogFile();
                openFile(trackFilePath, logFilePath);

                progBar.Value = 100;
                if (progBar.Value == 100)
                {
                    MessageBox.Show("Copy Complete !");
                    progBar.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("Invalid Paths");
            }
           
     
        }


        //Everytime the window service starts, system will append the newest Track File Path to log file 
        private void startWindowService()
        {
            
            ServiceController service = new ServiceController("File Management System");
            service.Start();
            
        }

        //Stop Window Service from running
        private void stopWindowService()
        {
            ServiceController service = new ServiceController("File Management System");
            if(service.Status == ServiceControllerStatus.Running)
            {
                service.Stop();
            }
        }

        private void openFile(string message, string path) 
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);

            using(StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(message);
            }
            
        }

        private void writeToLog(string message, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            using(StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(message);
            }
        }



        //readLogFile() changes to processLogFile()
        private void processLogFile()
        {


            FileStream fs = new FileStream(logFilePath, FileMode.OpenOrCreate, FileAccess.Read);

            using (StreamReader sr = new StreamReader(fs))
            {
                String updates;
                String fullDestPath = "";


                while ((updates = sr.ReadLine()) != null)
                {
                    if (updates.Equals(""))
                        continue;


                    if (Directory.Exists(updates))
                    {
                        var incomplete_targetFile = updates;
                         fullDestPath = Path.Combine(resultFilePath, getFolderName(incomplete_targetFile));

                        if (!Directory.Exists(fullDestPath))
                        {
                            DirectoryCopy(trackFilePath, fullDestPath);
                        }
                            

                        if (!File.Exists(fullDestPath + "\\Export.txt"))
                            openFile("", fullDestPath + "\\Export.txt");


                        continue;
                    }
                  

                    string tempChanges = updates.Replace(trackFilePath + "\\", "");

                    writeToLog(tempChanges, fullDestPath + "\\Export.txt");

                    try
                    {
                        int filePost = updates.IndexOf('|');
                        string path = updates.Substring(0, filePost - 1);
                        string fileName = path.Replace(trackFilePath + "\\", "");

                        string fileStatus = updates.Substring(filePost + 2);


                        exportFile(fullDestPath, fileStatus, fileName);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e);
                    }
                   
                }
            }
        }


        //Note: There might be bug with reading empty file
        private Boolean loadTextField()
        {
            bool result1 = false;

            FileStream fs = new FileStream(recordFilePath, FileMode.OpenOrCreate, FileAccess.Read);
            using(StreamReader sr = new StreamReader(fs))
            {
                var sourceFilePath = sr.ReadLine();
                var destinationFilePath = sr.ReadLine();

                if (sourceFilePath != null && Directory.Exists(sourceFilePath))
                {
                    directoryTextBox.Text = sourceFilePath;
                    result1 = true;
                }
                else
                    openFile("", logFilePath);

                if (destinationFilePath != null && Directory.Exists(destinationFilePath))
                {
                    exportFileTextField.Text = destinationFilePath;
                }
            }

            return result1;
        }


        //Need to implement features if directory does not exist 
        private void exportFile(string destPath, string fileStatus, string fileName)
        {

            if (!fileStatus.Equals("Renamed"))
            {
                var fullDestPath = System.IO.Path.Combine(destPath, fileName);
                var sourceFile = System.IO.Path.Combine(trackFilePath, fileName);
                var tempDirectory = fullDestPath;
                Boolean isFile = false;

                //Create temperarey varaible to store the directory and check to see if 
                //path is file or directory

                if (Path.HasExtension(fullDestPath))
                {
                    tempDirectory = Path.GetDirectoryName(fullDestPath);
                    isFile = true;
                }

                if (fileStatus.Equals("Changed") || fileStatus.Equals("Created"))
                {

                    if (!Directory.Exists(tempDirectory))
                    {
                        Directory.CreateDirectory(tempDirectory);
                    }

                    if (File.Exists(sourceFile) && isFile)
                    {
                        File.Copy(sourceFile, fullDestPath, true);
                    }
                }

                else if (fileStatus.Equals("Deleted"))
                {
                    //If path is a file and there is something to remove in destination path
                    if (isFile && File.Exists(fullDestPath))
                    {
                        try
                        {
                            File.Delete(fullDestPath);
                        }
                        catch (System.IO.IOException e)
                        {
                            Console.WriteLine(e);
                            Console.WriteLine("Trouble removing file: " + fullDestPath);
                        }
                    }

                    else if (Directory.Exists(tempDirectory))
                    {
                        try
                        {
                            Directory.Delete(tempDirectory, true);
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine(e);
                            Console.WriteLine("Trouble removing directory: " + tempDirectory);
                        }
                    }
                }
            }
           
            else if (fileStatus.Equals("Renamed"))
            {
                int renamePost = fileName.IndexOf('>');
                string oldPath = Path.Combine(destPath, fileName.Substring(0, renamePost - 1));
                string newPath = Path.Combine(destPath, fileName.Substring(renamePost + 2));
                //newSourcePath is used in case the destination old path does not exist and the path needs to be copied from
                //source path instead
                string newSourcePath = Path.Combine(trackFilePath, fileName.Substring(renamePost + 2));

                Boolean isFile = false;

                if (Path.HasExtension(newPath))
                    isFile = true;

                if (isFile)
                {

                    Console.WriteLine("Renaming file: " + oldPath);
                    if (File.Exists(newPath))
                        File.Delete(newPath);

                    if (File.Exists(oldPath))
                    {
                        File.Move(oldPath, newPath);
                    }
                    else if (File.Exists(newSourcePath))
                    {
                        Console.WriteLine("Copy file from" + newSourcePath + " To " + newPath);
                        File.Copy(newSourcePath, newPath);
                    }
                }

                else
                {
                    if (Directory.Exists(newPath))
                        Directory.Delete(newPath,true);

                    if (Directory.Exists(oldPath))
                    {
                        Directory.Move(oldPath, newPath);
                    }
                    //Might have to be updated
                    else if(Directory.Exists(newSourcePath))
                    {
                        Directory.Move(newSourcePath, newPath);
                    }
                }
            }

     
        }

        private static void DirectoryCopy(string sourceName, string destinationName)
        {
            DirectoryInfo info = new DirectoryInfo(sourceName);
            DirectoryInfo[] dirs = info.GetDirectories();
            FileInfo[] files = info.GetFiles();

            if (!Directory.Exists(destinationName))
                Directory.CreateDirectory(destinationName);

            foreach (FileInfo file in files)
                file.CopyTo(Path.Combine(destinationName, file.Name), true);

            foreach (DirectoryInfo subdir in dirs)
            {
                DirectoryCopy(subdir.FullName, Path.Combine(destinationName, subdir.Name));
            }
        }

        private string getFolderName(string path)
        {
            return new DirectoryInfo(path).Name;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void progBar_Click(object sender, EventArgs e)
        {

        }
    }
}
