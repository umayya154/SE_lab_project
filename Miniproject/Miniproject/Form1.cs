using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniproject
{
    public partial class Form1 : Form
    {
        // DataBase connection.
        SqlConnection connec = new SqlConnection("Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True");
        SqlCommand cmmd;
        SqlDataAdapter adapt;
        //ID variable is used for update and delete.
        int ID = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //It will store all studnet information in DB.
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                cmmd = new SqlCommand("insert into Student(FirstName, LastName, Contact, Email, RegistrationNumber, Status)values(@FirstName, @LastName, @Contact, @Email, @RegistrationNumber, @Status)", connec);
                connec.Open();
                cmmd.Parameters.AddWithValue("@FirstName", textBox2.Text);
                cmmd.Parameters.AddWithValue("@LastName", textBox3.Text);
                cmmd.Parameters.AddWithValue("@Contact", textBox4.Text);
                cmmd.Parameters.AddWithValue("@Email", textBox5.Text);
                cmmd.Parameters.AddWithValue("@RegistrationNumber", textBox6.Text);
                cmmd.Parameters.AddWithValue("@Status", textBox7.Text);
                connec.Close();
                MessageBox.Show("Saved");
                DisplayDataInGridView();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connec.Close();
            }
        }
            
    //DisplayDataInGridView();

    //ClearData();
    //Function used to display data in gridview.
    private void DisplayDataInGridView()
        {
            connec.Open();
            DataTable table = new DataTable();
            adapt = new SqlDataAdapter("select *from Student", connec);
            adapt.Fill(table);
            dataGridView1.DataSource = table;
            connec.Close();
        }
        //It will clear the data of these textbox while updating. 
        private void ClearData()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            ID = 0;
            connec.Open();


        }
        //Show data in gridview.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            DisplayDataInGridView();
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        //It will update data in student table .
        private void button3_Click(object sender, EventArgs e)
        {try
            {
                cmmd = new SqlCommand("update Student set FirstName=@FirstName,LastName=@ LastName, Contact=@Contact, Email=@Email, RegistrationNumber=@RegistrationNumber, Status=@Status  where Id=@Id ", connec);
                connec.Open();
                cmmd.Parameters.AddWithValue("@FirstName", textBox2.Text);
                cmmd.Parameters.AddWithValue("@LastName", textBox3.Text);
                cmmd.Parameters.AddWithValue("@Contact", textBox4.Text);
                cmmd.Parameters.AddWithValue("@Email", textBox5.Text);
                cmmd.Parameters.AddWithValue("@RegistrationNumber", textBox6.Text);
                cmmd.Parameters.AddWithValue("@Status", textBox7.Text);
                //cmd.ExecuteNonQuery();
                connec.Close();
                MessageBox.Show("Updated Successfully");
                DisplayDataInGridView();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connec.Close();
            }
        }
        //It will delete the whole tuple .
        private void button2_Click(object sender, EventArgs e)
        {
            try {
                cmmd = new SqlCommand("delete Student where RegistrationNumber = @RegistrationNumber", connec);
                connec.Open();
                cmmd.Parameters.AddWithValue("@RegistrationNumber", connec.ClientConnectionId);
                cmmd.ExecuteNonQuery();
                connec.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayDataInGridView();
                ClearData();
               }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connec.Close();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //It will show previous data in Db on page loading.
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select *from Student", connec);
            DataSet ds = new DataSet();
            da.Fill(ds,"Student");
            dataGridView1.DataSource = ds.Tables["Student"].DefaultView;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                cmmd = new SqlCommand("insert into Clo (Name,DateCreated,DateUpload)values(@Name,@DateCreated,@DateUpload )", connec);
                connec.Open();
                cmmd.Parameters.AddWithValue("@Name", textBox8.Text);
                cmmd.Parameters.AddWithValue("@DateCreated", textBox9.Text);
                cmmd.Parameters.AddWithValue("@DateUpload", textBox10.Text);
                connec.Close();
                MessageBox.Show("Saved");
            }

        
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connec.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                cmmd = new SqlCommand("delete Clo where Name = @Name", connec);
                connec.Open();
                cmmd.Parameters.AddWithValue("@Name", connec.ClientConnectionId);
                cmmd.ExecuteNonQuery();
                connec.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayDataInGridView();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connec.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                cmmd = new SqlCommand("update Clo set Name=@Name, DateCreated=@DateCreated,DateUpload =@DateUpload  where Id=@Id ", connec);
                connec.Open();
                cmmd.Parameters.AddWithValue("@Name", textBox8.Text);
                cmmd.Parameters.AddWithValue("@DateCreated", textBox9.Text);
                cmmd.Parameters.AddWithValue("@DateUpload", textBox10.Text);
                
                //cmd.ExecuteNonQuery();
                connec.Close();
                MessageBox.Show("Updated Successfully");
                DisplayDataInGridView();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connec.Close();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            DisplayDataInGridView();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                cmmd = new SqlCommand("insert into Rubric(Details,CloId ) values(@Details, @CloId)", connec);
                
                connec.Open();
                cmmd.Parameters.AddWithValue("@Details", textBox13.Text);
                cmmd.Parameters.AddWithValue("@CloId ", textBox14.Text);
                
                connec.Close();
                MessageBox.Show("Saved");
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connec.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                cmmd = new SqlCommand("delete Rubric where CloId= @CloId", connec);
                connec.Open();
                cmmd.Parameters.AddWithValue("@CloId", connec.ClientConnectionId);
                cmmd.ExecuteNonQuery();
                connec.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayDataInGridView();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connec.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                cmmd = new SqlCommand("update Rubric set Details =@Details, CloId = @CloId where Id=@Id ", connec);
                connec.Open();
                cmmd.Parameters.AddWithValue("@ Details", textBox8.Text);
                cmmd.Parameters.AddWithValue("@CloId", textBox9.Text);
                

                //cmd.ExecuteNonQuery();
                connec.Close();
                MessageBox.Show("Updated Successfully");
                DisplayDataInGridView();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connec.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                cmmd = new SqlCommand("insert into RubricId (RubricId,Details ,Measurement)values(@RubricId,@Details,  @ Measurement)", connec);

                connec.Open();
                cmmd.Parameters.AddWithValue("@RubricId", textBox1.Text);
                cmmd.Parameters.AddWithValue("@Details ", textBox15.Text);
                cmmd.Parameters.AddWithValue("@ Measurement ", textBox16.Text);

                connec.Close();
                MessageBox.Show("Saved");
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connec.Close();
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {

            try
            {
                cmmd = new SqlCommand("delete RubricId where RubricId= @RubricId", connec);
                connec.Open();
                cmmd.Parameters.AddWithValue("@RubricId", connec.ClientConnectionId);
                cmmd.ExecuteNonQuery();
                connec.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayDataInGridView();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connec.Close();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                cmmd = new SqlCommand("update RubricId set RubricId = @RubricId,Details =@Details, Measurement = @ Measurement ", connec);
                connec.Open();
                cmmd.Parameters.AddWithValue("@RubricId", textBox1.Text);
                cmmd.Parameters.AddWithValue("@Details ", textBox15.Text);
                cmmd.Parameters.AddWithValue("@Measurement ", textBox16.Text);


                //cmd.ExecuteNonQuery();
                connec.Close();
                MessageBox.Show("Updated Successfully");
                DisplayDataInGridView();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connec.Close();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                cmmd = new SqlCommand("insert into Lookup (LookupId,Name ,Category)values( @LookupId,@Name, @Category", connec);

                connec.Open();
                cmmd.Parameters.AddWithValue("@LookupId", txtlook.Text);
                cmmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmmd.Parameters.AddWithValue("@Category", txtcat.Text);

                connec.Close();
                MessageBox.Show("Saved");
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connec.Close();
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                cmmd = new SqlCommand("delete Lookup where Id = @Id", connec);
                connec.Open();
                cmmd.Parameters.AddWithValue("@Id", connec.ClientConnectionId);
                cmmd.ExecuteNonQuery();
                connec.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayDataInGridView();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connec.Close();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                cmmd = new SqlCommand("update Lookup set LookupId= @LookupId,Name=@Name, Category = @Category ", connec);
                connec.Open();
                cmmd.Parameters.AddWithValue("@LookupId", txtlook.Text);
                cmmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmmd.Parameters.AddWithValue("@Category", txtcat.Text);


                //cmd.ExecuteNonQuery();
                connec.Close();
                MessageBox.Show("Updated Successfully");
                DisplayDataInGridView();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connec.Close();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox13.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox14.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            DisplayDataInGridView();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox15.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox16.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            DisplayDataInGridView();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtlook.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcat.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            DisplayDataInGridView();
        }
    }
}

