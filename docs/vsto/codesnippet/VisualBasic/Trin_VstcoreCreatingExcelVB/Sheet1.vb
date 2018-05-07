Public Class Sheet1

    '--------------------------------------------------------------------------
    '<Snippet12>
    Shared Function SetPropertyInternational( _
        ByVal target As Object, ByVal name As String, _
        ByVal ParamArray parameters() As Object) As Object

        Return target.GetType.InvokeMember(name, _
            Reflection.BindingFlags.Instance Or Reflection.BindingFlags.SetProperty, _
            Nothing, target, parameters, _
            System.Globalization.CultureInfo.GetCultureInfo(1033))
    End Function
    '</Snippet12>


    '--------------------------------------------------------------------------
    '<Snippet15>
    Shared Function GetPropertyInternational( _
        ByVal target As Object, ByVal name As String, _
        ByVal ParamArray parameters() As Object) As Object

        Return target.GetType.InvokeMember(name, _
            Reflection.BindingFlags.Instance Or Reflection.BindingFlags.GetProperty, _
            Nothing, target, parameters, _
            System.Globalization.CultureInfo.GetCultureInfo(1033))
    End Function
    '</Snippet15>


    '--------------------------------------------------------------------------
    Sub Test1()

        '<Snippet13>
        Dim NamedRange1 As Microsoft.Office.Tools.Excel.NamedRange = _
            Me.Controls.AddNamedRange(Me.Range("A5"), "NamedRange1")
        '</Snippet13>


        '<Snippet14>
        SetPropertyInternational(NamedRange1.InnerObject, "Formula", "=SUM(12, 34)")
        '</Snippet14>


        '<Snippet16>
        Dim formula As String = CType( _
            GetPropertyInternational(NamedRange1.InnerObject, "Formula"), String)

        MessageBox.Show(formula)
        '</Snippet16>

    End Sub


    '--------------------------------------------------------------------------
    Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

        '<Snippet11>
        System.Threading.Thread.CurrentThread.CurrentUICulture = _
            New System.Globalization.CultureInfo("de")
        '</Snippet11>


        'THIS SNIPPET USED BY MORE THAN ONE TOPIC
        '----------------------------------------
        '<Snippet10>
        System.Threading.Thread.CurrentThread.CurrentUICulture = _
            New System.Globalization.CultureInfo( _
                Application.LanguageSettings.LanguageID( _
                    Office.MsoAppLanguageID.msoLanguageIDUI))
        '</Snippet10>


        '<Snippet8>
        Dim namedRange1 As Microsoft.Office.Tools.Excel.NamedRange = _
            Me.Controls.AddNamedRange(Me.Range("A1"), "NamedRange1")
        '</Snippet8>

        '<Snippet9>
        namedRange1.Value2 = My.Resources.ListCreateUnscheduledOrder
        '</Snippet9>
    End Sub


    Private Sub Sheet1_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
    End Sub


    '--------------------------------------------------------------------------
    Sub Test()

        '<Snippet6>
        Me.Range("A1").Value2 = "05/12/04"
        '</Snippet6>
    End Sub


    '--------------------------------------------------------------------------
    '<Snippet7>
    Private Sub ConvertDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ConvertDate.Click

        Try
            Dim dbl As Double = Me.Range("A5").Value2
            Dim dt As System.DateTime = System.DateTime.FromOADate(dbl)
            Me.Range("A7").Value2 = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '</Snippet7>


End Class
