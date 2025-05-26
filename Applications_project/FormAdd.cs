using Applications_project.Models;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Task = Applications_project.Models.Task;


namespace Applications_project
{
    public partial class FormAdd : Form
    {
        public FormAdd(DbSet<Category> categories, DbSet<Sender> senders, DbSet<Employee> employees, DbSet<Audience> audiences, Task? task = null)
        {
            InitializeComponent();

            if (!IsEmpty())
            {
                buttonSave.Enabled = true;
            }
            else
            {
                buttonSave.Enabled = false;
            }

            Category.DataSource = categories.Local.ToBindingList();
            Category.DisplayMember = "NameCategory";
            Category.ValueMember = "Id";
            Category.SelectedIndex = -1;

            Sender.DataSource = senders.Local.ToBindingList();
            Sender.DisplayMember = "FullName";
            Sender.ValueMember = "Id";
            Sender.SelectedIndex = -1;

            Employee.DataSource = employees.Local.ToBindingList();
            Employee.DisplayMember = "FullName";
            Employee.ValueMember = "Id";
            Employee.SelectedIndex = -1;

            Location.DataSource = audiences.Local.ToBindingList();
            Location.DisplayMember = "DisplayAudience";
            Location.ValueMember = "Id";
            Location.SelectedIndex = -1;


            // Если передан объект Task, заполняем поля
            if (task != null)
            {
                Description.Text = task.Description;
                Category.SelectedValue = task.IdCategory;
                Sender.SelectedValue = task.IdSender;
                Employee.SelectedValue = task.IdEmployee;
                Location.SelectedValue = task.IdAudience;
            }


            // Добавляем обработчики для ComboBox
            Category.TextChanged += TextBox_TextChanged;
            Sender.TextChanged += TextBox_TextChanged;
            Employee.TextChanged += TextBox_TextChanged;
            Location.TextChanged += TextBox_TextChanged;

            Description.TextChanged += TextBox_TextChanged;

            buttonSave.Enabled = !IsEmpty();
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsEmpty())
            {
                buttonSave.Enabled = true;
            }
            else
            {
                buttonSave.Enabled = false;
            }
        }
        private bool IsEmpty()
        {
            if (Description.Text == ""
                || Category.SelectedIndex == -1
                || Employee.SelectedIndex == -1
                || Sender.SelectedIndex == -1
                || Location.SelectedIndex == -1)
            {
                return true;
            }
            return false;
        }
    }
}
