using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applications_project
{
    public partial class Authorization : Form
    {
        private ApplicationsContext db;
        public Authorization()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            FormApplicationsView formView = new FormApplicationsView();
            this.Hide();
            formView.ShowDialog();
            this.Close();

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "teacher5432")
            {
                FormApplications formApplications = new FormApplications();
                formApplications.Show();
                this.Hide();
                MessageBox.Show("Успешно!");
            }
            else if(textBoxPassword.Text == "")
            {
                MessageBox.Show("Поле не может быть пустым. Введите пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Пароль неверный", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
