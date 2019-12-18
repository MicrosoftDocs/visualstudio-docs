---
title: "Migrating a Legacy Language Service | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "language services, migrating"
ms.assetid: e0f666a0-92a7-4f9c-ba79-d05b13fb7f11
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Migrating a Legacy Language Service
You can migrate a legacy language service to a later version of Visual Studio by updating the project and adding a source.extension.vsixmanifest file to the project. The language service itself will continue to function as before, because the Visual Studio editor adapts it.

 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more about the new way to implement a language service, see [Editor and Language Service Extensions](../../extensibility/editor-and-language-service-extensions.md).

> [!NOTE]
> We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.

## Migrating a Visual Studio 2008 Language Service Solution to a Later Version
 The following steps show how to adapt a Visual Studio 2008 sample named RegExLanguageService. You can find this sample in a Visual Studio 2008 SDK installation, in the *Visual Studio SDK installation path*\VisualStudioIntegration\Samples\IDE\CSharp\Example.RegExLanguageService\ folder.

> [!IMPORTANT]
> If your language service does not define colors, you must explicitly set <xref:Microsoft.VisualStudio.Shell.ProvideLanguageServiceAttribute.RequestStockColors%2A> to `true` on the VSPackage:

```
[Microsoft.VisualStudio.Shell.ProvideLanguageService(typeof(YourLanguageService), YourLanguageServiceName, 0, RequestStockColors = true)]
```

#### To migrate a Visual Studio 2008 language service to a later version

1. Install the newer versions of Visual Studio and the Visual Studio SDK. For more information about ways to install the SDK, see [Installing the Visual Studio SDK](../../extensibility/installing-the-visual-studio-sdk.md).

2. Edit the RegExLangServ.csproj file (without loading it in Visual Studio.

     In the `Import` node that refers to the Microsoft.VsSDK.targets file, replace the value with the following text.

    ```
    $(MSBuildExtensionsPath)\Microsoft\VisualStudio\v14.0\VSSDK\Microsoft.VsSDK.targets
    ```

3. Save the file, and then close it.

4. Open the RegExLangServ.sln solution.

5. The **One-way upgrade** window appears. Click **OK**.

6. Update the project properties. Open the **Project Properties** window by selecting the project node in the **Solution Explorer**, right-clicking, and selecting **Properties**.

    - On the **Application** tab, change **Target framework** to **4.6.1**.

    - On the **Debug** tab, in the **Start external program** box, type **\<Visual Studio installation path>\Common7\IDE\devenv.exe.**.

         In the **Command line arguments** box, type /**rootsuffix Exp**.

7. Update the following references:

    - Remove the reference to Microsoft.VisualStudio.Shell.9.0.dll, then add references to Microsoft.VisualStudio.Shell.14.0.dll and Microsoft.VisualStudio.Shell.Immutable.11.0.dll.

    - Remove the reference to Microsoft.VisualStudio.Package.LanguageService.9.0.dll, then add a reference to Microsoft.VisualStudio.Package.LanguageService.14.0.dll.

    - Add a reference to Microsoft.VisualStudio.Shell.Interop.10.0.dll.

8. Open the VsPkg.cs file and change the value of the `DefaultRegistryRoot` attribute to

    ```
    "Software\\Microsoft\\VisualStudio\\14.0Exp"
    ```

9. The original sample does not register its language service, so you must add the following attribute to VsPkg.cs.

    ```
    [ProvideLanguageService(typeof(RegularExpressionLanguageService), "RegularExpressionLanguage", 0, RequestStockColors=true)]
    ```

10. You must add a source.extension.vsixmanifest file.

    - Copy this file from an existing extension to your project directory. (One way to get this file is to create a VSIX project (under **File**, click **New**, then click **Project**. Under Visual Basic or C# click **Extensibility**, then select **VSIX Project**.)

    - Add the file to your project.

    - In the file's **Properties**, set **Build Action** to **None**.

    - Open the file with the **VSIX Manifest Editor**.

    - Change the following fields:

    - **ID**: RegExLangServ

    - **Product Name**: RegExLangServ

    - **Description**: A regular expression language service.

    - Under **Assets**, click **New**, select the **Type** to **Microsoft.VisualStudio.VsPackage**, set the **Source** to **A project in current solution**, and then set the **Project** to **RegExLangServ**.

    - Save and close the file.

11. Build the solution. The built files are deployed to **%USERPROFILE%\AppData\Local\Microsoft\VisualStudio\14.0Exp\Extensions\MSIT\ RegExLangServ\\**.

12. Start debugging. A second instance of Visual Studio opened.

## See also
- [Legacy Language Service Extensibility](../../extensibility/internals/legacy-language-service-extensibility.md)