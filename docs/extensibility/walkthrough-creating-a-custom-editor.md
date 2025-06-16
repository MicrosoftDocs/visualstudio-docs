---
title: 'Walkthrough: Creating a Custom Editor'
description: Learn how to the VSPackage project template can create a simple custom editor in C++ by using this walkthrough.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- editors [Visual Studio SDK], custom - create
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Walkthrough: Create a custom editor

The VSPackage project template can create a simple custom editor in C++. The VSPackage project template no longer supports C# or Visual Basic projects. For more information, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md).

## Prerequisites
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Install the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).

## The Visual Studio Package project template
 You can find the Visual Studio Package project template in the **New Project** dialog under the **C++ Extensibility** folder.

### To create a VSPackage using the Visual Studio package template

1. Create a project with the Visual Studio Package template.

2. Select the **Custom Editor** option and click **Next**. The **Editor Options** page appears.

3. Type the name of your editor in the **Editor Name** box. Type the file extension that you want to be associated with your editor in the **File Extension** box. Your editor is available for files with this extension. The file extension is registered for Visual Studio only, not for Windows. Type the default file name for new documents created with your editor in the **Default File Name** box.

4. Click **Finish** to create your VSPackage in the folder that you specified.

### To test your custom editor

1. On the **File** menu, point to **New** and then click **File**.

2. In the **Installed Templates** pane of the **New File** dialog box, select the file template, then the file type you registered.

3. Click **Open** to view and edit the document.

     The editor supports cut-and-paste, find-and-replace, and open-and-load operations.

## Related content
- [VSPackages](../extensibility/internals/vspackages.md)
