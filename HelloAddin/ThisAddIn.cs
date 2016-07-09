namespace HelloAddin
{
using Outlook = Microsoft.Office.Interop.Outlook;

public partial class ThisAddIn
{
    Outlook.Inspectors _inspectors;
    public Outlook.AppointmentItem AppointmentItem;

    private void ThisAddIn_Startup(object sender, System.EventArgs e)
    {
        _inspectors = Application.Inspectors;
        _inspectors.NewInspector += Inspectors_NewInspector;
    }

    void Inspectors_NewInspector(Outlook.Inspector inspector)
    {
        var appointmentItem = inspector.CurrentItem as Outlook.AppointmentItem;

        if (appointmentItem != null)
        {
            AppointmentItem = appointmentItem;
        }
    }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see http://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
