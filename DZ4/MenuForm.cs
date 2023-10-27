namespace DZ4
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Form newTask = new Form();
            switch (button.Tag)
            {
                case "1":
                    newTask = new FormTask1();
                    break;
                case "2":
                    newTask = new FormTask2();
                    break;
                case "3":
                    newTask = new FormTask3();
                    break;
                case "4":
                    newTask = new FormTask4();
                    break;
                case "5":
                    newTask = new FormTask5();
                    break;
            }
            newTask.Show();
        }
    }
}