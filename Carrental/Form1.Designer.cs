namespace Carrental
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.carBrand = new System.Windows.Forms.ComboBox();
            this.carFuelType = new System.Windows.Forms.ComboBox();
            this.carType = new System.Windows.Forms.ComboBox();
            this.wwf = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Carrental.Properties.Resources.pic;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.carBrand);
            this.panel1.Controls.Add(this.carFuelType);
            this.panel1.Controls.Add(this.carType);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1512, 609);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button1.Location = new System.Drawing.Point(1278, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // carBrand
            // 
            this.carBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carBrand.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.carBrand.FormattingEnabled = true;
            this.carBrand.Items.AddRange(new object[] {
            "Any Brand",
            "Opel",
            "Tesla",
            "BMW",
            "Audi",
            "Ford",
            "Toyota",
            "Kia",
            "Citroen",
            "Hyundai",
            "Fiat",
            "Renault",
            "Volkswagen",
            "Suzuki",
            "Volvo",
            "Nissan",
            "Dacia",
            "Honda",
            "Mazda"});
            this.carBrand.Location = new System.Drawing.Point(1020, 50);
            this.carBrand.MaxDropDownItems = 20;
            this.carBrand.Name = "carBrand";
            this.carBrand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.carBrand.Size = new System.Drawing.Size(181, 31);
            this.carBrand.TabIndex = 2;
            // 
            // carFuelType
            // 
            this.carFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carFuelType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carFuelType.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.carFuelType.FormattingEnabled = true;
            this.carFuelType.Items.AddRange(new object[] {
            "Any Fuel Type",
            "Petrol",
            "Diesel",
            "Hybrid",
            "Electric"});
            this.carFuelType.Location = new System.Drawing.Point(799, 49);
            this.carFuelType.Name = "carFuelType";
            this.carFuelType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.carFuelType.Size = new System.Drawing.Size(182, 31);
            this.carFuelType.TabIndex = 1;
            // 
            // carType
            // 
            this.carType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carType.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.carType.FormattingEnabled = true;
            this.carType.Items.AddRange(new object[] {
            "Any Type",
            "Mini",
            "Sport",
            "SUV",
            "Compact"});
            this.carType.Location = new System.Drawing.Point(580, 49);
            this.carType.Name = "carType";
            this.carType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.carType.Size = new System.Drawing.Size(175, 31);
            this.carType.TabIndex = 0;
            // 
            // wwf
            // 
            this.wwf.AutoSize = true;
            this.wwf.Font = new System.Drawing.Font("Edwardian Script ITC", 30F, System.Drawing.FontStyle.Bold);
            this.wwf.Location = new System.Drawing.Point(573, 635);
            this.wwf.Name = "wwf";
            this.wwf.Size = new System.Drawing.Size(384, 59);
            this.wwf.TabIndex = 1;
            this.wwf.Text = "Promotion for now only";
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.wwf);
            this.mainPanel.Location = new System.Drawing.Point(-1, -2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1539, 797);
            this.mainPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1540, 795);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox carBrand;
        private System.Windows.Forms.ComboBox carFuelType;
        private System.Windows.Forms.ComboBox carType;
        private System.Windows.Forms.Label wwf;
        private System.Windows.Forms.Panel mainPanel;
    }
}

