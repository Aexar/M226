/// \file frmCFCView.cs
/// \brief M226 exam, Carbon Footprint Calculator (MV, Object Oriented Development, Unit tests)
/// \author A. Beney, C. Marechal, CFPTI
/// \date $Id: frmCFCView.cs 336 2019-03-25 20:36:45Z marechal $
using System;
using System.Windows.Forms;

namespace CarbonFootprintCalculator {
  /// <summary>
  /// View class (for an MV design pattern)
  /// </summary>
  public partial class frmCFCView : Form {
    // Fields
    private CFCModel _model;

    // Properties
    internal CFCModel Model {
      get { return _model; }
      set { _model = value; }
    }

    /// <summary>
    /// designated constructor
    /// - Model instanciation
    /// </summary>
    public frmCFCView() {
      InitializeComponent();
      this.Model = new CFCModel();
    }

    /// <summary>
    /// View load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void frmCFCView_Load(object sender, EventArgs e) {
      this.InitCbxOfView();
      rbtPlane.Checked = true;
      lblCarbonFootprintResult.Visible = false;
      this.ControlsManagement();
    }

    /// <summary>
    /// Populate comboboxes with data from Model
    /// </summary>
    private void InitCbxOfView() {
      foreach (Destination d in this.Model.Destinations) {
        cbxDestination.Items.Add(d.City);
      }

      foreach (string theClasse in this.Model.TravelModeByPlane.AvailableTravelClasses) {
        cbxClassePlane.Items.Add(theClasse);
      }
    }

    /// <summary>
    /// - call Model methods for calculating CarbonFootprint
    /// - display CarbonFootPrint for the travel selected on the GUI
    /// - format the string and convert in kg
    /// </summary>
    private void UpdateView() {
      double carbonFootprint = -1.0;
      string destination = cbxDestination.SelectedItem.ToString();

      if (rbtTrain.Checked)
        carbonFootprint = this.Model.GetCarbonFootprintByTrain(destination);

      if (rbtPlane.Checked) {
        string travelClass = cbxClassePlane.SelectedItem.ToString();
        carbonFootprint = this.Model.GetCarbonFootprintByPlane(destination, travelClass);
      }

      carbonFootprint /= 1000;  // g to kg conversion

      lblCarbonFootprintResult.Visible = true;
      lblCarbonFootprintResult.Text = string.Format("{0:n1} kg de CO2", carbonFootprint);
    }

    private void btnCarbonFootprintCalc_Click(object sender, EventArgs e) {
      UpdateView();
    }

    /// <summary>
    /// Method for enabling/disabling controls according to user choices
    /// </summary>
    private void ControlsManagement() {
      lblCarbonFootprintResult.Text = string.Empty;
      btnCarbonFootprintCalc.Enabled = false;

      if ((rbtPlane.Checked) && (cbxClassePlane.SelectedItem != null) && (cbxDestination.SelectedItem != null))
        btnCarbonFootprintCalc.Enabled = true;

      if ((rbtTrain.Checked) && (cbxDestination.SelectedItem != null))
        btnCarbonFootprintCalc.Enabled = true;

      if (rbtPlane.Checked)
        cbxClassePlane.Enabled = true;
      else
        cbxClassePlane.Enabled = false;
    }

    private void cbxDestination_SelectedValueChanged(object sender, EventArgs e) {
      this.ControlsManagement();
    }

    private void rbtPlane_Click(object sender, EventArgs e) {
      this.ControlsManagement();
    }

        private void rbtPlane_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
