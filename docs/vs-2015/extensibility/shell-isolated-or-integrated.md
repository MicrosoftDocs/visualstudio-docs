---
title: "Shell (Isolated or Integrated) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Visual Studio shell"
  - "Visual Studio, Shell"
  - "Shell [Visual Studio]"
  - "Visual Studio shell, shell-based applications"
  - "Shell [Visual Studio], shell-based applications"
ms.assetid: c64a9bf0-9bf8-45c3-8fa2-306fa6cab66a
caps.latest.revision: 26
ms.author: gregvanl
manager: jillfra
---
# Shell (Isolated or Integrated)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can create your own Visual Studio-based application in either integrated or isolated mode. In integrated mode, many Visual Studio features are available in addition to your application. In the isolated mode, you choose a subset of Visual Studio features that you wish to distribute along with your own extension.  
  
## Integrated Mode  
 Integrated mode enables your users to use standard Visual Studio features along with your custom tools. The integrated shell is intended primarily for hosting programming languages and software development tools.  
  
 Custom tools that are built on the integrated shell automatically merge with any other edition of Visual Studio that is installed on the same computer. You can provide a redistributable version of the Visual Studio integrated shell if Visual Studio is not already installed.  
  
 The redistributable version of the Visual Studio integrated shell does not include programming languages and the features that support their respective project systems.  
  
> [!NOTE]
> The Visual Studio shell integrated mode can be installed together with all editions of Visual Studio except the Express editions.  
  
 For more information, see [Visual Studio Shell (Integrated)](../extensibility/visual-studio-shell-integrated.md).  
  
## Isolated Mode  
 Isolated mode allows you to create custom tools that run side-by-side with other versions of Visual Studio. It is intended primarily for tools that can access Visual Studio services without depending on all the standard Visual Studio features. You can customize the appearance of applications built on the Visual Studio isolated shell. You can easily turn off the features and menu command groups that you do not wish to appear together with your application.  
  
 For more information, see [Visual Studio Isolated Shell](../extensibility/visual-studio-isolated-shell.md).  
  
## Distributing your Integrated or Isolated Shell Application  
 In order to distribute your integrated or isolated shell application, you need to include your application, a special integrated or isolated shell redistributable, and an installation program. For more information about distribution and installation, see [Distributing Isolated Shell Applications](../extensibility/distributing-isolated-shell-applications.md).  
  
> [!IMPORTANT]
> The [End User License Agreement (EULA)](https://www.visualstudio.com/support/legal/mt171552) for the Visual Studio integrated and isolated shells includes a section on data collection (**Section 3. Data**).  It describes the customer usage data that may be collected by Microsoft from users of either the integrated or isolated shell software that you build into your application. For more information, see [Microsoft Visual Studio Product Family Privacy Statement](https://www.visualstudio.com/dn948229).  
> 
> If you collect separate usage data from your customers through your application, you must provide appropriate notice to users of your application of what you collect.  When you distribute either the isolated or integrated shell software as part of your application, according to the Visual Studio Software Development Kit license, you must include one of the following:  
> 
> - the End User License Agreement as part of your application license  
> - your own EULA that requires your customers to agree to terms that protect the Visual Studio integrated or isolated shell at least as much as the Microsoft End User License Terms for the shell software  
  
## Additional Resources  
 For more information about redistributable packages, see the [Visual Studio Extensibility Downloads](https://go.microsoft.com/fwlink/?LinkID=119298) Web site.  
  
## See Also  
 [Shipping Visual Studio Extensions](../extensibility/shipping-visual-studio-extensions.md)
