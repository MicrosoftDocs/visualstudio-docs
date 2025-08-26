---
title: Install Visual Studio and Choose Your Preferred Features
titleSuffix: ''
description: Learn how to install Visual Studio quickly. To reduce the installation footprint, choose your preferred features.
ms.date: 08/25/2025
ms.custom: vs-acquisition
ms.topic: install-set-up-deploy
helpviewer_keywords:
- install Visual Studio
- dev15
- dev16
- dev17
- set up Visual Studio
- Visual Studio setup
- Visual Studio installer
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: installation

#customer intent: As a developer, I want to install Visual Studio with the features I will need so that I can control the installation footprint. 
---
# Install Visual Studio

::: moniker range="vs-2019"

In Visual Studio 2019, it's easy to choose and install just the features you need. And because of its reduced minimum footprint, it installs quickly and with less system impact.

::: moniker-end

::: moniker range=">=vs-2022"

In Visual Studio 2022, it's easy to choose and install just the features you need.

::: moniker-end

> [!NOTE]
> If you need to programmatically install Visual Studio, see [Use command-line parameters](use-command-line-parameters-to-install-visual-studio.md).

::: moniker range="vs-2019"

Want to know more about what else is new in this version? See the [release notes](/visualstudio/releases/2019/release-notes/).

::: moniker-end

::: moniker range=">=vs-2022"

Want to know more about what else is new in this version? See the [release notes](/visualstudio/releases/2022/release-notes/).

You can download and install a specific version from the [Visual Studio 2022 Release History](/visualstudio/releases/2022/release-history#release-dates-and-build-numbers) page.

::: moniker-end

Ready to install? This article walks you through the process, step-by-step.

## Step 1 - Make sure your computer is ready for Visual Studio

Before you begin installing Visual Studio:

::: moniker range="vs-2019"

- Check the [system requirements](/visualstudio/releases/2019/system-requirements). These requirements help you determine whether your computer supports Visual Studio 2019.

- Make sure that the user who performs the initial installation has administrator permissions on the machine. For more information, see [User permissions and Visual Studio](/visualstudio/ide/user-permissions-and-visual-studio).

- Apply the latest Windows updates. These updates ensure that your computer has both the latest security updates and the required system components for Visual Studio.

- Restart. Restarting ensures that any pending installations or updates don't hinder your Visual Studio installation.

- Free up space. Remove unneeded files and applications from your system drive by, for example, running the Disk Cleanup utility.

For questions about running other versions of Visual Studio side-by-side with Visual Studio 2019, see [Visual Studio 2019 Platform Targeting and Compatibility](/visualstudio/releases/2019/compatibility/).

::: moniker-end

::: moniker range=">=vs-2022"

- Check the [system requirements](/visualstudio/releases/2022/system-requirements). These requirements help you determine whether your computer supports Visual Studio 2022.

- Make sure that the user who performs the initial installation has administrator permissions on the machine. For more information, see [User permissions and Visual Studio](/visualstudio/ide/user-permissions-and-visual-studio).

- Apply the latest Windows updates. These updates ensure that your computer has both the latest security updates and the required system components for Visual Studio.

- Restart. Restarting ensures that any pending installations or updates don't hinder your Visual Studio installation.

- Free up space. Remove unneeded files and applications from your system drive by, for example, running the Disk Cleanup utility.

You can install Visual Studio 2022 side-by-side with other versions. For more information, see [Visual Studio 2022 platform targeting and compatibility](/visualstudio/releases/2022/compatibility) and [Install Visual Studio versions side-by-side](install-visual-studio-versions-side-by-side.md).

::: moniker-end

## Step 2 - Determine which version and edition of Visual Studio to install

Decide which version and edition of Visual Studio to install. The most common options are:

::: moniker range="vs-2019"

- The latest release of Visual Studio 2019 that's hosted on Microsoft servers. To install this version, select the following button and then choose the edition you want. The installer downloads a small *bootstrapper* to your *Downloads* folder.

  > [!div class="button"]
  > [Download Visual Studio](https://visualstudio.microsoft.com/vs/older-downloads/)

::: moniker-end

::: moniker range=">=vs-2022"

- The latest release of Visual Studio 2022 that's hosted on Microsoft servers. To install this version, select the following button and then choose the edition you want. The installer downloads a small *bootstrapper* to your *Downloads* folder.

  > [!div class="button"]
  > [Download Visual Studio](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-install-visual-studio-page-cta)

::: moniker-end

- If you already have Visual Studio installed, you can [install another version alongside it](/visualstudio/install/install-visual-studio-versions-side-by-side#install-different-editions-within-the-same-major-visual-studio-version-side-by-side) by choosing one that's listed on the **Available** tab of the Visual Studio Installer.

::: moniker range="vs-2019"

- You can download a bootstrapper for a specific version from the [Visual Studio 2019 Release History](/visualstudio/releases/2019/history#installing-an-earlier-release) page and use it to install Visual Studio.

::: moniker-end

::: moniker range=">=vs-2022"

- You can download a bootstrapper for a specific version from the [Visual Studio 2022 Release History](/visualstudio/releases/2022/release-history#release-dates-and-build-numbers) page and use it to install Visual Studio.

::: moniker-end

- Your IT administrator might point you to a specific location from which to install Visual Studio.

## Step 3 - Initiate the installation

If you downloaded a bootstrapper file, you can use it to install Visual Studio. You need administrator permissions. The bootstrapper installs the latest version of the Visual Studio Installer. The installer is a separate program that provides everything you need to both install and customize Visual Studio.

::: moniker range="vs-2019"

1. From your *Downloads* folder, double-click the bootstrapper that matches or is similar to one of the following files:

   - *vs_community.exe* for Visual Studio Community
   - *vs_professional.exe* for Visual Studio Professional
   - *vs_enterprise.exe* for Visual Studio Enterprise

1. If you see a User Account Control notice, select **Yes**. The dialog box asks you to acknowledge the Microsoft [License Terms](https://visualstudio.microsoft.com/license-terms/) and the Microsoft [Privacy Statement](https://privacy.microsoft.com/privacystatement). Select **Continue**.

   :::image type="content" source="media/privacy-and-license-terms.png" alt-text="Screenshot showing the Microsoft License Terms and Privacy Statement.":::

::: moniker-end

::: moniker range=">=vs-2022"

1. From your *Downloads* folder, double-click the bootstrapper named *VisualStudioSetup.exe*, or named something like *vs_community.exe*, to start the installation.

1. If you see a User Account Control notice, select **Yes**. The dialog box asks you to acknowledge the Microsoft [License Terms](https://visualstudio.microsoft.com/license-terms/) and the Microsoft [Privacy Statement](https://privacy.microsoft.com/privacystatement). Select **Continue**.

   :::image type="content" source="../install/media/vs-2022/privacy-and-license-terms.png" alt-text="Screenshot showing the Microsoft License Terms and Privacy Statement.":::

::: moniker-end

Visual Studio Installer opens. You can also install any product that's listed on the [Visual Studio Installer Available tab](install-visual-studio-versions-side-by-side.md#install-different-editions-of-the-same-major-visual-studio-version-side-by-side).

## Step 4 - Choose workloads

After you install the Visual Studio Installer, you can use it to customize your installation by selecting the feature sets, or *workloads*, that you want. Here's how.

::: moniker range="vs-2019"

1. Find the workload that you want in the **Visual Studio Installer**.

   :::image type="content" source="../install/media/vs-2019/vs-installer-workloads.png" alt-text="Screenshot showing the Workloads tab of the Visual Studio Installer." lightbox="../install/media/vs-2019/vs-installer-workloads.png":::

   For example, select the **ASP.NET and web development** workload. It comes with the default core editor. That editor includes basic code editing support for more than 20 languages, the ability to open and edit code from any folder without requiring a project, and integrated source code control.

1. After you choose the workloads that you want, select **Install**.

   Next, a status screen that shows the progress of your Visual Studio installation appears.

::: moniker-end

::: moniker range=">=vs-2022"

1. Select the workload that you want in the **Visual Studio Installer**.

   :::image type="content" source="media/vs-2022/vs-installer-workloads.png" alt-text="Screenshot showing the Workloads tab of the Visual Studio Installer." lightbox="media/vs-2022/vs-installer-workloads.png":::

   Review the workload summaries to decide which workload supports the features you need. For example, choose the **ASP.NET and web development** workload to edit ASP.NET Web pages with Web Live Preview or build responsive web apps with Blazor. You might choose from the **Desktop & Mobile** workloads to develop cross-platform apps with C#, or C++ projects that target C++20.

1. After you choose the workloads that you want, select **Install**.

   Next, a status screen that shows the progress of your Visual Studio installation appears.

::: moniker-end

> [!TIP]
> At any time after installation, you can install workloads or components that you didn't install initially. If you have Visual Studio open, go to **Tools** > **Get Tools and Features**, which opens the Visual Studio Installer. Or open the **Visual Studio Installer** from the **Start** menu. From there, you can choose the workloads or components that you want to install. Then choose **Modify**.

## Step 5 - Choose individual components (optional)

If you don't want to use the Workloads feature to customize your Visual Studio installation, or if you want to add more components than a workload installs, you can install or add individual components from the **Individual components** tab. Choose what you want, and then follow the prompts.

::: moniker range="vs-2019"

  :::image type="content" source="media/vs-2019/vs-installer-individual-components.png" alt-text="Screenshot showing the Individual components tab of the Visual Studio Installer." lightbox="media/vs-2019/vs-installer-individual-components.png":::

::: moniker-end

::: moniker range=">=vs-2022"

  :::image type="content" source="media/vs-2022/vs-installer-individual-components.png" alt-text="Screenshot showing the Individual components tab of the Visual Studio Installer." lightbox="media/vs-2022/vs-installer-individual-components.png":::

::: moniker-end

## Step 6 - Install language packs (optional)

By default, the installer program tries to match the language of the operating system when it runs for the first time. To install Visual Studio in a language that you choose, go to the **Language packs** tab from the Visual Studio Installer, and then follow the prompts.

::: moniker range="vs-2019"

  :::image type="content" source="media/vs-2019/vs-installer-language-packs.png" alt-text="Screenshot showing the Language packs tab of the Visual Studio Installer." lightbox="media/vs-2019/vs-installer-language-packs.png":::

::: moniker-end

::: moniker range=">=vs-2022"

  :::image type="content" source="media/vs-2022/vs-installer-language-packs.png" alt-text="Screenshot showing the Language packs tab of the Visual Studio Installer." lightbox="media/vs-2022/vs-installer-language-packs.png":::

::: moniker-end

### Change the installer language at a command prompt

::: moniker range="<=vs-2019"

You can also change the default language by running the installer at a command prompt. For example, you can force the installer to run in English by using the following command:

  ```cmd
  vs_installer.exe --locale en-US
  ```

The installer retains this setting when you run it again. The installer supports the following language tokens: zh-cn, zh-tw, cs-cz, en-us, es-es, fr-fr, de-de, it-it, ja-jp, ko-kr, pl-pl, pt-br, ru-ru, and tr-tr.

::: moniker-end

::: moniker range=">=vs-2022"

You can also change the default language by running the installer at a command prompt. For example, you can force the installer to run in English by using the following command:

  ```cmd
  vs_installer.exe --locale en-US
  ```

The installer retains this setting when you run it again. The installer supports these [language locales](/visualstudio/install/use-command-line-parameters-to-install-visual-studio?view=vs-2022&preserve-view=true#list-of-language-locales): zh-cn, zh-tw, cs-cz, en-us, es-es, fr-fr, de-de, it-it, ja-jp, ko-kr, pl-pl, pt-br, ru-ru, and tr-tr.

::: moniker-end

## Step 7 - Select the installation location (optional)

You can reduce the installation footprint of Visual Studio on your system drive. For more information, see [Select installation locations](change-installation-locations.md).

::: moniker range="vs-2019"

:::image type="content" source="media/vs-2019/vs-installer-installation-locations.png" alt-text="Screenshot showing the Installation locations tab of the Visual Studio Installer." lightbox="media/vs-2019/vs-installer-installation-locations.png":::

::: moniker-end

::: moniker range=">=vs-2022"

  :::image type="content" source="media/vs-2022/vs-installer-installation-locations.png" alt-text="Screenshot showing the Installation locations tab of the Visual Studio Installer." lightbox="media/vs-2022/vs-installer-installation-locations.png":::

::: moniker-end

> [!IMPORTANT]
> You can select a different drive for the **Visual Studio IDE** or the **Download cache** only when you first install Visual Studio. If you already installed it and want to change drives, you must uninstall Visual Studio and then reinstall it.
>
> If you installed Visual Studio on your computer before, you won't be able to change the **Shared components, tools, and SDKs** path. It appears dimmed. This location is shared by all installations of Visual Studio.

## Step 8 - Sign in to your account (optional)

Although you don't have to sign in, there are many [advantages](../ide/signing-in-to-visual-studio.md#benefits-why-sign-in) to doing so.

You can evaluate a free trial of [Visual Studio Professional or Visual Studio Enterprise](https://visualstudio.microsoft.com/vs/compare/) for 30 days. If you sign in, you can extend the trial period to 90 days. The 90-day trial extension works only one time. To continue using Visual Studio after a trial period ends, unlock it with an [online subscription](../ide/how-to-unlock-visual-studio.md#use-an-online-subscription) or a [product key](../ide/how-to-unlock-visual-studio.md#enter-a-product-key).

Visual Studio Community doesn't require you to sign in. However, if the installation prompts you to sign in periodically, [sign in](../ide/signing-in-to-visual-studio.md) to continue using Visual Studio Community without interruptions.

## Step 9 - Start developing

After your installation is complete, you can get started developing with Visual Studio.

::: moniker range="vs-2019"

1. Select the **Launch** button.

1. In the start window, select **Create a new project**.

1. In the search box, enter the type of app you want to create to see a list of available templates. The list of templates depends on the workloads that you chose during installation. To see different templates, choose different workloads.

   You can also filter your search for a specific programming language by using the language dropdown list. The platform list and the project type list also provide filters.

1. Select **Next**. Provide information in the following dialogs, and then select **Create**.

Visual Studio opens your new project, and you're ready to code!

::: moniker-end

::: moniker range=">=vs-2022"

1. Select the **Launch** button.

1. In the start window, select **Create a new project**.

1. In the template search box, enter the type of app you want to create to see a list of available templates. The list of templates depends on the workloads that you chose during installation. To see different templates, choose different workloads.

   You can also filter your search for a specific programming language by using the **All languages** dropdown list. You can filter by using the **All platforms** list and the **All project types** list, too.

1. Select **Next**. Provide information in the following dialogs, and then select **Create**.

Visual Studio opens your new project, and you're ready to code!

::: moniker-end

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## Related content

- [Update Visual Studio](update-visual-studio.md)
- [Modify Visual Studio](modify-visual-studio.md)
- [Uninstall Visual Studio](uninstall-visual-studio.md)
- [Create an offline installation of Visual Studio](create-an-offline-installation-of-visual-studio.md)
- [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
