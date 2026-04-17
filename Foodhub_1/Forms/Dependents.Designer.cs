namespace Foodhub_1
{
    partial class FrmDependents
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDependentDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbRelationship = new System.Windows.Forms.ComboBox();
            this.cmbRider = new System.Windows.Forms.ComboBox();
            this.txtDependentName = new System.Windows.Forms.TextBox();
            this.txtDependentID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvDependents = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependents)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DependentID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDependentDOB);
            this.groupBox1.Controls.Add(this.cmbRelationship);
            this.groupBox1.Controls.Add(this.cmbRider);
            this.groupBox1.Controls.Add(this.txtDependentName);
            this.groupBox1.Controls.Add(this.txtDependentID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 180);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rider Dependents";
            // 
            // dtpDependentDOB
            // 
            this.dtpDependentDOB.Location = new System.Drawing.Point(68, 140);
            this.dtpDependentDOB.Name = "dtpDependentDOB";
            this.dtpDependentDOB.Size = new System.Drawing.Size(185, 20);
            this.dtpDependentDOB.TabIndex = 10;
            // 
            // cmbRelationship
            // 
            this.cmbRelationship.FormattingEnabled = true;
            this.cmbRelationship.Items.AddRange(new object[] {
            "Father",
            "",
            "Mother",
            "",
            "Son",
            "",
            "Daughter",
            "",
            "Wife",
            "",
            "Husband",
            "",
            "Brother",
            "",
            "Sister",
            "",
            "Other"});
            this.cmbRelationship.Location = new System.Drawing.Point(68, 116);
            this.cmbRelationship.Name = "cmbRelationship";
            this.cmbRelationship.Size = new System.Drawing.Size(185, 21);
            this.cmbRelationship.TabIndex = 9;
            // 
            // cmbRider
            // 
            this.cmbRider.FormattingEnabled = true;
            this.cmbRider.Location = new System.Drawing.Point(68, 59);
            this.cmbRider.Name = "cmbRider";
            this.cmbRider.Size = new System.Drawing.Size(185, 21);
            this.cmbRider.TabIndex = 8;
            this.cmbRider.SelectedIndexChanged += new System.EventHandler(this.cmbRider_SelectedIndexChanged);
            // 
            // txtDependentName
            // 
            this.txtDependentName.Location = new System.Drawing.Point(68, 90);
            this.txtDependentName.Name = "txtDependentName";
            this.txtDependentName.Size = new System.Drawing.Size(185, 20);
            this.txtDependentName.TabIndex = 7;
            // 
            // txtDependentID
            // 
            this.txtDependentID.Location = new System.Drawing.Point(68, 33);
            this.txtDependentID.Name = "txtDependentID";
            this.txtDependentID.ReadOnly = true;
            this.txtDependentID.Size = new System.Drawing.Size(185, 20);
            this.txtDependentID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DOB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Relationship";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dependednt \r\nname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rider";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(308, 57);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(308, 89);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(308, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(308, 152);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvDependents
            // 
            this.dgvDependents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDependents.Location = new System.Drawing.Point(12, 218);
            this.dgvDependents.Name = "dgvDependents";
            this.dgvDependents.Size = new System.Drawing.Size(376, 125);
            this.dgvDependents.TabIndex = 7;
            this.dgvDependents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDependents_CellContentClick);
            // 
            // FrmDependents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 355);
            this.Controls.Add(this.dgvDependents);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDependents";
            this.Text = "Dependents";
            this.Load += new System.EventHandler(this.FrmDependents_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDependentDOB;
        private System.Windows.Forms.ComboBox cmbRelationship;
        private System.Windows.Forms.ComboBox cmbRider;
        private System.Windows.Forms.TextBox txtDependentName;
        private System.Windows.Forms.TextBox txtDependentID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvDependents;
        private System.Windows.Forms.Button btnSave;
    }
}