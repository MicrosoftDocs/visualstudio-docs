---
title: "Creating an Extension Pack with an Extension Pack Item Template | Microsoft Docs"
ms.custom: ""
ms.date: "07/27/2018"
ms.technology: 
  - "vs-ide-sdk"
ms.topic: "conceptual"
helpviewer_keywords: 
  - "editors [Visual Studio SDK], new - extensions"
ms.assetid: fa3b993b-ab95-47fa-a38b-b788f3a5b2d8
author: "chitray"
ms.author: "chitray"
manager: Meng
ms.workload: 
  - "vssdk"
---
# Extension Pack
An Extension Pack is a set of extensions that can be installed together. An Extension Packs enable you to easily share your favorite extensions with other users or creating a set of extensions for a particular scenario.
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).  

The Extension Pack feature is available starting with Visual Studio 15.8 Preview 2.
  
## Creating an Extension with an Extension Pack Item Template  
 The Extension Pack item template creates an extension pack with set of extensions that can be installed together.
  
1.  In the **New Project** dialog box, expand **Visual C#** or **Visual Basic** and then click **Extensibility**. In the **Templates** pane, select **VSIX Project**. In the **Name** box, type `Test Extension Pack`. Click **OK**.  
  
2.  In the **Solution Explorer**, right-click the project node and select **Add / New Item**. Go to the Visual C# **Extensibility** node and select **Extension Pack**. Leave the default file name (ExtensionPack1.cs).  
  
3.  ExtensionPack1.vsext file is added which contains the following code



```json
    {
      "id": "ExtensionPack1",
      "name": "ExtensionPack1",
      "description": "Read about creating extension packs at https://aka.ms/vsextpack",
      "version": "1.0.0.0",
      "extensions": [  // List of extensions that are included in the Extension Pack.
        {
          "vsixId": "41858b2d-ff0b-4a43-80b0-f1b2d6084935", // The vsix id of the extension you want to include.
          "name": "AlignAssignments"
        },
        {
          "vsixId": "42374550-426a-400e-96f9-237682e8dea6",
          "name": "CopyAsHtml"
        }
      ]
    }
```



4. Vsixid of the extension to include in the Extension Pack can be available from [Visual Studio Marketplace](https://marketplace.visualstudio.com/). Find the extension you want to include and Click on **Copy ID**. You can update the existing **vsixId** in the above file or add another extension to the list.
    
    **NOTE** - An Extension pack can only install extensions thar are available on the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) or [Private gallery](../extensibility/how-to-create-an-atom-feed-for-a-private-gallery.md).

    ![Copy VsixId from Marketplace](media/vsixid-marketplace.png)

5. Build the project and upload your extension to the Marketplace. see [Uploading extension to the Marketplace](../extensibility/walkthrough-publishing-a-visual-studio-extension.md). 
  
## Install the Extension Pack from the Visual Studio Marketplace

Now that the extension is published, install it in Visual Studio and test it there.

1. In Visual Studio, on the **Tools** menu, click **Extensions and Updates...**.

2. Click **Online** and then search for `Test Extension Pack`.

3. Click **Download**. The extension and its list of extensions included in the Extension Pack will then be scheduled for install.

4. Below is a sample extension pack download view of the **Extensions and Updates** dialog. If you prefer to install only some of the included extensions in the Extension pack, you can modify the extension list in **Scheduled For Install**.

    ![Download Extension Pack from Marketplace](media/vside-extensionpack.png)

4. To complete the installation, close all instances of Visual Studio.

## Remove the Extension

To remove the extension from your computer

1. In Visual Studio, on the **Tools** menu, click **Extension and Updates...**.

2. Select `Test Extension Pack` and then click **Uninstall**. The extension and its list of extensions included in the Extension Pack will then be scheduled for uninstall.

3. To complete the uninstallation, close all instances of Visual Studio.
