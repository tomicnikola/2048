namespace PresentationLayer
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.labelCreateAccount = new System.Windows.Forms.Label();
            this.bunifuSeparatorRegister = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuTileButtonRegister = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTextboxUsername = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextboxPassword = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextboxIGN = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuThinButtonSignUp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // labelCreateAccount
            // 
            this.labelCreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCreateAccount.AutoSize = true;
            this.labelCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.labelCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateAccount.ForeColor = System.Drawing.Color.White;
            this.labelCreateAccount.Location = new System.Drawing.Point(366, 248);
            this.labelCreateAccount.Name = "labelCreateAccount";
            this.labelCreateAccount.Size = new System.Drawing.Size(290, 42);
            this.labelCreateAccount.TabIndex = 0;
            this.labelCreateAccount.Text = "Create Account";
            // 
            // bunifuSeparatorRegister
            // 
            this.bunifuSeparatorRegister.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparatorRegister.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparatorRegister.LineThickness = 1;
            this.bunifuSeparatorRegister.Location = new System.Drawing.Point(401, 290);
            this.bunifuSeparatorRegister.Name = "bunifuSeparatorRegister";
            this.bunifuSeparatorRegister.Size = new System.Drawing.Size(228, 35);
            this.bunifuSeparatorRegister.TabIndex = 1;
            this.bunifuSeparatorRegister.Transparency = 255;
            this.bunifuSeparatorRegister.Vertical = false;
            // 
            // bunifuTileButtonRegister
            // 
            this.bunifuTileButtonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuTileButtonRegister.color = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuTileButtonRegister.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuTileButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButtonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButtonRegister.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButtonRegister.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButtonRegister.Image")));
            this.bunifuTileButtonRegister.ImagePosition = 40;
            this.bunifuTileButtonRegister.ImageZoom = 40;
            this.bunifuTileButtonRegister.LabelPosition = 41;
            this.bunifuTileButtonRegister.LabelText = "";
            this.bunifuTileButtonRegister.Location = new System.Drawing.Point(448, 113);
            this.bunifuTileButtonRegister.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButtonRegister.Name = "bunifuTileButtonRegister";
            this.bunifuTileButtonRegister.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButtonRegister.TabIndex = 8;
            // 
            // bunifuTextboxUsername
            // 
            this.bunifuTextboxUsername.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextboxUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextboxUsername.BackgroundImage")));
            this.bunifuTextboxUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextboxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuTextboxUsername.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextboxUsername.Icon")));
            this.bunifuTextboxUsername.Location = new System.Drawing.Point(375, 348);
            this.bunifuTextboxUsername.Name = "bunifuTextboxUsername";
            this.bunifuTextboxUsername.Size = new System.Drawing.Size(278, 42);
            this.bunifuTextboxUsername.TabIndex = 9;
            this.bunifuTextboxUsername.text = "Username";
            this.bunifuTextboxUsername.Enter += new System.EventHandler(this.txtUsername);
            this.bunifuTextboxUsername.Leave += new System.EventHandler(this.leaveUsername);
            // 
            // bunifuTextboxPassword
            // 
            this.bunifuTextboxPassword.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextboxPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextboxPassword.BackgroundImage")));
            this.bunifuTextboxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuTextboxPassword.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextboxPassword.Icon")));
            this.bunifuTextboxPassword.Location = new System.Drawing.Point(375, 414);
            this.bunifuTextboxPassword.Name = "bunifuTextboxPassword";
            this.bunifuTextboxPassword.Size = new System.Drawing.Size(278, 42);
            this.bunifuTextboxPassword.TabIndex = 10;
            this.bunifuTextboxPassword.text = "Password";
            this.bunifuTextboxPassword.Enter += new System.EventHandler(this.txtPassword);
            this.bunifuTextboxPassword.Leave += new System.EventHandler(this.leavePassword);
            // 
            // bunifuTextboxIGN
            // 
            this.bunifuTextboxIGN.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextboxIGN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextboxIGN.BackgroundImage")));
            this.bunifuTextboxIGN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextboxIGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextboxIGN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuTextboxIGN.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextboxIGN.Icon")));
            this.bunifuTextboxIGN.Location = new System.Drawing.Point(375, 479);
            this.bunifuTextboxIGN.Name = "bunifuTextboxIGN";
            this.bunifuTextboxIGN.Size = new System.Drawing.Size(278, 42);
            this.bunifuTextboxIGN.TabIndex = 11;
            this.bunifuTextboxIGN.text = "IGN (In Game Name)";
            this.bunifuTextboxIGN.Enter += new System.EventHandler(this.txtIGN);
            this.bunifuTextboxIGN.Leave += new System.EventHandler(this.leaveIGN);
            // 
            // bunifuThinButtonSignUp
            // 
            this.bunifuThinButtonSignUp.ActiveBorderThickness = 1;
            this.bunifuThinButtonSignUp.ActiveCornerRadius = 20;
            this.bunifuThinButtonSignUp.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuThinButtonSignUp.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButtonSignUp.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuThinButtonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.bunifuThinButtonSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButtonSignUp.BackgroundImage")));
            this.bunifuThinButtonSignUp.ButtonText = "SIGN UP";
            this.bunifuThinButtonSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButtonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButtonSignUp.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButtonSignUp.IdleBorderThickness = 1;
            this.bunifuThinButtonSignUp.IdleCornerRadius = 20;
            this.bunifuThinButtonSignUp.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButtonSignUp.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButtonSignUp.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButtonSignUp.Location = new System.Drawing.Point(448, 565);
            this.bunifuThinButtonSignUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButtonSignUp.Name = "bunifuThinButtonSignUp";
            this.bunifuThinButtonSignUp.Size = new System.Drawing.Size(128, 49);
            this.bunifuThinButtonSignUp.TabIndex = 13;
            this.bunifuThinButtonSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButtonSignUp.Click += new System.EventHandler(this.bunifuThinButtonSignUp_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1056, 784);
            this.Controls.Add(this.bunifuThinButtonSignUp);
            this.Controls.Add(this.bunifuTextboxIGN);
            this.Controls.Add(this.bunifuTextboxPassword);
            this.Controls.Add(this.bunifuTextboxUsername);
            this.Controls.Add(this.bunifuTileButtonRegister);
            this.Controls.Add(this.bunifuSeparatorRegister);
            this.Controls.Add(this.labelCreateAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreateAccount;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparatorRegister;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButtonRegister;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextboxUsername;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextboxPassword;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextboxIGN;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButtonSignUp;
    }
}