---
title: "Validate code with layer diagrams | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "layer diagrams, validating"
  - "validation, layer diagrams"
  - "validation, code"
  - "code exploration, validating"
  - "architecture, validating"
  - "Visual Studio Ultimate, validating code"
  - "validation, architecture"
  - "validation, dependencies"
  - "MSBuild, tasks"
  - "MSBuild, layer diagrams"
  - "MSBuild, validating code"
ms.assetid: 70cbe55d-4b33-4355-b0a7-88c770a6f75c
caps.latest.revision: 84
author: jillre
ms.author: jillfra
manager: jillfra
---
# Validate code with layer diagrams
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To make sure that code doesn't conflict with its design, validate your code with layer diagrams in Visual Studio. This can help you:

- Find conflicts between dependencies in your code and dependencies on the layer diagram.

- Find dependencies that might be affected by proposed changes.

   For example, you can edit the layer diagram to show potential architecture changes and then validate the code to see the affected dependencies.

- Refactor or migrate code to a different design.

   Find code or dependencies that require work when you move the code to a different architecture.

  **Requirements**

- Visual Studio

- Visual Studio on your Team Foundation Build server to validate code automatically with Team Foundation Build

- A solution that has a modeling project with a layer diagram. This layer diagram must be linked to artifacts in Visual C# .NET or Visual Basic .NET projects that you want to validate. See [Create layer diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md).

  To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

  You can validate code manually from an open layer diagram in Visual Studio or from a command prompt. You can also validate code automatically when running local builds or Team Foundation Build. See [Channel 9 Video: Design and validate your architecture using layer diagrams](https://go.microsoft.com/fwlink/?LinkID=252073).

> [!IMPORTANT]
> If you want to run layer validation with Team Foundation Build, you must also install the same version of Visual Studio on your build server.

- [See if an item supports validation](#SupportsValidation)

- [Include other .NET assemblies and projects for validation](#IncludeReferences)

- [Validate code manually](#ValidateManually)

- [Validate code automatically](#ValidateAuto)

- [Troubleshoot layer validation issues](#TroubleshootingValidation)

- [Understand and resolve layer validation errors](#UnderstandingValidationErrors)

## <a name="SupportsValidation"></a> See if an item supports validation
 You can link layers to Web sites, Office documents, plain text files, and files in projects that are shared across multiple apps, but the validation process won't include them. Validation errors won't appear for references to projects or assemblies that are linked to separate layers when no dependencies appear between those layers. Such references are not considered dependencies unless the code uses those references.

1. On the layer diagram, select one or more layers, right-click your selection, and then click **View Links**.

2. In **Layer Explorer**, look at the **Supports Validation** column. If the value is false, the item does not support validation.

## <a name="IncludeReferences"></a> Include other .NET assemblies and projects for validation
 When you drag items to the layer diagram, references to the corresponding .NET assemblies or projects are added automatically to the **Layer References** folder in the modeling project. This folder contains references to the assemblies and projects that are analyzed during validation. You can include other .NET assemblies and projects for validation without manually dragging them to the layer diagram.

1. In **Solution Explorer**, right-click the modeling project or the **Layer References** folder, and then click **Add Reference**.

2. In the **Add Reference** dialog box, select the assemblies or projects, and then click **OK**.

## <a name="ValidateManually"></a> Validate code manually
 If you have an open layer diagram that is linked to solution items, you can run the **Validate** shortcut command from the diagram. You can also use the command prompt to run the **msbuild** command with the **/p:ValidateArchitecture** custom property set to **True**. For example, as you make changes in the code, perform layer validation regularly so that you can catch dependency conflicts early.

#### To validate code from an open layer diagram

1. Right-click the diagram surface, and then click **Validate Architecture**.

    > [!NOTE]
    > By default, the **Build Action** property on the layer diagram (.layerdiagram) file is set to **Validate** so that the diagram is included in the validation process.

     The **Error List** window reports any errors that occur. For more information about validation errors, see [Understand and resolve layer validation errors](#UnderstandingValidationErrors).

2. To view the source of each error, double-click the error in the **Error List** window.

    > [!NOTE]
    > [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] might show a code map instead of the source of the error. This occurs when either the code has a dependency on an assembly that is not specified by the layer diagram, or the code is missing a dependency that is specified by the layer diagram. Review the code map or the code to determine whether the dependency should exist. For more information about code maps, see [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md).

3. To manage errors, see [Manage validation errors](#ManageErrors).

#### To validate code at the command prompt

1. Open the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] command prompt.

2. Choose one of the following:

   - To validate code against a specific modeling project in the solution, run [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] with the following custom property.

     ```
     msbuild <FilePath+ModelProjectFileName>.modelproj /p:ValidateArchitecture=true
     ```

     - or -

       Browse to the folder that contains the modeling project (.modelproj) file and the layer diagram and then run [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] with the following custom property:

     ```
     msbuild /p:ValidateArchitecture=true
     ```

   - To validate code against all modeling projects in the solution, run [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] with the following custom property:

     ```
     msbuild <FilePath+SolutionName>.sln /p:ValidateArchitecture=true
     ```

     - or -

       Browse to the solution folder, which must contain a modeling project that contains a layer diagram, and then run [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] with the following custom property:

     ```
     msbuild /p:ValidateArchitecture=true
     ```

     Any errors that occur will be listed. For more information about [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)], see [MSBuild](../msbuild/msbuild.md) and [MSBuild Task](../msbuild/msbuild-task.md).

   For more information about validation errors, see [Understand and resolve layer validation errors](#UnderstandingValidationErrors).

### <a name="ManageErrors"></a> Manage validation errors
 During the development process, you might want to suppress some of the reported conflicts during validation. For example, you might want to suppress errors that you are already addressing or that are not relevant to your particular scenario. When you suppress an error, it is a good practice to log a work item in [!INCLUDE[esprfound](../includes/esprfound-md.md)].

> [!WARNING]
> You must already be connected to TFS Source Code Control (SCC) to create or link to a work item. If you try to open a connection to a different TFS SCC, Visual Studio closes the current solution automatically. Ensure that you are already connected to the appropriate SCC before attempting to create or link to a work item. In later releases of Visual Studio, the menu commands are not available if you are not connected to an SCC.

##### To create a work item for a validation error

- In the **Error List** window, right-click the error, point to **Create Work Item**, and then click the type of work item that you want to create.

  Use these tasks to manage validation errors in the **Error List** window:

|**To**|**Follow these steps**|
|------------|----------------------------|
|Suppress selected errors during validation|Right-click the one or multiple selected errors, point to **Manage Validation Errors**, and then click **Suppress Errors**.<br /><br /> The suppressed errors appear with strikethrough formatting. When you run validation the next time, these errors will not appear.<br /><br /> Suppressed errors are tracked in a .suppressions file for the corresponding layer diagram file.|
|Stop suppressing selected errors|Right-click the selected suppressed error or errors, point to **Manage Validation Errors**, and then click **Stop Suppressing Errors**.<br /><br /> The selected suppressed errors will appear when you run validation the next time.|
|Restore all suppressed errors in the **Error List** window|Right-click anywhere in the **Error List** window, point to **Manage Validation Errors**, and then click **Show All Suppressed Errors**.|
|Hide all suppressed errors from the **Error List** window|Right-click anywhere in the **Error List** window, point to **Manage Validation Errors**, and then click **Hide All Suppressed Errors**.|

## <a name="ValidateAuto"></a> Validate code automatically
 You can perform layer validation every time that you run a local build. If your team uses Team Foundation Build, you can perform layer validation with gated check-ins, which you can specify by creating a custom MSBuild task, and use build reports to collect validation errors. To create gated check-in builds, see [Use a gated check-in build process to validate changes](https://msdn.microsoft.com/library/9cfc8b9c-1023-40fd-8ab5-1b1bd9c172ec).

#### To validate code automatically during a local build

- Use a text editor to open the modeling project (.modelproj) file, and then include the following property:

```
<ValidateArchitecture>true</ValidateArchitecture>
```

 \- or -

1. In **Solution Explorer**, right-click the modeling project that contains the layer diagram or diagrams, and then click **Properties**.

2. In the **Properties** window, set the modeling project's **Validate Architecture** property to **True**.

    This includes the modeling project in the validation process.

3. In **Solution Explorer**, click the layer diagram (.layerdiagram) file that you want to use for validation.

4. In the **Properties** window, make sure that the diagram's **Build Action** property is set to **Validate**.

    This includes the layer diagram in the validation process.

   To manage errors in the Error List window, see [Manage Validation Errors](#ManageErrors).

#### To validate code automatically during a Team Foundation Build

1. In **Team Explorer**, double-click the build definition, and then click **Process**.

2. Under **Build process parameters**, expand **Compilation**, and type the following in the **MSBuild Arguments** parameter:

    `/p:ValidateArchitecture=true`

   For more information about validation errors, see [Understand and resolve layer validation errors](#UnderstandingValidationErrors). For more information about [!INCLUDE[esprbuild](../includes/esprbuild-md.md)], see:

- [Build the application](/azure/devops/pipelines/index)

- [Use the Default Template for your build process](https://msdn.microsoft.com/library/43930b12-c21b-4599-a980-2995e3d16e31)

- [Modify a Legacy Build that is Based on UpgradeTemplate.xaml](https://msdn.microsoft.com/library/ee1a8259-1dd1-4a10-9563-66c5446ef41c)

- [Customize your build process template](https://msdn.microsoft.com/library/b94c58f2-ae6f-4245-bedb-82cd114f6039)

- [Monitor Progress of a Running Build](https://msdn.microsoft.com/library/e51e3bad-2d1d-4b7b-bfcc-c43439c6c8ef)

## <a name="TroubleshootingValidation"></a> Troubleshoot layer validation issues
 The following table describes layer validation issues and their resolution. These issues differ from errors that result from conflicts between the code and the design. For more information about these errors, see [Understand and resolve layer validation errors](#UnderstandingValidationErrors).

|**Issue**|**Possible Cause**|**Resolution**|
|---------------|------------------------|--------------------|
|Validation errors do not occur as expected.|Validation does not work on layer diagrams that are copied from other layer diagrams in Solution Explorer and that are in the same modeling project. Layer diagrams that are copied in this way contain the same references as the original layer diagram.|Add a new layer diagram to the modeling project.<br /><br /> Copy the elements from the source layer diagram to the new diagram.|

## <a name="UnderstandingValidationErrors"></a> Understanding and Resolving Layer Validation Errors
 When you validate code against a layer diagram, validation errors occur when the code conflicts with the design. For example, the following conditions might cause validation errors to occur:

- An artifact is assigned to the wrong layer. In this case, move the artifact.

- An artifact, such as a class, uses another class in a way that conflicts with your architecture. In this case, refactor the code to remove the dependency.

  To resolve these errors, update the code until no more errors appear during validation. You can perform this task in an iterative manner.

  The following section describes the syntax that is used in these errors, explains the meaning of these errors, and suggests what you can do to resolve or manage them.

|**Syntax**|**Description**|
|----------------|---------------------|
|*ArtifactN*(*ArtifactTypeN*)|*ArtifactN* is an artifact that is associated with a layer on the layer diagram.<br /><br /> *ArtifactTypeN* is the type of *ArtifactN*, such as a **Class** or **Method**, for example:<br /><br /> MySolution.MyProject.MyClass.MyMethod(Method)|
|*NamespaceNameN*|The name of a namespace.|
|*LayerNameN*|The name of a layer on the layer diagram.|
|*DependencyType*|The type of dependency relationship between *Artifact1* and *Artifact2*. For example, *Artifact1* has a **Calls** relationship with *Artifact2*.|

|**Error Syntax**|**Error Description**|
|----------------------|---------------------------|
|AV0001: Invalid Dependency: *Artifact1*(*ArtifactType1*) --> *Artifact2*(*ArtifactType2*)<br /><br /> Layers: *LayerName1*, *LayerName2* &#124; Dependencies: *DependencyType*|*Artifact1* in *LayerName1* should not have a dependency on *Artifact2* in *LayerName2* because *LayerName1* does not have a direct dependency on *LayerName2*.|
|AV1001: Invalid Namespace: *Artifact*<br /><br /> Layer: *LayerName* &#124; Required Namespace: *NamespaceName1* &#124; Current Namespace: *NamespaceName2*|*LayerName* requires that its associated artifacts must belong to *NamespaceName1*. *Artifact* is in *NamespaceName2*, not *NamespaceName1*.|
|AV1002: Depends on Forbidden Namespace: *Artifact1*(*ArtifactType1*) &#124; *Artifact2*(*ArtifactType2*)<br /><br /> Layer: *LayerName* &#124; Forbidden Namespace: *NamespaceName* &#124; Dependencies: *DependencyType*|*LayerName* requires that its associated artifacts must not depend on *NamespaceName*. *Artifact1* cannot depend on *Artifact2* because *Artifact2* is in *NamespaceName*.|
|AV1003: In Forbidden Namespace: *Artifact*(*ArtifactType*)<br /><br /> Layer: *LayerName* &#124; Forbidden Namespace: *NamespaceName*|*LayerName* requires that its associated artifacts cannot belong to *NamespaceName*. *Artifact* belongs to *NamespaceName*.|
|AV3001: Missing Link: Layer '*LayerName*' links to '*Artifact*' which cannot be found. Are you missing an assembly reference?|*LayerName* links to an artifact that cannot be found. For example, a link to a class might be missing because the modeling project is missing a reference to the assembly that contains the class.|
|AV9001: Architectural analysis found internal errors. Results might not be complete. For more information, see the detailed build event log or output window.|See the build event log or output window for more details.|

## Security

## See Also
 [Validate your system during development](../modeling/validate-your-system-during-development.md)
