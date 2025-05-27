namespace Applications_project
{
    partial class Authorization
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
            textBoxPassword = new TextBox();
            panelBottom = new Panel();
            buttonEnter = new Button();
            buttonSkip = new Button();
            labelPassword = new Label();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPassword.Location = new Point(45, 57);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(457, 39);
            textBoxPassword.TabIndex = 0;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonEnter);
            panelBottom.Controls.Add(buttonSkip);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 130);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(20);
            panelBottom.Size = new Size(544, 107);
            panelBottom.TabIndex = 1;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.White;
            buttonEnter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEnter.Location = new Point(291, 23);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(211, 61);
            buttonEnter.TabIndex = 1;
            buttonEnter.Text = "Войти";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // buttonSkip
            // 
            buttonSkip.BackColor = Color.White;
            buttonSkip.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSkip.Location = new Point(45, 23);
            buttonSkip.Name = "buttonSkip";
            buttonSkip.Size = new Size(211, 61);
            buttonSkip.TabIndex = 0;
            buttonSkip.Text = "Пропустить";
            buttonSkip.UseVisualStyleBackColor = false;
            buttonSkip.Click += buttonSkip_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPassword.Location = new Point(45, 22);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(195, 32);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Введите пароль:";
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 237);
            Controls.Add(labelPassword);
            Controls.Add(panelBottom);
            Controls.Add(textBoxPassword);
            Name = "Authorization";
            Text = "Authorization";
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassword;
        private Panel panelBottom;
        private Button buttonSkip;
        private Button buttonEnter;
        private Label labelPassword;
    }
}