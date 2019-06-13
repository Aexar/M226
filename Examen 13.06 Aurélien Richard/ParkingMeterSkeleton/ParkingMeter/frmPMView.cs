/* $Id: frmPMView.cs 386 2019-06-11 11:59:46Z marechal $ */
/* CFPT-EI M226
Project : ParkingMeter (MV, Object Oriented Development, Unit tests)
Author : C. Marechal
Description : View class

DO NOT MODIFY THIS FILE
*/
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParkingMeter {
  public partial class frmPMView : Form {
    private PMModel _model;
    private PMModel Model { get => _model; set => _model = value; }

    public frmPMView() {
      InitializeComponent();
      this.Model = new PMModel();

      // clear combobox items
      cbxVehicleType.Items.Clear();

      // populate combobox with data from Model
      this.populateVehiculeTypeCombobox(cbxVehicleType, this.Model.VehicleRates); // was this.Model.VehiculeRates. Modified with consent of teacher!
      this.populateDurationCombobox(cbxDuration, this.Model.AvailableDurations);
    }

    /// <summary>
    /// populate Combobox with model infos (vehicle types)
    /// </summary>
    /// <param name="pCbx"></param>
    /// <param name="pVehiculeRates"></param>
    private void populateVehiculeTypeCombobox(ComboBox pCbx, List<VehicleRate> pVehiculeRates) {
      foreach (VehicleRate item in pVehiculeRates) {
        pCbx.Items.Add(String.Format("{0}", item.Name)); // was pCbx.Items.Add(String.Format("{0}", item));, so items would show up and not names. Modified with consent of teacher ! 
      }
    }

    /// <summary>
    /// populate Combobox with model infos (parking durations)
    /// </summary>
    /// <param name="pCbx"></param>
    /// <param name="pVehiculeRates"></param>
    private void populateDurationCombobox(ComboBox pbx, List<int> pDurations) {
      foreach (int duration in pDurations) {
        pbx.Items.Add(duration);
      }
    }

    /// <summary>
    /// Callback for filtering characters of registration number : 
    /// - convert to UpperCase
    /// - only letters (A-Z) and numbers (0-9)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void tbxRegistrationNumber_KeyPress(object sender, KeyPressEventArgs e) {
      // tbx.MaxLength characters max
      e.KeyChar = Char.ToUpper(e.KeyChar);
      if (((e.KeyChar < '0') || (e.KeyChar > '9')) &&
        ((e.KeyChar < 'A') || (e.KeyChar > 'Z')) &&
          (e.KeyChar != (char)Keys.Back)) {
        // Stop the character outside authorized characters
        e.Handled = true;
      }
      return;
    }

    /// <summary>
    /// OK button callback : 
    /// - call the Model for generating the ticket
    /// - display the ticket
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnOK_Click(object sender, EventArgs e) {
      Ticket ticket = this.Model.GenerateTicket(this.cbxVehicleType.SelectedIndex,
                                                this.cbxDuration.SelectedIndex);
      tbxTicket.Text = ticket.Display(tbxNumberPlate.Text);
    }

    /// <summary>
    /// Dummy keypress handler to avoid manual input in ComboBox
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void cbxGeneric_KeyPress(object sender, KeyPressEventArgs e) {
      e.Handled = true;
    }
  }
}
