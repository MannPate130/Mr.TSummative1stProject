
namespace Mr.TSummative1stProject
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.Burgertitle = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.burgerAmountlabel = new System.Windows.Forms.Label();
            this.friesAmountLabel = new System.Windows.Forms.Label();
            this.drinkAmountLabel = new System.Windows.Forms.Label();
            this.burgerAmounttextBox = new System.Windows.Forms.TextBox();
            this.friesAmounttextBox = new System.Windows.Forms.TextBox();
            this.drinkAmounttextBox = new System.Windows.Forms.TextBox();
            this.totalCalulator = new System.Windows.Forms.Button();
            this.newOrderbutton = new System.Windows.Forms.Button();
            this.totalAmountlabel = new System.Windows.Forms.Label();
            this.spacerLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedAmounttextLabel = new System.Windows.Forms.TextBox();
            this.calculateChangebutton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.printReceiptbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Burgertitle
            // 
            this.Burgertitle.BackColor = System.Drawing.Color.Gold;
            this.Burgertitle.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Burgertitle.Location = new System.Drawing.Point(1, -1);
            this.Burgertitle.Name = "Burgertitle";
            this.Burgertitle.Size = new System.Drawing.Size(1088, 65);
            this.Burgertitle.TabIndex = 0;
            this.Burgertitle.Text = "Best Burger in Town";
            this.Burgertitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.Silver;
            this.receiptLabel.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(681, 129);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(359, 440);
            this.receiptLabel.TabIndex = 1;
            // 
            // burgerAmountlabel
            // 
            this.burgerAmountlabel.AutoSize = true;
            this.burgerAmountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerAmountlabel.Location = new System.Drawing.Point(86, 113);
            this.burgerAmountlabel.Name = "burgerAmountlabel";
            this.burgerAmountlabel.Size = new System.Drawing.Size(217, 29);
            this.burgerAmountlabel.TabIndex = 2;
            this.burgerAmountlabel.Text = "Number of Burgers";
            // 
            // friesAmountLabel
            // 
            this.friesAmountLabel.AutoSize = true;
            this.friesAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesAmountLabel.Location = new System.Drawing.Point(86, 169);
            this.friesAmountLabel.Name = "friesAmountLabel";
            this.friesAmountLabel.Size = new System.Drawing.Size(187, 29);
            this.friesAmountLabel.TabIndex = 3;
            this.friesAmountLabel.Text = "Number of Fries";
            // 
            // drinkAmountLabel
            // 
            this.drinkAmountLabel.AutoSize = true;
            this.drinkAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkAmountLabel.Location = new System.Drawing.Point(86, 222);
            this.drinkAmountLabel.Name = "drinkAmountLabel";
            this.drinkAmountLabel.Size = new System.Drawing.Size(200, 29);
            this.drinkAmountLabel.TabIndex = 4;
            this.drinkAmountLabel.Text = "Number of Drinks";
            // 
            // burgerAmounttextBox
            // 
            this.burgerAmounttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerAmounttextBox.Location = new System.Drawing.Point(418, 112);
            this.burgerAmounttextBox.Name = "burgerAmounttextBox";
            this.burgerAmounttextBox.Size = new System.Drawing.Size(96, 30);
            this.burgerAmounttextBox.TabIndex = 5;
            // 
            // friesAmounttextBox
            // 
            this.friesAmounttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesAmounttextBox.Location = new System.Drawing.Point(418, 169);
            this.friesAmounttextBox.Name = "friesAmounttextBox";
            this.friesAmounttextBox.Size = new System.Drawing.Size(96, 30);
            this.friesAmounttextBox.TabIndex = 6;
            // 
            // drinkAmounttextBox
            // 
            this.drinkAmounttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkAmounttextBox.Location = new System.Drawing.Point(418, 221);
            this.drinkAmounttextBox.Name = "drinkAmounttextBox";
            this.drinkAmounttextBox.Size = new System.Drawing.Size(96, 30);
            this.drinkAmounttextBox.TabIndex = 7;
            // 
            // totalCalulator
            // 
            this.totalCalulator.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.totalCalulator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.totalCalulator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalCalulator.Font = new System.Drawing.Font("Javanese Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCalulator.Location = new System.Drawing.Point(243, 268);
            this.totalCalulator.Name = "totalCalulator";
            this.totalCalulator.Size = new System.Drawing.Size(175, 47);
            this.totalCalulator.TabIndex = 8;
            this.totalCalulator.Text = "Calculate Total";
            this.totalCalulator.UseVisualStyleBackColor = true;
            this.totalCalulator.Click += new System.EventHandler(this.totalCalulator_Click);
            // 
            // newOrderbutton
            // 
            this.newOrderbutton.BackColor = System.Drawing.Color.White;
            this.newOrderbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.newOrderbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderbutton.Font = new System.Drawing.Font("Javanese Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderbutton.Location = new System.Drawing.Point(783, 574);
            this.newOrderbutton.Name = "newOrderbutton";
            this.newOrderbutton.Size = new System.Drawing.Size(176, 47);
            this.newOrderbutton.TabIndex = 9;
            this.newOrderbutton.Text = "New Order";
            this.newOrderbutton.UseVisualStyleBackColor = false;
            this.newOrderbutton.Click += new System.EventHandler(this.newOrderbutton_Click);
            // 
            // totalAmountlabel
            // 
            this.totalAmountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountlabel.Location = new System.Drawing.Point(192, 318);
            this.totalAmountlabel.Name = "totalAmountlabel";
            this.totalAmountlabel.Size = new System.Drawing.Size(274, 177);
            this.totalAmountlabel.TabIndex = 10;
            // 
            // spacerLabel
            // 
            this.spacerLabel.BackColor = System.Drawing.Color.Black;
            this.spacerLabel.Location = new System.Drawing.Point(193, 495);
            this.spacerLabel.Name = "spacerLabel";
            this.spacerLabel.Size = new System.Drawing.Size(273, 13);
            this.spacerLabel.TabIndex = 11;
            this.spacerLabel.Text = "label1";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(134, 508);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(120, 29);
            this.tenderedLabel.TabIndex = 12;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedAmounttextLabel
            // 
            this.tenderedAmounttextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedAmounttextLabel.Location = new System.Drawing.Point(418, 507);
            this.tenderedAmounttextLabel.Name = "tenderedAmounttextLabel";
            this.tenderedAmounttextLabel.Size = new System.Drawing.Size(100, 30);
            this.tenderedAmounttextLabel.TabIndex = 13;
            // 
            // calculateChangebutton
            // 
            this.calculateChangebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.calculateChangebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateChangebutton.Font = new System.Drawing.Font("Javanese Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateChangebutton.Location = new System.Drawing.Point(243, 543);
            this.calculateChangebutton.Name = "calculateChangebutton";
            this.calculateChangebutton.Size = new System.Drawing.Size(187, 47);
            this.calculateChangebutton.TabIndex = 14;
            this.calculateChangebutton.Text = "Calculate Change";
            this.calculateChangebutton.UseVisualStyleBackColor = true;
            this.calculateChangebutton.Click += new System.EventHandler(this.calculateChangebutton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(134, 593);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(375, 31);
            this.changeLabel.TabIndex = 15;
            this.changeLabel.Text = "Change";
            // 
            // printReceiptbutton
            // 
            this.printReceiptbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.printReceiptbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReceiptbutton.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptbutton.Location = new System.Drawing.Point(773, 80);
            this.printReceiptbutton.Name = "printReceiptbutton";
            this.printReceiptbutton.Size = new System.Drawing.Size(176, 46);
            this.printReceiptbutton.TabIndex = 16;
            this.printReceiptbutton.Text = "Print Receipt";
            this.printReceiptbutton.UseVisualStyleBackColor = true;
            this.printReceiptbutton.Click += new System.EventHandler(this.printReceiptbutton_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 648);
            this.Controls.Add(this.printReceiptbutton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calculateChangebutton);
            this.Controls.Add(this.tenderedAmounttextLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.spacerLabel);
            this.Controls.Add(this.totalAmountlabel);
            this.Controls.Add(this.newOrderbutton);
            this.Controls.Add(this.totalCalulator);
            this.Controls.Add(this.drinkAmounttextBox);
            this.Controls.Add(this.friesAmounttextBox);
            this.Controls.Add(this.burgerAmounttextBox);
            this.Controls.Add(this.drinkAmountLabel);
            this.Controls.Add(this.friesAmountLabel);
            this.Controls.Add(this.burgerAmountlabel);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.Burgertitle);
            this.Name = "form1";
            this.Text = "BestBurgerInTown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Burgertitle;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Label burgerAmountlabel;
        private System.Windows.Forms.Label friesAmountLabel;
        private System.Windows.Forms.Label drinkAmountLabel;
        private System.Windows.Forms.TextBox burgerAmounttextBox;
        private System.Windows.Forms.TextBox friesAmounttextBox;
        private System.Windows.Forms.TextBox drinkAmounttextBox;
        private System.Windows.Forms.Button totalCalulator;
        private System.Windows.Forms.Button newOrderbutton;
        private System.Windows.Forms.Label totalAmountlabel;
        private System.Windows.Forms.Label spacerLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedAmounttextLabel;
        private System.Windows.Forms.Button calculateChangebutton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button printReceiptbutton;
    }
}

