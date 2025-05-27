
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.ComponentModel;

namespace Applications_project
{
    public partial class FormApplications : Form
    {
        private ApplicationsContext db;
        private short id;
        private Panel? selectedPanel;
        public FormApplications()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            db = new ApplicationsContext();
            db.Audiences.Load();
            db.Categories.Load();
            db.EducationalBuildings.Load();
            db.Employees.Load();
            db.Senders.Load();
            db.Statuses.Load();
            db.Tasks.Load();

            var applications = db.Tasks.Local.OrderBy(p => p.Id).ToList();
            foreach (var application in applications)
            {
                var auditoria = db.Audiences.FirstOrDefault(n => n.Id == application.IdAudience);
                CreatePanel(
                    //db.TypesOfPartners.FirstOrDefault(t => t.Id == application.IdTypeOfPartner).TypeOfPartner, 
                    application.Id,       
                    db.Senders.FirstOrDefault(n => n.Id == application.IdSender).FullName,
                    db.Categories.FirstOrDefault(n => n.Id == application.IdCategory).NameCategory,  
                    application.Description, 
                    db.Employees.FirstOrDefault(n => n.Id == application.IdEmployee).FullName, 
                    db.EducationalBuildings.FirstOrDefault(n => n.Id == auditoria.IdAcademicBuilding).AbbreviatedName + " | " + auditoria.AudienceNumber + " " + auditoria.AudienceName                                                                                // short location
                );
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            db?.Dispose();
            db = null;
        }

        private void Panel_MouseDown(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            id = short.Parse(panel.Name.Split("_")[1]);
            panel.BackColor = Color.AliceBlue;

            if (panel != selectedPanel && selectedPanel != null)
            {
                selectedPanel.BackColor = Color.White;
            }
            selectedPanel = panel;
        }

        private void CreatePanel(short id, string sender, string name, string description, string employee, string location)
        {
            var panel = new Panel();
            Label nameOfCategory = new();
            Label descriptionOfTask = new();
            Label nameOfEmployee = new();
            Label nameOfSender = new();
            Label dateStartdateEnd = new();
            Label locations = new();

            //
            //  nameOfCategory
            //

            nameOfCategory.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 255);
            nameOfCategory.Location = new Point(20, 15);
            nameOfCategory.Name = "nameOfCategory";
            nameOfCategory.AutoSize = true;
            nameOfCategory.TabIndex = 0;
            nameOfCategory.Text = $"{name}";
            nameOfCategory.Dock = DockStyle.Left;

            //
            //  descriptionOfTask
            //

            descriptionOfTask.MaximumSize = new Size(700, 0);
            descriptionOfTask.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            descriptionOfTask.Location = new Point(20, 50);
            descriptionOfTask.Name = "descriptionOfTask";
            descriptionOfTask.AutoSize = true;
            descriptionOfTask.TabIndex = 1;
            descriptionOfTask.Text = description.ToString();

            //
            //  nameOfEmployee
            //

            nameOfEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameOfEmployee.Location = new Point(20, 150);
            nameOfEmployee.Name = "nameOfEmployee";
            nameOfEmployee.Size = new Size(278, 25);
            nameOfEmployee.TabIndex = 2;
            nameOfEmployee.Text = $"{employee}";

            //
            //  location
            //

            locations.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            locations.Location = new Point(720, 150);
            locations.Name = "locations";
            locations.AutoSize = true;
            locations.TabIndex = 3;
            locations.Text = location;

            //
            //  nameOfSender
            //

            nameOfSender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameOfSender.Dock = DockStyle.Right;
            nameOfSender.TextAlign = ContentAlignment.MiddleRight;
            nameOfSender.Location = new Point(680, 15);
            nameOfSender.Name = "nameOfSender";
            nameOfSender.AutoSize = true;
            nameOfSender.TabIndex = 4;
            nameOfSender.Text = $"От {sender}";

            //
            //  panel
            //

            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(nameOfCategory);
            panel.Controls.Add(descriptionOfTask);
            panel.Controls.Add(nameOfEmployee);
            panel.Controls.Add(locations);
            panel.Controls.Add(nameOfSender);
            panel.Name = $"panel_{id}";
            panel.Size = new Size(900, 180);
            panel.TabIndex = 1;
            panel.MouseDown += Panel_MouseDown;

            flowLayoutPanelFill.Controls.Add(panel);

        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(db.Categories, db.Senders, db.Employees, db.Audiences);
            DialogResult result = formAdd.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;


            Task newTask = new Task
            {
                Description = formAdd.Description.Text,
                IdCategory = (short)formAdd.Category.SelectedValue,
                IdEmployee = (short)formAdd.Employee.SelectedValue,
                IdSender = (short)formAdd.Sender.SelectedValue,
                IdAudience = (short)formAdd.Location.SelectedValue,
                IdStatus = 2
            };

            db.Tasks.Add(newTask);
            db.SaveChanges();

            var applications = db.Tasks.FirstOrDefault(t => t.Id == newTask.Id);

            var auditoria = db.Audiences.FirstOrDefault(n => n.Id == applications.IdAudience);
            CreatePanel(
                applications.Id,
                db.Senders.FirstOrDefault(n => n.Id == applications.IdSender).FullName,
                db.Categories.FirstOrDefault(n => n.Id == applications.IdCategory).NameCategory,
                applications.Description,
                db.Employees.FirstOrDefault(n => n.Id == applications.IdEmployee).FullName,
                db.EducationalBuildings.FirstOrDefault(n => n.Id == auditoria.IdAcademicBuilding).AbbreviatedName + " | " + auditoria.AudienceNumber + " " + auditoria.AudienceName                                                                                // short location
            );

            MessageBox.Show("Партнер добавлен");

        }

        private void buttonUpdateTask_Click(object sender, EventArgs e)
        {
            if (selectedPanel == null)
                return;
            var applications = db.Tasks.Find(id);
            FormAdd formAdd = new FormAdd(db.Categories, db.Senders, db.Employees, db.Audiences, applications);
            DialogResult result = formAdd.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            // Обновление задачи
            applications.Description = formAdd.Description.Text;
            applications.IdCategory = (short)formAdd.Category.SelectedValue;
            applications.IdEmployee = (short)formAdd.Employee.SelectedValue;
            applications.IdSender = (short)formAdd.Sender.SelectedValue;
            applications.IdAudience = (short)formAdd.Location.SelectedValue;


            db.SaveChanges();
            DeletePanel(selectedPanel);


            var auditoria = db.Audiences.FirstOrDefault(n => n.Id == applications.IdAudience);
            CreatePanel(
                applications.Id,
                db.Senders.FirstOrDefault(n => n.Id == applications.IdSender).FullName,
                db.Categories.FirstOrDefault(n => n.Id == applications.IdCategory).NameCategory,
                applications.Description,
                db.Employees.FirstOrDefault(n => n.Id == applications.IdEmployee).FullName,
                db.EducationalBuildings.FirstOrDefault(n => n.Id == auditoria.IdAcademicBuilding).AbbreviatedName + " | " + auditoria.AudienceNumber + " " + auditoria.AudienceName

            );

            MessageBox.Show("Партнер обновлен");
        }
        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            if (selectedPanel == null)
                return;

            var applicationToDelete = db.Tasks.Find(id);

            if (applicationToDelete != null)
            {
                db.Tasks.Remove(applicationToDelete);
                db.SaveChanges();
                                  
                DeletePanel(selectedPanel);
                MessageBox.Show("Партнер удален");
            }
        }

        private void DeletePanel(Panel panel)
        {
            flowLayoutPanelFill.Controls.Remove(panel);
            selectedPanel = null;
        }

        
    }
}
