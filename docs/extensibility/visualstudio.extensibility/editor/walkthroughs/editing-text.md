---
title: Change Text in the Editor
description: This walkthrough shows you how to change text in the Visual Studio editor by using extensions.
ms.date: 1/13/2025
ms.topic: how-to
ms.author: tinali
monikerRange: ">=vs-2022"
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# Change text in the editor

Edits are changes to a text document open in the Visual Studio editor. Edits might arise from user interactions in Visual Studio or programmatic changes from language services and other extensions. Your extension must be prepared to deal with changes in the document text that occur in real time.

Extensions that run outside the main Visual Studio integrated development environment (IDE) process use asynchronous design patterns to communicate with the Visual Studio IDE process. This behavior means the use of asynchronous method calls, as indicated by the `async` keyword in C# and reinforced by the `Async` suffix on method names. Asynchronicity is a significant advantage in the context of an editor that users expect to respond to their actions.

If a traditional synchronous API call takes longer than expected, it stops responding to user input. This situation creates a UI freeze that lasts until the API call finishes. Users of modern interactive applications expect text editors to always remain responsive and never block them from working. To meet these user expectations, it's essential to have asynchronous extensions.

Learn more about asynchronous programming at [Asynchronous programming with async and await](/dotnet/csharp/programming-guide/concepts/async/).

In the new Visual Studio extensibility model, the extension is second class relative to the user. It can't directly modify the editor or the text document. All state changes are asynchronous and cooperative. The Visual Studio IDE performs the requested change for the extension. The extension can request one or more changes on a specific version of the document or text view. Changes from an extension might be rejected, for example, if that area of the document changed.

Edits are requested by using the `EditAsync()` method on [`EditorExtensibility`](/dotnet/api/microsoft.visualstudio.extensibility.editor.editorextensibility).

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

To avoid misplaced edits, edits from editor extensions are applied in the following manner:

1. The extension requests that an edit is made based on its most recent version of the document.
1. That request might contain one or more text edits, caret position changes, and so on. You can change any type that implements `IEditable` in a single `EditAsync()` request, including `ITextViewSnapshot` and `ITextDocumentSnapshot`. The editor does the edits. You can request edits on a specific class via `AsEditable()`.
1. Edit requests are sent to the Visual Studio IDE. They succeed only if the object being mutated didn't change since the version on which the request was made. If the document did change, the change might be rejected. The extension then must retry on a newer version. The outcome of the mutation operation is stored in `result`.
1. Edits are applied atomically, which means there are no interruptions from other executing threads. The best practice is to make all changes that should occur within a narrow time frame in a single `EditAsync()` call. This practice reduces the likelihood of unexpected behavior that arises from user edits or language service actions that occur between edits. (An example is extension edits that get interleaved because Roslyn C# moved the caret.)

## Change caret position or select text from an extension

Editing a text document from an extension implicitly affects caret position. For example, inserting some text at the caret moves the caret to the end of the inserted text. Extensions can also use [`ITextViewSnapshot.AsEditable().SetSelections()`](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextvieweditor.setselections) to set the caret explicitly to a different position or make text selections. To illustrate, the following code inserts some text but keeps the caret at the original position.

```csharp
await this.Extensibility.Editor().EditAsync(batch =>
{
    var caret = textView.Selection.Extent.Start;
    textView.Document.AsEditable(batch).Replace(textView.Selection.Extent, newGuidString);
    textView.AsEditable(batch).SetSelections([new Selection(activePosition: caret, anchorPosition: caret, insertionPosition: caret)]);
},
cancellationToken);
```

#### Concurrent execution

:warning: | Editor extensions can sometimes run concurrently.
:---: | :---

The initial release has a known issue that can result in concurrent execution of editor extension code. Each async method is called in the correct order, but continuations after the first `await` might be interleaved. If your extension relies on execution order, consider maintaining a queue of incoming requests to preserve the order until this issue is fixed.

For more information, see [StreamJsonRpc default ordering and concurrency](https://github.com/microsoft/vs-streamjsonrpc/blob/main/docfx/docs/resiliency.md#default-ordering-and-concurrency-behavior).
