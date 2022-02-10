namespace PresentationLayer
{
    partial class TopPlayers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopPlayers));
            this.labelTP = new System.Windows.Forms.Label();
            this.labelMoves = new System.Windows.Forms.Label();
            this.labelDT = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.label1TextMain = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.listBoxTopPlayers = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTP
            // 
            this.labelTP.AutoSize = true;
            this.labelTP.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTP.ForeColor = System.Drawing.Color.White;
            this.labelTP.Location = new System.Drawing.Point(694, 116);
            this.labelTP.Name = "labelTP";
            this.labelTP.Size = new System.Drawing.Size(145, 32);
            this.labelTP.TabIndex = 76;
            this.labelTP.Text = "Time Played";
            // 
            // labelMoves
            // 
            this.labelMoves.AutoSize = true;
            this.labelMoves.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoves.ForeColor = System.Drawing.Color.White;
            this.labelMoves.Location = new System.Drawing.Point(576, 116);
            this.labelMoves.Name = "labelMoves";
            this.labelMoves.Size = new System.Drawing.Size(86, 32);
            this.labelMoves.TabIndex = 75;
            this.labelMoves.Text = "Moves";
            // 
            // labelDT
            // 
            this.labelDT.AutoSize = true;
            this.labelDT.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDT.ForeColor = System.Drawing.Color.White;
            this.labelDT.Location = new System.Drawing.Point(330, 116);
            this.labelDT.Name = "labelDT";
            this.labelDT.Size = new System.Drawing.Size(172, 32);
            this.labelDT.TabIndex = 74;
            this.labelDT.Text = "Date and Time";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(181, 116);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(74, 32);
            this.labelScore.TabIndex = 73;
            this.labelScore.Text = "Score";
            // 
            // label1TextMain
            // 
            this.label1TextMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1TextMain.AutoSize = true;
            this.label1TextMain.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1TextMain.ForeColor = System.Drawing.Color.White;
            this.label1TextMain.Location = new System.Drawing.Point(433, 30);
            this.label1TextMain.Name = "label1TextMain";
            this.label1TextMain.Size = new System.Drawing.Size(201, 40);
            this.label1TextMain.TabIndex = 72;
            this.label1TextMain.Text = "TOP PLAYERS";
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(359, 30);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxUser.TabIndex = 71;
            this.pictureBoxUser.TabStop = false;
            // 
            // listBoxTopPlayers
            // 
            this.listBoxTopPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTopPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.listBoxTopPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTopPlayers.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTopPlayers.ForeColor = System.Drawing.Color.White;
            this.listBoxTopPlayers.FormattingEnabled = true;
            this.listBoxTopPlayers.ItemHeight = 30;
            this.listBoxTopPlayers.Location = new System.Drawing.Point(89, 151);
            this.listBoxTopPlayers.Name = "listBoxTopPlayers";
            this.listBoxTopPlayers.Size = new System.Drawing.Size(886, 600);
            this.listBoxTopPlayers.TabIndex = 70;
            // 
            // TopPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1056, 784);
            this.Controls.Add(this.labelTP);
            this.Controls.Add(this.labelMoves);
            this.Controls.Add(this.labelDT);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label1TextMain);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.listBoxTopPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TopPlayers";
            this.Text = "TopPlayers";
            this.Load += new System.EventHandler(this.TopPlayers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTP;
        private System.Windows.Forms.Label labelMoves;
        private System.Windows.Forms.Label labelDT;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label1TextMain;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.ListBox listBoxTopPlayers;
    }
}