using System.Data.SqlClient;

namespace BT1
{
    public partial class Form1 : Form
    {
        Connect kn = new Connect();
        SqlConnection connsql;
        public Form1()
        {
            InitializeComponent();
            connsql = kn.conn;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == System.Data.ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string insertString;
                insertString = "insert into SINHVIEN values ('" + sinhvien.Text + "', N'" + hoten.Text + "')";
                
                SqlCommand cmd = new SqlCommand(insertString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == System.Data.ConnectionState.Open)
                {
                    connsql.Close();
                }
                MessageBox.Show("Insert succeed!");
            }
            catch (Exception ex)
            {
                if (hoten.Text == hoten.Text || sinhvien.Text == sinhvien.Text)
                {
                    MessageBox.Show("This data is already inserted before! Please try again!");
                }
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == System.Data.ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string deleteString;
                deleteString = "delete SINHVIEN where MASV = '" + sinhvien.Text + "'";
                SqlCommand cmd = new SqlCommand(deleteString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == System.Data.ConnectionState.Open)
                {
                    connsql.Close();
                }
                MessageBox.Show("Delete succeed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed!");
            }
        }

        private void btnfix_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == System.Data.ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string updateString;
                updateString = "update SINHVIEN set TENSV= '" + hoten.Text + "' where MASV='" + sinhvien.Text + "'";
                SqlCommand cmd = new SqlCommand(updateString, connsql);
                cmd.ExecuteNonQuery();
                if (connsql.State == System.Data.ConnectionState.Open)
                {
                    connsql.Close();
                }
                MessageBox.Show("Modify succeed!");
            }
            catch (Exception ex)
            {
                if (hoten.Text == hoten.Text || sinhvien.Text == sinhvien.Text)
                {
                    MessageBox.Show("This data is already inserted before! Please try again!");
                }
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == System.Data.ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string Table = "SINHVIEN";
                string search = "select * from SINHVIEN where SINHVIEN.MASV = '" + sinhvien.Text + "' and SINHVIEN.TENSV = '" + hoten.Text + "'";
                SqlCommand cmd = new SqlCommand(search, connsql);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ShowListSV.Items.Add("Ma SV: " + reader["MASV"].ToString() + " " + "Ten SV: " + reader["TENSV"].ToString());
                reader.Close();
                if (connsql.State == System.Data.ConnectionState.Open)
                {
                    connsql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to show data!");
            }
        }
    }
}