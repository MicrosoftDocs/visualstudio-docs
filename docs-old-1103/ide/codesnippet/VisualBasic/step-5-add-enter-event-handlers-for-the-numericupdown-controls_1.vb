    ''' <summary> 
    ''' Modify the behavior of the NumericUpDown control
    ''' to make it easier to enter numeric values for
    ''' the quiz.
    ''' </summary> 
    Private Sub answer_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sum.Enter

        ' Select the whole answer in the NumericUpDown control.
        Dim answerBox = TryCast(sender, NumericUpDown)

        If answerBox IsNot Nothing Then
            Dim lengthOfAnswer = answerBox.Value.ToString().Length
            answerBox.Select(0, lengthOfAnswer)
        End If

    End Sub