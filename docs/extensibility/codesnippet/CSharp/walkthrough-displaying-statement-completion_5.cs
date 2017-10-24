    void ICompletionSource.AugmentCompletionSession(ICompletionSession session, IList<CompletionSet> completionSets)
    {
        List<string> strList = new List<string>();
        strList.Add("addition");
        strList.Add("adaptation");
        strList.Add("subtraction");
        strList.Add("summation");
        m_compList = new List<Completion>();
        foreach (string str in strList)
            m_compList.Add(new Completion(str, str, str, null, null));

        completionSets.Add(new CompletionSet(
            "Tokens",    //the non-localized title of the tab
            "Tokens",    //the display title of the tab
            FindTokenSpanAtPosition(session.GetTriggerPoint(m_textBuffer),
                session),
            m_compList,
            null));
    }