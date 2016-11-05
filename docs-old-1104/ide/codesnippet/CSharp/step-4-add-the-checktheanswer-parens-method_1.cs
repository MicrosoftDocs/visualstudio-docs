    /// <summary>
    /// Check the answer to see if the user got everything right.
    /// </summary>
    /// <returns>True if the answer's correct, false otherwise.</returns>
    private bool CheckTheAnswer()
    {
        if (addend1 + addend2 == sum.Value)
            return true;
        else
            return false;
    }