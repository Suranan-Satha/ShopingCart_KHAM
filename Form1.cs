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
            double dCash = 0, dCoffeePrice = 0, dCoffeeQuantity = 0, dGreenteaPrice = 0, dGreenteaQuantity = 0;
            double dNoodlePrice = 0, dNoodleQuantity = 0, dPizzaPrice = 0, dPizzaQuantity = 0;

            try
            {
                dCash = double.Parse(tb_cash.Text);
                if (chb_Coffee.Checked)
                {
                    dCoffeePrice = double.Parse(tb_Coffee_Price.Text);
                    dCoffeeQuantity = double.Parse(tb_Coffee_Quantity.Text);
                }
                if (chb_Greentea.Checked)
                {
                    dGreenteaPrice = double.Parse(tb_Greentea_Price.Text);
                    dGreenteaQuantity = double.Parse(tb_Greentea_Quantity.Text);
                }
                if (chb_noodle.Checked)
                {
                    dNoodlePrice = double.Parse(tb_Noodle_Price.Text);
                    dNoodleQuantity = double.Parse(tb_Noodle_Quantity.Text);
                }
                if (chb_pizza.Checked)
                {
                    dPizzaPrice = double.Parse(tb_Pizza_Price.Text);
                    dPizzaQuantity = double.Parse(tb_Pizza_Quantity.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("กรุณากรอกข้อมูลตัวเลขให้ถูกต้อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double dBeverageTotal = (dCoffeePrice * dCoffeeQuantity) + (dGreenteaPrice * dGreenteaQuantity);
            double dFoodTotal = (dNoodlePrice * dNoodleQuantity) + (dPizzaPrice * dPizzaQuantity);
            double dGrandTotal = dBeverageTotal + dFoodTotal;

            
            double dDiscountBev = chb_beverage.Checked ? double.Parse(tb_Beverage_Discount.Text) : 0;
            double dDiscountFood = chb_food.Checked ? double.Parse(tb_Food_Discount.Text) : 0;
            double dDiscountAll = chb_all.Checked ? double.Parse(tb_total_Discount.Text) : 0;

            double dTotalDiscount = (dBeverageTotal * dDiscountBev / 100) +(dFoodTotal * dDiscountFood / 100) +(dGrandTotal * dDiscountAll / 100);

            
            dGrandTotal -= dTotalDiscount;

            
            if (dCash < dGrandTotal)
            {
                MessageBox.Show("เงินสดไม่เพียงพอ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            double dChange = dCash - dGrandTotal;

            
            tb_total.Text = dGrandTotal.ToString("F2");
            tb_change.Text = dChange.ToString("F2");
            

            
            double[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1, 0.50, 0.25 };
            int[] changeCount = new int[denominations.Length];
            double remainChange = dChange;

            for (int i = 0; i < denominations.Length; i++)
            {
                changeCount[i] = (int)(remainChange / denominations[i]);
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
            tb_050.Text = changeCount[8].ToString();
            tb_025.Text = changeCount[9].ToString();
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
