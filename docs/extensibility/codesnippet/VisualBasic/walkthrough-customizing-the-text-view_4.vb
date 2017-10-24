    Public Sub TextViewCreated(ByVal textView As IWpfTextView) Implements IWpfTextViewCreationListener.TextViewCreated

        Dim formatMap As IEditorFormatMap = FormatMapService.GetEditorFormatMap(textView)

        Dim regularCaretProperties As ResourceDictionary = formatMap.GetProperties("Caret")
        Dim overwriteCaretProperties As ResourceDictionary = formatMap.GetProperties("Overwrite Caret")
        Dim indicatorMargin As ResourceDictionary = formatMap.GetProperties("Indicator Margin")
        Dim visibleWhitespace As ResourceDictionary = formatMap.GetProperties("Visible Whitespace")
        Dim selectedText As ResourceDictionary = formatMap.GetProperties("Selected Text")
        Dim inactiveSelectedText As ResourceDictionary = formatMap.GetProperties("Inactive Selected Text")

        formatMap.BeginBatchUpdate()

        regularCaretProperties(EditorFormatDefinition.ForegroundBrushId) = Brushes.Magenta
        formatMap.SetProperties("Caret", regularCaretProperties)

        overwriteCaretProperties(EditorFormatDefinition.ForegroundBrushId) = Brushes.Turquoise
        formatMap.SetProperties("Overwrite Caret", overwriteCaretProperties)

        indicatorMargin(EditorFormatDefinition.BackgroundColorId) = Colors.LightGreen
        formatMap.SetProperties("Indicator Margin", indicatorMargin)

        visibleWhitespace(EditorFormatDefinition.ForegroundColorId) = Colors.Red
        formatMap.SetProperties("Visible Whitespace", visibleWhitespace)

        selectedText(EditorFormatDefinition.BackgroundBrushId) = Brushes.LightPink
        formatMap.SetProperties("Selected Text", selectedText)

        inactiveSelectedText(EditorFormatDefinition.BackgroundBrushId) = Brushes.DeepPink
        formatMap.SetProperties("Inactive Selected Text", inactiveSelectedText)

        formatMap.EndBatchUpdate()
    End Sub