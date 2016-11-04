    public ISignature GetBestMatch(ISignatureHelpSession session)
    {
        if (session.Signatures.Count > 0)
        {
            ITrackingSpan applicableToSpan = session.Signatures[0].ApplicableToSpan;
            string text = applicableToSpan.GetText(applicableToSpan.TextBuffer.CurrentSnapshot);

            if (text.Trim().Equals("add"))  //get only "add" 
                return session.Signatures[0];
        }
        return null;
    }