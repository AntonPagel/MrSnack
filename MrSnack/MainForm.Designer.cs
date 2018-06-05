namespace MrSnack
{
    partial class MainForm
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
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.productsGroupBox = new System.Windows.Forms.GroupBox();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.productsTypesComboBox = new System.Windows.Forms.ComboBox();
            this.cartGroupBox = new System.Windows.Forms.GroupBox();
            this.payButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.productsGroupBox.SuspendLayout();
            this.cartGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsListBox
            // 
            this.productsListBox.DisplayMember = "Name";
            this.productsListBox.Location = new System.Drawing.Point(7, 47);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(188, 329);
            this.productsListBox.Sorted = true;
            this.productsListBox.TabIndex = 0;
            // 
            // cartListBox
            // 
            this.cartListBox.Location = new System.Drawing.Point(6, 19);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(188, 355);
            this.cartListBox.Sorted = true;
            this.cartListBox.TabIndex = 1;
            // 
            // productsGroupBox
            // 
            this.productsGroupBox.Controls.Add(this.addToCartButton);
            this.productsGroupBox.Controls.Add(this.productsTypesComboBox);
            this.productsGroupBox.Controls.Add(this.productsListBox);
            this.productsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.productsGroupBox.Name = "productsGroupBox";
            this.productsGroupBox.Size = new System.Drawing.Size(200, 414);
            this.productsGroupBox.TabIndex = 2;
            this.productsGroupBox.TabStop = false;
            this.productsGroupBox.Text = "Products";
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(7, 382);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(187, 23);
            this.addToCartButton.TabIndex = 2;
            this.addToCartButton.Text = "Add To Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.AddToCartButtonClick);
            // 
            // productsTypesComboBox
            // 
            this.productsTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productsTypesComboBox.Items.AddRange(new object[] {
            "Alles",
            "Süßes",
            "Salziges",
            "Getränke"});
            this.productsTypesComboBox.Location = new System.Drawing.Point(7, 20);
            this.productsTypesComboBox.Name = "productsTypesComboBox";
            this.productsTypesComboBox.Size = new System.Drawing.Size(187, 21);
            this.productsTypesComboBox.TabIndex = 1;
            this.productsTypesComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductsTypesComboBoxSelectedIndexChanged);
            // 
            // cartGroupBox
            // 
            this.cartGroupBox.Controls.Add(this.payButton);
            this.cartGroupBox.Controls.Add(this.minusButton);
            this.cartGroupBox.Controls.Add(this.plusButton);
            this.cartGroupBox.Controls.Add(this.cartListBox);
            this.cartGroupBox.Location = new System.Drawing.Point(218, 14);
            this.cartGroupBox.Name = "cartGroupBox";
            this.cartGroupBox.Size = new System.Drawing.Size(200, 412);
            this.cartGroupBox.TabIndex = 3;
            this.cartGroupBox.TabStop = false;
            this.cartGroupBox.Text = "Cart";
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(64, 380);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(130, 23);
            this.payButton.TabIndex = 4;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.PayButtonClick);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(35, 380);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(23, 23);
            this.minusButton.TabIndex = 3;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.MinusButtonClick);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(6, 380);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(23, 23);
            this.plusButton.TabIndex = 2;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.PlusButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 433);
            this.Controls.Add(this.cartGroupBox);
            this.Controls.Add(this.productsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mr. Snack";
            this.productsGroupBox.ResumeLayout(false);
            this.cartGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox productsListBox;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.GroupBox productsGroupBox;
        private System.Windows.Forms.ComboBox productsTypesComboBox;
        private System.Windows.Forms.GroupBox cartGroupBox;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
    }
}

