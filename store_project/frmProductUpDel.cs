using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_project
{


    public partial class frmProductUpDel : Form
    {
        byte[] proImage;
        int proId;
        public frmProductUpDel(int proId)
        {
            InitializeComponent();
            this.proId = proId;
        }

        private byte[] convertImageToByteArray(Image image, ImageFormat imageFormat)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, imageFormat);
                return ms.ToArray();
            }
        }

        private Image convertByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0)
            {
                return null;
            }
            try
            {
                using (MemoryStream ms = new MemoryStream(byteArrayIn))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (ArgumentException ex)
            {
                // อาจเกิดขึ้นถ้า byte array ไม่ใช่ข้อมูลรูปภาพที่ถูกต้อง
                Console.WriteLine("Error converting byte array to image: " + ex.Message);
                return null;
            }
        }

        private void frmProductUpDel_Load(object sender, EventArgs e)
        {
            //เอา proId ที่ส่งมา ไปค้นหาสินค้าใน database และเอาข้อมูลไปแสดง

            string connectionString = @"Server=DESKTOP-9U4FO0V\SQLEXPRESS;Database=store_db;trusted_Connection=True;";

            //สร้าง connection
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                try
                {
                    string strSQL = "select proID, proName, proPrice, proQuan, proUnit, proStatus, proImage from product Where proId = @proId";

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(strSQL, sqlConnection))
                    {
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@proId", proId);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        DataRow row = dataTable.Rows[0];
                        tbProId.Text = row["ProId"].ToString();
                        tbProName.Text = row["proName"].ToString();
                        tbProPrice.Text = row["proPrice"].ToString();
                        nudProQuan.Value = int.Parse(row["proQuan"].ToString());
                        tbProUnit.Text = row["proUnit"].ToString();
                        if (row["proStatus"].ToString() == "พร้อมขาย")
                        {
                            rdoProStatusOn.Checked = true;
                        }
                        else
                        {
                            rdoProStatusOff.Checked = true;
                        }

                        if (row["proImage"] == DBNull.Value)
                        {
                            pcdProImage.Image = null;
                        }
                        else
                        {
                            pcdProImage.Image = convertByteArrayToImage((byte[])row["proImage"]);
                        }



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("พบข้อผิดพลาด :" + ex.Message);
                }
            }
        }
        private void btProImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "Image Files (*.jpg;*.png) | *.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //เอารูปที่เลือกไปแสดงที่ pcdProImage
                pcdProImage.Image = Image.FromFile(ofd.FileName);
                //check format image และส่งรูปไปแปลง
                if (pcdProImage.Image.RawFormat == ImageFormat.Jpeg)
                {
                    proImage = convertImageToByteArray(pcdProImage.Image, ImageFormat.Jpeg);
                }
                else
                {
                    proImage = convertImageToByteArray(pcdProImage.Image, ImageFormat.Png);
                }
            }


        }

        private void btProDelete_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-9U4FO0V\SQLEXPRESS;Database=store_db;trusted_Connection=True;";

            //สร้าง connection
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlTransaction sqlTransaction = sqlConnection.BeginTransaction(); //ใช้กับ CRUD
                try
                {
                    string strSQL = "DELETE FROM product WHERE proID = @proId";

                    using (SqlCommand command = new SqlCommand(strSQL, sqlConnection, sqlTransaction))
                    {
                        // แก้ตรงนี้ ใช้ AddWithValue
                        command.Parameters.Add("@proId", SqlDbType.Int).Value = tbProId.Text;

                        command.ExecuteNonQuery();
                        sqlTransaction.Commit();
                    
                            MessageBox.Show("ลบข้อมูลสำเร็จ");
                            this.Close();
               
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("พบข้อผิดพลาด :" + ex.Message);
                }

            }
        }
        private void alertValidate(string msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btProUpdate_Click(object sender, EventArgs e)
        {
            if (proImage == null)
            {
                alertValidate("กรุณาเลือกภาพสินค้า");
            }
            else if (tbProName.Text.Length == 0)
            {
                alertValidate("กรุณาป้อนชื่อสินค้า");
            }
            else if (tbProPrice.Text.Length == 0)
            {
                alertValidate("กรุณาป้อนราคาสินค้า");
            }
            else if (nudProQuan.Value <= 0)
            {
                alertValidate("สินค้าต้องราคามากกว่า 0 บาท");
            }
            else if (tbProUnit.Text.Length == 0)
            {
                alertValidate("กรุณาป้อนหน่วยสินค้า");
            }
            else
            {
                //บันทึกลง db

                string connectionString = @"Server=DESKTOP-9U4FO0V\SQLEXPRESS;Database=store_db;trusted_Connection=True;";

                //สร้าง connection
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    try
                    {
                        sqlConnection.Open();
                        SqlTransaction sqlTransaction = sqlConnection.BeginTransaction(); //ใช้กับ CRUD
                        string strSQL = "UPDATE product SET " +
                     "proName = @proName, " +
                     "proPrice = @proPrice, " +
                     "proQuan = @proQuan, " +
                     "proUnit = @proUnit, " +
                     "proStatus = @proStatus, " +
                     "proImage = @proImage, " +
                     "createAt = @createAt, " +
                     "updateAt = @updateAt " +
                     "WHERE proID = @proId";

                        using (SqlCommand command = new SqlCommand(strSQL, sqlConnection, sqlTransaction))
                        {

                            //กำหนด Parameter
                            command.Parameters.Add("@proId", SqlDbType.Int).Value = tbProId.Text;
                            command.Parameters.Add("@proName", SqlDbType.NVarChar, 300).Value = tbProName.Text;
                            command.Parameters.Add("@proPrice", SqlDbType.Float).Value = float.Parse(tbProPrice.Text);
                            command.Parameters.Add("@proQuan", SqlDbType.Int).Value = int.Parse(nudProQuan.Value.ToString());
                            command.Parameters.Add("proUnit", SqlDbType.NVarChar, 50).Value = tbProUnit.Text;
                            if (rdoProStatusOn.Checked == true)
                            {
                                command.Parameters.Add("@proStatus", SqlDbType.NVarChar, 50).Value = "พร้อมขาย";
                            }
                            else
                            {
                                command.Parameters.Add("@proStatus", SqlDbType.NVarChar, 50).Value = "ไม่พร้อมขาย";
                            }
                            command.Parameters.Add("@proImage", SqlDbType.Image).Value = proImage;
                            command.Parameters.Add("@createAt", SqlDbType.Date).Value = DateTime.Now.Date;
                            command.Parameters.Add("@updateAt", SqlDbType.Date).Value = DateTime.Now.Date;

                            //excute sql
                            command.ExecuteNonQuery();
                            sqlTransaction.Commit();

                            MessageBox.Show("สำเร็จ");

                            this.Close();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("พบข้อผิดพลาด :" + ex.Message);
                    }
            }
        }

        private void tbProPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // อนุญาตเฉพาะตัวเลข, จุดทศนิยม (.) และ Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // ไม่ให้พิมพ์จุด (.) ซ้ำ
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
