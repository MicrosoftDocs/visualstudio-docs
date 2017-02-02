---
title: "Dotfuscator Community Edition | Microsoft Docs"
description: "Learn how you can protect your .NET applications with the free Dotfuscator Community Edition included in Visual Studio 2017."
keywords: "dotfuscator ce preemptive protection community edition" 
author: "Joe-K-Sewell"

ms.devlang: "dotnet"

ms.date: "2017-02-01"
ms.topic: "article"
ms.prod: "visual-studio-dev15"

ms.assetid: d9550502-0a82-49a6-b005-2caa791fbe02

---

# PreEmptive Protection - Dotfuscator Community Edition (CE)

*PreEmptive Protection – Dotfuscator* provides comprehensive .NET application protection that easily fits into your secure software development lifecycle. 
Use it to harden, protect, and prune desktop, mobile, server, and embedded applications to help secure trade secrets and other intellectual property (IP), reduce piracy and counterfeiting, and protect against tampering and unauthorized debugging.
Dotfuscator works on compiled assemblies without the need for additional programming or even access to source code.

## Why Protection Matters

It's important to **protect your intellectual property** (IP).
Your application's code contains design and implementation details which can be considered IP.
However, applications built on the .NET Framework [contain significant metadata and high-level intermediate code][assemblies], making them very easy to reverse engineer, just by using one of many free, automated tools.
By disrupting and stopping reverse-engineering, you can prevent unauthorized IP disclosure, as well as demonstrate that your code contains trade secrets.
Dotfuscator can [obfuscate][obfuscation] your .NET assemblies to hinder reverse-engineering, while maintaining original application behavior.

It's also important to **protect the integrity of your application**.
In addition to reverse-engineering, bad actors may attempt to pirate your application, alter the application's behavior at runtime, or manipulate data.
Dotfuscator can inject your application with the capability to [detect, report, and respond to unauthorized uses][checks], including tampering and third-party debugging.

For more information on how Dotfuscator fits into a secure software development lifecycle, see PreEmptive Solutions' [SDL App Protection page][sdl-protection].

## About Dotfuscator CE

Your copy of Microsoft Visual Studio 2017 includes a free license for ***PreEmptive Protection - Dotfuscator* Community Edition**, also known as Dotfuscator CE.
For instructions on how to install the version of Dotfuscator CE included with Visual Studio 2017, see the [Installation page][install].

Dotfuscator CE offers a range of [software protection and hardening][software-protection] services for developers, architects and testers. 
Examples of [.NET Obfuscation][obfuscation] and other [Application Protection][app-protection] features included in Dotfuscator CE are:

* *[Renaming][renaming]* of identifiers to make reverse-engineering of the compiled assemblies more difficult.
* *[Anti-tamper][tamper]* to detect the execution of tampered applications, transmit incident alerts, and terminate tampered sessions.
* *[Anti-debug][debug]* to detect the attachment of a debugger to a running application, transmit incident alerts, and terminate debugged sessions.
* *[Application expiration behaviors][shelflife]* that encode an "end-of-life" date, transmit alerts when applications are executed after their expiration date, and terminate expired application sessions.
* *[Exception tracking][exceptions]* to monitor unhandled exceptions occurring within the application.
* *[Session][sessions] and [feature][features] usage tracking* to determine what applications have been executed, what versions of those applications, and what features are used in those applications.

For details on these features, including how they fit into your application protection strategy, see the [Capabilities page][capabilities].

Dotfuscator CE offers basic protection out-of-the-box.
Even more application protection measures are available to registered users of Dotfuscator CE, 
and to users of *PreEmptive Protection - Dotfuscator* Professional Edition, the world's leading [.NET Obfuscator][net-obfuscator].
For information about enhancing Dotfuscator, see the [Upgrades page][upgrades].

## Full Documentation

This page and its sub-pages provide a high-level overview of Dotfuscator CE's features, as well as [instructions for installing the tool][install].

Please see [the full Dotfuscator CE User Guide at preemptive.com][full] for detailed usage instructions, including [how to start using the Dotfuscator CE user interface][getstarted].

[assemblies]: https://msdn.microsoft.com/en-us/library/zst29sk2.aspx
[software-protection]: https://www.preemptive.com/software-protection
[obfuscation]: https://www.preemptive.com/obfuscation
[app-protection]: https://www.preemptive.com/application-protection
[sdl-protection]: https://www.preemptive.com/solutions/SDL-App-Protection
[net-obfuscator]: https://www.preemptive.com/products/dotfuscator/overview

[install]: install.md
[capabilities]: capabilities.md
[upgrades]: upgrades.md

[full]: https://www.preemptive.com/dotfuscator/ce/docs/help/5.27/index.html

[getstarted]: https://www.preemptive.com/dotfuscator/ce/docs/help/5.27/gui_getstarted.html

[renaming]: https://www.preemptive.com/dotfuscator/ce/docs/help/5.27/obfuscation_renaming.html

[checks]: https://www.preemptive.com/dotfuscator/ce/docs/help/5.27/checks_overview.html
[tamper]: https://www.preemptive.com/dotfuscator/ce/docs/help/5.27/checks_tamper.html
[debug]: https://www.preemptive.com/dotfuscator/ce/docs/help/5.27/checks_debug.html
[shelflife]: https://www.preemptive.com/dotfuscator/ce/docs/help/5.27/checks_shelflife.html

[exceptions]: https://www.preemptive.com/dotfuscator/ce/docs/help/5.27/analytics_exceptions.html
[sessions]: https://www.preemptive.com/dotfuscator/ce/docs/help/5.27/analytics_sessions.html
[features]: https://www.preemptive.com/dotfuscator/ce/docs/help/5.27/analytics_features.html