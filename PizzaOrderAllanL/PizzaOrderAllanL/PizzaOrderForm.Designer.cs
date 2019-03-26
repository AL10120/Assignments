namespace PizzaOrderAllanL
{
    partial class frmPizzaOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudPizzaSize = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPizzaSize = new System.Windows.Forms.Label();
            this.nudPizzaToppings = new System.Windows.Forms.NumericUpDown();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblNumberOfToppings = new System.Windows.Forms.Label();
            this.lblToppings4 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblToppings1 = new System.Windows.Forms.Label();
            this.lblHST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblLarge = new System.Windows.Forms.Label();
            this.lblExLarge = new System.Windows.Forms.Label();
            this.lblToppings2 = new System.Windows.Forms.Label();
            this.lblToppings3 = new System.Windows.Forms.Label();
            this.btnOrderAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaToppings)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPizzaSize
            // 
            this.nudPizzaSize.Location = new System.Drawing.Point(546, 67);
            this.nudPizzaSize.Name = "nudPizzaSize";
            this.nudPizzaSize.Size = new System.Drawing.Size(47, 20);
            this.nudPizzaSize.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(471, 313);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(122, 63);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblPizzaSize
            // 
            this.lblPizzaSize.AutoSize = true;
            this.lblPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaSize.Location = new System.Drawing.Point(107, 64);
            this.lblPizzaSize.Name = "lblPizzaSize";
            this.lblPizzaSize.Size = new System.Drawing.Size(373, 20);
            this.lblPizzaSize.TabIndex = 2;
            this.lblPizzaSize.Text = "Please select the size of pizza you would like:";
            // 
            // nudPizzaToppings
            // 
            this.nudPizzaToppings.Location = new System.Drawing.Point(547, 211);
            this.nudPizzaToppings.Name = "nudPizzaToppings";
            this.nudPizzaToppings.Size = new System.Drawing.Size(46, 20);
            this.nudPizzaToppings.TabIndex = 3;
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedium.Location = new System.Drawing.Point(107, 95);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(149, 20);
            this.lblMedium.TabIndex = 4;
            this.lblMedium.Text = "Medium Pizza = 1";
            // 
            // lblNumberOfToppings
            // 
            this.lblNumberOfToppings.AutoSize = true;
            this.lblNumberOfToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfToppings.Location = new System.Drawing.Point(107, 208);
            this.lblNumberOfToppings.Name = "lblNumberOfToppings";
            this.lblNumberOfToppings.Size = new System.Drawing.Size(419, 20);
            this.lblNumberOfToppings.TabIndex = 5;
            this.lblNumberOfToppings.Text = "Please select the number of topping you would like:";
            // 
            // lblToppings4
            // 
            this.lblToppings4.AutoSize = true;
            this.lblToppings4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings4.Location = new System.Drawing.Point(107, 313);
            this.lblToppings4.Name = "lblToppings4";
            this.lblToppings4.Size = new System.Drawing.Size(127, 20);
            this.lblToppings4.TabIndex = 6;
            this.lblToppings4.Text = "4 Toppings = 4";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(107, 390);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(0, 20);
            this.lblSubtotal.TabIndex = 7;
            // 
            // lblToppings1
            // 
            this.lblToppings1.AutoSize = true;
            this.lblToppings1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings1.Location = new System.Drawing.Point(107, 252);
            this.lblToppings1.Name = "lblToppings1";
            this.lblToppings1.Size = new System.Drawing.Size(118, 20);
            this.lblToppings1.TabIndex = 8;
            this.lblToppings1.Text = "1 Topping = 1";
            // 
            // lblHST
            // 
            this.lblHST.AutoSize = true;
            this.lblHST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHST.Location = new System.Drawing.Point(107, 430);
            this.lblHST.Name = "lblHST";
            this.lblHST.Size = new System.Drawing.Size(0, 20);
            this.lblHST.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(107, 467);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 10;
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLarge.Location = new System.Drawing.Point(107, 125);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(133, 20);
            this.lblLarge.TabIndex = 11;
            this.lblLarge.Text = "Large Pizza = 2";
            // 
            // lblExLarge
            // 
            this.lblExLarge.AutoSize = true;
            this.lblExLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExLarge.Location = new System.Drawing.Point(107, 153);
            this.lblExLarge.Name = "lblExLarge";
            this.lblExLarge.Size = new System.Drawing.Size(180, 20);
            this.lblExLarge.TabIndex = 12;
            this.lblExLarge.Text = "Extra Large Pizza = 3";
            // 
            // lblToppings2
            // 
            this.lblToppings2.AutoSize = true;
            this.lblToppings2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings2.Location = new System.Drawing.Point(107, 273);
            this.lblToppings2.Name = "lblToppings2";
            this.lblToppings2.Size = new System.Drawing.Size(127, 20);
            this.lblToppings2.TabIndex = 13;
            this.lblToppings2.Text = "2 Toppings = 2";
            // 
            // lblToppings3
            // 
            this.lblToppings3.AutoSize = true;
            this.lblToppings3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings3.Location = new System.Drawing.Point(107, 293);
            this.lblToppings3.Name = "lblToppings3";
            this.lblToppings3.Size = new System.Drawing.Size(127, 20);
            this.lblToppings3.TabIndex = 14;
            this.lblToppings3.Text = "3 Toppings = 3";
            // 
            // btnOrderAgain
            // 
            this.btnOrderAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderAgain.Location = new System.Drawing.Point(471, 409);
            this.btnOrderAgain.Name = "btnOrderAgain";
            this.btnOrderAgain.Size = new System.Drawing.Size(122, 63);
            this.btnOrderAgain.TabIndex = 15;
            this.btnOrderAgain.Text = "Order Again";
            this.btnOrderAgain.UseVisualStyleBackColor = true;
            this.btnOrderAgain.Click += new System.EventHandler(this.btnOrderAgain_Click);
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 538);
            this.Controls.Add(this.btnOrderAgain);
            this.Controls.Add(this.lblToppings3);
            this.Controls.Add(this.lblToppings2);
            this.Controls.Add(this.lblExLarge);
            this.Controls.Add(this.lblLarge);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblHST);
            this.Controls.Add(this.lblToppings1);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblToppings4);
            this.Controls.Add(this.lblNumberOfToppings);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.nudPizzaToppings);
            this.Controls.Add(this.lblPizzaSize);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudPizzaSize);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order by Allan L";
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaToppings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudPizzaSize;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPizzaSize;
        private System.Windows.Forms.NumericUpDown nudPizzaToppings;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblNumberOfToppings;
        private System.Windows.Forms.Label lblToppings4;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblToppings1;
        private System.Windows.Forms.Label lblHST;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblLarge;
        private System.Windows.Forms.Label lblExLarge;
        private System.Windows.Forms.Label lblToppings2;
        private System.Windows.Forms.Label lblToppings3;
        private System.Windows.Forms.Button btnOrderAgain;
    }
}

