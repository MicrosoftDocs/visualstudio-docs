---
title: "ClickOnce and Application Settings"
description: Learn how application settings files work in a ClickOnce application and how ClickOnce migrates settings when the user upgrades to the next version.
ms.date: "08/03/2022"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "ClickOnce deployment, application settings"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# ClickOnce and application settings

Application settings for Windows Forms makes it easy to create, store, and maintain custom application and user preferences on the client. The following document describes how application settings files work in a ClickOnce application, and how ClickOnce migrates settings when the user upgrades to the next version.

 The information below applies only to the default application settings provider, the <xref:System.Configuration.LocalFileSettingsProvider> class. If you supply a custom provider, that provider will determine how it stores its data and how it upgrades its settings between versions. For more information on application settings providers, see [Application settings architecture](/dotnet/framework/winforms/advanced/application-settings-architecture).

## Application settings files

 Application settings consumes two files: *\<app>.exe.config* and *user.config*, where *app* is the name of your Windows Forms application. *user.config* is created on the client the first time your application stores user-scoped settings. *\<app>.exe.config*, by contrast, will exist prior to deployment if you define default values for settings. Visual Studio will include this file automatically when you use its **Publish** command. If you create your ClickOnce application using *Mage.exe* or *MageUI.exe*, you must make sure this file is included with your application's other files when you populate your application manifest.

 [!INCLUDE[ndptecclick](../deployment/includes/dotnet-dotnetmage-exe.md)]

 In a Windows Forms application not deployed using ClickOnce, an application's *\<app>.exe.config* file is stored in the application directory, while the *user.config* file is stored in the user's **Documents and Settings** folder. In a ClickOnce application, *\<app>.exe.config* lives in the application directory inside of the ClickOnce application cache, and *user.config* lives in the ClickOnce data directory for that application.

 Regardless of how you deploy your application, application settings ensures safe read access to *\<app>.exe.config*, and safe read/write access to *user.config*.

 In a ClickOnce application, the size of the configuration files used by application settings is constrained by the size of the ClickOnce cache. For more information, see [ClickOnce cache overview](../deployment/clickonce-cache-overview.md).

## .NET Core and .NET 5+

Currently, a .NET Core assembly to be published needs to be signed with a strong name key file. If it isn't, `ApplicationSettingsBase.Upgrade` method does not copy settings correctly after a new ClickOnce publish. You can specify use of a strong name in the .NET Core project's properties, under the **Build > Strong naming** option.

## Version upgrades

 Just as each version of a ClickOnce application is isolated from all other versions, the application settings for a ClickOnce application are isolated from the settings for other versions as well. When your user upgrades to a later version of your application, application settings compares most recent (highest-numbered) version's settings against the settings supplied with the updated version and merges the settings into a new set of settings files.

 The following table describes how application settings decides which settings to copy.

|Type of Change|Upgrade Action|
|--------------------|--------------------|
|Setting added to *\<app>.exe.config*|The new setting is merged into the current version's *\<app>.exe.config*|
|Setting removed from *\<app>.exe.config*|The old setting is removed from the current version's *\<app>.exe.config*|
|Setting's default changed; local setting still set to original default in *user.config*|The setting is merged into the current version's *user.config* with the new default as the value|
|Setting's default changed; setting set to non-default in *user.config*|The setting is merged into the current version's *user.config* with the non-default value retained|

If you have created your own application settings wrapper class and wish to customize the update logic, you can override the <xref:System.Configuration.ApplicationSettingsBase.Upgrade%2A> method.

## ClickOnce and roaming settings

 ClickOnce does not work with roaming settings, which allows your settings file to follow you across machines on a network. If you need roaming settings, you will need either to implement an application settings provider that stores settings over the network, or develop your own custom settings classes for storing settings on a remote computer. For more information in settings providers, see [Application settings architecture](/dotnet/framework/winforms/advanced/application-settings-architecture).

## Related content

- [ClickOnce security and deployment](../deployment/clickonce-security-and-deployment.md)
- [Application settings overview](/dotnet/framework/winforms/advanced/application-settings-overview)
- [ClickOnce cache overview](../deployment/clickonce-cache-overview.md)
- [Access local and remote data in ClickOnce applications](../deployment/accessing-local-and-remote-data-in-clickonce-applications.md)
