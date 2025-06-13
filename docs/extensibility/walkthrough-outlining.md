---
title: Define and display outlining regions
description: Define and display outlining regions in the context of a language service or for your own file name extension and content type in Visual Studio.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- editors [Visual Studio SDK], new - outlining
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
dev_langs:
  - csharp
  - vb
---
# Walkthrough: Outlining

Set up language-based features such as outlining by defining the kinds of text regions you want to expand or collapse. You can define regions in the context of a language service, or define your own file name extension and content type and apply the region definition to only that type, or apply the region definitions to an existing content type (such as "text"). This walkthrough shows how to define and display outlining regions.

## Create a Managed Extensibility Framework (MEF) project

### To create a MEF project

1. Create a VSIX project. Name the solution `OutlineRegionTest`.

2. Add an Editor Classifier item template to the project. For more information, see [Create an extension with an editor item template](../extensibility/creating-an-extension-with-an-editor-item-template.md).

3. Delete the existing class files.

## Implement an outlining tagger
 Outlining regions are marked by a kind of tag (<xref:Microsoft.VisualStudio.Text.Tagging.OutliningRegionTag>). This tag provides the standard outlining behavior. The outlined region can be expanded or collapsed. The outlined region is marked by a Plus sign (**+**) if it's collapsed or a Minus sign (**-**) if it's expanded, and the expanded region is demarcated by a vertical line.

 The following steps show how to define a tagger that creates outlining regions for all the regions delimited by the brackets (**[**,**]**).

### To implement an outlining tagger

1. Add a class file and name it `OutliningTagger`.

2. Import the following namespaces.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb" id="Snippet1":::
     ---

3. Create a class named `OutliningTagger`, and have it implement <xref:Microsoft.VisualStudio.Text.Tagging.ITagger%601>:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb" id="Snippet2":::
     ---

4. Add some fields to track the text buffer and snapshot and to accumulate the sets of lines that should be tagged as outlining regions. This code includes a list of Region objects (to be defined later) that represent the outlining regions.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb" id="Snippet3":::
     ---

5. Add a tagger constructor that initializes the fields, parses the buffer, and adds an event handler to the <xref:Microsoft.VisualStudio.Text.ITextBuffer.Changed> event.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs" id="Snippet4":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb" id="Snippet4":::
     ---

6. Implement the <xref:Microsoft.VisualStudio.Text.Tagging.ITagger%601.GetTags%2A> method, which instantiates the tag spans. This example assumes that the spans in the <xref:Microsoft.VisualStudio.Text.NormalizedSpanCollection> passed in to the method are contiguous, although it may not always be the case. This method instantiates a new tag span for each of the outlining regions.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs" id="Snippet5":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb" id="Snippet5":::
     ---

7. Declare a `TagsChanged` event handler.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs" id="Snippet6":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb" id="Snippet6":::
     ---

8. Add a `BufferChanged` event handler that responds to <xref:Microsoft.VisualStudio.Text.ITextBuffer.Changed> events by parsing the text buffer.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs" id="Snippet7":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb" id="Snippet7":::
     ---

9. Add a method that parses the buffer. The example given here is for illustration only. It synchronously parses the buffer into nested outlining regions.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs" id="Snippet8":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb" id="Snippet8":::
     ---

10. The following helper method gets an integer that represents the level of the outlining, such that 1 is the leftmost brace pair.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs" id="Snippet9":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb" id="Snippet9":::
     ---

11. The following helper method translates a Region (defined later in this article) into a SnapshotSpan.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs" id="Snippet10":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb" id="Snippet10":::
     ---

12. The following code is for illustration only. It defines a PartialRegion class that contains the line number and offset of the start of an outlining region, and a reference to the parent region (if any). This code enables the parser to set up nested outlining regions. A derived Region class contains a reference to the line number of the end of an outlining region.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs" id="Snippet11":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb" id="Snippet11":::
     ---

## Implement a tagger provider
 Export a tagger provider for your tagger. The tagger provider creates an `OutliningTagger` for a buffer of the "text" content type, or else returns an `OutliningTagger` if the buffer already has one.

### To implement a tagger provider

1. Create a class named `OutliningTaggerProvider` that implements <xref:Microsoft.VisualStudio.Text.Tagging.ITaggerProvider>, and export it with the ContentType and TagType attributes.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs" id="Snippet12":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb" id="Snippet12":::
     ---

2. Implement the <xref:Microsoft.VisualStudio.Text.Tagging.ITaggerProvider.CreateTagger%2A> method by adding an `OutliningTagger` to the properties of the buffer.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs" id="Snippet13":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb" id="Snippet13":::
     ---

## Build and test the code
 To test this code, build the OutlineRegionTest solution and run it in the experimental instance.

### To build and test the OutlineRegionTest solution

1. Build the solution.

2. When you run this project in the debugger, a second instance of Visual Studio is started.

3. Create a text file. Type some text that includes both the opening brackets and the closing brackets.

    ```
    [
       Hello
    ]
    ```

4. There should be an outlining region that includes both brackets. You should be able to click the Minus Sign to the left of the open bracket to collapse the outlining region. When the region is collapsed, the ellipsis symbol (*...*) should appear to the left of the collapsed region, and a popup containing the text **hover text** should appear when you move the pointer over the ellipsis.

## Related content
- [Walkthrough: Link a content type to a file name extension](../extensibility/walkthrough-linking-a-content-type-to-a-file-name-extension.md)
