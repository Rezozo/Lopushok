using Lopyshok.models;
using Lopyshok.provider;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lopyshok
{
    public partial class ProductControl : UserControl
    {
        private ProductProvider productProvider = new ProductProvider();
        private FormProductList productListForm;
        public Product Product { get; set; }


        public ProductControl(FormProductList form)
        {
            InitializeComponent();
            productListForm = form;
            this.BackColor = ColorTranslator.FromHtml("#CEFFF9");
        }

        private void ProductControl_Load(object sender, EventArgs e)
        {
            string imagePath;
            if (string.IsNullOrEmpty(Product.ImagePath))
            {
                imagePath = Directory.GetCurrentDirectory() + "\\products\\picture.png";
            }
            else
            {
                imagePath = Directory.GetCurrentDirectory() + Product.ImagePath;
            }
            productImage.Image = new Bitmap(imagePath);
            articleLbl.Text += Product.Article;
            typeTitleLbl.Text = Product.ProductTypeName + " | " + Product.Title;
            costLbl.Text += Product.MinimumCost.ToString();

            foreach (Material material in Product.Materials)
            {
                materialLbl.Text += ", " + material.Title;
            }

            ContextMenuStrip contextMenu = new ContextMenuStrip();

            ToolStripMenuItem editItem = new ToolStripMenuItem("Редактировать товар");
            ToolStripMenuItem selectItem = new ToolStripMenuItem("Выбрать товар");

            editItem.Click += EditItem_Click;
            selectItem.Click += SelectItem_Click;

            contextMenu.Items.Add(selectItem);
            contextMenu.Items.Add(editItem);
            ContextMenuStrip = contextMenu;
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            FormAddProduct formAddProduct = new FormAddProduct(productListForm);
            formAddProduct.Product = Product;
            formAddProduct.ShowDialog();
        }

        private void SelectItem_Click(object sender, EventArgs e)
        {
            productListForm.selectedProducts.Add(Product);
            productListForm.ShowChangeBtn();
        }
    }
}
