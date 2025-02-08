---
title: Editor extensibility concepts
description: An overview of the object model for editor-based extensions
ms.topic: conceptual
ms.date: 3/31/2023
ms.author: maiak
monikerRange: ">=vs-2022"
author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---

# Editor extensibility concepts

This article describes the extensibility object model that represents the Visual Studio editor and the text document that is opened for editing. For an introduction to working with the editor extension functionality, see [Use Visual Studio editor extensibility](editor.md).

The Visual Studio Editor extensibility object model is composed of a few integral parts. This article covers [ITextViewSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewsnapshot), [ITextDocumentSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextdocumentsnapshot), and other abstract representations of the whole document, as well as `Position` and `Span`, which represent location and spans of text, respectively.

## ITextViewSnapshot

[ITextViewSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewsnapshot) contains the URI and version information necessary to acquire an [ITextDocumentSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextdocumentsnapshot) as well as some properties of the text view, such as selections.

- This object is immutable and will never change after it is created.
- You can use `ITextViewSnapshot.GetTextDocumentAsync()` to get the content from the document. Calling this method is expensive and only should be done if you need the document content.
- `ITextViewSnapshot` can't be changed directly. All changes are requested via mutation. See [Make changes in a text document from an extension](./walkthroughs/editing-text.md).

## ITextDocumentSnapshot

[ITextDocumentSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextdocumentsnapshot) contains the content of the text document from a point in time or version.

- This object is immutable and will never change after it is created.
- `ITextDocumentSnapshot` can't be changed directly. All changes are requested via mutation. See [Make changes in a text document from an extension](./walkthroughs/editing-text.md).

If you're familiar with legacy Visual Studio extensions, [ITextDocumentSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextdocumentsnapshot) is almost the same as
[ITextSnapshot](/dotnet/api/microsoft.visualstudio.text.itextsnapshot) and supports most of the same methods for accessing the text.

Best Practices:

- You can use Position and Span to represent substrings in the document without expending resources copying or allocating strings. Most APIs operate in terms of these primitives.
- You can use the indexer syntax, `textDocument[0]`, to read character by character in the document without copying it to a string.
- If you must create a string such as for use as a dictionary key, use the overload that takes a `Span`, to avoid creating a large throwaway string from the entire line or document.
- Avoid assuming lines or documents will be short. Many languages minify into huge lines or consume very large files
- - [ITextDocumentSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextdocumentsnapshot) references large data structures that may consume memory if an old enough version is stored. Best practice is to periodically update positions and spans that you're storing long term to the latest document version via their `TranslateTo()` method so the old `ITextDocumentSnapshot` version can be garbage collected.

## Position

Represents a position within the text document. As opposed to `int` positions, the Position type is aware of the [ITextDocumentSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextdocumentsnapshot) it came from and supports `GetChar()` to directly get the character at that point.

If you're familiar with legacy Visual Studio extensions, Position is almost the same as [SnapshotPoint](/dotnet/api/microsoft.visualstudio.text.snapshotpoint) and supports most of the same methods.

## Span

Represents a contiguous substring of characters within an [ITextDocumentSnapshot](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextdocumentsnapshot). As opposed to a string created with `string.Substring()` or `ITextDocumentSnapshot.CopyToString()`, creating a Span doesn't require any allocations or additional memory. You can later call `Span.GetText()` to realize it into a string in a deferred fashion.

If you're familiar with legacy Visual Studio extensions, `Position` is almost the same as
[SnapshotSpan](/dotnet/api/microsoft.visualstudio.text.snapshotSpan) and supports most of the same methods.

## Related content

Review sample code for a simple editor-based extension:

- [DocumentSelectorSample](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/DocumentSelectorSample/)
