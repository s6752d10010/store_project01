namespace store_project
{
    partial class frmProductShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductShow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvAllProduct = new System.Windows.Forms.ListView();
            this.btnProductCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "บริหารจัดการข้อมูลสินค้า";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(490, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "*เมื่อต้องการแก้ไขหรือลบสินค้าให้คลิกที่รายการสินค้า";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvAllProduct
            // 
            this.lvAllProduct.HideSelection = false;
            this.lvAllProduct.Location = new System.Drawing.Point(29, 91);
            this.lvAllProduct.Name = "lvAllProduct";
            this.lvAllProduct.Size = new System.Drawing.Size(741, 268);
            this.lvAllProduct.TabIndex = 3;
            this.lvAllProduct.UseCompatibleStateImageBehavior = false;
            this.lvAllProduct.ItemActivate += new System.EventHandler(this.lvAllProduct_ItemActivate);
            // 
            // btnProductCreate
            // 
            this.btnProductCreate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProductCreate.Image = global::store_project.Properties.Resources.basket;
            this.btnProductCreate.Location = new System.Drawing.Point(664, 365);
            this.btnProductCreate.Name = "btnProductCreate";
            this.btnProductCreate.Size = new System.Drawing.Size(106, 48);
            this.btnProductCreate.TabIndex = 0;
            this.btnProductCreate.Text = "เพิ่มข้อมูลสินค้า";
            this.btnProductCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductCreate.UseVisualStyleBackColor = false;
            this.btnProductCreate.Click += new System.EventHandler(this.btnProductCreate_Click);
            // 
            // frmProductShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvAllProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProductCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProductShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "บริหารจัดการข้อมูลสินค้า";
            this.Load += new System.EventHandler(this.frmProductShow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvAllProduct;
    }
}