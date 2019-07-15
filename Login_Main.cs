using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading;
using System.Collections;

namespace Coffee_Shop
{
    public partial class Login_Main : Form
    {
        private string login_name { get; set; }
        private string login_role { get; set; }
        public BindingSource BindingSourceAccount { get; private set; }

        SqlConnection Cafe = new SqlConnection("Data Source=.;Initial Catalog=Trungtam_Cafe;User ID=QL_Cafe;Password=123");
        public Login_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            username_wrn.Visible = false;
            pass_wrn.Visible = false;
            label_Store_Name.Text = Login.Store_Select.store_name;
            toolStripStatusLabel_Date.Text = Login.Store_Select.date;
            toolStripStatusLabel_Hour.Text = Login.Store_Select.open_hour.ToString() + ":";
            toolStripStatusLabel_Minute.Text = Login.Store_Select.open_min.ToString() + "0";

            // TODO: This line of code loads data into the 'trungtam_CafeDataSet.CUA_HANG' table. You can move, or remove it, as needed.

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (LoginUser_txt.Text == "" || LoginPw_txt.Text == "")
            {
                username_wrn.Text = "*Tài khoản không được để trống";
                pass_wrn.Text = "*Mật khẩu không được để trống";
                username_wrn.Show();
                pass_wrn.Show();
                Cafe.Close();
            }
            else
            {
                username_wrn.Visible = false;
                pass_wrn.Visible = false;
                Cafe.Open();
                SqlDataAdapter loginAdapter = new SqlDataAdapter
                ("select * from [dbo].[TAI_KHOAN_HE_THONG] where TAI_KHOAN='" + LoginUser_txt.Text + "' and MAT_KHAU='" + LoginPw_txt.Text + "' ", Cafe);
                DataTable result = new DataTable();
                loginAdapter.Fill(result);
                try
                {
                    if (result.Rows.Count == 1)
                    {
                        if (LoginUser_txt.Text == result.Rows[0]["TAI_KHOAN"].ToString() && LoginPw_txt.Text == result.Rows[0]["MAT_KHAU"].ToString())
                        {
                            login_role = result.Rows[0]["LOAI_TK"].ToString();
                            switch (login_role)
                            {
                                case "Admin":
                                    {
                                        AdminMenu AdminMenu = new AdminMenu();
                                        MessageBox.Show("Đăng nhập thành công\n Xin chào Admin");
                                        AdminMenu.Login_Main_Data(login_role);
                                        this.Hide();
                                        AdminMenu.Show();
                                        break;
                                    }
                                case "Thu ngân":
                                    {
                                        CashierMenu CashierMenu = new CashierMenu();
                                        MessageBox.Show("Đăng nhập thành công\n Xin chào Thu ngân");
                                        CashierMenu.Login_Main_Data(login_role);
                                        this.Hide();
                                        CashierMenu.Show();
                                        break;
                                    }
                                case "Khách hàng":
                                    {
                                        MessageBox.Show("Tính năng đang trong quá trình phát triển");
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập thất bại\n Vui lòng kiểm tra tài khoản và mật khẩu");
                            Cafe.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK);
                    Cafe.Close();
                }
            }
        }

        private void Login_Exit(object sender, EventArgs e)
        {
            string message = "Trở về màn hình chào?";
            string caption = "Question";
            DialogResult Exit_ms;
            Exit_ms= MessageBox.Show
            (message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Exit_ms == DialogResult.Yes)
            {
                this.Hide();
                Login.Welcome_Form welcome_Form = new Login.Welcome_Form();
                welcome_Form.Show();
            }
            else
            {
                return;
            }
        }

        private void Forgot_Password_Link_Clicked(object sender, EventArgs e)
        {
            Form Account_List = new Form();
            int a = Account_List.Width - 25;
            int b = Account_List.Height -45;
            DataGridView DataGridView_Account = new DataGridView();
            DataGridView_Account.Size = new Size(a, b);
            SqlDataAdapter AccountAdapter = new SqlDataAdapter
            ("select * from [TAI_KHOAN_HE_THONG]", Cafe);
            DataTable result = new DataTable();
            AccountAdapter.Fill(result);

            result.Columns[1].ColumnName = "Tài khoản";
            result.Columns[2].ColumnName = "Mật khẩu";
            result.Columns[3].ColumnName = "Loại tài khoản";

            BindingSourceAccount = new BindingSource();
            BindingSourceAccount.DataSource = result;

            DataGridView_Account.DataSource = result;
            Account_List.Controls.Add(DataGridView_Account);
            Account_List.ShowDialog();
        }

        private void textBox_User_Key_Down(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Down)
            {
                LoginPw_txt.Focus();
            }
        }

        private void textBox_Pw_Key_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                LoginUser_txt.Focus();
            }
        }

        private void toolStripStatusLabel_Date_Double_Click(object sender, EventArgs e)
        {
            DialogResult debug;
            debug = MessageBox.Show("Debug", "Debug", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(debug == DialogResult.Yes)
            {
                AdminMenu AdminMenu = new AdminMenu();
                AdminMenu.ShowDialog();
            }
            else
            {
                return;
            }

        }

        private void Login_Main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
