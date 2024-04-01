using Lopyshok.models;
using Lopyshok.provider;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lopyshok
{
    public partial class FormProductList : Form
    {
        private ProductProvider productProvider;
        public List<Product> productList = new List<Product>();
        public List<Product> selectedProducts = new List<Product>();
        private List<string> typeList = new List<string>();
        private const int itemsPerPage = 20;
        private int currentPage = 1;
        private int offset;
        private int limit;
        private int totalPages;
        public FormProductList()
        {
            InitializeComponent();
        }

        private void FormProductList_Load(object sender, System.EventArgs e)
        {
            productProvider = new ProductProvider();
            productList = productProvider.getAllProducts();
            typeList = productProvider.GetAllProductTypes();
            string[] typeArray = new string[typeList.Count];
            typeList.CopyTo(typeArray, 0);
            filterBox.Items.Add("Все типы");
            filterBox.Items.AddRange(typeArray);

            addProductBtn.BackColor = ColorTranslator.FromHtml("#00CC76");
            changeCostBtn.BackColor = ColorTranslator.FromHtml("#00CC76");

            DisplayPage(currentPage, null, null, null);
        }

        public void RefreshProducts()
        {
            productList = productProvider.getAllProducts();
            DisplayPage(1, null, null, null);
        }

        private void DisplayPage(int page, string text, string sorter, string filter)
        {
            flowLayoutPanelProducts.Controls.Clear();
            flowLayoutPanelPagination.Controls.Clear();

            offset = (page - 1) * itemsPerPage;
            limit = itemsPerPage;

            var filteredProducts = productList;

            if (!string.IsNullOrEmpty(text) && text != "Введите для поиска")
            {
                filteredProducts = filteredProducts
                    .Where(p => p.Title.Contains(text))
                    .ToList();
            }

            if (!string.IsNullOrEmpty(sorter) && sorter != "Сортировка")
            {
                switch (sorter)
                {
                    case "По наименованию (по возрастанию)":
                        filteredProducts = filteredProducts.OrderBy(p => p.Title).ToList();
                        break;
                    case "По наименованию (по убыванию)":
                        filteredProducts = filteredProducts.OrderByDescending(p => p.Title).ToList();
                        break;
                    case "По номеру производственного цеха (по возрастанию)":
                        filteredProducts = filteredProducts.OrderBy(p => p.WorkShopNumber).ToList();
                        break;
                    case "По номеру производственного цеха (по убыванию)":
                        filteredProducts = filteredProducts.OrderByDescending(p => p.WorkShopNumber).ToList();
                        break;
                    case "По стоимости (по возрастанию)":
                        filteredProducts = filteredProducts.OrderBy(p => p.MinimumCost).ToList();
                        break;
                    case "По стоимости (по убыванию)":
                        filteredProducts = filteredProducts.OrderByDescending(p => p.MinimumCost).ToList();
                        break;
                    default:
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter) && filter != "Фильтрация" && filter != "Все типы")
            {
                filteredProducts = filteredProducts
                    .Where(p => p.ProductTypeName.Equals(filter))
                    .ToList();
            }

            int resultCount = filteredProducts.Count;
            filteredProducts = filteredProducts.Skip(offset).Take(limit).ToList();

            DisplayProduct(filteredProducts);
            DisplayPagination(resultCount);
        }

        private void DisplayProduct(List<Product> product)
        {
            ProductControl[] productControls = new ProductControl[product.Count];

            for (int i = 0; i < product.Count; i++)
            {
                ProductControl productControl = new ProductControl(this);
                productControl.Product = product[i];
                productControls[i] = productControl;
                if (!productProvider.isSoldLastMonth(product[i].Id))
                {
                    productControl.BackColor = ColorTranslator.FromHtml("#FFCCCC");
                }
            }

            flowLayoutPanelProducts.Controls.AddRange(productControls);
        }

        private void DisplayPagination(int count)
        {
            totalPages = (int)Math.Ceiling((double)count / itemsPerPage);

            flowLayoutPanelPagination.RightToLeft = RightToLeft.Yes;

            AddPageButton("<", currentPage + 1);

            for (int i = totalPages; i != 0; i--)
            {
                Label pageButton = new Label
                {
                    Text = i.ToString(),
                    Width = 20,
                    Height = 20,
                    Margin = new Padding(5),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Cursor = Cursors.Hand
                };

                if (i == currentPage)
                {
                    pageButton.Font = new System.Drawing.Font(pageButton.Font, FontStyle.Bold | FontStyle.Underline);
                }

                pageButton.Click += (sender, e) =>
                {
                    currentPage = int.Parse(((Label)sender).Text);
                    DisplayPage(currentPage, searchTxt.Text, sortBox.Text, filterBox.Text);
                };

                flowLayoutPanelPagination.Controls.Add(pageButton);
            }

            AddPageButton(">", currentPage - 1);
        }

        private void AddPageButton(string buttonText, int targetPage)
        {
            Label pageButton = new Label
            {
                Text = buttonText,
                Width = 15,
                Height = 15,
                Margin = new Padding(5),
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand
            };

            pageButton.Click += (sender, e) =>
            {
                if (targetPage > 0 && targetPage <= totalPages)
                {
                    currentPage = targetPage;
                    DisplayPage(currentPage, searchTxt.Text, sortBox.Text, filterBox.Text);
                }
            };

            flowLayoutPanelPagination.Controls.Add(pageButton);
        }

        private void searchTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTxt.Text))
            {
                searchTxt.Text = "Введите для поиска";
                searchTxt.ForeColor = Color.Gray;
            }
        }

        private void searchTxt_Enter(object sender, EventArgs e)
        {
            if (searchTxt.Text.Equals("Введите для поиска"))
            {
                searchTxt.Clear();
                searchTxt.ForeColor = Color.Black;
            }
        }

        private void searchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            currentPage = 1;
            DisplayPage(currentPage, searchTxt.Text, sortBox.Text, filterBox.Text);
        }

        private void sortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            DisplayPage(currentPage, searchTxt.Text, sortBox.Text, filterBox.Text);
        }

        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            DisplayPage(currentPage, searchTxt.Text, sortBox.Text, filterBox.Text);
        }

        private void changeCostBtn_Click(object sender, EventArgs e)
        {
            FormChangeCost form = new FormChangeCost(this);
            form.selectedList = selectedProducts;
            form.ShowDialog();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            FormAddProduct formAddProduct = new FormAddProduct(this);
            formAddProduct.ShowDialog();
        }

        public void ShowChangeBtn()
        {
            changeCostBtn.Visible = true;
        }

        public void HideChangeBtn()
        {
            selectedProducts.Clear();
            changeCostBtn.Visible = false;
        }
    }
}
