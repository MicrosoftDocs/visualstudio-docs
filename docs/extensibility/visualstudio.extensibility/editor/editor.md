---
title: Editor overview
description: An overview of the editor-based extensions for the Visual Studio IDE
ms.date: 3/31/2023
ms.topic: conceptual
ms.author: maiak
monikerRange: ">=vs-2022"
author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---

# Use Visual Studio editor extensibility

The Visual Studio editor supports extensions that add to its capabilities. Examples include extensions that insert and modify code in an existing language.

For the initial release of the new Visual Studio extensibility model, only the following capabilities are supported:

- Listening for text views being opened and closed.
- Listening for text view (editor) state changes.
- Reading the text of the document and the selections/carets locations.
- Performing text edits and selection/caret changes.
- Defining new document types.
- Extending text views with new text view margins.
- Extending text views with new Code Lenses.

The Visual Studio editor generally refers to the functionality of editing text files, known as documents, of any type. Individual files may be opened for editing, and the open editor window is referred to as a `TextView`.

The editor object model is described at [Editor concepts](editor-concepts.md).

## Get started

Your extension code can be configured to run in response to various entry points (situations that occur when a user interacts with Visual Studio). Editor extensibility currently supports three entry points: listeners, the [EditorExtensibility](#access-editor-functionality) service object, and commands.

Event listeners get triggered when certain actions occur in an editor window, represented in code by a `TextView`. For example, when a user types something into the editor, a `TextViewChanged` event occurs. When an editor window is opened or closed, `TextViewOpened` and `TextViewClosed` events occur.

The editor service object is an instance of the [`EditorExtensibility`](/dotnet/api/microsoft.visualstudio.extensibility.editor.editorextensibility) class, which exposes real-time editor functionality, such as performing text edits.

[Commands](../command/command.md) are initiated by the user by clicking on an item, which you can place on a menu, context menu, or toolbar.

### Add a text view listener

There are two types of listeners, [ITextViewChangedListener](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewchangedlistener) and [ITextViewOpenClosedListener](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewopenclosedlistener).
Together, these listeners can be used to observe the open, close, and modification of text editors.

Then, create a new class, implementing the [ExtensionPart](/dotnet/api/microsoft.visualstudio.extensibility.extensionpart) base class and `ITextViewChangedListener`,
`ITextViewOpenClosedListener`, or both, and add a [VisualStudioContribution](/dotnet/api/microsoft.visualstudio.extensibility.visualstudiocontributionattribute) attribute.

Then, implement the [TextViewExtensionConfiguration](/dotnet/api/microsoft.visualstudio.extensibility.editor.textviewextensionconfiguration) property, as required by [ITextViewChangedListener](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewchangedlistener) and [ITextViewOpenClosedListener](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewopenclosedlistener), making the listener apply when editing C# files:
```csharp
public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
{
    AppliesTo = new[] { DocumentFilter.FromDocumentType("CSharp") },
};
```

The available document types for other programming languages and file types are listed [later in this article](#specify-programming-languages-with-the-appliesto-configuration), and custom file types may also be defined when required.

Assuming you decide to implement both listeners, the finished class declaration should look like the following:

```csharp
  [VisualStudioContribution]                
  public sealed class TextViewOperationListener :
      ExtensionPart, // This is the extension part base class containing infrastructure necessary to use VS services.
      ITextViewOpenClosedListener, // Indicates this part listens for text view lifetime events.
      ITextViewChangedListener // Indicates this part listens to text view changes.
  {
      public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
      {
          // Indicates this part should only light up in C# files.
          AppliesTo = new[] { DocumentFilter.FromDocumentType("CSharp") },
      };
      ...
```

Since both [ITextViewOpenClosedListener](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewopenclosedlistener) and [ITextViewChangedListener](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewchangedlistener) declare the [TextViewExtensionConfiguration](/dotnet/api/microsoft.visualstudio.extensibility.editor.textviewextensionconfiguration) property, the configuration applies to both listeners.

When you run your extension, you should see:

- [ITextViewOpenClosedListener.TextViewOpenedAsync](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewopenclosedlistener.textviewopenedasync) called anytime a text view is opened by the user.
- [ITextViewOpenClosedListener.TextViewClosedAsync](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewopenclosedlistener.textviewclosedasync) called anytime a text view is closed by the user.
- [ITextViewChangedListener.TextViewChangedAsync](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewchangedlistener.textviewchangedasync) called anytime a user makes a text change to a text document displayed by a text view.

Each of these methods is passed an [ITextViewSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewsnapshot) containing the state of the text view and text document at the time the user invoked the action and a CancellationToken that will have `IsCancellationRequested == true` when the IDE wishes to cancel a pending action.

## Define when your extension is relevant

Your extension is typically relevant only to certain supported document types and scenarios, and so it's important to clearly define its applicability. You can use [AppliesTo configuration](#specify-programming-languages-with-the-appliesto-configuration)) in several ways to clearly define the applicability of an extension. You can specify either what file types such as code languages the extension supports, and/or further refine the applicability of an extension by matching on a pattern based on the filename or path.

### Specify programming languages with the AppliesTo configuration

The [AppliesTo](/dotnet/api/microsoft.visualstudio.extensibility.editor.textviewextensionconfiguration.appliesto) configuration indicates the programming language scenarios in which the extension should activate. It is written as `AppliesTo = new[] { DocumentFilter.FromDocumentType("CSharp") }`, where the document type is a well known name of a language built into Visual Studio, or custom defined in a Visual Studio extension.

Some well-known document types are shown in the following table:

| DocumentType | Description |
| - | - |
| "CSharp" | C# |
| "C/C++" | C, C++, headers, and IDL |
| "TypeScript" | TypeScript and JavaScript type languages. |
| "HTML" | HTML |
| "JSON" | JSON |
| "text" | Text files, including hierarchical descendants of "code", which descends from "text". |
| "code" | C, C++, C#, and so on. |

DocumentTypes are hierarchical. That is, C# and C++ both descend from "code", so declaring "code" causes your extension to activate for all code languages, C#, C, C++, and so on.

### Define a new document type

You can define a new document type, for example to support a custom code language, by adding a static [DocumentTypeConfiguration](/dotnet/api/microsoft.visualstudio.extensibility.editor.documenttypeconfiguration) property to any class in the extension project, and marking the property with the [`VisualStudioContribution`](/dotnet/api/microsoft.visualstudio.extensibility.visualstudiocontributionattribute) attribute.

`DocumentTypeConfiguration` allows you to define a new document type, specify that it inherits one or more other document types, and specify one or more file extensions that are used to identify the file type:

```csharp
using Microsoft.VisualStudio.Extensibility.Editor;

internal static class MyDocumentTypes
{
    [VisualStudioContribution]
    internal static DocumentTypeConfiguration MarkdownDocumentType => new("markdown")
    {
        FileExtensions = new[] { ".md", ".mdk", ".markdown" },
        BaseDocumentType = DocumentType.KnownValues.Text,
    };
}
```

Document type definitions are merged with content type definitions provided by legacy Visual Studio extensibility, which allows you to map additional file extensions to existing document types.

### Document selectors

In addition to [DocumentFilter.FromDocumentType](/dotnet/api/microsoft.visualstudio.extensibility.documentfilter.fromdocumenttype), [DocumentFilter.FromGlobPattern](/dotnet/api/microsoft.visualstudio.extensibility.documentfilter.fromglobpattern) allows you to further limit applicability of the extension by making it activate only when document's file path matches a glob (wildcard) pattern:

```csharp
[VisualStudioContribution]                
public sealed class TextViewOperationListener
    : ExtensionPart, ITextViewOpenClosedListener, ITextViewChangedListener
{
    public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = new[]
        {
            DocumentFilter.FromDocumentType("CSharp"),
            DocumentFilter.FromGlobPattern("**/tests/*.cs"),
        },
    };
```

```csharp
[VisualStudioContribution]                
public sealed class TextViewOperationListener
    : ExtensionPart, ITextViewOpenClosedListener, ITextViewChangedListener
{
    public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = new[]
        {
            DocumentFilter.FromDocumentType(MyDocumentTypes.MarkdownDocumentType),
            DocumentFilter.FromGlobPattern("docs/*.md", relativePath: true),
        },
    };
```

The `pattern` parameter represents a glob pattern that is matched on the absolute path of the document.

Glob patterns can have the following syntax:

- `*` to match zero or more characters in a path segment
- `?` to match on one character in a path segment
- `**` to match any number of path segments, including none
- `{}` to group conditions (for example, `**​/*.{ts,js}` matches all TypeScript and JavaScript files)
- `[]` to declare a range of characters to match in a path segment (for example, `example.[0-9]` to match on `example.0`, `example.1`, …)
- `[!...]` to negate a range of characters to match in a path segment (for example, `example.[!0-9]` to match on `example.a`, `example.b`, but not `example.0`)

A backslash (`\`) isn't valid within a glob pattern. Make sure to convert any backslash to slash when creating the glob pattern.

## Access editor functionality

Your editor extension classes inherit from [ExtensionPart](/dotnet/api/microsoft.visualstudio.extensibility.extensionpart). The `ExtensionPart` class exposes the [Extensibility](/dotnet/api/microsoft.visualstudio.extensibility.extensionpart.extensibility) property. Using this property, you can request an instance of the [EditorExtensibility](/dotnet/api/microsoft.visualstudio.extensibility.editor.editorextensibility) object. You can use this object to access real-time editor functionality, such as performing edits.

```csharp
EditorExtensibility editorService = this.Extensibility.Editor();
```

### Access editor state within a command

`ExecuteCommandAsync()` in each `Command` is passed an `IClientContext` that contains a snapshot of the state of the IDE at the time the command was invoked. You can access the active document via the [`ITextViewSnapshot`](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewsnapshot) interface, which you get by from the [`EditorExtensibility`](/dotnet/api/microsoft.visualstudio.extensibility.editor.editorextensibility) object by calling the asynchronous method [`GetActiveTextViewAsync`](/dotnet/api/microsoft.visualstudio.extensibility.editor.editorextensibility.getactivetextviewasync):

```csharp
using ITextViewSnapshot textView = await this.Extensibility.Editor().GetActiveTextViewAsync(clientContext, cancellationToken);
```

Once you have `ITextViewSnapshot`, you can access editor state. [`ITextViewSnapshot`](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewsnapshot) is an immutable view of editor state at a point in time, so you need to use the other interfaces in the [Editor object model](editor-concepts.md) to make edits.

## Make changes in a text document from an extension

Edits, that is, changes to a text document open in the Visual Studio editor, may arise from user interactions, threads in Visual Studio such as language services and other extensions. Your extension must be prepared to deal with changes in the document text occurring in real time.

Extensions running outside the main Visual Studio IDE process that use asynchronous design patterns to communicate with the Visual Studio IDE process. This means the use of asynchronous method calls, as indicated by the `async` keyword in C# and reinforced by the `Async` suffix on method names. Asynchronicity is a significant advantage in the context of an editor that is expected to be responsive to user actions. A traditional synchronous API call, if it takes longer than expected, will stop responding to user input, creating a UI freeze that lasts until the API call completes. User expectations of modern interactive applications are that text editors always remain responsive, and never block them from working. Having extensions be asynchronous is therefore essential to meet user expectations.

Learn more about asynchronous programming at [Asynchronous programming with async and await](/dotnet/csharp/programming-guide/concepts/async/).

In the new Visual Studio extensibility model, the extension is second class relative to the user: it can't directly modify the editor or the text document. All state changes are asynchronous and cooperative, with Visual Studio IDE performing the requested change on the extension's behalf. The extension can request one or more changes on a specific version of the document or text view, but changes from an extension may be rejected, such as if that area of the document has changed.

Edits are requested using the `EditAsync()` method on [`EditorExtensibility`](/dotnet/api/microsoft.visualstudio.extensibility.editor.editorextensibility).

If you're familiar with legacy Visual Studio extensions, [`ITextDocumentEditor`](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextdocumenteditor) is almost the same as the state changing methods from [ITextBuffer](/dotnet/api/microsoft.visualstudio.text.itextbuffer) and [ITextDocument](/dotnet/api/microsoft.visualstudio.text.itextdocument) and supports most of the same capabilities.

```csharp
MutationResult result = await this.Extensibility.Editor().EditAsync(
batch =>
{
    var editor = document.AsEditable(batch);
    editor.Replace(textView.Selection.Extent, newGuidString);
},
cancellationToken);
```

To avoid misplaced edits, edits from editor extensions are applied as follows:

1. Extension requests an edit be made, based on its most recent version of the document.
1. That request may contain one or more text edits, caret position changes, and so on. Any type implementing `IEditable` can be changed in a single `EditAsync()` request, including `ITextViewSnapshot` and `ITextDocumentSnapshot`. Edits are done by editor, which can be requested on a specific class via `AsEditable()`.
1. Edit requests are sent to Visual Studio IDE, where it succeeds only if the object being mutated hasn't changed since the version the request was made one. If the document has changed, the change may be rejected, requiring the extension to retry on newer version. Outcome of mutation operation is stored in `result`.
1. Edits are applied atomically, meaning without interruption from other executing threads. The best practice is to do all changes that should occur within a narrow time frame into a single `EditAsync()` call, to reduce the likelihood of unexpected behavior arising from user edits, or language service actions that occur between edits (for example, extension edits getting interleaved with Roslyn C# moving the caret).

## Changing caret position or selecting text from an extension

Editing text document from an extension implicitly affects caret position. For example, inserting some text at the caret will move the caret to the end of the inserted text. Extensions can also use [`ITextViewSnapshot.AsEditable().SetSelections()`](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextvieweditor.setselections) to set the caret explicitly to a different position or make text selections. To illustrate, the following code would insert some text, but keep the caret at the original position:

```csharp
await this.Extensibility.Editor().EditAsync(batch =>
{
    var caret = textView.Selection.Extent.Start;
    textView.Document.AsEditable(batch).Replace(textView.Selection.Extent, newGuidString);
    textView.AsEditable(batch).SetSelections([new Selection(activePosition: caret, anchorPosition: caret, insertionPosition: caret)]);
},
cancellationToken);
```

### Asynchronous execution

[ITextViewSnapshot.GetTextDocumentAsync](/visualstudio/extensibility/visualstudio.extensibility/editor/editor-concepts?view=vs-2022#itextviewsnapshot) opens a copy of the text document in the Visual Studio extension. Since extensions run in a separate process, all extension interactions are asynchronous, cooperative, and have some caveats:

> [!CAUTION]
> `GetTextDocumentAsync` might fail if called on an old `ITextDocument`, because it may no longer be cached by the Visual Studio client, if the user has made many changes since it was created. For  this reason, if you plan to store an `ITextView` to access its document later, and can't tolerate failure, it may be a good idea to call `GetTextDocumentAsync` immediately. Doing so fetches the text content for that version of the document into your extension, ensuring that a copy of that version is sent to your extension before it expires.

> [!CAUTION]
> `GetTextDocumentAsync` or `MutateAsync` might fail if the user closes the document.

#### Concurrent execution

:warning: | Editor extensions can sometimes run concurrently
:---: | :---

The initial release has a known issue that can result in concurrent execution of editor extension code. Each async method is guaranteed to be called in the correct order but continuations after the first `await` may be interleaved. If your extension relies on execution order, consider maintaining a queue of incoming requests to preserve the order, until this issue is fixed.

For more information, see [StreamJsonRpc Default Ordering and Concurrency](https://github.com/microsoft/vs-streamjsonrpc/blob/main/doc/resiliency.md#default-ordering-and-concurrency-behavior).

## Extending Visual Studio editor with a new margin

Extensions can contribute new text view margins to the Visual Studio editor. A text view margin is a rectangular UI control attached to a text view on one of its four sides. 

Text view margins are placed into a margin container (see [ContainerMarginPlacement.KnownValues](/dotnet/api/microsoft.visualstudio.extensibility.editor.containermarginplacement.knownvalues)) and ordered before or after relatively to other margins (see [MarginPlacement.KnownValues](/dotnet/api/microsoft.visualstudio.extensibility.editor.marginplacement.knownvalues)).

Text view margin providers implement [ITextViewMarginProvider](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewmarginprovider) interface, configure the margin they provide by implementing [TextViewMarginProviderConfiguration](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewmarginprovider.textviewmarginproviderconfiguration) and when activated, provide UI control to be hosted in the margin via [CreateVisualElementAsync](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewmarginprovider.createvisualelementasync).

Because extensions in VisualStudio.Extensibility might be out-of-process from the Visual Studio, we can't directly use WPF as a presentation layer for content of text view margins. Instead, providing a content to a text view margin requires creating a [RemoteUserControl](./../inside-the-sdk/remote-ui.md#create-the-remote-user-control) and the corresponding data template for that control. While there are some simple examples below, we recommend reading the [Remote UI documentation](./../inside-the-sdk/remote-ui.md) when creating text view margin UI content.

```csharp
/// <summary>
/// Configures the margin to be placed to the left of built-in Visual Studio line number margin.
/// </summary>
public TextViewMarginProviderConfiguration TextViewMarginProviderConfiguration => new(marginContainer: ContainerMarginPlacement.KnownValues.BottomRightCorner)
{
    Before = new[] { MarginPlacement.KnownValues.RowMargin },
};

/// <summary>
/// Creates a remotable visual element representing the content of the margin.
/// </summary>
public async Task<IRemoteUserControl> CreateVisualElementAsync(ITextViewSnapshot textView, CancellationToken cancellationToken)
{
    var documentSnapshot = await textView.GetTextDocumentAsync(cancellationToken);
    var dataModel = new WordCountData();
    dataModel.WordCount = CountWords(documentSnapshot);
    this.dataModels[textView.Uri] = dataModel;
    return new MyMarginContent(dataModel);
}
```

In addition to configuring margin placement, text view margin providers can also configure the size of the grid cell in which the margin should be placed using [GridCellLength](/dotnet/api/microsoft.visualstudio.extensibility.editor.textviewmarginproviderconfiguration.gridcelllength) and [GridUnitType](/dotnet/api/microsoft.visualstudio.extensibility.editor.textviewmarginproviderconfiguration.gridunittype) properties.

Text view margins typically visualize some data related to the text view (for example, current line number or the count of errors) so most text view margin providers would also want to [listen to text view events](#add-a-text-view-listener) to react to opening, closing of text views and user typing.

Visual Studio only creates one instance of your text view margin provider regardless of how many applicable text views a user opens, so if your margin displays some stateful data, your provider needs to keep the state of currently open text views.

For more information, see [Word Count Margin Sample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/WordCountMargin/).

Vertical text view margins whose content needs to be aligned with text view lines are not yet supported.

## Extending Visual Studio editor with a new Code Lens

Extensions can contribute new Code Lenses to the Visual Studio editor. A Code Lens is a visual indicator displayed above lines of text providing actionable contextual information such as number of references to a code element, results of the last unit test run or actions to run/debug a unit test.

### Text view Code Lens
Text view Code Lens provide text-based information to segments of code. This is the simplest forms of Code Lens. The following concepts illustrate how to create a text view Code Lens:
- [`ICodeLensProvider`](/dotnet/api/microsoft.visualstudio.extensibility.editor.icodelensprovider) interface is the main interface to implement. Your implementation of this interface will define when your Code Lens will be activated, and which segments of code your Code Lens will be applicable to, and how it will be displayed.
- Within your implementation of [`ICodeLensProvider`](/dotnet/api/microsoft.visualstudio.extensibility.editor.icodelensprovider), you will need to define when the Code Lens should be activated by implementing [`CodeLensProviderConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelensproviderconfiguration).
- You will also need to implement the [`TryCreateCodeLensAsync`](/dotnet/api/microsoft.visualstudio.extensibility.editor.icodelensprovider.trycreatecodelensasync) method. This method will be invoked when your Code Lens is activated. In this method, you can define how you want your Code Lens to be displayed and when it should be displayed. This method returns an instance of [`CodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens).
- You will need to create your own sub-class of [`CodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens), where you get to define how you want your display text to appear through the [`GetLabelAsync`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens.getlabelasync) method. This method returns an instance of [`CodeLensLabel`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelenslabel), which you can use to configure the text, tooltip, and an optional icon.

### Invokable Code Lens
Invokable Code Lens allows extensions to perform some action (e.g. run a unit test) when user clicks on the Code Lens. Extensions can contribute invokable Code Lens by implementing [`InvokableCodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.invokablecodelens), which derives from [`CodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens).

### Visual Code Lens
Visual Code Lens allows extensions to provide custom UI, like a list of references to a method, to be displayed in a popup above the Code Lens when user clicks on the Code Lens. Extensions can contribute visual Code Lens by implementing [`VisualCodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.visualcodelens), which derives from [`CodeLens`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelens). Similar to text view margins, because extensions in VisualStudio.Extensibility might be out-of-process from the Visual Studio, visual Code Lenses provide UI by creating a [`RemoteUserControl`](./../inside-the-sdk/remote-ui.md) and the corresponding data template for that control. While there are some simple examples below, we recommend reading the [Remote UI documentation](./../inside-the-sdk/remote-ui.md) when creating visual Code Lens' UI content.

The sample code below demonstrates how to create a text view Code Lens and an invokable Code Lens:

```csharp
public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
{
    AppliesTo = new[]
    {
        DocumentFilter.FromDocumentType(DocumentType.KnownValues.Code),
    },
};

public CodeLensProviderConfiguration CodeLensProviderConfiguration =>
    new("CodeLens Sample Provider") {};

public Task<CodeLens?> TryCreateCodeLensAsync(CodeElement codeElement, CodeElementContext codeElementContext, CancellationToken token)
{
    if (codeElement.Kind == CodeElementKind.KnownValues.Method)
    {
        return Task.FromResult<CodeLens?>(new ClickableCodeLens(codeElement, this.Extensibility));
    }
    
    return Task.FromResult<CodeLens?>(new WordCountCodeLens(codeElement, codeElementContext, this.Extensibility, this));
}

...

public class ClickableCodeLens : InvokableCodeLens
{
    public override Task ExecuteAsync(CodeElementContext codeElementContext, IClientContext clientContext, CancellationToken cancelToken)
    {
        this.clickCount++;
        this.Invalidate();
        return Task.CompletedTask;
    }

    public override Task<CodeLensLabel> GetLabelAsync(CodeElementContext codeElementContext, CancellationToken token)
    {
        return Task.FromResult(new CodeLensLabel()
        {
            Text = this.clickCount == 0 ? "Click me" : $"Clicked {this.clickCount} times",
            Tooltip = "Invokable CodeLens Sample Tooltip",
        });
    }
}

public class WordCountCodeLens : VisualCodeLens
{   
    public override Task<IRemoteUserControl> GetVisualizationAsync(CodeElementContext codeElementContext, IClientContext clientContext, CancellationToken token)
    {
        return Task.FromResult<IRemoteUserControl>(new WordCountCodeLensVisual(this.wordCountData));
    }

    public override Task<CodeLensLabel> GetLabelAsync(CodeElementContext codeElementContext, CancellationToken token)
    {
        this.wordCountData.WordCount = CountWords(codeElementContext.Range);
        return Task.FromResult(new CodeLensLabel()
        {
            Text = $"Words: {this.wordCountData.WordCount}",
            Tooltip = "Number of words in this code element",
        });
    }
}
```

In addition to configuring Code Lens provider display name, Code Lens providers can also configure priority of their Code Lens. The priority value is used to determine the relative ordering of your Code Lens respective to other Code Lenses. This is done through the [`Priority`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelensproviderconfiguration.priority) property in the [`CodeLensProviderConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.editor.codelensproviderconfiguration) object.

Code Lenses typically visualize some data related to the text view. For example, they might want to display the number of references to a method. To do so, your Code Lens provider should also [listen to text view events](#add-a-text-view-listener) to react to opening, closing of text views and user typing.

Visual Studio only creates one instance of your Code Lens provider regardless of how many applicable text views a user opens. This means that if your Code Lens needs to maintain state, you need to ensure your Code Lens provider has a way to keep the state of currently open text views.

For more information, see [Code Lens Sample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/CodeLensSample/).

*Contributing Code Lenses to new documents types (or existing document types not supporting Code Lens) is not yet supported.*

## Related content

Learn about the editor interfaces and types at [Editor concepts](editor-concepts.md).

Review sample code for a simple editor-based extension:

- [DocumentSelectorSample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/DocumentSelectorSample/)

Advanced users might wish to learn about the [Editor RPC support](editor-rpc.md).
