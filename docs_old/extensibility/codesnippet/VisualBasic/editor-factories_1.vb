<Guid(GuidList.guidEditorFactory)> _
Public NotInheritable Class SingleViewEditorFactory
    Implements IVsEditorFactory
    Implements IDisposable

    Private MyPackage As PackageSingleViewEditor
    Private vsServiceProvider As ServiceProvider

    Public Sub New(ByVal packageEditor As PackageSingleViewEditor)
        Trace.WriteLine(String.Format(CultureInfo.CurrentCulture,
          "Entering {0} constructor", Me.ToString()))
        MyPackage = packageEditor
    End Sub

#Region "IVsEditorFactorySupport"
    Public Function Close() As Integer Implements VisualStudio.Shell.Interop.IVsEditorFactory.Close
        Throw New NotImplementedException
    End Function

    Public Function CreateEditorInstance(ByVal grfCreateDoc As UInteger, ByVal pszMkDocument As String, ByVal pszPhysicalView As String, ByVal pvHier As VisualStudio.Shell.Interop.IVsHierarchy, ByVal itemid As UInteger, ByVal punkDocDataExisting As System.IntPtr, ByRef ppunkDocView As System.IntPtr, ByRef ppunkDocData As System.IntPtr, ByRef pbstrEditorCaption As String, ByRef pguidCmdUI As System.Guid, ByRef pgrfCDW As Integer) As Integer Implements VisualStudio.Shell.Interop.IVsEditorFactory.CreateEditorInstance
        Throw New NotImplementedException
    End Function

    Public Function MapLogicalView(ByRef rguidLogicalView As System.Guid, ByRef pbstrPhysicalView As String) As Integer Implements VisualStudio.Shell.Interop.IVsEditorFactory.MapLogicalView
        Throw New NotImplementedException
    End Function

    Public Function SetSite(ByVal psp As VisualStudio.OLE.Interop.IServiceProvider) As Integer Implements VisualStudio.Shell.Interop.IVsEditorFactory.SetSite
        Throw New NotImplementedException
    End Function
#End Region

#Region "IDisposable Support"
    Public Sub Dispose() Implements IDisposable.Dispose
        Throw New NotImplementedException
    End Sub
#End Region

End Class