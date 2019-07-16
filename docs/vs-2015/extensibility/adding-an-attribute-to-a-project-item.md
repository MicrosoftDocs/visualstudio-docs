---
title: "Adding an Attribute to a Project Item | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "attributes [Visual Studio], adding to a project item"
ms.assetid: 404a71d5-cce5-44e7-9eaf-d747c794fedb
caps.latest.revision: 5
ms.author: gregvanl
manager: jillfra
---
# Adding an Attribute to a Project Item
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The methods <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.GetItemAttribute%2A> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.SetItemAttribute%2A> get and set the value of the attributes of a project item. SetItemAttribute creates the attribute if it does not already exist, adding it to the project item metadata.  
  
## Adding an attribute to a project item  
  
#### To add an attribute to a project item  
  
- The following code uses the <xref:EnvDTE.DTE> automation object and the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.SetItemAttribute%2A> method to add an attribute to a project item. The project item ID is obtained from the project item name "program.cs". The attribute "MyAttribute" is added to this project item and given the value "MyValue".  
  
    ```  
    EnvDTE.DTE dte = (EnvDTE.DTE)Package.GetGlobalService(typeof(EnvDTE.DTE));  
    EnvDTE.Project project = dte.Solution.Projects.Item(1);  
  
    string uniqueName = project.UniqueName;  
    IVsSolution solution =     (IVsSolution)Package.GetGlobalService(typeof(SVsSolution));  
    IVsHierarchy hierarchy;  
    solution.GetProjectOfUniqueName(uniqueName, out hierarchy);  
    IVsBuildPropertyStorage buildPropertyStorage = hierarchy as IVsBuildPropertyStorage;  
    if (buildPropertyStorage != null)  
    {  
        uint itemId;  
        string fullPath =         (string)project.ProjectItems.Item("Program.cs").Properties.Item("FullPath").Value;  
        hierarchy.ParseCanonicalName(fullPath, out itemId);  
        buildPropertyStorage.SetItemAttribute(  
            itemId, "MyAttribute", "MyValue");  
    }  
  
    ```  
  
## See Also  
 [Persisting Data in the MSBuild Project File](../extensibility/internals/persisting-data-in-the-msbuild-project-file.md)
