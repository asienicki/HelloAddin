using Microsoft.Office.Tools.Ribbon;

namespace HelloAddin
{
public partial class SunTab
{
    private void BtnCheckWeather(object sender, RibbonControlEventArgs e)
    {
        ShowForm();
    }

    private HelloForm _form1;

    private void ShowForm()
    {
        if (_form1 == null)
        {
            _form1 = new HelloForm();
        }

        _form1.ShowDialog();
    }
}
}
