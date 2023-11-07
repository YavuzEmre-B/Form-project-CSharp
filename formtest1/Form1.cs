using formtest1.Properties;
using System.Reflection.Emit;
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
            timer1.Start();
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();

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

            if (lbxProducts.SelectedItem != null)
            {
                string key = lbxProducts.SelectedItem.ToString();
                btnRemoveFromCart.Enabled = true;
                btnRemoveAllInCart.Enabled = true;
                if (carPrices[key] < bakiye)
                {
                    if (carPrices.ContainsKey(key))
                    {
                        bakiye -= carPrices[key];
                        lblBakiye.Text = bakiye.ToString();
                    }
                    lbxCart.Items.Add(lbxProducts.SelectedItem);
                    lbxProducts.Items.Remove(lbxProducts.SelectedItem);

                }
                else if (carPrices[key] > bakiye)
                {
                    MessageBox.Show("Bakiyeniz yetersiz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir araç seçiniz.");
            }

        }

        private void lblCart_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                string key = lbxCart.SelectedItem.ToString();
                if (carPrices.ContainsKey(key))
                {
                    bakiye += carPrices[key];
                    lblBakiye.Text = bakiye.ToString();
                }
                lbxProducts.Items.Add(lbxCart.SelectedItem);
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }
            else
            {
                MessageBox.Show("Lütfen çýkartýlcak aracý seçiniz.");
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }
            if (lbxCart.Items.Count == 0)
            {
                btnRemoveAllInCart.Enabled = false;
            }
        }

        private void btnRemoveAllInCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.Items.Count != 0)
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
            if (lbxCart.Items.Count == 0)
            {
                btnRemoveAllInCart.Enabled = false;
            }
            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }
        }


        private void lbxCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bakiye_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}