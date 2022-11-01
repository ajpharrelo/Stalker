using Stalker.Models.Common;
using System.Diagnostics;
using System.Reflection;
using System.Text.Json;

namespace Stalker
{
    public class TProcess : ITProcess
    {
        public enum TProcesssStatus
        {
            notRunning,
            running,
        }

        public Guid ID { get; set; }
        public string Name { get; set; }
        public string? ExecutablePath { get; set; }
        public DateTime StartTime { get; }
        public DateTime ExitTime { get; set; }
        public Process? StalkedProcess { get; set; }

        public TProcesssStatus Status { get; set; }

        public TProcess(){}

        public TProcess(Process process, string name)
        {
            StalkedProcess = process;
            StalkedProcess.EnableRaisingEvents = true;
            Name = name;
            ExecutablePath = process.MainModule?.FileName;
            StartTime = process.StartTime;
        }


        #region Methods
        public static Process? FindProcess(string executableLocation)
        {
            Process[] processList = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(executableLocation));

            foreach (Process p in processList)
            {
                if (p != null && p.MainModule?.FileName == executableLocation)
                    return p;
            }

            return null;
        }

        public static List<TProcess> ReadProcessList(string processListPath)
        {
            if(File.Exists(processListPath))
            {
                List<TProcess> processList = new List<TProcess>();

                using(StreamReader sr = File.OpenText(processListPath))
                {
                    // ERROR
                    // Each field in TProcess must be assigned in constructor
                    TProcess[]? processes = JsonSerializer.Deserialize<TProcess[]>(sr.ReadToEnd());
                    foreach (TProcess p in processes)
                    {
                        if (p != null)
                            processList.Add(p);
                    }
                    return processList;
                }
                
            }
            else
            {
                Console.WriteLine("Process list file not found at " + processListPath);
                return null;
            }
        }
        #endregion
    }
}
