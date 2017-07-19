using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SharpFileMirror
{
    public class moveFile
    {

        public class CurrentState
        {
            public int copyProgress;
            public string fileCopying;
            public string fileCompleted;
            public string fileCopytime;
        }


        ////public string source;
        //public string destination;
        ////public double fileLength;
        //public FileInfo[] fileNames;
        public List<filePair> fileList;

        public void moveF(
            System.ComponentModel.BackgroundWorker worker,
            System.ComponentModel.DoWorkEventArgs e)
        {
            // Initialize the variables.
            CurrentState state = new CurrentState();



            foreach(filePair fp in fileList)
            {
                Console.WriteLine("{0}: {1}: (2)", fp.source.FullName, fp.source.LastAccessTime, fp.source.Length);
                string timeToCopyMessage;
                int timeToCopy = 0;
                timeToCopy = MoveTime(worker, fp.source.FullName, fp.destination + fp.source.Name, fp.source.Length);

                if (timeToCopy < 1000)
                {
                    timeToCopyMessage = timeToCopy.ToString() + " milliseconds";
                }
                else if (timeToCopy >= 1000 & timeToCopy < 60000)
                {
                    timeToCopyMessage = (timeToCopy / 1000).ToString() + " seconds";
                }
                else
                {
                    timeToCopyMessage = (timeToCopy / 1000 / 60).ToString() + " minutes";
                }
                state.fileCompleted = fp.source.Name;
                state.fileCopytime = timeToCopyMessage;
                worker.ReportProgress(100, state);
            }            
        }
        public int MoveTime(System.ComponentModel.BackgroundWorker worker, string source, string destination, long fileLength)
        {
            DateTime start_time = DateTime.Now;
            FMove(worker, source, destination, fileLength);
            long size = new FileInfo(destination).Length;
            int milliseconds = 1 + (int)((DateTime.Now - start_time).TotalMilliseconds);

            // size time in milliseconds per hour
            long tsize = size * 3600000 / milliseconds;
            tsize = tsize / (int)Math.Pow(2, 30);
            Console.WriteLine(tsize + "GB/hour");
            return milliseconds;
        }
        private void FMove(System.ComponentModel.BackgroundWorker worker, string source, string destination, double fileLength)
        {
            CurrentState state = new CurrentState();
            int array_length = 524288; //512kb
            double copiedSoFar = 0;
            byte[] dataArray = new byte[array_length];
            using (FileStream fsread = new FileStream
            (source, FileMode.Open, FileAccess.Read, FileShare.None, array_length))
            {
                using (BinaryReader bwread = new BinaryReader(fsread))
                {
                    using (FileStream fswrite = new FileStream
                    (destination, FileMode.Create, FileAccess.Write, FileShare.None, array_length))
                    {
                        using (BinaryWriter bwwrite = new BinaryWriter(fswrite))
                        {
                            for (;;)
                            {
                                int read = bwread.Read(dataArray, 0, array_length);
                                if (0 == read)
                                    break;
                                bwwrite.Write(dataArray, 0, read);
                                copiedSoFar += 524288;
                                double progress = ((copiedSoFar / fileLength));
                                int intProgress = Convert.ToInt32(progress * 100);
                                //Console.WriteLine("Progress as an int is {0}", intProgress);
                                //Console.WriteLine(String.Format("{0:p2}", progress));
                                state.copyProgress = intProgress;
                                state.fileCopying = source;
                                worker.ReportProgress(0, state);
                            }
                        }
                    }
                }
            }
            File.Delete(source);
        }


    }
}
