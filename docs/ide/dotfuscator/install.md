---
title: "Install Dotfuscator Community Edition (CE) | Microsoft Docs"
ms.date: "2017-06-22"
ms.devlang: "dotnet"
ms.technology: 
  - "vs-ide-general"
ms.topic: "article"
keywords: Dotfuscator, Dotfuscator CE, PreEmptive, PreEmptive Solutions, PreEmptive Protection, protection, community edition, obfuscation, .NET, free, Visual Studio 2017, install
helpviewer_keywords: 
  - "PreEmptive Protection Dotfuscator"
  - "Dotfuscator Community Edition"
  - "Dotfuscator CE"
  - "Dotfuscator"
  - "obfuscation"
  - "protection"
  - "Dotfuscator installer"
  - "Dotfuscator setup"
  - "install Dotfuscator"
  - "installing Dotfuscator"
  - "set up Dotfuscator"
description: "Learn how to install the free Dotfuscator Community Edition included in Visual Studio 2017."
ms.assetid: f2146651-e24a-4e24-ade8-8ddee8ff4e43
author: "Joe-Sewell-PreEmptive"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---

# Install Dotfuscator Community Edition (CE)

Visual Studio 2017 introduces a new low-impact installation experience.
As a result, Dotfuscator Community Edition (Dotfuscator CE) is not installed by default.
However, it is easy to install Dotfuscator CE even if you have already installed Visual Studio.

> [!NOTE]
> In addition to the versions of Dotfuscator CE shipped with releases of Visual Studio,
> PreEmptive Solutions also periodically provides updated versions on its website.
> If you want to download the **latest version** directly instead of installing from Visual Studio,
> **[click here to go to the Dotfuscator Downloads page][download]**.

## Within Visual Studio

You can install Dotfuscator CE from the Visual Studio IDE:

1. In the **Quick Launch** (Ctrl+Q) search bar, type `dotfuscator`. <br/> <br/> ![](media/install_from_vs_12.png) <br/> <br/>
2. In the Quick Launch results shown, under the *Install* heading, select **PreEmptive Protection - Dotfuscator (Individual Component)**.
  * If you instead see, under the *Menus* heading, **Tools - PreEmptive Protection - Dotfuscator**, then Dotfuscator CE is already installed. For usage details, see [the Getting Started page of the full Dotfuscator CE User Guide][get-started].
3. A Visual Studio Installer window will launch, pre-configured with to install Dotfuscator CE.
  * You may be required to provide administrator credentials to continue.
4. Close all instances of the Visual Studio IDE. <br/> <br/> ![](media/install_from_vs_345.png) <br/> <br/>
5. In the Visual Studio Installer window, click *Install*.

Once the installation is complete, you can start using Dotfuscator CE. For details, see [the Getting Started page of the full Dotfuscator CE User Guide][get-started].

## During Visual Studio Installation

If you have not yet installed Visual Studio 2017, you can obtain the installer from [the Visual Studio website][2017-install].
When run, it will display installation options for the selected Visual Studio edition.

![](media/install_ui.png)

You can then install Dotfuscator CE as an individual component of Visual Studio 2017:

1. Select the **Individual components** tab.
2. Under *Code tools*, check the *PreEmptive Protection - Dotfuscator* item.<br/> <br/> ![](media/install_individually_12.png) <br/> <br/>
3. The *Summary* panel displays *PreEmptive Protection - Dotfuscator* under the *Individual Components* section. <br/> <br/> ![](media/install_individually_3.png) <br/> <br/>
4. Configure any further installation settings as appropriate for your environment.
5. When ready to install Visual Studio, click the *Install* button.

Once the installation is complete, you can start using Dotfuscator CE. For details, see [the Getting Started page of the full Dotfuscator CE User Guide][get-started].

## See Also

[This topic in the full Dotfuscator CE User Guide][full]

<!-- Copyright © 2017 PreEmptive Solutions, LLC -->

[2017-install]: https://www.visualstudio.com/downloads/#vs-2017
[get-started]: https://www.preemptive.com/dotfuscator/ce/docs/help/gui_getstarted.html

[download]: https://www.preemptive.com/products/dotfuscator/downloads

[full]: https://www.preemptive.com/dotfuscator/ce/docs/help/intro_install.html
