namespace store_project
{
    partial class frmProductUpDel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductUpDel));
            this.nudProQuan = new System.Windows.Forms.NumericUpDown();
            this.btProImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcdProImage = new System.Windows.Forms.PictureBox();
            this.tbProUnit = new System.Windows.Forms.TextBox();
            this.tbProPrice = new System.Windows.Forms.TextBox();
            this.tbProName = new System.Windows.Forms.TextBox();
            this.rdoProStatusOff = new System.Windows.Forms.RadioButton();
            this.rdoProStatusOn = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btProDelete = new System.Windows.Forms.Button();
            this.btProUpdate = new System.Windows.Forms.Button();
            this.tbProId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudProQuan)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcdProImage)).BeginInit();
            this.SuspendLayout();
            // 
            // nudProQuan
            // 
            this.nudProQuan.Location = new System.Drawing.Point(134, 310);
            this.nudProQuan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProQuan.Name = "nudProQuan";
            this.nudProQuan.Size = new System.Drawing.Size(216, 20);
            this.nudProQuan.TabIndex = 34;
            this.nudProQuan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btProImage
            // 
            this.btProImage.Location = new System.Drawing.Point(316, 188);
            this.btProImage.Name = "btProImage";
            this.btProImage.Size = new System.Drawing.Size(34, 23);
            this.btProImage.TabIndex = 33;
            this.btProImage.Text = "...";
            this.btProImage.UseVisualStyleBackColor = true;
            this.btProImage.Click += new System.EventHandler(this.btProImage_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pcdProImage);
            this.panel1.Location = new System.Drawing.Point(134, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 123);
            this.panel1.TabIndex = 32;
            // 
            // pcdProImage
            // 
            this.pcdProImage.Location = new System.Drawing.Point(3, 3);
            this.pcdProImage.Name = "pcdProImage";
            this.pcdProImage.Size = new System.Drawing.Size(169, 115);
            this.pcdProImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcdProImage.TabIndex = 0;
            this.pcdProImage.TabStop = false;
            // 
            // tbProUnit
            // 
            this.tbProUnit.Location = new System.Drawing.Point(134, 343);
            this.tbProUnit.Name = "tbProUnit";
            this.tbProUnit.Size = new System.Drawing.Size(216, 20);
            this.tbProUnit.TabIndex = 31;
            // 
            // tbProPrice
            // 
            this.tbProPrice.Location = new System.Drawing.Point(134, 277);
            this.tbProPrice.Name = "tbProPrice";
            this.tbProPrice.Size = new System.Drawing.Size(216, 20);
            this.tbProPrice.TabIndex = 30;
            this.tbProPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProPrice_KeyPress);
            // 
            // tbProName
            // 
            this.tbProName.Location = new System.Drawing.Point(134, 244);
            this.tbProName.Name = "tbProName";
            this.tbProName.Size = new System.Drawing.Size(216, 20);
            this.tbProName.TabIndex = 29;
            // 
            // rdoProStatusOff
            // 
            this.rdoProStatusOff.AutoSize = true;
            this.rdoProStatusOff.Location = new System.Drawing.Point(245, 375);
            this.rdoProStatusOff.Name = "rdoProStatusOff";
            this.rdoProStatusOff.Size = new System.Drawing.Size(83, 17);
            this.rdoProStatusOff.TabIndex = 26;
            this.rdoProStatusOff.Text = "ไม่พร้อมขาย";
            this.rdoProStatusOff.UseVisualStyleBackColor = true;
            // 
            // rdoProStatusOn
            // 
            this.rdoProStatusOn.AutoSize = true;
            this.rdoProStatusOn.Checked = true;
            this.rdoProStatusOn.Location = new System.Drawing.Point(151, 373);
            this.rdoProStatusOn.Name = "rdoProStatusOn";
            this.rdoProStatusOn.Size = new System.Drawing.Size(70, 17);
            this.rdoProStatusOn.TabIndex = 25;
            this.rdoProStatusOn.TabStop = true;
            this.rdoProStatusOn.Text = "พร้อมขาย";
            this.rdoProStatusOn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "สถานะสินค้า";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "หน่วยสินค้า";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "จำนวนสินค้า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "ราคาสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "ชื่อสินค้า";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 51);
            this.label1.TabIndex = 19;
            this.label1.Text = "แก้ไข / ลบ สินค้า";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btProDelete
            // 
            this.btProDelete.BackColor = System.Drawing.Color.Red;
            this.btProDelete.Image = global::store_project.Properties.Resources.delete;
            this.btProDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btProDelete.Location = new System.Drawing.Point(222, 396);
            this.btProDelete.Name = "btProDelete";
            this.btProDelete.Size = new System.Drawing.Size(106, 48);
            this.btProDelete.TabIndex = 28;
            this.btProDelete.Text = "ลบสินค้า";
            this.btProDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btProDelete.UseVisualStyleBackColor = false;
            this.btProDelete.Click += new System.EventHandler(this.btProDelete_Click);
            // 
            // btProUpdate
            // 
            this.btProUpdate.BackColor = System.Drawing.Color.GreenYellow;
            this.btProUpdate.Image = global::store_project.Properties.Resources.update;
            this.btProUpdate.Location = new System.Drawing.Point(104, 396);
            this.btProUpdate.Name = "btProUpdate";
            this.btProUpdate.Size = new System.Drawing.Size(106, 48);
            this.btProUpdate.TabIndex = 27;
            this.btProUpdate.Text = "แก้ไขสินค้า";
            this.btProUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btProUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btProUpdate.UseVisualStyleBackColor = false;
            this.btProUpdate.Click += new System.EventHandler(this.btProUpdate_Click);
            // 
            // tbProId
            // 
            this.tbProId.Location = new System.Drawing.Point(218, 218);
            this.tbProId.Name = "tbProId";
            this.tbProId.ReadOnly = true;
            this.tbProId.Size = new System.Drawing.Size(82, 20);
            this.tbProId.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "รหัสสินค้า";
            // 
            // frmProductUpDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbProId);
            this.Controls.Add(this.nudProQuan);
            this.Controls.Add(this.btProImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbProUnit);
            this.Controls.Add(this.tbProPrice);
            this.Controls.Add(this.tbProName);
            this.Controls.Add(this.btProDelete);
            this.Controls.Add(this.btProUpdate);
            this.Controls.Add(this.rdoProStatusOff);
            this.Controls.Add(this.rdoProStatusOn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProductUpDel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "แก้ไข/ลบ สินค้า - บริหารจัดการข้อมูลสินค้า";
            this.Load += new System.EventHandler(this.frmProductUpDel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProQuan)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcdProImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudProQuan;
        private System.Windows.Forms.Button btProImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcdProImage;
        private System.Windows.Forms.TextBox tbProUnit;
        private System.Windows.Forms.TextBox tbProPrice;
        private System.Windows.Forms.TextBox tbProName;
        private System.Windows.Forms.Button btProDelete;
        private System.Windows.Forms.Button btProUpdate;
        private System.Windows.Forms.RadioButton rdoProStatusOff;
        private System.Windows.Forms.RadioButton rdoProStatusOn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProId;
        private System.Windows.Forms.Label label7;
    }
}