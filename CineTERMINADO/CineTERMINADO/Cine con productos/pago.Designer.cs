namespace Cine
{
    partial class pago
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
            this.boleta_pagar = new System.Windows.Forms.Label();
            this.totaldul_pagarr = new System.Windows.Forms.Label();
            this.totalbo_pagar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Pelicula_pagar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boleta_pagar
            // 
            this.boleta_pagar.AutoSize = true;
            this.boleta_pagar.BackColor = System.Drawing.Color.White;
            this.boleta_pagar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boleta_pagar.Location = new System.Drawing.Point(99, 41);
            this.boleta_pagar.Name = "boleta_pagar";
            this.boleta_pagar.Size = new System.Drawing.Size(18, 18);
            this.boleta_pagar.TabIndex = 20;
            this.boleta_pagar.Text = "0";
            // 
            // totaldul_pagarr
            // 
            this.totaldul_pagarr.AutoSize = true;
            this.totaldul_pagarr.BackColor = System.Drawing.Color.White;
            this.totaldul_pagarr.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaldul_pagarr.Location = new System.Drawing.Point(174, 112);
            this.totaldul_pagarr.Name = "totaldul_pagarr";
            this.totaldul_pagarr.Size = new System.Drawing.Size(156, 18);
            this.totaldul_pagarr.TabIndex = 19;
            this.totaldul_pagarr.Text = "TOTAL DULCERIA:";
            // 
            // totalbo_pagar
            // 
            this.totalbo_pagar.AutoSize = true;
            this.totalbo_pagar.BackColor = System.Drawing.Color.White;
            this.totalbo_pagar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalbo_pagar.Location = new System.Drawing.Point(174, 79);
            this.totalbo_pagar.Name = "totalbo_pagar";
            this.totalbo_pagar.Size = new System.Drawing.Size(146, 18);
            this.totalbo_pagar.TabIndex = 18;
            this.totalbo_pagar.Text = "TOTAL BOLETAS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "BOLETAS";
            // 
            // Pelicula_pagar
            // 
            this.Pelicula_pagar.AutoSize = true;
            this.Pelicula_pagar.BackColor = System.Drawing.Color.White;
            this.Pelicula_pagar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pelicula_pagar.Location = new System.Drawing.Point(12, 9);
            this.Pelicula_pagar.Name = "Pelicula_pagar";
            this.Pelicula_pagar.Size = new System.Drawing.Size(87, 18);
            this.Pelicula_pagar.TabIndex = 16;
            this.Pelicula_pagar.Text = "PELICULA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "TOTAL DULCERIA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "TOTAL BOLETAS:";
            // 
            // pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boleta_pagar);
            this.Controls.Add(this.totaldul_pagarr);
            this.Controls.Add(this.totalbo_pagar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Pelicula_pagar);
            this.Name = "pago";
            this.Text = "pago";
            this.Load += new System.EventHandler(this.pago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label boleta_pagar;
        private System.Windows.Forms.Label totaldul_pagarr;
        private System.Windows.Forms.Label totalbo_pagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Pelicula_pagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}