---
title: "Creating an Extension with an Editor Item Template | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], new - extensions"
ms.assetid: fa3b993b-ab95-47fa-a38b-b788f3a5b2d8
caps.latest.revision: 17
ms.author: gregvanl
manager: jillfra
---
# Creating an Extension with an Editor Item Template
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use item templates that are included in the Visual Studio SDK to create basic editor extensions that add classifiers, adornments, and margins to the editor. The editor item templates are available for Visual C# or Visual Basic VSIX projects.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).  
  
## Creating a Classifier Extension  
 The Editor Classifier item template creates an editor classifier that colors the appropriate text (in this case, everything) in any text file.  
  
1. In the **New Project** dialog box, expand **Visual C#** or **Visual Basic** and then click **Extensibility**. In the **Templates** pane, select **VSIX Project**. In the **Name** box, type `TestClassifier`. Click **OK**.  
  
2. In the **Solution Explorer**, right-click the project node and select **Add / New Item**. Go to the Visual C# **Extensibility** node and select **Editor Classifier**. Leave the default file name (EditorClassifier1.cs).  
  
3. There are three code files, as follows:  
  
    - EditorClassifier1.cs contains the `EditorClassifier1` class.  
  
    - EditorClassifier1ClassificationDefinition.cs contains the `OEditorClassifier1ClassificationDefinition` class.  
  
    - EditorClassifier1Format.cs contains the `EditorClassifier1Format`  class.  
  
    - EditorClassifier1Provider.cs contains the `EditorClassifier1Provider` class.  
  
4. Build the project and start debugging. The experimental instance of Visual Studio appears.  
  
     If you open a text file, all the text is underlined against a violet background.  
  
## Creating a Text-Relative Adornment Extension  
 The Editor Text Adornment template creates a text-relative adornment that decorates all instances of the text character 'a' by using a box that has a red outline and a blue background. It is text-relative because the box always overlays the 'a' characters, even when they are moved or reformatted.  
  
1. In the **New Project** dialog box, expand **Visual C#** or **Visual Basic** and then click **Extensibility**. In the **Templates** pane, select **VSIX Project**. In the **Name** box, type `TestAdornment`. Click **OK**.  
  
2. In the **Solution Explorer**, right-click the project node and select **Add / New Item**. Go to the Visual C# **Extensibility** node and select **Editor Text Adornment**. Leave the default file name (TextAdornment1.cs/vb).  
  
3. There are two code files, as follows:  
  
    - TextAdornment1.cs contains the `TextAdornment1` class.  
  
    - extAdornment1TextViewCreationListener.cs contains the `TextAdornment1TextViewCreationListener` class.  
  
4. Build the project and start debugging. The experimental instance appears. If you open a text file, all the 'a' characters in the text are outlined in red against a blue background.  
  
## Creating a Viewport-Relative Adornment Extension  
 The Editor Viewport Adornment template creates a viewport-relative adornment that adds a violet box that has a red outline to the top-right corner of the viewport.  
  
> [!NOTE]
> The *viewport* is the area of the text view that is currently displayed.  
  
#### To create a viewport adornment extension by using the Editor Viewport Adornment template  
  
1. In the **New Project** dialog box, expand **Visual C#** or **Visual Basic** and then click **Extensibility**. In the **Templates** pane, select **VSIX Project**. In the **Name** box, type `ViewportAdornment`. Click **OK**.  
  
2. In the **Solution Explorer**, right-click the project node and select **Add / New Item**. Go to the Visual C# **Extensibility** node and select **Editor Viewport Adornment**. Leave the default file name (ViewportAdornment1.cs/vb).  
  
3. There are two code files, as follows:  
  
    - ViewportAdornment1.cs contains the `ViewportAdornment1` class.  
  
    - ViewportAdornment1TextViewCreationListener.cs contains the `ViewportAdornment1TextViewCreationListener` class  
  
4. Build the project and start debugging. The experimental instance appears. If you create a new text file, a violet box that has a red outline is displayed in the top-right corner of the viewport.  
  
## Creating a Margin Extension  
 The Editor Margin template creates a green margin that appears together with the words "Hello world!" below the horizontal scrollbar.  
  
#### To create a margin extension by using the Editor Margin template  
  
1. In the **New Project** dialog box, expand **Visual C#** or **Visual Basic** and then click **Extensibility**. In the **Templates** pane, select **VSIX Project**. In the **Name** box, type `MarginExtension`. Click **OK**.  
  
2. In the **Solution Explorer**, right-click the project node and select **Add / New Item**. Go to the Visual C# **Extensibility** node and select **Editor Viewport Adornment**. Leave the default file name (EditorMargin1.cs/vb).  
  
3. There are two code files, as follows:  
  
    - EditorMargin1.cs contains the `EditorMargin1` class.  
  
    - EditorMargin1Factory.cs contains the `EditorMargin1Factory` class.  
  
4. Build this project and start debugging. The experimental instance appears. If you open a text file, a green margin that has the words "Hello EditorMargin1" is displayed below the horizontal scrollbar.  
  
## See Also  
 [Language Service and Editor Extension Points](../extensibility/language-service-and-editor-extension-points.md)
