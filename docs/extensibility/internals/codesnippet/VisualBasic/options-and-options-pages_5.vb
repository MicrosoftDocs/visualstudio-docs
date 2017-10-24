        Dim dte As DTE = CType(GetService(GetType(DTE)), DTE)
        Dim props As EnvDTE.Properties = dte.get_Properties("My Category", "My Grid Page")
        Dim n As Integer = CInt(Fix(props.Item("OptionInteger").Value))