---
title: Upgrade Dotfuscator Community
ms.date: 03/28/2019
ms.devlang: "dotnet"
ms.topic: conceptual
keywords: Dotfuscator, Dotfuscator Community, Dotfuscator CE, PreEmptive, PreEmptive Solutions, PreEmptive Protection, protection, community edition, obfuscation, .NET, free, Visual Studio 2019, Visual Studio 2017, Visual Studio, upgrade, command line
helpviewer_keywords:
  - "PreEmptive Protection Dotfuscator"
  - "Dotfuscator Community Edition"
  - "Dotfuscator CE"
  - "Dotfuscator Community"
  - "Dotfuscator"
  - "obfuscation"
  - "protection"
  - "Dotfuscator upgrade"
  - "upgrade Dotfuscator"
  - "upgrading Dotfuscator"
  - "register Dotfuscator"
  - "registering Dotfuscator"
  - "Dotfuscator command line"
  - "Dotfuscator Professional"
description: "Learn how to upgrade the free copy of Dotfuscator Community included in Visual Studio."
ms.assetid: c7c60904-27f9-4f1f-b79b-ddf65041b810
author: "Joe-Sewell-PreEmptive"
ms.author: jillfra
manager: jillfra
---
# Upgrade Dotfuscator Community

Dotfuscator Community offers many application protection and hardening features immediately to all developers using Microsoft Visual Studio.
However, there are more features available to users who upgrade their version of Dotfuscator.

## Registering Dotfuscator Community

Registered users of Dotfuscator Community get access to additional features, such as [command-line support][cli], which makes it easy to integrate Dotfuscator Community into your automated build process. Registering also grants access to a built-in tool used for [decoding obfuscated stack traces][decode-obfuscated].

Registration is quick, simple, and free of charge.
To register Dotfuscator Community, see [the instructions in the full Dotfuscator Community User Guide][register-ce].

## Dotfuscator Professional

While Dotfuscator Community provides a basic level of protection, ***PreEmptive Protection - Dotfuscator Professional*** includes enhanced obfuscation transforms and protection capabilities such as:

* *Intellectual Property Protection*
  * Additional renaming options, including Enhanced Overload Induction™ and randomized identifier selection.
  * Access to enterprise-level obfuscation transforms, including [transforms targeted at defeating automated code decompilation][control-flow].
  * The ability to [obscure sensitive strings][string-encryption], making a simple search of the decompiled code impossible.
  * The ability to [discreetly embed ownership and distribution strings into your assemblies][watermarking], allowing you to determine the source of unauthorized software leaks.
  * The ability to [combine multiple assemblies into one][linking], making it even more difficult for attackers to determine the roles of code elements, as separation of concerns has been eliminated.
  * The ability to [automatically remove unused code from your application][pruning], reducing the amount of sensitive code that is shipped.
* *Application Integrity Protection*
  * Additional [application defense behaviors][check-actions].
  * The ability to provide a warning period before an application's end-of-life deadline.
  * The ability to notify application code during an end-of-life warning period or after the deadline.

Dotfuscator Professional is the industry standard [.NET Obfuscator][net-obfuscator] and is suitable for enterprise developers requiring ongoing support, maintenance, and product updates.
Additionally, Dotfuscator Professional offers tighter integration with Visual Studio and is licensed for commercial use.

For more information about the advanced application protection features of Dotfuscator Professional, visit PreEmptive Solutions' [Dotfuscator Overview page][product-about] and [compare it to Dotfuscator Community][product-compare].
[Fully supported trials are available at preemptive.com][eval].

## See also

[This article in the full Dotfuscator Community User Guide][full]

<!-- Copyright © 2019 PreEmptive Solutions, LLC -->

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