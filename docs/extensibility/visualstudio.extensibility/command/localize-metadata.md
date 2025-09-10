---
title: Metadata localization
description: An overview of extensibility metadata localization
author: RyanToth3
ms.author: rytoth
monikerRange: ">=vs-2022"
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
ms.topic: overview
ms.date: 02/03/2023
---

# Metadata localization overview

Some metadata defined inside of configuration objects support localization. Properties that support localization are adorned with [`LocalizableStringAttribute`](/visualstudio/ide/visual-studio-search) and the compiler emits a warning if these properties are set to a non-localizable value. These values can be localized by including *string-resources.json* files with your extension and surrounding the string resource key with `%` characters.

A [`Command`](/dotnet/api/microsoft.visualstudio.extensibility.commands.command) with a localized [`DisplayName`](/dotnet/api/microsoft.visualstudio.extensibility.commands.placeholdercommand.displayname) and [`ToolTipText`](/dotnet/api/microsoft.visualstudio.extensibility.commands.placeholdercommand.tooltiptext) looks like the following:

```csharp
public override CommandConfiguration CommandConfiguration => new("%Microsoft.VisualStudio.MyExtension.SampleRemoteCommand.DisplayName%")
{
    ToolTipText = "%Microsoft.VisualStudio.MyExtension.SampleRemoteCommand.ToolTipText%"
}
```

## string-resources.json

Your extension should provide a *string-resources.json* file for every language that your extension supports. This JSON file is a dictionary of key/value pairs where the key is a globally (all of Visual Studio) unique identifier for a string resource and the value is the localized string resource. These JSON files should be deployed with your extension under the `.vsextension` directory, with each language you support being shipped in a folder matching the name of the locale, that is, "de" for German, "it" for Italian, etc. The *string-resources.json* deployed at the root of the `.vsextension` directory is used as the default if your extension doesn't support the language that Visual Studio is currently set to. An example of what this directory structure would look like can be seen here:

![Localization directory structure](./media/localization-directory-structure.png)

string-resources.json sample:

```json
{
    "Microsoft.VisualStudio.MyExtension.SampleRemoteCommand.DisplayName": "Sample Remote Command Display Name",
    "Microsoft.VisualStudio.MyExtension.SampleRemoteCommand.ToolTipText": "Sample Remote Command ToolTip"
}
```

## Next steps

Learn more about VisualStudio.Extensibility commands at [Add Visual Studio commands](command.md).
