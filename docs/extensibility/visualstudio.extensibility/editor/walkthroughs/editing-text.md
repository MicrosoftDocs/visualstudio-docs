---
title: Changing text in the editor
description: A walkthrough of how to change text in the Visual Studio editor using extensions
ms.date: 1/13/2025
ms.topic: conceptual
ms.author: tinaschrepfer
monikerRange: ">=vs-2022"
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
---

# Changing text in the editor
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