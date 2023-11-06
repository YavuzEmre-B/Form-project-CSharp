using System.Windows.Forms;

namespace formtest1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> carPrices;
        private int bakiye = 100000;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {

        }

        private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var productText = "Araçlar";
            var addToCartText = "Sepete Ekle";
            var cartText = "Sepet";
            var removeFromCartText = "Sepetten Çýkar";
            var removeAllFromCartText = "Sepeti Boþalt";


            lblProducts.Text = productText;
            btnAddToCart.Text = addToCartText;
            lblCart.Text = cartText;
            btnRemoveFromCart.Text = removeFromCartText;
            btnRemoveAllInCart.Text = removeAllFromCartText;
            lblBakiye.Text = bakiye.ToString();



            string[] products = new string[] { "BMW", "Mercedes", "Audi", "Volkswagen", "Fiat", "Renault", "Peugeot", "Opel", "Ford", "Toyota" };

            carPrices = new Dictionary<string, int>();

            carPrices["BMW"] = 50000;
            carPrices["Mercedes"] = 60000;
            carPrices["Audi"] = 55000;
            carPrices["Volkswagen"] = 30000;
            carPrices["Fiat"] = 20000;
            carPrices["Renault"] = 25000;
            carPrices["Peugeot"] = 28000;
            carPrices["Opel"] = 27000;
            carPrices["Ford"] = 32000;
            carPrices["Toyota"] = 35000;

            foreach (var product in products)
            {
                lbxProducts.Items.Add(product);
            }
            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
                btnRemoveAllInCart.Enabled = false;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            string key = lbxProducts.SelectedItem.ToString();
            if (lbxProducts.SelectedItem != null && carPrices[key] < bakiye)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                btnRemoveFromCart.Enabled = true;
                btnRemoveAllInCart.Enabled = true;
                if (carPrices.ContainsKey(key))
                {
                    bakiye -= carPrices[key];
                    lblBakiye.Text = bakiye.ToString();
                }
            }
            else if (carPrices[key] > bakiye)
            {
                MessageBox.Show("Bakiyeniz yetersiz.");
            }
            else
            {
                MessageBox.Show("Lütfen bir araç seçiniz.");
            }
            lbxProducts.Items.Remove(lbxProducts.SelectedItem);
        }

        private void lblCart_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            string key = lbxCart.SelectedItem.ToString();
            if (carPrices.ContainsKey(key))
            {
                bakiye += carPrices[key];
                lblBakiye.Text = bakiye.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen çýkarýlacak aracý seçiniz.");
            }
            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }
            if (lbxCart.Items.Count != 0)
            {
                lbxProducts.Items.Add(lbxCart.SelectedItem);
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }
        }

        private void btnRemoveAllInCart_Click(object sender, EventArgs e)
        {
            if(lbxCart.Items.Count != 0)
            {
                foreach (var item in lbxCart.Items)
                {
                    string key = item.ToString();
                    if (carPrices.ContainsKey(key))
                    {
                        bakiye += carPrices[key];
                        lblBakiye.Text = bakiye.ToString();
                    }
                }
            }
            if (lbxCart.Items.Count == 0)
            {
                btnRemoveAllInCart.Enabled = false;
            }
            if (lbxCart.Items.Count != 0)
            {
                lbxProducts.Items.AddRange(lbxCart.Items);
                lbxCart.Items.Clear();
            }
        }

        private void lbxCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bakiye_Click(object sender, EventArgs e)
        {

        }
    }
}