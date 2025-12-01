---
title: Locate and organize project templates
description: Locate and organize project and item templates in Visual Studio, including installed templates and user templates (.vstemplate files).
ms.date: 11/13/2025
ms.topic: concept-article
helpviewer_keywords:
- project templates [Visual Studio], locations
- item templates [Visual Studio], locations
- template locations [Visual Studio]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide

#customer intent: As a developer, I want to locate and organize project and item templates in Visual Studio, so I can easily access them to create code for new projects and items.
---

# Locate and organize project and item templates

When template files are placed in a known location, Visual Studio can locate the files and make them available for creating new projects and new items. Templates provide a convenient way to create applications, access class libraries, implement unit tests, and set up configuration files.

Installed templates and user templates (`.vstemplate` files) are stored in different locations. You can also customize the locations with Visual Studio options.

This article describes the template file locations recognized by Visual Studio.

## Location for installed templates

By default, templates installed with Visual Studio are placed in the following locations:

::: moniker range="vs-2019"

- *%ProgramFiles(x86)%\\Microsoft Visual Studio\\2019\\\<edition>\\Common7\IDE\ProjectTemplates\\<Language\>\\<Locale ID\>*

- *%ProgramFiles(x86)%\\Microsoft Visual Studio\\2019\\\<edition>\Common7\IDE\ItemTemplates\\<Language\>\\<Locale ID\>*

For example, the following directory in a default installation of Visual Studio Community 2019 has the Visual Basic item templates for English (LCID 1033):

*C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\Common7\\IDE\\ItemTemplates\\VisualBasic\\1033*

::: moniker-end
::: moniker range="vs-2022"

- *%ProgramFiles%\\Microsoft Visual Studio\\2022\\\<edition>\\Common7\IDE\ProjectTemplates\\<Language\>\\<Locale ID\>*

- *%ProgramFiles%\\Microsoft Visual Studio\\2022\\\<edition>\Common7\IDE\ItemTemplates\\<Language\>\\<Locale ID\>*

For example, the following directory in a default installation of Visual Studio Community 2022 has the Visual Basic item templates for English (LCID 1033):

*C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\ItemTemplates\\VisualBasic\\1033*

::: moniker-end
::: moniker range="visualstudio"

- *%ProgramFiles%\\Microsoft Visual Studio\\18\\\<edition>\\Common7\IDE\ProjectTemplates\\<Language\>\\<Locale ID\>*

- *%ProgramFiles%\\Microsoft Visual Studio\\18\\\<edition>\Common7\IDE\ItemTemplates\\<Language\>\\<Locale ID\>*

For example, the following directory in a default installation of Visual Studio Community has the Visual Basic item templates for English (LCID 1033):

*C:\\Program Files\\Microsoft Visual Studio\\18\\Community\\Common7\\IDE\\ItemTemplates\\VisualBasic\\1033*

::: moniker-end
## Location for user templates

When you add a compressed (`.zip`) file that includes a `.vstemplate` file to the user template directory, Visual Studio makes the template available in the **New project** and **New item** dialogs. By default, user templates are placed in the following locations:

::: moniker range="vs-2019"

- *%USERPROFILE%\Documents\Visual Studio 2019\Templates\ProjectTemplates*

- *%USERPROFILE%\Documents\Visual Studio 2019\Templates\ItemTemplates*

For example, the following directory has user project templates for C#:

- *C:\Users\UserName\Documents\Visual Studio 2019\Templates\ProjectTemplates\Visual C#*

::: moniker-end

::: moniker range="vs-2022"

- *%USERPROFILE%\Documents\Visual Studio 2022\Templates\ProjectTemplates*

- *%USERPROFILE%\Documents\Visual Studio 2022\Templates\ItemTemplates*

For example, the following directory has user project templates for C#:

- *C:\Users\UserName\Documents\Visual Studio 2022\Templates\ProjectTemplates\Visual C#*

::: moniker-end
::: moniker range="visualstudio"

- *%USERPROFILE%\Documents\Visual Studio 18\Templates\ProjectTemplates*

- *%USERPROFILE%\Documents\Visual Studio 18\Templates\ItemTemplates*

For example, the following directory has user project templates for C#:

- *C:\Users\UserName\Documents\Visual Studio 18\Templates\ProjectTemplates\Visual C#*

::: moniker-end

### Change location for user templates

:::moniker range="visualstudio"

You can change the location for user templates in Visual Studio from the **Tools** > **Options** pane. The location settings are under the **All Settings** > **Projects and Solutions** > **Locations** section.

:::moniker-end
:::moniker range="<=vs-2022"

You can change the location for user templates in Visual Studio from the **Tools** > **Options** dialog. The location settings are under the **Projects and Solutions** > **Locations** section.

:::moniker-end

## Related content

- Review the [Visual Studio template schema reference (extensibility)](../extensibility/visual-studio-template-schema-reference.md)
- Use [prebuilt templates installed with the .NET SDK](/dotnet/core/tools/dotnet-new-sdk-templates)
- [Manage .NET project and item templates with the .NET SDK CLI](/dotnet/core/install/templates?pivots=os-windows&preserve-view=true)
