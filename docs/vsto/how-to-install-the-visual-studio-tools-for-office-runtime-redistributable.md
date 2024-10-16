---
title: Install the Visual Studio Tools for Office Runtime Redistributable
description: Install the Microsoft Visual Studio 2010 Tools for Office Runtime redistributable, and review installation requirements.
titleSuffix: ""
ms.date: "01/25/2022"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office runtime [Office development in Visual Studio]"
  - "installing Office development tools in Visual Studio"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Install the Visual Studio Tools for Office Runtime Redistributable

   Each computer that runs solutions created by using the Visual Studio in Visual Studio, must install the Visual Studio 2010 Tools for Office runtime. The runtime is installed automatically when you install Visual Studio, and Microsoft Office. For more information, see [Visual Studio Tools for Office runtime installation scenarios](../vsto/visual-studio-tools-for-office-runtime-installation-scenarios.md).

[!include[Add-ins note](includes/addinsnote.md)]

 You might need to follow the manual installation instructions in the following situations:

- You need to install the  Visual Studio Tools for Office runtime  on a server.

- You need to install the runtime on a computer that already has all the other prerequisites for Office solutions installed.

    > [!NOTE]
    > You must be an administrator on the development computer to install the .NET Framework and the  Visual Studio Tools for Office runtime .

## To install the Visual Studio Tools for Office runtime

1. Install the .NET Framework 4 or later.

    - To download the .NET Framework 4, see [Microsoft .NET Framework 4 (Web Installer)](https://www.microsoft.com/download/details.aspx?id=17851).

    - To download the .NET Framework 4 Client Profile, see [Microsoft .NET Framework 4 Client Profile (Web Installer)](https://www.microsoft.com/download/details.aspx?id=17113).

    - To download the .NET Framework 4.5, see [Microsoft .NET Framework 4.5](https://www.microsoft.com/download/details.aspx?id=30653).

2. Run *vstor_redist.exe* to install the  Visual Studio Tools for Office runtime .

     You can download these setup files from [Visual Studio 2010 Tools for Office runtime](https://go.microsoft.com/fwlink/?linkid=140384). The prerequisites for the  Visual Studio Tools for Office runtime  match the prerequisites for the .NET Framework.

     The  Visual Studio Tools for Office runtime  includes language packs. If your installation of Windows is set to a language other than English, you can display runtime messages in the same language that you use for Windows. Similarly, if you install the  Visual Studio Tools for Office runtime . Then run your solutions on installations of Windows with a language other than English, runtime messages will appear in the same language as Windows. In some cases, you might need more language packs. For example, you might need extra language packs if your copy of Windows uses more than one language setting. Alternatively, you can switch to another language after you've already installed the  Visual Studio Tools for Office runtime . You can find language packs at [Microsoft Visual Studio 2010 Tools for the Microsoft Office system (version 4.0 runtime) language pack](https://go.microsoft.com/fwlink/?LinkId=140386).

## Related content

- [Get started &#40;Office development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md)
- [Configure a computer to develop Office solutions](../vsto/how-to-configure-a-computer-to-develop-office-solutions.md)
- [How to: Install Office primary interop assemblies](../vsto/how-to-install-office-primary-interop-assemblies.md)
- [Manage documents on a server by using the ServerDocument class](../vsto/managing-documents-on-a-server-by-using-the-serverdocument-class.md)
- [Deploy an Office solution](../vsto/deploying-an-office-solution.md)
