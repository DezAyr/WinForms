using System.Windows.Forms;

namespace Windows_Forms_Sample
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            UserNameLbl = new Label();
            PasswordLbl = new Label();
            UsernameTxtbox = new TextBox();
            PasswordTxtBox = new TextBox();
            LoginBtn = new Button();
            CancelBtn = new Button();
            ErrorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ErrorProvider1).BeginInit();
            SuspendLayout();
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.Location = new Point(106, 104);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(95, 25);
            UserNameLbl.TabIndex = 0;
            UserNameLbl.Text = "Username:";
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Location = new Point(106, 172);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(87, 25);
            PasswordLbl.TabIndex = 1;
            PasswordLbl.Text = "Password";
            // 
            // UsernameTxtbox
            // 
            UsernameTxtbox.Location = new Point(312, 101);
            UsernameTxtbox.Name = "UsernameTxtbox";
            UsernameTxtbox.Size = new Size(340, 31);
            UsernameTxtbox.TabIndex = 2;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Location = new Point(312, 169);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.Size = new Size(340, 31);
            PasswordTxtBox.TabIndex = 3;
            PasswordTxtBox.PasswordChar = '*';
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(323, 237);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(112, 34);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += button1_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(498, 237);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(112, 34);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // ErrorProvider1
            // 
            ErrorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTxtBox);
            Controls.Add(UsernameTxtbox);
            Controls.Add(PasswordLbl);
            Controls.Add(UserNameLbl);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ErrorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        #endregion

        private Label UserNameLbl;
        private Label PasswordLbl;
        private TextBox UsernameTxtbox;
        private TextBox PasswordTxtBox;
        private Button LoginBtn;
        private Button CancelBtn;
        private ErrorProvider ErrorProvider1;
    }
}
