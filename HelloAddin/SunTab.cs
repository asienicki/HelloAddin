using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;

namespace HelloAddin
{
    public partial class SunTab
    {
        private void SunTab_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnCheckWeather(object sender, RibbonControlEventArgs e)
        {
            MessageBox.Show("Jutro znowu gorąco! Kup klimę albo będziesz zdychał :)");
        }
    }
}
