namespace Lopyshok
{
    partial class FormAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.articleTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.countPeopleTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.workShopTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.minCostTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteProductBtn = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.addMaterial = new System.Windows.Forms.Button();
            this.materialView = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(323, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 51);
            this.label1.TabIndex = 33;
            this.label1.Text = "Продукт";
            // 
            // productImage
            // 
            this.productImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImage.Image = global::Lopyshok.Properties.Resources.picture;
            this.productImage.Location = new System.Drawing.Point(56, 180);
            this.productImage.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(196, 181);
            this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImage.TabIndex = 34;
            this.productImage.TabStop = false;
            this.productImage.Click += new System.EventHandler(this.productImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 31);
            this.label2.TabIndex = 35;
            this.label2.Text = "Название";
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(332, 105);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(255, 36);
            this.titleTxt.TabIndex = 36;
            // 
            // articleTxt
            // 
            this.articleTxt.Location = new System.Drawing.Point(332, 180);
            this.articleTxt.Name = "articleTxt";
            this.articleTxt.Size = new System.Drawing.Size(255, 36);
            this.articleTxt.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 31);
            this.label3.TabIndex = 37;
            this.label3.Text = "Артикул";
            // 
            // countPeopleTxt
            // 
            this.countPeopleTxt.Location = new System.Drawing.Point(332, 255);
            this.countPeopleTxt.Name = "countPeopleTxt";
            this.countPeopleTxt.Size = new System.Drawing.Size(255, 36);
            this.countPeopleTxt.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 31);
            this.label4.TabIndex = 39;
            this.label4.Text = "Количество человек для производства";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 31);
            this.label5.TabIndex = 41;
            this.label5.Text = "Изображение";
            // 
            // workShopTxt
            // 
            this.workShopTxt.Location = new System.Drawing.Point(332, 336);
            this.workShopTxt.Name = "workShopTxt";
            this.workShopTxt.Size = new System.Drawing.Size(255, 36);
            this.workShopTxt.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 31);
            this.label6.TabIndex = 42;
            this.label6.Text = "Номер производственного цеха";
            // 
            // minCostTxt
            // 
            this.minCostTxt.Location = new System.Drawing.Point(332, 412);
            this.minCostTxt.Name = "minCostTxt";
            this.minCostTxt.Size = new System.Drawing.Size(255, 36);
            this.minCostTxt.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 31);
            this.label7.TabIndex = 44;
            this.label7.Text = "Минимальная стоимость для агента";
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(332, 492);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(255, 39);
            this.typeBox.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 31);
            this.label8.TabIndex = 47;
            this.label8.Text = "Тип продукта";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(56, 413);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descriptionTxt.Size = new System.Drawing.Size(196, 118);
            this.descriptionTxt.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 31);
            this.label9.TabIndex = 48;
            this.label9.Text = "Описание продукта";
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteProductBtn.Location = new System.Drawing.Point(332, 561);
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.Size = new System.Drawing.Size(247, 53);
            this.deleteProductBtn.TabIndex = 51;
            this.deleteProductBtn.Text = "Удалить продукт";
            this.deleteProductBtn.UseVisualStyleBackColor = true;
            this.deleteProductBtn.Visible = false;
            this.deleteProductBtn.Click += new System.EventHandler(this.deleteProductBtn_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProductBtn.Location = new System.Drawing.Point(56, 561);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(247, 53);
            this.addProductBtn.TabIndex = 50;
            this.addProductBtn.Text = "Редактировать продукт";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(655, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 51);
            this.label10.TabIndex = 52;
            this.label10.Text = "Материалы";
            // 
            // addMaterial
            // 
            this.addMaterial.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMaterial.Location = new System.Drawing.Point(664, 135);
            this.addMaterial.Name = "addMaterial";
            this.addMaterial.Size = new System.Drawing.Size(197, 43);
            this.addMaterial.TabIndex = 53;
            this.addMaterial.Text = "Редактировать продукт";
            this.addMaterial.UseVisualStyleBackColor = true;
            this.addMaterial.Click += new System.EventHandler(this.addMaterial_Click);
            // 
            // materialView
            // 
            this.materialView.AllowUserToAddRows = false;
            this.materialView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.materialView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.PhoneNumber});
            this.materialView.Location = new System.Drawing.Point(664, 193);
            this.materialView.Name = "materialView";
            this.materialView.RowHeadersWidth = 51;
            this.materialView.RowTemplate.Height = 24;
            this.materialView.Size = new System.Drawing.Size(349, 244);
            this.materialView.TabIndex = 104;
            this.materialView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialView_CellContentDoubleClick);
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Название";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 200;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Количество";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 125;
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1067, 632);
            this.Controls.Add(this.materialView);
            this.Controls.Add(this.addMaterial);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.deleteProductBtn);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.minCostTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.workShopTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.countPeopleTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.articleTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productImage);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MaximumSize = new System.Drawing.Size(1085, 679);
            this.MinimumSize = new System.Drawing.Size(1085, 679);
            this.Name = "FormAddProduct";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox articleTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox countPeopleTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox workShopTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox minCostTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button deleteProductBtn;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addMaterial;
        private System.Windows.Forms.DataGridView materialView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
    }
}