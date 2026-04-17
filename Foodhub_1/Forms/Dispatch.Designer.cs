namespace Foodhub_1
{
    partial class FrmDispatch
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
            this.grpDispatch = new System.Windows.Forms.GroupBox();
            this.btnDispatch = new System.Windows.Forms.Button();
            this.txtCurrentStatus = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dtpDispatchDateTime = new System.Windows.Forms.DateTimePicker();
            this.cmbOrdersPending = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvDispatchHistory = new System.Windows.Forms.DataGridView();
            this.grpDispatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispatchHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDispatch
            // 
            this.grpDispatch.Controls.Add(this.btnDispatch);
            this.grpDispatch.Controls.Add(this.txtCurrentStatus);
            this.grpDispatch.Controls.Add(this.txtCustomerName);
            this.grpDispatch.Controls.Add(this.dtpDispatchDateTime);
            this.grpDispatch.Controls.Add(this.cmbOrdersPending);
            this.grpDispatch.Controls.Add(this.label4);
            this.grpDispatch.Controls.Add(this.label3);
            this.grpDispatch.Controls.Add(this.label2);
            this.grpDispatch.Controls.Add(this.lblOrderNo);
            this.grpDispatch.Location = new System.Drawing.Point(43, 21);
            this.grpDispatch.Name = "grpDispatch";
            this.grpDispatch.Size = new System.Drawing.Size(399, 242);
            this.grpDispatch.TabIndex = 0;
            this.grpDispatch.TabStop = false;
            this.grpDispatch.Text = "Dispatch Order";
            this.grpDispatch.Enter += new System.EventHandler(this.grpDispatch_Enter);
            // 
            // btnDispatch
            // 
            this.btnDispatch.Location = new System.Drawing.Point(151, 209);
            this.btnDispatch.Name = "btnDispatch";
            this.btnDispatch.Size = new System.Drawing.Size(75, 23);
            this.btnDispatch.TabIndex = 8;
            this.btnDispatch.Text = "Dispatch";
            this.btnDispatch.UseVisualStyleBackColor = true;
            this.btnDispatch.Click += new System.EventHandler(this.btnDispatch_Click);
            // 
            // txtCurrentStatus
            // 
            this.txtCurrentStatus.Location = new System.Drawing.Point(88, 159);
            this.txtCurrentStatus.Name = "txtCurrentStatus";
            this.txtCurrentStatus.ReadOnly = true;
            this.txtCurrentStatus.Size = new System.Drawing.Size(200, 20);
            this.txtCurrentStatus.TabIndex = 7;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(88, 120);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerName.TabIndex = 6;
            // 
            // dtpDispatchDateTime
            // 
            this.dtpDispatchDateTime.Location = new System.Drawing.Point(88, 82);
            this.dtpDispatchDateTime.Name = "dtpDispatchDateTime";
            this.dtpDispatchDateTime.Size = new System.Drawing.Size(200, 20);
            this.dtpDispatchDateTime.TabIndex = 5;
            // 
            // cmbOrdersPending
            // 
            this.cmbOrdersPending.FormattingEnabled = true;
            this.cmbOrdersPending.Location = new System.Drawing.Point(88, 41);
            this.cmbOrdersPending.Name = "cmbOrdersPending";
            this.cmbOrdersPending.Size = new System.Drawing.Size(200, 21);
            this.cmbOrdersPending.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Curren tStatus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dispatch DateTime";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Location = new System.Drawing.Point(21, 44);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(50, 13);
            this.lblOrderNo.TabIndex = 0;
            this.lblOrderNo.Text = "Order No";
            this.lblOrderNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDispatchHistory
            // 
            this.dgvDispatchHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispatchHistory.Location = new System.Drawing.Point(2, 269);
            this.dgvDispatchHistory.Name = "dgvDispatchHistory";
            this.dgvDispatchHistory.Size = new System.Drawing.Size(448, 136);
            this.dgvDispatchHistory.TabIndex = 1;
            this.dgvDispatchHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDispatchHistory_CellContentClick);
            // 
            // FrmDispatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 405);
            this.Controls.Add(this.dgvDispatchHistory);
            this.Controls.Add(this.grpDispatch);
            this.Name = "FrmDispatch";
            this.Text = "Dispatch";
            this.Load += new System.EventHandler(this.FrmDispatch_Load);
            this.grpDispatch.ResumeLayout(false);
            this.grpDispatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispatchHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDispatch;
        private System.Windows.Forms.Label lblOrderNo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDispatch;
        private System.Windows.Forms.TextBox txtCurrentStatus;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DateTimePicker dtpDispatchDateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDispatchHistory;
        private System.Windows.Forms.ComboBox cmbOrdersPending;
    }
}