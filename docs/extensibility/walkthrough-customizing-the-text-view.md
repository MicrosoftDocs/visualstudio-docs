---
title: "Walkthrough: Customizing the Text View | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "editors [Visual Studio SDK], new - customizing the view"
ms.assetid: 32d32ac8-22ff-4de7-af69-bd46ec4ad9bf
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Walkthrough: Customize the text view
You can customize a text view by modifying any of the following properties in its editor-format map:

- Indicator margin

- Insertion caret

- Overwrite caret

- Selected text

- Inactive selected text (that is, selected text that's lost focus)

- Visible whitespace

## Prerequisites
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It's included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Install the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).

## Create a MEF project

1. Create a C# VSIX project. (In the **New Project** dialog, select **Visual C# / Extensibility**, then **VSIX Project**.) Name the solution `ViewPropertyTest`.

2. Add an Editor Classifier item template to the project. For more information, see [Create an extension with an editor item template](../extensibility/creating-an-extension-with-an-editor-item-template.md).

3. Delete the existing class files.

## Define the content type

1. Add a class file and name it `ViewPropertyModifier`.

2. Add the following `using` directives:

    [!code-csharp[VSSDKViewPropertyTest#1](../extensibility/codesnippet/CSharp/walkthrough-customizing-the-text-view_1.cs)]
    [!code-vb[VSSDKViewPropertyTest#1](../extensibility/codesnippet/VisualBasic/walkthrough-customizing-the-text-view_1.vb)]

3. Declare a class named `TestViewCreationListener` that inherits from <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewCreationListener>. Export this class with the following attributes:

   - <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute> to specify the type of content to which this listener applies.

   - <xref:Microsoft.VisualStudio.Text.Editor.TextViewRoleAttribute> to specify the role of this listener.

     [!code-csharp[VSSDKViewPropertyTest#2](../extensibility/codesnippet/CSharp/walkthrough-customizing-the-text-view_2.cs)]
     [!code-vb[VSSDKViewPropertyTest#2](../extensibility/codesnippet/VisualBasic/walkthrough-customizing-the-text-view_2.vb)]

4. In this class, import the <xref:Microsoft.VisualStudio.Text.Classification.IEditorFormatMapService>.

    [!code-csharp[VSSDKViewPropertyTest#3](../extensibility/codesnippet/CSharp/walkthrough-customizing-the-text-view_3.cs)]
    [!code-vb[VSSDKViewPropertyTest#3](../extensibility/codesnippet/VisualBasic/walkthrough-customizing-the-text-view_3.vb)]

## Change the view properties

1. Set up the <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewCreationListener.TextViewCreated%2A> method so that the view properties are changed when the view is opened. To make the change, first find the <xref:System.Windows.ResourceDictionary> that corresponds to the aspect of the view you want to find. Then, change the appropriate property in the resource dictionary and set the properties. Batch the calls to the <xref:Microsoft.VisualStudio.Text.Classification.IEditorFormatMap.SetProperties%2A> method by calling the <xref:Microsoft.VisualStudio.Text.Classification.IEditorFormatMap.BeginBatchUpdate%2A> method before you set the properties and then the <xref:Microsoft.VisualStudio.Text.Classification.IEditorFormatMap.EndBatchUpdate%2A> after you set the properties.

     [!code-csharp[VSSDKViewPropertyTest#4](../extensibility/codesnippet/CSharp/walkthrough-customizing-the-text-view_4.cs)]
     [!code-vb[VSSDKViewPropertyTest#4](../extensibility/codesnippet/VisualBasic/walkthrough-customizing-the-text-view_4.vb)]

## Build and test the code

1. Build the solution.

     When you run this project in the debugger, a second instance of Visual Studio is started.

2. Create a text file and type some text.

    - The insertion caret should be magenta and the overwrite caret should be turquoise.

    - The indicator margin (to the left of the text view) should be light green.

3. Select the text you typed. The color of the selected text should be light pink.

4. While the text is selected, click anywhere outside the text window. The color of the selected text should be dark pink.

5. Turn on visible whitespace. (On the **Edit** menu, point to **Advanced** and then click **View White Space**). Type some tabs in the text. Red arrows that represent the tabs should be displayed.

## See also
- [Language service and editor extension points](../extensibility/language-service-and-editor-extension-points.md)