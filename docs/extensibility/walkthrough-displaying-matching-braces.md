---
title: 'Walkthrough: Displaying Matching Braces'
description: Learn how to define braces in the context of a language, applying brace matching tags to the text content type by using this walkthrough.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- editors [Visual Studio SDK], new - brace matching
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Walkthrough: Display matching braces

Implement language-based features, such as, brace matching by defining the braces you want to match, and adding a text marker tag to the matching braces when the caret is on one of the braces. You can define braces in the context of a language, define your own file name extension and content type, and apply the tags to just that type or apply the tags to an existing content type (such as "text"). The following walkthrough shows how to apply brace matching tags to the "text" content type.

## Create a Managed Extensibility Framework (MEF) project

#### To create a MEF project

1. Create an Editor Classifier project. Name the solution `BraceMatchingTest`.

2. Add an Editor Classifier item template to the project. For more information, see [Create an extension with an editor item template](../extensibility/creating-an-extension-with-an-editor-item-template.md).

3. Delete the existing class files.

## Implement a brace matching tagger
 To get a brace highlighting effect that resembles the one that's used in Visual Studio, you can implement a tagger of type <xref:Microsoft.VisualStudio.Text.Tagging.TextMarkerTag>. The following code shows how to define the tagger for brace pairs at any level of nesting. In this example, the brace pairs of [] and {} are defined in the tagger constructor, but in a full language implementation, the relevant brace pairs would be defined in the language specification.

### To implement a brace matching tagger

1. Add a class file and name it BraceMatching.

2. Import the following namespaces.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb" id="Snippet1":::
     ---

3. Define a class `BraceMatchingTagger` that inherits from <xref:Microsoft.VisualStudio.Text.Tagging.ITagger%601> of type <xref:Microsoft.VisualStudio.Text.Tagging.TextMarkerTag>.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb" id="Snippet2":::
     ---

4. Add properties for the text view, the source buffer, the current snapshot point, and also a set of brace pairs.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb" id="Snippet3":::
     ---

5. In the tagger constructor, set the properties and subscribe to the view change events <xref:Microsoft.VisualStudio.Text.Editor.ITextCaret.PositionChanged> and <xref:Microsoft.VisualStudio.Text.Editor.ITextView.LayoutChanged>. In this example, for illustrative purposes, the matching pairs are also defined in the constructor.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs" id="Snippet4":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb" id="Snippet4":::
     ---

6. As part of the <xref:Microsoft.VisualStudio.Text.Tagging.ITagger%601> implementation, declare a TagsChanged event.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs" id="Snippet5":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb" id="Snippet5":::
     ---

7. The event handlers update the current caret position of the `CurrentChar` property and raise the TagsChanged event.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs" id="Snippet6":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb" id="Snippet6":::
     ---

8. Implement the <xref:Microsoft.VisualStudio.Text.Tagging.ITagger%601.GetTags%2A> method to match braces either when the current character is an open brace or when the previous character is a close brace, as in Visual Studio. When the match is found, this method instantiates two tags, one for the open brace and one for the close brace.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs" id="Snippet7":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb" id="Snippet7":::
     ---

9. The following private methods find the matching brace at any level of nesting. The first method finds the close character that matches the open character:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs" id="Snippet8":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb" id="Snippet8":::
     ---

10. The following helper method finds the open character that matches a close character:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs" id="Snippet9":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb" id="Snippet9":::
     ---

## Implement a brace matching tagger provider
 In addition to implementing a tagger, you must also implement and export a tagger provider. In this case, the content type of the provider is "text". So, brace matching will appear in all types of text files, but a fuller implementation applies brace matching only to a specific content type.

### To implement a brace matching tagger provider

1. Declare a tagger provider that inherits from <xref:Microsoft.VisualStudio.Text.Tagging.IViewTaggerProvider>, name it BraceMatchingTaggerProvider, and export it with a <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute> of "text" and a <xref:Microsoft.VisualStudio.Text.Tagging.TagTypeAttribute> of <xref:Microsoft.VisualStudio.Text.Tagging.TextMarkerTag>.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs" id="Snippet10":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb" id="Snippet10":::
     ---

2. Implement the <xref:Microsoft.VisualStudio.Text.Tagging.IViewTaggerProvider.CreateTagger%2A> method to instantiate a BraceMatchingTagger.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs" id="Snippet11":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb" id="Snippet11":::
     ---

## Build and test the code
 To test this code, build the BraceMatchingTest solution and run it in the experimental instance.

#### To build and test BraceMatchingTest solution

1. Build the solution.

2. When you run this project in the debugger, a second instance of Visual Studio is started.

3. Create a text file and type some text that includes matching braces.

    ```
    hello {
    goodbye}

    {}

    {hello}
    ```

4. When you position the caret before an open brace, both that brace and the matching close brace should be highlighted. When you position the cursor just after the close brace, both that brace and the matching open brace should be highlighted.

## Related content
- [Walkthrough: Link a content type to a file name extension](../extensibility/walkthrough-linking-a-content-type-to-a-file-name-extension.md)
