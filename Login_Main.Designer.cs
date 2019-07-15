namespace Coffee_Shop
{
    partial class Login_Main
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
            this.UserLogin_lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassLogin_lb = new System.Windows.Forms.Label();
            this.LoginUser_txt = new System.Windows.Forms.TextBox();
            this.LoginPw_txt = new System.Windows.Forms.TextBox();
            this.LoginConfirm_btn = new System.Windows.Forms.Button();
            this.LoginExit_btn = new System.Windows.Forms.Button();
            this.username_wrn = new System.Windows.Forms.Label();
            this.pass_wrn = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trungtam_CafeDataSet = new Coffee_Shop.Trungtam_CafeDataSet();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Hour = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Minute = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_Store_Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trungtam_CafeDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserLogin_lb
            // 
            this.UserLogin_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserLogin_lb.AutoSize = true;
            this.UserLogin_lb.ForeColor = System.Drawing.Color.Blue;
            this.UserLogin_lb.Location = new System.Drawing.Point(236, 7);
            this.UserLogin_lb.Margin = new System.Windows.Forms.Padding(225, 0, 3, 0);
            this.UserLogin_lb.Name = "UserLogin_lb";
            this.UserLogin_lb.Size = new System.Drawing.Size(78, 20);
            this.UserLogin_lb.TabIndex = 0;
            this.UserLogin_lb.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 0;
            // 
            // PassLogin_lb
            // 
            this.PassLogin_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassLogin_lb.AutoSize = true;
            this.PassLogin_lb.ForeColor = System.Drawing.Color.Blue;
            this.PassLogin_lb.Location = new System.Drawing.Point(238, 80);
            this.PassLogin_lb.Margin = new System.Windows.Forms.Padding(225, 0, 3, 0);
            this.PassLogin_lb.Name = "PassLogin_lb";
            this.PassLogin_lb.Size = new System.Drawing.Size(75, 20);
            this.PassLogin_lb.TabIndex = 1;
            this.PassLogin_lb.Text = "Mật khẩu";
            // 
            // LoginUser_txt
            // 
            this.LoginUser_txt.Location = new System.Drawing.Point(332, 4);
            this.LoginUser_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginUser_txt.MaxLength = 8;
            this.LoginUser_txt.Name = "LoginUser_txt";
            this.LoginUser_txt.Size = new System.Drawing.Size(112, 26);
            this.LoginUser_txt.TabIndex = 2;
            this.LoginUser_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_User_Key_Down);
            // 
            // LoginPw_txt
            // 
            this.LoginPw_txt.Location = new System.Drawing.Point(332, 72);
            this.LoginPw_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginPw_txt.Name = "LoginPw_txt";
            this.LoginPw_txt.PasswordChar = '*';
            this.LoginPw_txt.Size = new System.Drawing.Size(112, 26);
            this.LoginPw_txt.TabIndex = 3;
            this.LoginPw_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Pw_Key_Down);
            // 
            // LoginConfirm_btn
            // 
            this.LoginConfirm_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.LoginConfirm_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoginConfirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginConfirm_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoginConfirm_btn.Location = new System.Drawing.Point(212, 165);
            this.LoginConfirm_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginConfirm_btn.Name = "LoginConfirm_btn";
            this.LoginConfirm_btn.Size = new System.Drawing.Size(114, 53);
            this.LoginConfirm_btn.TabIndex = 4;
            this.LoginConfirm_btn.Text = "Đăng nhập";
            this.LoginConfirm_btn.UseVisualStyleBackColor = false;
            this.LoginConfirm_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // LoginExit_btn
            // 
            this.LoginExit_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.LoginExit_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginExit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginExit_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoginExit_btn.Location = new System.Drawing.Point(332, 165);
            this.LoginExit_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginExit_btn.Name = "LoginExit_btn";
            this.LoginExit_btn.Size = new System.Drawing.Size(138, 53);
            this.LoginExit_btn.TabIndex = 5;
            this.LoginExit_btn.Text = "Màn hình chào";
            this.LoginExit_btn.UseVisualStyleBackColor = false;
            this.LoginExit_btn.Click += new System.EventHandler(this.Login_Exit);
            // 
            // username_wrn
            // 
            this.username_wrn.AutoSize = true;
            this.username_wrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_wrn.ForeColor = System.Drawing.Color.Red;
            this.username_wrn.Location = new System.Drawing.Point(332, 34);
            this.username_wrn.Name = "username_wrn";
            this.username_wrn.Size = new System.Drawing.Size(205, 20);
            this.username_wrn.TabIndex = 6;
            this.username_wrn.Text = "*Vui lòng nhập tài khoản";
            // 
            // pass_wrn
            // 
            this.pass_wrn.AutoSize = true;
            this.pass_wrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_wrn.ForeColor = System.Drawing.Color.Red;
            this.pass_wrn.Location = new System.Drawing.Point(332, 112);
            this.pass_wrn.Name = "pass_wrn";
            this.pass_wrn.Size = new System.Drawing.Size(205, 20);
            this.pass_wrn.TabIndex = 7;
            this.pass_wrn.Text = "*Vui lòng nhập mật khẩu";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LoginExit_btn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pass_wrn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LoginPw_txt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LoginConfirm_btn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.UserLogin_lb, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.username_wrn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PassLogin_lb, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LoginUser_txt, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(658, 222);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.trungtam_CafeDataSet;
            this.bindingSource1.Position = 0;
            // 
            // trungtam_CafeDataSet
            // 
            this.trungtam_CafeDataSet.CaseSensitive = true;
            this.trungtam_CafeDataSet.DataSetName = "Trungtam_CafeDataSet";
            this.trungtam_CafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Date,
            this.toolStripStatusLabel_Hour,
            this.toolStripStatusLabel_Minute});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(658, 30);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Date
            // 
            this.toolStripStatusLabel_Date.Name = "toolStripStatusLabel_Date";
            this.toolStripStatusLabel_Date.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel_Date.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel_Date.DoubleClick += new System.EventHandler(this.toolStripStatusLabel_Date_Double_Click);
            // 
            // toolStripStatusLabel_Hour
            // 
            this.toolStripStatusLabel_Hour.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel_Hour.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripStatusLabel_Hour.Name = "toolStripStatusLabel_Hour";
            this.toolStripStatusLabel_Hour.Size = new System.Drawing.Size(179, 30);
            this.toolStripStatusLabel_Hour.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel_Hour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel_Minute
            // 
            this.toolStripStatusLabel_Minute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel_Minute.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripStatusLabel_Minute.Name = "toolStripStatusLabel_Minute";
            this.toolStripStatusLabel_Minute.Size = new System.Drawing.Size(179, 30);
            this.toolStripStatusLabel_Minute.Text = "toolStripStatusLabel3";
            this.toolStripStatusLabel_Minute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Store_Name
            // 
            this.label_Store_Name.AutoSize = true;
            this.label_Store_Name.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Store_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Store_Name.ForeColor = System.Drawing.Color.Blue;
            this.label_Store_Name.Location = new System.Drawing.Point(0, 0);
            this.label_Store_Name.MaximumSize = new System.Drawing.Size(650, 0);
            this.label_Store_Name.Name = "label_Store_Name";
            this.label_Store_Name.Padding = new System.Windows.Forms.Padding(150, 0, 0, 0);
            this.label_Store_Name.Size = new System.Drawing.Size(282, 46);
            this.label_Store_Name.TabIndex = 11;
            this.label_Store_Name.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.label_Store_Name);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 268);
            this.panel1.TabIndex = 12;
            // 
            // Login_Main
            // 
            this.AcceptButton = this.LoginConfirm_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(658, 430);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login_Main";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trungtam_CafeDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UserLogin_lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PassLogin_lb;
        private System.Windows.Forms.TextBox LoginUser_txt;
        private System.Windows.Forms.TextBox LoginPw_txt;
        private System.Windows.Forms.Button LoginConfirm_btn;
        private System.Windows.Forms.Button LoginExit_btn;
        private System.Windows.Forms.Label username_wrn;
        private System.Windows.Forms.Label pass_wrn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Trungtam_CafeDataSet trungtam_CafeDataSet;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Date;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Hour;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Minute;
        private System.Windows.Forms.Label label_Store_Name;
        private System.Windows.Forms.Panel panel1;
    }
}

