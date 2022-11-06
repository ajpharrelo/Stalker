using Stalker.Models.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Stalker
{
    public class TProcessSession : ITProcess
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string ExecutablePath { get; set; }
        public string SessionDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime ExitTime { get; set; }

        public TProcessSession(Guid id, string name, string executablePath, DateTime startTime, DateTime exitTime, string sessionDate)
        {
            ID = id;
            Name = name;
            ExecutablePath = executablePath;
            StartTime = startTime;
            ExitTime = exitTime;
            SessionDate = sessionDate;
        }

        public TProcessSession(){}

        public static List<TProcessSession>? ReadSessionList(string listPath)
        {

            if (File.Exists(listPath))
            {
                using (StreamReader sr = File.OpenText(listPath))
                {
                    List<TProcessSession>? list = JsonSerializer.Deserialize<List<TProcessSession>>(sr.ReadToEnd());
                    return list;
                }
            }
            else
                // If no list file found create a new one and then populate with an empty JSON array.
                File.WriteAllText(listPath, "[]");
                return new List<TProcessSession>();

        }

        public static void SaveSessionList(List<TProcessSession> sessionList, string listPath)
        {
            using (StreamWriter sw = File.CreateText(listPath))
            {
                string jsonOutput = JsonSerializer.Serialize(sessionList, new JsonSerializerOptions { WriteIndented = true });
                sw.WriteLine(jsonOutput);
            }

        }
    }
}
