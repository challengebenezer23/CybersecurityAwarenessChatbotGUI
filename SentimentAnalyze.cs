using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CybersecurityAwarenessChatbotGUI
{
    public static class SentimentAnalyzer
    {
        public static string DetectSentiment(string input)
        {
            input = input.ToLower();

            if (input.Contains("worried") ||
                input.Contains("scared"))
            {
                return "worried";
            }

            if (input.Contains("frustrated") ||
                input.Contains("angry"))
            {
                return "frustrated";
            }

            if (input.Contains("confused"))
            {
                return "confused";
            }

            return "neutral";
        }
    }
}
