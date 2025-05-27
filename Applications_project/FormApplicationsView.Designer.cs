namespace Applications_project
{
    partial class FormApplicationsView
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
            flowLayoutPanelTop = new FlowLayoutPanel();
            flowLayoutPanelFill = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Size = new Size(948, 50);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // flowLayoutPanelFill
            // 
            flowLayoutPanelFill.AutoScroll = true;
            flowLayoutPanelFill.Dock = DockStyle.Fill;
            flowLayoutPanelFill.Location = new Point(0, 50);
            flowLayoutPanelFill.Name = "flowLayoutPanelFill";
            flowLayoutPanelFill.Padding = new Padding(5);
            flowLayoutPanelFill.Size = new Size(948, 469);
            flowLayoutPanelFill.TabIndex = 1;
            // 
            // FormApplicationsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 519);
            Controls.Add(flowLayoutPanelFill);
            Controls.Add(flowLayoutPanelTop);
            Name = "FormApplicationsView";
            Text = "FormApplicationsView";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private FlowLayoutPanel flowLayoutPanelFill;
    }
}