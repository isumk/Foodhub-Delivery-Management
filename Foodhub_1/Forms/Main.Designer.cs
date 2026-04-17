namespace Foodhub_1
{
    partial class FrmMain
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
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnFoodItems = new System.Windows.Forms.Button();
            this.btnIngredients = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDispatchOrders = new System.Windows.Forms.Button();
            this.btnRiders = new System.Windows.Forms.Button();
            this.btnDependents = new System.Windows.Forms.Button();
            this.btnMotorBikes = new System.Windows.Forms.Button();
            this.btnBikeAssignments = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(35, 108);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(110, 38);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnFoodItems
            // 
            this.btnFoodItems.Location = new System.Drawing.Point(208, 108);
            this.btnFoodItems.Name = "btnFoodItems";
            this.btnFoodItems.Size = new System.Drawing.Size(110, 38);
            this.btnFoodItems.TabIndex = 1;
            this.btnFoodItems.Text = "Food Items";
            this.btnFoodItems.UseVisualStyleBackColor = true;
            this.btnFoodItems.Click += new System.EventHandler(this.btnFoodItems_Click);
            // 
            // btnIngredients
            // 
            this.btnIngredients.Location = new System.Drawing.Point(363, 108);
            this.btnIngredients.Name = "btnIngredients";
            this.btnIngredients.Size = new System.Drawing.Size(110, 38);
            this.btnIngredients.TabIndex = 2;
            this.btnIngredients.Text = "Ingredients";
            this.btnIngredients.UseVisualStyleBackColor = true;
            this.btnIngredients.Click += new System.EventHandler(this.btnIngredients_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(35, 171);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(110, 38);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnDispatchOrders
            // 
            this.btnDispatchOrders.Location = new System.Drawing.Point(208, 171);
            this.btnDispatchOrders.Name = "btnDispatchOrders";
            this.btnDispatchOrders.Size = new System.Drawing.Size(110, 38);
            this.btnDispatchOrders.TabIndex = 4;
            this.btnDispatchOrders.Text = "Dispatch Orders";
            this.btnDispatchOrders.UseVisualStyleBackColor = true;
            this.btnDispatchOrders.Click += new System.EventHandler(this.btnDispatchOrders_Click);
            // 
            // btnRiders
            // 
            this.btnRiders.Location = new System.Drawing.Point(363, 171);
            this.btnRiders.Name = "btnRiders";
            this.btnRiders.Size = new System.Drawing.Size(110, 38);
            this.btnRiders.TabIndex = 5;
            this.btnRiders.Text = "Riders";
            this.btnRiders.UseVisualStyleBackColor = true;
            this.btnRiders.Click += new System.EventHandler(this.btnRiders_Click);
            // 
            // btnDependents
            // 
            this.btnDependents.Location = new System.Drawing.Point(35, 249);
            this.btnDependents.Name = "btnDependents";
            this.btnDependents.Size = new System.Drawing.Size(110, 38);
            this.btnDependents.TabIndex = 6;
            this.btnDependents.Text = "Dependents";
            this.btnDependents.UseVisualStyleBackColor = true;
            this.btnDependents.Click += new System.EventHandler(this.btnDependents_Click);
            // 
            // btnMotorBikes
            // 
            this.btnMotorBikes.Location = new System.Drawing.Point(208, 249);
            this.btnMotorBikes.Name = "btnMotorBikes";
            this.btnMotorBikes.Size = new System.Drawing.Size(110, 38);
            this.btnMotorBikes.TabIndex = 7;
            this.btnMotorBikes.Text = "Motor Bikes";
            this.btnMotorBikes.UseVisualStyleBackColor = true;
            this.btnMotorBikes.Click += new System.EventHandler(this.btnMotorBikes_Click);
            // 
            // btnBikeAssignments
            // 
            this.btnBikeAssignments.Location = new System.Drawing.Point(363, 249);
            this.btnBikeAssignments.Name = "btnBikeAssignments";
            this.btnBikeAssignments.Size = new System.Drawing.Size(110, 38);
            this.btnBikeAssignments.TabIndex = 8;
            this.btnBikeAssignments.Text = "Bike Assignments";
            this.btnBikeAssignments.UseVisualStyleBackColor = true;
            this.btnBikeAssignments.Click += new System.EventHandler(this.btnBikeAssignments_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(208, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 38);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(234, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 24);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Main Menu";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 418);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBikeAssignments);
            this.Controls.Add(this.btnMotorBikes);
            this.Controls.Add(this.btnDependents);
            this.Controls.Add(this.btnRiders);
            this.Controls.Add(this.btnDispatchOrders);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnIngredients);
            this.Controls.Add(this.btnFoodItems);
            this.Controls.Add(this.btnCustomers);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnFoodItems;
        private System.Windows.Forms.Button btnIngredients;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnDispatchOrders;
        private System.Windows.Forms.Button btnRiders;
        private System.Windows.Forms.Button btnMotorBikes;
        private System.Windows.Forms.Button btnBikeAssignments;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDependents;
    }
}