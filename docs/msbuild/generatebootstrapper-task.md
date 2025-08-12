---
title: GenerateBootstrapper Task
description: Use the MSBuild GenerateBootstrapper task for an automated way to detect, download, and install an application and its prerequisites.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#GenerateBootstrapper
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, GenerateBootstrapper task
- GenerateBootstrapper task [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# GenerateBootstrapper task

Provides an automated way to detect, download, and install an application and its prerequisites. It serves as a single installer that integrates the separate installers for all the components making up an application.

## Task parameters

The following describe the parameters of the `GenerateBootstrapper` task.

- `ApplicationFile`

   Optional `String` parameter.

   Specifies the file the bootstrapper will use to begin the installation of the application after all prerequisites have been installed. A build error will result if neither the `BootstrapperItems` nor the `ApplicationFile` parameter is specified.

- `ApplicationName`

   Optional `String` parameter.

   Specifies the name of the application that the bootstrapper will install. This name will appear in the UI the bootstrapper uses during installation.

- `ApplicationRequiresElevation`

   Optional `Boolean` parameter.

   If `true`, the component runs with elevated permissions when it is installed on a target computer.

- `ApplicationUrl`

   Optional `String` parameter.

   Specifies the Web location that is hosting the application's installer.

- `BootstrapperComponentFiles`

   Optional `String[]` output parameter.

   Specifies the built location of bootstrapper package files.

- `BootstrapperItems`

   Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.

   Specifies the products to build into the bootstrapper. The items passed to this parameter should have the following syntax:

  ```xml
  <BootstrapperItem
      Include="ProductCode">
      <ProductName>
          ProductName
      </ProductName>
  </BootstrapperItem>
  ```

   The `Include` attribute represents the name of a prerequisite that should be installed. The `ProductName` item metadata is optional, and will be used by the build engine as a user-friendly name if the package cannot be found. These items are not required MSBuild input parameters, unless no `ApplicationFile` is specified. You should include one item for every prerequisite that must be installed for your application.

   A build error will result if neither the `BootstrapperItems` nor the `ApplicationFile` parameter is specified.

- `BootstrapperKeyFile`

   Optional `String` output parameter.

   Specifies the built location of *setup.exe*

- `ComponentsLocation`

   Optional `String` parameter.

   Specifies a location for the bootstrapper to look for installation prerequisites to install. This parameter can have the following values:

  - `HomeSite`: Indicates that the prerequisite is being hosted by the component vendor.

  - `Relative`: Indicates that the prerequisite is at the same location of the application.

  - `Absolute`: Indicates that all components are to be found at a centralized URL. This value should be used in conjunction with the `ComponentsUrl` input parameter.

    If `ComponentsLocation` is not specified, `HomeSite` is used by default.

- `ComponentsUrl`

   Optional `String` parameter.

   Specifies the URL containing the installation prerequisites.

- `CopyComponents`

   Optional `Boolean` parameter.

   If `true`, the bootstrapper copies all output files to the path specified in the `OutputPath` parameter. The values of the `BootstrapperComponentFiles` parameter should all be based on this path. If `false`, the files are not copied, and the `BootstrapperComponentFiles` values are based on the value of the `Path` parameter.  The default value of this parameter is `true`.

- `Culture`

   Optional `String` parameter.

   Specifies the culture to use for the bootstrapper UI and installation prerequisites. If the specified culture is unavailable, the task uses the value of the `FallbackCulture` parameter.

- `FallbackCulture`

   Optional `String` parameter.

   Specifies the secondary culture to use for the bootstrapper UI and installation prerequisites.

- `OutputPath`

   Optional `String` parameter.

   Specifies the location to copy *setup.exe* and all package files.

- `Path`

   Optional `String` parameter.

   Specifies the location of all available prerequisite packages.

- `SupportUrl`

   Optional `String` parameter.

   Specifies the URL to provide if the bootstrapper installation fails.

- `Validate`

   Optional `Boolean` parameter.

   If `true`, the bootstrapper performs XSD validation on the specified input bootstrapper items. The default value of this parameter is `false`.

## Remarks

In addition to the parameters listed above, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
