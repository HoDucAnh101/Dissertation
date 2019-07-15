namespace Coffee_Shop.Login
{
    partial class Welcome_Form
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
            this.button_Begin = new System.Windows.Forms.Button();
            this.button_End = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Begin
            // 
            this.button_Begin.BackColor = System.Drawing.Color.GreenYellow;
            this.button_Begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Begin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_Begin.Location = new System.Drawing.Point(212, 389);
            this.button_Begin.Name = "button_Begin";
            this.button_Begin.Size = new System.Drawing.Size(126, 49);
            this.button_Begin.TabIndex = 0;
            this.button_Begin.Text = "Khởi động";
            this.button_Begin.UseVisualStyleBackColor = false;
            this.button_Begin.Click += new System.EventHandler(this.Button_Begin_Click);
            // 
            // button_End
            // 
            this.button_End.BackColor = System.Drawing.Color.GreenYellow;
            this.button_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_End.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_End.Location = new System.Drawing.Point(461, 389);
            this.button_End.Name = "button_End";
            this.button_End.Size = new System.Drawing.Size(135, 49);
            this.button_End.TabIndex = 1;
            this.button_End.Text = "Thoát";
            this.button_End.UseVisualStyleBackColor = false;
            this.button_End.Click += new System.EventHandler(this.Button_End_Click);
            // 
            // Welcome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coffee_Shop.Properties.Resources.coffee_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button_End);
            this.Controls.Add(this.button_Begin);
            this.DoubleBuffered = true;
            this.Name = "Welcome_Form";
            this.Text = "Màn hình chào";
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Button button_Begin;
        private System.Windows.Forms.Button button_End;
    }
}