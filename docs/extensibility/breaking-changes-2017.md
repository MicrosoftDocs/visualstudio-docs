---
title: Breaking Changes in Visual Studio 2017 extensibility
titleSuffix: ""
ms.date: "11/09/2016"
ms.topic: "conceptual"
ms.assetid: 54d5af60-0b44-4ae1-aa57-45aa03f89f3d
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"

---
# Changes in Visual Studio 2017 extensibility

Visual Studio 2017 provides a [faster, lighter-weight Visual Studio installation experience](https://devblogs.microsoft.com/visualstudio/faster-leaner-visual-studio-installer) that reduces the impact of Visual Studio on user systems while giving users greater choice over the workloads and features that are installed. To support these improvements, we've made changes to the extensibility model, including some breaking changes. This article describes the technical details of these changes and what can be done to address them.

> [!NOTE]
> Some information is point-in-time implementation details and may be changed later.

## Changes affecting VSIX format and installation

Visual Studio 2017 introduced the VSIX v3 (version 3) format to support the lightweight installation experience.

Changes to the VSIX format include:

* Declaration of setup prerequisites. To deliver on the promise of a lightweight, fast-installing Visual Studio, the installer now offers more configuration options to users. As a result, to ensure that the features and components required by an extension are installed, extensions need to declare their dependencies.

  * The Visual Studio 2017 installer automatically offers to acquire and install the necessary components for the user as part of installing your extension.
  * Users are also warned when trying to install an extension that was not built using the new VSIX v3 format, even if they have been marked in their manifest as targeting version 15.0.

* Enhanced capabilities for the VSIX format. To deliver on a [low-impact install](https://devblogs.microsoft.com/visualstudio/anatomy-of-a-low-impact-visual-studio-install) of Visual Studio that also supports side-by-side installs, we no longer save most configuration data to the system registry and have moved Visual Studio-specific assemblies out of the GAC. We also increased the capabilities of the VSIX format and VSIX installation engine, allowing you to use it rather than an MSI or EXE to install your extensions for some installation types.

The new capabilities include:

* Registration into the specified Visual Studio instance.
* Installation outside the [extensions folder](set-install-root.md).
* Detection of processor architecture.
* Dependence on language-separated language packs.
* Installation with [NGEN support](ngen-support.md).

## Build an extension for Visual Studio 2017

Designer tooling for authoring of the new VSIX v3 manifest format is available in Visual Studio 2017. See the accompanying document [How to: Migrate extensibility projects to Visual Studio 2017](how-to-migrate-extensibility-projects-to-visual-studio-2017.md) for details on using the designer tools or making manual updates to the project and manifest to develop VSIX v3 extensions.

## Change: Visual Studio user data path

Previously, only one installation of each major release of Visual Studio could exist on each machine. To support side-by-side installations of Visual Studio 2017, multiple user data paths for Visual Studio may exist on the user's machine.

Code running inside the Visual Studio process should be updated to use the Visual Studio Settings Manager. Code running outside of the Visual Studio process can find the user path of a specific Visual Studio installation [by following the guidance here](locating-visual-studio.md).

## Change: Global Assembly Cache (GAC)

Most Visual Studio core assemblies are no longer installed into the GAC. The following changes were made so that code running in Visual Studio process can still find required assemblies at run time.

> [!NOTE]
> [INSTALLDIR] below refers to the installation root directory of Visual Studio. *VSIXInstaller.exe* will automatically populate this, but to write custom deployment code, please read [locating Visual Studio](locating-visual-studio.md).

* Assemblies that were only installed into the GAC:

  These assemblies are now installed under <em>[INSTALLDIR]\Common7\IDE\*, *[INSTALLDIR]\Common7\IDE\PublicAssemblies</em> or *[INSTALLDIR]\Common7\IDE\PrivateAssemblies*. These folders are part of the Visual Studio process's probing paths.

* Assemblies that were installed into a non-probing path and into the GAC:

  * The copy in the GAC was removed from setup.
  * A *.pkgdef* file was added to specify a code base entry for the assembly.

    For example:

    ```
    [$RootKey$\RuntimeConfiguration\dependentAssembly\codeBase\{UniqueGUID}]
    "name"="AssemblyName" "codeBase"="$PackageFolder$\AssemblyName.dll"
    "publicKeyToken"="Public Key Token"
    "culture"="neutral"
    "version"=15.0.0.0
    ```

    At run time, the Visual Studio pkgdef subsystem merges these entries into the Visual Studio process's runtime configuration file (under *[VSAPPDATA]\devenv.exe.config*) as [`<codeBase>`](/dotnet/framework/configure-apps/file-schema/runtime/codebase-element) elements. This is the recommended way to let the Visual Studio process find your assembly, because it avoids searching through probing paths.

### Reacting to this breaking change

* If your extension is running within the Visual Studio process:

  * Your code will be able to find Visual Studio core assemblies.
  * Consider using a *.pkgdef* file to specify a path to your assemblies if necessary.

* If your extension is running outside the Visual Studio process:

  Consider looking for Visual Studio core assemblies under <em>[INSTALLDIR]\Common7\IDE\*, *[INSTALLDIR]\Common7\IDE\PublicAssemblies</em> or *[INSTALLDIR]\Common7\IDE\PrivateAssemblies* using configuration file or assembly resolver.

## Change: Reduce registry impact

### Global COM registration

* Previously, Visual Studio installed many registry keys into the HKEY_CLASSES_ROOT and HKEY_LOCAL_MACHINE hives to support native COM registration. To eliminate this impact, Visual Studio now uses [Registration-Free Activation for COM components](https://msdn.microsoft.com/library/ms973913.aspx).
* As a result, most TLB / OLB / DLL files under %ProgramFiles(x86)%\Common Files\Microsoft Shared\MSEnv are no longer installed by default by Visual Studio. These files are now installed under [INSTALLDIR] with corresponding Registration-Free COM manifests used by the Visual Studio host process.
* As a result, external code that relies on global COM registration for Visual Studio COM interfaces will no longer find these registrations. Code running inside Visual Studio process will not see a difference.

### Visual Studio registry

* Previously, Visual Studio installed many registry keys into the system's **HKEY_LOCAL_MACHINE** and **HKEY_CURRENT_USER** hives under a Visual Studio-specific key:

  * **HKLM\Software\Microsoft\VisualStudio\{Version}**: Registry keys created by MSI installers and per-machine extensions.
  * **HKCU\Software\Microsoft\VisualStudio\{Version}**: Registry keys created by Visual Studio to store user-specific settings.
  * **HKCU\Software\Microsoft\VisualStudio\{Version}_Config**: A copy of Visual Studio HKLM key above, plus the registry keys merged from *.pkgdef* files by extensions.

* To reduce the impact on the registry, Visual Studio now uses the [RegLoadAppKey](/windows/desktop/api/winreg/nf-winreg-regloadappkeya) function to store registry keys in a private binary file under *[VSAPPDATA]\privateregistry.bin*. Only a very small number of Visual Studio-specific keys remain in the system registry.
* Existing code running inside the Visual Studio process is not impacted. Visual Studio will redirect all registry operations under the HKCU Visual Studio-specific key to the private registry. Reading and writing to other registry locations will continue to use the system registry.
* External code will need to load and read from this file for Visual Studio registry entries.

### React to this breaking change

* External code should be converted to use Registration-Free activation for COM components as well.
* External components can find the Visual Studio location [by following the guidance here](https://devblogs.microsoft.com/setup/changes-to-visual-studio-15-setup).
* We recommend that external components use the [External Settings Manager](/dotnet/api/microsoft.visualstudio.settings.externalsettingsmanager) instead of reading/writing directly to Visual Studio registry keys.
* Check whether the components your extension is using may have implemented another technique for registration. For example, debugger extensions may be able to take advantage of the new [msvsmon JSON-file COM registration](migrate-debugger-COM-registration.md).
