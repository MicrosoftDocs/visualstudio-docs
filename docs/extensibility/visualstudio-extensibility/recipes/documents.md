---
title: "Documents"
description: "Open, read, and monitor documents in Visual Studio using the VisualStudio.Extensibility SDK."
ms.date: 06/17/2026
ms.topic: how-to
author: jasonchlus
ms.author: jasonc
---

# Documents

Open documents, read their content, and subscribe to lifecycle events (open, save, close, rename).

> [!NOTE]
> This guide uses the **VisualStudio.Extensibility** SDK. See [Choose the right extensibility model](../how-it-works/models/extensibility-models.md) for model comparison.

## Related sample

The samples repo doesn't currently include a standalone `IDocumentEventsListener` sample. The closest related sample listens for text view open, change, and close events on matching documents:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/DocumentSelectorSample/UnitTestRunner.cs":::

> [!TIP]
> See the related sample: [DocumentSelectorSample ↗](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/DocumentSelectorSample/) — it demonstrates document filtering and text view lifecycle events rather than document open/save/rename events.

**Related concepts:** [Editor concepts](editor/editor-concepts.md) — document types and text view lifecycle

## Understand the example

### Open a document

```csharp
DocumentsExtensibility documents = this.Extensibility.Documents();
Uri uri = new Uri(@"C:\path\to\Class1.cs", UriKind.Absolute);
DocumentSnapshot document = await documents.OpenDocumentAsync(uri, cancellationToken);
```

### Read document text

```csharp
ITextDocumentSnapshot snapshot = await document.AsTextDocumentAsync(
    this.Extensibility, cancellationToken);
string allText = snapshot.Text.CopyToString();
```

### Get the active document

```csharp
var textView = await context.GetActiveTextViewAsync(cancellationToken);
if (textView is not null)
{
    var document = textView.Document;
    // Work with document.Uri, document.Text.CopyToString(), etc.
}
```

### Subscribe to document events

Implement `IDocumentEventsListener` and subscribe with `Documents().SubscribeAsync()`:

```csharp
public class MyDocumentListener : IDocumentEventsListener
{
    public Task OpenedAsync(DocumentEventArgs e, CancellationToken ct)
    {
        // React to document open
        return Task.CompletedTask;
    }

    public Task SavedAsync(DocumentEventArgs e, CancellationToken ct)
    {
        // React to document save
        return Task.CompletedTask;
    }

    public Task ClosedAsync(DocumentEventArgs e, CancellationToken ct) => Task.CompletedTask;
    public Task RenamedAsync(RenamedDocumentEventArgs e, CancellationToken ct) => Task.CompletedTask;
    public Task SavingAsync(DocumentEventArgs e, CancellationToken ct) => Task.CompletedTask;
    public Task ShownAsync(DocumentEventArgs e, CancellationToken ct) => Task.CompletedTask;
    public Task HiddenAsync(DocumentEventArgs e, CancellationToken ct) => Task.CompletedTask;
}

// Subscribe (returns IDisposable — dispose to unsubscribe)
var listener = new MyDocumentListener();
IDisposable subscription = await this.Extensibility.Documents()
    .SubscribeAsync(listener, filterRegex: null, cancellationToken);
```

## Tips

### ✅ DO

- Dispose the subscription when you no longer need events
- Use `filterRegex` parameter to limit events to specific file patterns
- Use `AsTextDocumentAsync` to access text content from a `DocumentSnapshot`
- Handle all `IDocumentEventsListener` methods (even if just returning `Task.CompletedTask`)

### ❌ DON'T

- Don't hold `DocumentSnapshot` references long-term — they represent a point-in-time state
- Don't forget to dispose event subscriptions (causes memory leaks)
- Don't assume a document is a text document — call `AsTextDocumentAsync` and check for null

### 🔧 Troubleshooting

| Symptom | Fix |
|---------|-----|
| Events not firing | Ensure `SubscribeAsync` completed; check `filterRegex` isn't filtering too aggressively |
| Document content is stale | Get a fresh snapshot — `DocumentSnapshot` is immutable |
| NullReferenceException on text | Use `AsTextDocumentAsync` — not all documents have text content |

## Next steps

- [Read and edit text](editor/editor.md) — for editing document content
- [Output window](observability/output-window.md) — log document events
- [Add a command](commands/commands.md) — trigger document operations
- [Extension anatomy](../how-it-works/models/extension-anatomy.md) — understand the extension lifecycle
