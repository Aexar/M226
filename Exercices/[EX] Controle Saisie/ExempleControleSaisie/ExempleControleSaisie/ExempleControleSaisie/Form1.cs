/// M226, I.DA-D3A
/// C. Marechal, 14/03/19
/// exemple de contrôle de saisie, touches autorisées : 
///  - chiffres
///  - un seul point (point décimal)
///  - Backspace
///  - Delete
using System.Windows.Forms;

namespace ExempleControleSaisie {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void textBox2_KeyPress(object sender, KeyPressEventArgs e) {
      // check if a decimal separator (point, comma...according culture) is already in tebDisplay control
      if (e.KeyChar == '.' &&
          (sender as TextBox).Text.Contains(".")) {
        e.Handled = true;
      } else
        //// authorized chararacters : 0 1 2 3 4 5 6 7 8 9 DecimalSeparator Backspace
        if (((e.KeyChar < '0') || (e.KeyChar > '9')) &&
            (e.KeyChar != (char)Keys.Delete) &&
            (e.KeyChar != (char)Keys.Back)) {
        // Stop the character outside authorized characters
        e.Handled = true;
      }
      return;
    }

  }
}

