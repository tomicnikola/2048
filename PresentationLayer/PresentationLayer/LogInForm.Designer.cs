namespace PresentationLayer
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.bunifuThinButtonLogIn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTextboxPasswordLogIn = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextboxUsernameLogIn = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTileButtonRegister = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuSeparatorRegister = new Bunifu.Framework.UI.BunifuSeparator();
            this.labelLogIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuThinButtonLogIn
            // 
            this.bunifuThinButtonLogIn.ActiveBorderThickness = 1;
            this.bunifuThinButtonLogIn.ActiveCornerRadius = 20;
            this.bunifuThinButtonLogIn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuThinButtonLogIn.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButtonLogIn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuThinButtonLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.bunifuThinButtonLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButtonLogIn.BackgroundImage")));
            this.bunifuThinButtonLogIn.ButtonText = "LOGIN";
            this.bunifuThinButtonLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButtonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButtonLogIn.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButtonLogIn.IdleBorderThickness = 1;
            this.bunifuThinButtonLogIn.IdleCornerRadius = 20;
            this.bunifuThinButtonLogIn.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButtonLogIn.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButtonLogIn.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButtonLogIn.Location = new System.Drawing.Point(446, 535);
            this.bunifuThinButtonLogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButtonLogIn.Name = "bunifuThinButtonLogIn";
            this.bunifuThinButtonLogIn.Size = new System.Drawing.Size(128, 49);
            this.bunifuThinButtonLogIn.TabIndex = 20;
            this.bunifuThinButtonLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButtonLogIn.Click += new System.EventHandler(this.bunifuThinButtonLogIn_Click);
            // 
            // bunifuTextboxPasswordLogIn
            // 
            this.bunifuTextboxPasswordLogIn.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextboxPasswordLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextboxPasswordLogIn.BackgroundImage")));
            this.bunifuTextboxPasswordLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextboxPasswordLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextboxPasswordLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuTextboxPasswordLogIn.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextboxPasswordLogIn.Icon")));
            this.bunifuTextboxPasswordLogIn.Location = new System.Drawing.Point(373, 454);
            this.bunifuTextboxPasswordLogIn.Name = "bunifuTextboxPasswordLogIn";
            this.bunifuTextboxPasswordLogIn.Size = new System.Drawing.Size(278, 42);
            this.bunifuTextboxPasswordLogIn.TabIndex = 18;
            this.bunifuTextboxPasswordLogIn.text = "Password";
            this.bunifuTextboxPasswordLogIn.Enter += new System.EventHandler(this.passLogIn);
            this.bunifuTextboxPasswordLogIn.Leave += new System.EventHandler(this.leavepassLogIn);
            // 
            // bunifuTextboxUsernameLogIn
            // 
            this.bunifuTextboxUsernameLogIn.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextboxUsernameLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextboxUsernameLogIn.BackgroundImage")));
            this.bunifuTextboxUsernameLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextboxUsernameLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextboxUsernameLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.bunifuTextboxUsernameLogIn.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextboxUsernameLogIn.Icon")));
            this.bunifuTextboxUsernameLogIn.Location = new System.Drawing.Point(373, 386);
            this.bunifuTextboxUsernameLogIn.Name = "bunifuTextboxUsernameLogIn";
            this.bunifuTextboxUsernameLogIn.Size = new System.Drawing.Size(278, 42);
            this.bunifuTextboxUsernameLogIn.TabIndex = 17;
            this.bunifuTextboxUsernameLogIn.text = "Username";
            this.bunifuTextboxUsernameLogIn.Enter += new System.EventHandler(this.txtLogIn);
            this.bunifuTextboxUsernameLogIn.Leave += new System.EventHandler(this.leaveLogIn);
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
            this.bunifuTileButtonRegister.Location = new System.Drawing.Point(446, 125);
            this.bunifuTileButtonRegister.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButtonRegister.Name = "bunifuTileButtonRegister";
            this.bunifuTileButtonRegister.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButtonRegister.TabIndex = 16;
            // 
            // bunifuSeparatorRegister
            // 
            this.bunifuSeparatorRegister.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparatorRegister.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparatorRegister.LineThickness = 1;
            this.bunifuSeparatorRegister.Location = new System.Drawing.Point(347, 323);
            this.bunifuSeparatorRegister.Name = "bunifuSeparatorRegister";
            this.bunifuSeparatorRegister.Size = new System.Drawing.Size(342, 35);
            this.bunifuSeparatorRegister.TabIndex = 15;
            this.bunifuSeparatorRegister.Transparency = 255;
            this.bunifuSeparatorRegister.Vertical = false;
            // 
            // labelLogIn
            // 
            this.labelLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.BackColor = System.Drawing.Color.Transparent;
            this.labelLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogIn.ForeColor = System.Drawing.Color.White;
            this.labelLogIn.Location = new System.Drawing.Point(314, 283);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(405, 31);
            this.labelLogIn.TabIndex = 14;
            this.labelLogIn.Text = "Get Started From Login Below";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1056, 784);
            this.Controls.Add(this.bunifuThinButtonLogIn);
            this.Controls.Add(this.bunifuTextboxPasswordLogIn);
            this.Controls.Add(this.bunifuTextboxUsernameLogIn);
            this.Controls.Add(this.bunifuTileButtonRegister);
            this.Controls.Add(this.bunifuSeparatorRegister);
            this.Controls.Add(this.labelLogIn);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButtonLogIn;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextboxPasswordLogIn;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextboxUsernameLogIn;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButtonRegister;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparatorRegister;
        private System.Windows.Forms.Label labelLogIn;
    }
}