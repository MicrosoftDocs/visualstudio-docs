    Private Sub EndEditOnAllBindingSources()
        Dim BindingSourcesQuery = From bindingsources In Me.components.Components 
                      Where (TypeOf bindingsources Is Windows.Forms.BindingSource) 
                      Select bindingsources

        For Each bindingSource As Windows.Forms.BindingSource In BindingSourcesQuery
            bindingSource.EndEdit()
        Next
    End Sub