---
title: Verifying Subtypes of a Project at Run Time | Microsoft Docs
description: Learn how to have your VSPackage verify the presence of a specified custom project subtype that it depends on.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- project subtypes
- check subtypes
ms.assetid: b87780ec-36a3-4e9a-9ee2-7abdc26db739
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Verify subtypes of a project at run time
A VSPackage that depends on a custom project subtype should include logic to look for that subtype so that it can fail gracefully if the subtype is not present. The following procedure shows how to verify the presence of a specified subtype.

### To verify the presence of a subtype

1. Get the project hierarchy from the project and solution objects as a <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> object by adding the following code to your VSPackage.

    ```csharp
    EnvDTE.DTE dte;
    dte = (EnvDTE.DTE)Package.GetGlobalService(typeof(EnvDTE.DTE));

    EnvDTE.Project project;
    project = dte.Solution.Projects.Item(1);

    IVsSolution solution;
    solution = (IVsSolution)Package.GetGlobalService(typeof(SVsSolution));

    IVsHierarchy hierarchy;
    hierarchy = solution.GetProjectOfUniqueName(project.UniqueName);

    ```

2. Cast the hierarchy to the <xref:Microsoft.VisualStudio.Shell.Flavor.IVsAggregatableProjectCorrected> interface.

    ```csharp
    IVsAggregatableProjectCorrected AP;
    AP = hierarchy as IVsAggregatableProjectCorrected;

    ```

3. Get the list of project type GUIDs by invoking the <xref:Microsoft.VisualStudio.Shell.Flavor.IVsAggregatableProjectCorrected.GetAggregateProjectTypeGuids%2A>.

    ```csharp
    string projTypeGuids = AP.GetAggregateProjectTypeGuids().ToUpper();

    ```

4. Check the list for the GUID of the specified subtype.

    ```csharp
    // Replace the string "MyGUID" with the GUID of the subtype.
    string guidMySubtype = "MyGUID";
    if (projTypeGuids.IndexOf(guidMySubtype) > 0)
    {
        // The specified subtype is present.
    }
    ```

## See also
- [Project subtypes](../extensibility/internals/project-subtypes.md)
- [Project subtypes design](../extensibility/internals/project-subtypes-design.md)
- [Properties and methods extended by project subtypes](../extensibility/internals/properties-and-methods-extended-by-project-subtypes.md)
