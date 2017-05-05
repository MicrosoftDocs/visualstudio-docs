#region Using directives

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;

//<Snippet1>
using Word = Microsoft.Office.Interop.Word;
//</Snippet1>

#endregion

namespace Trin_RibbonImageControl
{
    //<Snippet2>
    // TODO:
    // This is an override of the RequestService method in ThisAddin class.
    // To hook up your custom ribbon uncomment this code.
    public partial class ThisAddIn
    {
        MyRibbon ribbon;
        protected override object RequestService(Guid serviceGuid)
        {
            if (serviceGuid == typeof(Office.IRibbonExtensibility).GUID)
            {
                if (ribbon == null)
                    ribbon = new MyRibbon();
                return ribbon;
            }

            return base.RequestService(serviceGuid);
        }
    }
    //</Snippet2>


    [ComVisible(true)]
    public class MyRibbon : Office.IRibbonExtensibility
    {

        #region fields

        private Office.IRibbonUI ribbon;

        #endregion


        #region Initialization

        public MyRibbon()
        {
        }

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("MyRibbon.xml");
        }

        public void OnLoad(Office.IRibbonUI ribbonUI)
        {
            this.ribbon = ribbonUI;
        }

        #endregion

        //<Snippet3>
        public void OnTextButton(Office.IRibbonControl control)
        {
            Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            currentRange.Text = "This text was added by the Ribbon.";
        }
        //</Snippet3>

        //<Snippet4>
        public void OnTableButton(Office.IRibbonControl control)
        {
            object missing = System.Type.Missing;

            Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            Word.Table newTable = Globals.ThisAddIn.Application.ActiveDocument.Tables.Add(
                currentRange, 3, 4, ref missing, ref missing);
            
            // Get all of the borders except for the diagonal borders.
            Word.Border[] borders = new Word.Border[6];
            borders[0] = newTable.Borders[Word.WdBorderType.wdBorderLeft];
            borders[1] = newTable.Borders[Word.WdBorderType.wdBorderRight];
            borders[2] = newTable.Borders[Word.WdBorderType.wdBorderTop];
            borders[3] = newTable.Borders[Word.WdBorderType.wdBorderBottom];
            borders[4] = newTable.Borders[Word.WdBorderType.wdBorderHorizontal];
            borders[5] = newTable.Borders[Word.WdBorderType.wdBorderVertical];

            // Format each of the borders.
            foreach (Word.Border border in borders)
            {
                border.LineStyle = Word.WdLineStyle.wdLineStyleSingle;
                border.Color = Word.WdColor.wdColorBlue;
            }
        }
        //</Snippet4>


        #region Helpers
        public static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resources = asm.GetManifestResourceNames();
            foreach (string resource in resources)
            {
                if (resource.EndsWith(resourceName))
                {
                    System.IO.StreamReader resourceReader =
                        new System.IO.StreamReader(asm.GetManifestResourceStream(resource));
                    if (resourceReader != null)
                    {
                        return resourceReader.ReadToEnd();
                    }
                }
            }
            return null;
        }
        #endregion
    }
}
