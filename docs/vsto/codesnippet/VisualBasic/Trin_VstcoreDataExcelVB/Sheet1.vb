Public Class Sheet1

    '--------------------------------------------------------------------------
    '<Snippet11>
    <Microsoft.VisualStudio.Tools.Applications.Runtime.Cached()> _
    Public employeesDataSet As DataSet
    '</Snippet11>


    '--------------------------------------------------------------------------
    '<Snippet12>
    Public dataSet1 As DataSet
    '</Snippet12>

    Sub Test2()

        '<Snippet13>
        dataSet1 = New DataSet()

        If Not (Me.IsCached("dataSet1")) Then
            Me.StartCaching("dataSet1")
        End If
        '</Snippet13>


        '<Snippet14>
        If (Me.IsCached("dataSet1")) Then
            Me.StopCaching("dataSet1")
        End If
        '</Snippet14>
    End Sub


    '--------------------------------------------------------------------------
    Private Sub Sheet1_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

        '<Snippet2>
        With Me
            .Button1.Text = "|<"
            .Button2.Text = "<"
            .Button3.Text = ">"
            .Button4.Text = ">|"
        End With
        '</Snippet2>
    End Sub


    '--------------------------------------------------------------------------
    '<Snippet4>
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Button1.Click

        Me.CustomersBindingSource.MoveFirst()
    End Sub
    '</Snippet4>

    '<Snippet5>
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Button2.Click

        Me.CustomersBindingSource.MovePrevious()
    End Sub
    '</Snippet5>

    '<Snippet6>
    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Button3.Click

        Me.CustomersBindingSource.MoveNext()
    End Sub
    '</Snippet6>

    '<Snippet7>
    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Button4.Click

        Me.CustomersBindingSource.MoveLast()
    End Sub
    '</Snippet7>


    '--------------------------------------------------------------------------
    Sub Test1()
        '<Snippet1>
        Me.NamedRange1.DataBindings("Value2").WriteValue()
        '</Snippet1>

        '<Snippet19>
        Me.NamedRange1.DataBindings("Value2").DataSourceUpdateMode = _
            DataSourceUpdateMode.OnPropertyChanged
        '</Snippet19>

        '<Snippet20>
        Me.CustomersBindingSource.EndEdit()
        '</Snippet20>

        '<Snippet21>
        Me.CustomersTableAdapter.Update(Me.NorthwindDataSet.Customers)
        '</Snippet21>
    End Sub
End Class
