---
title: 'Walkthrough: Displaying Light Bulb Suggestions'
description: Create a light bulb in the Visual Studio editor that appears on the current word and has two suggested actions by using this walkthrough.
ms.date: 11/04/2016
ms.topic: how-to
author: maiak
ms.author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---
# Walkthrough: Display light bulb suggestions

Light bulbs are icons in the Visual Studio editor that expand to display a set of actions, for example, fixes for problems identified by the built-in code analyzers or code refactoring.

 In the Visual C# and Visual Basic editors, you can also use the .NET Compiler Platform ("Roslyn") to write and package your own code analyzers with actions that display light bulbs automatically. For more information, see:

- [How To: Write a C# diagnostic and code fix](https://github.com/dotnet/roslyn/blob/main/docs/wiki/How-To-Write-a-C%23-Analyzer-and-Code-Fix.md)

- [How To: Write a Visual Basic diagnostic and code fix](https://github.com/dotnet/roslyn/blob/main/docs/wiki/How-To-Write-a-Visual-Basic-Analyzer-and-Code-Fix.md)

  Other languages such as C++ also provide light bulbs for some quick actions, such as, a suggestion to create a stub implementation of that function.

  Here's what a light bulb looks like. In a Visual Basic or Visual C# project, a red squiggle appears under a variable name when it's invalid. If you mouse over the invalid identifier, a light bulb appears near the cursor.

  ![light bulb](../extensibility/media/lightbulb.png "LightBulb")

  If you click the down arrow by the light bulb, a set of suggested actions appears, along with a preview of the selected action. In this case, it shows the changes that are made to your code if you execute the action.

  ![light bulb preview](../extensibility/media/lightbulbpreview.png "LightBulbPreview")

  You can use light bulbs to provide your own suggested actions. For example, you could provide actions to move opening curly braces to a new line or move them to the end of the preceding line. The following walkthrough shows how to create a light bulb that appears on the current word and has two suggested actions: **Convert to upper case** and **Convert to lower case**.

## Create a Managed Extensibility Framework (MEF) project

1. Create a C# VSIX project. (In the **New Project** dialog, select **Visual C# / Extensibility**, then **VSIX Project**.) Name the solution `LightBulbTest`.

2. Add an **Editor Classifier** item template to the project. For more information, see [Create an extension with an editor item template](../extensibility/creating-an-extension-with-an-editor-item-template.md).

3. Delete the existing class files.

4. Add the following reference to the project, and set **Copy Local** to `False`:

     *Microsoft.VisualStudio.Language.Intellisense*

5. Add a new class file and name it **LightBulbTest**.

6. Add the following using directives:

    ```csharp
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.Language.Intellisense;
    using Microsoft.VisualStudio.Text;
    using Microsoft.VisualStudio.Text.Editor;
    using Microsoft.VisualStudio.Text.Operations;
    using Microsoft.VisualStudio.Utilities;
    using System.ComponentModel.Composition;
    using System.Threading;

    ```

## Implement the light bulb source provider

1. In the *LightBulbTest.cs* class file, delete the LightBulbTest class. Add a class named **TestSuggestedActionsSourceProvider** that implements <xref:Microsoft.VisualStudio.Language.Intellisense.ISuggestedActionsSourceProvider>. Export it with a Name of **Test Suggested Actions** and a <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute> of "text".

    ```csharp
    [Export(typeof(ISuggestedActionsSourceProvider))]
    [Name("Test Suggested Actions")]
    [ContentType("text")]
    internal class TestSuggestedActionsSourceProvider : ISuggestedActionsSourceProvider
    ```

2. Inside the source provider class, import the <xref:Microsoft.VisualStudio.Text.Operations.ITextStructureNavigatorSelectorService> and add it as a property.

    ```csharp
    [Import(typeof(ITextStructureNavigatorSelectorService))]
    internal ITextStructureNavigatorSelectorService NavigatorService { get; set; }
    ```

3. Implement the <xref:Microsoft.VisualStudio.Language.Intellisense.ISuggestedActionsSourceProvider.CreateSuggestedActionsSource%2A> method to return an <xref:Microsoft.VisualStudio.Language.Intellisense.ISuggestedActionsSource> object. The source is discussed in the next section.

    ```csharp
    public ISuggestedActionsSource CreateSuggestedActionsSource(ITextView textView, ITextBuffer textBuffer)
    {
        if (textBuffer == null || textView == null)
        {
            return null;
        }
        return new TestSuggestedActionsSource(this, textView, textBuffer);
    }
    ```

## Implement the ISuggestedActionSource
 The suggested action source is responsible for collecting the set of suggested actions and adding them in the right context. In this case, the context is the current word and the suggested actions are **UpperCaseSuggestedAction** and **LowerCaseSuggestedAction**, which is discussed in the following section.

1. Add a class **TestSuggestedActionsSource** that implements <xref:Microsoft.VisualStudio.Language.Intellisense.ISuggestedActionsSource>.

    ```csharp
    internal class TestSuggestedActionsSource : ISuggestedActionsSource
    ```

2. Add private, read-only fields for the suggested action source provider, the text buffer, and the text view.

    ```csharp
    private readonly TestSuggestedActionsSourceProvider m_factory;
    private readonly ITextBuffer m_textBuffer;
    private readonly ITextView m_textView;
    ```

3. Add a constructor that sets the private fields.

    ```csharp
    public TestSuggestedActionsSource(TestSuggestedActionsSourceProvider testSuggestedActionsSourceProvider, ITextView textView, ITextBuffer textBuffer)
    {
        m_factory = testSuggestedActionsSourceProvider;
        m_textBuffer = textBuffer;
        m_textView = textView;
    }
    ```

4. Add a private method that returns the word that is currently under the cursor. The following method looks at the current location of the cursor and asks the text structure navigator for the extent of the word. If the cursor is on a word, the <xref:Microsoft.VisualStudio.Text.Operations.TextExtent> is returned in the out parameter; otherwise, the `out` parameter is `null` and the method returns `false`.

    ```csharp
    private bool TryGetWordUnderCaret(out TextExtent wordExtent)
    {
        ITextCaret caret = m_textView.Caret;
        SnapshotPoint point;

        if (caret.Position.BufferPosition > 0)
        {
            point = caret.Position.BufferPosition - 1;
        }
        else
        {
            wordExtent = default(TextExtent);
            return false;
        }

        ITextStructureNavigator navigator = m_factory.NavigatorService.GetTextStructureNavigator(m_textBuffer);

        wordExtent = navigator.GetExtentOfWord(point);
        return true;
    }
    ```

5. Implement the <xref:Microsoft.VisualStudio.Language.Intellisense.ISuggestedActionsSource.HasSuggestedActionsAsync%2A> method. The editor calls this method to find out whether to display the light bulb. This call is made often, for example, whenever the cursor moves from one line to another, or when the mouse hovers over an error squiggle. It's asynchronous in order to allow other UI operations to carry on while this method is working. In most cases, this method needs to perform some parsing and analysis of the current line, so the processing may take some time.

     In this implementation, it asynchronously gets the <xref:Microsoft.VisualStudio.Text.Operations.TextExtent> and determines whether the extent is significant, as in, whether it has some text other than whitespace.

    ```csharp
    public Task<bool> HasSuggestedActionsAsync(ISuggestedActionCategorySet requestedActionCategories, SnapshotSpan range, CancellationToken cancellationToken)
    {
        return Task.Factory.StartNew(() =>
        {
            TextExtent extent;
            if (TryGetWordUnderCaret(out extent))
            {
                // don't display the action if the extent has whitespace
                return extent.IsSignificant;
              }
            return false;
        });
    }
    ```

6. Implement the <xref:Microsoft.VisualStudio.Language.Intellisense.ISuggestedActionsSource.GetSuggestedActions%2A> method, which returns an array of <xref:Microsoft.VisualStudio.Language.Intellisense.SuggestedActionSet> objects that contain the different <xref:Microsoft.VisualStudio.Language.Intellisense.ISuggestedAction> objects. This method is called when the light bulb is expanded.

    > [!WARNING]
    > You should make sure that the implementations of `HasSuggestedActionsAsync()` and `GetSuggestedActions()` are consistent; that is, if `HasSuggestedActionsAsync()` returns `true`, then `GetSuggestedActions()` should have some actions to display. In many cases, `HasSuggestedActionsAsync()` is called just before `GetSuggestedActions()`, but this is not always the case. For example, if the user invokes the light bulb actions by pressing (**CTRL+** .) only `GetSuggestedActions()` is called.

    ```csharp
    public IEnumerable<SuggestedActionSet> GetSuggestedActions(ISuggestedActionCategorySet requestedActionCategories, SnapshotSpan range, CancellationToken cancellationToken)
    {
        TextExtent extent;
        if (TryGetWordUnderCaret(out extent) && extent.IsSignificant)
        {
            ITrackingSpan trackingSpan = range.Snapshot.CreateTrackingSpan(extent.Span, SpanTrackingMode.EdgeInclusive);
            var upperAction = new UpperCaseSuggestedAction(trackingSpan);
            var lowerAction = new LowerCaseSuggestedAction(trackingSpan);
            return new SuggestedActionSet[] { new SuggestedActionSet(new ISuggestedAction[] { upperAction, lowerAction }) };
        }
        return Enumerable.Empty<SuggestedActionSet>();
    }
    ```

7. Define a `SuggestedActionsChanged` event.

    ```csharp
    public event EventHandler<EventArgs> SuggestedActionsChanged;
    ```

8. To complete the implementation, add implementations for the `Dispose()` and `TryGetTelemetryId()` methods. You don't want to do telemetry, so just return `false` and set the GUID to `Empty`.

    ```csharp
    public void Dispose()
    {
    }

    public bool TryGetTelemetryId(out Guid telemetryId)
    {
        // This is a sample provider and doesn't participate in LightBulb telemetry
        telemetryId = Guid.Empty;
        return false;
    }
    ```

## Implement light bulb actions

1. In the project, add a reference to *Microsoft.VisualStudio.Imaging.Interop.14.0.DesignTime.dll* and set **Copy Local** to `False`.

2. Create two classes, the first named `UpperCaseSuggestedAction` and the second named `LowerCaseSuggestedAction`. Both classes implement <xref:Microsoft.VisualStudio.Language.Intellisense.ISuggestedAction>.

    ```csharp
    internal class UpperCaseSuggestedAction : ISuggestedAction
    internal class LowerCaseSuggestedAction : ISuggestedAction
    ```

     Both classes are alike except that one calls <xref:System.String.ToUpper%2A> and the other calls <xref:System.String.ToLower%2A>. The following steps cover only the uppercase action class, but you must implement both classes. Use the steps for implementing the uppercase action as a pattern for implementing the lowercase action.

3. Add the following using directives for these classes:

    ```csharp
    using Microsoft.VisualStudio.Imaging.Interop;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Media;

    ```

4. Declare a set of private fields.

    ```csharp
    private ITrackingSpan m_span;
    private string m_upper;
    private string m_display;
    private ITextSnapshot m_snapshot;
    ```

5. Add a constructor that sets the fields.

    ```csharp
    public UpperCaseSuggestedAction(ITrackingSpan span)
    {
        m_span = span;
        m_snapshot = span.TextBuffer.CurrentSnapshot;
        m_upper = span.GetText(m_snapshot).ToUpper();
        m_display = string.Format("Convert '{0}' to upper case", span.GetText(m_snapshot));
    }
    ```

6. Implement the <xref:Microsoft.VisualStudio.Language.Intellisense.ISuggestedAction.GetPreviewAsync%2A> method so that it displays the action preview.

    ```csharp
    public Task<object> GetPreviewAsync(CancellationToken cancellationToken)
    {
        var textBlock = new TextBlock();
        textBlock.Padding = new Thickness(5);
        textBlock.Inlines.Add(new Run() { Text = m_upper });
        return Task.FromResult<object>(textBlock);
    }
    ```

7. Implement the <xref:Microsoft.VisualStudio.Language.Intellisense.ISuggestedAction.GetActionSetsAsync%2A> method so that it returns an empty <xref:Microsoft.VisualStudio.Language.Intellisense.SuggestedActionSet> enumeration.

    ```csharp
    public Task<IEnumerable<SuggestedActionSet>> GetActionSetsAsync(CancellationToken cancellationToken)
    {
        return Task.FromResult<IEnumerable<SuggestedActionSet>>(null);
    }
    ```

8. Implement the properties as follows.

    ```csharp
    public bool HasActionSets
    {
        get { return false; }
    }
    public string DisplayText
    {
        get { return m_display; }
    }
    public ImageMoniker IconMoniker
    {
       get { return default(ImageMoniker); }
    }
    public string IconAutomationText
    {
        get
        {
            return null;
        }
    }
    public string InputGestureText
    {
        get
        {
            return null;
        }
    }
    public bool HasPreview
    {
        get { return true; }
    }
    ```

9. Implement the <xref:Microsoft.VisualStudio.Language.Intellisense.ISuggestedAction.Invoke%2A> method by replacing the text in the span with its uppercase equivalent.

    ```csharp
    public void Invoke(CancellationToken cancellationToken)
    {
        m_span.TextBuffer.Replace(m_span.GetSpan(m_snapshot), m_upper);
    }
    ```

    > [!WARNING]
    > The light bulb action **Invoke** method is not expected to show UI. If your action does bring up new UI (for example a preview or selection dialog), do not display the UI directly from within the **Invoke** method but instead schedule to display your UI after returning from **Invoke**.

10. To complete the implementation, add the `Dispose()` and `TryGetTelemetryId()` methods.

    ```csharp
    public void Dispose()
    {
    }

    public bool TryGetTelemetryId(out Guid telemetryId)
    {
        // This is a sample action and doesn't participate in LightBulb telemetry
        telemetryId = Guid.Empty;
        return false;
    }
    ```

11. Don't forget to do the same thing for `LowerCaseSuggestedAction` changing the display text to "Convert '{0}' to lower case" and the call <xref:System.String.ToUpper%2A> to <xref:System.String.ToLower%2A>.

## Build and test the code
 To test this code, build the LightBulbTest solution and run it in the Experimental instance.

1. Build the solution.

2. When you run this project in the debugger, a second instance of Visual Studio is started.

3. Create a text file and type some text. You should see a light bulb to the left of the text.

     ![test the light bulb](../extensibility/media/testlightbulb.png "TestLIghtBulb")

4. Point at the light bulb. You should see a down arrow.

5. When you click the light bulb, two suggested actions should display, along with the preview of the selected action.

     ![test light bulb, expanded](../extensibility/media/testlightbulbexpanded.gif "TestLIghtBulbExpanded")

6. If you click the first action, all the text in the current word should be converted to upper-case. If you click the second action, all the text should be converted to lower-case.
