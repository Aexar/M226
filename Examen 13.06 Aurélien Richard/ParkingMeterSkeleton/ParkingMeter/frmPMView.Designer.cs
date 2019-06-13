namespace ParkingMeter {
  partial class frmPMView {
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
      this.cbxVehicleType = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lblDuration = new System.Windows.Forms.Label();
      this.cbxDuration = new System.Windows.Forms.ComboBox();
      this.tbxNumberPlate = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.btnOK = new System.Windows.Forms.Button();
      this.tbxTicket = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cbxVehicleType
      // 
      this.cbxVehicleType.FormattingEnabled = true;
      this.cbxVehicleType.Location = new System.Drawing.Point(108, 16);
      this.cbxVehicleType.Name = "cbxVehicleType";
      this.cbxVehicleType.Size = new System.Drawing.Size(193, 21);
      this.cbxVehicleType.TabIndex = 1;
      this.cbxVehicleType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxGeneric_KeyPress);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(89, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Type de véhicule";
      // 
      // lblDuration
      // 
      this.lblDuration.AutoSize = true;
      this.lblDuration.Location = new System.Drawing.Point(12, 113);
      this.lblDuration.Name = "lblDuration";
      this.lblDuration.Size = new System.Drawing.Size(61, 13);
      this.lblDuration.TabIndex = 0;
      this.lblDuration.Text = "Durée [min]";
      // 
      // cbxDuration
      // 
      this.cbxDuration.FormattingEnabled = true;
      this.cbxDuration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cbxDuration.Location = new System.Drawing.Point(108, 105);
      this.cbxDuration.Name = "cbxDuration";
      this.cbxDuration.Size = new System.Drawing.Size(193, 21);
      this.cbxDuration.TabIndex = 3;
      this.cbxDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxGeneric_KeyPress);
      // 
      // tbxNumberPlate
      // 
      this.tbxNumberPlate.Location = new System.Drawing.Point(108, 62);
      this.tbxNumberPlate.MaxLength = 20;
      this.tbxNumberPlate.Name = "tbxNumberPlate";
      this.tbxNumberPlate.Size = new System.Drawing.Size(193, 20);
      this.tbxNumberPlate.TabIndex = 2;
      this.tbxNumberPlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRegistrationNumber_KeyPress);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 69);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(77, 13);
      this.label4.TabIndex = 0;
      this.label4.Text = "Immatriculation";
      // 
      // btnOK
      // 
      this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnOK.Location = new System.Drawing.Point(146, 166);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(121, 45);
      this.btnOK.TabIndex = 4;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // tbxTicket
      // 
      this.tbxTicket.BackColor = System.Drawing.SystemColors.Window;
      this.tbxTicket.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxTicket.Location = new System.Drawing.Point(332, 24);
      this.tbxTicket.Multiline = true;
      this.tbxTicket.Name = "tbxTicket";
      this.tbxTicket.ReadOnly = true;
      this.tbxTicket.Size = new System.Drawing.Size(417, 187);
      this.tbxTicket.TabIndex = 0;
      this.tbxTicket.TabStop = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(520, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Ticket";
      // 
      // frmPMView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(761, 224);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbxTicket);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.tbxNumberPlate);
      this.Controls.Add(this.cbxDuration);
      this.Controls.Add(this.lblDuration);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cbxVehicleType);
      this.Name = "frmPMView";
      this.Text = "Parcmètre V4";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cbxVehicleType;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblDuration;
    private System.Windows.Forms.ComboBox cbxDuration;
    private System.Windows.Forms.TextBox tbxNumberPlate;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.TextBox tbxTicket;
    private System.Windows.Forms.Label label2;
  }
}

