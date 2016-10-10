---
title: "Walkthrough: Displaying SmartTags"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 10bb4f69-b259-41f0-b91a-69b04385d9a5
caps.latest.revision: 31
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Walkthrough: Displaying SmartTags
Smart tags are deprecated in favor of light bulbs. See [Walkthrough: Displaying Light Bulb Suggestions](../Topic/Walkthrough:%20Displaying%20Light%20Bulb%20Suggestions.md).  
  
 Smart tags are tags on text that expand to display a set of actions. For example, in a Visual Basic or Visual C# project, a red line appears under a word when you rename an identifier such as a variable name. When you move the pointer over the underline, a button is displayed near the pointer. If you click the button, a suggested action is displayed, for example, **Rename IsRead to IsReady**. If you click the action, all references to **IsRead** in the project are renamed **IsReady**.  
  
 Although smart tags are part of the IntelliSense implementation in the editor, you can implement smart tags by subclassing <xref:Microsoft.VisualStudio.Language.Intellisense.SmartTag?qualifyHint=False>, and then implementing the <xref:Microsoft.VisualStudio.Text.Tagging.ITagger`1?qualifyHint=False> interface and the <xref:Microsoft.VisualStudio.Text.Tagging.IViewTaggerProvider?qualifyHint=False> interface.  
  
> [!NOTE]
>  Other kinds of tags can be implemented in a similar manner.  
  
 The following walkthrough shows how to create a smart tag that appears on the current word and has two suggested actions: **Convert to upper case** and **Convert to lower case**.  
  
## Prerequisites  
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio SDK](../Topic/Visual%20Studio%20SDK.md).  
  
## Creating a Managed Extensibility Framework (MEF) Project  
  
#### To create a MEF project  
  
1.  Create an Editor Classifier project. Name the solution `SmartTagTest`.  
  
2.  Open the source.extension.vsixmanifest file in the VSIX Manifest Editor.  
  
3.  Make sure that the **Assets** section contains a `Microsoft.VisualStudio.MefComponent` type, the **Source** is set to `A project in current solution`, and **Project** is set to SmartTagTest.dll.  
  
4.  Save and close source.extension.vsixmanifest.  
  
5.  Add the following reference to the project, and set **CopyLocal** to `false`:  
  
     Microsoft.VisualStudio.Language.Intellisense  
  
6.  Delete the existing class files.  
  
## Implementing a Tagger for Smart Tags  
  
#### To implement a tagger for smart tags  
  
1.  Add a class file and name it `TestSmartTag`.  
  
2.  Add the following imports:  
  
     [!CODE [VSSDKSmartTagTest#1](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#1)]  
  
3.  Add a class named `TestSmartTag` that inherits from <xref:Microsoft.VisualStudio.Language.Intellisense.SmartTag?qualifyHint=False>.  
  
     [!CODE [VSSDKSmartTagTest#2](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#2)]  
  
4.  Add a constructor for this class that calls the base constructor with a <xref:Microsoft.VisualStudio.Language.Intellisense.SmartTagType?qualifyHint=False> of <xref:Microsoft.VisualStudio.Language.Intellisense.SmartTagType?qualifyHint=False>, which will cause a blue line to appear under the first character of a word. (If you use <xref:Microsoft.VisualStudio.Language.Intellisense.SmartTagType?qualifyHint=False>, a red line will appear under the last character of the word.)  
  
     [!CODE [VSSDKSmartTagTest#3](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#3)]  
  
5.  Add a class named `TestSmartTagger` that inherits from <xref:Microsoft.VisualStudio.Text.Tagging.ITagger`1?qualifyHint=False> of type `TestSmartTag`, and implements <xref:System.IDisposable?qualifyHint=False>.  
  
     [!CODE [VSSDKSmartTagTest#4](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#4)]  
  
6.  Add the following private fields to the tagger class.  
  
     [!CODE [VSSDKSmartTagTest#5](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#5)]  
  
7.  Add a constructor that sets the private fields, and subscribes to the <xref:Microsoft.VisualStudio.Text.Editor.ITextView.LayoutChanged?qualifyHint=False> event.  
  
     [!CODE [VSSDKSmartTagTest#6](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#6)]  
  
8.  Implement <xref:Microsoft.VisualStudio.Text.Tagging.ITagger`1.GetTags?qualifyHint=False> so that the tag is created for the current word. (This method also calls a private method `GetSmartTagActions` that is explained later.)  
  
     [!CODE [VSSDKSmartTagTest#7](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#7)]  
  
9. Add a `GetSmartTagActions` method to set up the smart tag actions. The actions themselves are implemented in later steps.  
  
     [!CODE [VSSDKSmartTagTest#8](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#8)]  
  
10. Declare the `SmartTagsChanged` event.  
  
     [!CODE [VSSDKSmartTagTest#9](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#9)]  
  
11. Implement the `OnLayoutChanged` event handler to raise the `TagsChanged` event, which causes <xref:Microsoft.VisualStudio.Text.Tagging.ITagger`1.GetTags?qualifyHint=False> to be called.  
  
     [!CODE [VSSDKSmartTagTest#10](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#10)]  
  
12. Implement the <xref:System.IDisposable.Dispose?qualifyHint=False> method so that it unsubscribes from the <xref:Microsoft.VisualStudio.Text.Editor.ITextView.LayoutChanged?qualifyHint=False> event.  
  
     [!CODE [VSSDKSmartTagTest#11](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#11)]  
  
## Implementing the Smart Tag Tagger Provider  
  
#### To implement the smart tag tagger provider  
  
1.  Add a class named `TestSmartTagTaggerProvider` that inherits from <xref:Microsoft.VisualStudio.Text.Tagging.IViewTaggerProvider?qualifyHint=False>. Export it with a <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute?qualifyHint=False> of "text", a <xref:Microsoft.VisualStudio.Utilities.OrderAttribute?qualifyHint=False> of Before="default", and a <xref:Microsoft.VisualStudio.Text.Tagging.TagTypeAttribute?qualifyHint=False> of <xref:Microsoft.VisualStudio.Language.Intellisense.SmartTag?qualifyHint=False>.  
  
     [!CODE [VSSDKSmartTagTest#12](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#12)]  
  
2.  Import the <xref:Microsoft.VisualStudio.Text.Operations.ITextStructureNavigatorSelectorService?qualifyHint=False> as a property.  
  
     [!CODE [VSSDKSmartTagTest#13](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#13)]  
  
3.  Implement the <xref:Microsoft.VisualStudio.Text.Tagging.IViewTaggerProvider.CreateTagger``1?qualifyHint=False> method.  
  
     [!CODE [VSSDKSmartTagTest#14](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#14)]  
  
## Implementing Smart Tag Actions  
  
#### To implement smart tag actions  
  
1.  Create two classes, the first named `UpperCaseSmartTagAction` and the second named `LowerCaseSmartTagAction`. Both classes implement <xref:Microsoft.VisualStudio.Language.Intellisense.ISmartTagAction?qualifyHint=False>.  
  
     [!CODE [VSSDKSmartTagTest#15](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#15)]  
  
     [!CODE [VSSDKSmartTagTest#16](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#16)]  
  
 Both classes are alike except that one calls <xref:System.String.ToUpper?qualifyHint=False> and the other calls <xref:System.String.ToLower?qualifyHint=False>. The following steps cover only the uppercase action class, but you must implement both classes. Use the steps for implementing the uppercase action as a pattern for implementing the lowercase action.  
  
1.  Declare a set of private fields.  
  
     [!CODE [VSSDKSmartTagTest#17](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#17)]  
  
2.  Add a constructor that sets the fields.  
  
     [!CODE [VSSDKSmartTagTest#18](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#18)]  
  
3.  Implement the properties as follows.  
  
     [!CODE [VSSDKSmartTagTest#19](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#19)]  
  
4.  Implement the <xref:Microsoft.VisualStudio.Language.Intellisense.ISmartTagAction.Invoke?qualifyHint=False> method by replacing the text in the span with its uppercase equivalent.  
  
     [!CODE [VSSDKSmartTagTest#20](../CodeSnippet/VS_Snippets_VSSDK/vssdksmarttagtest#20)]  
  
## Building and Testing the Code  
 To test this code, build the SmartTagTest solution and run it in the experimental instance.  
  
#### To build and test the SmartTagTest solution  
  
1.  Build the solution.  
  
2.  When you run this project in the debugger, a second instance of Visual Studio is instantiated.  
  
3.  Create a text file and type some text.  
  
     A blue line should be displayed under the first letter of the first word of the text.  
  
4.  Move the pointer over the blue line.  
  
     A button should be displayed near the pointer.  
  
5.  When you click the button, two suggested actions should be displayed: **Convert to upper case** and **Convert to lower case**. If you click the first action, all the text in the current word should be converted to upper case. If you click the second action, all the text should be converted to lower case.  
  
## See Also  
 [Walkthrough: Linking a Content Type to a File Name Extension](../Topic/Walkthrough:%20Linking%20a%20Content%20Type%20to%20a%20File%20Name%20Extension.md)