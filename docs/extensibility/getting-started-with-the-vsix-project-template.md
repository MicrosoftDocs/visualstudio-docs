---
title: Getting Started with the VSIX Project Template
description: Get started with the VSIX Project template in Visual Studio and create an extension or package an existing extension for deployment. 
ms.date: 2/2/2024
ms.topic: how-to
helpviewer_keywords:
- Visual Studio SDK, VSIX project template
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Get started with the VSIX Project template

You can use the VSIX Project template to create an extension or to package an existing extension for deployment. The VSIX Project template has both Visual Basic and Visual C# versions, and is installed as part of the Visual Studio SDK.

 The VSIX Project template just consists of a `source.extension.vsixmanifest` file, which contains information about the extension and the assets it ships.

 To find the VSIX project template, you must install the Visual Studio SDK. For more information, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md).

## Deploy a Custom Project Template using the VSIX Project template

 The following steps show how to use the VSIX project to package a project template that you can share with other developers or upload to the Visual Studio Gallery.

1. Create a project template.

    1. Open the project from which to create a template. This project can be of any project type.

    2. On the **Project** menu, click **Export Template**. Complete the steps of the wizard.

         A `.zip` file is created in `%USERPROFILE%\My Documents\Visual Studio {version}\My Exported Templates\`.

2. Create an empty VSIX project.

     Select **File** > **New** > **Project**. In the search box, type "vsix" and select either the **C#** or **Visual Basic** version of **VSIX Project**.

3. Add the *.zip* file to the project. Set its **Copy to Output Directory** property to `Copy Always`.

4. In **Solution Explorer**, double-click the *source.extension.vsixmanifest* file to open it in the **VSIX Manifest Designer**, and then make the following changes:

    - Set the **Product Name** field to **My Project Template**.

    - Set the **Product ID** field to **MyProjectTemplate - 1**.

    - Set the **Author** field to **Fabrikam**.

    - Set the **Description** field to **My project template**.

    - In the **Assets** section, add a **Microsoft.VisualStudio.ProjectTemplate** type and set its path to the name of the *.zip* file.

5. Save and close the `source.extension.vsixmanifest` file.

6. Build the project.

7. In the output directory, double-click the `.vsix` file.

8. A **VSIX Installer** message box appears. Follow the instructions to install the extension.

9. Close Visual Studio and then reopen it.

10. Select **Manage Extensions** (on the **Extensions** menu) and select the **Templates** category. One of the available extensions should be **My Project Template**.

11. The new project template appears in the **New Project** dialog in the same place as the original project template. For example, if you created a template named **VB Console** from a Visual Basic console application, **VB Console** appears in the same pane as the Visual Basic **Console Application** template.

### To specify the location of the template in the New Project Dialog box

1. Template folders are located in the `{Visual Studio Installation Path}\Common7\IDE\ProjectTemplates` and `{Visual Studio Installation Path}\Common7\IDE\ItemTemplates` directories. The names of the top-level sections in the **New Project** dialog do not exactly match the names of the template folders. Where they differ, use the name of the template folder.

    Change the `.vsix` file extension to `.zip`, and then open the file.

2. Create a new folder with the same name as the section of the **New Project** dialog the template should appear in.

3. If the template is to appear in a subsection, create a subfolder of the same name.

4. Move the template `.zip` file into the new folder.

5. Change the `.zip` extension to `.vsix`.

6. Open the VSIX manifest.

7. In the VSIX manifest, update the **Asset** path of the template so that it points to the root of the directory tree that contains the template file. For example, if the template is in `\CSharp\Windows`, the reference should point to `\CSharp`.
