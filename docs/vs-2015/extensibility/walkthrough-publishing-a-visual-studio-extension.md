---
title: "Publish an Extension | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords:
  - "publishing web controls"
  - "web controls, publishing"
ms.assetid: a7816161-0490-4043-86f5-0f7331ed83b3
caps.latest.revision: 21
ms.author: gregvanl
manager: jillfra
---
# Walkthrough: Publishing a Visual Studio Extension
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

**Note**: The Visual Studio Gallery is being replaced by the Visual Studio Marketplace. See the latest version of this topic for details.

This walkthrough shows you how to publish a Visual Studio extension to the Visual Studio Gallery. When you add your extension to the Gallery, developers can use **Extensions and Updates** to browse there for new and updated extensions.

## Prerequisites
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md).

## Create a Visual Studio Extension
 In this case we will use a default VSPackage extension, but the same steps are valid for every kind of extension.

1. Create a VSPackage in C# named `TestPublishing` that has a menu command. For more information, see [Creating an Extension with a Menu Command](../extensibility/creating-an-extension-with-a-menu-command.md).

## Test the Extension
 Before you distribute the extension, build and test it to make sure it is installed correctly in the experimental instance of Visual Studio.

1. In Visual Studio, start debugging. to open an experimental instance of Visual Studio.

2. In the experimental instance, go to the **Tools** menu and click **Extension Manager**. The TestPublishing extension should appear in the center pane and be enabled.

3. On the **Tools** menu, make sure you see the test command.

## Publish the Extension to the Visual Studio Gallery
 Now you can publish the extension to the Visual Studio Gallery.

1. Make sure that you have built the Release version of your extension and that it is up-to-date.

2. In a web browser, open the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) website.

3. In the upper-right corner, click **SIGN IN**.

4. Use your Microsoft account to sign in. If you do not have a Microsoft account, you can create one at this point.

5. Click **Upload**.

6. In **Step 1: Extension Type**, select **Tool** and then click **Next**.

7. In **Step 2: Upload**, you can choose to upload directly to Visual Studio Gallery or just add a link to your own website. In this case select **I would like to upload my tool**. The **Select your control** box appears. Click **Browse** and then select TestPublish.vsix in the \bin\Release folder of the project. Click **Next**.

8. In **Step 3: Basic Information**, fields from the source.extension.vsixmanifest file are displayed. Select an appropriate **Category** and add **Tags** to help users find your extension. You may want to add a more detailed summary and description (the description must be at least 280 characters long). Leave **Extension Type** as **Not a Microsoft Extension** and **Cost Category** as **Trial**.

9. Read the Contribution Agreement at the bottom of the page and check **I agree**.

10. Click **Create Contribution**. This displays the page your extension will have on the Visual Studio Gallery, with a message that the page has not yet been published.

11. Click **Publish**.

12. Search the Visual Studio Gallery for your extension. The listing for the TestPublish extension should appear.

## Install the Extension from the Visual Studio Gallery
 Now that the extension is published, install it in Visual Studio and test it there.

1. In Visual Studio, on the **Tools** menu, click **Extensions and Updates**.

2. Click **Online** and then search for TestPublish. The listing for the TestPublish extension should appear.

3. Click **Download**. After the extension is downloaded, click **Install**.

4. To complete the installation, restart Visual Studio.

## Removing the Extension
 You can remove the extension from the Visual Studio Gallery and from your computer.

#### To remove the extension from the Visual Studio Gallery

1. Open the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) website.

2. In the upper-right corner, click **My Extenions**. The listing for TestPublish is displayed.

3. Click **Delete**.

#### To remove the extension from your computer

1. In Visual Studio, on the **Tools** menu, click **Extension Manager**.

2. Select TestPublish and then click **Uninstall**.

3. To complete the uninstallation, restart Visual Studio.
