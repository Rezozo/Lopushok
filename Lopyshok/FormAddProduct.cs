using Lopyshok.models;
using Lopyshok.provider;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lopyshok
{
    public partial class FormAddProduct : Form
    {
        private ProductProvider productProvider = new ProductProvider();
        public List<Material> materials = new List<Material>();
        public Product Product { get; set; }
        private string savedImageTitle = Application.StartupPath + "\\products\\picture.png";
        private FormProductList productForm;

        public FormAddProduct(FormProductList productForm)
        {
            InitializeComponent();
            this.productForm = productForm;
            List<string> typeList = productProvider.GetAllProductTypes();
            string[] typeArray = new string[typeList.Count];
            typeList.CopyTo(typeArray, 0);
            typeBox.Items.AddRange(typeArray);
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            if (Product != null)
            {
                materials = Product.Materials;

                try
                {
                    productImage.Image = new Bitmap(Application.StartupPath + Product.ImagePath);
                }
                catch { }
                titleTxt.Text = Product.Title;
                articleTxt.Text = Product.Article;
                countPeopleTxt.Text = Product.CountOfPeople.ToString();
                workShopTxt.Text = Product.WorkShopNumber.ToString();
                minCostTxt.Text =  ((int)Product.MinimumCost).ToString();
                descriptionTxt.Text = Product.Description;
                typeBox.Text = Product.ProductTypeName;

                UpdateMaterials();
                deleteProductBtn.Visible = true;
            }
            deleteProductBtn.BackColor = ColorTranslator.FromHtml("#00CC76");
            addProductBtn.BackColor = ColorTranslator.FromHtml("#00CC76");
            addMaterial.BackColor = ColorTranslator.FromHtml("#00CC76");
        }

        private void UpdateMaterials()
        {
            materialView.Rows.Clear();

            foreach(Material material in materials)
            {
                string title = material.Title;
                double count = material.CountInCurrentProduct;
                materialView.Rows.Add(title, count);
            }
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            productProvider.DeleteProduct(Product.Id);
            productForm.RefreshProducts();
            Hide();
        }

        private void productImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    savedImageTitle = fileName;

                    if (Product != null)
                    {
                        Product.ImagePath = "\\products\\" + fileName.Split('\\').Last();
                    }

                    productImage.Image = new Bitmap(fileName);
                }
            }
            catch
            {
                MessageBox.Show("Укажите файл из папки Resources");
            }
        }

        private void addMaterial_Click(object sender, EventArgs e)
        {
            FormAddMaterial formAddMaterial = new FormAddMaterial(this);
            formAddMaterial.ShowDialog();

            UpdateMaterials();
        }

        private void materialView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы хотите удалить этот материал?", "Удаление", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                materials.Remove(materials[e.RowIndex]);
                UpdateMaterials();
            }
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string title = titleTxt.Text;
                string article = articleTxt.Text;
                string count = countPeopleTxt.Text;
                string workShopNum = workShopTxt.Text;
                string minCost = minCostTxt.Text;
                string description = descriptionTxt.Text;
                string type = typeBox.Text;
                if (!validateProduct(title, article, count, workShopNum, minCost, type))
                {
                    return;
                }

                Product newProduct = new Product();
                newProduct.Title = title;
                newProduct.Article = article;
                newProduct.Description = description;
                newProduct.ProductTypeName = type;
                newProduct.WorkShopNumber = int.Parse(workShopNum);
                newProduct.CountOfPeople = int.Parse(count);
                newProduct.MinimumCost = decimal.Parse(minCost);
                newProduct.Materials = materials;
                savedImageTitle = "\\products\\" + savedImageTitle.Split('\\').Last();

                if (Product == null)
                {
                    newProduct.ImagePath = savedImageTitle;
                    productProvider.InsertProduct(newProduct);
                }
                else
                {
                    newProduct.Id = Product.Id;
                    newProduct.ImagePath = Product.ImagePath;
                    productProvider.UpdateProduct(newProduct);
                }

                MessageBox.Show("Данные успешно сохранены");
                productForm.RefreshProducts();
                Hide();
            } catch
            {
                MessageBox.Show("Проверьте данные перед сохранением");
            }
        }

        private bool validateProduct(string title, string article, string count, string workshop, string minCost, string type)
        {
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Укажите название продукта");
                return false;
            }

            if (string.IsNullOrEmpty(article) || productProvider.existsByArticle(article))
            {
                MessageBox.Show("Укажите артикул");
                return false;
            }

            if (!string.IsNullOrEmpty(minCost))
            {
                try
                {
                    decimal.Parse(minCost);
                }
                catch
                {
                    MessageBox.Show("Стоимость должна состоять только из цифр");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Укажите стоимость продукта");
                return false;
            }

            if (!string.IsNullOrEmpty(count))
            {
                try
                {
                    int.Parse(count);
                }
                catch
                {
                    MessageBox.Show("Количество человек должено состоять только из цифр");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Укажите количество человек");
                return false;
            }

            if (!string.IsNullOrEmpty(workshop))
            {
                try
                {
                    int.Parse(workshop);
                }
                catch
                {
                    MessageBox.Show("Номер цеха должено состоять только из цифр");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Укажите номер цеха");
                return false;
            }

            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Укажите тип продукта");
                return false;
            }

            return true;
        }
    }
}
