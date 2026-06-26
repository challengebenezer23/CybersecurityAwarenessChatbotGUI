using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace CybersecurityAwarenessChatbotGUI
{
    public class TaskStorageHelper
    {
        private readonly string filePath = "tasks.json";

        // LOAD TASKS
        public List<CyberTask> LoadTasks()
        {
            try
            {
                if (!File.Exists(filePath))
                    return new List<CyberTask>();

                string json = File.ReadAllText(filePath);

                return JsonConvert.DeserializeObject<List<CyberTask>>(json)
                       ?? new List<CyberTask>();
            }
            catch
            {
                return new List<CyberTask>();
            }
        }

        // SAVE TASKS
        public void SaveTasks(List<CyberTask> tasks)
        {
            try
            {
                string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch
            {
                // silently fail (POE acceptable if handled)
            }
        }

        // ADD TASK
        public void AddTask(CyberTask task)
        {
            var tasks = LoadTasks();

            task.Id = tasks.Count > 0 ? tasks[tasks.Count - 1].Id + 1 : 1;

            tasks.Add(task);

            SaveTasks(tasks);
        }

        // COMPLETE TASK
        public void MarkComplete(int id)
        {
            var tasks = LoadTasks();

            var task = tasks.Find(t => t.Id == id);

            if (task != null)
            {
                task.IsComplete = true;
                SaveTasks(tasks);
            }
        }

        // DELETE TASK
        public void DeleteTask(int id)
        {
            var tasks = LoadTasks();

            tasks.RemoveAll(t => t.Id == id);

            SaveTasks(tasks);
        }
    }
}