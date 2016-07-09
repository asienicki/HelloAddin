using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using Newtonsoft.Json;

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

            var properties = _appointmentItem.UserProperties;

            var secretData = new SecretData
            {
                Age = ageNumeric.Value
            };

            try
            {
                InitProperty(properties, secretData);
            }
            catch (UnauthorizedAccessException)
            {
                InitProperty(properties, secretData);
            }
        }

        private static void InitProperty(UserProperties properties, SecretData secretData)
        {
            var property = properties.Add("secretData", OlUserPropertyType.olText);

            property.Value = JsonConvert.SerializeObject(secretData);
        }
    }
}
