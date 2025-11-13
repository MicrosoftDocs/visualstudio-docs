---
title: 'Link a content type to a filename extension'
description: Learn how to link your own content type to a file name extension by using the editor Managed Extensibility Framework extensions in this walkthrough.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- editors [Visual Studio SDK], new - link content type to file name extension
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Walkthrough: Link a content type to a file name extension

You can define your own content type and link a file name extension to it by using the editor Managed Extensibility Framework (MEF) extensions. In some cases, the file name extension is already defined by a language service. But, to use it with MEF, you must still link it to a content type.

## Create a MEF project

1. Create a C# VSIX project. (In the **New Project** dialog, select **Visual C# / Extensibility**, then **VSIX Project**.) Name the solution `ContentTypeTest`.

2. In the **source.extension.vsixmanifest** file, go to the **Assets** tab, and set the **Type** field to **Microsoft.VisualStudio.MefComponent**, the **Source** field to **A project in current solution**, and the **Project** field to the name of the project.

## Define the content type

1. Add a class file and name it `FileAndContentTypes`.

2. Add references to the following assemblies:

    1. System.ComponentModel.Composition

    2. Microsoft.VisualStudio.Text.Logic

    3. Microsoft.VisualStudio.CoreUtility

3. Add the following `using` directives.

    ```csharp
    using System.ComponentModel.Composition;
    using Microsoft.VisualStudio.Text.Classification;
    using Microsoft.VisualStudio.Utilities;

    ```

4. Declare a static class that contains the definitions.

    ```csharp
    internal static class FileAndContentTypeDefinitions
    {. . .}
    ```

5. In this class, export a <xref:Microsoft.VisualStudio.Utilities.ContentTypeDefinition> named "hid" and declare its base definition to be "text".

    ```csharp
    internal static class FileAndContentTypeDefinitions
    {
        [Export]
        [Name("hid")]
        [BaseDefinition("text")]
        internal static ContentTypeDefinition hidingContentTypeDefinition;
    }
    ```

## Link a file name extension to a content type

- To map this content type to a file name extension, export a <xref:Microsoft.VisualStudio.Utilities.FileExtensionToContentTypeDefinition> that has the extension *.hid* and the content type "hid".

    ```csharp
    internal static class FileAndContentTypeDefinitions
    {
         [Export]
         [Name("hid")]
         [BaseDefinition("text")]
        internal static ContentTypeDefinition hidingContentTypeDefinition;

         [Export]
         [FileExtension(".hid")]
         [ContentType("hid")]
        internal static FileExtensionToContentTypeDefinition hiddenFileExtensionDefinition;
    }
    ```

## Add the content type to an editor export

1. Create an editor extension. For example, you can use the margin glyph extension described in [Walkthrough: Create a margin glyph](../extensibility/walkthrough-creating-a-margin-glyph.md).

2. Add the class you defined in this procedure.

3. When you export the extension class, add a <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute> of type "hid" to it.

    ```csharp
    [Export]
    [ContentType("hid")]
    ```

## Related content
- [Language service and editor extension points](../extensibility/language-service-and-editor-extension-points.md)
