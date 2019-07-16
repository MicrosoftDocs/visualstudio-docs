---
title: "Web Site Support | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "web site projects"
ms.assetid: ce9f4266-bb64-4c09-be88-4bd6413f60d0
caps.latest.revision: 18
ms.author: gregvanl
manager: jillfra
---
# Web Site Support
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

A Web site project system is a project system that creates Web projects. Web projects in turn create Web applications. A Web site project generates one executable file for each Web page that has associated code. Additional executable files are generated from the source code files in the /App_Code folder.  
  
 Web site project systems are created by adding templates and registration attributes to an existing project system. One of these attributes selects the IntelliSense provider for the language. The IntelliSense provider implementation handles references and calls the language compiler when a smart Web page that is not cached is requested.  
  
 The language compiler used to compile Web pages must be registered with [!INCLUDE[vstecasp](../../includes/vstecasp-md.md)]. You can use the [\<compiler> Element](https://msdn.microsoft.com/library/7a151659-b803-4c27-b5ce-1c4aa0d5a823) in a Web.config file to register the compiler, as in the following example:  
  
```  
<system.codedom>  <compilers>    <compiler language="py;IronPython" extension=".py"       type="IronPython.CodeDom.PythonProvider, IronPython,       Version=1.0.2391.18146, Culture=neutral,       PublicKeyToken=b03f5f7f11d50a3a" />  </compilers></system.codedom>  
```  
  
## In This Section  
 [Web Site Support Templates](../../extensibility/internals/web-site-support-templates.md)  
 Lists the templates that you can use to create new Web site projects and associated items.  
  
 [Web Site Support Attributes](../../extensibility/internals/web-site-support-attributes.md)  
 Presents the registration attributes that connect a Web site project to [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] and [!INCLUDE[vstecasp](../../includes/vstecasp-md.md)].  
  
## Related Sections  
 [Web Projects](../../extensibility/internals/web-projects.md)  
 Presents an overview of the two kinds of Web projects, Web site projects and Web application projects.
