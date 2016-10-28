    ' Call the StartTheQuiz() method and enable
    ' the Start button. 
    Private Sub startButton_Click() Handles startButton.Click
        StartTheQuiz()
        startButton.Enabled = False
    End Sub