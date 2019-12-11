---
title: "Walkthrough: Displaying QuickInfo Tooltips | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "editors [Visual Studio SDK], new - QuickInfo"
ms.assetid: 23fb8384-4f12-446f-977f-ce7910347947
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Walkthrough: Display QuickInfo tooltips
QuickInfo is an IntelliSense feature that displays method signatures and descriptions when a user moves the pointer over a method name. You can implement language-based features such as QuickInfo by defining the identifiers for which you want to provide QuickInfo descriptions, and then creating a tooltip in which to display the content. You can define QuickInfo in the context of a language service, or you can define your own file name extension and content type and display the QuickInfo for just that type, or you can display QuickInfo for an existing content type (such as "text"). This walkthrough shows how to display QuickInfo for the "text" content type.

 The QuickInfo example in this walkthrough displays the tooltips when a user moves the pointer over a method name. This design requires you to implement these four interfaces:

- source interface

- source provider interface

- controller interface

- controller provider interface

  The source and controller providers are Managed Extensibility Framework (MEF) component parts, and are responsible for exporting the source and controller classes and importing services and brokers such as the <xref:Microsoft.VisualStudio.Text.ITextBufferFactoryService>, which creates the tooltip text buffer, and the <xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoBroker>, which triggers the QuickInfo session.

  In this example, the QuickInfo source uses a hard-coded list of method names and descriptions, but in full implementations, the language service and the language documentation are responsible for providing that content.

## Prerequisites
 Starting in Visual Studio 2015, you don't need to install the Visual Studio SDK from the download center. It's included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Install the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).

## Create a MEF project

### To create a MEF project

1. Create a C# VSIX project. (In the **New Project** dialog, select **Visual C# / Extensibility**, then **VSIX Project**.) Name the solution `QuickInfoTest`.

2. Add an Editor Classifier item template to the project. For more information, see [Create an extension with an editor item template](../extensibility/creating-an-extension-with-an-editor-item-template.md).

3. Delete the existing class files.

## Implement the QuickInfo source
 The QuickInfo source is responsible for collecting the set of identifiers and their descriptions and adding the content to the tooltip text buffer when one of the identifiers is encountered. In this example, the identifiers and their descriptions are just added in the source constructor.

#### To implement the QuickInfo source

1. Add a class file and name it `TestQuickInfoSource`.

2. Add a reference to *Microsoft.VisualStudio.Language.IntelliSense*.

3. Add the following imports.

     [!code-vb[VSSDKQuickInfoTest#1](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_1.vb)]
     [!code-csharp[VSSDKQuickInfoTest#1](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_1.cs)]

4. Declare a class that implements <xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoSource>, and name it `TestQuickInfoSource`.

     [!code-vb[VSSDKQuickInfoTest#2](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_2.vb)]
     [!code-csharp[VSSDKQuickInfoTest#2](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_2.cs)]

5. Add fields for the QuickInfo source provider, the text buffer, and a set of method names and method signatures. In this example, the method names and signatures are initialized in the `TestQuickInfoSource` constructor.

     [!code-vb[VSSDKQuickInfoTest#3](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_3.vb)]
     [!code-csharp[VSSDKQuickInfoTest#3](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_3.cs)]

6. Add a constructor that sets the QuickInfo source provider and the text buffer, and populates the set of method names, and method signatures and descriptions.

     [!code-vb[VSSDKQuickInfoTest#4](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_4.vb)]
     [!code-csharp[VSSDKQuickInfoTest#4](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_4.cs)]

7. Implement the <xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoSource.AugmentQuickInfoSession%2A> method. In this example, the method finds the current word, or the previous word if the cursor is at the end of a line or a text buffer. If the word is one of the method names, the description for that method name is added to the QuickInfo content.

     [!code-vb[VSSDKQuickInfoTest#5](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_5.vb)]
     [!code-csharp[VSSDKQuickInfoTest#5](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_5.cs)]

8. You must also implement a Dispose() method, since <xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoSource> implements <xref:System.IDisposable>:

     [!code-vb[VSSDKQuickInfoTest#6](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_6.vb)]
     [!code-csharp[VSSDKQuickInfoTest#6](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_6.cs)]

## Implement a QuickInfo source provider
 The provider of the QuickInfo source serves primarily to export itself as a MEF component part and instantiate the QuickInfo source. Because it's a MEF component part, it can import other MEF component parts.

#### To implement a QuickInfo source provider

1. Declare a QuickInfo source provider named `TestQuickInfoSourceProvider` that implements <xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoSourceProvider>, and export it with a <xref:Microsoft.VisualStudio.Utilities.NameAttribute> of "ToolTip QuickInfo Source", an <xref:Microsoft.VisualStudio.Utilities.OrderAttribute> of Before="default", and a <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute> of "text".

     [!code-vb[VSSDKQuickInfoTest#7](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_7.vb)]
     [!code-csharp[VSSDKQuickInfoTest#7](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_7.cs)]

2. Import two editor services, <xref:Microsoft.VisualStudio.Text.Operations.ITextStructureNavigatorSelectorService> and <xref:Microsoft.VisualStudio.Text.ITextBufferFactoryService>, as properties of `TestQuickInfoSourceProvider`.

     [!code-vb[VSSDKQuickInfoTest#8](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_8.vb)]
     [!code-csharp[VSSDKQuickInfoTest#8](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_8.cs)]

3. Implement <xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoSourceProvider.TryCreateQuickInfoSource%2A> to return a new `TestQuickInfoSource`.

     [!code-vb[VSSDKQuickInfoTest#9](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_9.vb)]
     [!code-csharp[VSSDKQuickInfoTest#9](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_9.cs)]

## Implement a QuickInfo controller
 QuickInfo controllers determine when QuickInfo is displayed. In this example, QuickInfo appears when the pointer is over a word that corresponds to one of the method names. The QuickInfo controller implements a mouse hover event handler that triggers a QuickInfo session.

### To implement a QuickInfo controller

1. Declare a class that implements <xref:Microsoft.VisualStudio.Language.Intellisense.IIntellisenseController>, and name it `TestQuickInfoController`.

     [!code-vb[VSSDKQuickInfoTest#10](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_10.vb)]
     [!code-csharp[VSSDKQuickInfoTest#10](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_10.cs)]

2. Add private fields for the text view, the text buffers represented in the text view, the QuickInfo session, and the QuickInfo controller provider.

     [!code-vb[VSSDKQuickInfoTest#11](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_11.vb)]
     [!code-csharp[VSSDKQuickInfoTest#11](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_11.cs)]

3. Add a constructor that sets the fields and adds the mouse hover event handler.

     [!code-vb[VSSDKQuickInfoTest#12](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_12.vb)]
     [!code-csharp[VSSDKQuickInfoTest#12](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_12.cs)]

4. Add the mouse hover event handler that triggers the QuickInfo session.

     [!code-vb[VSSDKQuickInfoTest#13](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_13.vb)]
     [!code-csharp[VSSDKQuickInfoTest#13](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_13.cs)]

5. Implement the <xref:Microsoft.VisualStudio.Language.Intellisense.IIntellisenseController.Detach%2A> method so that it removes the mouse hover event handler when the controller is detached from the text view.

     [!code-vb[VSSDKQuickInfoTest#14](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_14.vb)]
     [!code-csharp[VSSDKQuickInfoTest#14](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_14.cs)]

6. Implement the <xref:Microsoft.VisualStudio.Language.Intellisense.IIntellisenseController.ConnectSubjectBuffer%2A> method and the <xref:Microsoft.VisualStudio.Language.Intellisense.IIntellisenseController.DisconnectSubjectBuffer%2A> method as empty methods for this example.

     [!code-vb[VSSDKQuickInfoTest#15](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_15.vb)]
     [!code-csharp[VSSDKQuickInfoTest#15](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_15.cs)]

## Implementing the QuickInfo controller provider
 The provider of the QuickInfo controller serves primarily to export itself as a MEF component part and instantiate the QuickInfo controller. Because it's a MEF component part, it can import other MEF component parts.

### To implement the QuickInfo controller provider

1. Declare a class named `TestQuickInfoControllerProvider` that implements <xref:Microsoft.VisualStudio.Language.Intellisense.IIntellisenseControllerProvider>, and export it with a <xref:Microsoft.VisualStudio.Utilities.NameAttribute> of "ToolTip QuickInfo Controller" and a <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute> of "text":

     [!code-vb[VSSDKQuickInfoTest#16](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_16.vb)]
     [!code-csharp[VSSDKQuickInfoTest#16](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_16.cs)]

2. Import the <xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoBroker> as a property.

     [!code-vb[VSSDKQuickInfoTest#17](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_17.vb)]
     [!code-csharp[VSSDKQuickInfoTest#17](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_17.cs)]

3. Implement the <xref:Microsoft.VisualStudio.Language.Intellisense.IIntellisenseControllerProvider.TryCreateIntellisenseController%2A> method by instantiating the QuickInfo controller.

     [!code-vb[VSSDKQuickInfoTest#18](../extensibility/codesnippet/VisualBasic/walkthrough-displaying-quickinfo-tooltips_18.vb)]
     [!code-csharp[VSSDKQuickInfoTest#18](../extensibility/codesnippet/CSharp/walkthrough-displaying-quickinfo-tooltips_18.cs)]

## Build and test the Code
 To test this code, build the QuickInfoTest solution and run it in the experimental instance.

### To build and test the QuickInfoTest solution

1. Build the solution.

2. When you run this project in the debugger, a second instance of Visual Studio is started.

3. Create a text file and type some text that includes the words "add" and "subtract".

4. Move the pointer over one of the occurrences of "add". The signature and the description of the `add` method should be displayed.

## See also
- [Walkthrough: Link a content type to a file name extension](../extensibility/walkthrough-linking-a-content-type-to-a-file-name-extension.md)