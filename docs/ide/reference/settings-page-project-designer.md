---
title: Settings Page, Project Designer
description: Learn how to use the Settings page of the Project Designer to specify a project's application settings.
ms.date: 01/09/2023
ms.topic: reference
f1_keywords:
- ApplicationSettingsOverview
helpviewer_keywords:
- Settings page in Project Designer
- Project Designer, Settings page
ms.custom: "ide-ref"
author:anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Settings page, Project Designer

Use the **Settings** page of the [Project Designer](project-properties-reference.md) to specify a project's application settings. Application settings enable you to store and retrieve property settings and other information for your application dynamically. They also enable you to maintain custom application and user preferences on a client computer. For more information, see [Manage application settings](../managing-application-settings-dotnet.md).

To access the **Settings** page, select a [project node](../use-solution-explorer.md#solution-explorer-context-menu) in **Solution Explorer**, and then use the right-click context menu to select **Properties**. When the Project Designer appears, select the **Settings** tab.

::: moniker range="vs-2022"

In **Settings** tab, you'll see a **Create or open application settings** link.

:::image type="content" source="media/vs-2022/project-properties-designer-settings-create-dialog.png" alt-text="Screenshot of the Settings tab in the Project Designer for a WPF project in Visual Studio 2022, where you click a link to dynamically generate the Settings dialog.":::

Select the **Create or open application settings** link to open a Settings page in the Project Designer.

:::image type="content" source="media/vs-2022/project-properties-designer-settings.png" alt-text="Screenshot of the Settings tab in the Project Designer for a WPF project in Visual Studio 2022.":::

::: moniker-end

::: moniker range="vs-2019"
:::image type="content" source="media/vs-2019/project-properties-designer-settings.png" alt-text="Screenshot of the Settings tab in the Project Designer for a WPF project in Visual Studio 2019.":::
::: moniker-end

## Header bar

The header bar at the top of the **Settings** page contains several controls:

**Synchronize**

**Synchronize** restores user-scoped settings that the application uses at run time or during debugging to their default values as defined at design time. To restore the data, remove run-time generated application-specific files from disk, not from project data.

**Load Web Settings**

**Load Web Settings** displays a **Login** dialog box that enables you to load settings for an authenticated user or for anonymous users. This button is enabled only when you've enabled client application services on the **Services** page and specified a **Web settings service location**.

**View Code**

For C# projects, the **View Code** button enables you to view the code in the *Settings.cs* file. This file defines the `Settings` class, which enables you to handle specific events on the `Settings` object. In languages other than Visual Basic, you must explicitly call the `Save` method of this wrapper class in order to persist the user settings. You usually do this in the **Closing** event handler of the main form. Following is an example of a call to the `Save` method:

```csharp
Properties.Settings.Default.Save();
```

For Visual Basic projects, the **View Code** button enables you to view the code in the *Settings.vb* file. This file defines the `MySettings` class, which enables you to handle specific events on the `My.Settings` object. For more information about accessing application settings by using the `My.Settings` object, see [Access application settings](/dotnet/visual-basic/developing-apps/programming/app-settings/accessing-application-settings).

For more information about accessing application settings, see [Application settings for Windows Forms](/dotnet/framework/winforms/advanced/application-settings-for-windows-forms).

**Access modifier**

The **Access modifier** button specifies the access level of the `Properties.Settings` (in C#) or `My.Settings` (in Visual Basic) helper classes that Visual Studio generates in *Settings.Designer.cs* or *Settings.Designer.vb*.

For Visual C# projects, the access modifier can be **Internal** or **Public**.

For Visual Basic projects, the access modifier can be **Friend** or **Public**.

By default, the setting is **Internal** in C# and **Friend** in Visual Basic. When Visual Studio generates helper classes as **Internal** or **Friend**, executable (*.exe*) applications cannot access the resources and settings that you have added to class libraries (*.dll* files). If you have to share resources and settings from a class library, set the access modifier to **Public**.

For more information about the settings helper classes, see [Manage application settings](../managing-application-settings-dotnet.md).

## Settings grid

**Settings Grid** is used to configure application settings. This grid includes the following columns:

**Name**

Enter the name of the application setting in this field.

**Type**

Use the drop-down list to select a type for the setting. The most frequently used types appear in the drop-down list, for example, **String**, **(Connection string)**, and **System.Drawing.Font**. You can choose another type by selecting **Browse** at the end of the list, and then selecting a type from the **Select a Type** dialog box. After you choose a type, it's added to the common types in the drop-down list (for the current solution only).

> [!IMPORTANT]
> **Browse** is available only for .NET Framework projects. **Browse** isn't available for .NET or .NET Core projects.

**Scope**

Select either **Application** or **User**.

Application-scoped settings, such as connection strings, are associated with the application. Users can't change application-scoped settings at run time.

User-scoped settings, such as system fonts, are intended to be used for user preferences. Users can change them at run time.

**Value**

The data or value associated with the application setting. For example, if the setting is a font, its value could be **Verdana, 9.75pt, style=Bold**.

## See also

- [Manage application settings](../managing-application-settings-dotnet.md)
- [Access application settings (Visual Basic)](/dotnet/visual-basic/developing-apps/programming/app-settings/accessing-application-settings)
