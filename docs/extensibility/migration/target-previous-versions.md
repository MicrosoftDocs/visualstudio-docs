---
title: Target Visual Studio 2019 when creating an extension in Visual Studio 2022
description: Learn how to make your Visual Studio extension work with Visual Studio 2019 if you create the project with Visual Studio 2022.
ms.date: 06/08/2021
ms.topic: conceptual
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
monikerRange: "vs-2022"

---
# Target a previous version when creating an extension in Visual Studio 2022

When you create a new VSIX project using Visual Studio 2022, the project is created from a template that targets Visual Studio 2022. If you want to target Visual Studio 2019 or an earlier version, you must modify the created project.

Consider using [shared projects](update-visual-studio-extension.md#use-shared-projects-for-multi-targeting) to target Visual Studio 2019 and Visual Studio 2022 while sharing most or all the code in your extension.

Follow these steps on the VSIX project that should target Visual Studio 2019:

1. Edit the `source.extension.vsixmanifest` file to remove the `ProductArchitecture` element and the version range:

    ```diff
    -<InstallationTarget Id="Microsoft.VisualStudio.Community" Version="[17.0,18.0)">
    +<InstallationTarget Id="Microsoft.VisualStudio.Community" Version="[16.0,17.0)">
    -  <ProductArchitecture>amd64</ProductArchitecture>
     </InstallationTarget>
    ```

   Also update the prerequisite:

    ```diff
    -<Prerequisite Id="Microsoft.VisualStudio.Component.CoreEditor" Version="[17.0,18.0)" DisplayName="Visual Studio core editor" />
    +<Prerequisite Id="Microsoft.VisualStudio.Component.CoreEditor" Version="[16.0,17.0)" DisplayName="Visual Studio core editor" />
    ```

    Review the file for any other updates that may be necessary.

1. Change the versions of the VSSDK packages that you reference in your project file:

    ```diff
    -<PackageReference Include="Microsoft.VisualStudio.SDK" Version="17.0.0-preview.1" />
    +<PackageReference Include="Microsoft.VisualStudio.SDK" Version="16.0.206" />
    -<PackageReference Include="Microsoft.VSSDK.BuildTools" Version="17.0.63-preview.1" />
    +<PackageReference Include="Microsoft.VSSDK.BuildTools" Version="16.10.32" />
    ```
