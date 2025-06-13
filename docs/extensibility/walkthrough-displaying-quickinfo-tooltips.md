---
title: 'Walkthrough: Displaying QuickInfo Tooltips'
description: Learn how to display QuickInfo for text content by using this walkthrough. QuickInfo displays method signatures and descriptions for a method name.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- editors [Visual Studio SDK], new - QuickInfo
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
dev_langs:
- csharp
- vb
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

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet1":::
     ---

4. Declare a class that implements <xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoSource>, and name it `TestQuickInfoSource`.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet2":::
     ---

5. Add fields for the QuickInfo source provider, the text buffer, and a set of method names and method signatures. In this example, the method names and signatures are initialized in the `TestQuickInfoSource` constructor.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet3":::
     ---

6. Add a constructor that sets the QuickInfo source provider and the text buffer, and populates the set of method names, and method signatures and descriptions.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet4":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet4":::
     ---

7. Implement the <xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoSource.AugmentQuickInfoSession%2A> method. In this example, the method finds the current word, or the previous word if the cursor is at the end of a line or a text buffer. If the word is one of the method names, the description for that method name is added to the QuickInfo content.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet5":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet5":::
     ---

8. You must also implement a Dispose() method, since <xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoSource> implements <xref:System.IDisposable>:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet6":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet6":::
     ---

## Implement a QuickInfo source provider
 The provider of the QuickInfo source serves primarily to export itself as a MEF component part and instantiate the QuickInfo source. Because it's a MEF component part, it can import other MEF component parts.

#### To implement a QuickInfo source provider

1. Declare a QuickInfo source provider named `TestQuickInfoSourceProvider` that implements <xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoSourceProvider>, and export it with a <xref:Microsoft.VisualStudio.Utilities.NameAttribute> of "ToolTip QuickInfo Source", an <xref:Microsoft.VisualStudio.Utilities.OrderAttribute> of Before="default", and a <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute> of "text".

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet7":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet7":::
     ---

2. Import two editor services, <xref:Microsoft.VisualStudio.Text.Operations.ITextStructureNavigatorSelectorService> and <xref:Microsoft.VisualStudio.Text.ITextBufferFactoryService>, as properties of `TestQuickInfoSourceProvider`.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet8":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet8":::
     ---

3. Implement <xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoSourceProvider.TryCreateQuickInfoSource%2A> to return a new `TestQuickInfoSource`.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet9":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet9":::
     ---

## Implement a QuickInfo controller
 QuickInfo controllers determine when QuickInfo is displayed. In this example, QuickInfo appears when the pointer is over a word that corresponds to one of the method names. The QuickInfo controller implements a mouse hover event handler that triggers a QuickInfo session.

### To implement a QuickInfo controller

1. Declare a class that implements <xref:Microsoft.VisualStudio.Language.Intellisense.IIntellisenseController>, and name it `TestQuickInfoController`.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet10":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet10":::
     ---

2. Add private fields for the text view, the text buffers represented in the text view, the QuickInfo session, and the QuickInfo controller provider.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet11":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet11":::
     ---

3. Add a constructor that sets the fields and adds the mouse hover event handler.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet12":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet12":::
     ---

4. Add the mouse hover event handler that triggers the QuickInfo session.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet13":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet13":::
     ---

5. Implement the <xref:Microsoft.VisualStudio.Language.Intellisense.IIntellisenseController.Detach%2A> method so that it removes the mouse hover event handler when the controller is detached from the text view.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet14":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet14":::
     ---

6. Implement the <xref:Microsoft.VisualStudio.Language.Intellisense.IIntellisenseController.ConnectSubjectBuffer%2A> method and the <xref:Microsoft.VisualStudio.Language.Intellisense.IIntellisenseController.DisconnectSubjectBuffer%2A> method as empty methods for this example.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet15":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet15":::
     ---

## Implementing the QuickInfo controller provider
 The provider of the QuickInfo controller serves primarily to export itself as a MEF component part and instantiate the QuickInfo controller. Because it's a MEF component part, it can import other MEF component parts.

### To implement the QuickInfo controller provider

1. Declare a class named `TestQuickInfoControllerProvider` that implements <xref:Microsoft.VisualStudio.Language.Intellisense.IIntellisenseControllerProvider>, and export it with a <xref:Microsoft.VisualStudio.Utilities.NameAttribute> of "ToolTip QuickInfo Controller" and a <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute> of "text":

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet16":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet16":::
     ---

2. Import the <xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoBroker> as a property.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet17":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet17":::
     ---

3. Implement the <xref:Microsoft.VisualStudio.Language.Intellisense.IIntellisenseControllerProvider.TryCreateIntellisenseController%2A> method by instantiating the QuickInfo controller.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkquickinfotest/cs/testquickinfosource.cs" id="Snippet18":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkquickinfotest/vb/testquickinfosource.vb" id="Snippet18":::
     ---

## Build and test the Code
 To test this code, build the QuickInfoTest solution and run it in the experimental instance.

### To build and test the QuickInfoTest solution

1. Build the solution.

2. When you run this project in the debugger, a second instance of Visual Studio is started.

3. Create a text file and type some text that includes the words "add" and "subtract".

4. Move the pointer over one of the occurrences of "add". The signature and the description of the `add` method should be displayed.

## Related content
- [Walkthrough: Link a content type to a file name extension](../extensibility/walkthrough-linking-a-content-type-to-a-file-name-extension.md)
