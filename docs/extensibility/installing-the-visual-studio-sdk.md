---
title: Installing the Visual Studio SDK
description: Explore installation options for the Visual Studio Software Development Kit, including during Visual Studio installation.
ms.date: 02/02/2024
ms.topic: overview
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Install the Visual Studio SDK

The Visual Studio SDK (Software Development Kit) is an optional feature in Visual Studio setup. You can also install the VSSDK later on.

## Install the Visual Studio SDK as part of a Visual Studio installation

To include the VSSDK in your Visual Studio installation, install the **Visual Studio extension development** workload under **Other Toolsets**. This workload will install the Visual Studio SDK and the necessary prerequisites. You can further tune the installation by selecting or unselecting components from the **Summary** view.

## Install the Visual Studio SDK after installing Visual Studio

To install the Visual Studio SDK after completing your Visual Studio installation, rerun the Visual Studio installer and select the **Visual Studio extension development** workload.

## Install the Visual Studio SDK from a solution

If you open a solution with an extensibility project without first installing the VSSDK, you'll be prompted by an **Install Missing Feature** dialog to install the **Visual Studio extension development** workload:

::: moniker range="vs-2019"
:::image type="content" source="media/install-extension-development.png" alt-text="Screenshot showing the Visual Studio dialog to Install extension development workload.":::
::: moniker-end

::: moniker range=">=vs-2022"
:::image type="content" source="media/vs-2022/install-extension-development.png" alt-text="Screenshot showing the Visual Studio dialog to Install extension development workload.":::
::: moniker-end

## Install the Visual Studio SDK from the command line

As with any Visual Studio workload or component, you can also install the **Visual Studio extension development** workload (ID: `Microsoft.VisualStudio.Workload.VisualStudioExtension`) from the command line. See [Use command-line parameters to install Visual Studio](../install/use-command-line-parameters-to-install-visual-studio.md) for details on the appropriate command-line switches and general instructions on determining workload or component identifiers.
