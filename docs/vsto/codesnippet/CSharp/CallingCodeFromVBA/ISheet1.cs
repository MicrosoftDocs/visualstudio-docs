using System;
namespace CallingCodeFromVBA
{
    //<Snippet4>
    [System.Runtime.InteropServices.ComVisible(true)]
    public interface ISheet1
    {
        void CreateVstoNamedRange(Microsoft.Office.Interop.Excel.Range range, string name);
    }
    //</Snippet4>
}
