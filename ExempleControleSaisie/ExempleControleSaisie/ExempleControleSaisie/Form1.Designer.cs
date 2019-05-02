namespace ExempleControleSaisie {
  partial class Form1 {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent() {
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(46, 42);
      this.textBox2.Name = "textBox2";
      this.textBox2.ShortcutsEnabled = false;
      this.textBox2.Size = new System.Drawing.Size(100, 20);
      this.textBox2.TabIndex = 3;
      this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(46, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(282, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "On ne peut entrer que des chiffres et un seul point décimal";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(340, 320);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox2);
      this.Name = "Form1";
      this.Text = "Exemple de contrôle de saisie";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label1;
  }
}

