---
title: "How to: Include Prerequisites with a ClickOnce Application | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
ms.assetid: c66bf0a5-8c93-4e68-a224-3b29ac36fe4d
caps.latest.revision: 18
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Include Prerequisites with a ClickOnce Application
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Before you can distribute prerequisite software with a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application, you must first download the installer packages for those prerequisites to your development computer. When you publish an application and choose **Download prerequisites from the same location as my application**, an error will occur if the installer packages aren’t in the **Packages** folder.  
  
> [!NOTE]
> To add an installer package for the .NET Framework, see [.NET Framework Deployment Guide for Developers](https://msdn.microsoft.com/library/ee942965\(v=vs.110\).aspx).  
  
## <a name="Package"></a> To add an installer package by using Package.xml  
  
1. In File Explorer, open the **Packages** folder.  
  
     By default, the path is C:\Program Files\Microsoft Visual Studio 14.0\SDK\Bootstrapper\Packages on a 32-bit system and C:\Program Files (x86)\Microsoft Visual Studio 14.0\SDK\Bootstrapper\Packages on a 64-bit system.  
  
2. Open the folder for the prerequisite that you want to add, and then open the language folder for your installed version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] (for example, **en** for English).  
  
3. In Notepad, open the **Package.xml** file.  
  
4. Locate the **Name** element that contains **http://go.microsoft.com/fwlink**, and copy the URL. Include the **LinkID** portion.  
  
    > [!NOTE]
    > If no **Name** element contains **http://go.microsoft.com/fwlink**, open the **Product.xml** file in the root folder for the prerequisite and locate the **fwlink** string.  
  
    > [!IMPORTANT]
    > Some prerequisites have multiple installer packages (for example, for 32-bit or 64-bit systems). If multiple **Name** elements contain **fwlink**, you must repeat the remaining steps for each of them.  
  
5. Paste the URL into the address bar of your browser, and then, when you are prompted to run or save, choose **Save**.  
  
     This step downloads the installer file to your computer.  
  
6. Copy the file to the root folder for the prerequisite.  
  
     For example, for the Windows Installer 4.5 prerequisite, copy the file to the \Packages\WindowsInstaller4_5 folder.  
  
     You can now distribute the installer package with your application.  
  
## See Also  
 [How to: Install Prerequisites with a ClickOnce Application](../deployment/how-to-install-prerequisites-with-a-clickonce-application.md)
