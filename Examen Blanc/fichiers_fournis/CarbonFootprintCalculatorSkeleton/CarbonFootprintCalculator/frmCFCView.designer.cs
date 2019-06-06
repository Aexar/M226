namespace CarbonFootprintCalculator {
  partial class frmCFCView
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
            this.gbxCourse = new System.Windows.Forms.GroupBox();
            this.cbxDestination = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblFromGva = new System.Windows.Forms.Label();
            this.gbxVehicles = new System.Windows.Forms.GroupBox();
            this.cbxClassePlane = new System.Windows.Forms.ComboBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.rbtTrain = new System.Windows.Forms.RadioButton();
            this.rbtPlane = new System.Windows.Forms.RadioButton();
            this.gbxCarbonFootprint = new System.Windows.Forms.GroupBox();
            this.lblCarbonFootprintResult = new System.Windows.Forms.Label();
            this.btnCarbonFootprintCalc = new System.Windows.Forms.Button();
            this.gbxCourse.SuspendLayout();
            this.gbxVehicles.SuspendLayout();
            this.gbxCarbonFootprint.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCourse
            // 
            this.gbxCourse.Controls.Add(this.cbxDestination);
            this.gbxCourse.Controls.Add(this.lblDestination);
            this.gbxCourse.Controls.Add(this.lblFromGva);
            this.gbxCourse.Location = new System.Drawing.Point(12, 12);
            this.gbxCourse.Name = "gbxCourse";
            this.gbxCourse.Size = new System.Drawing.Size(192, 138);
            this.gbxCourse.TabIndex = 0;
            this.gbxCourse.TabStop = false;
            this.gbxCourse.Text = "Parcours";
            // 
            // cbxDestination
            // 
            this.cbxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDestination.FormattingEnabled = true;
            this.cbxDestination.Location = new System.Drawing.Point(47, 87);
            this.cbxDestination.Name = "cbxDestination";
            this.cbxDestination.Size = new System.Drawing.Size(115, 21);
            this.cbxDestination.TabIndex = 5;
            this.cbxDestination.SelectedValueChanged += new System.EventHandler(this.cbxDestination_SelectedValueChanged);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(18, 90);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(23, 13);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "A : ";
            // 
            // lblFromGva
            // 
            this.lblFromGva.AutoSize = true;
            this.lblFromGva.Location = new System.Drawing.Point(18, 40);
            this.lblFromGva.Name = "lblFromGva";
            this.lblFromGva.Size = new System.Drawing.Size(74, 13);
            this.lblFromGva.TabIndex = 3;
            this.lblFromGva.Text = "De :   Genève";
            // 
            // gbxVehicles
            // 
            this.gbxVehicles.Controls.Add(this.cbxClassePlane);
            this.gbxVehicles.Controls.Add(this.lblClasse);
            this.gbxVehicles.Controls.Add(this.rbtTrain);
            this.gbxVehicles.Controls.Add(this.rbtPlane);
            this.gbxVehicles.Location = new System.Drawing.Point(224, 12);
            this.gbxVehicles.Name = "gbxVehicles";
            this.gbxVehicles.Size = new System.Drawing.Size(238, 138);
            this.gbxVehicles.TabIndex = 1;
            this.gbxVehicles.TabStop = false;
            this.gbxVehicles.Text = "Moyen de transport";
            // 
            // cbxClassePlane
            // 
            this.cbxClassePlane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClassePlane.FormattingEnabled = true;
            this.cbxClassePlane.Location = new System.Drawing.Point(98, 36);
            this.cbxClassePlane.Name = "cbxClassePlane";
            this.cbxClassePlane.Size = new System.Drawing.Size(103, 21);
            this.cbxClassePlane.TabIndex = 6;
            this.cbxClassePlane.SelectedValueChanged += new System.EventHandler(this.cbxDestination_SelectedValueChanged);
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(131, 21);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(38, 13);
            this.lblClasse.TabIndex = 4;
            this.lblClasse.Text = "Classe";
            // 
            // rbtTrain
            // 
            this.rbtTrain.AutoSize = true;
            this.rbtTrain.Checked = true;
            this.rbtTrain.Location = new System.Drawing.Point(21, 86);
            this.rbtTrain.Name = "rbtTrain";
            this.rbtTrain.Size = new System.Drawing.Size(49, 17);
            this.rbtTrain.TabIndex = 1;
            this.rbtTrain.TabStop = true;
            this.rbtTrain.Text = "Train";
            this.rbtTrain.UseVisualStyleBackColor = true;
            this.rbtTrain.Click += new System.EventHandler(this.rbtPlane_Click);
            // 
            // rbtPlane
            // 
            this.rbtPlane.AutoSize = true;
            this.rbtPlane.Location = new System.Drawing.Point(21, 36);
            this.rbtPlane.Name = "rbtPlane";
            this.rbtPlane.Size = new System.Drawing.Size(52, 17);
            this.rbtPlane.TabIndex = 0;
            this.rbtPlane.Text = "Avion";
            this.rbtPlane.UseVisualStyleBackColor = true;
            this.rbtPlane.CheckedChanged += new System.EventHandler(this.rbtPlane_CheckedChanged);
            this.rbtPlane.Click += new System.EventHandler(this.rbtPlane_Click);
            // 
            // gbxCarbonFootprint
            // 
            this.gbxCarbonFootprint.Controls.Add(this.lblCarbonFootprintResult);
            this.gbxCarbonFootprint.Location = new System.Drawing.Point(12, 225);
            this.gbxCarbonFootprint.Name = "gbxCarbonFootprint";
            this.gbxCarbonFootprint.Size = new System.Drawing.Size(450, 80);
            this.gbxCarbonFootprint.TabIndex = 2;
            this.gbxCarbonFootprint.TabStop = false;
            this.gbxCarbonFootprint.Text = "Empreinte carbone du parcours (aller simple et par personne)";
            // 
            // lblCarbonFootprintResult
            // 
            this.lblCarbonFootprintResult.AutoSize = true;
            this.lblCarbonFootprintResult.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbonFootprintResult.Location = new System.Drawing.Point(17, 32);
            this.lblCarbonFootprintResult.Name = "lblCarbonFootprintResult";
            this.lblCarbonFootprintResult.Size = new System.Drawing.Size(65, 24);
            this.lblCarbonFootprintResult.TabIndex = 0;
            this.lblCarbonFootprintResult.Text = "label5";
            this.lblCarbonFootprintResult.Visible = false;
            // 
            // btnCarbonFootprintCalc
            // 
            this.btnCarbonFootprintCalc.Location = new System.Drawing.Point(12, 167);
            this.btnCarbonFootprintCalc.Name = "btnCarbonFootprintCalc";
            this.btnCarbonFootprintCalc.Size = new System.Drawing.Size(450, 38);
            this.btnCarbonFootprintCalc.TabIndex = 0;
            this.btnCarbonFootprintCalc.Text = "Calculer l\'empreinte carbone";
            this.btnCarbonFootprintCalc.UseVisualStyleBackColor = true;
            this.btnCarbonFootprintCalc.Click += new System.EventHandler(this.btnCarbonFootprintCalc_Click);
            // 
            // frmCFCView
            // 
            this.AcceptButton = this.btnCarbonFootprintCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 320);
            this.Controls.Add(this.btnCarbonFootprintCalc);
            this.Controls.Add(this.gbxCarbonFootprint);
            this.Controls.Add(this.gbxVehicles);
            this.Controls.Add(this.gbxCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCFCView";
            this.Text = "Calculateur d\'empreinte carbone";
            this.Load += new System.EventHandler(this.frmCFCView_Load);
            this.gbxCourse.ResumeLayout(false);
            this.gbxCourse.PerformLayout();
            this.gbxVehicles.ResumeLayout(false);
            this.gbxVehicles.PerformLayout();
            this.gbxCarbonFootprint.ResumeLayout(false);
            this.gbxCarbonFootprint.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gbxCourse;
    private System.Windows.Forms.ComboBox cbxDestination;
    private System.Windows.Forms.Label lblDestination;
    private System.Windows.Forms.Label lblFromGva;
    private System.Windows.Forms.GroupBox gbxVehicles;
    private System.Windows.Forms.ComboBox cbxClassePlane;
    private System.Windows.Forms.Label lblClasse;
    private System.Windows.Forms.RadioButton rbtTrain;
    private System.Windows.Forms.RadioButton rbtPlane;
    private System.Windows.Forms.GroupBox gbxCarbonFootprint;
    private System.Windows.Forms.Label lblCarbonFootprintResult;
    private System.Windows.Forms.Button btnCarbonFootprintCalc;
  }
}

