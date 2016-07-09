namespace HelloAddin
{
    partial class SunTab : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public SunTab()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.weatherTab = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.weatherTab.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // weatherTab
            // 
            this.weatherTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.weatherTab.ControlId.OfficeId = "TabAppointment";
            this.weatherTab.Groups.Add(this.group1);
            this.weatherTab.Label = "TabAppointment";
            this.weatherTab.Name = "weatherTab";
            // 
            // group1
            // 
            this.group1.Items.Add(this.button1);
            this.group1.Label = "Pogodynka";
            this.group1.Name = "group1";
            // 
            // button1
            // 
            this.button1.Image = global::HelloAddin.Properties.Resources.sun;
            this.button1.Label = "Sprawdź pogodę";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnCheckWeather);
            // 
            // SunTab
            // 
            this.Name = "SunTab";
            this.RibbonType = "Microsoft.Outlook.Appointment, Microsoft.Outlook.MeetingRequest.Send";
            this.Tabs.Add(this.weatherTab);
            this.weatherTab.ResumeLayout(false);
            this.weatherTab.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab weatherTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
    }

    partial class ThisRibbonCollection
    {
        internal SunTab SunTab
        {
            get { return this.GetRibbon<SunTab>(); }
        }
    }
}
