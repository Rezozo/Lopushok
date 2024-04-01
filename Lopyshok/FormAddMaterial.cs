using Lopyshok.models;
using Lopyshok.provider;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lopyshok
{
    public partial class FormAddMaterial : Form
    {
        private FormAddProduct formAddProduct;
        private MaterialProvider materialProvider = new MaterialProvider();

        public FormAddMaterial(FormAddProduct formAddProduct)
        {
            InitializeComponent();
            this.formAddProduct = formAddProduct;
            changeCostBtn.BackColor = ColorTranslator.FromHtml("#00CC76");
            List<string> typeList = materialProvider.GetAllMaterialsTitles();
            string[] typeArray = new string[typeList.Count];
            typeList.CopyTo(typeArray, 0);
            typeBox.Items.AddRange(typeArray);
        }

        private void changeCostBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(countTxt.Text) && !string.IsNullOrEmpty(typeBox.Text))
            {
                try
                {
                    Material material = materialProvider.GetByTitle(typeBox.Text);
                    material.CountInCurrentProduct = double.Parse(countTxt.Text);
                    formAddProduct.materials.Add(material);
                    Hide();
                } catch
                {
                    MessageBox.Show("Неправильный формат количества");
                    return;
                }
            }
        }
    }
}
