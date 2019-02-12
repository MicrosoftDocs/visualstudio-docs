---
title: Dotfuscator Community Edition (CE)
ms.date: 10/10/2017
ms.devlang: "dotnet"
ms.topic: conceptual
keywords: Dotfuscator, Dotfuscator CE, PreEmptive, PreEmptive Solutions, PreEmptive Protection, protection, community edition, obfuscation, .NET, free, Visual Studio 2017
helpviewer_keywords:
  - "PreEmptive Protection Dotfuscator"
  - "Dotfuscator Community Edition"
  - "Dotfuscator CE"
  - "Dotfuscator"
  - "obfuscation"
  - "protection"
description: "Learn how you can protect your .NET applications with the free Dotfuscator Community Edition included in Visual Studio 2017."
ms.assetid: d9550502-0a82-49a6-b005-2caa791fbe02
author: "Joe-Sewell-PreEmptive"
ms.author: gewarren
manager: jillfra
---
# Dotfuscator Community Edition (CE)

*PreEmptive Protection - Dotfuscator* provides comprehensive .NET application protection that easily fits into your secure software development lifecycle.
Use it to harden, protect, and prune desktop, mobile, server, and embedded applications to help secure trade secrets and other intellectual property (IP), reduce piracy and counterfeiting, and protect against tampering and unauthorized debugging.
Dotfuscator works on compiled assemblies without the need for additional programming or even access to source code.

![PreEmptive Protection - Dotfuscator](media/header.svg)

## Why protection matters

It's important to **protect your intellectual property** (IP).
Your application's code contains design and implementation details, which can be considered IP.
However, applications built on the .NET Framework [contain significant metadata and high-level intermediate code][assemblies], making them easy to reverse engineer, just by using one of many free, automated tools.
By disrupting and stopping reverse-engineering, you can prevent unauthorized IP disclosure, as well as demonstrate that your code contains trade secrets.
Dotfuscator can [obfuscate][obfuscation] your .NET assemblies to hinder reverse-engineering, while maintaining original application behavior.

It's also important to **protect the integrity of your application**.
In addition to reverse-engineering, bad actors may attempt to pirate your application, alter the application's behavior at runtime, or manipulate data.
Dotfuscator can inject your application with the capability to [detect and respond to unauthorized uses][checks], including tampering, third-party debugging, and rooted devices.

For more information on how Dotfuscator fits into a secure software development lifecycle, see PreEmptive Solutions' [SDL App Protection page][sdl-protection].

## About Dotfuscator CE

Your copy of Microsoft Visual Studio 2017 includes a copy of **_PreEmptive Protection - Dotfuscator_ Community Edition**, also known as Dotfuscator CE, free for personal use.
For instructions on how to install the version of Dotfuscator CE included with Visual Studio 2017, see the [Installation page][install].

Dotfuscator CE offers a range of [software protection and hardening][software-protection] services for developers, architects, and testers.
Examples of [.NET Obfuscation][obfuscation] and other [Application Protection][app-protection] features included in Dotfuscator CE are:

* *[Renaming][renaming]* of identifiers to make reverse-engineering of the compiled assemblies more difficult.
* *[Anti-tamper][tamper]* to detect the execution of tampered applications and terminate or respond to tampered sessions.
* *[Anti-debug][debug]* to detect the attachment of a debugger to a running application and terminate or respond to debugged sessions.
* *[Anti-rooted device][root]* to detect if the application is running on a rooted Android device and terminate or respond to sessions on these devices.
* *[Application expiration behaviors][shelflife]* that encode an "end-of-life" date and terminate expired application sessions.

For details on these features, including how they fit into your application protection strategy, see the [Capabilities page][capabilities].

Dotfuscator CE offers basic protection out-of-the-box.
Even more application protection measures are available to registered users of Dotfuscator CE,
and to users of *PreEmptive Protection - Dotfuscator* Professional Edition, the world's leading [.NET Obfuscator][net-obfuscator].
For information about enhancing Dotfuscator, see the [Upgrades page][upgrades].

## Getting started

To begin using Dotfuscator CE from Visual Studio, type `dotfuscator` into the **Quick Launch** (Ctrl+Q) search bar.

* If Dotfuscator CE is already installed, **Quick Launch** brings up the *Menu* option to start the Dotfuscator CE user interface. For details, see [the Getting Started page of the full Dotfuscator CE User Guide][get-started].
* If Dotfuscator CE is not yet installed, **Quick Launch** brings up the relevant *Install* option. See the [Installation page][install] for details.

You can also get the **latest version** of Dotfuscator CE from [the Dotfuscator Downloads page on preemptive.com][download].

## Full documentation

This page and its subpages provide a high-level overview of Dotfuscator CE's features, as well as [instructions for installing the tool][install].

See [the full Dotfuscator CE User Guide at preemptive.com][full] for detailed usage instructions, including [how to start using the Dotfuscator CE user interface][get-started].

<!-- Copyright © 2017 PreEmptive Solutions, LLC -->

[assemblies]:  https://docs.microsoft.com/dotnet/standard/assembly-format
[software-protection]:  https://www.preemptive.com/software-protection
[obfuscation]:  https://www.preemptive.com/obfuscation
[app-protection]:  https://www.preemptive.com/application-protection
[sdl-protection]:  https://www.preemptive.com/solutions/SDL-App-Protection
[net-obfuscator]:  https://www.preemptive.com/products/dotfuscator/overview
[download]:  https://www.preemptive.com/products/dotfuscator/downloads

[install]:  install.md
[capabilities]:  capabilities.md
[upgrades]:  upgrades.md

[get-started]:  https://www.preemptive.com/dotfuscator/ce/docs/help/gui_getstarted.html

[renaming]:  https://www.preemptive.com/dotfuscator/ce/docs/help/obfuscation_renaming.html

[checks]:  https://www.preemptive.com/dotfuscator/ce/docs/help/checks_overview.html
[tamper]:  https://www.preemptive.com/dotfuscator/ce/docs/help/checks_tamper.html
[debug]:  https://www.preemptive.com/dotfuscator/ce/docs/help/checks_debug.html
[root]: https://www.preemptive.com/dotfuscator/ce/docs/help/checks_root.html
[shelflife]:  https://www.preemptive.com/dotfuscator/ce/docs/help/checks_shelflife.html

[full]:  https://www.preemptive.com/dotfuscator/ce/docs/help/index.html
