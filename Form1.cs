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

            int iCoffeePrice = 0, iCoffeeQuantity = 0, iGreenteaPrice = 0, iGreenteaQuantity = 0, iCash = 0;

            try
            {
                iCash = int.Parse(strCash);
                if (chb_Coffee.Checked)
                {
                    iCoffeePrice = int.Parse(strCoffeePrice);
                    iCoffeeQuantity = int.Parse(strCoffeeQuantity);
                }
                if (chb_Greentea.Checked)
                {
                    iGreenteaPrice = int.Parse(strGreenteaPrice);
                    iGreenteaQuantity = int.Parse(strGreenteaQuantity);
                }
            }

            catch (Exception ex)
            {
                iCoffeePrice = 0;
                iCoffeeQuantity = 0;
                iGreenteaPrice = 0;
                iGreenteaQuantity = 0;
                iCash = 0;
            }

            int iCoffeeTotal = iCoffeePrice * iCoffeeQuantity;
            int iGreenteaTotal = iGreenteaPrice * iGreenteaQuantity;
            int iTotal = iCoffeeTotal + iGreenteaTotal;
            int iChange = iCash - iTotal;

            tb_total.Text = iTotal.ToString();
            tb_change.Text = iChange.ToString();

            
            int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 }; 
            int[] changeCount = new int[denominations.Length];
            int remainChange = iChange;

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
    }
}
