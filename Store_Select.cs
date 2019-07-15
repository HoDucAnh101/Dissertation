using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop.Login
{
    public partial class Store_Select : Form
    {
        static SqlConnection Cafe = new SqlConnection("Data Source=.;Initial Catalog=Trungtam_Cafe;User ID=QL_Cafe;Password=123");
        SqlDataAdapter StoreAdapter = new SqlDataAdapter
        ("select * from [NHAT_KY_CUA_HANG]", Cafe);
        SqlDataAdapter StoreAdapter1 = new SqlDataAdapter
        ("select * from [v_Hour_Minute]", Cafe);
        SqlDataAdapter StoreAdapter2 = new SqlDataAdapter
        ("select * from [CUA_HANG]",Cafe);
        DataTable result = new DataTable();
        DataTable result1 = new DataTable();
        DataTable result2 = new DataTable();
        Redirect.RedirectForm RedirectForm = new Redirect.RedirectForm();
        Login_Main Login_Main = new Login_Main();
        public Store_Select()
        {
            InitializeComponent();
        }
        private string logged_role;
        private int store_selected_count = 0;
        private string get_store_id;
        private int get_open_hour;
        private int get_open_min;
        private int get_close_hour;
        private int get_close_min;
        DateTime get_date;
        CultureInfo culture = new CultureInfo("vi");

        public static string store_name;
        public static string date;
        public static string store_status;
        public static int open_hour;
        public static int open_min;
        public static int close_hour;
        public static int close_min;

        public void Login_Main_Data(string store_select)
        {
            logged_role = store_select.ToString();
        }
        private void Store_Select_Load(object sender, EventArgs e)
        {
            StoreAdapter.Fill(result);
            StoreAdapter1.Fill(result1);
            StoreAdapter2.Fill(result2);
            dataGridView_Store.DataSource = result;
            dataGridView_Store.MultiSelect = false;
            dataGridView_Store.AllowUserToAddRows = false;
            dataGridView_Store.AllowUserToDeleteRows = false;
            dataGridView_Store.ReadOnly = true;
            dataGridView_Store.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            for (int i = 0; i < result.Columns.Count; i++)
            {
                switch (dataGridView_Store.Columns[i].HeaderText.ToString())
                {
                    case "ID_NK":
                        dataGridView_Store.Columns[i].HeaderText = "Mã nhật ký";
                        break;
                    case "ID_CH":
                        dataGridView_Store.Columns[i].HeaderText = "Mã cửa hàng";
                        break;
                    case "NGAY_MO_CUA":
                        dataGridView_Store.Columns[i].HeaderText = "Ngày mở cửa";
                        break;
                    case "GIO_MO_CUA":
                        dataGridView_Store.Columns[i].HeaderText = "Giờ mở cửa";
                        break;
                    case "GIO_DONG_CUA":
                        dataGridView_Store.Columns[i].HeaderText = "Giờ đóng cửa";
                        break;
                    case "TRANG_THAI":
                        dataGridView_Store.Columns[i].HeaderText = "Trạng thái";
                        break;
                }
            }
        }
        public void Set_Store_Name()
        {
            foreach(DataRow item in result2.Rows)
            {
                if(item[1].ToString() == get_store_id)
                {
                    store_name = item[2].ToString();
                }
            }
        }
        private void Store_Select_Click(object sender, EventArgs e)
        {
            Cafe.Open();
            store_selected_count = dataGridView_Store.SelectedRows.Count;
            int store_data_count = 0;
            store_data_count = result.Rows.Count;
            if(store_data_count <= 0)
            {
                
            }
            if (store_selected_count == 1)
            {
                try
                {
                    for (int i = 0; i < store_data_count; i++)
                    {
                        if (dataGridView_Store.Rows[i].Selected == true)
                        {
                            store_status = result.Rows[i][6].ToString();
                            get_date = Convert.ToDateTime(result.Rows[i][3].ToString(), culture);
                            date = get_date.ToShortDateString();

                            get_open_hour = (int)result1.Rows[i][0];
                            get_open_min = (int)result1.Rows[i][1];
                            get_close_hour = (int)result1.Rows[i][2];
                            get_close_min = (int)result1.Rows[i][3];

                            get_store_id = (string)result.Rows[i][2];
                            
                        }
                    }
                    Set_Store_Name();
                    open_hour = get_open_hour;
                    if(get_open_min < 10)
                    {
                        open_min = get_open_min;
                    }
                    else
                    {
                        open_min = get_open_min / 10;
                    }
                    close_hour = get_close_hour;
                    close_min = get_close_min;
                    Cafe.Close();
                    this.Hide();
                    Login_Main.Show();
                    /*
                        Redirect.RedirectForm.OpenFrom = "Store_Select";
                        Redirect.RedirectForm.RedirectTo = "Đăng nhập";
                        Redirect.RedirectForm.FullRedirect = "Login_Main";
                        RedirectForm.Show();
                    */
                }
                catch (Exception ex)
                {
                    Cafe.Close();
                    MessageBox.Show(ex.Message, "Fatal", MessageBoxButtons.OK);
                }
            }
            else
            {
                Cafe.Close();
                MessageBox.Show("Vui lòng chọn một nhật ký để tiếp tục", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
    }
}
