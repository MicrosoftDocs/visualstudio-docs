---
title: "Walkthrough: Outlining | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "editors [Visual Studio SDK], new - outlining"
ms.assetid: d75a44aa-265a-44d4-9c28-457f59c4ff9f
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Walkthrough: Outlining
Set up language-based features such as outlining by defining the kinds of text regions you want to expand or collapse. You can define regions in the context of a language service, or define your own file name extension and content type and apply the region definition to only that type, or apply the region definitions to an existing content type (such as "text"). This walkthrough shows how to define and display outlining regions.

## Prerequisites
 Starting in Visual Studio 2015, you don't install the Visual Studio SDK from the download center. It's included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Install the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).

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

     [!code-csharp[VSSDKOutlineRegionTest#1](../extensibility/codesnippet/CSharp/walkthrough-outlining_1.cs)]
     [!code-vb[VSSDKOutlineRegionTest#1](../extensibility/codesnippet/VisualBasic/walkthrough-outlining_1.vb)]

3. Create a class named `OutliningTagger`, and have it implement <xref:Microsoft.VisualStudio.Text.Tagging.ITagger%601>:

     [!code-csharp[VSSDKOutlineRegionTest#2](../extensibility/codesnippet/CSharp/walkthrough-outlining_2.cs)]
     [!code-vb[VSSDKOutlineRegionTest#2](../extensibility/codesnippet/VisualBasic/walkthrough-outlining_2.vb)]

4. Add some fields to track the text buffer and snapshot and to accumulate the sets of lines that should be tagged as outlining regions. This code includes a list of Region objects (to be defined later) that represent the outlining regions.

     [!code-csharp[VSSDKOutlineRegionTest#3](../extensibility/codesnippet/CSharp/walkthrough-outlining_3.cs)]
     [!code-vb[VSSDKOutlineRegionTest#3](../extensibility/codesnippet/VisualBasic/walkthrough-outlining_3.vb)]

5. Add a tagger constructor that initializes the fields, parses the buffer, and adds an event handler to the <xref:Microsoft.VisualStudio.Text.ITextBuffer.Changed> event.

     [!code-csharp[VSSDKOutlineRegionTest#4](../extensibility/codesnippet/CSharp/walkthrough-outlining_4.cs)]
     [!code-vb[VSSDKOutlineRegionTest#4](../extensibility/codesnippet/VisualBasic/walkthrough-outlining_4.vb)]

6. Implement the <xref:Microsoft.VisualStudio.Text.Tagging.ITagger%601.GetTags%2A> method, which instantiates the tag spans. This example assumes that the spans in the <xref:Microsoft.VisualStudio.Text.NormalizedSpanCollection> passed in to the method are contiguous, although it may not always be the case. This method instantiates a new tag span for each of the outlining regions.

     [!code-csharp[VSSDKOutlineRegionTest#5](../extensibility/codesnippet/CSharp/walkthrough-outlining_5.cs)]
     [!code-vb[VSSDKOutlineRegionTest#5](../extensibility/codesnippet/VisualBasic/walkthrough-outlining_5.vb)]

7. Declare a `TagsChanged` event handler.

     [!code-csharp[VSSDKOutlineRegionTest#6](../extensibility/codesnippet/CSharp/walkthrough-outlining_6.cs)]
     [!code-vb[VSSDKOutlineRegionTest#6](../extensibility/codesnippet/VisualBasic/walkthrough-outlining_6.vb)]

8. Add a `BufferChanged` event handler that responds to <xref:Microsoft.VisualStudio.Text.ITextBuffer.Changed> events by parsing the text buffer.

     [!code-csharp[VSSDKOutlineRegionTest#7](../extensibility/codesnippet/CSharp/walkthrough-outlining_7.cs)]
     [!code-vb[VSSDKOutlineRegionTest#7](../extensibility/codesnippet/VisualBasic/walkthrough-outlining_7.vb)]

9. Add a method that parses the buffer. The example given here is for illustration only. It synchronously parses the buffer into nested outlining regions.

     [!code-csharp[VSSDKOutlineRegionTest#8](../extensibility/codesnippet/CSharp/walkthrough-outlining_8.cs)]
     [!code-vb[VSSDKOutlineRegionTest#8](../extensibility/codesnippet/VisualBasic/walkthrough-outlining_8.vb)]

10. The following helper method gets an integer that represents the level of the outlining, such that 1 is the leftmost brace pair.

     [!code-csharp[VSSDKOutlineRegionTest#9](../extensibility/codesnippet/CSharp/walkthrough-outlining_9.cs)]
     [!code-vb[VSSDKOutlineRegionTest#9](../extensibility/codesnippet/VisualBasic/walkthrough-outlining_9.vb)]

11. The following helper method translates a Region (defined later in this article) into a SnapshotSpan.

     [!code-csharp[VSSDKOutlineRegionTest#10](../extensibility/codesnippet/CSharp/walkthrough-outlining_10.cs)]
     [!code-vb[VSSDKOutlineRegionTest#10](../extensibility/codesnippet/VisualBasic/walkthrough-outlining_10.vb)]

12. The following code is for illustration only. It defines a PartialRegion class that contains the line number and offset of the start of an outlining region, and a reference to the parent region (if any). This code enables the parser to set up nested outlining regions. A derived Region class contains a reference to the line number of the end of an outlining region.

     [!code-csharp[VSSDKOutlineRegionTest#11](../extensibility/codesnippet/CSharp/walkthrough-outlining_11.cs)]
     [!code-vb[VSSDKOutlineRegionTest#11](../extensibility/codesnippet/VisualBasic/walkthrough-outlining_11.vb)]

## Implement a tagger provider
 Export a tagger provider for your tagger. The tagger provider creates an `OutliningTagger` for a buffer of the "text" content type, or else returns an `OutliningTagger` if the buffer already has one.

### To implement a tagger provider

1. Create a class named `OutliningTaggerProvider` that implements <xref:Microsoft.VisualStudio.Text.Tagging.ITaggerProvider>, and export it with the ContentType and TagType attributes.

     [!code-csharp[VSSDKOutlineRegionTest#12](../extensibility/codesnippet/CSharp/walkthrough-outlining_12.cs)]
     [!code-vb[VSSDKOutlineRegionTest#12](../extensibility/codesnippet/VisualBasic/walkthrough-outlining_12.vb)]

2. Implement the <xref:Microsoft.VisualStudio.Text.Tagging.ITaggerProvider.CreateTagger%2A> method by adding an `OutliningTagger` to the properties of the buffer.

     [!code-csharp[VSSDKOutlineRegionTest#13](../extensibility/codesnippet/CSharp/walkthrough-outlining_13.cs)]
     [!code-vb[VSSDKOutlineRegionTest#13](../extensibility/codesnippet/VisualBasic/walkthrough-outlining_13.vb)]

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

## See also
- [Walkthrough: Link a content type to a file name extension](../extensibility/walkthrough-linking-a-content-type-to-a-file-name-extension.md)