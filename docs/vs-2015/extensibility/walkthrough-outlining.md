---
title: "Walkthrough: Outlining | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], new - outlining"
ms.assetid: d75a44aa-265a-44d4-9c28-457f59c4ff9f
caps.latest.revision: 31
ms.author: gregvanl
manager: jillfra
---
# Walkthrough: Outlining
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can implement language-based features such as outlining by defining the kinds of text regions you want to expand or collapse. You can define regions in the context of a language service, or you can define your own file name extension and content type and apply the region definition to only that type, or you can apply the region definitions to an existing content type (such as "text"). This walkthrough shows how to define and display outlining regions.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).  
  
## Creating a Managed Extensibility Framework (MEF) Project  
  
#### To create a MEF project  
  
1. Create an VSIX project. Name the solution `OutlineRegionTest`.  
  
2. Add an Editor Classifier item template to the project. For more information, see [Creating an Extension with an Editor Item Template](../extensibility/creating-an-extension-with-an-editor-item-template.md).  
  
3. Delete the existing class files.  
  
## Implementing an Outlining Tagger  
 Outlining regions are marked by a kind of tag (<xref:Microsoft.VisualStudio.Text.Tagging.OutliningRegionTag>). This tag provides the standard outlining behavior. The outlined region can be expanded or collapsed. The outlined region is marked by a PLUS SIGN if it is collapsed or a MINUS SIGN if it is expanded, and the expanded region is demarcated by a vertical line.  
  
 The following steps show how to define a tagger that creates outlining regions for all the regions that are delimited by "[" and "]".  
  
#### To implement an outlining tagger  
  
1. Add a class file and name it `OutliningTagger`.  
  
2. Import the following namespaces.  
  
     [!code-csharp[VSSDKOutlineRegionTest#1](../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs#1)]
     [!code-vb[VSSDKOutlineRegionTest#1](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb#1)]  
  
3. Create a class named `OutliningTagger`, and have it implement <xref:Microsoft.VisualStudio.Text.Tagging.ITagger%601>:  
  
     [!code-csharp[VSSDKOutlineRegionTest#2](../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs#2)]
     [!code-vb[VSSDKOutlineRegionTest#2](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb#2)]  
  
4. Add some fields to track the text buffer and snapshot and to accumulate the sets of lines that should be tagged as outlining regions. This code includes a list of Region objects (to be defined later) that represent the outlining regions.  
  
     [!code-csharp[VSSDKOutlineRegionTest#3](../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs#3)]
     [!code-vb[VSSDKOutlineRegionTest#3](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb#3)]  
  
5. Add a tagger constructor that initializes the fields, parses the buffer, and adds an event handler to the <xref:Microsoft.VisualStudio.Text.ITextBuffer.Changed> event.  
  
     [!code-csharp[VSSDKOutlineRegionTest#4](../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs#4)]
     [!code-vb[VSSDKOutlineRegionTest#4](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb#4)]  
  
6. Implement the <xref:Microsoft.VisualStudio.Text.Tagging.ITagger%601.GetTags%2A> method, which instantiates the tag spans. This example assumes that the spans in the <xref:Microsoft.VisualStudio.Text.NormalizedSpanCollection> passed in to the method are contiguous, although this may not always be the case. This method instantiates a new tag span for each of the outlining regions.  
  
     [!code-csharp[VSSDKOutlineRegionTest#5](../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs#5)]
     [!code-vb[VSSDKOutlineRegionTest#5](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb#5)]  
  
7. Declare a `TagsChanged` event handler.  
  
     [!code-csharp[VSSDKOutlineRegionTest#6](../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs#6)]
     [!code-vb[VSSDKOutlineRegionTest#6](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb#6)]  
  
8. Add a `BufferChanged` event handler that responds to <xref:Microsoft.VisualStudio.Text.ITextBuffer.Changed> events by parsing the text buffer.  
  
     [!code-csharp[VSSDKOutlineRegionTest#7](../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs#7)]
     [!code-vb[VSSDKOutlineRegionTest#7](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb#7)]  
  
9. Add a method that parses the buffer. The example given here is for illustration only. It synchronously parses the buffer into nested outlining regions.  
  
     [!code-csharp[VSSDKOutlineRegionTest#8](../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs#8)]
     [!code-vb[VSSDKOutlineRegionTest#8](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb#8)]  
  
10. The following helper method gets an integer that represents the level of the outlining, such that 1 is the leftmost brace pair.  
  
     [!code-csharp[VSSDKOutlineRegionTest#9](../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs#9)]
     [!code-vb[VSSDKOutlineRegionTest#9](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb#9)]  
  
11. The following helper method translates a Region (defined later in this topic) into a SnapshotSpan.  
  
     [!code-csharp[VSSDKOutlineRegionTest#10](../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs#10)]
     [!code-vb[VSSDKOutlineRegionTest#10](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb#10)]  
  
12. The following code is for illustration only. It defines a PartialRegion class that contains the line number and offset of the start of an outlining region, and also a reference to the parent region (if any). This enables the parser to set up nested outlining regions. A derived Region class contains a reference to the line number of the end of an outlining region.  
  
     [!code-csharp[VSSDKOutlineRegionTest#11](../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs#11)]
     [!code-vb[VSSDKOutlineRegionTest#11](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb#11)]  
  
## Implementing a Tagger Provider  
 You must export a tagger provider for your tagger. The tagger provider creates an `OutliningTagger` for a buffer of the "text" content type, or else returns an `OutliningTagger` if the buffer already has one.  
  
#### To implement a tagger provider  
  
1. Create a class named `OutliningTaggerProvider` that implements <xref:Microsoft.VisualStudio.Text.Tagging.ITaggerProvider>, and export it with the ContentType and TagType attributes.  
  
     [!code-csharp[VSSDKOutlineRegionTest#12](../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs#12)]
     [!code-vb[VSSDKOutlineRegionTest#12](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb#12)]  
  
2. Implement the <xref:Microsoft.VisualStudio.Text.Tagging.ITaggerProvider.CreateTagger%2A> method by adding an `OutliningTagger` to the properties of the buffer.  
  
     [!code-csharp[VSSDKOutlineRegionTest#13](../snippets/csharp/VS_Snippets_VSSDK/vssdkoutlineregiontest/cs/outliningtagger.cs#13)]
     [!code-vb[VSSDKOutlineRegionTest#13](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkoutlineregiontest/vb/outliningtagger.vb#13)]  
  
## Building and Testing the Code  
 To test this code, build the OutlineRegionTest solution and run it in the experimental instance.  
  
#### To build and test the OutlineRegionTest solution  
  
1. Build the solution.  
  
2. When you run this project in the debugger, a second instance of Visual Studio is instantiated.  
  
3. Create a text file. Type some text that includes both the opening brace and the closing brace.  
  
    ```  
    [  
       Hello  
    ]  
    ```  
  
4. There should be an outlining region that includes both braces. You should be able to click the MINUS SIGN to the left of the open brace to collapse the outlining region. When the region is collapsed, the ellipsis symbol (...) should appear to the left of the collapsed region, and a popup containing the text **hover text** should appear when you move the pointer over the ellipsis.  
  
## See Also  
 [Walkthrough: Linking a Content Type to a File Name Extension](../extensibility/walkthrough-linking-a-content-type-to-a-file-name-extension.md)
