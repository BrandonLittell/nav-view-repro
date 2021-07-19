using System;
using System.Collections.Generic;
using System.Text;

namespace NavViewSettingsBug
{
    public class Program
    {
        [System.STAThreadAttribute()]
        public static void Main()
        {
            using (new UwpApp.App())
            {
                NavViewSettingsBug.App app = new NavViewSettingsBug.App();
                app.InitializeComponent();
                app.Run();
            }
        }
    }
}
