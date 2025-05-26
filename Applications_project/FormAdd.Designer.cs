namespace Applications_project
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonCancel = new Button();
            Category = new ComboBox();
            Description = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Sender = new ComboBox();
            label4 = new Label();
            Employee = new ComboBox();
            Location = new ComboBox();
            label5 = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonSave);
            flowLayoutPanel1.Controls.Add(buttonCancel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 393);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(585, 75);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.White;
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(13, 13);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(154, 50);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.White;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(173, 13);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(154, 50);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // Category
            // 
            Category.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Category.AutoCompleteSource = AutoCompleteSource.ListItems;
            Category.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Category.FormattingEnabled = true;
            Category.Location = new Point(161, 18);
            Category.MaxDropDownItems = 6;
            Category.Name = "Category";
            Category.Size = new Size(349, 33);
            Category.TabIndex = 1;
            // 
            // Description
            // 
            Description.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Description.Location = new Point(161, 70);
            Description.Multiline = true;
            Description.Name = "Description";
            Description.Size = new Size(349, 71);
            Description.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(56, 21);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 3;
            label1.Text = "Название:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(52, 70);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 8;
            label2.Text = "Описание:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(63, 167);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 9;
            label3.Text = "Заказчик:";
            // 
            // Sender
            // 
            Sender.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Sender.AutoCompleteSource = AutoCompleteSource.ListItems;
            Sender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Sender.FormattingEnabled = true;
            Sender.Location = new Point(161, 164);
            Sender.MaxDropDownItems = 6;
            Sender.Name = "Sender";
            Sender.Size = new Size(349, 33);
            Sender.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(47, 251);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 11;
            label4.Text = "Сотрудник:";
            // 
            // Employee
            // 
            Employee.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Employee.AutoCompleteSource = AutoCompleteSource.ListItems;
            Employee.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Employee.FormattingEnabled = true;
            Employee.Location = new Point(161, 248);
            Employee.MaxDropDownItems = 6;
            Employee.Name = "Employee";
            Employee.Size = new Size(349, 33);
            Employee.TabIndex = 12;
            // 
            // Location
            // 
            Location.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Location.AutoCompleteSource = AutoCompleteSource.ListItems;
            Location.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Location.FormattingEnabled = true;
            Location.Location = new Point(161, 326);
            Location.MaxDropDownItems = 6;
            Location.Name = "Location";
            Location.Size = new Size(349, 33);
            Location.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(64, 329);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 14;
            label5.Text = "Локация:";
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(585, 468);
            Controls.Add(label5);
            Controls.Add(Location);
            Controls.Add(Employee);
            Controls.Add(label4);
            Controls.Add(Sender);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Description);
            Controls.Add(Category);
            Controls.Add(flowLayoutPanel1);
            Name = "FormAdd";
            Text = "FormAdd";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonSave;
        private Button buttonCancel;
        public ComboBox Category;
        public TextBox Description;
        public ComboBox Sender;
        public ComboBox Employee;
        public ComboBox Location;
    }
}