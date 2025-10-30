---
title: Inside the Editor
description: Learn about the subsystems and features of the editor. You can extend features of the Visual Studio editor.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- editors [Visual Studio SDK], new - architecture
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Inside the editor

The editor is composed of several different subsystems, which are designed to keep the editor text model separate from the text view and the user interface.

These sections describe different aspects of the editor:

- [Overview of the subsystems](../extensibility/inside-the-editor.md#the-subsystems)

- [The text model](../extensibility/inside-the-editor.md#the-text-model)

- [The text view](../extensibility/inside-the-editor.md#the-text-view)

These sections describe the features of the editor:

- [Tags and classifiers](../extensibility/inside-the-editor.md#tags-and-classifiers)

- [Adornments](../extensibility/inside-the-editor.md#adornments)

- [Projection](../extensibility/inside-the-editor.md#projection)

- [Outlining](../extensibility/inside-the-editor.md#outlining)

- [Mouse bindings](../extensibility/inside-the-editor.md#mouse-bindings)

- [Editor operations](../extensibility/inside-the-editor.md#editor-operations)

- [IntelliSense](../extensibility/inside-the-editor.md#intellisense)

## The subsystems

### Text model subsystem

The text model subsystem is responsible for representing text and enabling its manipulation. The text model subsystem contains the <xref:Microsoft.VisualStudio.Text.ITextBuffer> interface, which describes the sequence of characters that is to be displayed by the editor. This text can be modified, tracked, and otherwise manipulated in many ways. The text model also provides types for the following aspects:

- A service that associates text with files, and manages reading and writing them in the file system.

- A differencing service that finds the minimal differences between two sequences of objects.

- A system for describing the text in a buffer in terms of subsets of the text in other buffers.

The text model subsystem is free of user interface (UI) concepts. For example, it is not responsible for text formatting or text layout, and it has no knowledge of visual adornments that may be associated with the text.

The public types of the text model subsystem are contained in *Microsoft.VisualStudio.Text.Data.dll* and *Microsoft.VisualStudio.CoreUtility.dll*, which depend only on the .NET Framework base class library and the Managed Extensibility Framework (MEF).

### Text view subsystem

The text view subsystem is responsible for formatting and displaying text. The types in this subsystem are divided into two layers, depending on whether the types rely on Windows Presentation Foundation (WPF). The most important types are <xref:Microsoft.VisualStudio.Text.Editor.ITextView> and <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextView>, which control the set of text lines that are to be displayed, and also the caret, the selection, and the facilities for adorning the text by using WPF UI elements. This subsystem also provides margins around the text display area. These margins can be extended, and can contain different kinds of content and visual effects. Examples of margins are line number displays and scroll bars.

The public types of the text view subsystem are contained in *Microsoft.VisualStudio.Text.UI.dll* and *Microsoft.VisualStudio.Text.UI.Wpf.dll*. The first assembly contains the platform-independent elements, and the second contains the WPF-specific elements.

### Classification subsystem

The classification subsystem is responsible for determining font properties for text. A classifier breaks the text into different classes, for example, "keyword" or "comment". The classification format map relates these classes to actual font properties, for example, "Blue Consolas 10 pt". This information is used by the text view when it formats and renders text. Tagging, which is described in more detail later in this topic, enables data to be associated with spans of text.

The public types of the classification subsystem are contained in Microsoft.VisualStudio.Text.Logic.dll, and they interact with the visual aspects of classification, which are contained in Microsoft.VisualStudio.Text.UI.Wpf.dll.

### Operations subsystem

The operations subsystem defines editor behavior. It provides the implementation for Visual Studio editor commands and the undo system.

## A closer look at the text model and the text view

### The text model

The text model subsystem consists of different groupings of text types. These include the text buffer, text snapshots, and text spans.

#### Text buffers and text snapshots

The <xref:Microsoft.VisualStudio.Text.ITextBuffer> interface represents a sequence of Unicode characters that are encoded by using UTF-16, which is the encoding used by the `String` type in the .NET Framework. A text buffer can be persisted as a file system document, but this is not required.

The <xref:Microsoft.VisualStudio.Text.ITextBufferFactoryService> is used to create an empty text buffer, or a text buffer that is initialized from a string or from <xref:System.IO.TextReader>. The text buffer can be persisted to the file system as an <xref:Microsoft.VisualStudio.Text.ITextDocument>.

Any thread can edit the text buffer until a thread takes ownership of the text buffer by calling <xref:Microsoft.VisualStudio.Text.ITextBuffer.TakeThreadOwnership%2A>. After that, only that thread can perform edits.

A text buffer can go through many versions during its lifetime. A new version is generated every time the buffer is edited, and an immutable <xref:Microsoft.VisualStudio.Text.ITextSnapshot> represents the contents of that version of the buffer. Because text snapshots are immutable, you can access a text snapshot on any thread, without restrictions, even if the text buffer it represents continues to change.

#### Text snapshots and text snapshot lines

You can view the contents of a text snapshot as a sequence of characters or as a sequence of lines. Characters and lines are both indexed starting at zero. An empty text snapshot contains zero characters and one empty line. A line is delimited by any valid Unicode line-break character sequence, or by the beginning or end of the buffer. Line-break characters are explicitly represented in the text snapshot, and the line breaks in a text snapshot do not all have to be the same.

> [!NOTE]
> For more information about line-break characters in the Visual Studio editor, see [Encodings and line breaks](../ide/encodings-and-line-breaks.md).

A line of text is represented by an <xref:Microsoft.VisualStudio.Text.ITextSnapshotLine> object, which can be obtained from a text snapshot for a particular line number or for a particular character position.

#### SnapshotPoints, SnapshotSpans, and NormalizedSnapshotSpanCollections

A <xref:Microsoft.VisualStudio.Text.SnapshotPoint> represents a character position in a snapshot. The position is guaranteed to lie between zero and the length of the snapshot. A <xref:Microsoft.VisualStudio.Text.SnapshotSpan> represents a span of text in a snapshot. Its End position is guaranteed to lie between zero and the length of the snapshot. The <xref:Microsoft.VisualStudio.Text.NormalizedSnapshotSpanCollection> consists of a set of <xref:Microsoft.VisualStudio.Text.SnapshotSpan> objects from the same snapshot.

#### Spans and NormalizedSpanCollections

A <xref:Microsoft.VisualStudio.Text.Span> represents an interval that can be applied to a span of text in a text snapshot. Snapshot positions are zero-based, so spans can start at any position including zero. The `End` property of a span is equal to the sum of its `Start` property and its `Length` property. A `Span` does not include the character that is indexed by the `End` property. For example, a span that has Start=5 and Length=3 has End=8, and it includes the characters at positions 5, 6, and 7. The notation for this span is [5..8).

Two spans intersect if they have any positions in common, including the End position. Therefore, the intersection of [3, 5) and [2, 7) is [3, 5) and the intersection of [3, 5) and [5, 7) is [5, 5). (Notice that [5, 5) is an empty span.)

Two spans overlap if they have positions in common, except for the End position. An empty span never overlaps any other span, and the overlap of two spans is never empty.

A <xref:Microsoft.VisualStudio.Text.NormalizedSpanCollection> is a list of spans in the order of the Start properties of the spans. In the list, overlapping or abutting spans are merged. For example, given the set of spans [5..9), [0..1), [3..6), and [9..10), the normalized list of spans is [0..1), [3..10).

#### ITextEdit, TextVersion, and text change notifications

The content of a text buffer can be changed by using an <xref:Microsoft.VisualStudio.Text.ITextEdit> object. Creating such an object (by using one of the `CreateEdit()` methods of <xref:Microsoft.VisualStudio.Text.ITextBuffer>) starts a text transaction that consists of text edits. Every edit is a replacement of some span of text in the buffer by a string. The coordinates and content of every edit are expressed relative to the snapshot of the buffer when the transaction was started. The <xref:Microsoft.VisualStudio.Text.ITextEdit> object adjusts the coordinates of edits that are affected by other edits in the same transaction.

For example, consider a text buffer that contains this string:

```
abcdefghij
```

Apply a transaction that contains two edits, one edit that replaces the span at [2..4) by using the character `X` and a second edit that replaces the span at [6..9) by using the character `Y`. The result is this buffer:

```
abXefYj
```

The coordinates for the second edit were computed with respect to the contents of the buffer at the beginning of the transaction, before the first edit was applied.

The changes to the buffer take effect when the <xref:Microsoft.VisualStudio.Text.ITextEdit> object is committed by calling its `Apply()` method. If there was at least one non-empty edit, a new <xref:Microsoft.VisualStudio.Text.ITextVersion> is created, a new <xref:Microsoft.VisualStudio.Text.ITextSnapshot> is created, and one `Changed` event is raised. Every text version has a different text snapshot. A text snapshot represents the complete state of the text buffer after an edit transaction, but a text version describes only the changes from one snapshot to the next. In general, text snapshots are meant to be used once and then discarded, while text versions must remain alive for some time.

A text version contains a <xref:Microsoft.VisualStudio.Text.INormalizedTextChangeCollection>. This collection describes the changes that, when applied to the snapshot, produce the subsequent snapshot. Every <xref:Microsoft.VisualStudio.Text.ITextChange> in the collection contains the character position of the change, the replaced string, and the replacement string. The replaced string is empty for a basic insertion, and the replacement string is empty for a basic deletion. The normalized collection is always `null` for the most recent version of the text buffer.

Only one <xref:Microsoft.VisualStudio.Text.ITextEdit> object can be instantiated for a text buffer at any time, and all text edits must be performed on the thread that owns the text buffer (if ownership has been claimed). A text edit can be abandoned by calling its `Cancel` method or its `Dispose` method.

<xref:Microsoft.VisualStudio.Text.ITextBuffer> also provides `Insert()`, `Delete()`, and `Replace()` methods that resemble those found on the <xref:Microsoft.VisualStudio.Text.ITextEdit> interface. Calling these has the same effect as creating an <xref:Microsoft.VisualStudio.Text.ITextEdit> object, making the similar call, and then applying the edit.

#### Tracking points and tracking spans

An <xref:Microsoft.VisualStudio.Text.ITrackingPoint> represents a character position in a text buffer. If the buffer is edited in a way that causes the position of the character to shift, the tracking point shifts with it. For example, if a tracking point refers to position 10 in a buffer, and five characters are inserted at the beginning of the buffer, the tracking point then refers to position 15. If an insertion happens at precisely the position denoted by the tracking point, its behavior is determined by its <xref:Microsoft.VisualStudio.Text.PointTrackingMode>, which can be either `Positive` or `Negative`. If the tracking mode is positive, the tracking point refers to the same character, which is now at the end of the insertion. If the tracking mode is negative, the tracking point refers to the first inserted character at the original position. If the character at the position that is represented by a tracking point is deleted, the tracking point shifts to the first character that follows the deleted range. For example, if a tracking point refers to the character at position 5, and the characters at positions 3 through 6 are deleted, the tracking point refers to the character at position 3.

An <xref:Microsoft.VisualStudio.Text.ITrackingSpan> represents a range of characters instead of just one position. Its behavior is determined by its <xref:Microsoft.VisualStudio.Text.SpanTrackingMode>. If the span tracking mode is [SpanTrackingMode.EdgeInclusive](xref:Microsoft.VisualStudio.Text.SpanTrackingMode.EdgeInclusive), the tracking span grows to incorporate text inserted at its edges. If the span tracking mode is [SpanTrackingMode.EdgeExclusive](xref:Microsoft.VisualStudio.Text.SpanTrackingMode.EdgeExclusive), the tracking span does not incorporate text inserted at its edges. However, if the span tracking mode is [SpanTrackingMode.EdgePositive](xref:Microsoft.VisualStudio.Text.SpanTrackingMode.EdgePositive), an insertion pushes the current position toward the start, and if the span tracking mode is [SpanTrackingMode.EdgeNegative](xref:Microsoft.VisualStudio.Text.SpanTrackingMode.EdgeNegative), an insertion pushes the current position toward the end.

You can get the position of a tracking point or the span of a tracking span for any snapshot of the text buffer to which they belong. Tracking points and tracking spans may be safely referenced from any thread.

#### Content types

Content types are a mechanism for defining different kinds of content. A content type can be a file type such as "text", "code", or "binary", or a technology type such as "xml", "vb", or "c#". For example, the word "using" is a keyword in both C# and Visual Basic, but not in other programming languages. Therefore, the definition of this keyword would be limited to the "c#" and "vb" content types.

Content types are used as a filter for adornments and other elements of the editor. Many editor features and extension points are defined per content type. For example, text coloring is different for plain text files, XML files, and Visual Basic source code files. Text buffers are generally assigned a content type when they are created, and the content type of a text buffer can be changed.

Content types can multiple-inherit from other content types. The <xref:Microsoft.VisualStudio.Utilities.ContentTypeDefinition> lets you specify multiple base types as the parents of a given content type.

Developers can define their own content types and register them by using the <xref:Microsoft.VisualStudio.Utilities.IContentTypeRegistryService>. Many editor features can be defined with respect to a specific content type by using the <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute>. For example, editor margins, adornments, and mouse handlers can be defined so that they apply only to editors that display particular content types.

### The text view

The view part of the model view controller (MVC) pattern defines the text view, the formatting of the view, graphic elements such as the scroll bar, and the caret. All presentation elements of the Visual Studio editor are based on WPF.

#### Text views

The <xref:Microsoft.VisualStudio.Text.Editor.ITextView> interface is a platform-independent representation of a text view. It is used primarily to display text documents in a window, but it can also be used for other purposes, for example, in a tooltip.

The text view references different kinds of text buffers. The <xref:Microsoft.VisualStudio.Text.Editor.ITextView.TextViewModel%2A> property refers to an <xref:Microsoft.VisualStudio.Text.Editor.ITextViewModel> object that points to these three different text buffers: the data buffer, which is the top data-level buffer, the edit buffer, in which editing occurs, and the visual buffer, which is the buffer that is displayed in the text view.

The text is formatted based on the classifiers that are attached to the underlying text buffer, and is adorned by using the adornment providers that are attached to the text view itself.

#### The text view coordinate system

The text view coordinate system specifies positions in the text view. In this coordinate system, the x value 0.0 corresponds to the left edge of the text being displayed, and the y value 0.0 corresponds to the top edge of the text being displayed. The x coordinate increases from left to right, and the y coordinate increases from top to bottom.

A viewport (the part of the text visible in the text window) cannot be scrolled in the same manner horizontally as it is scrolled vertically. A viewport is scrolled horizontally by changing its left coordinate so that it moves with respect to the drawing surface. However, a viewport can be scrolled vertically only by changing the rendered text, which causes a <xref:Microsoft.VisualStudio.Text.Editor.ITextView.LayoutChanged> event to be raised.

Distances in the coordinate system correspond to logical pixels. If the text rendering surface is displayed without a scaling transform, then one unit in the text rendering coordinate system corresponds to one pixel on the display.

#### Margins

The <xref:Microsoft.VisualStudio.Text.Editor.ITextViewMargin> interface represents a margin and enables control of the visibility of the margin and its size. There are four predefined margins, which are named "Top", "Left", "Right", and "Bottom" and are attached to the top, bottom, left, or right edge of a view. These margins are containers in which other margins can be placed. The interface defines methods that return the size of the margin and the visibility of a margin. Margins are visual elements that provide additional information about the text view to which they are attached. For example, the line-number margin displays line numbers for the text view. The glyph margin displays UI elements.

The <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewMarginProvider> interface handles the creation and placement of margins. Margins can be ordered with respect to other margins. Higher-priority margins are located closer to the text view. For example, if there are two left margins, margin A and margin B, and margin B has a lower priority than margin A, margin B appears to the left of margin A.

#### The text view host

The <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewHost> interface contains the text view and any abutting decorations that accompany the view, for example, scroll bars. The text view host also contains margins that are attached to a border of the view.

#### Formatted text

The text that is displayed in a text view is composed of <xref:Microsoft.VisualStudio.Text.Formatting.ITextViewLine> objects. Every text-view line corresponds to one line of text in the text view. Long lines in the underlying text buffer can be either partially obscured (if word wrapping is not enabled) or broken into multiple text-view lines. The <xref:Microsoft.VisualStudio.Text.Formatting.ITextViewLine> interface contains methods and properties for mapping between coordinates and characters, and for the adornments that may be associated with the line.

<xref:Microsoft.VisualStudio.Text.Formatting.ITextViewLine> objects are created by using an <xref:Microsoft.VisualStudio.Text.Formatting.IFormattedLineSource> interface. If you are just concerned about the text that is currently displayed in the view, you can ignore the formatting source. If you are interested in the format of text that is not displayed in the view (for example, to support a rich-text cut and paste), you can use <xref:Microsoft.VisualStudio.Text.Formatting.IFormattedLineSource> to format text in a text buffer.

The text view formats one <xref:Microsoft.VisualStudio.Text.ITextSnapshotLine> at a time.

## Editor features

The features of the editor are designed so that the definition of the feature is separate from its implementation. The editor includes these features:

- Tags and classifiers

- Adornments

- Projection

- Outlining

- Mouse and key bindings

- Operations and primitives

- IntelliSense

### Tags and classifiers

Tags are markers that are associated with a span of text. They can be presented in different ways, for example, by using text coloring, underlines, graphics, or pop-ups. Classifiers are one kind of tag.

Other kinds of tags are <xref:Microsoft.VisualStudio.Text.Tagging.TextMarkerTag> for text highlighting, <xref:Microsoft.VisualStudio.Text.Tagging.OutliningRegionTag> for outlining, and <xref:Microsoft.VisualStudio.Text.Tagging.ErrorTag> for compile errors.

#### Classification types

An <xref:Microsoft.VisualStudio.Text.Classification.IClassificationType> interface represents an equivalence class, which is an abstract category of text. Classification types can multiple-inherit from other classification types. For example, programming language classifications might include "keyword", "comment", and "identifier", which all inherit from "code". Natural language classification types might include "noun", "verb", and "adjective", which all inherit from "natural language".

#### Classifications

A classification is an instance of a particular classification type, typically over a span of text. A <xref:Microsoft.VisualStudio.Text.Classification.ClassificationSpan> is used to represent a classification. A classification span can be thought of as a label that covers a particular span of text and tells the system that this span of text is of a particular classification type.

#### Classifiers

An <xref:Microsoft.VisualStudio.Text.Classification.IClassifier> is a mechanism that breaks text into a set of classifications. Classifiers must be defined for specific content types and instantiated for specific text buffers. Clients must implement <xref:Microsoft.VisualStudio.Text.Classification.IClassifier> to participate in text classification.

#### Classifier aggregators

A classifier aggregator is a mechanism that combines all the classifiers for one text buffer into just one set of classifications. For example, both a C# classifier and an English language classifier could create classifications over a comment in a C# file. Consider this comment:

```
// This method produces a classifier
```

A C# classifier might label the entire span as a comment, and the English language classifier might classify "produces" as a "verb" and "method" as a "noun". The aggregator produces a set of non-overlapping classifications, and the type of the set is based on all the contributions.

A classifier aggregator is also a classifier because it breaks text into a set of classifications. The classifier aggregator also ensures that there are no overlapping classifications and that the classifications are sorted. Individual classifiers are free to return any set of classifications, in any order, and overlapping in any way.

#### Classification formatting and text coloring

Text formatting is an example of a feature that is built on text classification. It is used by the text view layer to determine the display of text in an application. The text formatting area depends on WPF, but the logical definition of classifications does not.

A classification format is a set of formatting properties for a specific classification type. These formats inherit from the format of the parent of the classification type.

An <xref:Microsoft.VisualStudio.Text.Classification.IClassificationFormatMap> is a map from a classification type to a set of text formatting properties. The implementation of the format map in the editor handles all the exports of classification formats.

### Adornments

Adornments are graphic effects that are not directly related to the font and color of the characters in the text view. For example, the red squiggle underline that is used to mark non-compiling code in many programming languages is an embedded adornment, and tooltips are pop-up adornments. Adornments are derived from <xref:System.Windows.UIElement> and implement <xref:Microsoft.VisualStudio.Text.Tagging.ITag>. Two specialized types of adornment tag are the <xref:Microsoft.VisualStudio.Text.Tagging.SpaceNegotiatingAdornmentTag>, for adornments that occupy the same space as the text in a view, and the <xref:Microsoft.VisualStudio.Text.Tagging.ErrorTag>, for the squiggle underline.

Embedded adornments are graphics that form part of the formatted text view. They are organized in different Z-order layers. There are three built-in layers, as follows: text, the caret, and the selection. However, developers can define more layers and put them in order with respect to one another. The three kinds of embedded adornments are text-relative adornments (which move when the text moves, and are deleted when the text is deleted), view-relative adornments (which have to do with non-text parts of the view), and owner-controlled adornments (the developer must manage their placement).

Pop-up adornments are graphics that appear in a small window above the text view, for example, tooltips.

### <a name="projection"></a> Projection

Projection is a technique for constructing a different kind of text buffer that does not actually store text, but instead combines text from other text buffers. For example, a projection buffer can be used to concatenate the text from two other buffers and present the result as if it is in just one buffer, or to hide parts of the text in one buffer. A projection buffer can act as a source buffer to another projection buffer. A set of buffers that are related by projection can be constructed to rearrange text in many different ways. (Such a set is also known as a *buffer graph*.) The Visual Studio text outlining feature is implemented by using a projection buffer to hide the collapsed text, and the Visual Studio editor for ASP.NET pages uses projection to support embedded languages such as Visual Basic and C#.

An <xref:Microsoft.VisualStudio.Text.Projection.IProjectionBuffer> is created by using <xref:Microsoft.VisualStudio.Text.Projection.IProjectionBufferFactoryService>. A projection buffer is represented by an ordered sequence of <xref:Microsoft.VisualStudio.Text.ITrackingSpan> objects that are known as *source spans*. The contents of these spans are presented as a sequence of characters. The text buffers from which the source spans are drawn are named *source buffers*. Clients of a projection buffer do not have to be aware that it differs from an ordinary text buffer.

The projection buffer listens to text-change events on the source buffers. When the text in a source span changes, the projection buffer maps the changed text coordinates to its own coordinates and raises appropriate text-change events. For example, consider source buffers A and B that have these contents:

```
A: ABCDE
B: vwxyz
```

If projection buffer P is formed from two text spans, one that has all of buffer A and the other that has all of buffer B, then P has the following content:

```
P: ABCDEvwxyz
```

If the substring `xy` is deleted from buffer B, then buffer P raises an event that indicates that the characters at positions 7 and 8 were deleted.

The projection buffer can also be edited directly. It propagates edits to the appropriate source buffers. For example, if a string is inserted into buffer P at position 6 (the original position of the character "v"), the insertion is propagated to buffer B at position 1.

There are restrictions on the source spans that contribute to a projection buffer. Source spans may not overlap; a location in a projection buffer cannot map to more than one location in any source buffer, and a location in a source buffer cannot map to more than one location in a projection buffer. No circularities are permitted in the source buffer relationship.

Events are raised when the set of source buffers for a projection buffer changes and when the set of source spans changes.
An elision buffer is a special kind of projection buffer. It is primarily used for outlining and for operations that expand and collapse blocks of text. An elision buffer is based on just one source buffer, and the spans in the elision buffer must be ordered the same as they are ordered in the source buffer.

#### The buffer graph

The <xref:Microsoft.VisualStudio.Text.Projection.IBufferGraph> interface enables mapping across a graph of projection buffers. All the text buffers and projection buffers are collected in a directed acyclic graph, much like the abstract syntax tree that is produced by a language compiler. The graph is defined by the top buffer, which can be any text buffer. The buffer graph can map from a point in the top buffer to a point in a source buffer, or from a span in the top buffer to a set of spans in a source buffer. Similarly, it can map a point or span from a source buffer to a point in the top buffer. Buffer graphs are created by using the <xref:Microsoft.VisualStudio.Text.Projection.IBufferGraphFactoryService>.

#### Events and projection buffers

When a projection buffer is modified, the modifications are sent from the projection buffer to the buffers that depend on it. After all the buffers are modified, buffer change events are raised, starting with the deepest buffer.

### Outlining

Outlining is the ability to expand or collapse different blocks of text in a text view. Outlining is defined as a kind of <xref:Microsoft.VisualStudio.Text.Tagging.ITag>, in the same way as adornments are defined. A <xref:Microsoft.VisualStudio.Text.Tagging.OutliningRegionTag> is a tag that defines a text region that can be expanded or collapsed. To use outlining, you must import the <xref:Microsoft.VisualStudio.Text.Outlining.IOutliningManagerService> to get an <xref:Microsoft.VisualStudio.Text.Outlining.IOutliningManager>. The outlining manager enumerates, collapses, and expands the different blocks, which are represented as <xref:Microsoft.VisualStudio.Text.Outlining.ICollapsible> objects, and raises events accordingly.

### Mouse bindings

Mouse bindings link mouse movements to different commands. Mouse bindings are defined by using an <xref:Microsoft.VisualStudio.Text.Editor.IMouseProcessorProvider>, and key bindings are defined by using an <xref:Microsoft.VisualStudio.Text.Editor.IKeyProcessorProvider>. The <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewHost> automatically instantiates all bindings and connects them to mouse events in the view.

The <xref:Microsoft.VisualStudio.Text.Editor.IMouseProcessor> interface contains pre-process and post-process event handlers for different mouse events. To handle one of the events, you can override some of the methods in <xref:Microsoft.VisualStudio.Text.Editor.MouseProcessorBase>.

### Editor operations

Editor operations can be used to automate interaction with the editor, for scripting or other purposes. You can import the <xref:Microsoft.VisualStudio.Text.Operations.IEditorOperationsFactoryService> to access operations on a given <xref:Microsoft.VisualStudio.Text.Editor.ITextView>. You can then use these objects to modify the selection, scroll the view, or move the caret to different parts of the view.

### IntelliSense

IntelliSense supports statement completion, signature help (also known as parameter info), Quick Info, and light bulbs.

Statement completion provides pop-up lists of potential completions for method names, XML elements, and other coding or markup elements. In general, a user gesture invokes a completion session. The session displays the list of potential completions, and the user can select one or dismiss the list. The <xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionBroker> is responsible for creating and triggering the <xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionSession>. The <xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionSource> computes the <xref:Microsoft.VisualStudio.Language.Intellisense.CompletionSet> of completion items for the session.

## Troubleshooting Import/Export Issues: Access the MEF Composition Error Log 
You may experience issues if you try to import something that doesn't exist in the current VS install, or if you incorrectly author your import or export.  The primary way to find and address these issues is to reference the **Managed Extensibility Framework (MEF) Composition Error Log**, stored at *%localappdata%\Microsoft\VisualStudio[yourVSVersion]\ComponentModelCache\Microsoft.VisualStudio.Default.err*.

## Related content

- [Language service and editor extension points](../extensibility/language-service-and-editor-extension-points.md)
- [Editor imports](../extensibility/editor-imports.md)
