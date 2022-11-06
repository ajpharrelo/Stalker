using Stalker.Models;
using System.Diagnostics;
using System.Net.Security;
using System.Text.Json;

namespace Stalker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private List<TProcess> stalkedProcesses = new List<TProcess>();
        private List<TProcessSession>? sessions = new List<TProcessSession>();

        string sessionListPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Stalker\sessions.json";

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // Read existing sessions to be appended with new sessions
            sessions = TProcessSession.ReadSessionList(sessionListPath);

            // Read existing list of executables to stalk
            string processListFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Stalker\list.json";
            stalkedProcesses = TProcess.ReadProcessList(processListFile);


            while (!stoppingToken.IsCancellationRequested)
            {

                foreach (TProcess process in stalkedProcesses)
                {
                    if(process.ExecutablePath != null)
                    {
                        Process? newProcess = TProcess.FindProcess(process.ExecutablePath);

                        if (newProcess != null)
                        {
                            if (process.Status == TProcess.TProcesssStatus.notRunning)
                            {
                                _logger.LogInformation($"{Path.GetFileNameWithoutExtension(newProcess.MainModule?.FileName)} Start time: {newProcess.StartTime.ToString("HH:mm:ss")}");
                                process.StalkedProcess = newProcess;
                                process.Status = TProcess.TProcesssStatus.running;

                                process.StalkedProcess.Exited += StalkedProcess_Exited;
                                process.StalkedProcess.EnableRaisingEvents = true;
                            }
                        }
                    }
                }

                await Task.Delay(2500, stoppingToken);
            }    
        }

        private void StalkedProcess_Exited(object? sender, EventArgs e)
        {
            if(sender != null)
            {
                Process p = (Process)sender;
                if (p != null)
                {
                    TProcess? findProcess = stalkedProcesses.Find(x => x.StalkedProcess == p);
                    _logger.LogInformation($"{findProcess?.Name} exited at {p?.ExitTime.ToString("HH:mm:ss")}");


                    if (findProcess == null) throw new Exception("Could not find exited process.");

                    findProcess.Status = TProcess.TProcesssStatus.notRunning;

                    TProcessSession processSession = new TProcessSession
                    {
                        ID = findProcess.ID,
                        Name = findProcess.Name,
                        ExecutablePath = findProcess.ExecutablePath,
                        StartTime = p.StartTime,
                        ExitTime = p.ExitTime,
                        SessionDate = DateTime.Now.ToShortDateString()
                    };

                    if(sessions != null)
                    {
                        sessions.Add(processSession);
                        TProcessSession.SaveSessionList(sessions, sessionListPath);
                    }
                    else
                    {
                        // Populate list if null
                        sessions = TProcessSession.ReadSessionList(sessionListPath);
                    }

                    sessions = TProcessSession.ReadSessionList(sessionListPath);

                    // Free resources once instance process has exited
                    findProcess.StalkedProcess.Dispose();
                }
            }
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Stalker service started at " + DateTime.Now.ToString());
            return base.StartAsync(cancellationToken);
        }
        public override Task StopAsync(CancellationToken cancellationToken)
        {

            _logger.LogInformation("Stalker service closed at " + DateTime.Now.ToString());
            return base.StopAsync(cancellationToken);
        }
    }
}