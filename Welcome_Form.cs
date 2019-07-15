using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop.Login
{
    public partial class Welcome_Form : Form
    {
        Store_Select Store_Select = new Store_Select();
        public Welcome_Form()
        {
            InitializeComponent();
        }
        private void Button_Begin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Store_Select.Show();
        }

        private void Button_End_Click(object sender, EventArgs e)
        {
            string message = "Xác nhận thoát chương trình ?";
            string caption = "Question";
            DialogResult Exit_ms;
            Exit_ms = MessageBox.Show
            (message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Exit_ms == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
