---
title: Upgrade Dotfuscator Community
ms.date: 03/28/2019
ms.devlang: dotnet
ms.topic: conceptual
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
description: Learn how to upgrade the free copy of Dotfuscator Community included in Visual Studio.
ms.assetid: c7c60904-27f9-4f1f-b79b-ddf65041b810
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
---
# Upgrade Dotfuscator Community

Dotfuscator Community offers many application protection and hardening features immediately to all developers using Microsoft Visual Studio.
However, there are more features available to users who upgrade their version of Dotfuscator.

This User Guide covers ***PreEmptive Protection - Dotfuscator Community* 6**.
Depending on your installation history and version of Visual Studio, you may be currently running Dotfuscator Community 5, the prior major version.
If so, you should upgrade, because [it is important to ensure your code is being given the latest protection measures][always-improving].
Upgrades are available at no charge.

This page explains how to determine what version you currently have, how to upgrade to version 6 if necessary, and what features have been replaced or removed between the two versions.

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

### Updating Paths to the Command Line Interface

For the CLI update instructions, see the [Updating from Community 5][up-com] page of the full Dotfuscator Community User Guide.

### Upgrading Dotfuscator Config Files

For the config files upgrade instructions, see the [Updating from Community 5][up-com-d] page of the full Dotfuscator Community User Guide.

### Updating Xamarin Integration

For the Xamarin Integration update instructions, see the [Updating from Community 5][up-com-xa] page of the full Dotfuscator Community User Guide

### Updating References to Attribute Libraries

For the References to Attribute Libraries update instructions, see the [Updating from Community 5][up-com-li] page of the full Dotfuscator Community User Guide.

## Removed Features

Dotfuscator Community 6 introduces breaking changes from Dotfuscator Community 5.
If you have been using Dotfuscator Community 5, this section describes how to deal with the changes that might require build modifications or affect Dotfuscator's output.
A full list of the changes is available in the [changelog][changelog].

## Registering Dotfuscator Community

Registered users of Dotfuscator Community get access to additional features, such as [command-line support][cli], which makes it easy to integrate Dotfuscator Community into your automated build process. Registering also grants access to a built-in tool used for [decoding obfuscated stack traces][decode-obfuscated].

Registration is quick, simple, and free of charge.
To register Dotfuscator Community, see [the instructions in the full Dotfuscator Community User Guide][register-ce].

## Upgrading to Dotfuscator Professional

While Dotfuscator Community provides a basic level of protection, upgrading to ***PreEmptive Protection - Dotfuscator Professional*** will give you access to enhanced obfuscation transforms and protection capabilities. These include:

* *Intellectual Property Protection*
  * Additional renaming options, including Enhanced Overload Induction™ and randomized identifier selection.
  * Access to enterprise-level obfuscation transforms, including [transforms targeted at defeating automated code decompilation][control-flow].
  * The ability to [obscure sensitive strings][string-encryption], making a simple search of the decompiled code impossible.
  * The ability to [discreetly embed ownership and distribution strings into your assemblies][watermarking], (software watermarking) allowing you to determine the source of unauthorized software leaks.
  * The ability to [combine multiple assemblies into one][linking], making it even more difficult for attackers to determine the roles of code elements, as separation of concerns has been eliminated.
  * The ability to [automatically remove unused code from your application][pruning], reducing the amount of sensitive code that is shipped.
* *Application Integrity Protection*
  * Additional [application defense behaviors][check-actions].
  * The ability to inject anti-tamper and anti-debug code into `.dll` assemblies.
  * The ability to provide a warning period before an application's end-of-life deadline.
  * The ability to notify application code during an end-of-life warning period or after the deadline.

Dotfuscator Professional is the industry standard [.NET Obfuscator][net-obfuscator] and is suitable for enterprise developers requiring ongoing support, maintenance, and product updates.
Additionally, Dotfuscator Professional offers tighter integration with Visual Studio and is licensed for commercial use.

For more information on the advanced application protection features of Dotfuscator Professional, please visit our [Dotfuscator Overview page][product-about] and [compare Dotfuscator Professional to Dotfuscator Community][product-compare].

[Fully-supported trials of Dotfuscator Professional are available on request at preemptive.com.][eval].

## See also

[Upgrade Dotfuscator Community][full]

<!-- Copyright © 2021 PreEmptive Solutions, LLC -->

[control-flow]:  https://www.preemptive.com/products/dotfuscator/features#controlflow
[string-encryption]:  https://www.preemptive.com/products/dotfuscator/features#string
[watermarking]:  https://www.preemptive.com/products/dotfuscator/features#watermarking
[linking]:  https://www.preemptive.com/products/dotfuscator/features#linking
[pruning]:  https://www.preemptive.com/products/dotfuscator/features#pruning

[check-actions]:  https://www.preemptive.com/dotfuscator/pro/userguide/en/protection_checks_overview.html#actions

[net-obfuscator]:  https://www.preemptive.com/products/dotfuscator/overview
[eval]:  https://www.preemptive.com/eval-request

[product-about]:  https://www.preemptive.com/products/dotfuscator/overview
[product-compare]:  https://www.preemptive.com/products/dotfuscator/compare-editions

[cli]:  https://www.preemptive.com/dotfuscator/ce/docs/help/intro_cli.html
[register-ce]:  https://www.preemptive.com/dotfuscator/ce/docs/help/gui_getstarted.html#register

[full]:  https://www.preemptive.com/dotfuscator/ce/docs/help/intro_upgrades.html
[decode-obfuscated]:  https://www.preemptive.com/dotfuscator/ce/docs/help/gui_decode_stack_trace.html

[Dotfuscator Community User Guide][home]

[always-improving]:  https://www.preemptive.com/always-improving
[gui]:  https://www.preemptive.com/dotfuscator/ce/docs/help/getting_started_gui.html
[xamarin]:  https://www.preemptive.com/dotfuscator/ce/docs/help/getting_started_xamarin.html
[verbosity]:  ../how-to-view-save-and-configure-build-log-files.md?view=vs-2019&preserve-view=true#to-change-the-amount-of-information-included-in-the-build-log
[vs-update]:  ../../install/update-visual-studio.md?view=vs-2019&preserve-view=true
[install]:  https://www.preemptive.com/dotfuscator/ce/docs/help/intro_install.html
[download]:  https://www.preemptive.com/products/dotfuscator/downloads
[pro]:  https://www.preemptive.com/dotfuscator/ce/docs/help/intro_upgrades.html
[register]:  https://www.preemptive.com/dotfuscator/ce/docs/help/intro_register.html
[up-com]:  https://www.preemptive.com/dotfuscator/ce/docs/help/intro_upgrade_from_5.html#pctoc-updating-paths-to-the-command-line-interface
[up-com-d]:  https://www.preemptive.com/dotfuscator/ce/docs/help/intro_upgrade_from_5.html#pctoc-upgrading-dotfuscator-config-files
[up-com-xa]:  https://www.preemptive.com/dotfuscator/ce/docs/help/intro_upgrade_from_5.html#pctoc-updating-xamarin-integration
[up-com-li]:  https://www.preemptive.com/dotfuscator/ce/docs/help/intro_upgrade_from_5.html#pctoc-updating-references-to-attribute-libraries
[changelog]:  https://www.preemptive.com/support/dotfuscator-support/dotfuscator-ce-change-log
[home]:  https://www.preemptive.com/dotfuscator/ce/docs/help/index.html