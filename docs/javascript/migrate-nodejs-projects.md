---
title: "Migrate Node.js projects"
description: Migrate Node.js projects to the JavaScript project system (.esproj) and access updates including npm dependency management, unit testing, and launch settings.
ms.date: "07/10/2023"
ms.topic: "how-to"
ms.devlang: javascript
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: javascript-typescript
dev_langs:
  - JavaScript
monikerRange: '>= vs-2022'
---
# Migrate Node.js projects in Visual Studio

Starting in Visual Studio 2022 version 17.7 Preview 1, you can convert existing projects based on the older Node.js project system (*.njsproj*) to the new JavaScript project system (*.esproj*). By migrating the project, you can benefit from project system updates such as npm dependency management, unit testing support, and launch config settings.

To migrate from a Node.js project to a JavaScript project:

Right-click the project node for your Node.js project. You should see one of two options: **Convert to New JavaScript Project Experience** or **Convert to New TypeScript Project Experience**. Select the available option to migrate your project to the new project system.

:::image type="content" source="media/vs-2022/migrate-convert-to-js-project.png" alt-text="Screenshot of option to convert to a JavaScript project.":::

After you choose **Convert**, a conversion log text file gets created and then it opens. The log file details the steps that occurred during the migration.  

:::image type="content" source="media/vs-2022/migrate-conversion-log.png" alt-text="Screenshot of conversion log.":::

If anything goes wrong during the migration, you can choose the **Revert Project to Old Experience** option so that the conversion will be reverted. If you encounter any problem during this process, please the [Report a problem](../ide/how-to-report-a-problem-with-visual-studio.md) feature in Visual Studio.

:::image type="content" source="media/vs-2022/migrate-revert-to-nodejs.png" alt-text="Screenshot of option to revert to a Node.js project.":::
