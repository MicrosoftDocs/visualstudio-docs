---
title: Persisting the Property of a Project Item
description: Learn how to persist a property that you add to a project item by storing the property in the project file in your extended project type.
ms.date: 03/22/2018
ms.topic: how-to
helpviewer_keywords:
- properties, adding to a project item
- project items, adding properties
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Persist the property of a project item

You may want to persist a property you add to a project item, such as the author of a source file. You can do this by storing the property in the project file.

 The first step to persist a property in a project file is to obtain the hierarchy of the project as an <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> interface. You can obtain this interface either by using Automation or by using <xref:Microsoft.VisualStudio.Shell.Interop.IVsMonitorSelection>. Once you obtain the interface, you can use it to determine which project item is currently selected. Once you have the project item ID, you can use <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.SetItemAttribute%2A> to add the property.

 In the following procedures, you persist the *VsPkg.cs* property `Author` with the value `Tom` in the project file.

## To obtain the project hierarchy with the DTE object

1. Add the following code to your VSPackage:

    ```csharp
    EnvDTE.DTE dte = (EnvDTE.DTE)Package.GetGlobalService(typeof(EnvDTE.DTE));
    EnvDTE.Project project = dte.Solution.Projects.Item(1);

    string uniqueName = project.UniqueName;
    IVsSolution solution = (IVsSolution)Package.GetGlobalService(typeof(SVsSolution));
    IVsHierarchy hierarchy;
    solution.GetProjectOfUniqueName(uniqueName, out hierarchy);
    ```

## To persist the project item property with the DTE object

1. Add the following code to the code given in the method in the previous procedure:

    ```csharp
    IVsBuildPropertyStorage buildPropertyStorage =
        hierarchy as IVsBuildPropertyStorage;
    if (buildPropertyStorage != null)
    {
        uint itemId;
        string fullPath = (string)project.ProjectItems.Item(
            "VsPkg.cs").Properties.Item("FullPath").Value;
        hierarchy.ParseCanonicalName(fullPath, out itemId);
        buildPropertyStorage.SetItemAttribute(itemId, "Author", "Tom");
    }
    ```

## To obtain the project hierarchy using IVsMonitorSelection

1. Add the following code to your VSPackage:

    ```csharp
    IVsHierarchy hierarchy = null;
    IntPtr hierarchyPtr = IntPtr.Zero;
    IntPtr selectionContainer = IntPtr.Zero;
    uint itemid;

    // Retrieve shell interface in order to get current selection
    IVsMonitorSelection monitorSelection =     Package.GetGlobalService(typeof(SVsShellMonitorSelection)) as     IVsMonitorSelection;
    if (monitorSelection == null)
        throw new InvalidOperationException();

    try
    {
        // Get the current project hierarchy, project item, and selection container for the current selection
        // If the selection spans multiple hierarchies, hierarchyPtr is Zero
        IVsMultiItemSelect multiItemSelect = null;
        ErrorHandler.ThrowOnFailure(
            monitorSelection.GetCurrentSelection(
                out hierarchyPtr, out itemid,
                out multiItemSelect, out selectionContainer));

        // We only care if there is only one node selected in the tree
        if (!(itemid == VSConstants.VSITEMID_NIL ||
            hierarchyPtr == IntPtr.Zero ||
            multiItemSelect != null ||
            itemid == VSConstants.VSITEMID_SELECTION))
        {
            hierarchy = Marshal.GetObjectForIUnknown(hierarchyPtr)
                as IVsHierarchy;
        }
    }
    finally
    {
        if (hierarchyPtr != IntPtr.Zero)
            Marshal.Release(hierarchyPtr);
        if (selectionContainer != IntPtr.Zero)
            Marshal.Release(selectionContainer);
    }
    ```

## To persist the selected project item property, given the project hierarchy

1. Add the following code to the code given in the method in the previous procedure:

    ```csharp
    IVsBuildPropertyStorage buildPropertyStorage =
        hierarchy as IVsBuildPropertyStorage;
    if (buildPropertyStorage != null)
    {
        buildPropertyStorage.SetItemAttribute(itemId, "Author", "Tom");
    }
    ```

## To verify that the property is persisted

1. Start Visual Studio and then open or create a solution.

2. Select the project item VsPkg.cs in **Solution Explorer**.

3. Use a breakpoint or otherwise determine that your VSPackage is loaded and that SetItemAttribute runs.

   > [!NOTE]
   > You can autoload a VSPackage in the UI context <xref:Microsoft.VisualStudio.VSConstants.UICONTEXT.SolutionExists_guid>. For more information, see [Load VSPackages](../extensibility/loading-vspackages.md).

4. Close Visual Studio and then open the project file in Notepad. You should see the \<Author> tag with the value Tom, as follows:

   ```xml
   <Compile Include="VsPkg.cs">
       <Author>Tom</Author>
   </Compile>
   ```

## Related content

- [Custom tools](../extensibility/internals/custom-tools.md)
