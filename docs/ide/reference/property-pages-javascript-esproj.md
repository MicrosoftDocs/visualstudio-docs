---
title: "Project Settings for React, Angular, and Vue projects | Microsoft Docs"
description: Understand how to change the project settings for a JavaScript project (.esproj) that uses React, Angular, or Vue in Visual Studio, using the Debug tab and Build tab of the project property pages.
ms.date: "09/20/2022"
ms.topic: "reference"
dev_langs:
  - "JavaScript"
helpviewer_keywords:
  - "debug configurations, JavaScript"
  - "debug configurations, esproj"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-javascript
monikerRange: '>= vs-2022'
---

# Property pages for React, Angular, and Vue projects in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

This article applies to React, Angular, and Vue projects created in Visual Studio that use the .esproj project format. This format is supported starting in Visual Studio 2022.

The **Property Pages** provides access to project settings. To open the property pages, select the project in **Solution Explorer** and then select the **Properties** icon, or right-click the project and select **Properties**.

[!INCLUDE[note_settings_general](../../data-tools/includes/note_settings_general_md.md)]

The following pages and options appear in the **Property Pages**.

## Build tab

Under the General tab, the following properties are available.

**Build Command**

Specifies the command to run when you build the project. (**Build > Build Solution**, or when you run the project.) If used, this is typically an npm command.

**Production Build Command**

Specifies the command to run when the project is integrated with the ASP.NET Core Web API project. Generates production-ready files. By default, this command is `npm run build`.

**Build Output Folder**

Specifies the output folder for production build objects when the **Production Build Command** is used.

**Clean Command**

Specifies the command to run when you clean the project. (**Build > Clean Solution**) If used, this is typically an npm command.

**Working Directory**

Specifies the working directory for the build command. This is the project root, by default.

## Debug tab

**Startup Command**

Specifies the command to execute when you start the project. For example, an Angular project uses `npm start` by default.

**Working Directory**

Specifies the working directory for the startup command. By default, this is the project root. Relative paths are relative to the project root.

## See also

[JavaScript and TypeScript in Visual Studio](../../javascript/javascript-in-visual-studio.md)