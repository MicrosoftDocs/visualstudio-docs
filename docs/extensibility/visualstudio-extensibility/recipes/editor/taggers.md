---
title: Create editor taggers
description: Learn how to create taggers that associate data with text ranges for text highlighting, CodeLens integration, and syntax classification.
ms.date: 09/29/2026
ms.topic: how-to
ms.author: maprospe
monikerRange: ">=vs-2022"
author: matteo-prosperi
ms.manager:  tinaschrepfer
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# Create editor taggers

Taggers annotate text spans with data that drives editor features such as text highlighting, CodeLens indicators, and syntax classification. These features consume the tags produced by taggers.

Common scenarios include highlighting text patterns and providing CodeLens tags. If you need syntax coloring, see [syntax highlighting](syntax-highlighting.md), which uses classification tags.

> [!NOTE]
> This guide uses the **VisualStudio.Extensibility** SDK. See [Choose the right extensibility model](../../how-it-works/models/extensibility-models.md) for model comparison.

## Full example

The text marker tagger provider:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/TaggersSample/MarkdownTextMarkerTaggerProvider.cs":::

> [!TIP]
> See the full working sample: [TaggersSample ↗](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/TaggersSample) — text marker and CodeLens taggers with performance optimization.

**Related concepts:** [Editor concepts](editor-concepts.md) — text view lifecycle, taggers, and editor architecture

## Understand the example

**When to use taggers vs. alternatives:**

- Highlight or mark text spans with colors/styles → **taggers** with `TextMarkerTag` (this page)
- Drive CodeLens with tagged data → **taggers** with `CodeLensTag` (this page) + [CodeLens provider](codelens.md)
- Syntax coloring for a language → [classification taggers](syntax-highlighting.md)
- Error/warning squiggles for C#/VB → prefer Roslyn analyzers or LSP diagnostics
- Per-line gutter icons → [margins](margins.md) with glyph factory

### Supported tag types

Extensions can contribute new taggers to Visual Studio. `VisualStudio.Extensibility` supports tag types that implement the [ITag ↗](/dotnet/api/microsoft.visualstudio.extensibility.editor.itag) interface:

- `CodeLensTag` is used together with an [ICodeLensProvider](./codelens.md) to add CodeLens to documents.
- `TextMarkerTag` is used to highlight portions of documents with a built-in or extension-defined `TextMarkerStyleConfiguration`.
- `ClassificationTag` is used to classify a document's syntax, which allows for the text to be colorized accordingly.

### How to create a tagger

Contribute a provider for each tag type. The built-in `TextViewTaggerProvider<TTag, TTagger>` creates and manages taggers for matching documents and forwards text view changes. It implements the necessary interfaces, so the common case needs no manual tagger registry or change listener:

```csharp
[VisualStudioContribution]
internal class MarkdownTextMarkerTaggerProvider : TextViewTaggerProvider<TextMarkerTag, MarkdownTextMarkerTagger>
{
    public override TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = [DocumentFilter.FromDocumentType("vs-markdown")],
    };
}
```

Derive the tagger from `TextViewTagger<TextMarkerTag>` and override its two callbacks. The base class serializes tag requests and aggregated text view changes, and exposes the associated document URI. The built-in provider manages the taggers' lifetime, so this pattern needs no manual disposal:

```csharp
internal class MarkdownTextMarkerTagger : TextViewTagger<TextMarkerTag>
{
    protected override Task OnRequestTagsAsync(
        NormalizedTextRangeCollection requestedRanges,
        bool recalculateAll,
        CancellationToken cancellationToken)
    {
        if (requestedRanges.Count == 0)
        {
            return Task.CompletedTask;
        }

        return this.CreateTagsAsync(requestedRanges.TextDocumentSnapshot!, requestedRanges);
    }

    protected override async Task OnTextViewChangedAsync(
        TextViewChangedArgs args,
        CancellationToken cancellationToken)
    {
        if (args.Edits.Count == 0)
        {
            return;
        }

        var allRequestedRanges = await this.GetAllRequestedRangesAsync(
            args.AfterTextView.Document, cancellationToken);
        await this.CreateTagsAsync(
            args.AfterTextView.Document,
            allRequestedRanges.Intersect(
                args.Edits.Select(e => EnsureNotEmpty(e.RangeAfterEdit))));
    }

    // See the full sample for EnsureNotEmpty and CreateTagsAsync.
}
```

`OnRequestTagsAsync` receives the ranges Visual Studio wants tagged. `OnTextViewChangedAsync` receives edits to a document; use `RangeAfterEdit` for ranges in the current snapshot. A deletion can produce an empty range, so expand it before intersecting with previously requested ranges. See the [complete tagger ↗](https://github.com/microsoft/VSExtensibility/blob/main/New_Extensibility_Model/Samples/TaggersSample/MarkdownTextMarkerTagger.cs) for `EnsureNotEmpty` and `CreateTagsAsync`.

`CreateTagsAsync` extends those ranges to complete Markdown lines, creates a `TaggedTrackingTextRange<TextMarkerTag>` for each heading, and calls `UpdateTagsAsync` with **both** the processed ranges and the new tags. This replaces the cached tags in those ranges; include processed ranges with no tags to clear stale highlighting. Limit work to requested or edited ranges where possible.

The sample's [CodeLens tagger ↗](https://github.com/microsoft/VSExtensibility/blob/main/New_Extensibility_Model/Samples/TaggersSample/MarkdownCodeLensTagger.cs) recalculates its section IDs only when a heading changes, because earlier headings can affect later IDs.

If you handle text view changes in a non-tagger component, `TextViewChangesAggregator` can combine successive edits. See the [WordCountMargin provider ↗](https://github.com/microsoft/VSExtensibility/blob/main/New_Extensibility_Model/Samples/WordCountMargin/TextViewMarginProvider.cs). `TextViewTagger<T>` already uses this aggregation internally.

### Define a custom marker style

A VisualStudio.Extensibility extension can contribute a `TextMarkerStyleConfiguration` and use it in its tags. Provide at least light and dark colors; for high contrast, use system colors. The Markdown tagger defines a style with a dashed border and themed background:

```csharp
[VisualStudioContribution]
private static TextMarkerStyleConfiguration HeaderStyle { get; } = new(
    "MarkerFormatDefinition/TaggersSample.MarkdownHeader",
    "%TaggersSample.MarkdownTextMarkerTagger.HeaderStyle.DisplayName%")
{
    BorderDashStyle = PenDashStyle.Dash,
    BorderThickness = 2,
    ThemedColors = new()
    {
        [Theme.KnownValues.Light] = new(
            BackgroundColor: UIColor.KnownColors.LightSeaGreen,
            BorderColor: 0xFFFF0000),
        [Theme.KnownValues.Dark] = new(
            BackgroundColor: UIColor.KnownColors.Teal,
            BorderColor: UIColor.Rgb(r: byte.MaxValue, 0, 0)),
        [Theme.KnownValues.HighContrast] = new(
            BackgroundColor: UIColor.SysColors.COLOR_HIGHLIGHT,
            BorderColor: UIColor.SysColors.COLOR_HIGHLIGHTTEXT),
    },
};
```

The tag uses `new TextMarkerTag(HeaderStyle)` rather than a built-in marker style. Localize the display name so users can recognize the style.

## Tips

### ✅ DO

- Implement `OnRequestTagsAsync` and `OnTextViewChangedAsync`
- Intersect edited ranges with previously requested ranges to avoid unnecessary work
- Convert requested ranges to meaningful document sections (for example, full lines)
- Include processed ranges with no new tags to clear obsolete tags after an edit

### ❌ DON'T

- Don't create a manual registry of active taggers when using `TextViewTaggerProvider<TTag, TTagger>`
- Don't use a classification type that hasn't been registered; use a known value or contribute a custom type

### 🔧 Troubleshooting

| Symptom | Fix |
|---------|-----|
| Tags not appearing | Verify `AppliesTo` document filter matches the file type |
| Tags disappear after edits | Ensure `OnTextViewChangedAsync` recalculates affected ranges and calls `UpdateTagsAsync` |
| Editor lag when typing | Limit recalculation to requested ranges and edits when possible |
| Old tags remain after deletion | Include the affected range and an empty tag list in `UpdateTagsAsync` |
| Custom marker style not applied | Check that the style is contributed and the tag references it; provide light and dark theme colors |

## Next steps

- [Syntax highlighting](syntax-highlighting.md) — specialized classification tagger
- [CodeLens](codelens.md) — uses `CodeLensTag` from taggers
- [Editor margins](margins.md) — visual annotations alongside text
