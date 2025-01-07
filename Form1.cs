namespace ShopingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tb_Coffee_Price_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strCash = tb_cash.Text;

            string strCoffeePrice = tb_Coffee_Price.Text;
            string strCoffeeQuantity = tb_Coffee_Quantity.Text;

            string strGreenteaPrice = tb_Greentea_Price.Text;
            string strGreenteaQuantity = tb_Greentea_Quantity.Text;

            double dCoffeePrice = 0, dCoffeeQuantity = 0, dGreenteaPrice = 0, dGreenteaQuantity = 0, dCash = 0;

            try
            {
                dCash = double.Parse(strCash);
                if (chb_Coffee.Checked)
                {
                    dCoffeePrice = double.Parse(strCoffeePrice);
                    dCoffeeQuantity = double.Parse(strCoffeeQuantity);
                }
                if (chb_Greentea.Checked)
                {
                    dGreenteaPrice = double.Parse(strGreenteaPrice);
                    dGreenteaQuantity = double.Parse(strGreenteaQuantity);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("?????????????????????????????: " + ex.Message);
                return;
            }

            double dDiscountBev = 0;
            if (chb_beverage.Checked)
            {
                try
                {
                    dDiscountBev = double.Parse(tb_Beverage_Discount.Text);
                }
                catch
                {
                    MessageBox.Show("???????????????????????????");
                    return;
                }
            }

            double dCoffeeTotal = dCoffeePrice * dCoffeeQuantity;
            double dGreenteaTotal = dGreenteaPrice * dGreenteaQuantity;
            double dTotal = dCoffeeTotal + dGreenteaTotal;

            dTotal -= (dTotal * dDiscountBev / 100);

            if (dCash < dTotal)
            {
                MessageBox.Show("????????? ??????????????");
                return;
            }

            double dChange = dCash - dTotal;

            tb_total.Text = dTotal.ToString("F2"); 
            tb_change.Text = dChange.ToString("F2");

            int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
            int[] changeCount = new int[denominations.Length];
            int remainChange = (int)dChange;

            for (int i = 0; i < denominations.Length; i++)
            {
                changeCount[i] = remainChange / denominations[i];
                remainChange %= denominations[i];
            }

            tb_1000.Text = changeCount[0].ToString();
            tb_500.Text = changeCount[1].ToString();
            tb_100.Text = changeCount[2].ToString();
            tb_50.Text = changeCount[3].ToString();
            tb_20.Text = changeCount[4].ToString();
            tb_10.Text = changeCount[5].ToString();
            tb_5.Text = changeCount[6].ToString();
            tb_1.Text = changeCount[7].ToString();
        }

        private void chb_Coffee_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }
    }
}
