---
title: "Using the Automation Model | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "automation [Visual Studio SDK], automation model"
ms.assetid: 0c7f7889-fbfb-4b19-804f-b742138baecd
caps.latest.revision: 16
ms.author: gregvanl
manager: jillfra
---
# Using the Automation Model
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

After you have connected your VSPackage to automation, you can obtain the properties and methods by calling the <xref:EnvDTE.DTEClass.GetObject%2A> method on the <xref:EnvDTE._DTE> object, passing a string representing the object you wish to retrieve.  
  
## Obtaining Project Objects  
 The following are two code examples that show how an automation consumer obtains the project automation objects. For information about how to get the DTE object, see [How to: Get References to the DTE and DTE2 Objects](https://msdn.microsoft.com/library/c92e3c8e-82e6-4a67-85da-e43c50ffd8e4).  
  
```vb  
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
  
```vb  
Dim MyPrj As Project  
Dim MyPrjItem As ProjectItem  
Dim objMyObject as MyExtendedObject  
  
MyPrj = MyProjects.Item(1) 'use the Projects collection to get a project  
objMyObject = MyPrj.Object 'You call .Object to get to special Project  
                           'implementation  
objMyObject.MySpecialMethodOrProperty  
```  
  
 The following code lists the names of all of the properties in the [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] environment **General** option on the **Tools** menu:  
  
```vb  
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
