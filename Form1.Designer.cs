namespace ShopingCart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_Coffee_Price = new TextBox();
            button1 = new Button();
            chb_Coffee = new CheckBox();
            chb_Greentea = new CheckBox();
            tb_Greentea_Price = new TextBox();
            tb_Coffee_Quantity = new TextBox();
            tb_Greentea_Quantity = new TextBox();
            tb_total = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tb_10 = new TextBox();
            tb_20 = new TextBox();
            tb_50 = new TextBox();
            tb_500 = new TextBox();
            tb_1000 = new TextBox();
            tb_change = new TextBox();
            tb_5 = new TextBox();
            tb_1 = new TextBox();
            tb_cash = new TextBox();
            label1 = new Label();
            tb_100 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // tb_Coffee_Price
            // 
            tb_Coffee_Price.Location = new Point(130, 34);
            tb_Coffee_Price.Name = "tb_Coffee_Price";
            tb_Coffee_Price.Size = new Size(125, 27);
            tb_Coffee_Price.TabIndex = 0;
            tb_Coffee_Price.TextChanged += tb_Coffee_Price_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(346, 222);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chb_Coffee
            // 
            chb_Coffee.AutoSize = true;
            chb_Coffee.Location = new Point(12, 37);
            chb_Coffee.Name = "chb_Coffee";
            chb_Coffee.Size = new Size(75, 24);
            chb_Coffee.TabIndex = 2;
            chb_Coffee.Text = "Coffee";
            chb_Coffee.UseVisualStyleBackColor = true;
            chb_Coffee.CheckedChanged += chb_Coffee_CheckedChanged;
            // 
            // chb_Greentea
            // 
            chb_Greentea.AutoSize = true;
            chb_Greentea.Location = new Point(12, 84);
            chb_Greentea.Name = "chb_Greentea";
            chb_Greentea.Size = new Size(91, 24);
            chb_Greentea.TabIndex = 3;
            chb_Greentea.Text = "Greentea";
            chb_Greentea.UseVisualStyleBackColor = true;
            // 
            // tb_Greentea_Price
            // 
            tb_Greentea_Price.Location = new Point(130, 81);
            tb_Greentea_Price.Name = "tb_Greentea_Price";
            tb_Greentea_Price.Size = new Size(125, 27);
            tb_Greentea_Price.TabIndex = 4;
            // 
            // tb_Coffee_Quantity
            // 
            tb_Coffee_Quantity.Location = new Point(289, 34);
            tb_Coffee_Quantity.Name = "tb_Coffee_Quantity";
            tb_Coffee_Quantity.Size = new Size(125, 27);
            tb_Coffee_Quantity.TabIndex = 7;
            // 
            // tb_Greentea_Quantity
            // 
            tb_Greentea_Quantity.Location = new Point(289, 82);
            tb_Greentea_Quantity.Name = "tb_Greentea_Quantity";
            tb_Greentea_Quantity.Size = new Size(125, 27);
            tb_Greentea_Quantity.TabIndex = 8;
            // 
            // tb_total
            // 
            tb_total.Location = new Point(561, 32);
            tb_total.Name = "tb_total";
            tb_total.Size = new Size(125, 27);
            tb_total.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(513, 35);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 10;
            label2.Text = "Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 122);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 12;
            label3.Text = "Cash";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(496, 65);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 13;
            label4.Text = "Change";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(514, 105);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 14;
            label5.Text = "1000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(522, 141);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 15;
            label6.Text = "500";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(530, 207);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 16;
            label7.Text = "50";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(530, 240);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 17;
            label8.Text = "20";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(530, 273);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 18;
            label9.Text = "10";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(538, 306);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 19;
            label10.Text = "5";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(538, 339);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 20;
            label11.Text = "1";
            // 
            // tb_10
            // 
            tb_10.Location = new Point(561, 266);
            tb_10.Name = "tb_10";
            tb_10.Size = new Size(125, 27);
            tb_10.TabIndex = 21;
            // 
            // tb_20
            // 
            tb_20.Location = new Point(561, 233);
            tb_20.Name = "tb_20";
            tb_20.Size = new Size(125, 27);
            tb_20.TabIndex = 22;
            // 
            // tb_50
            // 
            tb_50.Location = new Point(561, 200);
            tb_50.Name = "tb_50";
            tb_50.Size = new Size(125, 27);
            tb_50.TabIndex = 23;
            // 
            // tb_500
            // 
            tb_500.Location = new Point(561, 134);
            tb_500.Name = "tb_500";
            tb_500.Size = new Size(125, 27);
            tb_500.TabIndex = 24;
            // 
            // tb_1000
            // 
            tb_1000.Location = new Point(561, 98);
            tb_1000.Name = "tb_1000";
            tb_1000.Size = new Size(125, 27);
            tb_1000.TabIndex = 25;
            // 
            // tb_change
            // 
            tb_change.Location = new Point(561, 65);
            tb_change.Name = "tb_change";
            tb_change.Size = new Size(125, 27);
            tb_change.TabIndex = 26;
            // 
            // tb_5
            // 
            tb_5.Location = new Point(561, 299);
            tb_5.Name = "tb_5";
            tb_5.Size = new Size(125, 27);
            tb_5.TabIndex = 27;
            // 
            // tb_1
            // 
            tb_1.Location = new Point(561, 332);
            tb_1.Name = "tb_1";
            tb_1.Size = new Size(125, 27);
            tb_1.TabIndex = 28;
            // 
            // tb_cash
            // 
            tb_cash.Location = new Point(202, 122);
            tb_cash.Name = "tb_cash";
            tb_cash.Size = new Size(125, 27);
            tb_cash.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(522, 174);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 30;
            label1.Text = "100";
            // 
            // tb_100
            // 
            tb_100.Location = new Point(561, 167);
            tb_100.Name = "tb_100";
            tb_100.Size = new Size(125, 27);
            tb_100.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(329, 9);
            label12.Name = "label12";
            label12.Size = new Size(49, 20);
            label12.TabIndex = 32;
            label12.Text = "จำนวน";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(169, 9);
            label13.Name = "label13";
            label13.Size = new Size(38, 20);
            label13.TabIndex = 33;
            label13.Text = "ราคา";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(tb_100);
            Controls.Add(label1);
            Controls.Add(tb_cash);
            Controls.Add(tb_1);
            Controls.Add(tb_5);
            Controls.Add(tb_change);
            Controls.Add(tb_1000);
            Controls.Add(tb_500);
            Controls.Add(tb_50);
            Controls.Add(tb_20);
            Controls.Add(tb_10);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_total);
            Controls.Add(tb_Greentea_Quantity);
            Controls.Add(tb_Coffee_Quantity);
            Controls.Add(tb_Greentea_Price);
            Controls.Add(chb_Greentea);
            Controls.Add(chb_Coffee);
            Controls.Add(button1);
            Controls.Add(tb_Coffee_Price);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Coffee_Price;
        private Button button1;
        private CheckBox chb_Coffee;
        private CheckBox chb_Greentea;
        private TextBox tb_Greentea_Price;
        private TextBox tb_Coffee_Quantity;
        private TextBox tb_Greentea_Quantity;
        private TextBox tb_total;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tb_10;
        private TextBox tb_20;
        private TextBox tb_50;
        private TextBox tb_500;
        private TextBox tb_1000;
        private TextBox tb_change;
        private TextBox tb_5;
        private TextBox tb_1;
        private TextBox tb_cash;
        private Label label1;
        private TextBox tb_100;
        private Label label12;
        private Label label13;
    }
}
