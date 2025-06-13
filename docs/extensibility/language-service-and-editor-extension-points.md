---
title: Language Service and Editor Extension Points
description: Learn about the extension points in the Visual Studio code editor that you can extend, including most language service features.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- editors [Visual Studio SDK], new - extension points
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Language service and editor extension points

The editor provides extension points that you can extend as Managed Extensibility Framework (MEF) component parts, including most language service features. These are the main extension point categories:

- Content types

- Classification types and classification formats

- Margins and scrollbars

- Tags

- Adornments

- Mouse processors

- Drop handlers

- Options

- IntelliSense

## Extend content types
 Content types are the definitions of the kinds of text handled by the editor, for example, "text", "code", or "CSharp". You define a new content type by declaring a variable of the type <xref:Microsoft.VisualStudio.Utilities.ContentTypeDefinition> and giving the new content type a unique name. To register the content type with the editor, export it together with the following attributes:

- <xref:Microsoft.VisualStudio.Utilities.NameAttribute> is the name of the content type.

- <xref:Microsoft.VisualStudio.Utilities.BaseDefinitionAttribute> is the name of the content type from which this content type is derived. A content type may inherit from multiple other content types.

  Because the <xref:Microsoft.VisualStudio.Utilities.ContentTypeDefinition> class is sealed, you can export it with no type parameter.

  The following example shows export attributes on a content type definition.

```
[Export]
[Name("test")]
[BaseDefinition("code")]
[BaseDefinition("projection")]
internal static ContentTypeDefinition TestContentTypeDefinition;
```

 Content types can be based on zero or more pre-existing content types. These are the built-in types:

- Any: the basic content type. Parent of all other content types.

- Text: the basic type for non-projection content. Inherits from "any".

- Plaintext: for non-code text. Inherits from "text".

- Code: for code of all kinds. Inherits from "text".

- Inert: excludes the text from any kind of handling. Text of this content type will never have any extension applied to it.

- Projection: for the contents of projection buffers. Inherits from "any".

- Intellisense: for the contents of IntelliSense. Inherits from "text".

- Sighelp: signature help. Inherits from "intellisense".

- Sighelp-doc: signature help documentation. Inherits from "intellisense".

  These are some of the content types that are defined by Visual Studio and some of the languages that are hosted in Visual Studio:

- Basic

- C/C++

- ConsoleOutput

- CSharp

- CSS

- ENC

- FindResults

- F#

- HTML

- JScript

- XAML

- XML

  To discover the list of available content types, import the <xref:Microsoft.VisualStudio.Utilities.IContentTypeRegistryService>, which maintains the collection of content types for the editor. The following code imports this service as a property.

```
[Import]
internal IContentTypeRegistryService ContentTypeRegistryService { get; set; }
```

 To associate a content type with a file name extension, use <xref:Microsoft.VisualStudio.Utilities.FileExtensionToContentTypeDefinition>.

> [!NOTE]
> In Visual Studio, file name extensions are registered by using the <xref:Microsoft.VisualStudio.Shell.ProvideLanguageExtensionAttribute> on a language service package. The <xref:Microsoft.VisualStudio.Utilities.FileExtensionToContentTypeDefinition> associates a MEF content type with a file name extension that has been registered in this manner.

 To export the file name extension to the content type definition, you must include the following attributes:

- <xref:Microsoft.VisualStudio.Utilities.FileExtensionAttribute>: specifies the file name extension.

- <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute>: specifies the content type.

  Because the <xref:Microsoft.VisualStudio.Utilities.FileExtensionToContentTypeDefinition> class is sealed, you can export it with no type parameter.

  The following example shows export attributes on a file name extension to a content type definition.

```
[Export]
[FileExtension(".test")]
[ContentType("test")]
internal static FileExtensionToContentTypeDefinition TestFileExtensionDefinition;
```

 The <xref:Microsoft.VisualStudio.Utilities.IFileExtensionRegistryService> manages the associations between file name extensions and content types.

## Extend classification types and classification formats
 You can use classification types to define the kinds of text for which you want to provide different handling (for example, coloring the "keyword" text blue and the "comment" text green). Define a new classification type by declaring a variable of type <xref:Microsoft.VisualStudio.Text.Classification.ClassificationTypeDefinition> and giving it a unique name.

 To register the classification type with the editor, export it together with the following attributes:

- <xref:Microsoft.VisualStudio.Utilities.NameAttribute>: the name of the classification type.

- <xref:Microsoft.VisualStudio.Utilities.BaseDefinitionAttribute>: the name of the classification type from which this classification type inherits. All classification types inherit from "text", and a classification type may inherit from multiple other classification types.

  Because the <xref:Microsoft.VisualStudio.Text.Classification.ClassificationTypeDefinition> class is sealed, you can export it with no type parameter.

  The following example shows export attributes on a classification type definition.

```
[Export]
[Name("csharp.test")]
[BaseDefinition("test")]
internal static ClassificationTypeDefinition CSharpTestDefinition;
```

 The <xref:Microsoft.VisualStudio.Language.StandardClassification.IStandardClassificationService> provides access to standard classifications. Built-in classification types include these:

- "text"

- "natural language" (derives from "text")

- "formal language" (derives from "text")

- "string" (derives from "literal")

- "character" (derives from "literal")

- "numerical" (derives from "literal")

  A set of different error types inherit from <xref:Microsoft.VisualStudio.Text.Adornments.ErrorTypeDefinition>. They include the following error types:

- "syntax error"

- "compiler error"

- "other error"

- "warning"

  To discover the list of available classification types, import the <xref:Microsoft.VisualStudio.Text.Classification.IClassificationTypeRegistryService>, which maintains the collection of classification types for the editor. The following code imports this service as a property.

```
[Import]
internal IClassificationTypeRegistryService ClassificationTypeRegistryService { get; set; }
```

 You can define a classification format definition for your new classification type. Derive a class from <xref:Microsoft.VisualStudio.Text.Classification.ClassificationFormatDefinition> and export it with the type <xref:Microsoft.VisualStudio.Text.Classification.EditorFormatDefinition>, together with the following attributes:

- <xref:Microsoft.VisualStudio.Utilities.NameAttribute>: the name of the format.

- <xref:Microsoft.VisualStudio.Utilities.DisplayNameAttribute>: the display name of the format.

- <xref:Microsoft.VisualStudio.Text.Classification.UserVisibleAttribute>: specifies whether the format appears on the **Fonts and Colors** page of the **Options** dialog box.

- <xref:Microsoft.VisualStudio.Utilities.OrderAttribute>: the priority of the format. Valid values are from <xref:Microsoft.VisualStudio.Text.Classification.Priority>.

- <xref:Microsoft.VisualStudio.Text.Classification.ClassificationTypeAttribute>: the name of the classification type to which this format is mapped.

  The following example shows export attributes on a classification format definition.

```
[Export(typeof(EditorFormatDefinition))]
[ClassificationType(ClassificationTypeNames = "test")]
[Name("test")]
[DisplayName("Test")]
[UserVisible(true)]
[Order(After = Priority.Default, Before = Priority.High)]
internal sealed class TestFormat : ClassificationFormatDefinition
```

 To discover the list of available formats, import the <xref:Microsoft.VisualStudio.Text.Classification.IEditorFormatMapService>, which maintains the collection of formats for the editor. The following code imports this service as a property.

```
[Import]
internal IEditorFormatMapService FormatMapService { get; set; }
```

## Extend margins and scrollbars
 Margins and scrollbars are the main view elements of the editor in addition to the text view itself. You can provide any number of margins in addition to the standard margins that appear around the text view.

 Implement an <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewMargin> interface to define a margin. You must also implement the <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewMarginProvider> interface to create the margin.

 To register the margin provider with the editor, you must export the provider together with the following attributes:

- <xref:Microsoft.VisualStudio.Utilities.NameAttribute>: the name of the margin.

- <xref:Microsoft.VisualStudio.Utilities.OrderAttribute>: the order in which the margin appears, relative to the other margins.

   These are the built-in margins:

  - "Wpf Horizontal Scrollbar"

  - "Wpf Vertical Scrollbar"

  - "Wpf Line Number Margin"

    Horizontal margins that have an order attribute of `After="Wpf Horizontal Scrollbar"` are displayed below the built-in margin, and horizontal margins that have an order attribute of `Before ="Wpf Horizontal Scrollbar"` are displayed above the built-in margin. Right vertical margins that have an order attribute of `After="Wpf Vertical Scrollbar"` are displayed to the right of the scrollbar. Left vertical margins that have an order attribute of `After="Wpf Line Number Margin"` appear to the left of the line number margin (if it is visible).

- <xref:Microsoft.VisualStudio.Text.Editor.MarginContainerAttribute>: the kind of margin (left, right, top, or bottom).

- <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute>: the kind of content (for example, "text" or "code") for which your margin is valid.

  The following example shows export attributes on a margin provider for a margin that appears to the right of the line number margin.

```
[Export(typeof(IWpfTextViewMarginProvider))]
[Name("TestMargin")]
[Order(Before = "Wpf Line Number Margin")]
[MarginContainer(PredefinedMarginNames.Left)]
[ContentType("text")]
```

## Extend tags
 Tags are a way of associating data with different kinds of text. In many cases, the associated data is displayed as a visual effect, but not all tags have a visual presentation. You can define your own kind of tag by implementing <xref:Microsoft.VisualStudio.Text.Tagging.ITag>. You must also implement <xref:Microsoft.VisualStudio.Text.Tagging.ITagger%601> to provide the tags for a given set of text spans, and an <xref:Microsoft.VisualStudio.Text.Tagging.ITaggerProvider> to provide the tagger. You must export the tagger provider together with the following attributes:

- <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute>: the kind of content (for example, "text" or "code") for which your tag is valid.

- <xref:Microsoft.VisualStudio.Text.Tagging.TagTypeAttribute>: the kind of tag.

  The following example shows export attributes on a tagger provider.

\<CodeContentPlaceHolder>8</CodeContentPlaceHolder>
 The following kinds of tag are built-in:

- <xref:Microsoft.VisualStudio.Text.Tagging.ClassificationTag>: associated with an <xref:Microsoft.VisualStudio.Text.Classification.IClassificationType>.

- <xref:Microsoft.VisualStudio.Text.Tagging.ErrorTag>: associated with error types.

- <xref:Microsoft.VisualStudio.Text.Tagging.TextMarkerTag>: associated with an adornment.

  > [!NOTE]
  > For an example of a <xref:Microsoft.VisualStudio.Text.Tagging.TextMarkerTag>, see the HighlightWordTag definition in [Walkthrough: Highlighting Text](../extensibility/walkthrough-highlighting-text.md).

- <xref:Microsoft.VisualStudio.Text.Tagging.OutliningRegionTag>: associated with regions that can be expanded or collapsed in outlining.

- <xref:Microsoft.VisualStudio.Text.Tagging.SpaceNegotiatingAdornmentTag>: defines the space an adornment occupies in a text view. For more information about space-negotiating adornments, see the following section.

- <xref:Microsoft.VisualStudio.Text.Editor.IntraTextAdornmentTag>: provides automatic spacing and sizing for the adornment.

  To find and use tags for buffers and views, import the <xref:Microsoft.VisualStudio.Text.Tagging.IViewTagAggregatorFactoryService> or the <xref:Microsoft.VisualStudio.Text.Tagging.IBufferTagAggregatorFactoryService>, which give you an <xref:Microsoft.VisualStudio.Text.Tagging.ITagAggregator%601> of the requested type. The following code imports this service as a property.

```
[Import]
internal IViewTagAggregatorFactoryService ViewTagAggregatorFactoryService { get; set; }
```

#### Tags and MarkerFormatDefinitions
 You can extend the <xref:Microsoft.VisualStudio.Text.Classification.MarkerFormatDefinition> class to define the appearance of a tag. You must export your class (as a <xref:Microsoft.VisualStudio.Text.Classification.EditorFormatDefinition>)with the following attributes:

- <xref:Microsoft.VisualStudio.Utilities.NameAttribute>: the name used to reference this format

- <xref:Microsoft.VisualStudio.Text.Classification.UserVisibleAttribute>: this causes the format to appear in the UI

  In the constructor, you define the display name and appearance of the tag. <xref:Microsoft.VisualStudio.Text.Classification.EditorFormatDefinition.BackgroundColor%2A> defines the fill color, and <xref:Microsoft.VisualStudio.Text.Classification.EditorFormatDefinition.ForegroundColor%2A> defines the border color. The <xref:Microsoft.VisualStudio.Text.Classification.EditorFormatDefinition.DisplayName%2A> is the localizable name of the format definition.

  The following is an example of a format definition:

```
[Export(typeof(EditorFormatDefinition))]
[Name("MarkerFormatDefinition/HighlightWordFormatDefinition")]
[UserVisible(true)]
internal class HighlightWordFormatDefinition : MarkerFormatDefinition
{
    public HighlightWordFormatDefinition()
    {
        this.BackgroundColor = Colors.LightBlue;
        this.ForegroundColor = Colors.DarkBlue;
        this.DisplayName = "Highlight Word";
        this.ZOrder = 5;
    }
}

```

 To apply this format definition to a tag, reference the name you set in the name attribute of the class (not the display name).

> [!NOTE]
> For an example of a <xref:Microsoft.VisualStudio.Text.Classification.MarkerFormatDefinition>, see the HighlightWordFormatDefinition class in [Walkthrough: Highlighting Text](../extensibility/walkthrough-highlighting-text.md).

## Extend adornments
 Adornments define visual effects that can be added either to the text that is displayed in a text view or to the text view itself. You can define your own adornment as any type of <xref:System.Windows.UIElement>.

 In your adornment class, you must declare an <xref:Microsoft.VisualStudio.Text.Editor.AdornmentLayerDefinition>. To register your adornment layer, export it together with the following attributes:

- <xref:Microsoft.VisualStudio.Utilities.NameAttribute>: the name of the adornment.

- <xref:Microsoft.VisualStudio.Utilities.OrderAttribute>: the ordering of the adornment with respect to other adornment layers. The class <xref:Microsoft.VisualStudio.Text.Editor.PredefinedAdornmentLayers> defines four default layers: Selection, Outlining, Caret, and Text.

  The following example shows export attributes on an adornment layer definition.

```
[Export]
[Name("TestEmbeddedAdornment")]
[Order(After = PredefinedAdornmentLayers.Selection, Before = PredefinedAdornmentLayers.Text)]
internal AdornmentLayerDefinition testLayerDefinition;
```

 You must create a second class that implements <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewCreationListener> and handles its <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewCreationListener.TextViewCreated%2A> event by instantiating the adornment. You must export this class together with the following attributes:

- <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute>: the kind of content (for example, "text" or "code") for which the adornment is valid.

- <xref:Microsoft.VisualStudio.Text.Editor.TextViewRoleAttribute>: the kind of text view for which this adornment is valid. The class <xref:Microsoft.VisualStudio.Text.Editor.PredefinedTextViewRoles> has the set of predefined text view roles. For example, <xref:Microsoft.VisualStudio.Text.Editor.PredefinedTextViewRoles.Document> is primarily used for text views of files. <xref:Microsoft.VisualStudio.Text.Editor.PredefinedTextViewRoles.Interactive> is used for text views that a user can edit or navigate by using a mouse and keyboard. Examples of <xref:Microsoft.VisualStudio.Text.Editor.PredefinedTextViewRoles.Interactive> views are the editor text view and the **Output** window.

  The following example shows export attributes on the adornment provider.

```
[Export(typeof(IWpfTextViewCreationListener))]
[ContentType("csharp")]
[TextViewRole(PredefinedTextViewRoles.Document)]
internal sealed class TestAdornmentProvider : IWpfTextViewCreationListener
```

 A space-negotiating adornment is one that occupies space at the same level as the text. To create this kind of adornment, you must define a tag class that inherits from <xref:Microsoft.VisualStudio.Text.Tagging.SpaceNegotiatingAdornmentTag>, which defines the amount of space the adornment occupies.

 As with all adornments, you must export the adornment layer definition.

```
[Export]
[Name("TestAdornment")]
[Order(After = DefaultAdornmentLayers.Text)]
internal AdornmentLayerDefinition testAdornmentLayer;
```

 To instantiate the space-negotiating adornment, you must create a class that implements <xref:Microsoft.VisualStudio.Text.Tagging.ITaggerProvider>, in addition to the class that implements <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewCreationListener> (as with other kinds of adornments).

 To register the tagger provider, you must export it together with the following attributes:

- <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute>: the kind of content (for example, "text" or "code") for which your adornment is valid.

- <xref:Microsoft.VisualStudio.Text.Editor.TextViewRoleAttribute>: the kind of text view for which this tag or adornment is valid. The class <xref:Microsoft.VisualStudio.Text.Editor.PredefinedTextViewRoles> has the set of predefined text view roles. For example, <xref:Microsoft.VisualStudio.Text.Editor.PredefinedTextViewRoles.Document> is primarily used for text views of files. <xref:Microsoft.VisualStudio.Text.Editor.PredefinedTextViewRoles.Interactive> is used for text views that a user can edit or navigate by using a mouse and keyboard. Examples of <xref:Microsoft.VisualStudio.Text.Editor.PredefinedTextViewRoles.Interactive> views are the editor text view and the **Output** window.

- <xref:Microsoft.VisualStudio.Text.Tagging.TagTypeAttribute>: the kind of tag or adornment that you have defined. You must add a second <xref:Microsoft.VisualStudio.Text.Tagging.TagTypeAttribute> for <xref:Microsoft.VisualStudio.Text.Tagging.SpaceNegotiatingAdornmentTag>.

  The following example shows export attributes on the tagger provider for a space-negotiating adornment tag.

```
[Export(typeof(ITaggerProvider))]
[ContentType("text")]
[TextViewRole(PredefinedTextViewRoles.Document)]
[TagType(typeof(SpaceNegotiatingAdornmentTag))]
[TagType(typeof(TestSpaceNegotiatingTag))]
internal sealed class TestTaggerProvider : ITaggerProvider
```

## Extending Mouse Processors
 You can add special handling for mouse input. Create a class that inherits from <xref:Microsoft.VisualStudio.Text.Editor.MouseProcessorBase> and override the mouse events for the input you want to handle. You must also implement <xref:Microsoft.VisualStudio.Text.Editor.IMouseProcessorProvider> in a second class and export it together with the <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute> that specifies the kind of content (for example, "text" or "code") for which your mouse handler is valid.

 The following example shows export attributes on a mouse processor provider.

```
[Export(typeof(IMouseProcessorProvider))]
[Name("test mouse processor")]
[ContentType("text")]
[TextViewRole(PredefinedTextViewRoles.Interactive)]
internal sealed class TestMouseProcessorProvider : IMouseProcessorProvider
```

## Extend drop handlers
 You can customize the behavior of drop handlers for specific kinds of text by creating a class that implements <xref:Microsoft.VisualStudio.Text.Editor.DragDrop.IDropHandler> and a second class that implements <xref:Microsoft.VisualStudio.Text.Editor.DragDrop.IDropHandlerProvider> to create the drop handler. You must export the drop handler together with the following attributes:

- <xref:Microsoft.VisualStudio.Text.Editor.DragDrop.DropFormatAttribute>: the text format for which this drop handler is valid. The following formats are handled in priority order from highest to lowest:

  1. Any custom format

  2. FileDrop

  3. EnhancedMetafile

  4. WaveAudio

  5. Riff

  6. Dif

  7. Locale

  8. Palette

  9. PenData

  10. Serializable

  11. SymbolicLink

  12. Xaml

  13. XamlPackage

  14. Tiff

  15. Bitmap

  16. Dib

  17. MetafilePicture

  18. CSV

  19. System.String

  20. HTML Format

  21. UnicodeText

  22. OEMText

  23. Text

- <xref:Microsoft.VisualStudio.Utilities.NameAttribute>: the name of the drop handler.

- <xref:Microsoft.VisualStudio.Utilities.OrderAttribute>: the ordering of the drop handler before or after the default drop handler. The default drop handler for Visual Studio is named "DefaultFileDropHandler".

  The following example shows export attributes on a drop handler provider.

```
[Export(typeof(IDropHandlerProvider))]
[DropFormat("Text")]
[Name("TestDropHandler")]
[Order(Before="DefaultFileDropHandler")]
internal class TestDropHandlerProvider : IDropHandlerProvider
```

## Extending Editor Options
 You can define options to be valid only in a certain scope, for example, in a text view. The editor provides this set of predefined options: editor options, view options, and Windows Presentation Foundation (WPF) view options. These options can be found in <xref:Microsoft.VisualStudio.Text.Editor.DefaultOptions>, <xref:Microsoft.VisualStudio.Text.Editor.DefaultTextViewOptions>, and <xref:Microsoft.VisualStudio.Text.Editor.DefaultWpfViewOptions>.

 To add a new option, derive a class from one of these option definition classes:

- <xref:Microsoft.VisualStudio.Text.Editor.EditorOptionDefinition%601>

- <xref:Microsoft.VisualStudio.Text.Editor.ViewOptionDefinition%601>

- <xref:Microsoft.VisualStudio.Text.Editor.WpfViewOptionDefinition%601>

  The following example shows how to export an option definition that has a Boolean value.

```
[Export(typeof(EditorOptionDefinition))]
internal sealed class TestOption : EditorOptionDefinition<bool>
```

## Extend IntelliSense
 IntelliSense is a general term for a group of features that provide information about structured text, and statement completion for it. These features include statement completion, signature help, Quick Info, and light bulbs. Statement completion helps users type a language keyword or member name correctly. Signature help displays the signature or signatures for the method that the user has just typed. Quick Info displays a complete signature for a type or member name when the mouse rests on it. Light bulb provide additional actions for certain identifiers in certain contexts, for example, renaming all occurrences of a variable after one occurrence has been renamed.

 The design of an IntelliSense feature is much the same in all cases:

- An IntelliSense *broker* is responsible for the overall process.

- An IntelliSense *session* represents the sequence of events between the triggering of the presenter and the committal or cancellation of the selection. The session is typically triggered by some user gesture.

- An IntelliSense *controller* is responsible for deciding when the session should start and end. It also decides when the information should be committed and when the session should be cancelled.

- An IntelliSense *source* provides the content and decides the best match.

- An IntelliSense *presenter* is responsible for displaying the content.

  In most cases, we recommend that you provide at least a source and a controller. You can also provide a presenter if you want to customize the display.

### Implement an IntelliSense Source
 To customize a source, you must implement one (or more) of the following source interfaces:

- <xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionSource>

- <xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoSource>

- <xref:Microsoft.VisualStudio.Language.Intellisense.ISignatureHelpSource>

- <xref:Microsoft.VisualStudio.Language.Intellisense.ISuggestedActionsSource>

> [!IMPORTANT]
> <xref:Microsoft.VisualStudio.Language.Intellisense.ISmartTagSource> has been deprecated in favor of <xref:Microsoft.VisualStudio.Language.Intellisense.ISuggestedActionsSource>.

 In addition, you must implement a provider of the same kind:

- <xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionSourceProvider>

- <xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoSourceProvider>

- <xref:Microsoft.VisualStudio.Language.Intellisense.ISignatureHelpSourceProvider>

- <xref:Microsoft.VisualStudio.Language.Intellisense.ISuggestedActionsSourceProvider>

> [!IMPORTANT]
> <xref:Microsoft.VisualStudio.Language.Intellisense.ISmartTagSourceProvider> has been deprecated in favor of <xref:Microsoft.VisualStudio.Language.Intellisense.ISuggestedActionsSourceProvider>.

 You must export the provider together with the following attributes:

- <xref:Microsoft.VisualStudio.Utilities.NameAttribute>: the name of the source.

- <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute>: the kind of content (for example, "text" or "code") to which the source applies.

- <xref:Microsoft.VisualStudio.Utilities.OrderAttribute>: the order in which the source should appear (with respect to other sources).

- The following example shows export attributes on a completion source provider.

```
Export(typeof(ICompletionSourceProvider))]
[Name(" Test Statement Completion Provider")]
[Order(Before = "default")]
[ContentType("text")]
internal class TestCompletionSourceProvider : ICompletionSourceProvider
```

 For more information about implementing IntelliSense sources, see the following walkthroughs:

- [Walkthrough: Display QuickInfo tooltips](../extensibility/walkthrough-displaying-quickinfo-tooltips.md)

- [Walkthrough: Display Signature Help](../extensibility/walkthrough-displaying-signature-help.md)

- [Walkthrough: Display statement completion](../extensibility/walkthrough-displaying-statement-completion.md)

### Implement an IntelliSense controller
 To customize a controller, you must implement the <xref:Microsoft.VisualStudio.Language.Intellisense.IIntellisenseController> interface. In addition, you must implement a controller provider together with the following attributes:

- <xref:Microsoft.VisualStudio.Utilities.NameAttribute>: the name of the controller.

- <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute>: the kind of content (for example, "text" or "code") to which the controller applies.

- <xref:Microsoft.VisualStudio.Utilities.OrderAttribute>: the order in which the controller should appear (with respect to other controllers).

  The following example shows export attributes on a completion controller provider.

```
Export(typeof(IIntellisenseControllerProvider))]
[Name(" Test Controller Provider")]
[Order(Before = "default")]
[ContentType("text")]
internal class TestIntellisenseControllerProvider : IIntellisenseControllerProvider
```

 For more information about using IntelliSense controllers, see the following walkthroughs:

- [Walkthrough: Display QuickInfo tooltips](../extensibility/walkthrough-displaying-quickinfo-tooltips.md)
