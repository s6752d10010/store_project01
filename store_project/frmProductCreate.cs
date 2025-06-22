using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace store_project
{
    public partial class frmProductCreate : Form
    {
        //สร้างตัวแปร ไว้เก็บ Binary ไว้บันทึกลง database
        byte[] proImage;
        public frmProductCreate()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        // method แปลงภาพเป็น binary
        private byte[] convertImageToByteArray(Image image, ImageFormat imageFormat)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, imageFormat);
                return ms.ToArray();
            }
        }

        private void btProImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "Image Files (*.jpg;*.png) | *.jpg;*.png";
            if(ofd.ShowDialog()== DialogResult.OK)
            {
                //เอารูปที่เลือกไปแสดงที่ pcdProImage
                pcdProImage.Image = Image.FromFile(ofd.FileName);
                //check format image และส่งรูปไปแปลง
                if (pcdProImage.Image.RawFormat == ImageFormat.Jpeg)
                {
                    proImage = convertImageToByteArray(pcdProImage.Image,ImageFormat.Jpeg);
                }
                else {
                    proImage = convertImageToByteArray(pcdProImage.Image, ImageFormat.Png);
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

        //method alert validate data
        private void alertValidate(string msg)
        {
            MessageBox.Show(msg, "คำเตือน",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (proImage == null)
            {
                alertValidate("กรุณาเลือกภาพสินค้า");
            }else if (tbProName.Text.Length == 0)
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
                        string strSQL = "INSERT INTO product (proName, proPrice, proQuan, proUnit, proStatus, proImage, createAt,updateAt)" +
                                        "VALUES (@proName,@proPrice,@proQuan,@proUnit,@proStatus,@proImage,@createAt,@updateAt)";

                        using (SqlCommand command = new SqlCommand(strSQL, sqlConnection, sqlTransaction))
                        {

                            //กำหนด Parameter
                            command.Parameters.Add("@proName", SqlDbType.NVarChar,300).Value = tbProName.Text;
                            command.Parameters.Add("@proPrice", SqlDbType.Float).Value = float.Parse(tbProPrice.Text);
                            command.Parameters.Add("@proQuan", SqlDbType.Int).Value = int.Parse(nudProQuan.Value.ToString());
                            command.Parameters.Add("proUnit",SqlDbType.NVarChar,50).Value = tbProUnit.Text;
                            if (rdoProStatusOn.Checked == true) {
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
                    catch (Exception ex) {
                        MessageBox.Show("พบข้อผิดพลาด :" + ex.Message);
                    } 



            }

        }

        private void frmProductCreate_Load(object sender, EventArgs e)
        {

        }
    }



}
