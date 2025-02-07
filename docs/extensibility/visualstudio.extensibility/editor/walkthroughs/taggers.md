---
title: Customizing taggers in the editor
description: A walkthrough of how to provide your own taggers in the Visual Studio editor using extensions
ms.date: 2/5/2025
ms.topic: conceptual
ms.author: maprospe
monikerRange: ">=vs-2022"
author: matteo-prosperi
manager: tinaschrepfer
ms.subservice: extensibility-integration
---

# Extending Visual Studio editor with a new tagger
Extensions can contribute new taggers to Visual Studio. Taggers are used to associate data with spans of text, such data is consumed by other Visual Studio features (E.g., [CodeLens](./codelens.md)).

VisualStudio.Extensibility only supports tag types that are provided by the [Microsoft.VisualStudio.Extensibility](https://www.nuget.org/packages/Microsoft.VisualStudio.Extensibility) package and implement the `Microsoft.VisualStudio.Extensibility.Editor.ITag` interface:

- `CodeLensTag` can be used together with an [ICodeLensProvider](./codelens.md) to add Code Lenses to documents
- `TextMarkerTag` can be used to highlight portions of documents. VisualStudio.Extensibility doesn't support defining new Text Marker styles yet, so only styles that are built into Visual Studio or provided by a VSSDK extension can be used for now (a [VisualStudio.Extensibility in-proc extension](../../get-started/in-proc-extensions.md) can create Text Marker styles with an `[Export(typeof(EditorFormatDefinition))]`).

To generate tags, the extension must contribute an extension part that implements `ITextViewTaggerProvider<>` for the type (or types) of tags provided. The extension part generally also need to implement `ITextViewChangedListener` to react to document changes:

```csharp
[VisualStudioContribution]
internal class MarkdownCodeLensTaggerProvider : ExtensionPart, ITextViewTaggerProvider<CodeLensTag>, ITextViewChangedListener
{
    public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = [DocumentFilter.FromDocumentType("vs-markdown")],
    };

    public async Task TextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
    {
        ...
    }

    public Task<TextViewTagger<CodeLensTag>> CreateTaggerAsync(ITextViewSnapshot textView, CancellationToken cancellationToken)
    {
        ...
    }
}
```

The tagger provider has to keep track of the active taggers in order to dispatch the `TextViewChangedAsync` notifications to them. This is a full implementation:

```csharp
[VisualStudioContribution]
internal class MarkdownCodeLensTaggerProvider : ExtensionPart, ITextViewTaggerProvider<CodeLensTag>, ITextViewChangedListener
{
    private readonly object lockObject = new();
    private readonly Dictionary<Uri, List<MarkdownCodeLensTagger>> taggers = new();

    public TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = [DocumentFilter.FromDocumentType("vs-markdown")],
    };

    public async Task TextViewChangedAsync(TextViewChangedArgs args, CancellationToken cancellationToken)
    {
        List<Task> tasks = new();
        lock (this.lockObject)
        {
            if (this.taggers.TryGetValue(args.AfterTextView.Uri, out var textMarkerTaggers))
            {
                foreach (var textMarkerTagger in textMarkerTaggers)
                {
                    tasks.Add(textMarkerTagger.TextViewChangedAsync(args.AfterTextView, args.Edits, cancellationToken));
                }
            }
        }

        await Task.WhenAll(tasks);
    }

    public Task<TextViewTagger<CodeLensTag>> CreateTaggerAsync(ITextViewSnapshot textView, CancellationToken cancellationToken)
    {
        var tagger = new MarkdownCodeLensTagger(this, textView.Document.Uri);
        lock (this.lockObject)
        {
            if (!this.taggers.TryGetValue(textView.Document.Uri, out var taggers))
            {
                taggers = new();
                this.taggers[textView.Document.Uri] = taggers;
            }

            taggers.Add(tagger);
        }

        return Task.FromResult<TextViewTagger<CodeLensTag>>(tagger);
    }

    internal void RemoveTagger(Uri documentUri, MarkdownCodeLensTagger toBeRemoved)
    {
        lock (this.lockObject)
        {
            if (this.taggers.TryGetValue(documentUri, out var taggers))
            {
                taggers.Remove(toBeRemoved);
                if (taggers.Count == 0)
                {
                    this.taggers.Remove(documentUri);
                }
            }
        }
    }
}
```

The tagger itself, is a class implementing `TextViewTagger<>`:

```csharp
internal class MarkdownCodeLensTagger : TextViewTagger<CodeLensTag>
{
    private readonly MarkdownCodeLensTaggerProvider provider;
    private readonly Uri documentUri;

    public MarkdownCodeLensTagger(MarkdownCodeLensTaggerProvider provider, Uri documentUri)
    {
        this.provider = provider;
        this.documentUri = documentUri;
    }

    public override void Dispose()
    {
        this.provider.RemoveTagger(this.documentUri, this);
        base.Dispose();
    }

    public async Task TextViewChangedAsync(ITextViewSnapshot textView, IReadOnlyList<TextEdit> edits, CancellationToken cancellationToken)
    {
        ...
        await this.UpdateTagsAsync(ranges, tags, cancellationToken);
    }

    protected override async Task RequestTagsAsync(NormalizedTextRangeCollection requestedRanges, bool recalculateAll, CancellationToken cancellationToken)
    {
        ...
        await this.UpdateTagsAsync(ranges, tags, cancellationToken);
    }
}
```

Both the `TextViewChangedAsync` and `RequestTagsAsync` methods, should call `UpdateTagsAsync` providing the ranges that tags are being updated for and the new tags themselves. The `TextViewTagger<>` base class holds a cache of previously generated tags, calling `UpdateTagsAsync` invalidates all existing tags for the provided ranges and replaces them with the newly provided ones.

While generating tags for the entire document is a possible strategy, it is preferrable to only generate tags for the requested ranges (in `RequestTagsAsync`) and the edited ranges (in `TextViewChangedAsync`). It is also common to have to extend such ranges to cover meaningful spans of the document syntax (E.g., entire statements, entire lines of code, etc.).

Handling text view changes in particular requires some additional code. This is an example:

```csharp
public async Task TextViewChangedAsync(ITextViewSnapshot textView, IReadOnlyList<TextEdit> edits, CancellationToken cancellationToken)
{
    // GetAllRequestedRangesAsync returns all ranges that Visual Studio has requested
    // tags for so far.
    var allRequestedRanges = await this.GetAllRequestedRangesAsync(textView.Document, cancellationToken);

    // Translate edited ranges to the current document snapshot
    var editedRanges = edits.Select(e => e.Range.TranslateTo(textView.Document, TextRangeTrackingMode.EdgeInclusive));

    // Extend 0-length ranges to be at least 1 character so that they are not ignored
    // when passed to `Intersect`
    var fixedEditedRanges = editedRanges.Select(e => EnsureNotEmpty(editedRanges));

    // Intersect the edited ranges with the requested ranges to avoid generating tags
    // for ranges that Visual Studio is not interested in (E.g., non-visible portions
    // of the document)
    var rangesOfInterest = allRequestedRanges.Intersect(fixedEditedRanges);

    // Extend ranges to match meaningful portions of the document's syntax
    var rangesToCalculateTagsFor = ExtendToMatchSyntax(rangesOfInterest);

    // Calculate tags
    await this.CreateTagsAsync(textView.Document, rangesToCalculateTagsFor);
}

private static TextRange EnsureNotEmpty(TextRange range)
{
    ...
}

private static IEnumerable<TextRange> ExtendToMatchSyntax(IEnumerable<TextRange> range)
{
    ...
}

private async Task CreateTagsAsync(ITextDocumentSnapshot document, IEnumerable<TextRange> requestedRanges)
{
    ...
    await this.UpdateTagsAsync(ranges, tags, cancellationToken);
}
```

If generating tags requires significant computation (E.g., it's necessary to parse the entire document, or large portions of it, in order to generate tags), the tagger should have additional synchronization logic to avoid calculating tags for every text view change or call to `RequestTagsAsync`. Instead, `RequestTagsAsync` and `TextViewChangedAsync` should quickly return a completed task, multiple requests should be batched together, and `UpdateTagsAsync` should be called when the batched tag generation is completed. The [tagger sample extension](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/TaggersSample/README.md) contains a complete example of this approach.
