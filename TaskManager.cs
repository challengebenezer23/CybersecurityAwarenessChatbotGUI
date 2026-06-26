using System;
using System.Collections.Generic;

namespace CybersecurityAwarenessChatbotGUI
{
    public class TaskManager
    {
        private TaskStorageHelper storage = new TaskStorageHelper();

        public string AddTask(string title, string description, string reminder)
        {
            CyberTask task = new CyberTask
            {
                Title = title,
                Description = description,
                Reminder = reminder,
                IsComplete = false,
                CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
            };

            storage.AddTask(task);

            return $"Task added: '{title}'. Would you like a reminder?";
        }

        public List<CyberTask> GetTasks()
        {
            return storage.LoadTasks();
        }

        public string CompleteTask(int id)
        {
            storage.MarkComplete(id);
            return "Task marked as complete.";
        }

        public string DeleteTask(int id)
        {
            storage.DeleteTask(id);
            return "Task deleted.";
        }
    }
}