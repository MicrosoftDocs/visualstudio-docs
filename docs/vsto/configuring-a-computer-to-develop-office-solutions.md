---
title: "Configuring a Computer to Develop Office Solutions | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Office development in Visual Studio, installing tools"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Configuring a Computer to Develop Office Solutions
  To create VSTO Add-ins and customizations for Microsoft Office, install a supported version of Visual Studio, the .NET Framework, and Microsoft Office.  
  
|Software|Supported versions|  
|--------------|------------------------|  
|Visual Studio|-   [!INCLUDE[vsPro](../sharepoint/includes/vspro-md.md)]<br />-   [!INCLUDE[vsPreShort](../vsto/includes/vspreshort-md.md)]<br />-   [!INCLUDE[vsUltShort](../vsto/includes/vsultshort-md.md)] **Important:**  You must select the Microsoft Office Developer Tools check box during setup.|  
|.NET Framework|-   The .NET Framework 4 or later.|  
|Microsoft Office|<ul><li>Any suite edition of Office including Office Professional Plus for Office 365.</li><li>Any of the following standalone applications:<br /><br /> <ul><li>Excel</li><li>InfoPath (Office 2013 and Office 2010 only)</li><li>Outlook</li><li>PowerPoint</li><li>Project</li><li>Visio</li><li>Word</li></ul></li></ul><br /> Visual Basic for Applications (VBA) must be installed as part of Office. **Important:**  Click-to-Run versions of Office 2010 applications are not supported.|  
  
 For detailed installation steps, see [How to: Configure a Computer to Develop Office Solutions](../vsto/how-to-configure-a-computer-to-develop-office-solutions.md).  
  
## If project templates don't appear or they don't work in Visual Studio  
 If you install a supported version of Visual Studio, the .NET Framework, and Microsoft Office, but Office project templates either don't appear in the Visual Studio **New Project** dialog box, or you receive an error when you try to use one, check the following:  
  
-   Ensure that you have the Microsoft Office developer tools installed on your computer.  
  
     Office developer tools are an optional component of Visual Studio, but they are usually installed automatically along with Visual Studio. If you customize the Visual Studio installation by specifying which features to install, make sure that you choose **Microsoft Office Developer Tools** during setup to install the tools.  
  
     To ensure that these tools are installed, start the Visual Studio setup program, and choose the **Modify** button. Select the **Microsoft Office Developer Tools** check box, and then choose the **Update** button.  
  
-   Ensure that you're not running a version of Office that was delivered by Click-to-Run. See [How to: Verify Whether Outlook Is a Click-to-Run Application on a Computer](http://msdn.microsoft.com/library/office/ff864733(v=office.14).aspx).  
  
-   Ensure that you're running only one version of Microsoft Office.  
  
 If you continue to experience problems, see [Additional Support for Errors in Office Solutions](../vsto/additional-support-for-errors-in-office-solutions.md).  
  
## See Also  
 [Getting Started &#40;Office Development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md)   
 [How to: Configure a Computer to Develop Office Solutions](../vsto/how-to-configure-a-computer-to-develop-office-solutions.md)   
 [How to: Install the Visual Studio Tools for Office Runtime Redistributable](../vsto/how-to-install-the-visual-studio-tools-for-office-runtime-redistributable.md)   
 [How to: Install Office Primary Interop Assemblies](../vsto/how-to-install-office-primary-interop-assemblies.md)   
 [Features Available by Office Application and Project Type](../vsto/features-available-by-office-application-and-project-type.md)  
  
  