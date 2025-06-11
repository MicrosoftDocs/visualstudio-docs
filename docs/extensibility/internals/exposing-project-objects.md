---
title: Exposing Project Objects
description: Learn how to expose objects for custom project types in Visual Studio by providing automation objects that allow access to the project using automation interfaces.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- project objects, exposing
- extensibility, project objects
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Expose project objects

Custom project types can provide automation objects in order to allow access to the project using automation interfaces. Every project type is expected to provide the standard <xref:EnvDTE.Project> automation object that is accessed from <xref:EnvDTE.Solution>, which contains a collection of all projects that are open in the IDE. Each item in the project is expected to be exposed by a <xref:EnvDTE.ProjectItem> object accessed with `Project.ProjectItems`. In addition to these standard automation objects, projects can choose to offer project-specific automation objects.

You can create custom root-level automation objects that you can access late-bound from the root DTE object using `DTE.<customObjectName>` or `DTE.GetObject("<customObjectName>")`. For example, Visual C++ creates a C++ project-specific project collection called *VCProjects* that you can access using `DTE.VCProjects` or `DTE.GetObject("VCProjects")`. You can also create a `Project.Object`, which is unique for the project type, a `Project.CodeModel`, which can be queried for its most-derived object, and a `ProjectItem`, which exposes `ProjectItem.Object` and a `ProjectItem.FileCodeModel`.

It is a common convention for projects to expose a custom, project-specific project collection. For example, Visual C++ creates a C++ specific project collection that you can then access using `DTE.VCProjects` or `DTE.GetObject("VCProjects")`. You can also create a `Project.Object`, which is unique for the project type, a `Project.CodeModel`, which can be queried for its most-derived object, a `ProjectItem`, which exposes `ProjectItem.Object`, and a `ProjectItem.FileCodeModel`.

## To contribute a VSPackage-specific object for a project

1. Add the appropriate keys to the *.pkgdef* file of your VSPackage.

     For example, here are the *.pkgdef* settings for the C++ language project:

    ```
    [$RootKey$\Packages\{F1C25864-3097-11D2-A5C5-00C04F7968B4}\Automation]
    "VCProjects"=""
    [$RootKey$\Packages\{F1C25864-3097-11D2-A5C5-00C04F7968B4}\AutomationEvents]
    "VCProjectEngineEventsObject"=""
    ```

2. Implement the code in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetAutomationObject%2A> method, as in the following example.

    ```cpp
    STDMETHODIMP CVsPackage::GetAutomationObject(
    /* [in]  */ LPCOLESTR       pszPropName,
    /* [out] */ IDispatch **    ppIDispatch)
    {
    ExpectedPtrRet(pszPropName);
    ExpectedPtrRet(ppIDispatch);
    *ppIDispatch = NULL;

        if (m_fZombie)
            return E_UNEXPECTED;

        if (_wcsicmp(pszPropName, g_wszAutomationProjects) == 0)
        {
            return GetAutomationProjects(ppIDispatch);
        }
        else if (_wcsicmp(pszPropName, g_wszAutomationProjectsEvents) == 0)
        {
            return CAutomationEvents::GetAutomationEvents(ppIDispatch);
        }
        else if (_wcsicmp(pszPropName, g_wszAutomationProjectItemsEvents) == 0)
        {
            return CAutomationEvents::GetAutomationEvents(ppIDispatch);
        }
        return E_INVALIDARG;
    }
    ```

     In the code, `g_wszAutomationProjects` is the name of your project collection. The `GetAutomationProjects` method creates an object that implements the `Projects` interface and returns an `IDispatch` pointer to the calling object, as shown in the following code example.

    ```cpp
    HRESULT CVsPackage::GetAutomationProjects(/* [out] */ IDispatch ** ppIDispatch)
    {
        ExpectedPtrRet(ppIDispatch);
        *ppIDispatch = NULL;

        if (!m_srpAutomationProjects)
        {
            HRESULT hr = CACProjects::CreateInstance(&m_srpAutomationProjects);
            IfFailRet(hr);
            ExpectedExprRet(m_srpAutomationProjects != NULL);
        }
        return m_srpAutomationProjects.CopyTo(ppIDispatch);
    }
    ```

     Choose a unique name for your automation object. Name conflicts are unpredictable, and collisions cause a conflicting object name to be arbitrarily thrown out if multiple project types use the same name. You should include your corporate name or some unique aspect of its product name in the name of the automation object.

     The custom `Projects` collection object is a convenience entry point for the remaining part of your project automation model. Your project object is also accessible from the <xref:EnvDTE.Solution> project collection. After you have created the appropriate code and registry entries that provide consumers with `Projects` collection objects, your implementation must provide remaining standard objects for the project model. For more information, see [Project modeling](../../extensibility/internals/project-modeling.md).

## Related content

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetAutomationObject%2A>
