---
title: "Custom Parameters | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "wizards, custom parameters"
  - "custom parameters"
ms.assetid: ba5c364b-66e6-47ea-9760-a0b70de8f0a0
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# Custom Parameters
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Custom parameters control the operation of a wizard after a wizard has started. A related .vsz file provides an array of user-defined parameters that are packaged by the integrated development environment (IDE) and passed to the wizard as an array of strings when the wizard is started. The wizard then parses the array of strings and uses the information to control the actual operation of the wizard. In this manner, a wizard can customize functionality depending on the contents of the .vsz file.  
  
 Context parameters, on the other hand, define the state of the project when the wizard is started. For more information, see [Context Parameters](../../extensibility/internals/context-parameters.md).  
  
 Following is an example of a .vsz file that has custom parameters:  
  
```  
VSWIZARD 8.0  
Wizard=VsWizard.VsWizard_Engine  
Param="WIZARD_NAME = Sample Wizard"  
Param="WIZARD_UI = FALSE"  
Param="RELATIVE_PATH = VSWizards\Classwiz\ATL"  
Param="PREPROCESS_FUNCTION = CanAddATLSupport"  
Param="PROJECT_TYPE = CSPROJ"  
```  
  
 The author of the .vsz file adds the values of the parameters. When a user selects **New Project** or **Add New Item** on the File menu or by right-clicking a project in **Solution Explorer**, the IDE collects these values into an array of strings. The IDE then calls the project's <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3.AddItem%2A> method with the <xref:Microsoft.VisualStudio.Shell.Interop.VSADDITEMOPERATION> flag set, and the project calls the <xref:EnvDTE.IVsExtensibility.RunWizardFile%2A> method that is responsible for running the wizard and returning the result.  
  
 The wizard is responsible for parsing the array of strings and acting on the strings appropriately. In this manner, by implementing custom parameters you can create one wizard that performs a variety of functions. In other words, one wizard could have three different .vsz files. Each file passes different sets of custom parameters to control the behavior of the wizard in various situations.  
  
 For more information, see [Wizard (.Vsz) File](../../extensibility/internals/wizard-dot-vsz-file.md).  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3>   
 [Context Parameters](../../extensibility/internals/context-parameters.md)   
 [Wizards](../../extensibility/internals/wizards.md)   
 [Wizard (.Vsz) File](../../extensibility/internals/wizard-dot-vsz-file.md)
