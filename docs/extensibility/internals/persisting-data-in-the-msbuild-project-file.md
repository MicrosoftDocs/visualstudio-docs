---
title: Persisting Data in the MSBuild Project File
description: Learn how to persist data in a project file and use IPersistXMLFragment to maintain the data in the project file across project subtype aggregation levels.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- project files, persisting data in
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Persisting Data in the MSBuild Project File

A project subtype may need to persist subtype-specific data into the project file for later use. A project subtype uses project file persistence to meet the following requirements:

1. Persist data used as part of building the project. (For more information on the Microsoft Build Engine, see [MSBuild](../../msbuild/msbuild.md).) Build-related information can either:

    1. Configuration-independent data. That is, data stored in MSBuild elements with blank or missing conditions.

    2. Configuration-dependent data. That is, data stored in MSBuild elements that are conditioned for a particular project configuration. For example:

        ```
        <PropertyGroup Condition=" '$(Configuration)' == 'Debug' ">
        ```

2. Persist data that is not relevant to build. This data can be expressed in free-form XML that is not validated against an XML schema.

    1. Configuration-independent data.

    2. Configuration-dependent data.

## Persisting Build-Related Information
 Persistence of data useful for building a project is handled through MSBuild. The MSBuild system maintains a master table of build-related information. Project subtypes are responsible for accessing this data to get and set property values. Project subtypes can also augment the build-related data table by adding additional properties to be persisted and by removing properties so they are not persisted.

 To modify the MSBuild data, a project subtype is responsible for retrieving the MSBuild property object from the base project system through <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage>. <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage> is an interface implemented on the core project system and the aggregating project subtype queries for it by running `QueryInterface`.

 The following procedure outlines the steps for removing a property using <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage>.

#### To remove a property from an MSBuild project file

1. Call `QueryInterface` on <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage> of the project subtype.

2. Call <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.RemoveProperty%2A> with `pszPropName` set to the property you want to remove.

### Persisting Non-Build Related Information
 Persistence of data in project files that does not matter to build is handled through <xref:Microsoft.VisualStudio.Shell.Interop.IPersistXMLFragment>.

 You can implement <xref:Microsoft.VisualStudio.Shell.Interop.IPersistXMLFragment> on the main `project subtype aggregator` object, the `project subtype project configuration` object, or both.

 The following points outline the main concepts regarding the persistence of non-build related information.

- The base project calls on the main project subtype (that is, the outermost project subtype) aggregator object to load and save configuration independent data, and it calls on the project subtype project configuration objects to load or save configuration dependent data.

- The base project calls the methods of <xref:Microsoft.VisualStudio.Shell.Interop.IPersistXMLFragment> multiple times for each level of project subtype aggregation, and passes the GUID for each level.

- The base project passes or receives an XML fragment that is dedicated to a particular project subtype and uses this mechanism as a way of persisting state between the aggregation levels.

- The base project calls the outermost project subtype's <xref:Microsoft.VisualStudio.Shell.Interop.IPersistXMLFragment>implementation passing in a GUID. If the GUID belongs to the outermost project subtype, it handles the call itself; otherwise it delegates the call to an inner project subtype, and so on, until the project subtype that the GUID corresponds to is found.

- A project subtype can also modify the XML fragment before or after it delegates the call to an inner project subtype. The following example shows an excerpt from a project file, where a name of a file that contains properties specific to a project subtype, is passed to that project subtype.

    ```
    <ProjectExtensions>
        <VisualStudio>
          <FlavorProperties GUID="{<FlavorGUID>}">
            <FlavorProject TestFileFolder="TestFile" />
          </FlavorProperties>
        </VisualStudio>
      </ProjectExtensions>
    ```

## Related content
- [Project Subtypes](../../extensibility/internals/project-subtypes.md)
