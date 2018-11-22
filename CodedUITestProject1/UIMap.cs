namespace CodedUITestProject1
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;


    public partial class UIMap
    {
        public UIMap()
        {
            this.UIMainWindowWindow.UIStartButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "buttonA";
        }

        /// <summary>
        /// SimpleAppTest - Use 'SimpleAppTestParams' to pass parameters into this method.
        /// </summary>
        public void ModifiedSimpleAppTest()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            WinButton uICloseButton = this.UIMainWindowWindow1.UICloseButton;
            #endregion

            //// Launch '%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\devenv.exe' with arguments '"C:\Users\STUDENT\source\repos\WpfApp1\WpfApp1.sln"'
            //ApplicationUnderTest devenvApplication = ApplicationUnderTest.Launch(this.SimpleAppTestParams.ExePath, this.SimpleAppTestParams.AlternateExePath, "\"C:\\Users\\STUDENT\\source\\repos\\WpfApp1\\WpfApp1.sln\"");

            // Launch '%USERPROFILE%\source\repos\WpfApp1\WpfApp1\bin\Debug\WpfApp1.exe'
            ApplicationUnderTest uIMainWindowWindow = ApplicationUnderTest.Launch(this.SimpleAppTestParams.UIMainWindowWindowExePath, this.SimpleAppTestParams.UIMainWindowWindowAlternateExePath);

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(47, 9));

            uICheckBoxCheckBox.WaitForControlEnabled();

            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.SimpleAppTestParams.UICheckBoxCheckBoxChecked;

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(8, 18));
        }

        public virtual SimpleAppTestParams SimpleAppTestParams
        {
            get
            {
                if ((this.mSimpleAppTestParams == null))
                {
                    this.mSimpleAppTestParams = new SimpleAppTestParams();
                }
                return this.mSimpleAppTestParams;
            }
        }

        private SimpleAppTestParams mSimpleAppTestParams;
    }
    /// <summary>
    /// Parameters to be passed into 'SimpleAppTest'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class SimpleAppTestParams
    {

        #region Fields
        /// <summary>
        /// Launch '%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\devenv.exe' with arguments '"C:\Users\STUDENT\source\repos\WpfApp1\WpfApp1.sln"'
        /// </summary>
        public string ExePath = "C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\Common7\\IDE\\devenv" +
            ".exe";

        /// <summary>
        /// Launch '%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\devenv.exe' with arguments '"C:\Users\STUDENT\source\repos\WpfApp1\WpfApp1.sln"'
        /// </summary>
        public string AlternateExePath = "%ProgramFiles(x86)%\\Microsoft Visual Studio\\2017\\Enterprise\\Common7\\IDE\\devenv.ex" +
            "e";

        /// <summary>
        /// Launch '%USERPROFILE%\source\repos\WpfApp1\WpfApp1\bin\Debug\WpfApp1.exe'
        /// </summary>
        public string UIMainWindowWindowExePath = "C:\\Users\\STUDENT\\source\\repos\\WpfApp1\\WpfApp1\\bin\\Debug\\WpfApp1.exe";

        /// <summary>
        /// Launch '%USERPROFILE%\source\repos\WpfApp1\WpfApp1\bin\Debug\WpfApp1.exe'
        /// </summary>
        public string UIMainWindowWindowAlternateExePath = "%USERPROFILE%\\source\\repos\\WpfApp1\\WpfApp1\\bin\\Debug\\WpfApp1.exe";

        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;
        #endregion
    }
}
