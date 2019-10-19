namespace DataGridViewButtonExample
{
    partial class formEditRegister
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
            this.lblTitleUserCode = new MaterialSkin.Controls.MaterialLabel();
            this.lblTitleOldAccess = new MaterialSkin.Controls.MaterialLabel();
            this.lblUserCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblOldAccess = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNewAccess = new MaterialSkin.Controls.MaterialLabel();
            this.cbNewAccess = new System.Windows.Forms.ComboBox();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlChange = new System.Windows.Forms.Panel();
            this.pnlEdited = new System.Windows.Forms.Panel();
            this.btnBack = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlChange.SuspendLayout();
            this.pnlEdited.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleUserCode
            // 
            this.lblTitleUserCode.AutoSize = true;
            this.lblTitleUserCode.Depth = 0;
            this.lblTitleUserCode.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitleUserCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitleUserCode.Location = new System.Drawing.Point(59, 29);
            this.lblTitleUserCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitleUserCode.Name = "lblTitleUserCode";
            this.lblTitleUserCode.Size = new System.Drawing.Size(87, 19);
            this.lblTitleUserCode.TabIndex = 0;
            this.lblTitleUserCode.Text = "User Code: ";
            // 
            // lblTitleOldAccess
            // 
            this.lblTitleOldAccess.AutoSize = true;
            this.lblTitleOldAccess.Depth = 0;
            this.lblTitleOldAccess.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitleOldAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitleOldAccess.Location = new System.Drawing.Point(59, 68);
            this.lblTitleOldAccess.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitleOldAccess.Name = "lblTitleOldAccess";
            this.lblTitleOldAccess.Size = new System.Drawing.Size(93, 19);
            this.lblTitleOldAccess.TabIndex = 1;
            this.lblTitleOldAccess.Text = "Old Access: ";
            // 
            // lblUserCode
            // 
            this.lblUserCode.Depth = 0;
            this.lblUserCode.Enabled = false;
            this.lblUserCode.Hint = "123456";
            this.lblUserCode.Location = new System.Drawing.Point(202, 29);
            this.lblUserCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserCode.Name = "lblUserCode";
            this.lblUserCode.PasswordChar = '\0';
            this.lblUserCode.SelectedText = "";
            this.lblUserCode.SelectionLength = 0;
            this.lblUserCode.SelectionStart = 0;
            this.lblUserCode.Size = new System.Drawing.Size(92, 23);
            this.lblUserCode.TabIndex = 2;
            this.lblUserCode.UseSystemPasswordChar = false;
            // 
            // lblOldAccess
            // 
            this.lblOldAccess.Depth = 0;
            this.lblOldAccess.Enabled = false;
            this.lblOldAccess.Hint = "1";
            this.lblOldAccess.Location = new System.Drawing.Point(202, 64);
            this.lblOldAccess.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOldAccess.Name = "lblOldAccess";
            this.lblOldAccess.PasswordChar = '\0';
            this.lblOldAccess.SelectedText = "";
            this.lblOldAccess.SelectionLength = 0;
            this.lblOldAccess.SelectionStart = 0;
            this.lblOldAccess.Size = new System.Drawing.Size(92, 23);
            this.lblOldAccess.TabIndex = 3;
            this.lblOldAccess.UseSystemPasswordChar = false;
            // 
            // lblNewAccess
            // 
            this.lblNewAccess.AutoSize = true;
            this.lblNewAccess.Depth = 0;
            this.lblNewAccess.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNewAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNewAccess.Location = new System.Drawing.Point(59, 108);
            this.lblNewAccess.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNewAccess.Name = "lblNewAccess";
            this.lblNewAccess.Size = new System.Drawing.Size(101, 19);
            this.lblNewAccess.TabIndex = 4;
            this.lblNewAccess.Text = "New Access: ";
            // 
            // cbNewAccess
            // 
            this.cbNewAccess.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbNewAccess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNewAccess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbNewAccess.FormattingEnabled = true;
            this.cbNewAccess.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbNewAccess.Location = new System.Drawing.Point(202, 106);
            this.cbNewAccess.Name = "cbNewAccess";
            this.cbNewAccess.Size = new System.Drawing.Size(92, 21);
            this.cbNewAccess.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(301, 100);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(64, 36);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlChange
            // 
            this.pnlChange.Controls.Add(this.btnSave);
            this.pnlChange.Controls.Add(this.pnlEdited);
            this.pnlChange.Controls.Add(this.btnCancel);
            this.pnlChange.Controls.Add(this.lblTitleUserCode);
            this.pnlChange.Controls.Add(this.cbNewAccess);
            this.pnlChange.Controls.Add(this.lblTitleOldAccess);
            this.pnlChange.Controls.Add(this.lblNewAccess);
            this.pnlChange.Controls.Add(this.lblUserCode);
            this.pnlChange.Controls.Add(this.lblOldAccess);
            this.pnlChange.Location = new System.Drawing.Point(0, 63);
            this.pnlChange.Name = "pnlChange";
            this.pnlChange.Size = new System.Drawing.Size(430, 168);
            this.pnlChange.TabIndex = 7;
            // 
            // pnlEdited
            // 
            this.pnlEdited.Controls.Add(this.btnBack);
            this.pnlEdited.Controls.Add(this.label1);
            this.pnlEdited.Controls.Add(this.pictureBox1);
            this.pnlEdited.Location = new System.Drawing.Point(0, 0);
            this.pnlEdited.Name = "pnlEdited";
            this.pnlEdited.Size = new System.Drawing.Size(430, 168);
            this.pnlEdited.TabIndex = 12;
            this.pnlEdited.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Depth = 0;
            this.btnBack.Location = new System.Drawing.Point(192, 129);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = false;
            this.btnBack.Size = new System.Drawing.Size(47, 36);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(13, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "successfully updated";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataGridViewButtonExample.Properties.Resources.correctVector;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(175, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(367, 100);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = false;
            this.btnSave.Size = new System.Drawing.Size(46, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // formEditRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 231);
            this.Controls.Add(this.pnlChange);
            this.Name = "formEditRegister";
            this.Text = "Register Edit";
            this.pnlChange.ResumeLayout(false);
            this.pnlChange.PerformLayout();
            this.pnlEdited.ResumeLayout(false);
            this.pnlEdited.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTitleUserCode;
        private MaterialSkin.Controls.MaterialLabel lblTitleOldAccess;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblUserCode;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblOldAccess;
        private MaterialSkin.Controls.MaterialLabel lblNewAccess;
        private System.Windows.Forms.ComboBox cbNewAccess;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
        private System.Windows.Forms.Panel pnlChange;
        private MaterialSkin.Controls.MaterialFlatButton btnSave;
        private System.Windows.Forms.Panel pnlEdited;
        private MaterialSkin.Controls.MaterialFlatButton btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}