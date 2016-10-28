    Public Sub Detach(ByVal textView As ITextView) Implements IIntellisenseController.Detach
        If m_textView Is textView Then
            AddHandler m_textView.MouseHover, AddressOf Me.OnTextViewMouseHover
            m_textView = Nothing
        End If
    End Sub