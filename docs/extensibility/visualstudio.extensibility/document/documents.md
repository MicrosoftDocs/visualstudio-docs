---
title: Documents overview
description: An overview of extensibility documents
author: tinaschrepfer
ms.author: tinali
monikerRange: ">=vs-2022"
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
ms.topic: overview
ms.date: 02/10/2023
---

# Extend Visual Studio documents

A document is the in-memory representation of a file that is opened in Visual Studio.  It is referred to by
*moniker*, which is an absolute `Uri` using the `file://` scheme.  A document is represented by the `DocumentSnapshot`
class, which has the following properties:

- `Moniker`
- `IsDirty`
- `IsReadOnly`
- `IsInitialized`

The [`DocumentsExtensibility`](/dotnet/api/microsoft.visualstudio.extensibility.documentsextensibility) object provides various methods that are used to obtain and work with `DocumentSnapshot` object instances.

## Work with documents

This guide is designed to cover the top user scenarios when working with documents:

- [Open a document](#open-a-document)
- [Get a text document snapshot](#get-a-text-document-snapshot)
- [React to events related to documents](#react-to-events-related-to-documents)

### Open a document

Given the path to a file on disk, it's simple to open the file in Visual Studio:

```csharp
DocumentsExtensibility documents = this.Extensibility.Documents();

Uri uri = new Uri(@"C:\path\to\Class1.cs", UriKind.Absolute);
DocumentSnapshot document = await documents.OpenDocumentAsync(uri, cancellationToken);

// optionally do something with the document
```

### Get a text document snapshot

A `DocumentSnapshot` is an abstract representation of a document.  If you want to read or write the text in a
`DocumentSnapshot`, you can do so using the [`ITextDocumentSnapshot`](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextdocumentsnapshot) interface, which can be obtained with the
[`AsTextDocumentAsync`](/dotnet/api/microsoft.visualstudio.extensibility.documentextensions.astextdocumentasync) extension method for `DocumentSnapshot`.

```csharp
public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
{
    DocumentsExtensibility documents = this.Extensibility.Documents();

    Uri moniker = await context.GetSelectedPathAsync(cancellationToken);
    DocumentSnapshot document = await documents.GetDocumentAsync(moniker, cancellationToken);
    ITextDocumentSnapshot snapshot = await document.AsTextDocumentAsync(this.Extensibility, cancellationToken);

    // insert the current date/time
    EditorExtensibility editor = this.Extensibility.Editor();
    using ITextViewSnapshot textView = await context.GetActiveTextViewAsync(cancellationToken);

    await editor.EditAsync(
        batch => snapshot.AsEditable(batch).Replace(textView.Selection.Extent, DateTime.Now.ToString()),
        cancellationToken);
}
```

### React to events related to documents

There are scenarios when components may want to react to events related to documents (that is, when they're opened, closed, or saved).  This can be accomplished by implementing the `IDocumentEventsListener` interface, and using [`DocumentsExtensibility.SubscribeAsync`](/dotnet/api/microsoft.visualstudio.extensibility.documentsextensibility.subscribeasync) to set up the event subscription.

```csharp
internal sealed class SubscribeCommand : Command, IToggleCommand
{
    private IDisposable? subscription;

    bool? IToggleCommand.IsChecked => this.subscription is not null;

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
    {
        if (this.subscription is null)
        {
            // subscribe for events
            this.subscription = await Subscription.CreateInstanceAsync(this.Extensibility, cancellationToken);
        }
        else
        {
            // remove the event subscription
            this.subscription.Dispose();
            this.subscription = null;
        }

        this.OnPropertyChanged(new PropertyChangedEventArgs(nameof(IToggleCommand.IsChecked)));
    }

    private class Subscription : IDisposable, IDocumentEventsListener
    {
        private readonly OutputWindowExtensibility output;
        private IDisposable? rawSubscription;

        private Subscription(VisualStudioExtensibility extensibility)
        {
            this.output = extensibility.Views().Output;
        }

        public static async Task<Subscription> CreateInstanceAsync(
            VisualStudioExtensibility extensibility,
            CancellationToken cancellationToken)
        {
            var subscription = new Subscription(extensibility);

            DocumentsExtensibility documents = extensibility.Documents();
            subscription.rawSubscription = await documents.SubscribeAsync(subscription, filterRegex: null, cancellationToken);

            return subscription;
        }

        public void Dispose()
        {
            this.rawSubscription?.Dispose();
            this.rawSubscription = null;
        }

        Task IDocumentEventsListener.ClosedAsync(DocumentEventArgs e, CancellationToken token)
        {
            string text = $"IDocumentEventsListener.ClosedAsync ({e.Moniker})";
            return this.OutputEventTextAsync(text, token);
        }

        Task IDocumentEventsListener.HiddenAsync(DocumentEventArgs e, CancellationToken token)
        {
            string text = $"IDocumentEventsListener.HiddenAsync ({e.Moniker})";
            return this.OutputEventTextAsync(text, token);
        }

        Task IDocumentEventsListener.OpenedAsync(DocumentEventArgs e, CancellationToken token)
        {
            string text = $"IDocumentEventsListener.OpenedAsync ({e.Moniker})";
            return this.OutputEventTextAsync(text, token);
        }

        Task IDocumentEventsListener.RenamedAsync(RenamedDocumentEventArgs e, CancellationToken token)
        {
            string text = $"IDocumentEventsListener.RenamedAsync ({e.OldMoniker} -> {e.Moniker})";
            return this.OutputEventTextAsync(text, token);
        }

        Task IDocumentEventsListener.SavedAsync(DocumentEventArgs e, CancellationToken token)
        {
            string text = $"IDocumentEventsListener.SavedAsync ({e.Moniker})";
            return this.OutputEventTextAsync(text, token);
        }

        Task IDocumentEventsListener.SavingAsync(DocumentEventArgs e, CancellationToken token)
        {
            string text = $"IDocumentEventsListener.SavingAsync ({e.Moniker})";
            return this.OutputEventTextAsync(text, token);
        }

        Task IDocumentEventsListener.ShownAsync(DocumentEventArgs e, CancellationToken token)
        {
            string text = $"IDocumentEventsListener.ShownAsync ({e.Moniker})";
            return this.OutputEventTextAsync(text, token);
        }

        private async Task OutputEventTextAsync(string text, CancellationToken token)
        {
            using OutputWindow outputWindow = await this.output.GetChannelAsync(
                identifier: "Document Sample Command Output",
                displayNameResourceId: nameof(Strings.DocumentsSampleOutputWindowPaneName),
                token);

            await outputWindow.Writer.WriteLineAsync($"Event received: {text}");
        }
    }
}
```

## Next steps

- Follow the [create the project](../get-started/create-your-first-extension.md) quickstart in the Getting Started section.
