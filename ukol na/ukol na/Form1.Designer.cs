
namespace ukol_na
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.prevod = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelprumer = new System.Windows.Forms.Label();
            this.labelmin = new System.Windows.Forms.Label();
            this.labelinterval = new System.Windows.Forms.Label();
            this.labelprvni3 = new System.Windows.Forms.Label();
            this.labelposledni3 = new System.Windows.Forms.Label();
            this.labelsoucet = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prevod
            // 
            this.prevod.BackColor = System.Drawing.Color.PowderBlue;
            this.prevod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prevod.Location = new System.Drawing.Point(12, 358);
            this.prevod.Name = "prevod";
            this.prevod.Size = new System.Drawing.Size(520, 68);
            this.prevod.TabIndex = 0;
            this.prevod.Text = "Převod";
            this.prevod.UseVisualStyleBackColor = false;
            this.prevod.Click += new System.EventHandler(this.prevod_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Azure;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(17, 112);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 219);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(167, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Průměr čisel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(167, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minimální číslo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(167, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Počet čísel v intervalu <5,30)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(167, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "První pozice čísla 3 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(167, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Poslední pozice čísla 3 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(167, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Součet čísel:";
            // 
            // labelprumer
            // 
            this.labelprumer.AutoSize = true;
            this.labelprumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelprumer.Location = new System.Drawing.Point(422, 109);
            this.labelprumer.Name = "labelprumer";
            this.labelprumer.Size = new System.Drawing.Size(20, 18);
            this.labelprumer.TabIndex = 8;
            this.labelprumer.Text = "...";
            // 
            // labelmin
            // 
            this.labelmin.AutoSize = true;
            this.labelmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelmin.Location = new System.Drawing.Point(422, 150);
            this.labelmin.Name = "labelmin";
            this.labelmin.Size = new System.Drawing.Size(20, 18);
            this.labelmin.TabIndex = 9;
            this.labelmin.Text = "...";
            // 
            // labelinterval
            // 
            this.labelinterval.AutoSize = true;
            this.labelinterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelinterval.Location = new System.Drawing.Point(422, 193);
            this.labelinterval.Name = "labelinterval";
            this.labelinterval.Size = new System.Drawing.Size(20, 18);
            this.labelinterval.TabIndex = 10;
            this.labelinterval.Text = "...";
            // 
            // labelprvni3
            // 
            this.labelprvni3.AutoSize = true;
            this.labelprvni3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelprvni3.Location = new System.Drawing.Point(422, 233);
            this.labelprvni3.Name = "labelprvni3";
            this.labelprvni3.Size = new System.Drawing.Size(20, 18);
            this.labelprvni3.TabIndex = 11;
            this.labelprvni3.Text = "...";
            // 
            // labelposledni3
            // 
            this.labelposledni3.AutoSize = true;
            this.labelposledni3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelposledni3.Location = new System.Drawing.Point(422, 277);
            this.labelposledni3.Name = "labelposledni3";
            this.labelposledni3.Size = new System.Drawing.Size(20, 18);
            this.labelposledni3.TabIndex = 12;
            this.labelposledni3.Text = "...";
            // 
            // labelsoucet
            // 
            this.labelsoucet.AutoSize = true;
            this.labelsoucet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelsoucet.Location = new System.Drawing.Point(422, 311);
            this.labelsoucet.Name = "labelsoucet";
            this.labelsoucet.Size = new System.Drawing.Size(20, 18);
            this.labelsoucet.TabIndex = 13;
            this.labelsoucet.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(11, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(460, 50);
            this.label7.TabIndex = 14;
            this.label7.Text = "Do textboxu zadej čísla s kterými chceš počítat\r\n a poté klikní na tlačítko Převo" +
    "d pro výpočet ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Textbox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelsoucet);
            this.Controls.Add(this.labelposledni3);
            this.Controls.Add(this.labelprvni3);
            this.Controls.Add(this.labelinterval);
            this.Controls.Add(this.labelmin);
            this.Controls.Add(this.labelprumer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.prevod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prevod;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelprumer;
        private System.Windows.Forms.Label labelmin;
        private System.Windows.Forms.Label labelinterval;
        private System.Windows.Forms.Label labelprvni3;
        private System.Windows.Forms.Label labelposledni3;
        private System.Windows.Forms.Label labelsoucet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

