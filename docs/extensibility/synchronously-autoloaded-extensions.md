---
title: "Synchronously autoloaded extensions"
ms.date: "02/16/2019"
ms.topic: "conceptual"
ms.assetid: 822e3cf8-f723-4ff1-8467-e0fb42358a1f
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Synchronously autoloaded extensions

Synchronously autoloaded extensions have a negative impact on the performance of Visual Studio and should be converted to use asynchronous autoload instead. Starting in Visual Studio 2019 Preview 2, users are notified when an extension is being synchronously autoloaded. The extension will load and work as normal.

![extension compatibility warning](media/extension-compatibility-warning.png)

Users can:

- Click on **Learn more** to get to this information page.

- Click on **Manage performance** to open the [Performance Manager dialog](#performance-manager-dialog) that shows performance issues with extensions and tool windows.

- Click on **Don't show this message again** to dismiss the notification. Choosing this option also prevents all future notifications from synchronously autoloaded extensions. Users will continue to get notifications about other Visual Studio features.

## Performance Manager dialog

![performance manager dialog](media/performance-manager.png)

All extensions that synchronously loaded any packages in any user sessions appear in the **Deprecated APIs** tab.

* Users can click on the **More information about this issue** to gather more information about the deprecated APIs.
* Users can contact their extension vendors for the migration progress.

Extension authors can find instructions for migrating packages to asynchronous autoload at [Migrate to AsyncPackage](https://github.com/Microsoft/VSSDK-Extensibility-Samples/tree/master/AsyncPackageMigration).

## Specify synchronous autoload settings using group policy

Starting Visual Studio 2019 Update 1, by default, the Visual Studio installation blocks synchronous autoload. When you enable Group Policy, you can configure Visual Studio to allow synchronous autoload on individual computers. To do so, set a registry-based policy on the following key:

**HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\VisualStudio\SynchronousAutoload**

Entry = **Allowed**

Value = (DWORD)
* **0** is synchronous autoload not allowed
* **1** is synchronous autoload allowed

For more information about synchronous autoload settings in Visual Studio 2019 Update 1, see the [Synchronous Autoload Behavior](https://aka.ms/AA52xzw) page.
