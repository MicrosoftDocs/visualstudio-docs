#region Using directives

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;


#endregion

namespace Trin_RibbonOutlookBasic
{
    // TODO:
    // This is an override of the RequestService method in ThisAddin class.
    // To hook up your custom ribbon uncomment this code.
    public partial class ThisAddIn
    {
        Ribbon1 ribbon;
        protected override object RequestService(Guid serviceGuid)
        {
            if (serviceGuid == typeof(Office.IRibbonExtensibility).GUID)
            {
                if (ribbon == null)
                    ribbon = new Ribbon1();
                return ribbon;
            }

            return base.RequestService(serviceGuid);
        }
    }


    [ComVisible(true)]
    public class Ribbon1 : Office.IRibbonExtensibility
    {

        #region fields

        private Office.IRibbonUI ribbon;

        #endregion


        #region Initialization

        public Ribbon1()
        {
        }

        //<Snippet1>
        public string GetCustomUI(string ribbonID)
        {
            string ribbonXML = String.Empty;

            if (ribbonID == "Microsoft.Outlook.Mail.Compose")
            {
                ribbonXML = GetResourceText("Trin_RibbonOutlookBasic.Ribbon1.xml");
            }

            return ribbonXML;
        }
        //</Snippet1>

        public void OnLoad(Office.IRibbonUI ribbonUI)
        {
            this.ribbon = ribbonUI;
        }

        #endregion

        public void OnToggleButton1(Office.IRibbonControl control, bool isPressed)
        {
            if (isPressed == true)
                MessageBox.Show("Pressed!");
            else
                MessageBox.Show("Released!");
        }

        //<Snippet2>
        public void OnActionCallback(Office.IRibbonControl control, bool isPressed)
        {
            if (control.Id == "checkBox1")
            {
                MessageBox.Show("You clicked " + control.Id);
            }
            else
            {
                MessageBox.Show("You clicked a different control.");
            }
        }
        //</Snippet2>

        #region Helpers
        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }
        #endregion
    }
}
