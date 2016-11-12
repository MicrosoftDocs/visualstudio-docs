---
title: "Web Site Support Attributes | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "web site projects, registration"
ms.assetid: 46d52e2c-ca2a-4bbd-8500-5b0129768aec
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Web Site Support Attributes
[!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] Web site project can be extended to provide support for Web programming languages. The language must register itself with [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] so that project templates can appear in the **New Web Site** dialog box when the language is selected.  
  
 The IronPython Studio sample includes web site support. You can find it with the [VSSDK Samples](../../misc/vssdk-samples.md). It includes the following attribute classes to register IronPython as a codebehind language for new Web projects.  
  
## WebSiteProjectAttribute  
 This attribute is placed on the language project. It adds the language to the list of Web programming languages in the **Language** list in the **New Web Site** dialog box. For example, the following adds IronPython to the list:  
  
```  
[WebSiteProject("IronPython", "Iron Python")]public class PythonProjectPackage : ProjectPackage  
```  
  
 This attribute also sets the templates path to point to the templates folder. For more information on the location of the templates folder, see [Web Site Support Templates](../../extensibility/internals/web-site-support-templates.md).  
  
## WebSiteProjectRelatedFilesAttribute  
 This attribute is placed on the language project. It allows the Web Site project to nest one file type (related) under another file type (primary) in the **Solution Explorer**.  
  
 For example:  
  
```  
[WebSiteProjectRelatedFiles("aspx", "py")]public class PythonProjectPackage : ProjectPackage  
```  
  
 specifies that an IronPython codebehind file is related to an .aspx file. When a new .aspx Web page is created in an IronPython Web site solution, a new .py source file is generated and appears as a child node of the .aspx page.  
  
## ProvideIntellisenseProviderAttribute  
 This attribute is placed on the language project package. It selects the Intellisense provider for the language.  
  
 For example:  
  
```  
[ProvideIntellisenseProvider(typeof(PythonIntellisenseProvider), "IronPythonCodeProvider", "Iron Python", ".py", "IronPython;Python", "IronPython")]public class PythonPackage : Package, IOleComponent  
```  
  
 specifies that an instance of PythonIntellisenseProvider, which implements <xref:Microsoft.VisualStudio.Shell.Interop.IVsIntellisenseProject>, should be created on demand to provide language services.  
  
 The IVsIntellisenseProject implementation handles references and calls the language compiler when a Web page with code is requested but is not cached.  
  
## See Also  
 [Web Site Support](../../extensibility/internals/web-site-support.md)