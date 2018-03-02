---
title: "Office Primary Interop Assemblies | Microsoft Docs"
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
  - "primary interop assemblies"
  - "assemblies [Office development in Visual Studio], primary interop assemblies"
  - "Office primary interop assemblies"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Office Primary Interop Assemblies
  To use the features of a Microsoft Office application from an Office project, you must use the primary interop assembly (PIA) for the application. The PIA enables managed code to interact with a Microsoft Office application's COM-based object model.  
  
 When you create a new Office project, Visual Studio adds references to the PIAs that are required to build the project. In some scenarios, you might need to add references to additional PIAs (for example, if you want to use a feature of Microsoft Office Word in a project for Microsoft Office Excel).  
  
 This topic describes the following aspects of using the Microsoft Office PIAs in Office projects:  
  
-   [Separate primary interop assemblies for building and running projects](#separateassemblies)  
  
-   [Using features of multiple Microsoft Office applications in a single project](#usingfeatures)  
  
-   [Full list of primary interop assemblies for Microsoft Office applications](#pialist)  
  
 For more information about primary interop assemblies, see [Primary Interop Assemblies](http://msdn.microsoft.com/en-us/b977a8be-59a0-40a0-a806-b11ffba5c080).  
  
##  <a name="separateassemblies"></a> Separate Primary Interop Assemblies for Building and Running Projects  
 Visual Studio uses different sets of the PIAs on the development computer. These different sets of assemblies are in the following locations:  
  
-   A folder in the program files directory.  
  
     These copies of the assemblies are used when you write code and build projects. Visual Studio installs these assemblies automatically.  
  
-   The global assembly cache.  
  
     These copies of the assemblies are used during some development tasks, such as when you run or debug projects. Visual Studio does not install and register these assemblies; you must do this yourself.  
  
### Primary Interop Assemblies in the Program Files Directory  
 When you install Visual Studio, the PIAs are automatically installed to a location in the file system, outside of the global assembly cache. When you create a new project, Visual Studio automatically adds references to these copies of the PIAs to your project. Visual Studio uses these copies of the PIAs, instead of the assemblies in the global assembly cache, to resolve type references when you develop and build your project.  
  
 These copies of the PIAs help Visual Studio avoid several development issues that can occur when different versions of the PIAs are registered in the global assembly cache.  
  
 Visual Studio installs these copies of PIAs to the following locations on the development computer:  
  
-   %ProgramFiles%\Microsoft Visual Studio 12.0\Visual Studio Tools for Office\PIA\Office14  
  
     (or %ProgramFiles(x86)%\Microsoft Visual Studio 12.0\Visual Studio Tools for Office\PIA\Office14 on 64-bit operating systems)  
  
-   %ProgramFiles%\Microsoft Visual Studio 12.0\Visual Studio Tools for Office\PIA\Office15  
  
     (or %ProgramFiles(x86)%\Microsoft Visual Studio 12.0\Visual Studio Tools for Office\PIA\Office15 on 64-bit operating systems)  
  
### Primary Interop Assemblies in the Global Assembly Cache  
 To perform certain development tasks, the PIAs must be installed and registered in the global assembly cache on the development computer. Typically, the PIAs are installed automatically when you install Office on the development computer. For more information, see [Configuring a Computer to Develop Office Solutions](../vsto/configuring-a-computer-to-develop-office-solutions.md).  
  
 The Office PIAs are not required on end-user computers to run Office solutions. For more information, see [Designing and Creating Office Solutions](../vsto/designing-and-creating-office-solutions.md).  
  
##  <a name="usingfeatures"></a> Using Features of Multiple Microsoft Office Applications in a Single Project  
 Every Office project template in Visual Studio is designed to work with a single Microsoft Office application. To use features in multiple Microsoft Office applications, or to use features in an application or component that does not have a project in Visual Studio, you must add a reference to the required PIAs.  
  
 In most cases, you should add references to the PIAs that are installed by Visual Studio under the %ProgramFiles%\Microsoft Visual Studio 12.0\Visual Studio Tools for Office\PIA\ directory. These versions of the assemblies appear on the **Framework** tab of the **Reference Manger** dialog box. For more information, see [How to: Target Office Applications Through Primary Interop Assemblies](../vsto/how-to-target-office-applications-through-primary-interop-assemblies.md).  
  
 If you have installed and registered the PIAs in the global assembly cache, these versions of the assemblies appear on the **COM** tab of the **Reference Manager** dialog box. You should avoid adding references to these versions of the assemblies, because there are some development issues that can occur when you use them. For example, if you have registered different versions of the PIAs in the global assembly cache, your project will automatically bind to the version of the assembly that was registered last—even if you specify a different version of the assembly on the **COM** tab of the **Reference Manager** dialog box.  
  
> [!NOTE]  
>  Some assemblies are added to a project automatically when an assembly that references them is added. For example, references to the Office.dll and Microsoft.Vbe.Interop.dll assemblies are added automatically when you add a reference to the Word, Excel, Outlook, Microsoft Forms, or Graph assemblies.  
  
##  <a name="pialist"></a> Primary Interop Assemblies for Microsoft Office Applications  
 The following table lists the primary interop assemblies that are available for [!INCLUDE[Office_15_short](../vsto/includes/office-15-short-md.md)] and [!INCLUDE[office14_long](../vsto/includes/office14-long-md.md)].  
  
|Office application or component|Primary interop assembly name|  
|-------------------------------------|-----------------------------------|  
|Microsoft Access 14.0 Object Library<br /><br /> Microsoft Access 15.0 Object Library|Microsoft.Office.Interop.Access.dll|  
|Microsoft Office 14.0 Access Database Engine Object Library<br /><br /> Microsoft Office 15.0 Access Database Engine Object Library|Microsoft.Office.Interop.Access.Dao.dll|  
|Microsoft Excel 14.0 Object Library<br /><br /> Microsoft Excel 15.0 Object Library|Microsoft.Office.Interop.Excel.dll|  
|Microsoft Graph 14.0 Object Library (used by PowerPoint, Access, and Word for graphs)<br /><br /> Microsoft Graph 15.0 Object Library|Microsoft.Office.Interop.Graph.dll|  
|Microsoft InfoPath 2.0 Type Library (for InfoPath 2007 only)|Microsoft.Office.Interop.InfoPath.dll|  
|Microsoft InfoPath XML Interop Assembly (for InfoPath 2007 only)|Microsoft.Office.Interop.InfoPath.Xml.dll|  
|Microsoft Office 14.0 Object Library (Office shared functionality)<br /><br /> Microsoft Office 15.0 Object Library (Office shared functionality)|office.dll|  
|Microsoft Office Outlook View Control (can be used in Web pages and applications to access your Inbox)|Microsoft.Office.Interop.OutlookViewCtl.dll|  
|Microsoft Outlook 14.0 Object Library<br /><br /> Microsoft Outlook 15.0 Object Library|Microsoft.Office.Interop.Outlook.dll|  
|Microsoft PowerPoint 14.0 Object Library<br /><br /> Microsoft PowerPoint 15.0 Object Library|Microsoft.Office.Interop.PowerPoint.dll|  
|Microsoft Project 14.0 Object Library<br /><br /> Microsoft Project 15.0 Object Library|Microsoft.Office.Interop.MSProject.dll|  
|Microsoft Publisher 14.0 Object Library<br /><br /> Microsoft Publisher 15.0 Object Library|Microsoft.Office.Interop.Publisher.dll|  
|Microsoft SharePoint Designer 14.0 Web Object Reference Library|Microsoft.Office.Interop.SharePointDesigner.dll|  
|Microsoft SharePoint Designer 14.0 Page Object Reference Library|Microsoft.Office.Interop.SharePointDesignerPage.dll|  
|Microsoft Smart Tags 2.0 Type Library **Note:**  Smart tags are deprecated in [!INCLUDE[Excel_14_short](../vsto/includes/excel-14-short-md.md)] and [!INCLUDE[Word_14_short](../vsto/includes/word-14-short-md.md)].|Microsoft.Office.Interop.SmartTag.dll|  
|Microsoft Visio 14.0 Type Library<br /><br /> Microsoft Visio 15.0 Type Library|Microsoft.Office.Interop.Visio.dll|  
|Microsoft Visio 14.0 Save As Web Type Library<br /><br /> Microsoft Visio 15.0 Save As Web Type Library|Microsoft.Office.Interop.Visio.SaveAsWeb.dll|  
|Microsoft Visio 14.0 Drawing Control Type Library<br /><br /> Microsoft Visio 15.0 Drawing Control Type Library|Microsoft.Office.Interop.VisOcx.dll|  
|Microsoft Word 14.0 Object Library<br /><br /> Microsoft Word 15.0 Object Library|Microsoft.Office.Interop.Word.dll|  
|Microsoft Visual Basic for Applications Extensibility 5.3|Microsoft.Vbe.Interop.dll|  
  
### Binding Redirect Assemblies  
 When you install and register the Office PIAs in the global assembly cache (either with Office or by installing the redistributable package for the PIAs), the binding redirect assemblies are also installed only in the global assembly cache. These assemblies help make sure that the correct version of the primary interop assemblies are loaded at run time. For example, when a solution that references a [!INCLUDE[office14_long](../vsto/includes/office14-long-md.md)] assembly runs on a computer that has the [!INCLUDE[Office_15_short](../vsto/includes/office-15-short-md.md)] version of the same primary interop assembly, the binding redirect assembly instructs the [!INCLUDE[dnprdnshort](../sharepoint/includes/dnprdnshort-md.md)] runtime to load the [!INCLUDE[Office_15_short](../vsto/includes/office-15-short-md.md)] version of the primary interop assembly. For more information, see [How to: Enable and Disable Automatic Binding Redirection](/dotnet/framework/configure-apps/how-to-enable-and-disable-automatic-binding-redirection).  
  
## See Also  
 [How to: Target Office Applications Through Primary Interop Assemblies](../vsto/how-to-target-office-applications-through-primary-interop-assemblies.md)   
 [Excel Object Model Overview](../vsto/excel-object-model-overview.md)   
 [InfoPath Solutions](../vsto/infopath-solutions.md)   
 [Outlook Object Model Overview](../vsto/outlook-object-model-overview.md)   
 [PowerPoint Solutions](../vsto/powerpoint-solutions.md)   
 [Project Solutions](../vsto/project-solutions.md)   
 [Visio Object Model Overview](../vsto/visio-object-model-overview.md)   
 [Word Object Model Overview](../vsto/word-object-model-overview.md)   
 [General Reference &#40;Office Development in Visual Studio&#41;](../vsto/general-reference-office-development-in-visual-studio.md)  
  
  