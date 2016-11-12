---
title: "Context Parameters | Microsoft Docs"
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
  - "wizards, context parameters"
  - "context parameters"
ms.assetid: 1a062dcb-8a8f-40dd-bea9-3d10f9448966
caps.latest.revision: 13
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
# Context Parameters
In the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] integrated development environment (IDE), you can add wizards to the **New Project**, **Add New Item**, or **Add Sub Project** dialog boxes. The added wizards are available on the **File** menu or by right-clicking a project in **Solution Explorer**. The IDE passes context parameters to the implementation of the wizard. The context parameters define the state of the project when the IDE calls the wizard.  
  
 The IDE starts wizards by setting the <xref:Microsoft.VisualStudio.Shell.Interop.VSADDITEMOPERATION> flag in the IDE's call to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3.AddItem%2A> method for the project. When set, the project must cause the `IVsExtensibility::RunWizardFile` method to be executed by using the registered wizard name or GUID and other context parameters that the IDE passes to it.  
  
## Context Parameters for New Project  
  
|Parameter|Description|  
|---------------|-----------------|  
|`WizardType`|Registered wizard type (<xref:EnvDTE.Constants.vsWizardNewProject>) or the GUID that indicates the type of wizard. In the [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)] implementation, the GUID for the wizard is {0F90E1D0-4999-11D1-B6D1-00A0C90F2744}.|  
|`ProjectName`|A string that is the unique [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] project name.|  
|`LocalDirectory`|Local location of working project files.|  
|`InstallationDirectory`|Directory path of the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] is installation.|  
|`FExclusive`|Boolean flag which indicates that the project should close open solutions.|  
|`SolutionName`|Name of the solution file without the directory portion or the .sln extension. The .suo file name is also created by using `SolutionName`. When this argument is not an empty string, the wizard uses <xref:EnvDTE._Solution.Create%2A> before adding the project with <xref:EnvDTE._Solution.AddFromTemplate%2A>. If this name is an empty string, use <xref:EnvDTE._Solution.AddFromTemplate%2A> without calling <xref:EnvDTE._Solution.Create%2A>.|  
|`Silent`|Boolean that indicates whether the wizard should run silently as if **Finish** were clicked (`TRUE`).|  
  
## Context Parameters for Add New Item  
  
|Parameter|Description|  
|---------------|-----------------|  
|`WizardType`|Registered wizard type (<xref:EnvDTE.Constants.vsWizardAddItem>) or the GUID that indicates the type of wizard. In the [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)] implementation, the GUID for the wizard is {0F90E1D1-4999-11D1-B6D1-00A0C90F2744}.|  
|`ProjectName`|A string that is the unique [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] project name.|  
|`ProjectItems`|Local location that contains working project files.|  
|`ItemName`|Name of the item that is to be added. This name is either the default file name or the file name that the user types from the **Add Items** dialog box. The name is based on the flags that are set in the .vsdir file. The name can be a null value.|  
|`InstallationDirectory`|Directory path of the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] is installation.|  
|`Silent`|Boolean that indicates whether the wizard should run silently as if **Finish** were clicked (`TRUE`).|  
  
## Context Parameters for Add Sub Project  
  
|Parameter|Description|  
|---------------|-----------------|  
|`WizardType`|Registered wizard type (<xref:EnvDTE.Constants.vsWizardAddSubProject>) or the GUID that indicates the type of wizard. In the [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)] implementation, the GUID for the wizard is {0F90E1D2-4999-11D1-B6D1-00A0C90F2744}.|  
|`ProjectName`|A string that is the unique [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] project name.|  
|`ProjectItems`|Pointer to the `ProjectItems` collection on which the wizard operates. This pointer is passed to the wizard based on the project hierarchy selection. A user typically selects a folder in which to put the item and then calls the project's **Add Item** dialog box.|  
|`LocalDirectory`|Local location of working project files.|  
|`ItemName`|Name of the item that is to be added. This name is either the default file name or the file name that the user types from the **Add Items** dialog box. The name is based on the flags that are set in the .vsdir file. The name can be a null value.|  
|`InstallationDirectory`|Directory path of the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] is installation.|  
|`Silent`|Boolean that indicates whether the wizard should run silently as if **Finish** were clicked (`TRUE`).|  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject2>   
 [Custom Parameters](../../extensibility/internals/custom-parameters.md)   
 [Wizards](../../extensibility/internals/wizards.md)   
 [Wizard (.Vsz) File](../../extensibility/internals/wizard-dot-vsz-file.md)   
 [Context Parameters for Launching Wizards](../Topic/Context%20Parameters%20for%20Launching%20Wizards.md)