namespace store_project
{
    partial class frmProductCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductCreate));
            this.nudProQuan = new System.Windows.Forms.NumericUpDown();
            this.btProImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcdProImage = new System.Windows.Forms.PictureBox();
            this.tbProUnit = new System.Windows.Forms.TextBox();
            this.tbProPrice = new System.Windows.Forms.TextBox();
            this.tbProName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.rdoProStatusOff = new System.Windows.Forms.RadioButton();
            this.rdoProStatusOn = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudProQuan)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcdProImage)).BeginInit();
            this.SuspendLayout();
            // 
            // nudProQuan
            // 
            this.nudProQuan.Location = new System.Drawing.Point(134, 295);
            this.nudProQuan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProQuan.Name = "nudProQuan";
            this.nudProQuan.Size = new System.Drawing.Size(216, 20);
            this.nudProQuan.TabIndex = 50;
            this.nudProQuan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btProImage
            // 
            this.btProImage.Location = new System.Drawing.Point(316, 196);
            this.btProImage.Name = "btProImage";
            this.btProImage.Size = new System.Drawing.Size(34, 23);
            this.btProImage.TabIndex = 49;
            this.btProImage.Text = "...";
            this.btProImage.UseVisualStyleBackColor = true;
            this.btProImage.Click += new System.EventHandler(this.btProImage_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pcdProImage);
            this.panel1.Location = new System.Drawing.Point(134, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 123);
            this.panel1.TabIndex = 48;
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
            this.tbProUnit.Location = new System.Drawing.Point(134, 328);
            this.tbProUnit.Name = "tbProUnit";
            this.tbProUnit.Size = new System.Drawing.Size(216, 20);
            this.tbProUnit.TabIndex = 47;
            // 
            // tbProPrice
            // 
            this.tbProPrice.Location = new System.Drawing.Point(134, 262);
            this.tbProPrice.Name = "tbProPrice";
            this.tbProPrice.Size = new System.Drawing.Size(216, 20);
            this.tbProPrice.TabIndex = 46;
            this.tbProPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProPrice_KeyPress);
            // 
            // tbProName
            // 
            this.tbProName.Location = new System.Drawing.Point(134, 229);
            this.tbProName.Name = "tbProName";
            this.tbProName.Size = new System.Drawing.Size(216, 20);
            this.tbProName.TabIndex = 45;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Image = global::store_project.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(222, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 48);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnSave.Image = global::store_project.Properties.Resources.save;
            this.BtnSave.Location = new System.Drawing.Point(104, 394);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(106, 48);
            this.BtnSave.TabIndex = 43;
            this.BtnSave.Text = "บันทึกสินค้า";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // rdoProStatusOff
            // 
            this.rdoProStatusOff.AutoSize = true;
            this.rdoProStatusOff.Location = new System.Drawing.Point(245, 360);
            this.rdoProStatusOff.Name = "rdoProStatusOff";
            this.rdoProStatusOff.Size = new System.Drawing.Size(83, 17);
            this.rdoProStatusOff.TabIndex = 42;
            this.rdoProStatusOff.Text = "ไม่พร้อมขาย";
            this.rdoProStatusOff.UseVisualStyleBackColor = true;
            // 
            // rdoProStatusOn
            // 
            this.rdoProStatusOn.AutoSize = true;
            this.rdoProStatusOn.Checked = true;
            this.rdoProStatusOn.Location = new System.Drawing.Point(151, 358);
            this.rdoProStatusOn.Name = "rdoProStatusOn";
            this.rdoProStatusOn.Size = new System.Drawing.Size(70, 17);
            this.rdoProStatusOn.TabIndex = 41;
            this.rdoProStatusOn.TabStop = true;
            this.rdoProStatusOn.Text = "พร้อมขาย";
            this.rdoProStatusOn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "สถานะสินค้า";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "หน่วยสินค้า";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "จำนวนสินค้า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "ราคาสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "ชื่อสินค้า";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 43);
            this.label1.TabIndex = 35;
            this.label1.Text = "เพิ่มสินค้า";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmProductCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.nudProQuan);
            this.Controls.Add(this.btProImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbProUnit);
            this.Controls.Add(this.tbProPrice);
            this.Controls.Add(this.tbProName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnSave);
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
            this.Name = "frmProductCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เพิ่มสินค้า - บริหารจัดการข้อมูลสินค้า";
            this.Load += new System.EventHandler(this.frmProductCreate_Load);
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.RadioButton rdoProStatusOff;
        private System.Windows.Forms.RadioButton rdoProStatusOn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}