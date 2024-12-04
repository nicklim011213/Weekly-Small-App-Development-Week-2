using System.Collections.Generic;

namespace AOTW_Week2
{
    public partial class Form1 : Form
    {
        public DateTime SelectedDate;
        public Dictionary<DateTime, List<PlannedTask>> TaskList = new Dictionary<DateTime, List<PlannedTask>>();
        public Form1()
        {
            InitializeComponent();
            SelectedDate = DateTime.Now;
            TaskCreateDate.ValueChanged += new EventHandler(UpdateDate);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TaskCreateGoals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateDate(object sender, EventArgs e)
        {
            SelectedDate = TaskCreateDate.Value;
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            DateTime TaskAdd = DateTime.Now;
            List<String> ListGoalDescriptions = new List<String>();
            ListGoalDescriptions = TaskCreateGoals.Text.Split('\n').ToList();
            List<bool> ListGoalCompleted = CheckboxBoolConverter(new List<bool>());
            ImageConverter convert = new ImageConverter();

            Goal goal = new Goal("Temp", false);
            if (!TaskList.ContainsKey(TaskAdd))
            {
                TaskList.TryAdd(TaskAdd, new List<PlannedTask>());
            }
            TaskList[TaskAdd].Add(new PlannedTask { Title = "Empty", Description = TaskCreateDescription.Text, TaskPicture = (byte[])convert.ConvertTo(TaskCreatePicture.Image, typeof(byte[])), Goals = goal.CreateTaskList(ListGoalDescriptions, ListGoalCompleted) });
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
