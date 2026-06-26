using System.Collections.Generic;

namespace CybersecurityAwarenessChatbotGUI
{
    public class QuizQuestion
    {
        public string Question { get; set; }

        // A, B, C, D options
        public List<string> Options { get; set; }

        public string CorrectAnswer { get; set; }

        public string Explanation { get; set; }

        public bool IsTrueFalse { get; set; }
    }
}