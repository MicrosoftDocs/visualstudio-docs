        DTE dte = (DTE)GetService(typeof(DTE));
        EnvDTE.Properties props = dte.get_Properties("My Category", "My Grid Page");
        int n = (int)props.Item("OptionInteger").Value;