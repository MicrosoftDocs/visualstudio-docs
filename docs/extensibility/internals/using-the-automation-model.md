---
title: "Using the Automation Model | Microsoft Docs"
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
  - "automation [Visual Studio SDK], automation model"
ms.assetid: 0c7f7889-fbfb-4b19-804f-b742138baecd
caps.latest.revision: 15
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
# Using the Automation Model
After you have connected your VSPackage to automation, you can obtain the properties and methods by calling the <xref:EnvDTE.DTEClass.GetObject%2A> method on the <xref:EnvDTE._DTE> object, passing a string representing the object you wish to retrieve.  
  
## Obtaining Project Objects  
 The following are two code examples that show how an automation consumer obtains the project automation objects. For information about how to get the DTE object, see [How to: Get References to the DTE and DTE2 Objects](../Topic/How%20to:%20Get%20References%20to%20the%20DTE%20and%20DTE2%20Objects.md).  
  
```vb#  
Sub DoAutomation()  
    Dim MyProjects As Projects  
    MyProjects = DTE.GetObject("AcmeProject")  
End Sub  
```  
  
```cpp#  
void DoAutomation(void)  
{  
  CComQIPtr<Projects> pMyPkg; // Use an IDispatch-derived object type.  
    pMyPkg = pDTE->GetObject("AcmeProjects");   
  
   // The '=' performs a Query Interface.  
   // Assumes pDTE is already available as a global.  
   // Use pMyPkg to access your projects object's properties and methods.  
}  
  
```  
  
 At this point, you can use the standard project objects that are part of a specific VSPackage to move down the hierarchy model.  
  
 The following code example shows how to get a custom object that is a property of a custom project type.:  
  
```vb#  
Dim MyPrj As Project  
Dim MyPrjItem As ProjectItem  
Dim objMyObject as MyExtendedObject  
  
MyPrj = MyProjects.Item(1) 'use the Projects collection to get a project  
objMyObject = MyPrj.Object 'You call .Object to get to special Project  
                           'implementation  
objMyObject.MySpecialMethodOrProperty  
```  
  
 The following code lists the names of all of the properties in the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] environment **General** option on the **Tools** menu:  
  
```vb#  
dim objDTE  
dim objEnv  
set objDTE = CreateObject("VisualStudio.DTE")  
set objEnv = objDTE.Properties("Environment", "General")  
for each obj in ObjEnv  
MsgBox obj.Name  
Next  
  
```  
  
## See Also  
 <xref:EnvDTE.DTEClass.GetObject%2A>