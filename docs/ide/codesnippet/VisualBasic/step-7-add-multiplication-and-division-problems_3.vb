    ''' <summary>
    ''' Check the answers to see if the user got everything right.
    ''' </summary>
    ''' <returns>True if the answer's correct, false otherwise.</returns>
    ''' <remarks></remarks>
    Public Function CheckTheAnswer() As Boolean

        If addend1 + addend2 = sum.Value AndAlso 
           minuend - subtrahend = difference.Value AndAlso 
           multiplicand * multiplier = product.Value AndAlso 
           dividend / divisor = quotient.Value Then

            Return True
        Else
            Return False
        End If

    End Function