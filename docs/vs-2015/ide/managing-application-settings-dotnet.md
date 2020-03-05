---
title: "Managing Application Settings (.NET) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "msvse_settingsdesigner.err.nameblank"
helpviewer_keywords:
  - "application settings [Visual Studio]"
ms.assetid: 35254321-ad14-47d9-b8c6-39ab3203c5d9
caps.latest.revision: 27
author: jillre
ms.author: jillfra
manager: jillfra
---
# Managing Application Settings (.NET)

[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Application settings enable you to store application information dynamically. Settings allow you to store information on the client computer that should not be included in the application code (for example a connection string), user preferences and other information you need at runtime.

Application settings replace the dynamic properties used in earlier versions of Visual Studio.

Each application setting must have a unique name. The name can be any combination of letters, numbers, or an underscore that does not start with a number, and it cannot contain spaces. The name can be changed through the `Name` property.

Application settings can be stored as any data type that can be serialized to XML or has a `TypeConverter` that implements `ToString`/`FromString`. The most common types are `String`, `Integer`, and `Boolean`, but you can also store values as <xref:System.Drawing.Color>, <xref:System.Object>, or as a connection string.

Application settings also contain a value. The value is set with the **Value** property and must match the data type of the setting.

In addition, application settings can be bound to a property of a form or control at design time.

There are two types of application settings, based on scope:

- Application-scoped settings can be used for information such as a URL for a Web service or a database connection string. These values are associated with the application. Therefore, users cannot change them at run time.

- User-scoped settings can be used for information such as persisting the last position of a form or a font preference. Users can change these values at run time.

  You can change the type of a setting by using the **Scope** property.

  The project system stores application settings in two XML files: an app.config file, which is created at design time when you create the first application setting; and a user.config file, which is created at run time when the user who runs the application changes the value of any user setting. Notice that changes in user settings are not written to disk unless the application specifically calls a method to do this.

## Creating Application Settings at Design Time

At design time, you can create application settings in two ways: by using the **Settings** page of the **Project Designer**, or by using the **Properties** window for a form or control, which allows you to bind a setting to a property.

When you create an application-scoped setting (for example, a database connection string, or a reference to server resources), [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] saves it in app.config with the `<applicationSettings>` tag. (Connection strings are saved under the `<connectionStrings>` tag.)

When you create a user-scoped setting (for example, default font, home page, or window size), [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] saves it in app.config with the `<userSettings>` tag.

> [!IMPORTANT]
> When you store connection strings in app.config, you should take precautions to avoid revealing sensitive information, such as passwords or server paths, in the connection string.
>
> If you take connection string information from an external source, such as a user supplying a user ID and password, you must be careful to ensure that the values that you use to construct your connection string do not contain additional connection string parameters that change the behavior of your connection.
>
> Consider using the Protected Configuration feature to encrypt sensitive information in the configuration file. See [Protecting Connection Information](https://msdn.microsoft.com/library/1471f580-bcd4-4046-bdaf-d2541ecda2f4) for more information.

> [!NOTE]
> Because there is no configuration file model for class libraries, application settings do not apply for Class Library projects. The exception is a Visual Studio Tools for Office DLL project, which can have a configuration file.

## Using Customized Settings Files

You can add customized settings files to your project for convenient management of groups of settings. Settings that are contained in a single file are loaded and saved as a unit. Therefore, being able to store settings in separate files for frequently-used and infrequently-used groups can save time in loading and saving settings.

For example, you can add a file such as SpecialSettings.settings to your project. While your `SpecialSettings` class is not exposed in the `My` namespace, **View Code** can read the custom settings file that contains `Partial Class SpecialSettings`.

The Settings Designer first searches for the Settings.settings file that the project system creates; this is the default file that the Project Designer displays in the **Settings** tab. Settings.settings is located in the My Project folder for [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] projects and in the Properties folder for [!INCLUDE[csprcs](../includes/csprcs-md.md)] projects. The Project Designer then searches for other settings files in the project's root folder. Therefore, you should put your custom settings file there. If you add a .settings file elsewhere in your project, the Project Designer will not be able to locate it.

## Accessing or Changing Application Settings at Run Time in Visual Basic

In [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] projects, you can access application settings at run time by using the `My.Settings` object. On the **Settings** page, click the **View code** button to view the Settings.vb file. Settings.vb defines the `Settings` class, which enables you to handle these events on the settings class: <xref:System.Configuration.ApplicationSettingsBase.SettingChanging>, <xref:System.Configuration.ApplicationSettingsBase.PropertyChanged>, <xref:System.Configuration.ApplicationSettingsBase.SettingsLoaded>, and <xref:System.Configuration.ApplicationSettingsBase.SettingsSaving>. Notice that the `Settings` class in Settings.vb is a partial class that displays only the user-owned code, not the whole generated class. For more information about accessing application settings by using the `My.Settings` object, see [Accessing Application Settings](https://msdn.microsoft.com/library/e38d0cc7-247a-46ca-ba04-f2913f0adb2e).

The values of any user-scoped settings that the user changes at run time (for example, the position of a form) are stored in a user.config file. Notice that the default values are still saved in app.config.

If you have changed any user-scoped settings during run time, for example in testing the application, and want to reset these settings to their default values, click the **Synchronize** button.

We strongly recommend that you use the `My.Settings` object and the default .settings file to access settings. This is because you can use the Settings Designer to assign properties to settings, and, additionally, user settings are automatically saved before application shutdown. However, your [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] application can access settings directly. In that case you have to access the `MySettings` class and use a custom .settings file in the root of the project. You must also save the user settings before ending the application, as you would do for a C# application; this is described in the following section.

<!-- markdownlint-disable MD003 MD020 -->
## Accessing or Changing Application Settings at Run Time in Visual C#
<!-- markdownlint-enable MD003 MD020 -->

In languages other than [!INCLUDE[vbprvb](../includes/vbprvb-md.md)], such as [!INCLUDE[csprcs](../includes/csprcs-md.md)], you must access the `Settings` class directly, as shown in the following [!INCLUDE[csprcs](../includes/csprcs-md.md)] example.

```csharp
Properties.Settings.Default.FirstUserSetting = "abc";
```

You must also explicitly call the `Save` method of this wrapper class in order to persist the user settings. You usually do this in the `Closing` event handler of the main form. The following [!INCLUDE[csprcs](../includes/csprcs-md.md)] example shows a call to the `Save` method.

```csharp
Properties.Settings.Default.Save();
```

For general information about accessing application settings through the `Settings` class, see [Application Settings Overview](https://msdn.microsoft.com/library/0dd8bca5-a6bf-4ac4-8eec-5725d08b38dc). For information about iterating through the settings, see this [forum post](https://social.msdn.microsoft.com/Forums/en-US/40fbb470-f1e8-4a02-a4a0-9f62b54d0fc4/is-this-possible-propertiessettingsdefault?forum=csharpgeneral).

## See Also

- [Accessing Application Settings](https://msdn.microsoft.com/library/e38d0cc7-247a-46ca-ba04-f2913f0adb2e)
