    [Guid(GuidList.guidEditorFactory)]
    public sealed class SingleViewEditorFactory : IVsEditorFactory, IDisposable
    {
        private PackageSingleViewEditor MyPackage;
        private ServiceProvider vsServiceProvider;

        public SingleViewEditorFactory(PackageSingleViewEditor packageEditor)
        {
            Trace.WriteLine(string.Format(CultureInfo.CurrentCulture, 
                "Entering {0} constructor", this.ToString()));
            MyPackage = packageEditor;
        }

        #region "IVsEditorFactory Support"
            public int Close()
            {
                throw new NotImplementedException();
            }

            public int CreateEditorInstance(uint grfCreateDoc, string pszMkDocument, string pszPhysicalView, IVsHierarchy pvHier, uint itemid, IntPtr punkDocDataExisting, out IntPtr ppunkDocView, out IntPtr ppunkDocData, out string pbstrEditorCaption, out System.Guid pguidCmdUI, out int pgrfCDW)
            {
                throw new NotImplementedException();
            }

            public int MapLogicalView(ref System.Guid rguidLogicalView, out string pbstrPhysicalView)
            {
                throw new NotImplementedException();
            }

            public int SetSite(Microsoft.VisualStudio.OLE.Interop.IServiceProvider psp)
            {
                throw new NotImplementedException();
            }
        #endregion

        #region "IDisposable Support"
            public void Dispose()
            {
                throw new NotImplementedException();
            }
        #endregion
    }