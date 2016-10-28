Namespace MyLanguagePackage
	Friend Class MySource
		Inherits Source
        Public Sub New(ByVal service As LanguageService, ByVal textLines As IVsTextLines,
                       ByVal colorizer As Colorizer)
            MyBase.New(service, textLines, colorizer)
        End Sub
	End Class
End Namespace