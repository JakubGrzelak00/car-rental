namespace Carrental
{
    partial class RentForm
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
            this.days = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.carName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rentPeriod = new System.Windows.Forms.Label();
            this.rent = new System.Windows.Forms.Button();
            this.ivod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(38, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "For How Many Days You Want To Rent This Car?";
            // 
            // days
            // 
            this.days.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.days.Location = new System.Drawing.Point(667, 197);
            this.days.MaxLength = 4;
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(214, 38);
            this.days.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(38, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "You Have Choosen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label5.Location = new System.Drawing.Point(44, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price Per Day:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.price.Location = new System.Drawing.Point(228, 75);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(0, 31);
            this.price.TabIndex = 8;
            // 
            // carName
            // 
            this.carName.AutoSize = true;
            this.carName.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.carName.Location = new System.Drawing.Point(290, 27);
            this.carName.Name = "carName";
            this.carName.Size = new System.Drawing.Size(0, 31);
            this.carName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(44, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total:";
            this.label3.Visible = false;
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.cost.Location = new System.Drawing.Point(129, 368);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(0, 31);
            this.cost.TabIndex = 11;
            this.cost.Visible = false;
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.DarkRed;
            this.calculate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.calculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.calculate.Location = new System.Drawing.Point(158, 294);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(675, 36);
            this.calculate.TabIndex = 12;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label4.Location = new System.Drawing.Point(44, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rent Period:";
            this.label4.Visible = false;
            // 
            // rentPeriod
            // 
            this.rentPeriod.AutoSize = true;
            this.rentPeriod.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.rentPeriod.Location = new System.Drawing.Point(210, 414);
            this.rentPeriod.Name = "rentPeriod";
            this.rentPeriod.Size = new System.Drawing.Size(0, 31);
            this.rentPeriod.TabIndex = 14;
            this.rentPeriod.Visible = false;
            // 
            // rent
            // 
            this.rent.BackColor = System.Drawing.Color.DarkRed;
            this.rent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rent.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.rent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rent.Location = new System.Drawing.Point(158, 489);
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(675, 36);
            this.rent.TabIndex = 15;
            this.rent.Text = "Rent";
            this.rent.UseVisualStyleBackColor = false;
            this.rent.Visible = false;
            this.rent.Click += new System.EventHandler(this.rent_Click);
            // 
            // ivod
            // 
            this.ivod.AutoSize = true;
            this.ivod.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.ivod.ForeColor = System.Drawing.Color.Red;
            this.ivod.Location = new System.Drawing.Point(327, 379);
            this.ivod.Name = "ivod";
            this.ivod.Size = new System.Drawing.Size(367, 40);
            this.ivod.TabIndex = 16;
            this.ivod.Text = "Invalid Value Of Days";
            this.ivod.Visible = false;
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 546);
            this.Controls.Add(this.ivod);
            this.Controls.Add(this.rent);
            this.Controls.Add(this.rentPeriod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carName);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.days);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "RentForm";
            this.Text = "RentForm";
            this.Load += new System.EventHandler(this.RentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox days;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label carName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rentPeriod;
        private System.Windows.Forms.Button rent;
        private System.Windows.Forms.Label ivod;
    }
}