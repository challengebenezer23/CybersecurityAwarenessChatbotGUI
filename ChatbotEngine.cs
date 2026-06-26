using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CybersecurityAwarenessChatbotGUI
{
    public class ChatbotEngine
    {
        private User user = new User();
        private int setupStep = 0;

        private string currentTopic = "";
        private bool waitingForExample = false;
        private bool waitingForAnotherTopic = false;

        private Dictionary<string, string> topicInfo = new Dictionary<string, string>()
        {
            { "password safety", "Strong passwords include uppercase, lowercase, numbers and symbols." },
            { "phishing", "Phishing is when attackers trick you into revealing sensitive information." },
            { "privacy", "Privacy protects your personal data online." },
            { "scam", "Scams are deceptive attempts to steal money or data." }
        };

        private Dictionary<string, string> topicExamples = new Dictionary<string, string>()
        {
            { "password safety", "Example: T#k9!Lm2@Qa is a strong password." },
            { "phishing", "Example: Fake emails asking for your bank details." },
            { "privacy", "Example: Avoid sharing your address online." },
            { "scam", "Example: 'You won a prize' messages are usually scams." }
        };

        // ================= START =================
        public string StartConversation()
        {
            setupStep = 1;
            return "Hey 👋 Welcome to the Cybersecurity Chatbot.\nWhat is your name?";
        }

        // ================= MAIN NLP ENGINE =================
        public string GetResponse(string input)
        {
            input = input.ToLower().Trim();

            // ================= STEP 1: NAME SETUP =================
            if (setupStep == 1)
            {
                user.Name = input;
                setupStep = 2;

                ActivityLogger.Log($"User set name: {user.Name}");

                return $"Nice to meet you {user.Name} 😊\nWhat would you like to learn?";
            }

            // ================= STEP 2: NLP INTENT DETECTION =================

            // 🔥 ADD TASK INTENT
            if (input.Contains("add task") || input.Contains("create task") || input.Contains("i need to"))
            {
                ActivityLogger.Log("NLP detected: Add Task intent");

                return "Task detected 📝 Please go to Task tab to add it properly.";
            }

            // 🔥 REMINDER INTENT
            if (input.Contains("remind me") || input.Contains("reminder"))
            {
                ActivityLogger.Log("NLP detected: Reminder intent");

                return "Reminder noted ⏰ Please set it in the Task section.";
            }

            // 🔥 QUIZ INTENT
            if (input.Contains("quiz") || input.Contains("test me") || input.Contains("start quiz"))
            {
                ActivityLogger.Log("NLP detected: Quiz started");

                return "Launching cybersecurity quiz 🎮 (Go to Quiz tab)";
            }

            // 🔥 LOG INTENT
            if (input.Contains("show log") || input.Contains("activity log") || input.Contains("what have you done"))
            {
                ActivityLogger.Log("User requested activity log");

                return ActivityLogger.GetRecentLog(10);
            }

            // ================= STEP 3: SENTIMENT =================
            string sentiment = SentimentAnalyzer.DetectSentiment(input);

            if (sentiment == "worried")
            {
                ActivityLogger.Log("Sentiment detected: worried");

                return "It's okay to feel worried. Stay cautious online.";
            }

            if (sentiment == "frustrated")
            {
                ActivityLogger.Log("Sentiment detected: frustrated");

                return "Cybersecurity can be tricky, but you're learning 👍";
            }

            if (sentiment == "confused")
            {
                ActivityLogger.Log("Sentiment detected: confused");

                return "Let me simplify it for you 😊";
            }

            // ================= STEP 4: TOPIC MATCHING =================
            foreach (var topic in topicInfo.Keys)
            {
                if (input.Contains(topic))
                {
                    currentTopic = topic;
                    waitingForExample = true;

                    ActivityLogger.Log($"Keyword matched: {topic}");

                    return topicInfo[topic] + "\n\nWould you like an example?";
                }
            }

            // ================= STEP 5: EXAMPLE FLOW =================
            if (waitingForExample)
            {
                waitingForExample = false;

                if (input.Contains("yes"))
                {
                    ActivityLogger.Log($"Example shown: {currentTopic}");

                    waitingForAnotherTopic = true;

                    return topicExamples[currentTopic] +
                           "\n\nWould you like another topic?";
                }

                waitingForAnotherTopic = true;
                return "No problem 👍 Want another topic?";
            }

            // ================= STEP 6: CONTINUE FLOW =================
            if (waitingForAnotherTopic)
            {
                waitingForAnotherTopic = false;

                if (input.Contains("no"))
                {
                    ActivityLogger.Log("User ended conversation");

                    return $"Goodbye {user.Name} 👋 Stay safe online.";
                }

                return "Great 😄 What else would you like to learn?";
            }

            // ================= DEFAULT =================
            ActivityLogger.Log("Fallback response triggered");

            return "Choose a topic: Password Safety, Phishing, Privacy, Scam Awareness.";
        }
    }
}
