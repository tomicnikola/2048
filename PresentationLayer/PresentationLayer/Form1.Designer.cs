namespace PresentationLayer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.NavbarTop = new System.Windows.Forms.Panel();
            this.NormalForm = new System.Windows.Forms.PictureBox();
            this.MinimizeForm = new System.Windows.Forms.PictureBox();
            this.MaximizeForm = new System.Windows.Forms.PictureBox();
            this.FormClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.SideWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButtonTopPlayers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButtonPersonalScores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButtonGame = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButtonLogIn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButtonRegister = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.panelForms = new System.Windows.Forms.Panel();
            this.label3MainForm = new System.Windows.Forms.Label();
            this.label2MainForm = new System.Windows.Forms.Label();
            this.labelMainFormText = new System.Windows.Forms.Label();
            this.bunifuElipseCurveSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimationSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimationSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.NavbarTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NormalForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.SideWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.Wrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavbarTop
            // 
            this.NavbarTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.NavbarTop.Controls.Add(this.NormalForm);
            this.NavbarTop.Controls.Add(this.MinimizeForm);
            this.NavbarTop.Controls.Add(this.MaximizeForm);
            this.NavbarTop.Controls.Add(this.FormClose);
            this.NavbarTop.Controls.Add(this.label1);
            this.NavbarTop.Controls.Add(this.MenuSidebar);
            this.AnimationSidebarBack.SetDecoration(this.NavbarTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this.NavbarTop, BunifuAnimatorNS.DecorationType.None);
            this.NavbarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavbarTop.Location = new System.Drawing.Point(0, 0);
            this.NavbarTop.Name = "NavbarTop";
            this.NavbarTop.Size = new System.Drawing.Size(1400, 80);
            this.NavbarTop.TabIndex = 0;
            this.NavbarTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavbarTop_MouseDown);
            this.NavbarTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NavbarTop_MouseMove);
            // 
            // NormalForm
            // 
            this.NormalForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimationSidebar.SetDecoration(this.NormalForm, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.NormalForm, BunifuAnimatorNS.DecorationType.None);
            this.NormalForm.Image = ((System.Drawing.Image)(resources.GetObject("NormalForm.Image")));
            this.NormalForm.Location = new System.Drawing.Point(1307, 23);
            this.NormalForm.Name = "NormalForm";
            this.NormalForm.Size = new System.Drawing.Size(30, 30);
            this.NormalForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NormalForm.TabIndex = 5;
            this.NormalForm.TabStop = false;
            this.NormalForm.Visible = false;
            this.NormalForm.Click += new System.EventHandler(this.NormalForm_Click);
            // 
            // MinimizeForm
            // 
            this.MinimizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimationSidebar.SetDecoration(this.MinimizeForm, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.MinimizeForm, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeForm.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeForm.Image")));
            this.MinimizeForm.Location = new System.Drawing.Point(1271, 23);
            this.MinimizeForm.Name = "MinimizeForm";
            this.MinimizeForm.Size = new System.Drawing.Size(30, 30);
            this.MinimizeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeForm.TabIndex = 4;
            this.MinimizeForm.TabStop = false;
            this.MinimizeForm.Click += new System.EventHandler(this.MinimizeForm_Click);
            // 
            // MaximizeForm
            // 
            this.MaximizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimationSidebar.SetDecoration(this.MaximizeForm, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.MaximizeForm, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeForm.Image = ((System.Drawing.Image)(resources.GetObject("MaximizeForm.Image")));
            this.MaximizeForm.Location = new System.Drawing.Point(1307, 23);
            this.MaximizeForm.Name = "MaximizeForm";
            this.MaximizeForm.Size = new System.Drawing.Size(30, 30);
            this.MaximizeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaximizeForm.TabIndex = 3;
            this.MaximizeForm.TabStop = false;
            this.MaximizeForm.Click += new System.EventHandler(this.MaximizeForm_Click);
            // 
            // FormClose
            // 
            this.FormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimationSidebar.SetDecoration(this.FormClose, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.FormClose, BunifuAnimatorNS.DecorationType.None);
            this.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("FormClose.Image")));
            this.FormClose.Location = new System.Drawing.Point(1343, 23);
            this.FormClose.Name = "FormClose";
            this.FormClose.Size = new System.Drawing.Size(30, 30);
            this.FormClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormClose.TabIndex = 2;
            this.FormClose.TabStop = false;
            this.FormClose.Click += new System.EventHandler(this.FormClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.AnimationSidebar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            // 
            // MenuSidebar
            // 
            this.AnimationSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(23, 23);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(30, 30);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 0;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // SideWrapper
            // 
            this.SideWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SideWrapper.Controls.Add(this.Sidebar);
            this.AnimationSidebarBack.SetDecoration(this.SideWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this.SideWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SideWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideWrapper.ForeColor = System.Drawing.Color.White;
            this.SideWrapper.Location = new System.Drawing.Point(0, 80);
            this.SideWrapper.Name = "SideWrapper";
            this.SideWrapper.Size = new System.Drawing.Size(300, 820);
            this.SideWrapper.TabIndex = 1;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.bunifuFlatButton2);
            this.Sidebar.Controls.Add(this.bunifuFlatButton1);
            this.Sidebar.Controls.Add(this.bunifuFlatButtonTopPlayers);
            this.Sidebar.Controls.Add(this.bunifuFlatButtonPersonalScores);
            this.Sidebar.Controls.Add(this.bunifuFlatButtonGame);
            this.Sidebar.Controls.Add(this.bunifuFlatButtonLogIn);
            this.Sidebar.Controls.Add(this.bunifuFlatButtonRegister);
            this.Sidebar.Controls.Add(this.LineSidebar);
            this.AnimationSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.Location = new System.Drawing.Point(15, 17);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(270, 784);
            this.Sidebar.TabIndex = 0;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "       ACHIEVEMENTS";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(8, 411);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(254, 48);
            this.bunifuFlatButton1.TabIndex = 7;
            this.bunifuFlatButton1.Text = "       ACHIEVEMENTS";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // bunifuFlatButtonTopPlayers
            // 
            this.bunifuFlatButtonTopPlayers.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonTopPlayers.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonTopPlayers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonTopPlayers.BorderRadius = 0;
            this.bunifuFlatButtonTopPlayers.ButtonText = "       TOP PLAYERS";
            this.bunifuFlatButtonTopPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.bunifuFlatButtonTopPlayers, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.bunifuFlatButtonTopPlayers, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonTopPlayers.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonTopPlayers.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonTopPlayers.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonTopPlayers.Iconimage")));
            this.bunifuFlatButtonTopPlayers.Iconimage_right = null;
            this.bunifuFlatButtonTopPlayers.Iconimage_right_Selected = null;
            this.bunifuFlatButtonTopPlayers.Iconimage_Selected = null;
            this.bunifuFlatButtonTopPlayers.IconMarginLeft = 0;
            this.bunifuFlatButtonTopPlayers.IconMarginRight = 0;
            this.bunifuFlatButtonTopPlayers.IconRightVisible = true;
            this.bunifuFlatButtonTopPlayers.IconRightZoom = 0D;
            this.bunifuFlatButtonTopPlayers.IconVisible = true;
            this.bunifuFlatButtonTopPlayers.IconZoom = 50D;
            this.bunifuFlatButtonTopPlayers.IsTab = false;
            this.bunifuFlatButtonTopPlayers.Location = new System.Drawing.Point(8, 357);
            this.bunifuFlatButtonTopPlayers.Name = "bunifuFlatButtonTopPlayers";
            this.bunifuFlatButtonTopPlayers.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonTopPlayers.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonTopPlayers.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonTopPlayers.selected = false;
            this.bunifuFlatButtonTopPlayers.Size = new System.Drawing.Size(254, 48);
            this.bunifuFlatButtonTopPlayers.TabIndex = 6;
            this.bunifuFlatButtonTopPlayers.Text = "       TOP PLAYERS";
            this.bunifuFlatButtonTopPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonTopPlayers.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButtonTopPlayers.TextFont = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonTopPlayers.Click += new System.EventHandler(this.bunifuFlatButtonTopPlayers_Click);
            // 
            // bunifuFlatButtonPersonalScores
            // 
            this.bunifuFlatButtonPersonalScores.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonPersonalScores.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonPersonalScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonPersonalScores.BorderRadius = 0;
            this.bunifuFlatButtonPersonalScores.ButtonText = "       PERSONAL SCORES";
            this.bunifuFlatButtonPersonalScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.bunifuFlatButtonPersonalScores, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.bunifuFlatButtonPersonalScores, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonPersonalScores.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonPersonalScores.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonPersonalScores.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonPersonalScores.Iconimage")));
            this.bunifuFlatButtonPersonalScores.Iconimage_right = null;
            this.bunifuFlatButtonPersonalScores.Iconimage_right_Selected = null;
            this.bunifuFlatButtonPersonalScores.Iconimage_Selected = null;
            this.bunifuFlatButtonPersonalScores.IconMarginLeft = 0;
            this.bunifuFlatButtonPersonalScores.IconMarginRight = 0;
            this.bunifuFlatButtonPersonalScores.IconRightVisible = true;
            this.bunifuFlatButtonPersonalScores.IconRightZoom = 0D;
            this.bunifuFlatButtonPersonalScores.IconVisible = true;
            this.bunifuFlatButtonPersonalScores.IconZoom = 50D;
            this.bunifuFlatButtonPersonalScores.IsTab = false;
            this.bunifuFlatButtonPersonalScores.Location = new System.Drawing.Point(8, 303);
            this.bunifuFlatButtonPersonalScores.Name = "bunifuFlatButtonPersonalScores";
            this.bunifuFlatButtonPersonalScores.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonPersonalScores.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonPersonalScores.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonPersonalScores.selected = false;
            this.bunifuFlatButtonPersonalScores.Size = new System.Drawing.Size(254, 48);
            this.bunifuFlatButtonPersonalScores.TabIndex = 5;
            this.bunifuFlatButtonPersonalScores.Text = "       PERSONAL SCORES";
            this.bunifuFlatButtonPersonalScores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonPersonalScores.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButtonPersonalScores.TextFont = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonPersonalScores.Click += new System.EventHandler(this.bunifuFlatButtonPersonalScores_Click);
            // 
            // bunifuFlatButtonGame
            // 
            this.bunifuFlatButtonGame.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonGame.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonGame.BorderRadius = 0;
            this.bunifuFlatButtonGame.ButtonText = "       PLAY";
            this.bunifuFlatButtonGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.bunifuFlatButtonGame, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.bunifuFlatButtonGame, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonGame.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonGame.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonGame.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonGame.Iconimage")));
            this.bunifuFlatButtonGame.Iconimage_right = null;
            this.bunifuFlatButtonGame.Iconimage_right_Selected = null;
            this.bunifuFlatButtonGame.Iconimage_Selected = null;
            this.bunifuFlatButtonGame.IconMarginLeft = 0;
            this.bunifuFlatButtonGame.IconMarginRight = 0;
            this.bunifuFlatButtonGame.IconRightVisible = true;
            this.bunifuFlatButtonGame.IconRightZoom = 0D;
            this.bunifuFlatButtonGame.IconVisible = true;
            this.bunifuFlatButtonGame.IconZoom = 50D;
            this.bunifuFlatButtonGame.IsTab = false;
            this.bunifuFlatButtonGame.Location = new System.Drawing.Point(8, 249);
            this.bunifuFlatButtonGame.Name = "bunifuFlatButtonGame";
            this.bunifuFlatButtonGame.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonGame.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonGame.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonGame.selected = false;
            this.bunifuFlatButtonGame.Size = new System.Drawing.Size(254, 48);
            this.bunifuFlatButtonGame.TabIndex = 4;
            this.bunifuFlatButtonGame.Text = "       PLAY";
            this.bunifuFlatButtonGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonGame.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButtonGame.TextFont = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonGame.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButtonLogIn
            // 
            this.bunifuFlatButtonLogIn.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonLogIn.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonLogIn.BorderRadius = 0;
            this.bunifuFlatButtonLogIn.ButtonText = "       LOG IN";
            this.bunifuFlatButtonLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.bunifuFlatButtonLogIn, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.bunifuFlatButtonLogIn, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonLogIn.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonLogIn.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonLogIn.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonLogIn.Iconimage")));
            this.bunifuFlatButtonLogIn.Iconimage_right = null;
            this.bunifuFlatButtonLogIn.Iconimage_right_Selected = null;
            this.bunifuFlatButtonLogIn.Iconimage_Selected = null;
            this.bunifuFlatButtonLogIn.IconMarginLeft = 0;
            this.bunifuFlatButtonLogIn.IconMarginRight = 0;
            this.bunifuFlatButtonLogIn.IconRightVisible = true;
            this.bunifuFlatButtonLogIn.IconRightZoom = 0D;
            this.bunifuFlatButtonLogIn.IconVisible = true;
            this.bunifuFlatButtonLogIn.IconZoom = 50D;
            this.bunifuFlatButtonLogIn.IsTab = false;
            this.bunifuFlatButtonLogIn.Location = new System.Drawing.Point(8, 195);
            this.bunifuFlatButtonLogIn.Name = "bunifuFlatButtonLogIn";
            this.bunifuFlatButtonLogIn.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonLogIn.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonLogIn.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonLogIn.selected = false;
            this.bunifuFlatButtonLogIn.Size = new System.Drawing.Size(254, 48);
            this.bunifuFlatButtonLogIn.TabIndex = 3;
            this.bunifuFlatButtonLogIn.Text = "       LOG IN";
            this.bunifuFlatButtonLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonLogIn.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButtonLogIn.TextFont = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonLogIn.Click += new System.EventHandler(this.bunifuFlatButtonLogIn_Click);
            // 
            // bunifuFlatButtonRegister
            // 
            this.bunifuFlatButtonRegister.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonRegister.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonRegister.BorderRadius = 0;
            this.bunifuFlatButtonRegister.ButtonText = "       REGISTER";
            this.bunifuFlatButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.bunifuFlatButtonRegister, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.bunifuFlatButtonRegister, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonRegister.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonRegister.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonRegister.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonRegister.Iconimage")));
            this.bunifuFlatButtonRegister.Iconimage_right = null;
            this.bunifuFlatButtonRegister.Iconimage_right_Selected = null;
            this.bunifuFlatButtonRegister.Iconimage_Selected = null;
            this.bunifuFlatButtonRegister.IconMarginLeft = 0;
            this.bunifuFlatButtonRegister.IconMarginRight = 0;
            this.bunifuFlatButtonRegister.IconRightVisible = true;
            this.bunifuFlatButtonRegister.IconRightZoom = 0D;
            this.bunifuFlatButtonRegister.IconVisible = true;
            this.bunifuFlatButtonRegister.IconZoom = 50D;
            this.bunifuFlatButtonRegister.IsTab = false;
            this.bunifuFlatButtonRegister.Location = new System.Drawing.Point(8, 141);
            this.bunifuFlatButtonRegister.Name = "bunifuFlatButtonRegister";
            this.bunifuFlatButtonRegister.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonRegister.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonRegister.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonRegister.selected = false;
            this.bunifuFlatButtonRegister.Size = new System.Drawing.Size(252, 48);
            this.bunifuFlatButtonRegister.TabIndex = 2;
            this.bunifuFlatButtonRegister.Text = "       REGISTER";
            this.bunifuFlatButtonRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonRegister.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButtonRegister.TextFont = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonRegister.Click += new System.EventHandler(this.bunifuFlatButtonRegister_Click);
            // 
            // LineSidebar
            // 
            this.LineSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimationSidebarBack.SetDecoration(this.LineSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this.LineSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineSidebar.LineThickness = 1;
            this.LineSidebar.Location = new System.Drawing.Point(10, 94);
            this.LineSidebar.Name = "LineSidebar";
            this.LineSidebar.Size = new System.Drawing.Size(252, 1);
            this.LineSidebar.TabIndex = 0;
            this.LineSidebar.Transparency = 255;
            this.LineSidebar.Vertical = false;
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Wrapper.Controls.Add(this.panelForms);
            this.Wrapper.Controls.Add(this.label3MainForm);
            this.Wrapper.Controls.Add(this.label2MainForm);
            this.Wrapper.Controls.Add(this.labelMainFormText);
            this.AnimationSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(300, 80);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1100, 820);
            this.Wrapper.TabIndex = 2;
            // 
            // panelForms
            // 
            this.panelForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.AnimationSidebarBack.SetDecoration(this.panelForms, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this.panelForms, BunifuAnimatorNS.DecorationType.None);
            this.panelForms.Location = new System.Drawing.Point(17, 17);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(1056, 784);
            this.panelForms.TabIndex = 3;
            // 
            // label3MainForm
            // 
            this.label3MainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3MainForm.AutoSize = true;
            this.AnimationSidebar.SetDecoration(this.label3MainForm, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.label3MainForm, BunifuAnimatorNS.DecorationType.None);
            this.label3MainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3MainForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.label3MainForm.Location = new System.Drawing.Point(468, 426);
            this.label3MainForm.Name = "label3MainForm";
            this.label3MainForm.Size = new System.Drawing.Size(153, 72);
            this.label3MainForm.TabIndex = 2;
            this.label3MainForm.Text = "Danilo Korać\r\nNenad Penezić\r\nNikola Tomić\r\n";
            this.label3MainForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2MainForm
            // 
            this.label2MainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2MainForm.AutoSize = true;
            this.AnimationSidebar.SetDecoration(this.label2MainForm, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.label2MainForm, BunifuAnimatorNS.DecorationType.None);
            this.label2MainForm.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2MainForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.label2MainForm.Location = new System.Drawing.Point(495, 387);
            this.label2MainForm.Name = "label2MainForm";
            this.label2MainForm.Size = new System.Drawing.Size(105, 30);
            this.label2MainForm.TabIndex = 1;
            this.label2MainForm.Text = "MADE BY";
            this.label2MainForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMainFormText
            // 
            this.labelMainFormText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMainFormText.AutoSize = true;
            this.AnimationSidebar.SetDecoration(this.labelMainFormText, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.labelMainFormText, BunifuAnimatorNS.DecorationType.None);
            this.labelMainFormText.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainFormText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.labelMainFormText.Location = new System.Drawing.Point(450, 301);
            this.labelMainFormText.Name = "labelMainFormText";
            this.labelMainFormText.Size = new System.Drawing.Size(185, 86);
            this.labelMainFormText.TabIndex = 0;
            this.labelMainFormText.Text = "2048";
            this.labelMainFormText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipseCurveSidebar
            // 
            this.bunifuElipseCurveSidebar.ElipseRadius = 7;
            this.bunifuElipseCurveSidebar.TargetControl = this.Sidebar;
            // 
            // AnimationSidebar
            // 
            this.AnimationSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimationSidebar.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.AnimationSidebar.DefaultAnimation = animation1;
            // 
            // AnimationSidebarBack
            // 
            this.AnimationSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimationSidebarBack.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.AnimationSidebarBack.DefaultAnimation = animation2;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "       ABOUT";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebarBack.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(8, 465);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(254, 48);
            this.bunifuFlatButton2.TabIndex = 8;
            this.bunifuFlatButton2.Text = "       ABOUT";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SideWrapper);
            this.Controls.Add(this.NavbarTop);
            this.AnimationSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.NavbarTop.ResumeLayout(false);
            this.NavbarTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NormalForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            this.SideWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Wrapper.ResumeLayout(false);
            this.Wrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavbarTop;
        private System.Windows.Forms.PictureBox NormalForm;
        private System.Windows.Forms.PictureBox MinimizeForm;
        private System.Windows.Forms.PictureBox MaximizeForm;
        private System.Windows.Forms.PictureBox FormClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.Panel SideWrapper;
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuSeparator LineSidebar;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonLogIn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonRegister;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseCurveSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimationSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimationSidebarBack;
        private System.Windows.Forms.Label labelMainFormText;
        private System.Windows.Forms.Label label3MainForm;
        private System.Windows.Forms.Label label2MainForm;
        private System.Windows.Forms.Panel panelForms;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonGame;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonPersonalScores;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonTopPlayers;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}

