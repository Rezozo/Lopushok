namespace Lopyshok
{
    partial class FormProductList
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductList));
            this.label1 = new System.Windows.Forms.Label();
            this.filterBox = new System.Windows.Forms.ComboBox();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelPagination = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.changeCostBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(805, 51);
            this.label1.TabIndex = 31;
            this.label1.Text = "Для совершения действий, нажмите правой кнопкой мыши по выбранному продукту";
            // 
            // filterBox
            // 
            this.filterBox.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterBox.FormattingEnabled = true;
            this.filterBox.Location = new System.Drawing.Point(670, 8);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(294, 41);
            this.filterBox.TabIndex = 30;
            this.filterBox.Text = "Фильтрация";
            this.filterBox.SelectedIndexChanged += new System.EventHandler(this.filterBox_SelectedIndexChanged);
            // 
            // sortBox
            // 
            this.sortBox.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortBox.FormattingEnabled = true;
            this.sortBox.ItemHeight = 33;
            this.sortBox.Items.AddRange(new object[] {
            "По умолчанию",
            "По наименованию (по возрастанию)",
            "По наименованию (по убыванию)",
            "По номеру производственного цеха (по возрастанию)",
            "По номеру производственного цеха (по убыванию)",
            "По стоимости (по возрастанию)",
            "По стоимости (по убыванию)"});
            this.sortBox.Location = new System.Drawing.Point(351, 8);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(294, 41);
            this.sortBox.TabIndex = 29;
            this.sortBox.Text = "Сортировка";
            this.sortBox.SelectedIndexChanged += new System.EventHandler(this.sortBox_SelectedIndexChanged);
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTxt.Location = new System.Drawing.Point(14, 8);
            this.searchTxt.MaxLength = 200;
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(314, 38);
            this.searchTxt.TabIndex = 28;
            this.searchTxt.Enter += new System.EventHandler(this.searchTxt_Enter);
            this.searchTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTxt_KeyPress);
            this.searchTxt.Leave += new System.EventHandler(this.searchTxt_Leave);
            // 
            // flowLayoutPanelPagination
            // 
            this.flowLayoutPanelPagination.Location = new System.Drawing.Point(670, 701);
            this.flowLayoutPanelPagination.Name = "flowLayoutPanelPagination";
            this.flowLayoutPanelPagination.Size = new System.Drawing.Size(343, 41);
            this.flowLayoutPanelPagination.TabIndex = 27;
            // 
            // flowLayoutPanelProducts
            // 
            this.flowLayoutPanelProducts.AutoScroll = true;
            this.flowLayoutPanelProducts.Location = new System.Drawing.Point(14, 115);
            this.flowLayoutPanelProducts.MaximumSize = new System.Drawing.Size(1003, 580);
            this.flowLayoutPanelProducts.MinimumSize = new System.Drawing.Size(1003, 580);
            this.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            this.flowLayoutPanelProducts.Size = new System.Drawing.Size(1003, 580);
            this.flowLayoutPanelProducts.TabIndex = 26;
            // 
            // addProductBtn
            // 
            this.addProductBtn.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProductBtn.Location = new System.Drawing.Point(14, 701);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(247, 53);
            this.addProductBtn.TabIndex = 0;
            this.addProductBtn.Text = "Добавить продукт";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // changeCostBtn
            // 
            this.changeCostBtn.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeCostBtn.Location = new System.Drawing.Point(267, 701);
            this.changeCostBtn.Name = "changeCostBtn";
            this.changeCostBtn.Size = new System.Drawing.Size(247, 53);
            this.changeCostBtn.TabIndex = 32;
            this.changeCostBtn.Text = "Изменить стоимость на ...";
            this.changeCostBtn.UseVisualStyleBackColor = true;
            this.changeCostBtn.Visible = false;
            this.changeCostBtn.Click += new System.EventHandler(this.changeCostBtn_Click);
            // 
            // FormProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 772);
            this.Controls.Add(this.changeCostBtn);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.flowLayoutPanelPagination);
            this.Controls.Add(this.flowLayoutPanelProducts);
            this.Font = new System.Drawing.Font("Gabriola", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximumSize = new System.Drawing.Size(1045, 819);
            this.MinimumSize = new System.Drawing.Size(1045, 819);
            this.Name = "FormProductList";
            this.Text = "Все продукты";
            this.Load += new System.EventHandler(this.FormProductList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filterBox;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPagination;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProducts;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button changeCostBtn;
    }
}

