namespace Lopyshok
{
    partial class ProductControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.productImage = new System.Windows.Forms.PictureBox();
            this.typeTitleLbl = new System.Windows.Forms.Label();
            this.articleLbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.materialLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.SuspendLayout();
            // 
            // productImage
            // 
            this.productImage.Location = new System.Drawing.Point(0, 0);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(161, 158);
            this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImage.TabIndex = 1;
            this.productImage.TabStop = false;
            // 
            // typeTitleLbl
            // 
            this.typeTitleLbl.AutoSize = true;
            this.typeTitleLbl.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeTitleLbl.Location = new System.Drawing.Point(167, 0);
            this.typeTitleLbl.Name = "typeTitleLbl";
            this.typeTitleLbl.Size = new System.Drawing.Size(206, 53);
            this.typeTitleLbl.TabIndex = 2;
            this.typeTitleLbl.Text = "Тип | наименование";
            // 
            // articleLbl
            // 
            this.articleLbl.AutoSize = true;
            this.articleLbl.Location = new System.Drawing.Point(167, 37);
            this.articleLbl.Name = "articleLbl";
            this.articleLbl.Size = new System.Drawing.Size(82, 37);
            this.articleLbl.TabIndex = 3;
            this.articleLbl.Text = "Артикул: ";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLbl.Location = new System.Drawing.Point(742, 11);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(111, 42);
            this.costLbl.TabIndex = 4;
            this.costLbl.Text = "Стоимость ";
            // 
            // materialLbl
            // 
            this.materialLbl.AutoSize = true;
            this.materialLbl.Location = new System.Drawing.Point(167, 71);
            this.materialLbl.MaximumSize = new System.Drawing.Size(500, 200);
            this.materialLbl.Name = "materialLbl";
            this.materialLbl.Size = new System.Drawing.Size(98, 37);
            this.materialLbl.TabIndex = 5;
            this.materialLbl.Text = "Материалы:";
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialLbl);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.articleLbl);
            this.Controls.Add(this.typeTitleLbl);
            this.Controls.Add(this.productImage);
            this.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(937, 158);
            this.Load += new System.EventHandler(this.ProductControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Label typeTitleLbl;
        private System.Windows.Forms.Label articleLbl;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label materialLbl;
    }
}
