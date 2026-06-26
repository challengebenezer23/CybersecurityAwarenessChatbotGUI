using System;
using System.Collections.Generic;
using System.Linq;

namespace CybersecurityAwarenessChatbotGUI
{
    public class ActivityLogger
    {
        private static List<string> logs = new List<string>();

        // ADD LOG ENTRY
        public static void Log(string action)
        {
            string entry = $"[{DateTime.Now:HH:mm}] {action}";
            logs.Add(entry);
        }

        // GET LAST 10 ENTRIES
        public static string GetRecentLog(int count = 10)
        {
            if (logs.Count == 0)
                return "No activity recorded yet.";

            var recent = logs
                .Skip(Math.Max(0, logs.Count - count))
                .Take(count)
                .ToList();

            string result = "=== Recent Activity ===\n\n";

            for (int i = 0; i < recent.Count; i++)
            {
                result += $"{i + 1}. {recent[i]}\n";
            }

            return result;
        }

        // GET FULL LOG
        public static string GetFullLog()
        {
            if (logs.Count == 0)
                return "No activity recorded yet.";

            string result = "=== Full Activity Log ===\n\n";

            for (int i = 0; i < logs.Count; i++)
            {
                result += $"{i + 1}. {logs[i]}\n";
            }

            return result;
        }

        // GET COUNT
        public static int GetCount()
        {
            return logs.Count;
        }

        // CLEAR LOG (optional use for reset/testing)
        public static void Clear()
        {
            logs.Clear();
        }
    }
}