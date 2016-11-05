---
title: "How to: Change the Namespace of a Domain-Specific Language | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Domain-Specific Language, namespace"
ms.assetid: f20c47e5-230d-4f0e-812f-5c6edb86866c
caps.latest.revision: 19
author: "alancameronwills"
ms.author: "awills"
manager: "douge"
---
# How to: Change the Namespace of a Domain-Specific Language
You can change the namespace of a domain-specific language. You must make the change in the **DSL Explorer**, in the properties of the Dsl Package project, and in the assembly information.  
  
### To change the namespace of a domain-specific language  
  
1.  In **DSL Explorer**, click the **Dsl** node.  
  
2.  In the **Properties** window, change the **Namespace** property.  
  
3.  Save the solution and transform the templates.  
  
4.  On the **Project** menu, click **Dsl Properties**.  
  
     The properties for your project appear.  
  
5.  Click the **Application** tab.  
  
6.  Change the **Default namespace** property to the new namespace name.  
  
7.  If you also want to change the name of the assembly, change the **Assembly name property.**  
  
8.  If you have changed the Assembly name, open DslPackage\Package.tt and update this line:  
  
     `string dslAssembly = "YourDSLassembly.Dsl.dll";`  
  
9. If you have written any custom code, make sure to change the namespace and class references in the code files.  
  
10. Reset the Visual Studio Experimental instance.  
  
    1.  Delete **\Users\\***{your name}***\AppData\Local\Microsoft\VisualStudio\\\*Exp**  
  
    2.  On the Windows **Start** menu, choose **All Programs**, **Microsoft Visual Studio 2010 SDK**, **Tools**, **Reset the Experimental Instance**.  
  
11. On the **Build** menu, choose **Rebuild Solution**.  
  
## See Also  
 [Domain-Specific Language Tools Glossary](http://msdn.microsoft.com/en-us/ca5e84cb-a315-465c-be24-76aa3df276aa)