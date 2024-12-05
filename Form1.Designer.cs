namespace AOTW_Week2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CalanderView = new MonthCalendar();
            UpcomingPanel = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            GoalInput = new TextBox();
            AddGoal = new Button();
            UpcomingProgress = new ProgressBar();
            TaskCreateDate = new DateTimePicker();
            TaskCreatorPanel = new Panel();
            Reset = new Button();
            AddTask = new Button();
            TaskCreateDescription = new TextBox();
            TaskCreateGoals = new CheckedListBox();
            TaskCreatePicture = new PictureBox();
            DesignPanel = new Panel();
            UpcomingPanel.SuspendLayout();
            TaskCreatorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TaskCreatePicture).BeginInit();
            SuspendLayout();
            // 
            // CalanderView
            // 
            CalanderView.CalendarDimensions = new Size(1, 4);
            CalanderView.Location = new Point(1, 0);
            CalanderView.Name = "CalanderView";
            CalanderView.TabIndex = 0;
            // 
            // UpcomingPanel
            // 
            UpcomingPanel.Controls.Add(textBox2);
            UpcomingPanel.Controls.Add(textBox1);
            UpcomingPanel.Controls.Add(GoalInput);
            UpcomingPanel.Controls.Add(AddGoal);
            UpcomingPanel.Location = new Point(240, 12);
            UpcomingPanel.Name = "UpcomingPanel";
            UpcomingPanel.Size = new Size(314, 546);
            UpcomingPanel.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 22);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(75, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "Add Goals";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 187);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(308, 190);
            textBox1.TabIndex = 2;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // GoalInput
            // 
            GoalInput.Location = new Point(0, 64);
            GoalInput.Name = "GoalInput";
            GoalInput.Size = new Size(311, 23);
            GoalInput.TabIndex = 1;
            // 
            // AddGoal
            // 
            AddGoal.Location = new Point(110, 104);
            AddGoal.Name = "AddGoal";
            AddGoal.Size = new Size(75, 23);
            AddGoal.TabIndex = 0;
            AddGoal.Text = "AddGoal";
            AddGoal.UseVisualStyleBackColor = true;
            // 
            // UpcomingProgress
            // 
            UpcomingProgress.Location = new Point(240, 564);
            UpcomingProgress.Name = "UpcomingProgress";
            UpcomingProgress.Size = new Size(314, 26);
            UpcomingProgress.TabIndex = 2;
            // 
            // TaskCreateDate
            // 
            TaskCreateDate.Location = new Point(89, 22);
            TaskCreateDate.Name = "TaskCreateDate";
            TaskCreateDate.Size = new Size(193, 23);
            TaskCreateDate.TabIndex = 3;
            // 
            // TaskCreatorPanel
            // 
            TaskCreatorPanel.Controls.Add(Reset);
            TaskCreatorPanel.Controls.Add(AddTask);
            TaskCreatorPanel.Controls.Add(TaskCreateDescription);
            TaskCreatorPanel.Controls.Add(TaskCreateGoals);
            TaskCreatorPanel.Controls.Add(TaskCreatePicture);
            TaskCreatorPanel.Controls.Add(TaskCreateDate);
            TaskCreatorPanel.Location = new Point(560, 12);
            TaskCreatorPanel.Name = "TaskCreatorPanel";
            TaskCreatorPanel.Size = new Size(285, 432);
            TaskCreatorPanel.TabIndex = 4;
            // 
            // Reset
            // 
            Reset.Location = new Point(89, 397);
            Reset.Name = "Reset";
            Reset.Size = new Size(75, 23);
            Reset.TabIndex = 8;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            // 
            // AddTask
            // 
            AddTask.Location = new Point(207, 397);
            AddTask.Name = "AddTask";
            AddTask.Size = new Size(75, 23);
            AddTask.TabIndex = 7;
            AddTask.Text = "Add Task";
            AddTask.UseVisualStyleBackColor = true;
            AddTask.Click += AddTask_Click;
            // 
            // TaskCreateDescription
            // 
            TaskCreateDescription.Location = new Point(89, 133);
            TaskCreateDescription.Name = "TaskCreateDescription";
            TaskCreateDescription.Size = new Size(196, 23);
            TaskCreateDescription.TabIndex = 6;
            // 
            // TaskCreateGoals
            // 
            TaskCreateGoals.FormattingEnabled = true;
            TaskCreateGoals.Location = new Point(89, 51);
            TaskCreateGoals.Name = "TaskCreateGoals";
            TaskCreateGoals.Size = new Size(193, 76);
            TaskCreateGoals.TabIndex = 5;
            TaskCreateGoals.SelectedIndexChanged += TaskCreateGoals_SelectedIndexChanged;
            // 
            // TaskCreatePicture
            // 
            TaskCreatePicture.Location = new Point(89, 162);
            TaskCreatePicture.Name = "TaskCreatePicture";
            TaskCreatePicture.Size = new Size(193, 229);
            TaskCreatePicture.TabIndex = 4;
            TaskCreatePicture.TabStop = false;
            TaskCreatePicture.Click += pictureBox1_Click;
            // 
            // DesignPanel
            // 
            DesignPanel.Location = new Point(560, 450);
            DesignPanel.Name = "DesignPanel";
            DesignPanel.Size = new Size(285, 140);
            DesignPanel.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 602);
            Controls.Add(DesignPanel);
            Controls.Add(TaskCreatorPanel);
            Controls.Add(UpcomingProgress);
            Controls.Add(UpcomingPanel);
            Controls.Add(CalanderView);
            Name = "Form1";
            Text = "Form1";
            UpcomingPanel.ResumeLayout(false);
            UpcomingPanel.PerformLayout();
            TaskCreatorPanel.ResumeLayout(false);
            TaskCreatorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TaskCreatePicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar CalanderView;
        private Panel UpcomingPanel;
        private ProgressBar UpcomingProgress;
        private DateTimePicker TaskCreateDate;
        private Panel TaskCreatorPanel;
        private TextBox TaskCreateDescription;
        private CheckedListBox TaskCreateGoals;
        private PictureBox TaskCreatePicture;
        private Panel DesignPanel;
        private Button Reset;
        private Button AddTask;
        private TextBox GoalInput;
        private Button AddGoal;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
