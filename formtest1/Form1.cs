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
            string selectedProduct = lbxProducts.SelectedItem as string;
            if (selectedProduct != null)
            {
                string imagePath = Path.Combine("C:\\Users\\Emre\\Source\\Repos\\YavuzEmre-B\\Form-project-CSharp\\formtest1\\Resources", selectedProduct + ".jpg");
                if (File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Resim bulunamad�: " + imagePath);
                    pictureBox1.Image = null;
                }
            }
            else
            {
                pictureBox1.Image = null;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();

            var productText = "Ara�lar";
            var addToCartText = "Sepete Ekle";
            var cartText = "Sepet";
            var removeFromCartText = "Sepetten ��kar";
            var removeAllFromCartText = "Sepeti Bo�alt";


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
                btnRemoveAllInCart.Enabled = true;
                btnRemoveFromCart.Enabled = true;
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
                MessageBox.Show("L�tfen bir ara� se�iniz.");
            }
            pictureBox1.Image = null;
        }

        private void lblCart_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                btnRemoveFromCart.Enabled = true;
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
                MessageBox.Show("L�tfen ��kart�lacak arac� se�iniz.");
            }
            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
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
            pictureBox1.Image = null;
        }


        private void lbxCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCart = lbxCart.SelectedItem as string;
            if (selectedCart != null)
            {
                string imagePath = Path.Combine("C:\\Users\\Emre\\Source\\Repos\\YavuzEmre-B\\Form-project-CSharp\\formtest1\\Resources", selectedCart + ".jpg");
                if (File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Resim bulunamad�: " + imagePath);
                    pictureBox1.Image = null;
                }
            }
            else
            {
                pictureBox1.Image = null;
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string selectedProduct = lbxProducts.SelectedItem.ToString(); // Se�ilen �r�n� al�n

            // Se�ilen �r�n�n ad�na uygun resim dosyas�n�n yolunu olu�turun
            string imagePath = Path.Combine("Resources", selectedProduct + ".jpg");

            if (File.Exists(imagePath))
            {
                // PictureBox kontrol�ne resmi y�kle
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            else
            {
                // Resim bulunamazsa bir hata mesaj� g�sterin veya varsay�lan bir resim g�sterin
                pictureBox1.Image = null; // Veya bir varsay�lan resim y�kleyin
            }
        }
    }
}