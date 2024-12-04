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
            CalanderView = new MonthCalendar();
            UpcomingPanel = new Panel();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
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
            UpcomingPanel.Controls.Add(checkBox5);
            UpcomingPanel.Controls.Add(checkBox4);
            UpcomingPanel.Controls.Add(checkBox3);
            UpcomingPanel.Controls.Add(checkBox2);
            UpcomingPanel.Controls.Add(checkBox1);
            UpcomingPanel.Location = new Point(240, 12);
            UpcomingPanel.Name = "UpcomingPanel";
            UpcomingPanel.Size = new Size(314, 546);
            UpcomingPanel.TabIndex = 1;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(29, 169);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(83, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "checkBox5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(29, 132);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(83, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(29, 95);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(29, 60);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(29, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
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
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ProgressBar UpcomingProgress;
        private DateTimePicker TaskCreateDate;
        private Panel TaskCreatorPanel;
        private TextBox TaskCreateDescription;
        private CheckedListBox TaskCreateGoals;
        private PictureBox TaskCreatePicture;
        private Panel DesignPanel;
        private Button Reset;
        private Button AddTask;
    }
}
