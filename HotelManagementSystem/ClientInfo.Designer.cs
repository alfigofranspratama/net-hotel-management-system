namespace HotelManagementSystem
{
    partial class ClientInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.clientID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.clientName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.clientPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.clientCountry = new System.Windows.Forms.ComboBox();
            this.clientView = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button4 = new System.Windows.Forms.Button();
            this.dateLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.dateLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Information";
            // 
            // clientID
            // 
            this.clientID.BackColor = System.Drawing.SystemColors.Control;
            this.clientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.clientID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientID.HintForeColor = System.Drawing.Color.Empty;
            this.clientID.HintText = "";
            this.clientID.isPassword = false;
            this.clientID.LineFocusedColor = System.Drawing.Color.Blue;
            this.clientID.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.clientID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.clientID.LineThickness = 3;
            this.clientID.Location = new System.Drawing.Point(44, 158);
            this.clientID.Margin = new System.Windows.Forms.Padding(4);
            this.clientID.Name = "clientID";
            this.clientID.Size = new System.Drawing.Size(265, 33);
            this.clientID.TabIndex = 1;
            this.clientID.Text = "Client ID";
            this.clientID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // clientName
            // 
            this.clientName.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.clientName.BackColor = System.Drawing.SystemColors.Control;
            this.clientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.clientName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientName.HintForeColor = System.Drawing.Color.Empty;
            this.clientName.HintText = "";
            this.clientName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientName.isPassword = false;
            this.clientName.LineFocusedColor = System.Drawing.Color.Blue;
            this.clientName.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.clientName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.clientName.LineThickness = 3;
            this.clientName.Location = new System.Drawing.Point(44, 257);
            this.clientName.Margin = new System.Windows.Forms.Padding(4);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(265, 33);
            this.clientName.TabIndex = 2;
            this.clientName.Text = "Client Name";
            this.clientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // clientPhone
            // 
            this.clientPhone.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.clientPhone.BackColor = System.Drawing.SystemColors.Control;
            this.clientPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.clientPhone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clientPhone.HintForeColor = System.Drawing.Color.Empty;
            this.clientPhone.HintText = "";
            this.clientPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientPhone.isPassword = false;
            this.clientPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.clientPhone.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.clientPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.clientPhone.LineThickness = 3;
            this.clientPhone.Location = new System.Drawing.Point(44, 358);
            this.clientPhone.Margin = new System.Windows.Forms.Padding(4);
            this.clientPhone.Name = "clientPhone";
            this.clientPhone.Size = new System.Drawing.Size(265, 33);
            this.clientPhone.TabIndex = 3;
            this.clientPhone.Text = "Phone Number";
            this.clientPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // clientCountry
            // 
            this.clientCountry.BackColor = System.Drawing.Color.DodgerBlue;
            this.clientCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clientCountry.ForeColor = System.Drawing.Color.White;
            this.clientCountry.FormattingEnabled = true;
            this.clientCountry.Items.AddRange(new object[] {
            "INDONESIA",
            "JAPAN",
            "SINGAPURA",
            "MALAYSIA",
            "JERMAN",
            "KOREA SELATAN",
            "KOREA UTARA",
            "CHINA",
            "RUSIA",
            "AMERIKA SERIKAT",
            "INDIA",
            "ARAB SAUDI",
            "ITALIA",
            "KAZAKHSTAN"});
            this.clientCountry.Location = new System.Drawing.Point(44, 466);
            this.clientCountry.Name = "clientCountry";
            this.clientCountry.Size = new System.Drawing.Size(265, 24);
            this.clientCountry.TabIndex = 4;
            this.clientCountry.Text = "Country";
            // 
            // clientView
            // 
            this.clientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientView.Location = new System.Drawing.Point(367, 203);
            this.clientView.Name = "clientView";
            this.clientView.Size = new System.Drawing.Size(527, 520);
            this.clientView.TabIndex = 5;
            this.clientView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.Control;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.addBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.addBtn.Location = new System.Drawing.Point(146, 559);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(62, 30);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.updateBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.updateBtn.Location = new System.Drawing.Point(44, 559);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(79, 30);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.deleteBtn.Location = new System.Drawing.Point(230, 559);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(79, 30);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuMaterialTextbox4.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox4.HintText = "";
            this.bunifuMaterialTextbox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox4.LineThickness = 3;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(629, 163);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(265, 33);
            this.bunifuMaterialTextbox4.TabIndex = 9;
            this.bunifuMaterialTextbox4.Text = "Client Name";
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(815, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 30);
            this.button4.TabIndex = 10;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.dateLbl.Location = new System.Drawing.Point(789, 73);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(54, 23);
            this.dateLbl.TabIndex = 1;
            this.dateLbl.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(918, 735);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bunifuMaterialTextbox4);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.clientView);
            this.Controls.Add(this.clientCountry);
            this.Controls.Add(this.clientPhone);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.clientID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientInfo";
            this.Load += new System.EventHandler(this.ClientInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox clientID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox clientName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox clientPhone;
        private System.Windows.Forms.ComboBox clientCountry;
        private System.Windows.Forms.DataGridView clientView;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Timer timer1;
    }
}