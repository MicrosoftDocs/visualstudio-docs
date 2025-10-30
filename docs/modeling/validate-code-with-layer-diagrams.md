---
title: Validate code with dependency diagrams
description: Validate your code with dependency diagrams in Visual Studio to find conflicts in dependencies and refactor or migrate code to a different design as needed.
ms.date: 09/28/2018
ms.topic: how-to
helpviewer_keywords:
- dependency diagrams, validating
- validation, dependency diagrams
- validation, code
- code exploration, validating
- architecture, validating
- Visual Studio Ultimate, validating code
- validation, architecture
- validation, dependencies
- MSBuild, tasks
- MSBuild, dependency diagrams
- MSBuild, validating code
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Validate code with dependency diagrams

## Why use dependency diagrams?

To make sure that code doesn't conflict with its design, validate your code with dependency diagrams in Visual Studio. This can help you:

- Find conflicts between dependencies in your code and dependencies on the dependency diagram.

- Find dependencies that might be affected by proposed changes.

   For example, you can edit the dependency diagram  to show potential architecture changes and then validate the code to see the affected dependencies.

- Refactor or migrate code to a different design.

   Find code or dependencies that require work when you move the code to a different architecture.

**Requirements**

- Visual Studio

  To create a dependency diagram for a .NET Core project, you must have Visual Studio 2019 version 16.2 or later.

- A solution that has a modeling project with a dependency diagram. This dependency diagram must be linked to artifacts in C# or Visual Basic projects that you want to validate. See [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md).

To see which editions of Visual Studio support this feature, see [Edition support for architecture and modeling tools](../modeling/analyze-and-model-your-architecture.md#VersionSupport).

You can validate code manually from an open dependency diagram in Visual Studio or from a command prompt. You can also validate code automatically when running local builds or Azure Pipelines builds.

> [!IMPORTANT]
> If you want to run layer validation using Team Foundation Server (TFS), you must also install the same version of Visual Studio on your build server.

## Live dependency validation

Dependency validation occurs in real time, and errors are shown immediately in the **Error List**.

* Live validation is supported for C# and Visual Basic.

* To enable full solution analysis when using live dependency validation, open the options settings from the gold bar that appears in the **Error List**.

  - You can permanently dismiss the gold bar if you are not interested in seeing all the architectural issues in your solution.
  - If you don't enable full solution analysis, the analysis is done only for the files being edited.

* When upgrading projects to enable live validation, a dialog shows the progress of the conversion.

* When updating a project for live dependency validation, the version of the NuGet package is upgraded to be the same for all projects, and is the highest version in use.

* Adding a new dependency validation project triggers a project update.

## See if an item supports validation

You can link layers to websites, Office documents, plain text files, and files in projects that are shared across multiple apps, but the validation process won't include them. Validation errors won't appear for references to projects or assemblies that are linked to separate layers when no dependencies appear between those layers. Such references are not considered dependencies unless the code uses those references.

1. On the dependency diagram, select one or more layers, right-click your selection, and then click **View Links**.

2. In **Layer Explorer**, look at the **Supports Validation** column. If the value is false, the item does not support validation.

## Include other .NET assemblies and projects for validation

When you drag items to the dependency diagram, references to the corresponding .NET assemblies or projects are added automatically to the **Layer References** folder in the modeling project. This folder contains references to the assemblies and projects that are analyzed during validation. You can include other .NET assemblies and projects for validation without manually dragging them to the dependency diagram.

1. In **Solution Explorer**, right-click the modeling project or the **Layer References** folder, and then click **Add Reference**.

2. In the **Add Reference** dialog box, select the assemblies or projects, and then click **OK**.

## Validate code manually

If you have an open dependency diagram  that is linked to solution items, you can run the **Validate** shortcut command from the diagram. You can also use the command prompt to run the **msbuild** command with the **/p:ValidateArchitecture** custom property set to **True**. For example, as you make changes in the code, perform layer validation regularly so that you can catch dependency conflicts early.

### Validate code from an open dependency diagram

1. Right-click the diagram surface, and then click **Validate Architecture**.

    > [!NOTE]
    > By default, the **Build Action** property on the dependency diagram (.layerdiagram) file is set to **Validate** so that the diagram is included in the validation process.

     The **Error List** window reports any errors that occur. For more information about validation errors, see [Troubleshoot layer validation issues](#troubleshoot-layer-validation-issues).

2. To view the source of each error, double-click the error in the **Error List** window.

    > [!NOTE]
    > Visual Studio might show a code map instead of the source of the error. This occurs when either the code has a dependency on an assembly that is not specified by the dependency diagram, or the code is missing a dependency that is specified by the dependency diagram. Review the code map or the code to determine whether the dependency should exist. For more information about code maps, see [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md).

3. To manage errors, see [Resolve layer validation errors](#resolve-layer-validation-errors).

### Validate code at the command prompt

1. Open the Visual Studio command prompt.

2. Choose one of the following:

   - To validate code against a specific modeling project in the solution, run MSBuild with the following custom property.

       ```
       msbuild <FilePath+ModelProjectFileName>.modelproj /p:ValidateArchitecture=true
       ```

       -or-

       Browse to the folder that contains the modeling project (.modelproj) file and the dependency diagram and then run MSBuild with the following custom property:

       ```
       msbuild /p:ValidateArchitecture=true
       ```

   - To validate code against all modeling projects in the solution, run MSBuild with the following custom property:

       ```
       msbuild <FilePath+SolutionName>.sln /p:ValidateArchitecture=true
       ```

       -or-

       Browse to the solution folder, which must contain a modeling project that contains a dependency diagram, and then run MSBuild with the following custom property:

       ```
       msbuild /p:ValidateArchitecture=true
       ```

     Any errors that occur will be listed. For more information about MSBuild, see [MSBuild](../msbuild/msbuild.md) and [MSBuild Task](../msbuild/msbuild-task.md).

   For more information about validation errors, see [Troubleshoot layer validation issues](#troubleshoot-layer-validation-issues).

### Manage validation errors

During the development process, you might want to suppress some of the reported conflicts during validation. For example, you might want to suppress errors that you are already addressing or that are not relevant to your particular scenario. When you suppress an error, it is a good practice to log a work item in Team Foundation.

> [!WARNING]
> You must already be connected to TFS Source Code Control (SCC) to create or link to a work item. If you try to open a connection to a different TFS SCC, Visual Studio closes the current solution automatically. Ensure that you are already connected to the appropriate SCC before attempting to create or link to a work item. In later releases of Visual Studio, the menu commands are not available if you are not connected to an SCC.

#### Create a work item for a validation error

- In the **Error List** window, right-click the error, point to **Create Work Item**, and then click the type of work item that you want to create.

Use these tasks to manage validation errors in the **Error List** window:

|**To**|**Follow these steps**|
|-|-|
|Suppress selected errors during validation|Right-click the one or multiple selected errors, point to **Manage Validation Errors**, and then click **Suppress Errors**.<br /><br /> The suppressed errors appear with strikethrough formatting. When you run validation the next time, these errors will not appear.<br /><br /> Suppressed errors are tracked in a .suppressions file for the corresponding dependency diagram  file.|
|Stop suppressing selected errors|Right-click the selected suppressed error or errors, point to **Manage Validation Errors**, and then click **Stop Suppressing Errors**.<br /><br /> The selected suppressed errors will appear when you run validation the next time.|
|Restore all suppressed errors in the **Error List** window|Right-click anywhere in the **Error List** window, point to **Manage Validation Errors**, and then click **Show All Suppressed Errors**.|
|Hide all suppressed errors from the **Error List** window|Right-click anywhere in the **Error List** window, point to **Manage Validation Errors**, and then click **Hide All Suppressed Errors**.|

## Validate code automatically

You can perform layer validation every time that you run a local build. If your team uses Azure DevOps, you can perform layer validation with gated check-ins, which you can specify by creating a custom MSBuild task, and use build reports to collect validation errors. To create gated check-in builds, see [TFVC gated check-in](/azure/devops/pipelines/build/triggers).

### To validate code automatically during a local build

Use a text editor to open the modeling project (.modelproj) file, and then include the following property:

```xml
<ValidateArchitecture>true</ValidateArchitecture>
```

\- or -

1. In **Solution Explorer**, right-click the modeling project that contains the dependency diagram or diagrams, and then click **Properties**.

2. In the **Properties** window, set the modeling project's **Validate Architecture** property to **True**.

    This includes the modeling project in the validation process.

3. In **Solution Explorer**, click the dependency diagram  (.layerdiagram) file that you want to use for validation.

4. In the **Properties** window, make sure that the diagram's **Build Action** property is set to **Validate**.

    This includes the dependency diagram  in the validation process.

To manage errors in the Error List window, see [Resolve layer validation errors](#resolve-layer-validation-errors).

## Troubleshoot layer validation issues

The following table describes layer validation issues and their resolution. These issues differ from errors that result from conflicts between the code and the design. For more information about these errors, see [Troubleshoot layer validation issues](#troubleshoot-layer-validation-issues).

|**Issue**|**Possible Cause**|**Resolution**|
|-|-|-|
|Validation errors do not occur as expected.|Validation does not work on dependency diagrams that are copied from other dependency diagrams in Solution Explorer and that are in the same modeling project. dependency diagrams that are copied in this way contain the same references as the original dependency diagram.|Add a new dependency diagram  to the modeling project.<br /><br /> Copy the elements from the source dependency diagram  to the new diagram.|

## Resolve layer validation errors

When you validate code against a dependency diagram, validation errors occur when the code conflicts with the design. For example, the following conditions might cause validation errors to occur:

- An artifact is assigned to the wrong layer. In this case, move the artifact.

- An artifact, such as a class, uses another class in a way that conflicts with your architecture. In this case, refactor the code to remove the dependency.

To resolve these errors, update the code until no more errors appear during validation. You can perform this task in an iterative manner.

The following section describes the syntax that is used in these errors, explains the meaning of these errors, and suggests what you can do to resolve or manage them.

|**Syntax**|**Description**|
|-|-|
|*ArtifactN*(*ArtifactTypeN*)|*ArtifactN* is an artifact that is associated with a layer on the dependency diagram.<br /><br /> *ArtifactTypeN* is the type of *ArtifactN*, such as a **Class** or **Method**, for example:<br /><br /> MySolution.MyProject.MyClass.MyMethod(Method)|
|*NamespaceNameN*|The name of a namespace.|
|*LayerNameN*|The name of a layer on the dependency diagram.|
|*DependencyType*|The type of dependency relationship between *Artifact1* and *Artifact2*. For example, *Artifact1* has a **Calls** relationship with *Artifact2*.|

| **Error Syntax** | **Error Description** |
|-|-|
| DV0001: **Invalid Dependency** | This issue is reported when a code element (namespace, type, member) mapped to a Layer references a code element mapped to another layer, but there is no dependency arrow between these layers in the dependency validation diagram containing this layers. This is a dependency constraint violation. |
| DV1001: **Invalid namespace name** | This issue is reported on a code element associated with a layer which "Allowed Namespace Names" property does not contain the namespace in which this code element is defined. This is a naming constraint violation. Note that the syntax of "Allowed Namespace Names" is to be a semi-colon list of namespaces in which code elements associated with are layer are permitted to be defined. |
| DV1002: **Dependency on unreferenceable namespace** | This issue is reported on a code element associated with a layer and referencing another code element defined in a namespace which is defined in the "Unreferenceable Namespace" property of the layer. This is a naming constraint violation. Note that the "Unreferenceable Namespaces" property is defined as a Semi-colon separated list of namespaces that should not be referenced in code elements associated with this layer. |
| DV1003: **Disallowed namespace name** | This issue is reported on a code element associated with a layer which "Disallowed Namespace Names" property contains the namespace in which this code element is defined. This is a naming constraint violation. Note that the "Disallowed namespace name" property is defined as a Semi-colon separated list of namespaces in which code elements associated with this Layer should not be defined. |
| DV2001: **Layer Diagram Presence** | This issue is reported on a project that does not include a dependency diagram file, but refers to the dependency validation analyzers. If Dependency Validation has not been used, you can remove "Microsoft.DependencyValidation.Analyzers" directly from Solution Explorer or suppress this warning. To add a dependency diagram see [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md). |
| DV2002: **Unmapped Types Base** | This issue is reported when a code element is not mapped to any layer. |
| DV3001: **Missing Link** | Layer '*LayerName*' links to '*Artifact*' which cannot be found. Are you missing an assembly reference? |
| DV9001: **Architectural analysis found internal errors** | Results might not be complete. For more information, see the detailed build event log or output window. |

## Related content

- [Live dependency validation in Visual Studio](https://devblogs.microsoft.com/devops/live-dependency-validation-in-visual-studio-2017/)
- [Validate your system during development](../modeling/validate-your-system-during-development.md)
- [Video: Validate your architecture dependencies in real time](/events/visual-studio-visual-studio-2017-launch/t123)
