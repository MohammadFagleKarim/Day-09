namespace Coffee_Shop_withDB
{
    partial class Customer
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
            this.customerIdTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contactTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.customerAddBtn = new System.Windows.Forms.Button();
            this.customerDeleteBtn = new System.Windows.Forms.Button();
            this.customerUpdateBtn = new System.Windows.Forms.Button();
            this.customerSearchBtn = new System.Windows.Forms.Button();
            this.customerShowBtn = new System.Windows.Forms.Button();
            this.customerShowDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customerShowDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer id";
            // 
            // customerIdTB
            // 
            this.customerIdTB.Location = new System.Drawing.Point(255, 49);
            this.customerIdTB.Name = "customerIdTB";
            this.customerIdTB.Size = new System.Drawing.Size(232, 20);
            this.customerIdTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer name";
            // 
            // customerNameTB
            // 
            this.customerNameTB.Location = new System.Drawing.Point(255, 89);
            this.customerNameTB.Name = "customerNameTB";
            this.customerNameTB.Size = new System.Drawing.Size(232, 20);
            this.customerNameTB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contact";
            // 
            // contactTB
            // 
            this.contactTB.Location = new System.Drawing.Point(255, 127);
            this.contactTB.Name = "contactTB";
            this.contactTB.Size = new System.Drawing.Size(232, 20);
            this.contactTB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address";
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(255, 167);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(232, 20);
            this.addressTB.TabIndex = 1;
            // 
            // customerAddBtn
            // 
            this.customerAddBtn.Location = new System.Drawing.Point(84, 229);
            this.customerAddBtn.Name = "customerAddBtn";
            this.customerAddBtn.Size = new System.Drawing.Size(75, 23);
            this.customerAddBtn.TabIndex = 2;
            this.customerAddBtn.Text = "ADD";
            this.customerAddBtn.UseVisualStyleBackColor = true;
            this.customerAddBtn.Click += new System.EventHandler(this.customerAddBtn_Click);
            // 
            // customerDeleteBtn
            // 
            this.customerDeleteBtn.Location = new System.Drawing.Point(211, 229);
            this.customerDeleteBtn.Name = "customerDeleteBtn";
            this.customerDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.customerDeleteBtn.TabIndex = 3;
            this.customerDeleteBtn.Text = "DELETE";
            this.customerDeleteBtn.UseVisualStyleBackColor = true;
            this.customerDeleteBtn.Click += new System.EventHandler(this.customerDeleteBtn_Click);
            // 
            // customerUpdateBtn
            // 
            this.customerUpdateBtn.Location = new System.Drawing.Point(325, 229);
            this.customerUpdateBtn.Name = "customerUpdateBtn";
            this.customerUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.customerUpdateBtn.TabIndex = 4;
            this.customerUpdateBtn.Text = "UPDATE";
            this.customerUpdateBtn.UseVisualStyleBackColor = true;
            this.customerUpdateBtn.Click += new System.EventHandler(this.customerUpdateBtn_Click);
            // 
            // customerSearchBtn
            // 
            this.customerSearchBtn.Location = new System.Drawing.Point(449, 229);
            this.customerSearchBtn.Name = "customerSearchBtn";
            this.customerSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.customerSearchBtn.TabIndex = 5;
            this.customerSearchBtn.Text = "SEARCH";
            this.customerSearchBtn.UseVisualStyleBackColor = true;
            this.customerSearchBtn.Click += new System.EventHandler(this.customerSearchBtn_Click);
            // 
            // customerShowBtn
            // 
            this.customerShowBtn.Location = new System.Drawing.Point(566, 229);
            this.customerShowBtn.Name = "customerShowBtn";
            this.customerShowBtn.Size = new System.Drawing.Size(75, 23);
            this.customerShowBtn.TabIndex = 6;
            this.customerShowBtn.Text = "SHOW";
            this.customerShowBtn.UseVisualStyleBackColor = true;
            this.customerShowBtn.Click += new System.EventHandler(this.customerShowBtn_Click);
            // 
            // customerShowDataGridView
            // 
            this.customerShowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerShowDataGridView.Location = new System.Drawing.Point(53, 292);
            this.customerShowDataGridView.Name = "customerShowDataGridView";
            this.customerShowDataGridView.Size = new System.Drawing.Size(816, 190);
            this.customerShowDataGridView.TabIndex = 7;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 523);
            this.Controls.Add(this.customerShowDataGridView);
            this.Controls.Add(this.customerShowBtn);
            this.Controls.Add(this.customerSearchBtn);
            this.Controls.Add(this.customerUpdateBtn);
            this.Controls.Add(this.customerDeleteBtn);
            this.Controls.Add(this.customerAddBtn);
            this.Controls.Add(this.contactTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerIdTB);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.Text = "Customer Information";
            ((System.ComponentModel.ISupportInitialize)(this.customerShowDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerIdTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contactTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Button customerAddBtn;
        private System.Windows.Forms.Button customerDeleteBtn;
        private System.Windows.Forms.Button customerUpdateBtn;
        private System.Windows.Forms.Button customerSearchBtn;
        private System.Windows.Forms.Button customerShowBtn;
        private System.Windows.Forms.DataGridView customerShowDataGridView;
    }
}