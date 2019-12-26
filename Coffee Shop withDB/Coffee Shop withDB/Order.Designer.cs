namespace Coffee_Shop_withDB
{
    partial class Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.orderIdTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderItemNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalPriceTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderCustomerNameTB = new System.Windows.Forms.TextBox();
            this.orderAddBtn = new System.Windows.Forms.Button();
            this.orderDeleteBtn = new System.Windows.Forms.Button();
            this.orderUpdateBtn = new System.Windows.Forms.Button();
            this.orderSearchBtn = new System.Windows.Forms.Button();
            this.orderShowBtn = new System.Windows.Forms.Button();
            this.orderShowDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.orderShowDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Id";
            // 
            // orderIdTB
            // 
            this.orderIdTB.Location = new System.Drawing.Point(243, 52);
            this.orderIdTB.Name = "orderIdTB";
            this.orderIdTB.Size = new System.Drawing.Size(227, 20);
            this.orderIdTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item Name";
            // 
            // orderItemNameTB
            // 
            this.orderItemNameTB.Location = new System.Drawing.Point(243, 93);
            this.orderItemNameTB.Name = "orderItemNameTB";
            this.orderItemNameTB.Size = new System.Drawing.Size(227, 20);
            this.orderItemNameTB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantity";
            // 
            // quantityTB
            // 
            this.quantityTB.Location = new System.Drawing.Point(243, 135);
            this.quantityTB.Name = "quantityTB";
            this.quantityTB.Size = new System.Drawing.Size(227, 20);
            this.quantityTB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Price";
            // 
            // totalPriceTB
            // 
            this.totalPriceTB.Location = new System.Drawing.Point(243, 175);
            this.totalPriceTB.Name = "totalPriceTB";
            this.totalPriceTB.Size = new System.Drawing.Size(227, 20);
            this.totalPriceTB.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Customer Name";
            // 
            // OrderCustomerNameTB
            // 
            this.OrderCustomerNameTB.Location = new System.Drawing.Point(243, 214);
            this.OrderCustomerNameTB.Name = "OrderCustomerNameTB";
            this.OrderCustomerNameTB.Size = new System.Drawing.Size(227, 20);
            this.OrderCustomerNameTB.TabIndex = 1;
            // 
            // orderAddBtn
            // 
            this.orderAddBtn.Location = new System.Drawing.Point(78, 278);
            this.orderAddBtn.Name = "orderAddBtn";
            this.orderAddBtn.Size = new System.Drawing.Size(75, 23);
            this.orderAddBtn.TabIndex = 2;
            this.orderAddBtn.Text = "ADD";
            this.orderAddBtn.UseVisualStyleBackColor = true;
            this.orderAddBtn.Click += new System.EventHandler(this.orderAddBtn_Click);
            // 
            // orderDeleteBtn
            // 
            this.orderDeleteBtn.Location = new System.Drawing.Point(197, 278);
            this.orderDeleteBtn.Name = "orderDeleteBtn";
            this.orderDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.orderDeleteBtn.TabIndex = 3;
            this.orderDeleteBtn.Text = "DELETE";
            this.orderDeleteBtn.UseVisualStyleBackColor = true;
            this.orderDeleteBtn.Click += new System.EventHandler(this.orderDeleteBtn_Click);
            // 
            // orderUpdateBtn
            // 
            this.orderUpdateBtn.Location = new System.Drawing.Point(319, 278);
            this.orderUpdateBtn.Name = "orderUpdateBtn";
            this.orderUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.orderUpdateBtn.TabIndex = 4;
            this.orderUpdateBtn.Text = "UPDATE";
            this.orderUpdateBtn.UseVisualStyleBackColor = true;
            this.orderUpdateBtn.Click += new System.EventHandler(this.orderUpdateBtn_Click);
            // 
            // orderSearchBtn
            // 
            this.orderSearchBtn.Location = new System.Drawing.Point(439, 278);
            this.orderSearchBtn.Name = "orderSearchBtn";
            this.orderSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.orderSearchBtn.TabIndex = 5;
            this.orderSearchBtn.Text = "Search";
            this.orderSearchBtn.UseVisualStyleBackColor = true;
            this.orderSearchBtn.Click += new System.EventHandler(this.orderSearchBtn_Click);
            // 
            // orderShowBtn
            // 
            this.orderShowBtn.Location = new System.Drawing.Point(557, 278);
            this.orderShowBtn.Name = "orderShowBtn";
            this.orderShowBtn.Size = new System.Drawing.Size(75, 23);
            this.orderShowBtn.TabIndex = 6;
            this.orderShowBtn.Text = "SHOW";
            this.orderShowBtn.UseVisualStyleBackColor = true;
            this.orderShowBtn.Click += new System.EventHandler(this.orderShowBtn_Click);
            // 
            // orderShowDataGridView
            // 
            this.orderShowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderShowDataGridView.Location = new System.Drawing.Point(42, 325);
            this.orderShowDataGridView.Name = "orderShowDataGridView";
            this.orderShowDataGridView.Size = new System.Drawing.Size(856, 174);
            this.orderShowDataGridView.TabIndex = 7;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 529);
            this.Controls.Add(this.orderShowDataGridView);
            this.Controls.Add(this.orderShowBtn);
            this.Controls.Add(this.orderSearchBtn);
            this.Controls.Add(this.orderUpdateBtn);
            this.Controls.Add(this.orderDeleteBtn);
            this.Controls.Add(this.orderAddBtn);
            this.Controls.Add(this.OrderCustomerNameTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalPriceTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderItemNameTB);
            this.Controls.Add(this.quantityTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderIdTB);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.orderShowDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orderIdTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderItemNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalPriceTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OrderCustomerNameTB;
        private System.Windows.Forms.Button orderAddBtn;
        private System.Windows.Forms.Button orderDeleteBtn;
        private System.Windows.Forms.Button orderUpdateBtn;
        private System.Windows.Forms.Button orderSearchBtn;
        private System.Windows.Forms.Button orderShowBtn;
        private System.Windows.Forms.DataGridView orderShowDataGridView;
    }
}