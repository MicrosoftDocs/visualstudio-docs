---
title: Editor Extensibility Concepts
description: An overview of the object model for editor-based extensions.
ms.topic: conceptual
ms.date: 3/31/2023
ms.author: maiak
monikerRange: ">=vs-2022"
author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---

# Editor extensibility concepts

This article describes the extensibility object model that represents the Visual Studio editor and the text document that opened for editing. For an introduction to working with the editor extension functionality, see [Use Visual Studio editor extensibility](editor.md).

The Visual Studio editor extensibility object model is composed of a few integral parts. This article covers [ITextViewSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewsnapshot), [ITextDocumentSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextdocumentsnapshot), and other abstract representations of the whole document. The article also introduces [TextPosition](/dotnet/api/microsoft.visualstudio.extensibility.editor.textposition) and [TextRange](/dotnet/api/microsoft.visualstudio.extensibility.editor.textrange), which represent locations and spans of text, respectively.

## ITextViewSnapshot

The [ITextViewSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewsnapshot) class contains the URI and version information necessary to acquire an [ITextDocumentSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextdocumentsnapshot) class and some properties of the text view, such as selections.

- This object is immutable and never changes after it's created.
- You can use `ITextViewSnapshot.GetTextDocumentAsync()` to get the content from the document. Calling this method is expensive, and you should do it only if you need the document content.
- The `ITextViewSnapshot` class can't be changed directly. All changes are requested via mutation. For more information, see [Make changes in a text document from an extension](./walkthroughs/editing-text.md).

## ITextDocumentSnapshot

The [ITextDocumentSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextdocumentsnapshot) class contains the content of the text document from a point in time or version.

- This object is immutable and never changes after it's created.
- The `ITextDocumentSnapshot` class can't be changed directly. All changes are requested via mutation. For more information, see [Make changes in a text document from an extension](./walkthroughs/editing-text.md).

If you're familiar with legacy Visual Studio extensions, [ITextDocumentSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextdocumentsnapshot) is almost the same as
[ITextSnapshot](/dotnet/api/microsoft.visualstudio.text.itextsnapshot) and supports most of the same methods for accessing the text.

### Best practices

- Use position and range to represent substrings in the document without expending resources by copying or allocating strings. Most APIs operate in terms of these primitives.
- Use the indexer syntax, `textDocument[0]`, to read character by character in the document without copying it to a string.
- If you must create a string, such as for use as a dictionary key, use the overload that takes a `Range` to avoid creating a large throwaway string from the entire line or document.
- Avoid the assumption that lines or documents are short. Many languages minify into huge lines or consume large files.
   - The [ITextDocumentSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextdocumentsnapshot) class references large data structures that might consume memory if an old-enough version is stored. Best practice is to periodically update positions and ranges that you're storing long term to the latest document version via their `TranslateTo()` method so that the old `ITextDocumentSnapshot` version can be garbage collected.

## Position

The [TextPosition](/dotnet/api/microsoft.visualstudio.extensibility.editor.textposition) class represents a position within the text document. As opposed to `int` positions, the `TextPosition` type is aware of the [ITextDocumentSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextdocumentsnapshot) class that it came from and supports `GetChar()` to get the character directly at that point.

If you're familiar with legacy Visual Studio extensions, `TextPosition` is almost the same as [SnapshotPoint](/dotnet/api/microsoft.visualstudio.text.snapshotpoint) and supports most of the same methods.

## Range

The [TextRange](/dotnet/api/microsoft.visualstudio.extensibility.editor.textrange) class represents a contiguous substring of characters within an [ITextDocumentSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextdocumentsnapshot) class. As opposed to a string created with `string.Substring()` or `ITextDocumentSnapshot.CopyToString()`, creating a `TextRange` class doesn't require any allocations or extra memory. Later, you can call [CopyToString()](/dotnet/api/microsoft.visualstudio.extensibility.editor.textextensions.copytostring) to realize it into a string in a deferred fashion.

If you're familiar with legacy Visual Studio extensions, `TextRange` is almost the same as
[SnapshotSpan](/dotnet/api/microsoft.visualstudio.text.snapshotSpan) and supports most of the same methods.

## Tracking modes

The `TextPosition` and `TextRange` classes are associated with a specific `ITextDocumentSnapshot` class, which is the state of the document at a specific time. You can use the `TranslateTo` methods to translate such positions and ranges to a different snapshot. Such translation takes into account any text that was added or removed before, after (or, in the case of ranges, in the middle of) the position or range. When any of these edits happen exactly at the position or exactly at the edge of the range, [TextPositionTrackingMode](/dotnet/api/microsoft.visualstudio.extensibility.editor.textpositiontrackingmode) and [TextRangeTrackingMode](/dotnet/api/microsoft.visualstudio.extensibility.editor.textrangetrackingmode) are used to specify how the translation should behave.

## Tag

[Taggers](./walkthroughs/taggers.md) are used to associate data (a [tag](/dotnet/api/microsoft.visualstudio.extensibility.editor.itag)) with spans of text. Other Visual Studio features (for example, [CodeLens](./walkthroughs/codelens.md) and [classification](./walkthroughs/classification.md)) consume such data.

## Related content

- Review sample code for a simple editor-based extension in [DocumentSelectorSample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/DocumentSelectorSample/).
