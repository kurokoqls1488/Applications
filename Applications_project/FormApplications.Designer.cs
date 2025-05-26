namespace Applications_project
{
    partial class FormApplications
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
            fileSystemWatcher1 = new FileSystemWatcher();
            flowLayoutPanelTop = new FlowLayoutPanel();
            buttonAddTask = new Button();
            buttonUpdateTask = new Button();
            buttonDeleteTask = new Button();
            buttonCheckHistory = new Button();
            flowLayoutPanelFill = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            flowLayoutPanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.Controls.Add(buttonAddTask);
            flowLayoutPanelTop.Controls.Add(buttonUpdateTask);
            flowLayoutPanelTop.Controls.Add(buttonDeleteTask);
            flowLayoutPanelTop.Controls.Add(buttonCheckHistory);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(20);
            flowLayoutPanelTop.Size = new Size(938, 100);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // buttonAddTask
            // 
            buttonAddTask.BackColor = Color.White;
            buttonAddTask.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddTask.Location = new Point(23, 23);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(176, 56);
            buttonAddTask.TabIndex = 0;
            buttonAddTask.Text = "Добавить задачу";
            buttonAddTask.UseVisualStyleBackColor = false;
            buttonAddTask.Click += buttonAddTask_Click;
            // 
            // buttonUpdateTask
            // 
            buttonUpdateTask.BackColor = Color.White;
            buttonUpdateTask.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonUpdateTask.Location = new Point(205, 23);
            buttonUpdateTask.Name = "buttonUpdateTask";
            buttonUpdateTask.Size = new Size(225, 56);
            buttonUpdateTask.TabIndex = 1;
            buttonUpdateTask.Text = "Редактировать задачу";
            buttonUpdateTask.UseVisualStyleBackColor = false;
            buttonUpdateTask.Click += buttonUpdateTask_Click;
            // 
            // buttonDeleteTask
            // 
            buttonDeleteTask.BackColor = Color.White;
            buttonDeleteTask.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDeleteTask.Location = new Point(436, 23);
            buttonDeleteTask.Name = "buttonDeleteTask";
            buttonDeleteTask.Size = new Size(176, 56);
            buttonDeleteTask.TabIndex = 2;
            buttonDeleteTask.Text = "Удалить задачу";
            buttonDeleteTask.UseVisualStyleBackColor = false;
            buttonDeleteTask.Click += buttonDeleteTask_Click;
            // 
            // buttonCheckHistory
            // 
            buttonCheckHistory.BackColor = Color.White;
            buttonCheckHistory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCheckHistory.Location = new Point(618, 23);
            buttonCheckHistory.Name = "buttonCheckHistory";
            buttonCheckHistory.Size = new Size(294, 56);
            buttonCheckHistory.TabIndex = 3;
            buttonCheckHistory.Text = "Посмотреть историю задач";
            buttonCheckHistory.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanelFill
            // 
            flowLayoutPanelFill.AutoScroll = true;
            flowLayoutPanelFill.Dock = DockStyle.Fill;
            flowLayoutPanelFill.Location = new Point(0, 100);
            flowLayoutPanelFill.Name = "flowLayoutPanelFill";
            flowLayoutPanelFill.Padding = new Padding(5);
            flowLayoutPanelFill.Size = new Size(938, 433);
            flowLayoutPanelFill.TabIndex = 1;
            // 
            // FormApplications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(938, 533);
            Controls.Add(flowLayoutPanelFill);
            Controls.Add(flowLayoutPanelTop);
            Name = "FormApplications";
            Text = "FormApplications";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            flowLayoutPanelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private FlowLayoutPanel flowLayoutPanelTop;
        private FlowLayoutPanel flowLayoutPanelFill;
        private Button buttonAddTask;
        private Button buttonUpdateTask;
        private Button buttonDeleteTask;
        private Button buttonCheckHistory;
    }
}
