using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_project
{
    public partial class frmProductShow : Form
    {
        public frmProductShow()
        {
            InitializeComponent();
        }

        //แปลง byte เป็นภาพ
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

        // method ไว้ดึงข้อมูล
        private void getAllProductToLV()
        {
            //กำหนด connection string เพื่อติดต่อไปยัง Database
            string connectionString = @"Server=DESKTOP-9U4FO0V\SQLEXPRESS;Database=store_db;trusted_Connection=True;";

            //สร้าง connection
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    string strSQL = "select proID, proName, proPrice, proQuan, proUnit, proStatus, proImage from product";
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(strSQL, sqlConnection))
                    {
                        //เอาข้อมูลที่ได้จาก strSQL ที่เป็นก้อน มาแปลงเป็น Table
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        //ตั้งค่า listViews
                        lvAllProduct.Items.Clear();
                        lvAllProduct.Columns.Clear();
                        lvAllProduct.FullRowSelect = true;
                        lvAllProduct.View = View.Details;

                        //ตั้งค่าการแสดง img ใน listView
                        if (lvAllProduct.SmallImageList == null)
                        {
                            lvAllProduct.SmallImageList = new ImageList();
                            lvAllProduct.SmallImageList.ImageSize = new Size(50, 50);
                            lvAllProduct.SmallImageList.ColorDepth = ColorDepth.Depth32Bit;
                        }
                        lvAllProduct.SmallImageList.Images.Clear();

                        //กำหนดรายละเอียดของ column ใน listView
                        lvAllProduct.Columns.Add("รูปภาพ", 150, HorizontalAlignment.Left);
                        lvAllProduct.Columns.Add("รหัสสินค้า", 80, HorizontalAlignment.Left);
                        lvAllProduct.Columns.Add("ชื่อสินค้า", 170, HorizontalAlignment.Left);
                        lvAllProduct.Columns.Add("ราคา", 80, HorizontalAlignment.Left);
                        lvAllProduct.Columns.Add("จำนวน", 80, HorizontalAlignment.Left);
                        lvAllProduct.Columns.Add("หน่วย", 80, HorizontalAlignment.Left);
                        lvAllProduct.Columns.Add("สภานะ", 80, HorizontalAlignment.Left);

                        //loop ข้อมูลใส่ใน Table
                        foreach (DataRow dataRow in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem(); //สร้าง item เพื่อเก็บแต่ละข้อมูลในแต่ละรายการ
                            Image proImage = null;
                            if (dataRow["proImage"] != DBNull.Value)
                            {
                                byte[] imgByte = (byte[])dataRow["proImage"];

                                //แปลง byte เป็นภาพ
                                proImage = convertByteArrayToImage(imgByte);
                            }

                            string imageKey = null;
                            if (proImage != null)
                            {
                                imageKey = $"pro_{dataRow["proID"]}";
                                lvAllProduct.SmallImageList.Images.Add(imageKey, proImage);
                                item.ImageKey = imageKey;
                            }
                            else
                            {
                                item.ImageIndex = -1;
                            }
                            item.SubItems.Add(dataRow["proId"].ToString());
                            item.SubItems.Add(dataRow["proName"].ToString());
                            item.SubItems.Add(dataRow["proPrice"].ToString());
                            item.SubItems.Add(dataRow["proQuan"].ToString());
                            item.SubItems.Add(dataRow["proUnit"].ToString());
                            item.SubItems.Add(dataRow["proStatus"].ToString());

                            //เอาข้อมูลใน item ใส่ใน listView
                            lvAllProduct.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("พบข้อผิดพลาด :" + ex.Message);
                }
            }

        }

        // จะทำงานทุกครั้งที่ Form เปิดขึ้นมา
        private void frmProductShow_Load(object sender, EventArgs e)
        {
            getAllProductToLV();
        }

        private void btnProductCreate_Click(object sender, EventArgs e)
        {
            frmProductCreate productForm = new frmProductCreate();
            //productForm.Show(); //เปิดจอเล่นได้ทั้งคู่
            productForm.ShowDialog(); //เปิดจอเเล่นได้จอเดียว
            getAllProductToLV();
        }

        private void lvAllProduct_ItemActivate(object sender, EventArgs e)
        {
            frmProductUpDel frmProductUpDel = new frmProductUpDel(
                int.Parse(lvAllProduct.SelectedItems[0].SubItems[1].Text)
             );
            frmProductUpDel.ShowDialog();
            getAllProductToLV();
        }
    }
}
