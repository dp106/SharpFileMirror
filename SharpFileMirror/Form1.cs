using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;
using System.Security.Permissions;

namespace SharpFileMirror
{
    
    public partial class Form1 : Form
    {
        private string lastFile;
        private int selectedRow;
        private string AppName = "SharpFileMirror";
        private string appPath;
        private string XMLFile;
        private List<string> monitoredFolders = new List<string>();
        private List<string> inProgressFiles = new List<string>;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            appPath = Application.ExecutablePath;
            int lastSlash = appPath.LastIndexOf("\\");
            appPath = appPath.Substring(0, lastSlash+1);
            XMLFile = appPath + "XMLFile1.xml";
            //Console.WriteLine(appPath);
            
            if (File.Exists(XMLFile))
            {
                dataSet1.ReadXml(XMLFile);
            }
            progresslabel.Visible = false;
            progresslabel.Text = "";
            copyProgressBar.Visible = false;
            copyProgressBar.Value = 0;
            buttonSave.Visible = false;
            buttonUndo.Visible = false;
            lastFile = "";

            getDistinctFolders();

            monitorFolders();
            //backgroundWorkerFileMonitor.RunWorkerAsync();

        }
        private void button1_Click(object sender, EventArgs e)
        { }

        private void doFileWork() { 
            List<filePair> fileList = new List<filePair>();

            
            foreach(DataGridViewRow dr in dataGridView1.Rows)
            {                
                string source = dr.Cells[0].Value.ToString();
                string destination = dr.Cells[1].Value.ToString();
                string filter = dr.Cells[2].Value.ToString();

                Console.WriteLine("Source: " + source);
                Console.WriteLine("Destination: " + destination);
                Console.WriteLine("Filter: " + filter);

                //DriveInfo di = new System.IO.DriveInfo(@source);
                DirectoryInfo dirInfo = new DirectoryInfo(source);
                Console.WriteLine(dirInfo.Attributes.ToString());

                // Get the files in the directory and print out some information about them.
                System.IO.FileInfo[] fileNames = dirInfo.GetFiles(filter);

                //  THIS IS A METHOD FOR SEARCHING MULTIPLE FILES BUT I HAVE DECIDED TO USE THE PREVIOUS ONE AND DO ONE EXTENSION AT A TIME
                //  var files = Directory.EnumerateFiles(source, "*.*", SearchOption.AllDirectories)
                //          .Where(s => s.EndsWith(".mp4") || s.EndsWith(".MOV") || s.EndsWith(".wmv"));

                foreach(FileInfo fi in fileNames)
                {
                    filePair fp = new filePair();
                    fp.source = fi;
                    fp.destination = destination;
                    fileList.Add(fp);
                }                
            }

            // MoveTime();
            progresslabel.Visible = true;
            copyProgressBar.Visible = true;

            moveFile MF = new moveFile();
            MF.fileList = fileList;

            // Start the asynchronous operation.
            backgroundWorker1.RunWorkerAsync(MF);
            lastFile = "";

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // This event handler is where the actual work is done.
            // This method runs on the background thread.

            // Get the BackgroundWorker object that raised this event.
            System.ComponentModel.BackgroundWorker worker;
            worker = (System.ComponentModel.BackgroundWorker)sender;

            // Get the Words object and call the main method.
            moveFile MF = (moveFile)e.Argument;
            MF.moveF(worker, e);
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            moveFile.CurrentState state =
                (moveFile.CurrentState)e.UserState;
            progresslabel.Text = "Copying " + state.fileCopying;
            this.copyProgressBar.Value = state.copyProgress;
           
            if (state.fileCompleted != lastFile & !(state.fileCompleted is null)) {
                statusTextBox.Text += state.fileCompleted + " moved in  " +state.fileCopytime + "\r\n";
                lastFile = state.fileCompleted;
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // This event handler is called when the background thread finishes.
            // This method runs on the main thread.
            if (e.Error != null)
                MessageBox.Show("Error: " + e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("File copy canceled.");
            else
                MessageBox.Show("Finished copy.");
            progresslabel.Visible = false;
            copyProgressBar.Visible = false;

        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormNew fn = new FormNew(dataSet1);
            fn.Show();
            buttonSave.Visible = true;
            buttonUndo.Visible = true;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataSet1.TableConfigItems.Rows.RemoveAt(selectedRow);
            buttonSave.Visible = true;
            buttonUndo.Visible = true;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rc = dataGridView1.SelectedRows;

            foreach(DataGridViewRow  dr in rc)
            {
                Console.WriteLine("Index: " + dr.Index.ToString());
                selectedRow = dr.Index;
            }
            
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            dataSet1.WriteXml(XMLFile);
            buttonSave.Visible = false;
            buttonUndo.Visible = false;
        }
        private void buttonUndo_Click(object sender, EventArgs e)
        {
            dataSet1.TableConfigItems.Clear();
            dataSet1.ReadXml(XMLFile);
            buttonSave.Visible = false;
            buttonUndo.Visible = false;
        }
        private void buttonModify_Click(object sender, EventArgs e)
        {
            FormNew fn = new FormNew(dataSet1);
            fn.modifyRow = true;
            fn.selectedRow = selectedRow;
            fn.Show();
            buttonSave.Visible = true;
            buttonUndo.Visible = true;
        }
        private void runOnStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (runOnStartupToolStripMenuItem.Checked) {
                rk.SetValue(AppName, Application.ExecutablePath.ToString());
            } else {
                rk.DeleteValue(AppName, false);
            }

        }

        private void getDistinctFolders() {
            DataRow[] drArray = dataSet1.TableConfigItems.Select();
            monitoredFolders.Clear();
            foreach(DataRow dr in drArray)
            {                
                if(!(monitoredFolders.Contains(dr.ItemArray.GetValue(1).ToString()))) {
                    monitoredFolders.Add(dr.ItemArray.GetValue(1).ToString());
                }
            }
            
        }
        
        //  FILE WATCHER CODE BELOW
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private void monitorFolders()
        {

            foreach (string monitoredFolder in monitoredFolders)
            {
                // Create a new FileSystemWatcher and set its properties.
                FileSystemWatcher watcher = new FileSystemWatcher();
                watcher.Path = monitoredFolder;
                /* Watch for changes in LastAccess and LastWrite times, and
                   the renaming of files or directories. */
                watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                   | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                // Only watch text files.
                watcher.Filter = "*.*";

                // Add event handlers.
                watcher.Changed += new FileSystemEventHandler(OnChanged);
                watcher.Created += new FileSystemEventHandler(OnChanged);
                watcher.Deleted += new FileSystemEventHandler(OnChanged);
                watcher.Renamed += new RenamedEventHandler(OnRenamed);

                // Begin watching.
                watcher.EnableRaisingEvents = true;

                //// Wait for the user to quit the program.
                //Console.WriteLine("Press \'q\' to quit the sample.");
                //while (Console.Read() != 'q') ;
            }
        }
        // Define the event handlers.
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            // Specify what is done when a file is changed, created, or deleted.
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
            
        }
        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            // Specify what is done when a file is renamed.
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }


        protected virtual bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }
    }

    public class filePair
    {
        // obviously you find meaningful names of the 2 properties

        public FileInfo source { get; set; }
        public string destination { get; set; }
    }


}
