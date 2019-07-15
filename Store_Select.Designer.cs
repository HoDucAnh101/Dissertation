namespace Coffee_Shop.Login
{
    partial class Store_Select
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_Store = new System.Windows.Forms.DataGridView();
            this.button_Store_Select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Store)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.dataGridView_Store);
            this.panel1.Location = new System.Drawing.Point(23, 159);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 309);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView_Store
            // 
            this.dataGridView_Store.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Store.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Store.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Store.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_Store.Name = "dataGridView_Store";
            this.dataGridView_Store.RowTemplate.Height = 24;
            this.dataGridView_Store.Size = new System.Drawing.Size(953, 305);
            this.dataGridView_Store.TabIndex = 0;
            // 
            // button_Store_Select
            // 
            this.button_Store_Select.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Store_Select.BackColor = System.Drawing.Color.GreenYellow;
            this.button_Store_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Store_Select.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_Store_Select.Location = new System.Drawing.Point(422, 86);
            this.button_Store_Select.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Store_Select.Name = "button_Store_Select";
            this.button_Store_Select.Size = new System.Drawing.Size(109, 51);
            this.button_Store_Select.TabIndex = 2;
            this.button_Store_Select.Text = "Xác nhận";
            this.button_Store_Select.UseVisualStyleBackColor = false;
            this.button_Store_Select.Click += new System.EventHandler(this.Store_Select_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(120, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn một nhật ký cửa hàng để tiếp tục";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button_Store_Select);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 441);
            this.panel2.TabIndex = 3;
            // 
            // Store_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 464);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Store_Select";
            this.Text = "Nhật ký cửa hàng";
            this.Load += new System.EventHandler(this.Store_Select_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Store)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Store;
        private System.Windows.Forms.Button button_Store_Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}