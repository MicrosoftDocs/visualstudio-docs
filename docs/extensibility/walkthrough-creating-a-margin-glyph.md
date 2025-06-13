---
title: 'Walkthrough: Creating a Margin Glyph'
description: Learn how to customize the appearance of editor margins by using custom editor extensions by using this walkthrough.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- editors [Visual Studio SDK], new - margin glyph
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Walkthrough: Create a margin glyph

You can customize the appearance of editor margins by using custom editor extensions. This walkthrough puts a custom glyph on the indicator margin whenever the word "todo" appears in a code comment.

## Create a MEF project

1. Create a C# VSIX project. (In the **New Project** dialog, select **Visual C# / Extensibility**, then **VSIX Project**.) Name the solution `TodoGlyphTest`.

2. Add an Editor Classifier project item. For more information, see [Create an extension with an editor item template](../extensibility/creating-an-extension-with-an-editor-item-template.md).

3. Delete the existing class files.

## Define the glyph
 Define a glyph by running the <xref:Microsoft.VisualStudio.Text.Editor.IGlyphFactory> interface.

### To define the glyph

1. Add a class file and name it `TodoGlyphFactory`.

2. Add the following code by using declarations.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todoglyphfactory.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todoglyphfactory.vb" id="Snippet1":::
     ---

3. Add a class named `TodoGlyphFactory` that implements <xref:Microsoft.VisualStudio.Text.Editor.IGlyphFactory>.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todoglyphfactory.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todoglyphfactory.vb" id="Snippet2":::
     ---

4. Add a private field that defines the dimensions of the glyph.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todoglyphfactory.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todoglyphfactory.vb" id="Snippet3":::
     ---

5. Implement `GenerateGlyph` by defining the glyph user interface (UI) element. `TodoTag` is defined later in this walkthrough.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todoglyphfactory.cs" id="Snippet4":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todoglyphfactory.vb" id="Snippet4":::
     ---

6. Add a class named `TodoGlyphFactoryProvider` that implements <xref:Microsoft.VisualStudio.Text.Editor.IGlyphFactoryProvider>. Export this class with a <xref:Microsoft.VisualStudio.Utilities.NameAttribute> of "TodoGlyph", an <xref:Microsoft.VisualStudio.Utilities.OrderAttribute> of After VsTextMarker, a <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute> of "code", and a <xref:Microsoft.VisualStudio.Text.Tagging.TagTypeAttribute> of TodoTag.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todoglyphfactory.cs" id="Snippet5":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todoglyphfactory.vb" id="Snippet5":::
     ---

7. Implement the <xref:Microsoft.VisualStudio.Text.Editor.IGlyphFactoryProvider.GetGlyphFactory%2A> method by instantiating the `TodoGlyphFactory`.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todoglyphfactory.cs" id="Snippet6":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todoglyphfactory.vb" id="Snippet6":::
     ---

## Define a Todo tag and tagger
 Define the relationship between the UI element that you defined in the previous steps and the indicator margin. Create a tag type and tagger and export it by using a tagger provider.

### To define a todo tag and tagger

1. Add a new class file to the project and name it `TodoTagger`.

2. Add the following imports.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet7":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet7":::
     ---

3. Add a class named `TodoTag`.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet8":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet8":::
     ---

4. Modify the class named `TodoTagger` that implements <xref:Microsoft.VisualStudio.Text.Tagging.ITagger%601> of type `TodoTag`.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet9":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet9":::
     ---

5. To the `TodoTagger` class, add private fields for an <xref:Microsoft.VisualStudio.Text.Classification.IClassifier> and for the text to find in the classification spans.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet10":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet10":::
     ---

6. Add a constructor that sets the classifier.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet11":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet11":::
     ---

7. Implement the <xref:Microsoft.VisualStudio.Text.Tagging.ITagger%601.GetTags%2A> method by finding all the classification spans whose names include the word "comment" and whose text includes the search text. Whenever the search text is found, yield back a new <xref:Microsoft.VisualStudio.Text.Tagging.TagSpan%601> of type `TodoTag`.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet12":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet12":::
     ---

8. Declare a `TagsChanged` event.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet13":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet13":::
     ---

9. Add a class named `TodoTaggerProvider` that implements <xref:Microsoft.VisualStudio.Text.Tagging.ITaggerProvider>, and export it with a <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute> of "code" and a <xref:Microsoft.VisualStudio.Text.Tagging.TagTypeAttribute> of TodoTag.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet14":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet14":::
     ---

10. Import the <xref:Microsoft.VisualStudio.Text.Classification.IClassifierAggregatorService>.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet15":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet15":::
     ---

11. Implement the <xref:Microsoft.VisualStudio.Text.Tagging.ITaggerProvider.CreateTagger%2A> method by instantiating the `TodoTagger`.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet16":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet16":::
     ---

## Build and test the code
 To test this code, build the TodoGlyphTest solution and run it in the experimental instance.

### To build and test the TodoGlyphTest solution

1. Build the solution.

2. Run the project by pressing **F5**. A second instance of Visual Studio starts.

3. Make sure that the indicator margin is showing. (On the **Tools** menu, click **Options**. On the **Text Editor** page, make sure that **Indicator margin** is selected.)

4. Open a code file that has comments. Add the word "todo" to one of the comment sections.

5. A light blue circle with a dark blue outline appears in the indicator margin to the left of the code window.
