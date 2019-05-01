using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileWatcherInterface
{
    public partial class ExportControl : UserControl

    {
        private string exportFromPath
        {
            get
            {
                return exportfromTextField.Text;
            }
        }

        private string exportToPath
        {
            get
            {
                return exportToTextField.Text;
            }
        }

        private string exportFilePath
        {
            get
            {
                return Path.Combine(exportFromPath, "Export.txt");
            }
        }

        private string destExportFilePath
        {
            get
            {
               string simplePath = Path.Combine(exportToPath, Path.GetFileName(exportFromPath));
               return Path.Combine(simplePath, "Export.txt");
            }
        }

        private string exportRecordPath
        {
            get
            {
                return @"C:\Program Files (x86)\uWindsor\FileManagementSystem\ExportRecord.txt";
            }
        }


        public ExportControl()
        {
            InitializeComponent();
        }


        private void ExportControl_Load(object sender, EventArgs e)
        {
            loadTextField();
            if (exportFromPath.Equals("") && exportToPath.Equals(""))
                exportButton.Enabled = false;
            
        }


        private void exportFromButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                exportfromTextField.Text = fbd.SelectedPath;
                openFile(fbd.SelectedPath, exportRecordPath);
                writeToLog(exportToTextField.Text, exportRecordPath);
            }

            if (!exportFromPath.Equals("") && !exportToPath.Equals(""))
                exportButton.Enabled = true;

        }

        private void ExportToButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if(fbd.ShowDialog() == DialogResult.OK)
            {
                exportToTextField.Text = fbd.SelectedPath;
                openFile(exportfromTextField.Text, exportRecordPath);
                writeToLog(fbd.SelectedPath, exportRecordPath);
            }

            if (!exportFromPath.Equals("") && !exportToPath.Equals(""))
                exportButton.Enabled = true;
        }

        //This function has to be edited because in case the export file is missing, we to give
        //user some methods of recovery
        private void exportButton_Click(object sender, EventArgs e)
        {
           
            //If export file is not present in exportFromPath, then give a alert message to copy 

            string targetFileName = Path.GetFileName(exportFromPath);
            string fullExportToPath = Path.Combine(exportToPath, targetFileName);

            if (!Directory.Exists(fullExportToPath))
            {
                DirectoryCopy(exportFromPath, fullExportToPath);
                progBar.Value = 100;
                if (progBar.Value == 100)
                {
                    MessageBox.Show("Copy Complete !");
                    progBar.Value = 0;
                }
            }

            else
            {
                if (!File.Exists(exportFilePath))
                {
                    MessageBox.Show("Missing Export File", "Error");

                }
                else
                {
                    processExportFile(fullExportToPath);
                    File.Delete(exportFilePath);
                    File.Delete(destExportFilePath);
                    progBar.Value = 100;
                    if (progBar.Value == 100)
                    {
                        MessageBox.Show("Copy Complete !");
                        progBar.Value = 0;
                    }
                }
            }
            
        }

        private void processExportFile(string destinationPath)
        {

            FileStream fs = new FileStream(exportFilePath, FileMode.OpenOrCreate, FileAccess.Read);
            

            using(StreamReader sr = new StreamReader(fs))
            {
                string update;


                while((update = sr.ReadLine()) != null)
                {
                    if (update.Equals(""))
                        continue;

                    try
                    {
                        int filePost = update.IndexOf('|');
                        string file = update.Substring(0, filePost - 1);
                        string fileStatus = update.Substring(filePost + 2);

                        updateFile(destinationPath, file, fileStatus);

                    }
                    catch(IOException exception)
                    {
                        Console.WriteLine(exception);
                        Console.WriteLine("Fail processing line: " + update);
                    }
                }
            }
        }

        private void updateFile(string destinationPath , string rawFilePath, string fileStatus)
        {
            if (!fileStatus.Equals("Renamed"))
            {
                var fullDestPath = System.IO.Path.Combine(destinationPath, rawFilePath);
                var sourceFile = System.IO.Path.Combine(exportFromPath, rawFilePath);
                var tempDirectory = fullDestPath;
                Boolean isFile = false;

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
                int renamePost = rawFilePath.IndexOf('>');
                string oldPath = Path.Combine(destinationPath, rawFilePath.Substring(0, renamePost - 1));
                string newPath = Path.Combine(destinationPath, rawFilePath.Substring(renamePost + 2));
                //newSourcePath is used in case the destination old path does not exist and the path needs to be copied from
                //source path instead
                string newSourcePath = Path.Combine(exportFromPath, newPath);

               

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
                        Directory.Delete(newPath, true);

                    if (Directory.Exists(oldPath))
                    {
                        Directory.Move(oldPath, newPath);
                    }
                    //Might have to be updated
                    else if (Directory.Exists(newSourcePath))
                    {
                        DirectoryCopy(newSourcePath, newPath);
                    }
                }
            }
        }

     
        //destination example Desktop/499 where 499 is appended
        private static void DirectoryCopy(string sourceName, string destinationName)
        {
            DirectoryInfo info = new DirectoryInfo(sourceName);
            DirectoryInfo[] dirs = info.GetDirectories();
            FileInfo[] files = info.GetFiles();

            if (!Directory.Exists(destinationName)) 
             Directory.CreateDirectory(destinationName);

            foreach(FileInfo file in files)
               file.CopyTo(Path.Combine(destinationName, file.Name), true);
            
            foreach(DirectoryInfo subdir in dirs)
            {
                DirectoryCopy(subdir.FullName, Path.Combine(destinationName, subdir.Name));
            }
        }


        private void loadTextField()
        {
            FileStream fs = new FileStream(exportRecordPath, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                var sourceFilePath = sr.ReadLine();
                var destinationFilePath = sr.ReadLine();

                if (sourceFilePath != null && Directory.Exists(sourceFilePath))
                {
                    exportfromTextField.Text = sourceFilePath;
                }

                if (destinationFilePath != null && Directory.Exists(destinationFilePath))
                {
                    exportToTextField.Text = destinationFilePath;
                }

            }
        }

        private void openFile(string message, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);

            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(message);
            }

        }

        private void writeToLog(string message, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(message);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    
}
