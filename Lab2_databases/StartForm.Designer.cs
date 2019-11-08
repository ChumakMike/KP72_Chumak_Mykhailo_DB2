namespace Lab2_databases {
    partial class StartForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.Button();
            this.Providers = new System.Windows.Forms.Button();
            this.Deliveries = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DynamicSearch = new System.Windows.Forms.Button();
            this.fullTxtSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buyers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Products
            // 
            this.Products.Location = new System.Drawing.Point(50, 223);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(155, 63);
            this.Products.TabIndex = 1;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = true;
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // Providers
            // 
            this.Providers.Location = new System.Drawing.Point(248, 101);
            this.Providers.Name = "Providers";
            this.Providers.Size = new System.Drawing.Size(155, 63);
            this.Providers.TabIndex = 2;
            this.Providers.Text = "Providers";
            this.Providers.UseVisualStyleBackColor = true;
            this.Providers.Click += new System.EventHandler(this.Providers_Click);
            // 
            // Deliveries
            // 
            this.Deliveries.Location = new System.Drawing.Point(248, 223);
            this.Deliveries.Name = "Deliveries";
            this.Deliveries.Size = new System.Drawing.Size(155, 63);
            this.Deliveries.TabIndex = 3;
            this.Deliveries.Text = "Deliveries";
            this.Deliveries.UseVisualStyleBackColor = true;
            this.Deliveries.Click += new System.EventHandler(this.Deliveries_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "Static search in different tables";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DynamicSearch
            // 
            this.DynamicSearch.Location = new System.Drawing.Point(450, 223);
            this.DynamicSearch.Name = "DynamicSearch";
            this.DynamicSearch.Size = new System.Drawing.Size(150, 63);
            this.DynamicSearch.TabIndex = 5;
            this.DynamicSearch.Text = "Dynamic search";
            this.DynamicSearch.UseVisualStyleBackColor = true;
            this.DynamicSearch.Click += new System.EventHandler(this.DynamicSearch_Click);
            // 
            // fullTxtSearch
            // 
            this.fullTxtSearch.Location = new System.Drawing.Point(625, 165);
            this.fullTxtSearch.Name = "fullTxtSearch";
            this.fullTxtSearch.Size = new System.Drawing.Size(150, 63);
            this.fullTxtSearch.TabIndex = 6;
            this.fullTxtSearch.Text = "Full text search";
            this.fullTxtSearch.UseVisualStyleBackColor = true;
            this.fullTxtSearch.Click += new System.EventHandler(this.fullTxtSearch_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fullTxtSearch);
            this.Controls.Add(this.DynamicSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Deliveries);
            this.Controls.Add(this.Providers);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.button1);
            this.Name = "StartForm";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Button Providers;
        private System.Windows.Forms.Button Deliveries;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DynamicSearch;
        private System.Windows.Forms.Button fullTxtSearch;
    }
}

