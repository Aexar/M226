namespace CurrencyConverter
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvert = new System.Windows.Forms.Button();
            this.tbxRate = new System.Windows.Forms.TextBox();
            this.tbxSource = new System.Windows.Forms.TextBox();
            this.tbxDestination = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(101, 170);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "button1";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // tbxRate
            // 
            this.tbxRate.Location = new System.Drawing.Point(101, 42);
            this.tbxRate.Name = "tbxRate";
            this.tbxRate.Size = new System.Drawing.Size(100, 20);
            this.tbxRate.TabIndex = 1;
            // 
            // tbxSource
            // 
            this.tbxSource.Location = new System.Drawing.Point(101, 85);
            this.tbxSource.Name = "tbxSource";
            this.tbxSource.Size = new System.Drawing.Size(100, 20);
            this.tbxSource.TabIndex = 2;
            this.tbxSource.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSource_KeyPress);
            // 
            // tbxDestination
            // 
            this.tbxDestination.Location = new System.Drawing.Point(101, 128);
            this.tbxDestination.Name = "tbxDestination";
            this.tbxDestination.Size = new System.Drawing.Size(100, 20);
            this.tbxDestination.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxDestination);
            this.Controls.Add(this.tbxSource);
            this.Controls.Add(this.tbxRate);
            this.Controls.Add(this.btnConvert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox tbxRate;
        private System.Windows.Forms.TextBox tbxSource;
        private System.Windows.Forms.TextBox tbxDestination;
    }
}

