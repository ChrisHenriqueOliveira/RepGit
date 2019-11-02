namespace APS20192
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.btnRegisterForm = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlInitialScreen = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.picFingerPrint = new System.Windows.Forms.PictureBox();
            this.pnlRegistered = new System.Windows.Forms.Panel();
            this.btnBack = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblAbout = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLevel2Menu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLevel3Menu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRequestAccess = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btnLevel1Menu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLogout = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnUsersScreen = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblLoggedAs = new System.Windows.Forms.Label();
            this.lblHomeTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.btnBackFromUsers = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblUsersTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.lblCompareStatus = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlLvl1Access = new System.Windows.Forms.Panel();
            this.btnBack1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblLvl1Title = new MaterialSkin.Controls.MaterialLabel();
            this.pnlLvl2Access = new System.Windows.Forms.Panel();
            this.lblBack2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblLevel2Title = new MaterialSkin.Controls.MaterialLabel();
            this.pnlLvl3Access = new System.Windows.Forms.Panel();
            this.btnBack3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblLevel3Title = new MaterialSkin.Controls.MaterialLabel();
            this.pnlInitialScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerPrint)).BeginInit();
            this.pnlRegistered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHome.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlUsers.SuspendLayout();
            this.pnlLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlLvl1Access.SuspendLayout();
            this.pnlLvl2Access.SuspendLayout();
            this.pnlLvl3Access.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtID
            // 
            this.txtID.Depth = 0;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Hint = "User ID";
            this.txtID.Location = new System.Drawing.Point(85, 69);
            this.txtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.Size = new System.Drawing.Size(260, 23);
            this.txtID.TabIndex = 4;
            this.txtID.UseSystemPasswordChar = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(189, 24);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(52, 19);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "LOGIN";
            // 
            // btnRegisterForm
            // 
            this.btnRegisterForm.AutoSize = true;
            this.btnRegisterForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegisterForm.Depth = 0;
            this.btnRegisterForm.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegisterForm.Location = new System.Drawing.Point(178, 387);
            this.btnRegisterForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegisterForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegisterForm.Name = "btnRegisterForm";
            this.btnRegisterForm.Primary = false;
            this.btnRegisterForm.Size = new System.Drawing.Size(74, 36);
            this.btnRegisterForm.TabIndex = 6;
            this.btnRegisterForm.Text = "REGISTER";
            this.btnRegisterForm.UseVisualStyleBackColor = true;
            this.btnRegisterForm.Click += new System.EventHandler(this.btnRegisterClick);
            // 
            // btnLogin
            // 
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(140, 350);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(150, 36);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLoginClick);
            // 
            // pnlInitialScreen
            // 
            this.pnlInitialScreen.Controls.Add(this.lblError);
            this.pnlInitialScreen.Controls.Add(this.lblTitle);
            this.pnlInitialScreen.Controls.Add(this.btnRegisterForm);
            this.pnlInitialScreen.Controls.Add(this.btnLogin);
            this.pnlInitialScreen.Controls.Add(this.txtID);
            this.pnlInitialScreen.Controls.Add(this.picFingerPrint);
            this.pnlInitialScreen.Location = new System.Drawing.Point(0, 62);
            this.pnlInitialScreen.Name = "pnlInitialScreen";
            this.pnlInitialScreen.Size = new System.Drawing.Size(430, 500);
            this.pnlInitialScreen.TabIndex = 8;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(13, 95);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(404, 23);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "digital or user not found";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // picFingerPrint
            // 
            this.picFingerPrint.Image = global::DataGridViewButtonExample.Properties.Resources._1234561;
            this.picFingerPrint.InitialImage = null;
            this.picFingerPrint.Location = new System.Drawing.Point(140, 147);
            this.picFingerPrint.Name = "picFingerPrint";
            this.picFingerPrint.Size = new System.Drawing.Size(150, 150);
            this.picFingerPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFingerPrint.TabIndex = 3;
            this.picFingerPrint.TabStop = false;
            this.picFingerPrint.Click += new System.EventHandler(this.selectImage);
            // 
            // pnlRegistered
            // 
            this.pnlRegistered.Controls.Add(this.btnBack);
            this.pnlRegistered.Controls.Add(this.label1);
            this.pnlRegistered.Controls.Add(this.pictureBox1);
            this.pnlRegistered.Location = new System.Drawing.Point(0, 62);
            this.pnlRegistered.Name = "pnlRegistered";
            this.pnlRegistered.Size = new System.Drawing.Size(430, 500);
            this.pnlRegistered.TabIndex = 11;
            this.pnlRegistered.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Depth = 0;
            this.btnBack.Location = new System.Drawing.Point(192, 269);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = false;
            this.btnBack.Size = new System.Drawing.Size(47, 36);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBackClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(13, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "successfully registered";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataGridViewButtonExample.Properties.Resources.correctVector;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(175, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.lblAbout);
            this.pnlHome.Controls.Add(this.label5);
            this.pnlHome.Controls.Add(this.label4);
            this.pnlHome.Controls.Add(this.btnLevel2Menu);
            this.pnlHome.Controls.Add(this.btnLevel3Menu);
            this.pnlHome.Controls.Add(this.btnRequestAccess);
            this.pnlHome.Controls.Add(this.materialDivider1);
            this.pnlHome.Controls.Add(this.btnLevel1Menu);
            this.pnlHome.Controls.Add(this.btnLogout);
            this.pnlHome.Controls.Add(this.btnUsersScreen);
            this.pnlHome.Controls.Add(this.lblLoggedAs);
            this.pnlHome.Controls.Add(this.lblHomeTitle);
            this.pnlHome.Location = new System.Drawing.Point(0, 62);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(430, 500);
            this.pnlHome.TabIndex = 12;
            this.pnlHome.Visible = false;
            this.pnlHome.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHome_Paint);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Depth = 0;
            this.lblAbout.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAbout.Location = new System.Drawing.Point(116, 470);
            this.lblAbout.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(198, 19);
            this.lblAbout.TabIndex = 20;
            this.lblAbout.Text = "Developed by UNIP Systems";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(13, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "System Configuration";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(13, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(404, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Information Access";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLevel2Menu
            // 
            this.btnLevel2Menu.Depth = 0;
            this.btnLevel2Menu.Location = new System.Drawing.Point(135, 170);
            this.btnLevel2Menu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLevel2Menu.Name = "btnLevel2Menu";
            this.btnLevel2Menu.Primary = true;
            this.btnLevel2Menu.Size = new System.Drawing.Size(160, 36);
            this.btnLevel2Menu.TabIndex = 17;
            this.btnLevel2Menu.Text = "LEVEL 2";
            this.btnLevel2Menu.UseVisualStyleBackColor = true;
            this.btnLevel2Menu.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // btnLevel3Menu
            // 
            this.btnLevel3Menu.Depth = 0;
            this.btnLevel3Menu.Location = new System.Drawing.Point(135, 220);
            this.btnLevel3Menu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLevel3Menu.Name = "btnLevel3Menu";
            this.btnLevel3Menu.Primary = true;
            this.btnLevel3Menu.Size = new System.Drawing.Size(160, 36);
            this.btnLevel3Menu.TabIndex = 16;
            this.btnLevel3Menu.Text = "LEVEL 3";
            this.btnLevel3Menu.UseVisualStyleBackColor = true;
            this.btnLevel3Menu.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // btnRequestAccess
            // 
            this.btnRequestAccess.Depth = 0;
            this.btnRequestAccess.Location = new System.Drawing.Point(135, 306);
            this.btnRequestAccess.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRequestAccess.Name = "btnRequestAccess";
            this.btnRequestAccess.Primary = true;
            this.btnRequestAccess.Size = new System.Drawing.Size(160, 36);
            this.btnRequestAccess.TabIndex = 15;
            this.btnRequestAccess.Text = "REQUEST ACCESS";
            this.btnRequestAccess.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(50, 69);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(330, 1);
            this.materialDivider1.TabIndex = 14;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btnLevel1Menu
            // 
            this.btnLevel1Menu.Depth = 0;
            this.btnLevel1Menu.Location = new System.Drawing.Point(135, 120);
            this.btnLevel1Menu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLevel1Menu.Name = "btnLevel1Menu";
            this.btnLevel1Menu.Primary = true;
            this.btnLevel1Menu.Size = new System.Drawing.Size(160, 36);
            this.btnLevel1Menu.TabIndex = 13;
            this.btnLevel1Menu.Text = "LEVEL 1";
            this.btnLevel1Menu.UseVisualStyleBackColor = true;
            this.btnLevel1Menu.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Depth = 0;
            this.btnLogout.Location = new System.Drawing.Point(18, 9);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Primary = false;
            this.btnLogout.Size = new System.Drawing.Size(82, 36);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "<< Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUsersScreen
            // 
            this.btnUsersScreen.Depth = 0;
            this.btnUsersScreen.Location = new System.Drawing.Point(135, 356);
            this.btnUsersScreen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsersScreen.Name = "btnUsersScreen";
            this.btnUsersScreen.Primary = true;
            this.btnUsersScreen.Size = new System.Drawing.Size(160, 36);
            this.btnUsersScreen.TabIndex = 11;
            this.btnUsersScreen.Text = "USERS";
            this.btnUsersScreen.UseVisualStyleBackColor = true;
            this.btnUsersScreen.Click += new System.EventHandler(this.btnUsersClick);
            // 
            // lblLoggedAs
            // 
            this.lblLoggedAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedAs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLoggedAs.Location = new System.Drawing.Point(13, 43);
            this.lblLoggedAs.Name = "lblLoggedAs";
            this.lblLoggedAs.Size = new System.Drawing.Size(404, 16);
            this.lblLoggedAs.TabIndex = 10;
            this.lblLoggedAs.Text = "logged in as: ";
            this.lblLoggedAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHomeTitle
            // 
            this.lblHomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblHomeTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHomeTitle.Location = new System.Drawing.Point(13, 11);
            this.lblHomeTitle.Name = "lblHomeTitle";
            this.lblHomeTitle.Size = new System.Drawing.Size(404, 32);
            this.lblHomeTitle.TabIndex = 9;
            this.lblHomeTitle.Text = "PRIVATE SYSTEM";
            this.lblHomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(17, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panel1.Size = new System.Drawing.Size(390, 64);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(306, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "EDIT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Access level: 1 (MASTER)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "User code: 456558";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DataGridViewButtonExample.Properties.Resources._200_2008697_account_customer_login_man_user_icon_login_icon;
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnlUsers
            // 
            this.pnlUsers.AutoScroll = true;
            this.pnlUsers.Controls.Add(this.btnBackFromUsers);
            this.pnlUsers.Controls.Add(this.lblUsersTitle);
            this.pnlUsers.Controls.Add(this.panel1);
            this.pnlUsers.Location = new System.Drawing.Point(0, 62);
            this.pnlUsers.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pnlUsers.Size = new System.Drawing.Size(430, 500);
            this.pnlUsers.TabIndex = 13;
            this.pnlUsers.Visible = false;
            // 
            // btnBackFromUsers
            // 
            this.btnBackFromUsers.AutoSize = true;
            this.btnBackFromUsers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackFromUsers.Depth = 0;
            this.btnBackFromUsers.Location = new System.Drawing.Point(19, 9);
            this.btnBackFromUsers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBackFromUsers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackFromUsers.Name = "btnBackFromUsers";
            this.btnBackFromUsers.Primary = false;
            this.btnBackFromUsers.Size = new System.Drawing.Size(65, 36);
            this.btnBackFromUsers.TabIndex = 13;
            this.btnBackFromUsers.Text = "<< back";
            this.btnBackFromUsers.UseVisualStyleBackColor = true;
            this.btnBackFromUsers.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // lblUsersTitle
            // 
            this.lblUsersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblUsersTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsersTitle.Location = new System.Drawing.Point(150, 9);
            this.lblUsersTitle.Name = "lblUsersTitle";
            this.lblUsersTitle.Size = new System.Drawing.Size(130, 32);
            this.lblUsersTitle.TabIndex = 10;
            this.lblUsersTitle.Text = "USERS";
            this.lblUsersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.verifyUsersChanges);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.verifyLoginSuccess);
            // 
            // pnlLoading
            // 
            this.pnlLoading.Controls.Add(this.lblCompareStatus);
            this.pnlLoading.Controls.Add(this.pictureBox3);
            this.pnlLoading.Location = new System.Drawing.Point(0, 62);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(430, 500);
            this.pnlLoading.TabIndex = 12;
            this.pnlLoading.Visible = false;
            // 
            // lblCompareStatus
            // 
            this.lblCompareStatus.Depth = 0;
            this.lblCompareStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCompareStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCompareStatus.Location = new System.Drawing.Point(3, 282);
            this.lblCompareStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCompareStatus.Name = "lblCompareStatus";
            this.lblCompareStatus.Size = new System.Drawing.Size(424, 23);
            this.lblCompareStatus.TabIndex = 1;
            this.lblCompareStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DataGridViewButtonExample.Properties.Resources.loading1;
            this.pictureBox3.Location = new System.Drawing.Point(190, 225);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pnlLvl1Access
            // 
            this.pnlLvl1Access.Controls.Add(this.btnBack1);
            this.pnlLvl1Access.Controls.Add(this.lblLvl1Title);
            this.pnlLvl1Access.Location = new System.Drawing.Point(0, 62);
            this.pnlLvl1Access.Name = "pnlLvl1Access";
            this.pnlLvl1Access.Size = new System.Drawing.Size(430, 500);
            this.pnlLvl1Access.TabIndex = 13;
            this.pnlLvl1Access.Visible = false;
            // 
            // btnBack1
            // 
            this.btnBack1.AutoSize = true;
            this.btnBack1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack1.Depth = 0;
            this.btnBack1.Location = new System.Drawing.Point(11, 11);
            this.btnBack1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Primary = false;
            this.btnBack1.Size = new System.Drawing.Size(65, 36);
            this.btnBack1.TabIndex = 14;
            this.btnBack1.Text = "<< Back";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // lblLvl1Title
            // 
            this.lblLvl1Title.Depth = 0;
            this.lblLvl1Title.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLvl1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLvl1Title.Location = new System.Drawing.Point(10, 11);
            this.lblLvl1Title.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLvl1Title.Name = "lblLvl1Title";
            this.lblLvl1Title.Size = new System.Drawing.Size(411, 34);
            this.lblLvl1Title.TabIndex = 0;
            this.lblLvl1Title.Text = "LEVEL 1";
            this.lblLvl1Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLvl2Access
            // 
            this.pnlLvl2Access.Controls.Add(this.lblBack2);
            this.pnlLvl2Access.Controls.Add(this.lblLevel2Title);
            this.pnlLvl2Access.Location = new System.Drawing.Point(0, 62);
            this.pnlLvl2Access.Name = "pnlLvl2Access";
            this.pnlLvl2Access.Size = new System.Drawing.Size(430, 500);
            this.pnlLvl2Access.TabIndex = 14;
            this.pnlLvl2Access.Visible = false;
            // 
            // lblBack2
            // 
            this.lblBack2.AutoSize = true;
            this.lblBack2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lblBack2.Depth = 0;
            this.lblBack2.Location = new System.Drawing.Point(11, 11);
            this.lblBack2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lblBack2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBack2.Name = "lblBack2";
            this.lblBack2.Primary = false;
            this.lblBack2.Size = new System.Drawing.Size(65, 36);
            this.lblBack2.TabIndex = 14;
            this.lblBack2.Text = "<< Back";
            this.lblBack2.UseVisualStyleBackColor = true;
            this.lblBack2.Click += new System.EventHandler(this.lblBack2_Click);
            // 
            // lblLevel2Title
            // 
            this.lblLevel2Title.Depth = 0;
            this.lblLevel2Title.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLevel2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLevel2Title.Location = new System.Drawing.Point(10, 11);
            this.lblLevel2Title.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLevel2Title.Name = "lblLevel2Title";
            this.lblLevel2Title.Size = new System.Drawing.Size(411, 34);
            this.lblLevel2Title.TabIndex = 0;
            this.lblLevel2Title.Text = "LEVEL 2";
            this.lblLevel2Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLvl3Access
            // 
            this.pnlLvl3Access.Controls.Add(this.btnBack3);
            this.pnlLvl3Access.Controls.Add(this.lblLevel3Title);
            this.pnlLvl3Access.Location = new System.Drawing.Point(0, 62);
            this.pnlLvl3Access.Name = "pnlLvl3Access";
            this.pnlLvl3Access.Size = new System.Drawing.Size(430, 500);
            this.pnlLvl3Access.TabIndex = 15;
            this.pnlLvl3Access.Visible = false;
            // 
            // btnBack3
            // 
            this.btnBack3.AutoSize = true;
            this.btnBack3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack3.Depth = 0;
            this.btnBack3.Location = new System.Drawing.Point(11, 11);
            this.btnBack3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Primary = false;
            this.btnBack3.Size = new System.Drawing.Size(65, 36);
            this.btnBack3.TabIndex = 13;
            this.btnBack3.Text = "<< Back";
            this.btnBack3.UseVisualStyleBackColor = true;
            this.btnBack3.Click += new System.EventHandler(this.btnBack3_Click);
            // 
            // lblLevel3Title
            // 
            this.lblLevel3Title.Depth = 0;
            this.lblLevel3Title.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLevel3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLevel3Title.Location = new System.Drawing.Point(10, 11);
            this.lblLevel3Title.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLevel3Title.Name = "lblLevel3Title";
            this.lblLevel3Title.Size = new System.Drawing.Size(411, 34);
            this.lblLevel3Title.TabIndex = 0;
            this.lblLevel3Title.Text = "LEVEL 3";
            this.lblLevel3Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 563);
            this.Controls.Add(this.pnlUsers);
            this.Controls.Add(this.pnlInitialScreen);
            this.Controls.Add(this.pnlLvl2Access);
            this.Controls.Add(this.pnlLvl3Access);
            this.Controls.Add(this.pnlLvl1Access);
            this.Controls.Add(this.pnlLoading);
            this.Controls.Add(this.pnlRegistered);
            this.Controls.Add(this.pnlHome);
            this.Name = "Form1";
            this.Text = "UNIP Systems - Main";
            this.pnlInitialScreen.ResumeLayout(false);
            this.pnlInitialScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerPrint)).EndInit();
            this.pnlRegistered.ResumeLayout(false);
            this.pnlRegistered.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlUsers.ResumeLayout(false);
            this.pnlUsers.PerformLayout();
            this.pnlLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlLvl1Access.ResumeLayout(false);
            this.pnlLvl1Access.PerformLayout();
            this.pnlLvl2Access.ResumeLayout(false);
            this.pnlLvl2Access.PerformLayout();
            this.pnlLvl3Access.ResumeLayout(false);
            this.pnlLvl3Access.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picFingerPrint;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtID;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialFlatButton btnRegisterForm;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private System.Windows.Forms.Panel pnlInitialScreen;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlRegistered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton btnBack;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lblHomeTitle;
        private System.Windows.Forms.Label lblLoggedAs;
        private MaterialSkin.Controls.MaterialRaisedButton btnUsersScreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Label lblUsersTitle;
        private MaterialSkin.Controls.MaterialFlatButton btnBackFromUsers;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel pnlLoading;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialFlatButton btnLogout;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton btnLevel1Menu;
        private MaterialSkin.Controls.MaterialLabel lblAbout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialRaisedButton btnLevel2Menu;
        private MaterialSkin.Controls.MaterialRaisedButton btnLevel3Menu;
        private MaterialSkin.Controls.MaterialRaisedButton btnRequestAccess;
        private MaterialSkin.Controls.MaterialLabel lblCompareStatus;
        private System.Windows.Forms.Panel pnlLvl1Access;
        private MaterialSkin.Controls.MaterialLabel lblLvl1Title;
        private MaterialSkin.Controls.MaterialFlatButton btnBack1;
        private System.Windows.Forms.Panel pnlLvl2Access;
        private MaterialSkin.Controls.MaterialFlatButton lblBack2;
        private MaterialSkin.Controls.MaterialLabel lblLevel2Title;
        private System.Windows.Forms.Panel pnlLvl3Access;
        private MaterialSkin.Controls.MaterialFlatButton btnBack3;
        private MaterialSkin.Controls.MaterialLabel lblLevel3Title;
    }
}