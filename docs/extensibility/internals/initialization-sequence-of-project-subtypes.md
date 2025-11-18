---
title: Initialization Sequence of Project Subtypes
description: Learn about the initialization sequence in the Visual Studio environment for a project system aggregated by multiple project subtypes.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- project subtypes, initialization sequence
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Initialization Sequence of Project Subtypes

The environment constructs a project by calling the base project factory implementation of <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFactory.CreateProject%2A>. The construction of a project subtype starts when the environment determines that the project type GUID list for a project file's extension is not empty. The project file extension and project GUID specify whether the project is a Visual Basic or Visual C# project type. For example, the .vbproj extension and {F184B08F-C81C-45F6-A57F-5ABD9991F28F} identify a Visual Basic project.

## Environment's Initialization of Project Subtypes
 The following procedure details the initialization sequence for a project system aggregated by multiple project subtypes.

1. The environment calls the base project's <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFactory.CreateProject%2A>, and while the project parses its project file it discovers that the aggregate project type GUIDs list is not `null`. The project discontinues directly creating its project.

2. The project calls `QueryService` on <xref:Microsoft.VisualStudio.Shell.Interop.SVsCreateAggregateProject> service to create a project subtype using the environment's implementation of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsCreateAggregateProject.CreateAggregateProject%2A> method. Within this method the environment makes recursive function calls to your implementations of <xref:Microsoft.VisualStudio.Shell.Interop.IVsAggregatableProjectFactory.PreCreateForOuter%2A>, <xref:Microsoft.VisualStudio.Shell.Interop.IVsAggregatableProject.SetInnerProject%2A> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsAggregatableProject.InitializeForOuter%2A> methods while it is walking the list of project type GUIDs, starting with the outermost project subtype.

     The following details the initialization steps.

    1. The environment's implementation of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsCreateAggregateProject.CreateAggregateProject%2A> method calls the `HrCreateInnerProj` method with the following function declaration:

         \<CodeContentPlaceHolder>0</CodeContentPlaceHolder>

         When this function is called for the first time, that is, for the outermost project subtype, the parameters `pOuter` and `pOwner` are passed in as `null` and the function sets the outermost project subtype `IUnknown` to `pOuter`.

    2. Next the environment calls `HrCreateInnerProj` function with the second project type GUID in the list. This GUID corresponds to the second inner project subtype stepping in toward the base project in the aggregation sequence.

    3. The `pOuter` is now pointing to the `IUnknown` of the outermost project subtype, and `HrCreateInnerProj` calls your implementation of <xref:Microsoft.VisualStudio.Shell.Interop.IVsAggregatableProjectFactory.PreCreateForOuter%2A> followed by a call to your implementation of <xref:Microsoft.VisualStudio.Shell.Interop.IVsAggregatableProject.SetInnerProject%2A>. In <xref:Microsoft.VisualStudio.Shell.Interop.IVsAggregatableProjectFactory.PreCreateForOuter%2A> method you pass in the controlling `IUnknown` of the outermost project subtype, `pOuter`. The owned project (inner project subtype) needs to create its aggregate project object here. In the <xref:Microsoft.VisualStudio.Shell.Interop.IVsAggregatableProject.SetInnerProject%2A> method implementation you pass in a pointer to the `IUnknown` of the inner project that is being aggregated. These two methods create the aggregation object, and your implementations need to follow COM aggregation rules to ensure that a project subtype does not end up holding a reference count to itself.

    4. `HrCreateInnerProj` calls your implementation of <xref:Microsoft.VisualStudio.Shell.Interop.IVsAggregatableProjectFactory.PreCreateForOuter%2A>. In this method, the project subtype does its initialization work. You can, for example, register solution events in <xref:Microsoft.VisualStudio.Shell.Interop.IVsAggregatableProject.InitializeForOuter%2A>.

    5. `HrCreateInnerProj` is called recursively until the last GUID (the base project) in the list is reached. For each of these calls, the steps, c through d, are repeated. `pOuter` points to the outermost project subtype `IUnknown` for each level of aggregation.

## Example

The following example details the programmatic process in an approximate representation of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsCreateAggregateProject.CreateAggregateProject%2A> method as it is implemented by the environment. The code is just an example; it is not intended to be compiled, and all error checking was removed for clarity.

```cpp
HRESULT CreateAggregateProject
(
    LPCOLESTR lpstrGuids,
    LPCOLESTR pszFilename,
    LPCOLESTR pszLocation,
    LPCOLESTR pszName,
    VSCREATEPROJFLAGS grfCreateFlags,
    REFIID iidProject,
    void **ppvProject)
{
    HRESULT hr = NOERROR;
    CComPtr<IUnknown> srpunkProj;
    CComPtr<IVsAggregatableProject> srpAggProject;
    CComBSTR bstrGuids = lpstrGuids;
    BOOL fCanceled = FALSE;
    *ppvProject = NULL;

    HrCreateInnerProj(
         bstrGuids, NULL, NULL, pszFilename, pszLocation,
         pszName, grfCreateFlags, &srpunkProj, &fCanceled);
    srpunkProj->QueryInterface(
        IID_IVsAggregatableProject, (void **)&srpAggProject));
    srpAggProject->OnAggregationComplete();
    srpunkProj->QueryInterface(iidProject, ppvProject);
}

HRESULT HrCreateInnerProj
(
    WCHAR *pwszGuids,
    IUnknown *pOuter,
    IVsAggregatableProject *pOwner,
    LPCOLESTR pszFilename,
    LPCOLESTR pszLocation,
    LPCOLESTR pszName,
    VSCREATEPROJFLAGS grfCreateFlags,
    IUnknown **ppInner,
    BOOL *pfCanceled
)
{
    HRESULT hr = NOERROR;
    CComPtr<IUnknown> srpInner;
    CComPtr<IVsAggregatableProject> srpAggInner;
    CComPtr<IVsProjectFactory> srpProjectFactory;
    CComPtr<IVsAggregatableProjectFactory> srpAggPF;
    GUID guid = GUID_NULL;
    WCHAR *pwszNextGuids = wcschr(pwszGuids, L';');
    WCHAR wszText[_MAX_PATH+150] = L"";

    if (pwszNextGuids)
    {
        *pwszNextGuids++ = 0;
    }

    CLSIDFromString(pwszGuids, &guid);
    GetProjectTypeMgr()->HrGetProjectFactoryOfGuid(
        guid, &srpProjectFactory);
    srpProjectFactory->QueryInterface(
        IID_IVsAggregatableProjectFactory,
        (void **)&srpAggPF);
    srpAggPF->PreCreateForOuter(pOuter, &srpInner);
    srpInner->QueryInterface(
        IID_IVsAggregatableProject, (void **)&srpAggInner);

    if (pOwner)
    {
        IfFailGo(pOwner->SetInnerProject(srpInner));
    }

    if (pwszNextGuids)
    {
        CComPtr<IUnknown> srpNextInner;
        HrCreateInnerProj(
            pwszNextGuids, pOuter ? pOuter : srpInner,
            srpAggInner, pszFilename, pszLocation, pszName,
            grfCreateFlags, &srpNextInner, pfCanceled);
    }

    return srpAggInner->InitializeForOuter(
        pszFilename, pszLocation, pszName, grfCreateFlags,
        IID_IUnknown, (void **)ppInner, pfCanceled);
}
```

## Related content

- <xref:Microsoft.VisualStudio.Shell.Flavor>
- [Project Subtypes](../../extensibility/internals/project-subtypes.md)
