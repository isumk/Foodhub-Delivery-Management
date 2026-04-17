namespace Foodhub_1
{
    partial class FrmOrders
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
            this.grpOrderHeader = new System.Windows.Forms.GroupBox();
            this.dtpOrderTime = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.cmbOrderStatus = new System.Windows.Forms.ComboBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOrderTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpOrderItems = new System.Windows.Forms.GroupBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.cmbFoodItem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.grpOrderHeader.SuspendLayout();
            this.grpOrderItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOrderHeader
            // 
            this.grpOrderHeader.Controls.Add(this.dtpOrderTime);
            this.grpOrderHeader.Controls.Add(this.dtpOrderDate);
            this.grpOrderHeader.Controls.Add(this.cmbOrderStatus);
            this.grpOrderHeader.Controls.Add(this.cmbPaymentMethod);
            this.grpOrderHeader.Controls.Add(this.cmbCustomer);
            this.grpOrderHeader.Controls.Add(this.label5);
            this.grpOrderHeader.Controls.Add(this.label4);
            this.grpOrderHeader.Controls.Add(this.lblOrderTime);
            this.grpOrderHeader.Controls.Add(this.label2);
            this.grpOrderHeader.Controls.Add(this.label1);
            this.grpOrderHeader.Location = new System.Drawing.Point(3, 22);
            this.grpOrderHeader.Name = "grpOrderHeader";
            this.grpOrderHeader.Size = new System.Drawing.Size(312, 240);
            this.grpOrderHeader.TabIndex = 0;
            this.grpOrderHeader.TabStop = false;
            this.grpOrderHeader.Text = "Order Information";
            this.grpOrderHeader.Enter += new System.EventHandler(this.grpOrderHeader_Enter);
            // 
            // dtpOrderTime
            // 
            this.dtpOrderTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpOrderTime.Location = new System.Drawing.Point(61, 126);
            this.dtpOrderTime.Name = "dtpOrderTime";
            this.dtpOrderTime.ShowUpDown = true;
            this.dtpOrderTime.Size = new System.Drawing.Size(200, 20);
            this.dtpOrderTime.TabIndex = 8;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(61, 83);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 20);
            this.dtpOrderDate.TabIndex = 7;
            // 
            // cmbOrderStatus
            // 
            this.cmbOrderStatus.FormattingEnabled = true;
            this.cmbOrderStatus.Items.AddRange(new object[] {
            "Pending",
            "Preparing",
            "Dispatched",
            "Delivered",
            "Cancelled"});
            this.cmbOrderStatus.Location = new System.Drawing.Point(90, 206);
            this.cmbOrderStatus.Name = "cmbOrderStatus";
            this.cmbOrderStatus.Size = new System.Drawing.Size(171, 21);
            this.cmbOrderStatus.TabIndex = 6;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Online"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(90, 166);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(171, 21);
            this.cmbPaymentMethod.TabIndex = 5;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(61, 44);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(200, 21);
            this.cmbCustomer.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Order Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Payment Method";
            // 
            // lblOrderTime
            // 
            this.lblOrderTime.AutoSize = true;
            this.lblOrderTime.Location = new System.Drawing.Point(1, 132);
            this.lblOrderTime.Name = "lblOrderTime";
            this.lblOrderTime.Size = new System.Drawing.Size(59, 13);
            this.lblOrderTime.TabIndex = 2;
            this.lblOrderTime.Text = "Order Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // grpOrderItems
            // 
            this.grpOrderItems.Controls.Add(this.btnRemoveItem);
            this.grpOrderItems.Controls.Add(this.btnAddItem);
            this.grpOrderItems.Controls.Add(this.numQuantity);
            this.grpOrderItems.Controls.Add(this.txtUnitPrice);
            this.grpOrderItems.Controls.Add(this.cmbFoodItem);
            this.grpOrderItems.Controls.Add(this.label8);
            this.grpOrderItems.Controls.Add(this.label9);
            this.grpOrderItems.Controls.Add(this.label10);
            this.grpOrderItems.Location = new System.Drawing.Point(343, 32);
            this.grpOrderItems.Name = "grpOrderItems";
            this.grpOrderItems.Size = new System.Drawing.Size(289, 230);
            this.grpOrderItems.TabIndex = 9;
            this.grpOrderItems.TabStop = false;
            this.grpOrderItems.Text = "Add Food Items";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(138, 169);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(77, 23);
            this.btnRemoveItem.TabIndex = 6;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(38, 169);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(77, 23);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(61, 124);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(126, 20);
            this.numQuantity.TabIndex = 4;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(61, 87);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(200, 20);
            this.txtUnitPrice.TabIndex = 3;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbFoodItem
            // 
            this.cmbFoodItem.FormattingEnabled = true;
            this.cmbFoodItem.Location = new System.Drawing.Point(61, 44);
            this.cmbFoodItem.Name = "cmbFoodItem";
            this.cmbFoodItem.Size = new System.Drawing.Size(200, 21);
            this.cmbFoodItem.TabIndex = 1;
            this.cmbFoodItem.SelectedIndexChanged += new System.EventHandler(this.cmbFoodItem_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Unit Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Food Item";
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Location = new System.Drawing.Point(3, 268);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.Size = new System.Drawing.Size(612, 179);
            this.dgvOrderItems.TabIndex = 10;
            // 
            // lblTotalText
            // 
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Location = new System.Drawing.Point(635, 282);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(70, 13);
            this.lblTotalText.TabIndex = 11;
            this.lblTotalText.Text = "Total Amount";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(726, 282);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(28, 13);
            this.lblTotalAmount.TabIndex = 12;
            this.lblTotalAmount.Text = "0.00";
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(628, 372);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(147, 23);
            this.btnClearOrder.TabIndex = 14;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(628, 343);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(147, 23);
            this.btnSaveOrder.TabIndex = 13;
            this.btnSaveOrder.Text = "Save Order";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotalText);
            this.Controls.Add(this.dgvOrderItems);
            this.Controls.Add(this.grpOrderItems);
            this.Controls.Add(this.grpOrderHeader);
            this.Name = "FrmOrders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.FrmOrders_Load);
            this.grpOrderHeader.ResumeLayout(false);
            this.grpOrderHeader.PerformLayout();
            this.grpOrderItems.ResumeLayout(false);
            this.grpOrderItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrderHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOrderTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtpOrderTime;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.GroupBox grpOrderItems;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.ComboBox cmbOrderStatus;
        private System.Windows.Forms.ComboBox cmbFoodItem;
    }
}