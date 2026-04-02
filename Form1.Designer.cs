namespace LoginScreen
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
            lblAppName = new Label();
            txtID = new TextBox();
            btnLogin = new Button();
            txtPW = new TextBox();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = SystemColors.Control;
            lblAppName.Font = new Font("한컴 말랑말랑 Bold", 33F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = SystemColors.MenuHighlight;
            lblAppName.Location = new Point(165, 75);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(294, 71);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "⚝ Login ⚝";
            lblAppName.Click += label1_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("한컴 말랑말랑 Regular", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = SystemColors.ScrollBar;
            txtID.Location = new Point(126, 175);
            txtID.Name = "txtID";
            txtID.Size = new Size(372, 42);
            txtID.TabIndex = 1;
            txtID.Text = "아이디";
            txtID.UseWaitCursor = true;
            txtID.TextChanged += txtID_TextChanged;
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Desktop;
            btnLogin.Font = new Font("한컴 말랑말랑 Bold", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 129);
            btnLogin.Location = new Point(216, 335);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(185, 44);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("한컴 말랑말랑 Regular", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = SystemColors.ScrollBar;
            txtPW.Location = new Point(126, 235);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(372, 42);
            txtPW.TabIndex = 2;
            txtPW.Text = "패스워드";
            txtPW.UseWaitCursor = true;
            txtPW.TextChanged += txtPW_TextChanged;
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(126, 293);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(282, 20);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못되었습니다.";
            lblErrorMsg.Visible = false;
            lblErrorMsg.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(640, 450);
            Controls.Add(lblErrorMsg);
            Controls.Add(txtPW);
            Controls.Add(btnLogin);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private Button btnLogin;
        private TextBox txtPW;
        private Label lblErrorMsg;
    }
}
