---
title: Install Dotfuscator Community
ms.date: 03/28/2019
ms.devlang: "dotnet"
ms.topic: conceptual
keywords: Dotfuscator, Dotfuscator Community, Dotfuscator CE, PreEmptive, PreEmptive Solutions, PreEmptive Protection, protection, community edition, obfuscation, .NET, free, Visual Studio 2017, Visual Studio 2019, Visual Studio, install
helpviewer_keywords:
  - "PreEmptive Protection Dotfuscator"
  - "Dotfuscator Community Edition"
  - "Dotfuscator CE"
  - "Dotfuscator Community"
  - "Dotfuscator"
  - "obfuscation"
  - "protection"
  - "Dotfuscator installer"
  - "Dotfuscator setup"
  - "install Dotfuscator"
  - "installing Dotfuscator"
  - "set up Dotfuscator"
description: "Learn how to install the free copy of Dotfuscator Community included in Visual Studio."
ms.assetid: f2146651-e24a-4e24-ade8-8ddee8ff4e43
author: "Joe-Sewell-PreEmptive"
ms.author: jillfra
manager: jillfra
---
# Install Dotfuscator Community

Dotfuscator Community is an optional component of Visual Studio.
These instructions explain how to install it.

> [!NOTE]
> In addition to the versions of Dotfuscator Community shipped with releases of Visual Studio,
> PreEmptive Solutions also periodically provides updated versions on its website.
> If you want to download the **latest version** directly instead of installing from Visual Studio,
> **[click here to go to the Dotfuscator Downloads page][download]**.

## Within Visual Studio

::: moniker range="vs-2019"

You can install Dotfuscator Community from the Visual Studio IDE:

1. In the **Search Box** (Ctrl+Q), type `dotfuscator`. <br/> <br/> ![Search Box](media/install_in_vs19_12.png) <br/> <br/>

2. In the search results shown, under the *Components* heading, select **Install PreEmptive Protection - Dotfuscator**.
   * If you instead see, under the *Menus* heading, **PreEmptive Protection - Dotfuscator Community**, then Dotfuscator Community is already installed. Select that option to [get started][get-started].

3. A Visual Studio Installer window will launch, pre-configured to install Dotfuscator Community.
   > [!NOTE]
   > You may be required to provide administrator credentials to continue.

4. In the Visual Studio Installer window, click *Install*. <br/> <br/> ![Click Install](media/install_in_vs19_34.png) <br/> <br/>

::: moniker-end

::: moniker range="vs-2017"

You can install Dotfuscator Community from the Visual Studio IDE:

1. In the **Quick Launch** (Ctrl+Q) search bar, type `dotfuscator`. <br/> <br/> ![Quick Launch](media/install_from_vs_12.png) <br/> <br/>

2. In the Quick Launch results shown, under the *Install* heading, select **PreEmptive Protection - Dotfuscator (Individual Component)**.
   * If you instead see, under the *Menus* heading, **Tools - PreEmptive Protection - Dotfuscator**, then Dotfuscator CE is already installed. Select that option to [get started][get-started].

3. A Visual Studio Installer window will launch, pre-configured to install Dotfuscator CE.
   > [!NOTE]
   > You may be required to provide administrator credentials to continue.

4. In the Visual Studio Installer window, click *Install*. <br/> <br/> ![Click Install](media/install_from_vs_345.png) <br/> <br/>

::: moniker-end

Once the installation is complete, you can [start using Dotfuscator Community][get-started].

## During Visual Studio Installation

If you have not yet installed Visual Studio, you can obtain the installer from [the Visual Studio website][vs-install].
When run, it will display installation options for the selected Visual Studio edition.

::: moniker range="vs-2019"

![Install options](media/install_ui.png)

::: moniker-end

::: moniker range="vs-2017"

![Install options](media/install_ui_17.png)

::: moniker-end

You can then install Dotfuscator Community as an individual component of Visual Studio:

1. Select the **Individual components** tab.
2. Under *Code tools*, check the *PreEmptive Protection - Dotfuscator* item.<br/> <br/> ![Individual components](media/install_individually_12.png) <br/> <br/>
3. The *Summary* panel displays *PreEmptive Protection - Dotfuscator* under the *Individual Components* section. <br/> <br/> ![Summary pane](media/install_individually_3.png) <br/> <br/>
4. Configure any further installation settings as appropriate for your environment.
5. When ready to install Visual Studio, click the *Install* button.

Once the installation is complete, you can start using Dotfuscator Community. For details, see [the Getting Started page of the full Dotfuscator Community User Guide][get-started].

## See also

[This topic in the full Dotfuscator Community User Guide](https://www.preemptive.com/dotfuscator/ce/docs/help/)

<!-- Copyright © 2019 PreEmptive Solutions, LLC -->

[vs-install]:  https://visualstudio.microsoft.com/downloads/
[get-started]:  https://www.preemptive.com/dotfuscator/ce/docs/help/gui_getstarted.html

[download]:  https://www.preemptive.com/products/dotfuscator/downloads

[full]:  https://www.preemptive.com/dotfuscator/ce/docs/help/intro_install.html