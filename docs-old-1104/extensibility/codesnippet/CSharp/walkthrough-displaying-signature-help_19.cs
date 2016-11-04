    private TestSignature CreateSignature(ITextBuffer textBuffer, string methodSig, string methodDoc, ITrackingSpan span)
    {
        TestSignature sig = new TestSignature(textBuffer, methodSig, methodDoc, null);
        textBuffer.Changed += new EventHandler<TextContentChangedEventArgs>(sig.OnSubjectBufferChanged);

        //find the parameters in the method signature (expect methodname(one, two)
        string[] pars = methodSig.Split(new char[] { '(', ',', ')' });
        List<IParameter> paramList = new List<IParameter>();

        int locusSearchStart = 0;
        for (int i = 1; i < pars.Length; i++)
        {
            string param = pars[i].Trim();

            if (string.IsNullOrEmpty(param))
                continue;

            //find where this parameter is located in the method signature
            int locusStart = methodSig.IndexOf(param, locusSearchStart);
            if (locusStart >= 0)
            {
                Span locus = new Span(locusStart, param.Length);
                locusSearchStart = locusStart + param.Length;
                paramList.Add(new TestParameter("Documentation for the parameter.", locus, param, sig));
            }
        }

        sig.Parameters = new ReadOnlyCollection<IParameter>(paramList);
        sig.ApplicableToSpan = span;
        sig.ComputeCurrentParameter();
        return sig;
    }