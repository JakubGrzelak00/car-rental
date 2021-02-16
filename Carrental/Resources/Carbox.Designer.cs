namespace Carrental.Resources
{
    partial class Carbox
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.carbox_name = new System.Windows.Forms.Label();
            this.carbox_fuelType = new System.Windows.Forms.Label();
            this.carbox_price = new System.Windows.Forms.Label();
            this.carbox_promotion = new System.Windows.Forms.Label();
            this.carbox_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carbox_name
            // 
            this.carbox_name.AutoSize = true;
            this.carbox_name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carbox_name.Location = new System.Drawing.Point(46, 34);
            this.carbox_name.Name = "carbox_name";
            this.carbox_name.Size = new System.Drawing.Size(135, 30);
            this.carbox_name.TabIndex = 1;
            this.carbox_name.Text = "Opel Tigra";
            // 
            // carbox_fuelType
            // 
            this.carbox_fuelType.AutoSize = true;
            this.carbox_fuelType.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carbox_fuelType.Location = new System.Drawing.Point(328, 34);
            this.carbox_fuelType.Name = "carbox_fuelType";
            this.carbox_fuelType.Size = new System.Drawing.Size(85, 30);
            this.carbox_fuelType.TabIndex = 2;
            this.carbox_fuelType.Text = "Diesel";
            // 
            // carbox_price
            // 
            this.carbox_price.AutoSize = true;
            this.carbox_price.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carbox_price.Location = new System.Drawing.Point(727, 34);
            this.carbox_price.Name = "carbox_price";
            this.carbox_price.Size = new System.Drawing.Size(147, 30);
            this.carbox_price.TabIndex = 3;
            this.carbox_price.Text = "120PLN/24H";
            // 
            // carbox_promotion
            // 
            this.carbox_promotion.AutoSize = true;
            this.carbox_promotion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carbox_promotion.ForeColor = System.Drawing.Color.Red;
            this.carbox_promotion.Location = new System.Drawing.Point(880, 34);
            this.carbox_promotion.Name = "carbox_promotion";
            this.carbox_promotion.Size = new System.Drawing.Size(66, 30);
            this.carbox_promotion.TabIndex = 4;
            this.carbox_promotion.Text = "-20%";
            // 
            // carbox_button
            // 
            this.carbox_button.BackColor = System.Drawing.Color.Silver;
            this.carbox_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carbox_button.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.carbox_button.Location = new System.Drawing.Point(1015, 34);
            this.carbox_button.Name = "carbox_button";
            this.carbox_button.Size = new System.Drawing.Size(170, 32);
            this.carbox_button.TabIndex = 6;
            this.carbox_button.Text = "Choose";
            this.carbox_button.UseVisualStyleBackColor = false;
            this.carbox_button.Click += new System.EventHandler(this.carbox_button_Click);
            // 
            // Carbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.carbox_button);
            this.Controls.Add(this.carbox_promotion);
            this.Controls.Add(this.carbox_price);
            this.Controls.Add(this.carbox_fuelType);
            this.Controls.Add(this.carbox_name);
            this.Name = "Carbox";
            this.Size = new System.Drawing.Size(1233, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label carbox_name;
        public System.Windows.Forms.Label carbox_fuelType;
        public System.Windows.Forms.Label carbox_price;
        public System.Windows.Forms.Label carbox_promotion;
        public System.Windows.Forms.Button carbox_button;
    }
}
