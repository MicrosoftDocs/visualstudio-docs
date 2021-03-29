﻿using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;
using Microsoft.Win32;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VSSDKSupportForOptionsPages;
using EnvDTE;

namespace Microsoft.VSSDKSupportForOptionsPages
{
    /// <summary>
    /// This is the class that implements the package exposed by this assembly.
    ///
    /// The minimum requirement for a class to be considered a valid package for Visual Studio
    /// is to implement the IVsPackage interface and register itself with the shell.
    /// This package uses the helper classes defined inside the Managed Package Framework (MPF)
    /// to do it: it derives from the Package class that provides the implementation of the 
    /// IVsPackage interface and uses the registration attributes defined in the framework to 
    /// register itself and its components with the shell.
    /// </summary>
    // This attribute tells the PkgDef creation utility (CreatePkgDef.exe) that this class is
    // a package.
    //<Snippet2>
    [ProvideOptionPage(typeof(OptionsPageGeneral),"My Option Pages", "General", 101, 106, true)]
    [ProvideOptionPage(typeof(OptionsPageCustom), "My Option Pages", "Custom", 101, 107, true)]
    [Guid("B0002DC2-56EE-4931-93F7-70D6E9863940")]
    public class MyPackage : Package
    //</Snippet2>
    {
        /// <summary>
        /// Default constructor of the package.
        /// Inside this method you can place any initialization code that does not require 
        /// any Visual Studio service because at this point the package object is created but 
        /// not sited yet inside Visual Studio environment. The place to do all the other 
        /// initialization is the Initialize method.
        /// </summary>
        public MyPackage()
        {
            Trace.WriteLine(string.Format(CultureInfo.CurrentCulture, "Entering constructor for: {0}", this.ToString()));
        }



        /////////////////////////////////////////////////////////////////////////////
        // Overriden Package Implementation
        #region Package Members

        /// <summary>
        /// Initialization of the package; this method is called right after the package is sited, so this is the place
        /// where you can put all the initilaization code that rely on services provided by VisualStudio.
        /// </summary>
        protected override void Initialize()
        {
            Trace.WriteLine (string.Format(CultureInfo.CurrentCulture, "Entering Initialize() of: {0}", this.ToString()));
            base.Initialize();

        }
        #endregion
    }
}

//<Snippet1>
namespace Company.OptionsPage
{
    public class OptionsPageGeneral : DialogPage
    {
    }
}
//</Snippet1>

//<Snippet4>
[ProvideOptionPage(typeof(MyOptionPage), "My Category", "My Grid Page", 0, 0, true)]
[Guid("6bb6942e-014c-489e-a612-a935680f703d")]
public sealed class MyToolsOptions : Package
//</Snippet4>
{
    public void ParsnipFiller()
    {
        //<Snippet5>
        DTE dte = (DTE)GetService(typeof(DTE));
        EnvDTE.Properties props = dte.get_Properties("My Category", "My Grid Page");
        int n = (int)props.Item("OptionInteger").Value;
        //</Snippet5>
    }
}