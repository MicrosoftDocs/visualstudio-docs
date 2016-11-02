    internal void ComputeCurrentParameter()
    {
        if (Parameters.Count == 0)
        {
            this.CurrentParameter = null;
            return;
        }

        //the number of commas in the string is the index of the current parameter
        string sigText = ApplicableToSpan.GetText(m_subjectBuffer.CurrentSnapshot);

        int currentIndex = 0;
        int commaCount = 0;
        while (currentIndex < sigText.Length)
        {
            int commaIndex = sigText.IndexOf(',', currentIndex);
            if (commaIndex == -1)
            {
                break;
            }
            commaCount++;
            currentIndex = commaIndex + 1;
        }

        if (commaCount < Parameters.Count)
        {
            this.CurrentParameter = Parameters[commaCount];
        }
        else
        {
            //too many commas, so use the last parameter as the current one.
            this.CurrentParameter = Parameters[Parameters.Count - 1];
        }
    }