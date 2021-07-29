---
title: Upgrade Dotfuscator Community
ms.date: 07/21/2021
ms.devlang: dotnet
ms.topic: how-to
keywords: Dotfuscator, Dotfuscator Community, Dotfuscator CE, PreEmptive, PreEmptive Solutions, PreEmptive Protection, protection, community edition, obfuscation, .NET, free, Visual Studio 2019, Visual Studio 2017, Visual Studio, upgrade, command line
helpviewer_keywords:
- PreEmptive Protection Dotfuscator
- Dotfuscator Community Edition
- Dotfuscator CE
- Dotfuscator Community
- Dotfuscator
- obfuscation
- protection
- Dotfuscator upgrade
- upgrade Dotfuscator
- upgrading Dotfuscator
- register Dotfuscator
- registering Dotfuscator
- Dotfuscator command line
- Dotfuscator Professional
description: Learn how to upgrade the free copy of Dotfuscator Community 5 included in Visual Studio.
ms.assetid: 
author: 
ms.author: 
manager: 
---
# Upgrading from Dotfuscator Community 5

This User Guide covers ***PreEmptive Protection - Dotfuscator Community* 6**.
Depending on your installation history and version of Visual Studio, you may be currently running Dotfuscator Community 5, the prior major version.
If so, you should upgrade, because [it is important to ensure your code is being given the latest protection measures][always-improving].
Upgrades are available at no charge.

This page explains how to determine what version you currently have, how to upgrade to version 6 if necessary, and what features have been replaced or removed between the two versions.

<div id="toc">
<!-- TOC will be inserted here -->
</div>

## Determining Dotfuscator's Version

If you are unsure what version of Dotfuscator you are running, you can determine the version by doing one of the following:

* Launch the Dotfuscator Community [graphical user interface][gui] (GUI) by going to Visual Studio's **Tools** menu and selecting **PreEmptive Protection - Dotfuscator Community**.
  From the Dotfuscator GUI, open the **Help** menu, and select **About...** to display the About screen.
  This screen will list Dotfuscator's version.

* If you have Dotfuscator integrated into your build with the [command line interface][cli] (such as with [Xamarin][xamarin] apps), you can also check your build logs for a line like the following:

  ```no-highlight
  Dotfuscator Community Version 5.42.0.9514-e0e25f754
  ```

  You may need to increase your build's verbosity in order to see this text.
  For Visual Studio, see [Verbosity Settings][verbosity].

The first integer of the version, before the first dot `.`, indicates Dotfuscator's major version.
If this is `5`, then you should perform the upgrade steps on this page, so that you can take advantage of the latest Dotfuscator 6 features and protection updates.

## Upgrade Instructions

This section includes sets of instructions for upgrading typical usages of Dotfuscator Community from version 5 to version 6.

### Installing Dotfuscator 6

Dotfuscator Community is distributed as an extension for Visual Studio.
The instructions to install Dotfuscator 6 vary by which version of Visual Studio you have:

* **Visual Studio 2019**.
  Dotfuscator Community 6 is included in later versions of Visual Studio 2019 (version 16.10.0 and later).
  [Update Visual Studio 2019][vs-update] to the latest version.
  This will automatically upgrade any Dotfuscator Community 5 installation to Dotfuscator Community 6.

    * If you do not have Dotfuscator installed already, update Visual Studio first and then see [Installation][install].

    * In addition to the releases with Visual Studio, you can always get the latest versions of Dotfuscator Community from the [Dotfuscator Downloads][download] page.

* **Visual Studio 2017**.
  This version of Visual Studio only shipped with Dotfuscator Community 5.
  However, you can install or upgrade to Dotfuscator Community 6 by going to the [Dotfuscator Downloads][download] page and selecting the appropriate download link.

  Run the downloaded `.vsix` file and follow the prompts to install Dotfuscator Community 6 into Visual Studio.
  This will upgrade existing Dotfuscator Community 5 installations.

* **Earlier versions of Visual Studio.**
  Dotfuscator Community 6 is not supported in these versions of Visual Studio.
  We recommend upgrading to a newer version of Visual Studio, or [upgrading from Dotfuscator Community to Dotfuscator Professional][pro].

If you had previously [registered][register] Dotfuscator Community 5, that registration will be automatically converted the first time you run Dotfuscator Community 6.

<a name="steps-cli"></a>
### Updating Paths to the Command Line Interface

If you previously used Dotfuscator 5's [command line interface][cli] (CLI) to protect your app, you will need to update the path to the CLI in any projects and build scripts that reference it.
This includes projects which use Dotfuscator Community's [Xamarin][xamarin] integration.

The reason a path to Dotfuscator's CLI may now be invalid is because the names of some of the executables installed with Dotfuscator Community have changed in Dotfuscator 6.
This change makes these executable names the same across Dotfuscator Community and Dotfuscator Professional.

| Executable for...                     | Dotfuscator 5         | Dotfuscator 6         |
|---------------------------------------|-----------------------|-----------------------|
| [Graphical user interface][gui] (GUI) | `dotfuscator.exe`     | `dotfuscatorUI.exe`   |
| [Command line interface][cli] (CLI)   | `dotfuscatorCLI.exe`  | `dotfuscator.exe`     |

<div id="cli-other-note" class="alert alert-info">
<strong><i class="fas fa-info-circle"></i> Note:</strong>
The CLI path may also be invalid if you upgrade between major versions of Visual Studio or switch Visual Studio editions, as the Dotfuscator CLI is installed under Visual Studio's installation directory.
The symptoms and solution listed below also apply to this scenario.
</div>

If your build is using an invalid Dotfuscator CLI path, you may get errors such as one of the following:

```no-highlight
'"[...]\PreEmptiveSolutions\DotfuscatorCE\dotfuscatorCLI.exe"' is not recognized as an internal or external command,
operable program or batch file.
```

```no-highlight
The command ""[...]\PreEmptiveSolutions\DotfuscatorCE\dotfuscatorCLI.exe" Dotfuscator.xml" exited with code 9009.
```

```no-highlight
When the DotfuscatorXamarinEnabled property is 'true', the Dotfuscator command line interface specified by
DotfuscatorXamarinCliPath ('[...]\DotfuscatorCE\dotfuscatorCLI.exe') must exist.
```

To update your build to use the correct command line interface path:

1. Launch the Dotfuscator Community [graphical user interface][gui] (GUI) by going to Visual Studio's **Tools** menu and selecting **PreEmptive Protection - Dotfuscator Community**.
   
2. In the Dotfuscator Community GUI, go to the **Tools** menu and select **Dotfuscator Command Prompt**.

3. In the command prompt that opens, type `where dotfuscator.exe`.
   Copy the first path displayed to a plain text document for later reference; this is the new path to Dotfuscator Community 6's command line interface.

4. Open the project or build configuration as appropriate for your build system.

    * For Visual Studio projects, you will need to open the project file (`.csproj`, `.vbproj`, or `.fsproj`) as plain text.
      [Click here](https://docs.microsoft.com/en-us/visualstudio/ide/solutions-and-projects-in-visual-studio#project-file) for instructions on opening a project file this way in Visual Studio.
    
    * If you previously used Dotfuscator Community's [Xamarin][xamarin] integration to protect a Xamarin app, recall that Dotfuscator is integrated into each individual app project (such as `MyProject.Android.csproj` and `MyProject.iOS.csproj`) separately and not into shared library projects.
      You will need to update all of the app projects that are currently using Dotfuscator.

5. Locate any places within your project or build configuration where an old path to Dotfuscator Community 5's command line interface is used.
   This will typically be a path ending in `dotfuscatorCLI.exe`.

    * When updating a project using Dotfuscator Community's [Xamarin][xamarin] integration, the old path will be located between the `<DotfuscatorXamarinCliPath>` and `</DotfuscatorXamarinCliPath>` tags.

6. Replace the old paths located in step 5 with the new path you noted in step 3.
   
   If one of the old paths is not an absolute path, then you should adjust the new path appropriately based on the context.
   In the example below, the `VSInstallDir` environment variable was used in the old path, so the corresponding new path should do so as well.

    * New path from step 3: `C:\Program Files (x86)\Microsoft Visual Studio\2019\Preview\Common7\IDE\Extensions\PreEmptiveSolutions\DotfuscatorCE\dotfuscator.exe`
    * Old path in project file: `%VSInstallDir%\Common7\IDE\Extensions\PreEmptiveSolutions\DotfuscatorCE\dotfuscatorCLI.exe`
    * New path in project file: `%VSInstallDir%\Common7\IDE\Extensions\PreEmptiveSolutions\DotfuscatorCE\dotfuscator.exe`

7. If you are using a source control system, such as Git, then ensure the changes from step 6 are reflected in that system.
   Distribute these changes to the rest of your team as may be appropriate for your system and organization.

<div id="no-nuget-config-editor-warning" class="alert alert-warning">
<strong><i class="fas fa-exclamation-circle"></i> Warning:</strong>
Because `dotfuscator.exe` refers to the graphical user interface (GUI) in Dotfuscator 5 but refers to the command line interface (CLI) in Dotfuscator 6, be careful when updating build scripts shared across multiple machines.
<p/>
A machine with Dotfuscator 5 installed that runs a script updated for Dotfuscator 6 will cause the script to launch the graphical user interface, instead of the intended command line interface.
**This may cause the build to succeed despite not applying Dotfuscator's protection, meaning your output packages will NOT be protected.**
In other cases, it could instead cause a build failure.
<p/>
To avoid these scenarios, upgrade Dotfuscator Community from version 5 to version 6 across all of your machines and build scripts at the same time.
</div>

<a name="steps-config-files"></a>
### Upgrading Dotfuscator Config Files

***All*** Dotfuscator config files (such as `Dotfuscator.xml`) that were created prior to Dotfuscator 6 will need to be upgraded.

If you try to run the Dotfuscator command line interface (CLI) with an old configuration file, you will get errors like the following:

```no-highlight
Dotfuscator Engine Initialization error: PreEmptive Analytics, Authenticode signing, and the Introduce Explicit Method Overrides
setting are no longer supported. Please open your Dotfuscator config in the Config Editor which will automatically upgrade it.
```

<div id="config-file-important" class="alert alert-info">
<strong><i class="fas fa-info-circle"></i> Important:</strong>
You will receive this error and will need to upgrade your config file even if you were not using the features mentioned.
</div>

To upgrade a config file:

1. Launch the Dotfuscator Community [graphical user interface][gui] (GUI) by going to Visual Studio's **Tools** menu and selecting **PreEmptive Protection - Dotfuscator Community**.

2. Open the Dotfuscator config file in question (Ctrl+O).

3. The following message will be displayed in the *Build Output* tab:

   ```no-highlight
   PreEmptive Analytics, Authenticode signing, and the Introduce Explicit Method Overrides setting are no longer supported.
   The associated settings have been removed. Please save your upgraded Dotfuscator config.
   ```

4. Save the updated Dotfuscator config file (Ctrl+S).

5. If you are using a source control system, such as Git, then ensure the changes to the Dotfuscator config file are reflected in that system.
   Distribute these changes to the rest of your team as may be appropriate for your system and organization.

### Updating Xamarin Integration

If you integrated Dotfuscator Community 5 into your [Xamarin][xamarin] project, [one of the steps][xamarin-download] required you to download custom MSBuild targets and tasks, such as `PreEmptive.Dotfuscator.Xamarin.targets`.
These targets and tasks have been updated in Dotfuscator Community 6, so you will need to replace the old versions with the new versions.

To update your Xamarin integration files:

1. Locate the directory where you initially downloaded these files.
   The example given in [the instructions][xamarin-download] uses a subdirectory named `PreEmptive.Dotfuscator.Xamarin`, but you may have downloaded the files into a different directory, which may or may not also have files unrelated to Dotfuscator.

2. In the directory located in step 1, delete the files related to the Dotfuscator Xamarin integration.

3. Download the ZIP file linked at the current version of the following User Guide section: [Download the custom set of MSBuild Targets and Tasks for Dotfuscator][xamarin-download].

4. Extract the contents of the ZIP file to the same directory as noted in step 1.

5. If you are using a source control system, such as Git, then ensure the removal of the old files and addition of the new files are reflected in that system.
   Depending on the kind of system, these changes may appear as files changing contents, rather than being replaced.
   Distribute these changes to the rest of your team as may be appropriate for your system and organization.

Other subsections on this page also apply to Xamarin projects, so please review the rest of this page's instructions as well.

### Updating References to Attribute Libraries

Dotfuscator allows you to configure certain features via [.NET attributes][dotnet-attributes] in your source code.
If your projects were using such attributes, you may need to update them to address changes in Dotfuscator 6.

#### Obfuscation Attributes

There have been no changes to the [Obfuscation Attributes][attributes-obfuscation].
These attributes are defined in the .NET base class libraries, and Dotfuscator Community 6 continues to honor them.

<a name="steps-attrs-check"></a>
#### Check Attributes

The library containing the [Check Attributes][attributes-checks] has changed.
In Dotfuscator Community 5, it was distributed as a file alongside Dotfuscator itself.
Starting in Dotfuscator Community 6, it is instead distributed as a public NuGet package.

If you try to build a Visual Studio project which still references the old location, you may get errors like the following:

```no-highlight
The type or namespace name 'PreEmptive' could not be found
(are you missing a using directive or an assembly reference?)
```

```no-highlight
The type or namespace name 'TamperCheckAttribute' could not be found
(are you missing a using directive or an assembly reference?)
```

You may also get this warning:

```no-highlight
Could not resolve this reference. Could not locate the assembly "PreEmptive.Attributes". Check to make sure the assembly exists
on disk. If this reference is required by your code, you may get compilation errors.
```

To update your project to use the new location:

1. Remove the project's assembly reference to `PreEmptive.Attributes.dll`.

2. Add the NuGet package reference `PreEmptive.Protection.Checks.Attributes` to the project.
    The package is available on the default NuGet feed, [nuget.org][nuget-org].

Each Check Attribute's `ExtendedKey` parameters have also been removed.
These parameters were ignored in Dotfuscator Community 5, but if your source code used them regardless, you will need to remove these usages in order for your project to compile.

<a name="steps-attrs-analytics"></a>
#### Instrumentation Attributes

Instrumentation attributes were used to configure the PreEmptive Analytics feature in Dotfuscator 5.
However, PreEmptive Analytics has been removed in Dotfuscator 6; see the Removed Feature subsection [PreEmptive Analytics](#removed-analytics).
As a result, the instrumentation attributes have also been removed.

If you try to build a Visual Studio project which used instrumentation attributes, you may get the same kinds of errors and warnings as noted in [Check Attributes](#steps-attrs-check), though the attribute names will differ (for example, `FeatureAttribute` instead of `TamperCheckAttribute`).

If you try to run Dotfuscator on already-built assemblies which contain usages of instrumentation attributes, you will get errors like the following:

```no-highlight
The PreEmptive.Attributes.FeatureAttribute attribute (annotating SomeNamespace.SomeType::SomeMethod) is not recognized
by this version of Dotfuscator.
```

To fix these problems, you will need to remove all usages of instrumentation attributes from your source code.
You will also need to remove the assembly references to the library which defined the attributes, `PreEmptive.Attributes.dll`.
(If you were also using the Check Attributes that were defined in this library, they have moved; see [Check Attributes](#steps-attrs-check) above.)

## Removed Features

Dotfuscator Community 6 introduces breaking changes from Dotfuscator Community 5.
If you have been using Dotfuscator Community 5, this section describes how to deal with the changes that might require build modifications or affect Dotfuscator's output.
A full list of the changes is available in the [changelog][changelog].

<a name="removed-analytics"></a>
### PreEmptive Analytics

Dotfuscator 6 does not support PreEmptive Analytics, including Check Telemetry.
However, [Checks][checks-overview] themselves (including [Application Notification][checks-notification] and [Check Actions][checks-actions]) are still supported.

To use Dotfuscator 6, you will need to [upgrade your configuration file](#steps-config-files) to remove the PreEmptive Analytics settings.

If you were using in-code attributes to configure PreEmptive Analytics, you will need to [remove those from your source code](#steps-attrs-analytics) and rebuild your input assemblies before Dotfuscator 6 can protect those assemblies.

If you were using Check Telemetry to report when a Check detects an invalid state (such as when [tampering is detected][tamper]), you can replace it with a custom [Application Notification][checks-notification] that reports the incident to [Azure Application Insights][application-insights] or another service of your choice.

### Unsupported Application Types

The following application types are no longer supported in Dotfuscator 6:

* Windows Phone
* WinRT (Windows 8 apps)
* Silverlight
* Unity (game engine)

Additionally, Universal Windows Platform (UWP) apps are only supported for [Xamarin][xamarin] scenarios.
To protect other kinds of UWP apps, [upgrade to Dotfuscator Professional][pro] and follow the [Protect Your App][pro-pya] instructions.

### Unsupported Inputs

Dotfuscator Community no longer supports Universal Windows Platform (UWP) `.appx` packages as [inputs][inputs].
You can continue to protect Xamarin apps targeting UWP with the [Xamarin][xamarin] integration.
To protect other kinds of UWP apps, [upgrade to Dotfuscator Professional][pro] and follow the [Protect Your App][pro-pya] instructions.

Additionally, `.xap` packages can no longer be used as inputs.
This is because Silverlight is no longer supported.

### Introduce Explicit Method Overrides

The Renaming option to introduce explicit method overrides has been removed from Dotfuscator.
To use Dotfuscator 6, you will need to [upgrade your configuration file](#steps-config-files) to remove this setting.

[changelog]: https://www.preemptive.com/support/dotfuscator-support/dotfuscator-ce-change-log
[download]: https://www.preemptive.com/products/dotfuscator/downloads
[always-improving]: https://www.preemptive.com/always-improving
[vs-update]: https://docs.microsoft.com/en-us/visualstudio/install/update-visual-studio

[install]: intro_install.html
[register]: intro_register.html
[pro]: intro_upgrades.html
[pro-pya]: https://www.preemptive.com/dotfuscator/pro/userguide/en/getting_started_protect.html

[gui]: getting_started_gui.html
[cli]: getting_started_cli.html
[xamarin]: getting_started_xamarin.html
[xamarin-download]: getting_started_xamarin.html#setup-targets

[inputs]: gui_inputs.html

[checks-overview]: checks_overview.html
[checks-notification]: checks_overview.html#app-notification
[checks-actions]: checks_overview.html#actions
[tamper]: checks_tamper.html

[attributes-checks]: attributes_checks.html
[attributes-obfuscation]: attributes_obfuscation.html

[verbosity]: https://docs.microsoft.com/en-us/visualstudio/ide/how-to-view-save-and-configure-build-log-files#to-change-the-amount-of-information-included-in-the-build-log
[dotnet-attributes]: https://docs.microsoft.com/en-us/dotnet/standard/attributes/
[application-insights]: https://docs.microsoft.com/en-us/azure/azure-monitor/app/app-insights-overview
[nuget-org]: https://www.nuget.org/
