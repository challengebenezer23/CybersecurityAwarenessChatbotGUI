namespace CybersecurityAwarenessChatbotGUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabControl1;

        // CHAT TAB
        private System.Windows.Forms.TabPage tabChat;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblOnline;

        // TASK TAB
        private System.Windows.Forms.TabPage tabTasks;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.TextBox txtTaskReminder;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.DataGridView dgvTasks;

        // QUIZ TAB
        private System.Windows.Forms.TabPage tabQuiz;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.RichTextBox rtbFeedback;

        // LOG TAB
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnRefreshLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabChat = new System.Windows.Forms.TabPage();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblOnline = new System.Windows.Forms.Label();
            this.tabTasks = new System.Windows.Forms.TabPage();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.txtTaskReminder = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.tabQuiz = new System.Windows.Forms.TabPage();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.rtbFeedback = new System.Windows.Forms.RichTextBox();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnRefreshLog = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabChat.SuspendLayout();
            this.tabTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.tabQuiz.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabChat);
            this.tabControl1.Controls.Add(this.tabTasks);
            this.tabControl1.Controls.Add(this.tabQuiz);
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 650);
            this.tabControl1.TabIndex = 0;
            // 
            // tabChat
            // 
            this.tabChat.Controls.Add(this.rtbChat);
            this.tabChat.Controls.Add(this.txtUserInput);
            this.tabChat.Controls.Add(this.btnSend);
            this.tabChat.Controls.Add(this.lblOnline);
            this.tabChat.Location = new System.Drawing.Point(4, 22);
            this.tabChat.Name = "tabChat";
            this.tabChat.Size = new System.Drawing.Size(992, 624);
            this.tabChat.TabIndex = 0;
            this.tabChat.Text = "Chatbot";
            // 
            // rtbChat
            // 
            this.rtbChat.Location = new System.Drawing.Point(20, 20);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(900, 400);
            this.rtbChat.TabIndex = 0;
            this.rtbChat.Text = "";
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(20, 440);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(700, 20);
            this.txtUserInput.TabIndex = 1;
            this.txtUserInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserInput_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(740, 440);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(180, 30);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // lblOnline
            // 
            this.lblOnline.Location = new System.Drawing.Point(20, 480);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(100, 23);
            this.lblOnline.TabIndex = 3;
            this.lblOnline.Text = "Status: Online";
            // 
            // tabTasks
            // 
            this.tabTasks.Controls.Add(this.txtTaskTitle);
            this.tabTasks.Controls.Add(this.txtTaskDescription);
            this.tabTasks.Controls.Add(this.txtTaskReminder);
            this.tabTasks.Controls.Add(this.btnAddTask);
            this.tabTasks.Controls.Add(this.btnCompleteTask);
            this.tabTasks.Controls.Add(this.btnDeleteTask);
            this.tabTasks.Controls.Add(this.dgvTasks);
            this.tabTasks.Location = new System.Drawing.Point(4, 22);
            this.tabTasks.Name = "tabTasks";
            this.tabTasks.Size = new System.Drawing.Size(992, 624);
            this.tabTasks.TabIndex = 1;
            this.tabTasks.Text = "Tasks";
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Location = new System.Drawing.Point(20, 20);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(300, 20);
            this.txtTaskTitle.TabIndex = 0;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(20, 60);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(300, 20);
            this.txtTaskDescription.TabIndex = 1;
            // 
            // txtTaskReminder
            // 
            this.txtTaskReminder.Location = new System.Drawing.Point(20, 100);
            this.txtTaskReminder.Name = "txtTaskReminder";
            this.txtTaskReminder.Size = new System.Drawing.Size(300, 20);
            this.txtTaskReminder.TabIndex = 2;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(350, 20);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click_1);
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.Location = new System.Drawing.Point(350, 60);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(75, 23);
            this.btnCompleteTask.TabIndex = 4;
            this.btnCompleteTask.Text = "Complete";
            this.btnCompleteTask.Click += new System.EventHandler(this.btnCompleteTask_Click_1);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(350, 100);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTask.TabIndex = 5;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click_1);
            // 
            // dgvTasks
            // 
            this.dgvTasks.Location = new System.Drawing.Point(20, 150);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.Size = new System.Drawing.Size(900, 400);
            this.dgvTasks.TabIndex = 6;
            // 
            // tabQuiz
            // 
            this.tabQuiz.Controls.Add(this.lblQuestion);
            this.tabQuiz.Controls.Add(this.btnA);
            this.tabQuiz.Controls.Add(this.btnB);
            this.tabQuiz.Controls.Add(this.btnC);
            this.tabQuiz.Controls.Add(this.btnD);
            this.tabQuiz.Controls.Add(this.btnSubmitAnswer);
            this.tabQuiz.Controls.Add(this.btnNextQuestion);
            this.tabQuiz.Controls.Add(this.lblScore);
            this.tabQuiz.Controls.Add(this.rtbFeedback);
            this.tabQuiz.Location = new System.Drawing.Point(4, 22);
            this.tabQuiz.Name = "tabQuiz";
            this.tabQuiz.Size = new System.Drawing.Size(992, 624);
            this.tabQuiz.TabIndex = 2;
            this.tabQuiz.Text = "Quiz";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(20, 20);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(900, 60);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question appears here";
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(20, 100);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 23);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A";
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(200, 100);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(75, 23);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(380, 100);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(560, 100);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 23);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "D";
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Location = new System.Drawing.Point(20, 150);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitAnswer.TabIndex = 5;
            this.btnSubmitAnswer.Text = "Submit";
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click_1);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(150, 150);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnNextQuestion.TabIndex = 6;
            this.btnNextQuestion.Text = "Next";
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click_1);
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(20, 200);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 23);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score: 0";
            // 
            // rtbFeedback
            // 
            this.rtbFeedback.Location = new System.Drawing.Point(20, 240);
            this.rtbFeedback.Name = "rtbFeedback";
            this.rtbFeedback.Size = new System.Drawing.Size(900, 300);
            this.rtbFeedback.TabIndex = 8;
            this.rtbFeedback.Text = "";
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.rtbLog);
            this.tabLog.Controls.Add(this.btnRefreshLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Size = new System.Drawing.Size(992, 624);
            this.tabLog.TabIndex = 3;
            this.tabLog.Text = "Activity Log";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(20, 20);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(900, 450);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // btnRefreshLog
            // 
            this.btnRefreshLog.Location = new System.Drawing.Point(20, 490);
            this.btnRefreshLog.Name = "btnRefreshLog";
            this.btnRefreshLog.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshLog.TabIndex = 1;
            this.btnRefreshLog.Text = "Refresh";
            this.btnRefreshLog.Click += new System.EventHandler(this.btnRefreshLog_Click_1);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Cybersecurity Awareness Chatbot";
            this.tabControl1.ResumeLayout(false);
            this.tabChat.ResumeLayout(false);
            this.tabChat.PerformLayout();
            this.tabTasks.ResumeLayout(false);
            this.tabTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.tabQuiz.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}