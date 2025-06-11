---
title: Creating an Extension with an Editor Item Template
description: Learn how to use item templates in the Visual Studio SDK to create basic editor extensions that add classifiers, adornments, and margins to the editor.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- editors [Visual Studio SDK], new - extensions
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create an extension with an editor item template

You can use item templates that are included in the Visual Studio SDK to create basic editor extensions that add classifiers, adornments, and margins to the editor. The editor item templates are available for Visual C# or Visual Basic VSIX projects.

## Create a classifier extension
 The Editor Classifier item template creates an editor classifier that colors the appropriate text (in this case, everything) in any text file.

1. In the **New Project** dialog box, expand **Visual C#** or **Visual Basic** and then click **Extensibility**. In the **Templates** pane, select **VSIX Project**. In the **Name** box, type `TestClassifier`. Click **OK**.

2. In the **Solution Explorer**, right-click the project node and select **Add** > **New Item**. Go to the Visual C# **Extensibility** node and select **Editor Classifier**. Leave the default file name (*EditorClassifier1.cs*).

3. There are four code files, as follows:

    - *EditorClassifier1.cs* contains the `EditorClassifier1` class.

    - *EditorClassifier1ClassificationDefinition.cs* contains the `EditorClassifier1ClassificationDefinition` class.

    - *EditorClassifier1Format.cs* contains the `EditorClassifier1Format`  class.

    - *EditorClassifier1Provider.cs* contains the `EditorClassifier1Provider` class.

4. Build the project and start debugging. The experimental instance of Visual Studio appears.

     If you open a text file, all the text is underlined against a violet background.

## Create a text-relative adornment extension
 The Editor Text Adornment template creates a text-relative adornment that decorates all instances of the text character 'a' by using a box that has a red outline and a blue background. It is text-relative because the box always overlays the 'a' characters, even when they are moved or reformatted.

1. In the **New Project** dialog box, expand **Visual C#** or **Visual Basic** and then click **Extensibility**. In the **Templates** pane, select **VSIX Project**. In the **Name** box, type `TestAdornment`. Click **OK**.

2. In the **Solution Explorer**, right-click the project node and select **Add** > **New Item**. Go to the Visual C# **Extensibility** node and select **Editor Text Adornment**. Leave the default file name (*TextAdornment1.cs/vb*).

3. There are two code files, as follows:

    - *TextAdornment1.cs* contains the `TextAdornment1` class.

    - *TextAdornment1TextViewCreationListener.cs* contains the `TextAdornment1TextViewCreationListener` class.

4. Build the project and start debugging. The experimental instance appears. If you open a text file, all the 'a' characters in the text are outlined in red against a blue background.

## Create a viewport-relative adornment extension
 The Editor Viewport Adornment template creates a viewport-relative adornment that adds a violet box that has a red outline to the top-right corner of the viewport.

> [!NOTE]
> The **viewport** is the area of the text view that is currently displayed.

### To create a viewport adornment extension by using the Editor Viewport Adornment template

1. In the **New Project** dialog box, expand **Visual C#** or **Visual Basic** and then click **Extensibility**. In the **Templates** pane, select **VSIX Project**. In the **Name** box, type `ViewportAdornment`. Click **OK**.

2. In the **Solution Explorer**, right-click the project node and select **Add** > **New Item**. Go to the Visual C# **Extensibility** node and select **Editor Viewport Adornment**. Leave the default file name (*ViewportAdornment1.cs/vb*).

3. There are two code files, as follows:

    - *ViewportAdornment1.cs* contains the `ViewportAdornment1` class.

    - *ViewportAdornment1TextViewCreationListener.cs* contains the `ViewportAdornment1TextViewCreationListener` class

4. Build the project and start debugging. The experimental instance appears. If you create a new text file, a violet box that has a red outline is displayed in the top-right corner of the viewport.

## Create a margin extension
 The Editor Margin template creates a green margin that appears together with the words **Hello world!* below the horizontal scroll bar.

### To create a margin extension by using the Editor Margin template

1. In the **New Project** dialog box, expand **Visual C#** or **Visual Basic** and then click **Extensibility**. In the **Templates** pane, select **VSIX Project**. In the **Name** box, type `MarginExtension`. Click **OK**.

2. In the **Solution Explorer**, right-click the project node and select **Add** > **New Item**. Go to the Visual C# **Extensibility** node and select **Editor Margin**. Leave the default file name (EditorMargin1.cs/vb).

3. There are two code files, as follows:

    - *EditorMargin1.cs* contains the `EditorMargin1` class.

    - *EditorMargin1Factory.cs* contains the `EditorMargin1Factory` class.

4. Build this project and start debugging. The experimental instance appears. If you open a text file, a green margin that has the words **Hello EditorMargin1** is displayed below the horizontal scroll bar.

## Related content
- [Language service and editor extension points](../extensibility/language-service-and-editor-extension-points.md)
