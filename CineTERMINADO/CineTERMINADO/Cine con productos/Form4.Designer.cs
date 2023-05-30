namespace Cine
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelprec = new System.Windows.Forms.Label();
            this.nombreG = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 374);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "COMPRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelprec
            // 
            this.labelprec.AutoSize = true;
            this.labelprec.Location = new System.Drawing.Point(151, 224);
            this.labelprec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelprec.Name = "labelprec";
            this.labelprec.Size = new System.Drawing.Size(76, 16);
            this.labelprec.TabIndex = 1;
            this.labelprec.Text = "CANTIDAD";
            // 
            // nombreG
            // 
            this.nombreG.AutoSize = true;
            this.nombreG.Location = new System.Drawing.Point(60, 106);
            this.nombreG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreG.Name = "nombreG";
            this.nombreG.Size = new System.Drawing.Size(66, 16);
            this.nombreG.TabIndex = 2;
            this.nombreG.Text = "NOMBRE";
            // 
            // cantidad
            // 
            this.cantidad.AutoSize = true;
            this.cantidad.Location = new System.Drawing.Point(151, 170);
            this.cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(52, 16);
            this.cantidad.TabIndex = 3;
            this.cantidad.Text = "VALOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "VALOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "CANTIDAD";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1081, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.nombreG);
            this.Controls.Add(this.labelprec);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelprec;
        private System.Windows.Forms.Label nombreG;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}