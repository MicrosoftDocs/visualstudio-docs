---
title: Add syntax highlighting
description: Learn how to add custom syntax highlighting and text colorization to the Visual Studio editor using classification taggers in VisualStudio.Extensibility.
ms.date: 09/29/2026
ms.topic: how-to
ms.author: maprospe
monikerRange: ">=vs-2022"
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# Add syntax highlighting

Syntax highlighting colors code based on its structure — keywords, strings, comments, identifiers, and other token types each get a distinct visual style. This is one of the most common editor extensions and is essential when adding support for a new programming language.

In VisualStudio.Extensibility, syntax highlighting is implemented using classification taggers. A classification tagger examines text and returns `ClassificationTag` values that map text spans to classification types. Visual Studio then applies the corresponding colors and styles from the user's theme.

> [!NOTE]
> This guide uses the **VisualStudio.Extensibility** SDK. See [Choose the right extensibility model](../../how-it-works/models/extensibility-models.md) for model comparison.

## Full example

The CSV tagger provider:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/ClassificationSample/CsvTaggerProvider.cs":::

> [!TIP]
> See the full working sample: [ClassificationSample ↗](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/ClassificationSample) — custom syntax highlighting with classification taggers.

**Related concepts:** [Editor concepts](editor-concepts.md) — text view lifecycle and editor architecture

## Understand the example

**When to use classification taggers vs. alternatives:**

- Syntax coloring for a custom language → **classification tagger** (this page)
- General-purpose text highlighting (not language-specific) → [taggers](taggers.md) with `TextMarkerTag`
- Error/warning underlines → prefer Roslyn analyzers or LSP diagnostics
- Language support beyond highlighting (IntelliSense, diagnostics) → [Language Server Provider](../language-server-provider.md)

### How to create a classification tagger

Classification taggers use the same [provider and tagger pattern](taggers.md) as text marker taggers, but produce `ClassificationTag` values. Contribute a provider with `TextViewTaggerProvider<ClassificationTag, TTagger>` and a filter for the documents it supports. The CSV sample contributes its document type along with the provider:

```csharp
[VisualStudioContribution]
internal class CsvTaggerProvider : TextViewTaggerProvider<ClassificationTag, CsvTagger>
{
    [VisualStudioContribution]
    public static DocumentTypeConfiguration CsvDocumentType => new("csv")
    {
        FileExtensions = new[] { ".csv" },
        BaseDocumentType = DocumentType.KnownValues.PlainText,
    };

    public override TextViewExtensionConfiguration TextViewExtensionConfiguration => new()
    {
        AppliesTo = [DocumentFilter.FromDocumentType(CsvDocumentType)],
    };
}
```

The tagger derives from `TextViewTagger<ClassificationTag>` and implements `OnRequestTagsAsync` and `OnTextViewChangedAsync`. Both callbacks generate tags through `CreateTagsAsync`; on an edit, use the ranges in the **after** snapshot and intersect them with previously requested ranges. See the [CSV tagger ↗](https://github.com/microsoft/VSExtensibility/blob/main/New_Extensibility_Model/Samples/ClassificationSample/CsvTagger.cs) for the complete implementations of these callbacks and the parsing helper.

### Define custom classification types and colors

A VisualStudio.Extensibility extension can contribute `ClassificationTypeConfiguration` values. Choose a parent classification for each type and specify themed colors in its `ClassificationStyle`. For example, the CSV sample's separator inherits from the built-in operator classification:

```csharp
[VisualStudioContribution]
public static ClassificationTypeConfiguration Separator { get; } = new(
    "ClassificationType/ClassificationSample.Separator")
{
    ParentClassifications = [ClassificationType.KnownValues.Operator],
    Style = new("%ClassificationSample.Classifications.Separator.DisplayName%")
    {
        ThemedColors = new()
        {
            [Theme.KnownValues.Light] = new(UIColor.KnownColors.Black),
            [Theme.KnownValues.Dark] = new(UIColor.KnownColors.White),
            [Theme.KnownValues.HighContrast] = new(UIColor.SysColors.COLOR_HOTLIGHT),
        },
    },
};
```

Supply at least light and dark colors; use system colors for high contrast. The sample also defines `Header`, `Quote`, and `EscapedQuote` with appropriate parent classifications and colors in [Classifications.cs ↗](https://github.com/microsoft/VSExtensibility/blob/preview_18.12/New_Extensibility_Model/Samples/ClassificationSample/Classifications.cs). Keep user-facing style names localized.

### Tag the classified ranges

Use your contributed classification type or a built-in `ClassificationType.KnownValues` value in each `ClassificationTag`. For example, the CSV tagger uses `Classifications.Header` for first-line field text, a built-in string classification for later fields, and `Classifications.Separator` for commas:

```csharp
foreach (Capture capture in match.Groups[SeparatorMatchName].Captures)
{
    AddTag(capture, Classifications.Separator);
}

void AddTag(Capture capture, ClassificationType classificationType)
{
    tags.Add(new(new(document, line.Text.Start + capture.Index, capture.Length, TextRangeTrackingMode.ExtendNone), new(classificationType)));
}
```

Its `CreateTagsAsync` processes complete lines from the requested or edited ranges, then calls `UpdateTagsAsync` with both the processed ranges and their tags. Include ranges with no tags so old classifications can be cleared after an edit. Avoid parsing the entire document for every keystroke if the grammar allows incremental work.

## Tips

### ✅ DO

- Use `ClassificationType.KnownValues` for standard token types (Keyword, String, Comment, Operator, etc.)
- Limit work to requested or edited ranges when the syntax permits
- Use `TextRangeTrackingMode.ExtendNone` for classification spans (they shouldn't grow with edits)
- Define custom classification types and theme-aware styles with `ClassificationTypeConfiguration`

### ❌ DON'T

- Don't reclassify the entire document on every text change when individual lines can be processed
- Don't mix classification taggers with `TextMarkerTag` for syntax coloring (use classification for language tokens)
- Don't ignore performance — classification runs on every keystroke and must be fast

### 🔧 Troubleshooting

| Symptom | Fix |
|---------|-----|
| No colors appearing | Verify `AppliesTo` filter matches file type; check tagger is calling `UpdateTagsAsync` |
| Wrong colors | Verify the intended built-in or custom classification is used and inspect the theme-specific style |
| Custom classification type not working | Check that `ClassificationTypeConfiguration` has `[VisualStudioContribution]`, a valid parent, and light/dark colors |
| Editor lag on large files | Reduce tagged range scope; avoid full-document parsing on every edit |
| Colors disappear after edit | `OnTextViewChangedAsync` must recalculate affected ranges and call `UpdateTagsAsync` |

## Next steps

- [Taggers and classification](taggers.md) — underlying tagger pattern in detail
- [Language Server Provider](../language-server-provider.md) — full language support (highlighting + IntelliSense + diagnostics)
- [Editor margins](margins.md) — visual annotations alongside colorized text
