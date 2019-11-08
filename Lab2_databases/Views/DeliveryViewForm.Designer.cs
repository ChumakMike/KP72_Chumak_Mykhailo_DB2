namespace Lab2_databases {
    partial class DeliveryViewForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.DeliveriesGrid = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.All = new System.Windows.Forms.Button();
            this.RandomFill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveriesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DeliveriesGrid
            // 
            this.DeliveriesGrid.AllowUserToAddRows = false;
            this.DeliveriesGrid.AllowUserToDeleteRows = false;
            this.DeliveriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveriesGrid.Location = new System.Drawing.Point(297, 100);
            this.DeliveriesGrid.Name = "DeliveriesGrid";
            this.DeliveriesGrid.ReadOnly = true;
            this.DeliveriesGrid.RowTemplate.Height = 24;
            this.DeliveriesGrid.Size = new System.Drawing.Size(410, 250);
            this.DeliveriesGrid.TabIndex = 9;
            this.DeliveriesGrid.SelectionChanged += new System.EventHandler(this.DeliveriesGrid_SelectionChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(94, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Remove
            // 
            this.Remove.Enabled = false;
            this.Remove.Location = new System.Drawing.Point(94, 244);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(118, 34);
            this.Remove.TabIndex = 7;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(94, 181);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(118, 34);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // All
            // 
            this.All.Location = new System.Drawing.Point(94, 121);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(118, 34);
            this.All.TabIndex = 5;
            this.All.Text = "All";
            this.All.UseVisualStyleBackColor = true;
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // RandomFill
            // 
            this.RandomFill.Location = new System.Drawing.Point(94, 367);
            this.RandomFill.Name = "RandomFill";
            this.RandomFill.Size = new System.Drawing.Size(118, 31);
            this.RandomFill.TabIndex = 10;
            this.RandomFill.Text = "Random Fill";
            this.RandomFill.UseVisualStyleBackColor = true;
            this.RandomFill.Click += new System.EventHandler(this.RandomFill_Click);
            // 
            // DeliveryViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RandomFill);
            this.Controls.Add(this.DeliveriesGrid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.All);
            this.Name = "DeliveryViewForm";
            this.Text = "DeliveryViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.DeliveriesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DeliveriesGrid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button All;
        private System.Windows.Forms.Button RandomFill;
    }
}