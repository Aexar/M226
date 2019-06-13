/* $Id: Program.cs 370 2019-05-21 17:15:58Z marechal $ */
/* CFPT-EI M226
Project : ParkingMeter (MV, Object Oriented Development, Unit tests)
Author : C. Marechal
Description : 
*/
using System;
using System.Windows.Forms;

namespace ParkingMeter {
  static class Program {
    /// <summary>
    /// Point d'entrée principal de l'application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new frmPMView());
    }
  }
}
