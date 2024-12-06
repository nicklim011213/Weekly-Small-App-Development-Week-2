using System.Collections.Generic;

namespace AOTW_Week2
{
    public partial class Form1 : Form
    {
        public DateTime SelectedDate;
        public Dictionary<DateTime, List<PlannedTask>> TaskList = new Dictionary<DateTime, List<PlannedTask>>();
        public List<string> GoalNames = new List<string>();
        public List<bool> GoalCompleted = new List<bool>();
        public string GoalListTitle = "";
        public Form1()
        {
            InitializeComponent();
            SelectedDate = DateTime.Now;
            TaskCreateDate.ValueChanged += new EventHandler(UpdateDate);
            AddGoal.Click += new EventHandler(UpdateGoalList);
            TaskCreateGoals.ItemCheck += new ItemCheckEventHandler(SaveProgress);
        }

        private void UpdateGoalList(object? sender, EventArgs e)
        {
            GoalNames = new List<string>(GoalInput.Text.Split(";"));
            GoalCompleted = Enumerable.Repeat(false, GoalNames.Count).ToList();
            GoalListTitle = GoalTitleAdd.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TaskCreateGoals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateDate(object sender, EventArgs e)
        {
            SelectedDate = TaskCreateDate.Value.Date;
            TaskCreateGoals.Items.Clear();
            var AnyTasks = TaskList.TryGetValue(SelectedDate, out List<PlannedTask> tasks);
            if (AnyTasks)
            {
                foreach (var task in tasks)
                {
                    TaskCreateGoals.Items.Add(task.Title, true);
                    foreach (var goal in task.Goals)
                    {
                        TaskCreateGoals.Items.Add(goal.Description, goal.Completed);
                    }
                }
            }

        }
         
        private void SaveProgress(object? sender, ItemCheckEventArgs e)
        {
            DateTime TaskAdd = DateTime.Now.Date;
            int IndexofItem = e.Index;
            bool isChecked = e.NewValue == CheckState.Checked;

            foreach (var taskgoallist in TaskList[TaskAdd])
            {
                var SelectedGoal = taskgoallist.Goals.Find(TaskGoal => TaskCreateGoals.Items[IndexofItem].ToString() == TaskGoal.Description.ToString());
                if (SelectedGoal is not null)
                {
                    SelectedGoal.Completed = isChecked;
                }
            }
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            DateTime TaskAdd = DateTime.Now.Date;
            List<String> ListGoalDescriptions = new List<String>();
            ListGoalDescriptions = TaskCreateGoals.Text.Split('\n').ToList();
            List<bool> ListGoalCompleted = CheckboxBoolConverter(new List<bool>());
            ImageConverter convert = new ImageConverter();

            Goal goal = new Goal("Temp", false);
            if (!TaskList.ContainsKey(TaskAdd))
            {
                TaskList.TryAdd(TaskAdd, new List<PlannedTask>());
            }
            TaskList[TaskAdd].Add(new PlannedTask { Title = GoalListTitle, Description = TaskCreateDescription.Text, TaskPicture = (byte[])convert.ConvertTo(TaskCreatePicture.Image, typeof(byte[])), Goals = goal.CreateTaskList(GoalNames, GoalCompleted) });
            GoalInput.Clear();
            GoalTitleAdd.Clear();
            CalanderView.AddBoldedDate(TaskAdd);
        }

        private List<bool> CheckboxBoolConverter(List<bool> ListGoalCompleted)
        {
            for (int i = 0; i != TaskCreateGoals.Items.Count; i++)
            {
                if (TaskCreateGoals.GetItemCheckState(i) == CheckState.Checked)
                {
                    ListGoalCompleted.Add(true);
                }
                else
                {
                    ListGoalCompleted.Add(false);
                }
            }
            return ListGoalCompleted;
        }
    }

    public class PlannedTask
    {
        public String Title = "";
        public String Description = "";
        public byte[] TaskPicture = { };
        public List<Goal> Goals = new List<Goal>();
    }

    public class Goal
    {
        public String Description = "";
        public bool Completed;

        public Goal(string GoalDescription,  bool GoalCompleted)
        {
            Description = GoalDescription;
            Completed = GoalCompleted;
        }

        public List<Goal> CreateTaskList(List<String> Descriptions, List<bool> Checked)
        {
            if (Checked.Count != Descriptions.Count)
            {
                Console.WriteLine("Error Mismatched size");
                return new List<Goal>(); 
            }
            else
            {
                List<Goal> Goals = new List<Goal>();
                for (int i = 0; i !=  Descriptions.Count; i++)
                {
                    Goals.Add(new Goal(Descriptions[i], Checked[i]));
                }
                return Goals;
            }
        }
    }
}
