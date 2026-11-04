---
title: "Read and edit text"
description: "Read document text, make edits, handle selections, and respond to editor events using the VisualStudio.Extensibility SDK."
ms.date: 09/29/2026
ms.topic: how-to
ms.author: jasonc
monikerRange: ">=vs-2022"
author: jasonchlus
manager: mijacobs
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# Read and edit text

Use the VisualStudio.Extensibility editor APIs to read document content, make text edits, handle selections, and respond to editor events. All edits are asynchronous, atomic, and cooperative — the Visual Studio IDE applies your requested changes on your behalf.

> [!NOTE]
> This guide uses the **VisualStudio.Extensibility** SDK. See [Choose the right extensibility model](../../how-it-works/models/extensibility-models.md) for model comparison.

## Related samples

The samples repo includes text-editing samples such as [InsertGuid ↗](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/InsertGuid) and the DocumentEditing feature gallery, which demonstrate `GetActiveTextViewAsync` and `EditAsync`. Additional editor-focused samples demonstrate reacting to text view lifecycle events and filtering which documents an editor part applies to:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/MarkdownLinter/TextViewEventListener.cs":::

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/DocumentSelectorSample/UnitTestRunner.cs":::

> [!TIP]
> See the related samples: [MarkdownLinter ↗](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/MarkdownLinter), [DocumentSelectorSample ↗](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/DocumentSelectorSample), and [InsertGuid ↗](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/InsertGuid) (demonstrates `EditAsync` text modifications).

**Related concepts:** [Editor concepts](editor-concepts.md) — text view lifecycle, document types, and editor architecture, [Editor RPC](editor-rpc.md) — Remote Procedure Call communication between extension and editor

## Understand the example

### Get the active text view

From a command handler, get the currently active text view and its document:

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
{
    using var textView = await context.GetActiveTextViewAsync(ct);
    if (textView is null) return; // No text editor is active

    ITextDocumentSnapshot document = textView.Document;
    string allText = document.Text.CopyToString();  // Full document content
    Uri uri = document.Uri;          // Document URI
}
```

### Read text

#### Read the full document

```csharp
ITextDocumentSnapshot document = textView.Document;
string allText = document.Text.CopyToString();
```

#### Read a specific line

```csharp
ITextDocumentSnapshot document = textView.Document;
ITextDocumentSnapshotLine line = document.Lines[0]; // First line (zero-indexed)
string lineText = line.Text.CopyToString();
```

#### Read the current selection

```csharp
foreach (var selection in textView.Selections)
{
    if (!selection.IsEmpty)
    {
        var span = selection.Extent;
        // Use span.Start and span.Length to read selected text
    }
}
```

### Edit text

All document modifications go through `EditAsync()`. This method batches one or more edits into a single atomic operation and creates an implicit undo transaction.

#### Insert text at a position

```csharp
int position = textView.Selection.Extent.Start;
await this.Extensibility.Editor().EditAsync(
    batch =>
    {
        ITextDocumentSnapshot document = textView.Document;
        var doc = document.AsEditable(batch);
        doc.Insert(position, "inserted text");
    },
    ct);
```

#### Replace text in selections

```csharp
await this.Extensibility.Editor().EditAsync(
    batch =>
    {
        var doc = textView.Document.AsEditable(batch);
        foreach (var selection in textView.Selections)
        {
            if (!selection.IsEmpty)
            {
                doc.Replace(selection.Extent, newText);
            }
        }
    },
    ct);
```

#### Insert text and control caret position

By default, inserting text moves the caret to the end of the insertion. To keep the caret at its original position:

```csharp
await this.Extensibility.Editor().EditAsync(
    batch =>
    {
        var caret = textView.Selection.Extent.Start;
        textView.Document.AsEditable(batch).Replace(textView.Selection.Extent, newText);
        textView.AsEditable(batch).SetSelections(
            [new Selection(activePosition: caret, anchorPosition: caret, insertionPosition: caret)]);
    },
    ct);
```

#### How edits are applied

1. The extension requests edits based on its most recent document snapshot.
1. The request can contain multiple text edits, caret changes, or selection changes. Any type that implements `IEditable` can be changed in a single `EditAsync()` call.
1. The IDE applies the edits only if the document hasn't changed since the snapshot. If it has, the edit is rejected — retry on a newer snapshot.
1. Edits are applied atomically with no interruptions from other threads. Batch all related changes into a single `EditAsync()` call to avoid interleaving.

### Filter by document type

Use `TextViewExtensionConfiguration` with `DocumentFilter` to target specific file types.

#### Filter by glob pattern

```csharp
public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
{
    AppliesTo = [DocumentFilter.FromGlobPattern("**/*.cs", relativePath: false)],
};
```

#### Filter by document type

```csharp
public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
{
    AppliesTo = [DocumentFilter.FromDocumentType("CSharp")],
};
```

Common document types: `CSharp`, `C/C++`, `TypeScript`, `HTML`, `JSON`, `text`, `code`.

Document types are hierarchical — `code` activates for all code languages (C#, C, C++, and so on).

#### Define a custom document type

```csharp
internal static class MyDocumentTypes
{
    [VisualStudioContribution]
    internal static DocumentTypeConfiguration MarkdownDocumentType => new("markdown")
    {
        FileExtensions = [".md", ".mdk", ".markdown"],
        BaseDocumentType = DocumentType.KnownValues.Text,
    };
}
```

#### Glob pattern syntax

| Pattern | Meaning |
|---------|---------|
| `*` | Match zero or more characters in a path segment |
| `?` | Match one character in a path segment |
| `**` | Match any number of path segments, including none |
| `{}` | Group conditions (for example, `**/*.{ts,js}`) |
| `[]` | Character range (for example, `example.[0-9]`) |

> [!NOTE]
> Backslashes aren't valid in glob patterns. Convert backslashes to forward slashes (`/`).

### Listen to editor events

#### Respond to file open and close

Implement `ITextViewOpenClosedListener` to run code when files are opened or closed:

```csharp
[VisualStudioContribution]
internal class MyTextViewListener : ExtensionPart, ITextViewOpenClosedListener
{
    public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = [DocumentFilter.FromGlobPattern("**/*.md", relativePath: false)],
    };

    public async Task TextViewOpenedAsync(ITextViewSnapshot textView, CancellationToken ct)
    {
        // React to file open
    }

    public async Task TextViewClosedAsync(ITextViewSnapshot textView, CancellationToken ct)
    {
        // React to file close
    }
}
```

#### Respond to text changes

Implement `ITextViewChangedListener` to react when the user or another extension modifies the document:

```csharp
[VisualStudioContribution]
internal class MyTextChangeListener : ExtensionPart, ITextViewChangedListener
{
    public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = [DocumentFilter.FromDocumentType("CSharp")],
    };

    public async Task TextViewChangedAsync(TextViewChangedArgs args, CancellationToken ct)
    {
        // Inspect args for what changed
    }
}
```

You can implement both `ITextViewOpenClosedListener` and `ITextViewChangedListener` on the same class. The `TextViewExtensionConfiguration` applies to both.

## Tips

### ✅ DO

- Use `EditAsync()` for all document modifications — edits are batched and atomic.
- Check `selection.IsEmpty` before processing selections.
- Use `DocumentFilter.FromGlobPattern()` to target specific file types.
- Handle multiple selections — Visual Studio supports multi-cursor editing.
- Pass `CancellationToken` on all async calls.

### ❌ DON'T

- Don't modify documents outside of `EditAsync()` — changes won't persist.
- Don't assume a single selection — always iterate `textView.Selections`.
- Don't hold references to `ITextDocumentSnapshot` long-term — it's an immutable snapshot, not a live reference.
- Don't block the editor thread with synchronous work.

### 🔧 Troubleshooting

| Symptom | Fix |
|---------|-----|
| Edits don't appear | Ensure you're using `EditAsync()` and calling methods on `AsEditable(batch)`. |
| Extension only works on certain files | Check `AppliesTo` glob pattern; use `relativePath: false` for absolute paths. |
| Multiple selections ignored | Loop over `textView.Selections` instead of using a single selection. |
| Edit rejected silently | `EditAsync()` returns an `EditResponse` with `Succeeded` and `Message` properties. Check `EditResponse.Succeeded` — the document may have changed since your snapshot. Get a fresh snapshot and retry. |

## Next steps

- [Editor margins](margins.md) — add visual elements beside the editor
- [CodeLens](codelens.md) — add inline information above code lines
- [Taggers](taggers.md) — mark up text with visual indicators
- [Editor concepts](editor-concepts.md) — deep dive on the editor object model

