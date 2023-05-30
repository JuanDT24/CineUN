namespace Cine
{
    partial class Taquilla
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Taquilla));
            this.peli4 = new System.Windows.Forms.Button();
            this.peli2 = new System.Windows.Forms.Button();
            this.peli3 = new System.Windows.Forms.Button();
            this.peli5 = new System.Windows.Forms.Button();
            this.peli6 = new System.Windows.Forms.Button();
            this.peli1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peli4
            // 
            this.peli4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peli4.Image = global::Cine.Properties.Resources.fast1;
            this.peli4.Location = new System.Drawing.Point(145, 442);
            this.peli4.Margin = new System.Windows.Forms.Padding(4);
            this.peli4.Name = "peli4";
            this.peli4.Size = new System.Drawing.Size(332, 382);
            this.peli4.TabIndex = 3;
            this.peli4.UseVisualStyleBackColor = true;
            this.peli4.Click += new System.EventHandler(this.peli4_Click);
            // 
            // peli2
            // 
            this.peli2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peli2.Image = global::Cine.Properties.Resources.ultima;
            this.peli2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.peli2.Location = new System.Drawing.Point(733, 27);
            this.peli2.Margin = new System.Windows.Forms.Padding(4);
            this.peli2.Name = "peli2";
            this.peli2.Size = new System.Drawing.Size(332, 382);
            this.peli2.TabIndex = 4;
            this.peli2.UseVisualStyleBackColor = true;
            this.peli2.Click += new System.EventHandler(this.peli2_Click);
            // 
            // peli3
            // 
            this.peli3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peli3.Image = global::Cine.Properties.Resources.suzume_cartelera;
            this.peli3.Location = new System.Drawing.Point(1299, 27);
            this.peli3.Margin = new System.Windows.Forms.Padding(4);
            this.peli3.Name = "peli3";
            this.peli3.Size = new System.Drawing.Size(332, 382);
            this.peli3.TabIndex = 5;
            this.peli3.UseVisualStyleBackColor = true;
            this.peli3.Click += new System.EventHandler(this.peli3_Click);
            // 
            // peli5
            // 
            this.peli5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peli5.Image = global::Cine.Properties.Resources.spidermanpeq;
            this.peli5.Location = new System.Drawing.Point(733, 442);
            this.peli5.Margin = new System.Windows.Forms.Padding(4);
            this.peli5.Name = "peli5";
            this.peli5.Size = new System.Drawing.Size(332, 382);
            this.peli5.TabIndex = 6;
            this.peli5.UseVisualStyleBackColor = true;
            this.peli5.Click += new System.EventHandler(this.peli5_Click);
            // 
            // peli6
            // 
            this.peli6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peli6.Image = ((System.Drawing.Image)(resources.GetObject("peli6.Image")));
            this.peli6.Location = new System.Drawing.Point(1299, 442);
            this.peli6.Margin = new System.Windows.Forms.Padding(4);
            this.peli6.Name = "peli6";
            this.peli6.Size = new System.Drawing.Size(332, 382);
            this.peli6.TabIndex = 7;
            this.peli6.UseVisualStyleBackColor = true;
            this.peli6.Click += new System.EventHandler(this.peli6_Click);
            // 
            // peli1
            // 
            this.peli1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peli1.Image = global::Cine.Properties.Resources.avatar1;
            this.peli1.Location = new System.Drawing.Point(145, 27);
            this.peli1.Margin = new System.Windows.Forms.Padding(4);
            this.peli1.Name = "peli1";
            this.peli1.Size = new System.Drawing.Size(332, 382);
            this.peli1.TabIndex = 8;
            this.peli1.UseVisualStyleBackColor = true;
            this.peli1.Click += new System.EventHandler(this.peli1_Click);
            // 
            // Taquilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cine.Properties.Resources._87281;
            this.ClientSize = new System.Drawing.Size(1920, 1055);
            this.Controls.Add(this.peli1);
            this.Controls.Add(this.peli6);
            this.Controls.Add(this.peli5);
            this.Controls.Add(this.peli3);
            this.Controls.Add(this.peli2);
            this.Controls.Add(this.peli4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Taquilla";
            this.Text = "Taquilla";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Taquilla_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button peli4;
        private System.Windows.Forms.Button peli2;
        private System.Windows.Forms.Button peli3;
        private System.Windows.Forms.Button peli5;
        private System.Windows.Forms.Button peli6;
        private System.Windows.Forms.Button peli1;
    }
}

