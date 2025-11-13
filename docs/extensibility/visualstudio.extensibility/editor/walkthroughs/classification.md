---
title: Customizing classification in the editor
description: A walkthrough of how to provide your own classification in the Visual Studio editor using extensions
ms.date: 4/23/2025
ms.topic: concept-article
ms.author: maprospe
monikerRange: ">=vs-2022"
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# Extending Visual Studio editor with a new classification tagger

A Visual Studio extension can classify a document's syntax allowing for
the text to be colorized accordingly, which is achieved by contributing
a tagger that returns `ClassificationTag` values.

A detailed description of how to provide a tagger can be found in the
[Extending Visual Studio editor with a new tagger](./taggers.md) article.

To provide classification, we first implement a tagger provider and a
tagger:

```cs
[VisualStudioContribution]
internal class MyClassificationTaggerProvider :
    ExtensionPart,
    ITextViewTaggerProvider<ClassificationTag>,
    ITextViewChangedListener
{
    ...
```

```cs
internal class MyClassificationTagger :
    TextViewTagger<ClassificationTag>
{
    ...
```

Since we want the document colorization to appear as instantly as possible,
the generation of taggers needs to be as fast as possible. [This](./taggers.md) article 
stresses the importance of:
- only generating tags for the requested document portion (or a small
superset of it), not the whole document;
- avoiding parsing the whole document in order to generate tags.

Once the tagger structure is ready and the syntax parsing for the specific
file format is implemented, the tagger can provide text classification, by creating `ClassificationTag` values using the available
`ClassificationType` know values, and calling `UpdateTagsAsync`.

```cs
List<TaggedTrackingTextRange<ClassificationTag>> tags = new();
List<TextRange> ranges = new();

...

ranges.Add(new(document, lineStart, lineLength));
tags.Add(
    new TaggedTrackingTextRange<ClassificationTag>(
        new TrackingTextRange(
            document,
            tagStartPosition,
            tagLength,
            TextRangeTrackingMode.ExtendNone),
        new ClassificationTag(ClassificationType.KnownValues.Operator)));

...

await this.UpdateTagsAsync(ranges, tags, CancellationToken.None);
```

At this time, VisualStudio.Extensibility doesn't support defining text colors
for new classification types yet, so we must use existing classification types
(`ClassificationType.KnownValues`).

[VisualStudio.Extensibility in-proc extension](../../get-started/in-proc-extensions.md), can use [ClassificationTypeDefinition](/dotnet/api/microsoft.visualstudio.text.classification.classificationtypedefinition)
to define new classification types. Their name can be referenced using
`ClassificationType.Custom`.
