---
title: "Project Settings for React, Angular, and Vue projects"
description: Understand how to change the project settings for a JavaScript project (.esproj) that uses React, Angular, or Vue in Visual Studio, using the Debug tab and Build tab of the project property pages.
ms.date: "10/19/2023"
ms.topic: "reference"
dev_langs:
  - "JavaScript"
helpviewer_keywords:
  - "debug configurations, JavaScript"
  - "debug configurations, esproj"
ms.custom: "ide-ref"
author:"mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: javascript-typescript
monikerRange: '>= vs-2022'
---

# Property pages for React, Angular, and Vue projects in Visual Studio

This article applies to React, Angular, and Vue projects created in Visual Studio that use the JavaScript Project System (JSPS), which is the *.esproj* project format. This format is supported starting in Visual Studio 2022.

The **Property Pages** provides access to project settings. To open the property pages, select the project in **Solution Explorer** and then select the **Properties** icon, or right-click the project and select **Properties**.

[!INCLUDE[note_settings_general](../../data-tools/includes/note_settings_general_md.md)]

The following pages and options appear in the **Property Pages**.

## Build tab

Under the General tab, the following properties are available.

**Build Command**

Specifies the command to run when you build the project. (**Build > Build Solution**, or when you run the project.) If used, this value is typically an npm command. This property corresponds to the [BuildCommand](../../javascript/javascript-project-system-msbuild-reference.md) property in the project file.

**Production Build Command**

Specifies the command to run when you build the project, when the project is integrated with the ASP.NET Core Web API project. Generates production-ready files. By default, this command is `npm run build`.

Starting in Visual Studio 2022 version 17.5, this option is not present in the [recommended project templates](../../javascript/javascript-in-visual-studio.md#project-templates) for React, Vue, and Angular.

**Build Output Folder**

Specifies the output folder for production build objects. For older projects, use this property when you use the **Production Build Command**.

**Clean Command**

Specifies the command to run when you clean the project. (**Build > Clean Solution**) If used, this value is typically an npm command. This property corresponds to the [CleanCommand](../../javascript/javascript-project-system-msbuild-reference.md) property in the project file.

**Working Directory**

Specifies the working directory for the build command. This value is the project root, by default.

## Deploy tab

**Startup Command**

Specifies the command to execute when you start the project. For example, an Angular project uses `npm start` by default. This property corresponds to the [StartupCommand](../../javascript/javascript-project-system-msbuild-reference.md) property in the project file.

**Working Directory**

Specifies the working directory for the startup command. By default, this value is the project root. Relative paths are relative to the project root.

> [!NOTE]
> In Visual Studio, *launch.json* stores the startup settings associated with the **Start** button in the Debug toolbar. *launch.json* must be located under the *.vscode* folder.

## See also

[JavaScript and TypeScript in Visual Studio](../../javascript/javascript-in-visual-studio.md)