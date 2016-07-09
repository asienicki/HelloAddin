using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;

namespace HelloAddin
{
    public partial class HelloForm : Form
    {
        private readonly AppointmentItem _appointmentItem;

        public HelloForm(AppointmentItem appointmentItem)
        {
            _appointmentItem = appointmentItem;
            InitializeComponent();
        }

        private void ButtonPrintTemperature(object sender, EventArgs e)
        {
            MessageBox.Show($"Dzień dobry! Dziś na dworzu {ageNumeric.Value} stopni :)");
        }
    }
}
