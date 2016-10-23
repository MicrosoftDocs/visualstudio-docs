            Dim iconLabel = TryCast(control, Label)
            If iconLabel IsNot Nothing Then
                Dim randomNumber = random.Next(icons.Count)
                iconLabel.Text = icons(randomNumber)
                ' iconLabel.ForeColor = iconLabel.BackColor
                icons.RemoveAt(randomNumber)
            End If