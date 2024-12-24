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
            string strCoffeePrice = tb_Coffee_Price.Text;
            string strCoffeeQuantity = tb_Coffee_Quantity.Text;

            string strGreenteaPrice = tb_Greentea_Price.Text;
            string strGreenteaQuantity = tb_Greentea_Quantity.Text;

            int iCoffeePrice = 0, iCoffeeQuantity = 0, iGreenteaPrice = 0, iGreenteaQuantity = 0;

            try
            {
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
            }


            int iCoffeeToal = iCoffeePrice * iCoffeeQuantity;
            int iGreenteaTotal = iGreenteaPrice * iGreenteaQuantity;
            int iTotal = iCoffeeToal + iGreenteaTotal;

            tb_total.Text = iTotal.ToString();

        }

        private void chb_Coffee_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
