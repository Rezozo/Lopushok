using Lopyshok.models;
using Lopyshok.provider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lopyshok
{
    public partial class FormChangeCost : Form
    {
        private ProductProvider productProvider = new ProductProvider();
        public List<Product> selectedList { get; set; }
        private FormProductList formProductList;

        public FormChangeCost(FormProductList formProductList)
        {
            InitializeComponent();
            this.formProductList = formProductList;
        }

        private void FormChangeCost_Load(object sender, EventArgs e)
        {
            costTxt.Text = ((int) selectedList.Select(p => p.MinimumCost).Sum() / selectedList.Count).ToString();
            changeCostBtn.BackColor = ColorTranslator.FromHtml("#00CC76");
        }

        private void changeCostBtn_Click(object sender, EventArgs e)
        {
            decimal cost;
            try
            {
                cost = decimal.Parse(costTxt.Text);
            } catch
            {
                MessageBox.Show("Укажите верный формат стоимости");
                return;
            }

            foreach(Product p in selectedList)
            {
                productProvider.ChangeCost(p.Id, cost);
            }

            formProductList.HideChangeBtn();
            formProductList.RefreshProducts();
            Hide();
        }
    }
}
