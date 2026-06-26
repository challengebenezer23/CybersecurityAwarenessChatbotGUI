using System;
using System.Collections.Generic;
using System.Linq;

namespace CybersecurityAwarenessChatbotGUI
{
    public class QuizManager
    {
        private List<QuizQuestion> questions;
        private int currentIndex = 0;
        private int score = 0;

        public QuizManager()
        {
            questions = new List<QuizQuestion>
            {
                new QuizQuestion
                {
                    Question = "What is phishing?",
                    Options = new List<string>
                    {
                        "A) A fishing sport",
                        "B) A cyber attack that tricks users",
                        "C) A virus scanner",
                        "D) A password manager"
                    },
                    CorrectAnswer = "B",
                    Explanation = "Phishing tricks users into giving sensitive information.",
                    IsTrueFalse = false
                },

                new QuizQuestion
                {
                    Question = "Strong passwords should include letters, numbers and symbols.",
                    Options = new List<string>
                    {
                        "A) True",
                        "B) False"
                    },
                    CorrectAnswer = "A",
                    Explanation = "Strong passwords combine multiple character types.",
                    IsTrueFalse = true
                },

                new QuizQuestion
                {
                    Question = "What should you do if you receive a suspicious email?",
                    Options = new List<string>
                    {
                        "A) Click the link",
                        "B) Reply immediately",
                        "C) Report it as phishing",
                        "D) Ignore security warnings"
                    },
                    CorrectAnswer = "C",
                    Explanation = "Reporting protects you and others from scams.",
                    IsTrueFalse = false
                },

                new QuizQuestion
                {
                    Question = "2FA stands for?",
                    Options = new List<string>
                    {
                        "A) Two-Factor Authentication",
                        "B) Two File Access",
                        "C) Total Firewall Access",
                        "D) Third File Algorithm"
                    },
                    CorrectAnswer = "A",
                    Explanation = "2FA adds an extra layer of security.",
                    IsTrueFalse = false
                }
            };
        }

        // GET CURRENT QUESTION
        public QuizQuestion GetCurrentQuestion()
        {
            if (currentIndex < questions.Count)
                return questions[currentIndex];

            return null;
        }

        // SUBMIT ANSWER
        public bool SubmitAnswer(string answer)
        {
            var q = questions[currentIndex];

            bool correct = answer.ToUpper() == q.CorrectAnswer;

            if (correct)
                score++;

            currentIndex++;

            return correct;
        }

        // FEEDBACK
        public string GetExplanation()
        {
            return questions[currentIndex - 1].Explanation;
        }

        // SCORE
        public string GetScore()
        {
            return $"Score: {score} / {questions.Count}";
        }

        // FINISHED
        public bool IsFinished()
        {
            return currentIndex >= questions.Count;
        }

        // RESET
        public void Reset()
        {
            currentIndex = 0;
            score = 0;
        }

        public int GetFinalScore()
        {
            return score;
        }

        public int GetTotal()
        {
            return questions.Count;
        }
    }
}