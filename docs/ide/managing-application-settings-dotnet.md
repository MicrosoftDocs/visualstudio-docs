---
title: Manage application settings (.NET)
description: Manage application settings that aren't included in the application code but are needed at runtime with the Visual Studio IDE.
ms.date: 10/02/2024
ms.topic: conceptual
f1_keywords:
- msvse_settingsdesigner.err.nameblank
helpviewer_keywords:
- application settings [Visual Studio]
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
#customer intent: As a developer, I want to use application settings to store information that isn't included in the application code at runtime.
---
# Manage application settings (.NET)

Application settings enable you to store application information dynamically. With application settings, you can use a client computer to store information that shouldn't be included in the application code at runtime. Application settings can include connection strings, user preferences, and more.

> [!NOTE]
> Application settings replace the dynamic properties used in earlier versions of Visual Studio.

Each application setting must have a unique name. The name can be any combination of letters, numbers, or an underscore. The name can't start with a number, and it can't have spaces. The name is changed through the `Name` property.

Application settings can be stored as any data type that is serialized to XML or has a `TypeConverter` that implements `ToString`/`FromString`. The most common types are `String`, `Integer`, and `Boolean`. You can also store values as <xref:System.Drawing.Color>, <xref:System.Object>, or as a connection string.

Application settings also hold a value. The value is set with the **Value** property and must match the data type of the setting.

In addition, application settings can be bound to a property of a form or control at design time.

There are two types of application settings, based on scope:

- **Application-scoped settings** can be used for information such as a URL for a web service or a database connection string. These values are associated with the application. Therefore, users can't change them at runtime.

- **User-scoped settings** can be used for information such as persisting the last position of a form or a font preference. Users can change these values at runtime.

You can change the type of a setting by using the **Scope** property.

The project system stores application settings in two XML files:

- An *app.config* file, which is created at design time when you create the first application setting

- A *user.config* file, which is created at runtime when the user who runs the application changes the value of any user setting

Changes in user settings aren't written to disk unless the application specifically calls a method to do so.

## Create application settings at design time

At design time, you can create application settings in two ways:

- Use the **Settings** page of the **Project Designer**.

- Use the **Properties** window for a form or control, which allows you to bind a setting to a property.

When you create an application-scoped setting (for example, a database connection string, or a reference to server resources), Visual Studio saves it in the *app.config* file with the `<applicationSettings>` tag. Connection strings are saved under the `<connectionStrings>` tag.

When you create a user-scoped setting (for example, default font, home page, or window size), Visual Studio saves it in *app.config* file with the `<userSettings>` tag.

> [!IMPORTANT]
> When you store connection strings in *app.config*, you should take precautions to avoid revealing sensitive information, such as passwords or server paths, in the connection string.
>
> If you take connection string information from an external source, such as a user who supplies their user ID and password, ensure that the values you use to construct your connection string don't contain additional connection string parameters that change the behavior of your connection.
>
> Consider using the Protected Configuration feature to encrypt sensitive information in the configuration file. For more information, see [Protect connection information](/dotnet/framework/data/adonet/protecting-connection-information).

> [!NOTE]
> Because there isn't a configuration file model for class libraries, application settings don't apply for Class Library projects. The exception is a [Visual Studio Tools for Office Runtime](/visualstudio/vsto/visual-studio-tools-for-office-runtime-overview) DLL project, which can have a configuration file.

## Use customized settings files

You can add customized settings files to your project for convenient management of groups of settings. Settings that are contained in a single file are loaded and saved as a unit. Storing settings in separate files for frequently used and infrequently used groups can save time in loading and saving settings.

For example, you can add a *SpecialSettings.settings* file to your project. While your `SpecialSettings` class isn't exposed in the `My` namespace, **View Code** can read the custom settings file that contains `Partial Class SpecialSettings`.

The **Settings Designer** first searches for the *Settings.settings* file that the project system creates. This *Settings.settings* file is the default file that the [Project Designer](reference/project-properties-reference.md) displays in the **Settings** tab. The *Settings.settings* file is located in the *My Project* folder for Visual Basic projects and in the *Properties* folder for Visual C# projects. The **Project Designer** then searches for other settings files in the project's root folder. Therefore, you should put your custom settings file there. If you add a *.settings* file elsewhere in your project, the **Project Designer** can't locate it.

## Access or change application settings at runtime in Visual Basic

In Visual Basic projects, you can access application settings at runtime by using the `My.Settings` object. On the **Settings** page, select the **View code** button to view the *Settings.vb* file. *Settings.vb* defines the `Settings` class, which enables you to handle these events on the settings class:

- <xref:System.Configuration.ApplicationSettingsBase.SettingChanging>
- <xref:System.Configuration.ApplicationSettingsBase.PropertyChanged>
- <xref:System.Configuration.ApplicationSettingsBase.SettingsLoaded>
- <xref:System.Configuration.ApplicationSettingsBase.SettingsSaving>

The `Settings` class in *Settings.vb* is a partial class that displays only the user-owned code, not the whole generated class. For more information about accessing application settings by using the `My.Settings` object, see [Access application settings (.NET Framework)](/dotnet/visual-basic/developing-apps/programming/app-settings/accessing-application-settings).

The values of any user-scoped settings that the user changes at runtime, for example, the position of a form, are stored in a *user.config* file. The default values are still saved in *app.config*.

If any user-scoped settings are changed during runtime, for example in testing the application, and you want to reset these settings to their default values, select the **Synchronize** button.

We recommend that you use the `My.Settings` object and the default *.settings* file to access settings. You can use the **Settings Designer** to assign properties to settings, and, also, user settings are automatically saved before application shutdown. However, your Visual Basic application can access settings directly. In that case you have to access the `MySettings` class and use a custom *.settings* file in the root of the project. You must save the user settings before ending the application, as you would do for a C# application, as described in the following section.

<!-- markdownlint-disable MD003 MD020 -->
## Access or change application settings at runtime in C#
<!-- markdownlint-enable MD003 MD020 -->

In languages other than Visual Basic, such as C#, you must access the `Settings` class directly, as shown in the following Visual C# example.

```csharp
Properties.Settings.Default.FirstUserSetting = "abc";
```

You must explicitly call the `Save` method of this wrapper class in order to persist the user settings. You usually do so in the `Closing` event handler of the main form. The following C# example shows a call to the `Save` method.

```csharp
Properties.Settings.Default.Save();
```

For general information about accessing application settings through the `Settings` class, see [Application settings overview (.NET Framework)](/dotnet/framework/winforms/advanced/application-settings-overview).

## Migrating apps from .NET Framework to .NET

.NET Framework uses the *app.config* file to load settings for your app, such as connection strings and log provider configuration. Modern .NET uses the *appsettings.json* file for app settings. To learn more about converting *app.config* files to *appsettings.json*, see [Modernize after upgrading to .NET from .NET Framework](/dotnet/core/porting/modernize#appconfig).

## Related content

- [Add an app.config file (C#)](how-to-add-app-config-file.md)
- [Configure apps (.NET Framework)](/dotnet/framework/configure-apps/index)
- [Access application settings (Visual Basic)](/dotnet/visual-basic/developing-apps/programming/app-settings/accessing-application-settings)
- [Using application settings and user settings (Windows Forms)](/dotnet/framework/winforms/advanced/using-application-settings-and-user-settings)
