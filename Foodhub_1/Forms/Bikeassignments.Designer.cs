namespace Foodhub_1
{
    partial class FrmBikeassignments
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAssignmentID = new System.Windows.Forms.TextBox();
            this.txtMeterAssigned = new System.Windows.Forms.TextBox();
            this.txtMeterReturned = new System.Windows.Forms.TextBox();
            this.cmbRider = new System.Windows.Forms.ComboBox();
            this.cmbBike = new System.Windows.Forms.ComboBox();
            this.cmbShiftCode = new System.Windows.Forms.ComboBox();
            this.dtpAssignmentDate = new System.Windows.Forms.DateTimePicker();
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReturnBike = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AssignmentID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rider";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bike";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Assignment Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Shift Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Meter Assigned";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Meter Returned";
            // 
            // txtAssignmentID
            // 
            this.txtAssignmentID.Location = new System.Drawing.Point(113, 49);
            this.txtAssignmentID.Name = "txtAssignmentID";
            this.txtAssignmentID.ReadOnly = true;
            this.txtAssignmentID.Size = new System.Drawing.Size(200, 20);
            this.txtAssignmentID.TabIndex = 7;
            // 
            // txtMeterAssigned
            // 
            this.txtMeterAssigned.Location = new System.Drawing.Point(113, 203);
            this.txtMeterAssigned.Name = "txtMeterAssigned";
            this.txtMeterAssigned.Size = new System.Drawing.Size(200, 20);
            this.txtMeterAssigned.TabIndex = 8;
            // 
            // txtMeterReturned
            // 
            this.txtMeterReturned.Location = new System.Drawing.Point(113, 232);
            this.txtMeterReturned.Name = "txtMeterReturned";
            this.txtMeterReturned.Size = new System.Drawing.Size(200, 20);
            this.txtMeterReturned.TabIndex = 9;
            // 
            // cmbRider
            // 
            this.cmbRider.FormattingEnabled = true;
            this.cmbRider.Location = new System.Drawing.Point(113, 80);
            this.cmbRider.Name = "cmbRider";
            this.cmbRider.Size = new System.Drawing.Size(200, 21);
            this.cmbRider.TabIndex = 10;
            // 
            // cmbBike
            // 
            this.cmbBike.FormattingEnabled = true;
            this.cmbBike.Location = new System.Drawing.Point(113, 113);
            this.cmbBike.Name = "cmbBike";
            this.cmbBike.Size = new System.Drawing.Size(200, 21);
            this.cmbBike.TabIndex = 11;
            // 
            // cmbShiftCode
            // 
            this.cmbShiftCode.FormattingEnabled = true;
            this.cmbShiftCode.Location = new System.Drawing.Point(113, 175);
            this.cmbShiftCode.Name = "cmbShiftCode";
            this.cmbShiftCode.Size = new System.Drawing.Size(200, 21);
            this.cmbShiftCode.TabIndex = 12;
            // 
            // dtpAssignmentDate
            // 
            this.dtpAssignmentDate.Location = new System.Drawing.Point(113, 146);
            this.dtpAssignmentDate.Name = "dtpAssignmentDate";
            this.dtpAssignmentDate.Size = new System.Drawing.Size(200, 20);
            this.dtpAssignmentDate.TabIndex = 13;
            this.dtpAssignmentDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignments.Location = new System.Drawing.Point(12, 265);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.Size = new System.Drawing.Size(432, 172);
            this.dgvAssignments.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(353, 50);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 24);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnReturnBike
            // 
            this.btnReturnBike.Location = new System.Drawing.Point(353, 80);
            this.btnReturnBike.Name = "btnReturnBike";
            this.btnReturnBike.Size = new System.Drawing.Size(79, 24);
            this.btnReturnBike.TabIndex = 16;
            this.btnReturnBike.Text = "Return Bike";
            this.btnReturnBike.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(353, 110);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 24);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(353, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 24);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(353, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 24);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // FrmBikeassignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 440);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReturnBike);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvAssignments);
            this.Controls.Add(this.dtpAssignmentDate);
            this.Controls.Add(this.cmbShiftCode);
            this.Controls.Add(this.cmbBike);
            this.Controls.Add(this.cmbRider);
            this.Controls.Add(this.txtMeterReturned);
            this.Controls.Add(this.txtMeterAssigned);
            this.Controls.Add(this.txtAssignmentID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBikeassignments";
            this.Text = "Bikeassignments";
            this.Load += new System.EventHandler(this.FrmBikeassignments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAssignmentID;
        private System.Windows.Forms.TextBox txtMeterAssigned;
        private System.Windows.Forms.TextBox txtMeterReturned;
        private System.Windows.Forms.ComboBox cmbRider;
        private System.Windows.Forms.ComboBox cmbBike;
        private System.Windows.Forms.ComboBox cmbShiftCode;
        private System.Windows.Forms.DateTimePicker dtpAssignmentDate;
        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReturnBike;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}