---
title: Capabilities of Dotfuscator
ms.date: 10/10/2017
ms.devlang: "dotnet"
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: conceptual
keywords: Dotfuscator, Dotfuscator CE, PreEmptive, PreEmptive Solutions, PreEmptive Protection, protection, community edition, obfuscation, .NET, free, Visual Studio 2017
helpviewer_keywords:
  - "PreEmptive Protection Dotfuscator"
  - "Dotfuscator Community Edition"
  - "Dotfuscator CE"
  - "Dotfuscator"
  - "obfuscation"
  - "protection"
description: "Learn the capabilities of the free Dotfuscator Community Edition included in Visual Studio 2017."
ms.assetid: 0ee89c58-c900-48fc-a6a2-65ace00e8bab
author: "Joe-Sewell-PreEmptive"
ms.author: gewarren
manager: douge
---
# Capabilities of Dotfuscator

This page focuses on the capabilities of Dotfuscator Community Edition (Dotfuscator CE) with some references to advanced options available through [upgrades][upgrades].

Dotfuscator is a *post-build* system for .NET applications.
With Dotfuscator CE, Visual Studio users are able to [obfuscate assemblies][obfuscation] and inject [active defense][checks] and [analytics tracking][analytics] into the application - all without Dotfuscator needing to access the original source code.
Dotfuscator protects your application in multiple ways, creating a layered protection strategy.

Dotfuscator CE supports a wide range of .NET assembly and application types, including [Universal Windows Platform (UWP)][uwp] and [Xamarin][xamarin].

## Intellectual Property Protection

Your application's design, behavior, and implementation are forms of intellectual property (IP).
However, applications created for the .NET Framework are essentially open books; it's very easy to reverse engineer .NET assemblies, [as they contain high-level metadata and intermediate code][assemblies].

Dotfuscator CE includes basic [.NET obfuscation][obfuscation] in the form of [renaming][renaming].
Obfuscating your code with Dotfuscator reduces the risk of unauthorized access to source code through reverse engineering, as important naming information will no longer be public.
Obfuscation also shows effort on your part to protect your code from examination - a valuable step in establishing that your IP is legally protected as trade secret.

Many of the [application integrity protection features](#application-integrity-protection) of Dotfuscator CE further hinder reverse engineering.
For instance, a bad actor may attempt to attach a debugger to a running instance of your application in order to understand the program logic.
Dotfuscator can inject [anti-debug behavior][debug] into your application to obstruct this.

## Application Integrity Protection

In addition to protecting your source code, it's also important to ensure your application is used as designed.
Attackers can attempt to hijack your application in order to circumvent licensing policies (i.e., software piracy), to steal or manipulate sensitive data handled by the application, or to change the behavior of the application.

Dotfuscator CE can inject [application validation code][checks] into your assemblies,
including [anti-tamper][tamper], [anti-debug][debug], and [anti-rooted device][root] measures.
When an invalid application state is detected, the validation code can [call upon application code to address to the situation in an appropriate way][check-app].
Or, if you prefer not to write code to handle invalid uses of the application, Dotfuscator can also inject [telemetry reporting][check-telemetry] and [response][check-action] behaviors, without requiring any modification to your source code.

Many of these same methods may also be used to enforce [end-of-life deadlines][shelflife] for evaluation or trial software.

## Application Monitoring

When developing an application, it is critical to understand the behavior patterns of users, including beta testers and users of prior versions.
Application analytics allows you to track how frequently the application is used and how it is used, including what errors customers experience.

Dotfuscator CE can inject [exception-tracking][exceptions], [session-tracking][sessions], and [feature-tracking][features] code into your application.
When run, the processed application will transmit analytics data to a configured [PreEmptive Analytics endpoint][endpoints].

## See Also

[This topic in the full Dotfuscator CE User Guide][full]

<!-- Copyright © 2017 PreEmptive Solutions, LLC -->

[assemblies]:  https://docs.microsoft.com/en-us/dotnet/standard/assembly-format
[uwp]:  https://www.preemptive.com/blog/article/856-uwp-applications-in-dotfuscator-ce/91-dotfuscator-ce
[xamarin]:  https://www.preemptive.com/obfuscating-xamarin-with-dotfuscator

[upgrades]:  upgrades.md

[obfuscation]:  https://www.preemptive.com/dotfuscator/ce/docs/help/obfuscation_overview.html
[renaming]:  https://www.preemptive.com/dotfuscator/ce/docs/help/obfuscation_renaming.html

[analytics]:  https://www.preemptive.com/dotfuscator/ce/docs/help/instrumentation_overview.html
[endpoints]:  https://www.preemptive.com/dotfuscator/ce/docs/help/instrumentation_overview.html#endpoints

[checks]:  https://www.preemptive.com/dotfuscator/ce/docs/help/checks_overview.html
[check-app]:  https://www.preemptive.com/dotfuscator/ce/docs/help/checks_overview.html#app-notification
[check-action]:  https://www.preemptive.com/dotfuscator/ce/docs/help/checks_overview.html#action

[tamper]:  https://www.preemptive.com/dotfuscator/ce/docs/help/checks_tamper.html
[debug]:  https://www.preemptive.com/dotfuscator/ce/docs/help/checks_debug.html
[root]: https://www.preemptive.com/dotfuscator/ce/docs/help/checks_root.html
[shelflife]:  https://www.preemptive.com/dotfuscator/ce/docs/help/checks_shelflife.html
[exceptions]:  https://www.preemptive.com/dotfuscator/ce/docs/help/instrumentation_exceptions.html
[sessions]:  https://www.preemptive.com/dotfuscator/ce/docs/help/instrumentation_sessions.html
[features]:  https://www.preemptive.com/dotfuscator/ce/docs/help/instrumentation_features.html
[check-telemetry]:  https://www.preemptive.com/dotfuscator/ce/docs/help/instrumentation_checks.html

[full]:  https://www.preemptive.com/dotfuscator/ce/docs/help/intro_capabilities.html