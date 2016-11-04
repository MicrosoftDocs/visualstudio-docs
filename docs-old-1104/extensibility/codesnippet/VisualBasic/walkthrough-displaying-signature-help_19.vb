    Private Function CreateSignature(ByVal textBuffer As ITextBuffer, ByVal methodSig As String, ByVal methodDoc As String, ByVal span As ITrackingSpan) As TestSignature
        Dim sig As New TestSignature(textBuffer, methodSig, methodDoc, Nothing)
        AddHandler textBuffer.Changed, AddressOf sig.OnSubjectBufferChanged

        'find the parameters in the method signature (expect methodname(one, two)
        Dim pars() As String = methodSig.Split(New Char() {"("c, ","c, ")"c})
        Dim paramList As New List(Of IParameter)()

        Dim locusSearchStart As Integer = 0
        For i As Integer = 1 To pars.Length - 1
            Dim param As String = pars(i).Trim()

            If String.IsNullOrEmpty(param) Then
                Continue For
            End If

            'find where this parameter is located in the method signature
            Dim locusStart As Integer = methodSig.IndexOf(param, locusSearchStart)
            If locusStart >= 0 Then
                Dim locus As New Span(locusStart, param.Length)
                locusSearchStart = locusStart + param.Length
                paramList.Add(New TestParameter("Documentation for the parameter.", locus, param, sig))
            End If
        Next i

        sig.m_Parameters = New ReadOnlyCollection(Of IParameter)(paramList)
        sig.m_ApplicableToSpan = span
        sig.ComputeCurrentParameter()
        Return sig
    End Function