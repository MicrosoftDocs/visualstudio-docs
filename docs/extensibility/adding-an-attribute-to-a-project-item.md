---
title: Adding an Attribute to a Project Item
description: Learn how to add an attribute to a project item in Visual Studio by using the Shell Interop methods GetItemAttribute and SetItemAttribute. 
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- attributes [Visual Studio], adding to a project item
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Add an attribute to a project item

The methods <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.GetItemAttribute%2A> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.SetItemAttribute%2A> get and set the value of the attributes of a project item. SetItemAttribute creates the attribute if it does not already exist, adding it to the project item metadata.

## Add an attribute to a project item

- The following code uses the <xref:EnvDTE.DTE> automation object and the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.SetItemAttribute%2A> method to add an attribute to a project item. The project item ID is obtained from the project item name "program.cs". The attribute "MyAttribute" is added to this project item and given the value "MyValue".

    ```csharp
    EnvDTE.DTE dte = (EnvDTE.DTE)Package.GetGlobalService(typeof(EnvDTE.DTE));
    EnvDTE.Project project = dte.Solution.Projects.Item(1);

    string uniqueName = project.UniqueName;
    IVsSolution solution = (IVsSolution)Package.GetGlobalService(typeof(SVsSolution));
    IVsHierarchy hierarchy;
    solution.GetProjectOfUniqueName(uniqueName, out hierarchy);
    IVsBuildPropertyStorage buildPropertyStorage = hierarchy as IVsBuildPropertyStorage;
    if (buildPropertyStorage != null)
    {
        uint itemId;
        string fullPath = (string)project.ProjectItems.Item("Program.cs").Properties.Item("FullPath").Value;
        hierarchy.ParseCanonicalName(fullPath, out itemId);
        buildPropertyStorage.SetItemAttribute(itemId, "MyAttribute", "MyValue");
    }

    ```

## Related content
- [Persist data in the MSBuild project file](../extensibility/internals/persisting-data-in-the-msbuild-project-file.md)
