using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Buffers;


namespace Activity02DBconnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MCJR804\\SQLEXPRESS;Initial Catalog=SCHOOL;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;

        private void Load_data()
        {
            cmd = new SqlCommand("SELECT * FROM[STUDENT]", con);
            sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Nclear()
        {
            txtid.Text = txtname.Text = txtaddress.Text = "";
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //Load_data();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            txtid.Text = selectedRow.Cells[0].Value.ToString();
            txtname.Text = selectedRow.Cells[1].Value.ToString();
            txtaddress.Text = selectedRow.Cells[2].Value.ToString();
        }

        private void Parameters()
        {
            cmd.Parameters.AddWithValue("ID", txtid.Text);
            cmd.Parameters.AddWithValue("Name", txtname.Text);
            cmd.Parameters.AddWithValue("Address", txtaddress.Text);
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text) || string.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(txtaddress.Text))
            {
                MessageBox.Show("Complete all the required feilds");
                return;
            }
            else
            {
                con.Close();
                cmd = new SqlCommand("INSERT INTO [STUDENT] VALUES (@ID,@Name,@Address)", con);
                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                
                Load_data();
                MessageBox.Show("Record inserted succesfully ");
                Nclear();
            }
        }
        
        private void search_Click(object sender, EventArgs e)
        {
           
            cmd = new SqlCommand("SELECT * FROM [STUDENT] WHERE ID LIKE @SEARCH + '%' OR  Name LIKE @SEARCH +  '%' OR  Address Like @SEARCH + '%'  ",con);
            cmd.Parameters.AddWithValue("@SEARCH",txtSearch.Text);
            sda.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        
        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text) || string.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(txtaddress.Text))
            {
                MessageBox.Show("Complete all the required feilds");
                return;
            }
            else
            {
                con.Close();
                cmd = new SqlCommand("UPDATE [STUDENT] SET ID=@ID, Name = @Name, Address = @Address WHERE ID =@ID", con);
                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                
                Load_data();
                MessageBox.Show("Record updated succesfully ");
                Nclear();

            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("DELETE FROM [STUDENT] WHERE ID=@ID", con);
            Parameters();
            con.Open();
            cmd.ExecuteNonQuery();
            
            Load_data();
            MessageBox.Show("Record deleted succesfully ");
            Nclear();

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
