    public TestQuickInfoSource(TestQuickInfoSourceProvider provider, ITextBuffer subjectBuffer)
    {
        m_provider = provider;
        m_subjectBuffer = subjectBuffer;

        //these are the method names and their descriptions
        m_dictionary = new Dictionary<string, string>();
        m_dictionary.Add("add", "int add(int firstInt, int secondInt)\nAdds one integer to another.");
        m_dictionary.Add("subtract", "int subtract(int firstInt, int secondInt)\nSubtracts one integer from another.");
        m_dictionary.Add("multiply", "int multiply(int firstInt, int secondInt)\nMultiplies one integer by another.");
        m_dictionary.Add("divide", "int divide(int firstInt, int secondInt)\nDivides one integer by another.");
    }