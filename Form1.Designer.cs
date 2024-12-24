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
            label1 = new Label();
            tb_Coffee_Quantity = new TextBox();
            tb_Greentea_Quantity = new TextBox();
            tb_total = new TextBox();
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
            button1.Location = new Point(324, 133);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 138);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 6;
            label1.Text = "Total";
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
            tb_total.Location = new Point(193, 135);
            tb_total.Name = "tb_total";
            tb_total.Size = new Size(125, 27);
            tb_total.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_total);
            Controls.Add(tb_Greentea_Quantity);
            Controls.Add(tb_Coffee_Quantity);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox tb_Coffee_Quantity;
        private TextBox tb_Greentea_Quantity;
        private TextBox tb_total;
    }
}
