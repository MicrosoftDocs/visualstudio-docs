---
title: Creating an Extension with a Tool Window
description: Use the VSIX project template and the Custom Tool Window item template to create an extension with a tool window in Visual Studio.
ms.date: 3/16/2019
ms.topic: how-to
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create an extension with a tool window

In this procedure, you learn how to use the VSIX project template and the **Custom Tool Window** item template to create an extension with a tool window.

### Create a tool window

1. Create a VSIX project named **FirstWindow**. You can find the VSIX project template in the **New Project** dialog by searching for "vsix".

2. When the project opens, add a tool window item template named **MyWindow**. In the **Solution Explorer**, right-click the project node and select **Add** > **New Item**. In the **Add New Item** dialog, go to **Visual C#** > **Extensibility** and select **Custom Tool Window**. In the **Name** field at the bottom of the window, change the tool window file name to *MyWindow.cs*.

3. Build the project and start debugging.

   The experimental instance of Visual Studio appears. For more information about the experimental instance, see [The experimental instance](../extensibility/the-experimental-instance.md).

4. In the experimental instance, go to **View** > **Other Windows**.

   You should see a menu item for **MyWindow**. Click it.

   You should see a tool window with the title **MyWindow** and a button saying **Click Me!.**
