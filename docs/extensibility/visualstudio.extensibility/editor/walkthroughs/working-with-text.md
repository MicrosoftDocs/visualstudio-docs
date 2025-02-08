---
title: Working with text in the editor
description: A walkthrough of how to read text and track text changes in the Visual Studio editor using extensions
ms.date: 1/13/2025
ms.topic: conceptual
ms.author: tinali
monikerRange: ">=vs-2022"
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
---

# Working with text in the editor

Your extension code can be configured to run in response to various entry points (situations that occur when a user interacts with Visual Studio). Editor extensibility currently supports three entry points: listeners, the [EditorExtensibility](#access-editor-functionality) service object, and commands.

Event listeners get triggered when certain actions occur in an editor window, represented in code by a `TextView`. For example, when a user types something into the editor, a `TextViewChanged` event occurs. When an editor window is opened or closed, `TextViewOpened` and `TextViewClosed` events occur.

The editor service object is an instance of the [`EditorExtensibility`](/dotnet/api/microsoft.visualstudio.extensibility.editor.editorextensibility) class, which exposes real-time editor functionality, such as performing text edits.

[Commands](../../command/command.md) are initiated by the user by clicking on an item, which you can place on a menu, context menu, or toolbar.

## Add a text view listener

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

Once you have `ITextViewSnapshot`, you can access editor state. [`ITextViewSnapshot`](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewsnapshot) is an immutable view of editor state at a point in time, so you need to use the other interfaces in the [Editor object model](./../editor-concepts.md) to make edits.