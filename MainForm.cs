using System;
using System.Linq;
using System.Windows.Forms;

namespace CybersecurityAwarenessChatbotGUI
{
    public partial class MainForm : Form
    {
        private ChatbotEngine bot;
        private TaskManager taskManager;
        private QuizManager quiz;

        private string selectedAnswer = "";

        public MainForm()
        {
            InitializeComponent();

            bot = new ChatbotEngine();
            taskManager = new TaskManager();
            quiz = new QuizManager();

            Load += MainForm_Load;
        }

        // ================= LOAD =================
        private void MainForm_Load(object sender, EventArgs e)
        {
            rtbChat.AppendText(bot.StartConversation() + "\n\n");

            LoadTasks();
            LoadQuiz();
            LoadLog();
        }

        // ================= CHAT =================
        private void btnSend_Click_1(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void txtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendMessage();
            }
        }

        private void SendMessage()
        {
            string input = txtUserInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(input)) return;

            rtbChat.AppendText("You: " + input + "\n");

            string response = bot.GetResponse(input);

            rtbChat.AppendText("Bot: " + response + "\n\n");

            txtUserInput.Clear();

            LoadTasks();
            LoadLog();
        }

        // ================= TASKS =================
        private void LoadTasks()
        {
            dgvTasks.Rows.Clear();
            dgvTasks.Columns.Clear();

            dgvTasks.Columns.Add("Id", "Id");
            dgvTasks.Columns.Add("Title", "Title");
            dgvTasks.Columns.Add("Description", "Description");
            dgvTasks.Columns.Add("Reminder", "Reminder");
            dgvTasks.Columns.Add("Completed", "Completed");

            var tasks = taskManager.GetTasks();

            foreach (var t in tasks)
            {
                dgvTasks.Rows.Add(t.Id, t.Title, t.Description, t.Reminder, t.IsComplete);
            }
        }

        private void btnAddTask_Click_1(object sender, EventArgs e)
        {
            string title = txtTaskTitle.Text;
            string desc = txtTaskDescription.Text;
            string reminder = txtTaskReminder.Text;

            if (string.IsNullOrWhiteSpace(title)) return;

            string msg = taskManager.AddTask(title, desc, reminder);

            ActivityLogger.Log("Task added: " + title);

            MessageBox.Show(msg);

            LoadTasks();
            LoadLog();

            txtTaskTitle.Clear();
            txtTaskDescription.Clear();
            txtTaskReminder.Clear();
        }

        private void btnCompleteTask_Click_1(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells[0].Value);

            taskManager.CompleteTask(id);

            ActivityLogger.Log("Task completed ID: " + id);

            LoadTasks();
            LoadLog();
        }

        private void btnDeleteTask_Click_1(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells[0].Value);

            taskManager.DeleteTask(id);

            ActivityLogger.Log("Task deleted ID: " + id);

            LoadTasks();
            LoadLog();
        }

        // ================= QUIZ =================
        private void LoadQuiz()
        {
            var q = quiz.GetCurrentQuestion();

            if (q == null)
            {
                lblQuestion.Text = "Quiz Finished!";
                return;
            }

            lblQuestion.Text = q.Question;

            btnA.Text = q.Options[0];
            btnB.Text = q.Options[1];

            if (q.Options.Count > 2) btnC.Text = q.Options[2];
            if (q.Options.Count > 3) btnD.Text = q.Options[3];

            lblScore.Text = "Score: " + quiz.GetFinalScore();
        }

        private void btnA_Click(object sender, EventArgs e) => selectedAnswer = "A";
        private void btnB_Click(object sender, EventArgs e) => selectedAnswer = "B";
        private void btnC_Click(object sender, EventArgs e) => selectedAnswer = "C";
        private void btnD_Click(object sender, EventArgs e) => selectedAnswer = "D";

        private void btnSubmitAnswer_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedAnswer)) return;

            bool correct = quiz.SubmitAnswer(selectedAnswer);

            rtbFeedback.AppendText(correct ? "Correct!\n" : "Wrong!\n");
            rtbFeedback.AppendText(quiz.GetExplanation() + "\n\n");

            ActivityLogger.Log("Quiz answer submitted");

            LoadQuiz();
            LoadLog();

            selectedAnswer = "";
        }

        private void btnNextQuestion_Click_1(object sender, EventArgs e)
        {
            LoadQuiz();
        }

        // ================= LOG =================
        private void LoadLog()
        {
            rtbLog.Text = ActivityLogger.GetRecentLog(10);
        }

        private void btnRefreshLog_Click_1(object sender, EventArgs e)
        {
            LoadLog();
  

   


      

        }
    }
}