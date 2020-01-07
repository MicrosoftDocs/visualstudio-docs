---
title: "How to: Install the Visual Studio Tools for Office runtime redistributable"
titleSuffix: ""
ms.custom: "seodec18"
ms.date: "08/14/2019"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office runtime [Office development in Visual Studio]"
  - "installing Office development tools in Visual Studio"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Install the Visual Studio Tools for Office runtime redistributable
  The Visual Studio 2010 Tools for Office runtime must be installed on each computer that runs solutions that are created by using the Microsoft Office developer tools in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. The runtime is installed automatically when you install [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], and Microsoft Office. For more information, see [Visual Studio Tools for Office runtime installation scenarios](../vsto/visual-studio-tools-for-office-runtime-installation-scenarios.md).

[!include[Add-ins note](includes/addinsnote.md)]

 You might need to follow the manual installation instructions below in the following situations:

- You need to install the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] on a server. For example, you want to use the <xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class to manage document-level solutions on a server.

- You need to install the runtime on a computer that already has all the other prerequisites for Office solutions installed.

    > [!NOTE]
    > You must be an administrator on the development computer to install the .NET Framework and the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)].

## To install the Visual Studio Tools for Office runtime

1. Install the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later.

    - To download the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)], see [Microsoft .NET Framework 4 (Web Installer)](https://www.microsoft.com/download/details.aspx?id=17851).

    - To download the [!INCLUDE[net_client_v40_long](../vsto/includes/net-client-v40-long-md.md)], see [Microsoft .NET Framework 4 Client Profile (Web Installer)](https://www.microsoft.com/download/details.aspx?id=17113).

    - To download the [!INCLUDE[net_v45](../vsto/includes/net-v45-md.md)], see [Microsoft .NET Framework 4.5](https://www.microsoft.com/download/details.aspx?id=30653).

2. Run *vstor_redist.exe* to install the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)].

     You can download these setup files from [Visual Studio 2010 Tools for Office runtime](https://www.microsoft.com/download/details.aspx?id=56961). The prerequisites for the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] match the prerequisites for the .NET Framework.

     The [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] includes language packs. If your installation of Windows is set to a language other than English, you can display runtime messages in the same language that you use for Windows. Similarly, if end users install the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] and then run your solutions on installations of Windows that are set to a language other than English, runtime messages will appear in the same language as Windows. In some cases, you might need additional language packs. For example, you might need additional language packs if your copy of Windows uses more than one language setting, or you switch to another language after you've already installed the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)]. You can find language packs at [Microsoft Visual Studio 2010 Tools for the Microsoft Office system (version 4.0 runtime) language pack](https://www.microsoft.com/download/details.aspx?id=54246).

## See also
- [Get started &#40;Office development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md)
- [Configure a computer to develop Office solutions](../vsto/configuring-a-computer-to-develop-office-solutions.md)
- [How to: Configure a computer to develop Office solutions](../vsto/how-to-configure-a-computer-to-develop-office-solutions.md)
- [How to: Install Office primary interop assemblies](../vsto/how-to-install-office-primary-interop-assemblies.md)
- [Manage documents on a server by using the ServerDocument class](../vsto/managing-documents-on-a-server-by-using-the-serverdocument-class.md)
- [Deploy an Office solution](../vsto/deploying-an-office-solution.md)
