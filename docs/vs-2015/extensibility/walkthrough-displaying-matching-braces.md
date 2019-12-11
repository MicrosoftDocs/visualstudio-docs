---
title: "Walkthrough: Displaying Matching Braces | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], new - brace matching"
ms.assetid: 5af08ac7-1d08-4ccf-997e-01aa6cb3d3d7
caps.latest.revision: 28
ms.author: gregvanl
manager: jillfra
---
# Walkthrough: Displaying Matching Braces
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can implement language-based features such as brace matching by defining the braces you want to match, and then adding a text marker tag to the matching braces when the caret is on one of the braces. You can define braces in the context of a language, or you can define your own file name extension and content type and apply the tags to just that type, or you can apply the tags to an existing content type (such as "text"). The following walkthrough shows how to apply brace matching tags to the "text" content type.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).  
  
## Creating a Managed Extensibility Framework (MEF) Project  
  
#### To create a MEF project  
  
1. Create an Editor Classifier project. Name the solution `BraceMatchingTest`.  
  
2. Add an Editor Classifier item template to the project. For more information, see [Creating an Extension with an Editor Item Template](../extensibility/creating-an-extension-with-an-editor-item-template.md).  
  
3. Delete the existing class files.  
  
## Implementing a Brace Matching Tagger  
 To get a brace highlighting effect that resembles the one that is used in Visual Studio, you can implement a tagger of type <xref:Microsoft.VisualStudio.Text.Tagging.TextMarkerTag>. The following code shows how to define the tagger for brace pairs at any level of nesting. In this example, the brace pairs []. [], and {} are defined in the tagger constructor, but in a full language implementation the relevant brace pairs would be defined in the language specification.  
  
#### To implement a brace matching tagger  
  
1. Add a class file and name it BraceMatching.  
  
2. Import the following namespaces.  
  
     [!code-csharp[VSSDKBraceMatchingTest#1](../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs#1)]
     [!code-vb[VSSDKBraceMatchingTest#1](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb#1)]  
  
3. Define a class `BraceMatchingTagger` that inherits from <xref:Microsoft.VisualStudio.Text.Tagging.ITagger%601> of type <xref:Microsoft.VisualStudio.Text.Tagging.TextMarkerTag>.  
  
     [!code-csharp[VSSDKBraceMatchingTest#2](../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs#2)]
     [!code-vb[VSSDKBraceMatchingTest#2](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb#2)]  
  
4. Add properties for the text view, the source buffer, and the current snapshot point, and also a set of brace pairs.  
  
     [!code-csharp[VSSDKBraceMatchingTest#3](../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs#3)]
     [!code-vb[VSSDKBraceMatchingTest#3](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb#3)]  
  
5. In the tagger constructor, set the properties and subscribe to the view change events <xref:Microsoft.VisualStudio.Text.Editor.ITextCaret.PositionChanged> and <xref:Microsoft.VisualStudio.Text.Editor.ITextView.LayoutChanged>. In this example, for illustrative purposes, the matching pairs are also defined in the constructor.  
  
     [!code-csharp[VSSDKBraceMatchingTest#4](../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs#4)]
     [!code-vb[VSSDKBraceMatchingTest#4](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb#4)]  
  
6. As part of the <xref:Microsoft.VisualStudio.Text.Tagging.ITagger%601> implementation, declare a TagsChanged event.  
  
     [!code-csharp[VSSDKBraceMatchingTest#5](../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs#5)]
     [!code-vb[VSSDKBraceMatchingTest#5](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb#5)]  
  
7. The event handlers update the current caret position of the `CurrentChar` property and raise the TagsChanged event.  
  
     [!code-csharp[VSSDKBraceMatchingTest#6](../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs#6)]
     [!code-vb[VSSDKBraceMatchingTest#6](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb#6)]  
  
8. Implement the <xref:Microsoft.VisualStudio.Text.Tagging.ITagger%601.GetTags%2A> method to match braces either when the current character is an open brace or when the previous character is a close brace, as in Visual Studio. When the match is found, this method instantiates two tags, one for the open brace and one for the close brace.  
  
     [!code-csharp[VSSDKBraceMatchingTest#7](../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs#7)]
     [!code-vb[VSSDKBraceMatchingTest#7](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb#7)]  
  
9. The following private methods find the matching brace at any level of nesting. The first method finds the close character that matches the open character:  
  
     [!code-csharp[VSSDKBraceMatchingTest#8](../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs#8)]
     [!code-vb[VSSDKBraceMatchingTest#8](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb#8)]  
  
10. The following helper method finds the open character that matches a close character:  
  
     [!code-csharp[VSSDKBraceMatchingTest#9](../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs#9)]
     [!code-vb[VSSDKBraceMatchingTest#9](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb#9)]  
  
## Implementing a Brace Matching Tagger Provider  
 In addition to implementing a tagger, you must also implement and export a tagger provider. In this case, the content type of the provider is "text". This means that brace matching will appear in all types of text files, but a fuller implementation would apply brace matching only to a specific content type.  
  
#### To implement a brace matching tagger provider  
  
1. Declare a tagger provider that inherits from <xref:Microsoft.VisualStudio.Text.Tagging.IViewTaggerProvider>, name it BraceMatchingTaggerProvider, and export it with a <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute> of "text" and a <xref:Microsoft.VisualStudio.Text.Tagging.TagTypeAttribute> of <xref:Microsoft.VisualStudio.Text.Tagging.TextMarkerTag>.  
  
     [!code-csharp[VSSDKBraceMatchingTest#10](../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs#10)]
     [!code-vb[VSSDKBraceMatchingTest#10](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb#10)]  
  
2. Implement the <xref:Microsoft.VisualStudio.Text.Tagging.IViewTaggerProvider.CreateTagger%2A> method to instantiate a BraceMatchingTagger.  
  
     [!code-csharp[VSSDKBraceMatchingTest#11](../snippets/csharp/VS_Snippets_VSSDK/vssdkbracematchingtest/cs/bracematching.cs#11)]
     [!code-vb[VSSDKBraceMatchingTest#11](../snippets/visualbasic/VS_Snippets_VSSDK/vssdkbracematchingtest/vb/bracematching.vb#11)]  
  
## Building and Testing the Code  
 To test this code, build the BraceMatchingTest solution and run it in the experimental instance.  
  
#### To build and test BraceMatchingTest solution  
  
1. Build the solution.  
  
2. When you run this project in the debugger, a second instance of Visual Studio is instantiated.  
  
3. Create a text file and type some text that includes matching braces.  
  
    ```  
    hello {  
    goodbye}  
  
    {}  
  
    {hello}  
    ```  
  
4. When you position the caret before an open brace, both that brace and the matching close brace should be highlighted. When you position the cursor just after the close brace, both that brace and the matching open brace should be highlighted.  
  
## See Also  
 [Walkthrough: Linking a Content Type to a File Name Extension](../extensibility/walkthrough-linking-a-content-type-to-a-file-name-extension.md)
