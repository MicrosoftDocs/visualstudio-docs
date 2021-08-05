---
title: 'Walkthrough: Creating a Margin Glyph | Microsoft Docs'
description: Learn how to customize the appearance of editor margins by using custom editor extensions by using this walkthrough.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- editors [Visual Studio SDK], new - margin glyph
ms.assetid: 814185db-24f9-417f-b3b1-7c5aabb42b45
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Walkthrough: Create a margin glyph
You can customize the appearance of editor margins by using custom editor extensions. This walkthrough puts a custom glyph on the indicator margin whenever the word "todo" appears in a code comment.

## Prerequisites
 Starting in Visual Studio 2015, you don't install the Visual Studio SDK from the download center. It's included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Install the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).

## Create a MEF project

1. Create a C# VSIX project. (In the **New Project** dialog, select **Visual C# / Extensibility**, then **VSIX Project**.) Name the solution `TodoGlyphTest`.

2. Add an Editor Classifier project item. For more information, see [Create an extension with an editor item template](../extensibility/creating-an-extension-with-an-editor-item-template.md).

3. Delete the existing class files.

## Define the glyph
 Define a glyph by running the <xref:Microsoft.VisualStudio.Text.Editor.IGlyphFactory> interface.

### To define the glyph

1. Add a class file and name it `TodoGlyphFactory`.

2. Add the following code by using declarations.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todoglyphfactory.cs" id="Snippet1":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todoglyphfactory.vb" id="Snippet1":::

3. Add a class named `TodoGlyphFactory` that implements <xref:Microsoft.VisualStudio.Text.Editor.IGlyphFactory>.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todoglyphfactory.cs" id="Snippet2":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todoglyphfactory.vb" id="Snippet2":::

4. Add a private field that defines the dimensions of the glyph.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todoglyphfactory.cs" id="Snippet3":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todoglyphfactory.vb" id="Snippet3":::

5. Implement `GenerateGlyph` by defining the glyph user interface (UI) element. `TodoTag` is defined later in this walkthrough.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todoglyphfactory.cs" id="Snippet4":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todoglyphfactory.vb" id="Snippet4":::

6. Add a class named `TodoGlyphFactoryProvider` that implements <xref:Microsoft.VisualStudio.Text.Editor.IGlyphFactoryProvider>. Export this class with a <xref:Microsoft.VisualStudio.Utilities.NameAttribute> of "TodoGlyph", an <xref:Microsoft.VisualStudio.Utilities.OrderAttribute> of After VsTextMarker, a <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute> of "code", and a <xref:Microsoft.VisualStudio.Text.Tagging.TagTypeAttribute> of TodoTag.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todoglyphfactory.cs" id="Snippet5":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todoglyphfactory.vb" id="Snippet5":::

7. Implement the <xref:Microsoft.VisualStudio.Text.Editor.IGlyphFactoryProvider.GetGlyphFactory%2A> method by instantiating the `TodoGlyphFactory`.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todoglyphfactory.cs" id="Snippet6":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todoglyphfactory.vb" id="Snippet6":::

## Define a Todo tag and tagger
 Define the relationship between the UI element that you defined in the previous steps and the indicator margin. Create a tag type and tagger and export it by using a tagger provider.

### To define a todo tag and tagger

1. Add a new class file to the project and name it `TodoTagger`.

2. Add the following imports.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet7":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet7":::

3. Add a class named `TodoTag`.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet8":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet8":::

4. Modify the class named `TodoTagger` that implements <xref:Microsoft.VisualStudio.Text.Tagging.ITagger%601> of type `TodoTag`.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet9":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet9":::

5. To the `TodoTagger` class, add private fields for an <xref:Microsoft.VisualStudio.Text.Classification.IClassifier> and for the text to find in the classification spans.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet10":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet10":::

6. Add a constructor that sets the classifier.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet11":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet11":::

7. Implement the <xref:Microsoft.VisualStudio.Text.Tagging.ITagger%601.GetTags%2A> method by finding all the classification spans whose names include the word "comment" and whose text includes the search text. Whenever the search text is found, yield back a new <xref:Microsoft.VisualStudio.Text.Tagging.TagSpan%601> of type `TodoTag`.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet12":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet12":::

8. Declare a `TagsChanged` event.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet13":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet13":::

9. Add a class named `TodoTaggerProvider` that implements <xref:Microsoft.VisualStudio.Text.Tagging.ITaggerProvider>, and export it with a <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute> of "code" and a <xref:Microsoft.VisualStudio.Text.Tagging.TagTypeAttribute> of TodoTag.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet14":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet14":::

10. Import the <xref:Microsoft.VisualStudio.Text.Classification.IClassifierAggregatorService>.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet15":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet15":::

11. Implement the <xref:Microsoft.VisualStudio.Text.Tagging.ITaggerProvider.CreateTagger%2A> method by instantiating the `TodoTagger`.

     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdktodoglyphtest/cs/todotagger.cs" id="Snippet16":::
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdktodoglyphtest/vb/todotagger.vb" id="Snippet16":::

## Build and test the code
 To test this code, build the TodoGlyphTest solution and run it in the experimental instance.

### To build and test the TodoGlyphTest solution

1. Build the solution.

2. Run the project by pressing **F5**. A second instance of Visual Studio starts.

3. Make sure that the indicator margin is showing. (On the **Tools** menu, click **Options**. On the **Text Editor** page, make sure that **Indicator margin** is selected.)

4. Open a code file that has comments. Add the word "todo" to one of the comment sections.

5. A light blue circle with a dark blue outline appears in the indicator margin to the left of the code window.
