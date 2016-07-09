using System;
using System.Windows.Forms;

namespace HelloAddin
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void ButtonPrintTemperature(object sender, EventArgs e)
        {
            MessageBox.Show($"Dzień dobry! Dziś na dworzu {ageNumeric.Value} stopni :)");
        }
    }
}
