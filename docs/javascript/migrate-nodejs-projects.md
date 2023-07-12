---
title: "Migrate Node.js projects"
description: Learn how to migrate a Node.js project to the JavaScript project system (.esproj)
ms.date: "07/10/2023"
ms.topic: "how-to"
ms.devlang: javascript
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-javascript
dev_langs:
  - JavaScript
ms.workload:
  - "nodejs"
monikerRange: '>= vs-2022'
---
# Migrate Node.js Projects in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

The Node.js project system (*.njsproj*) in Visual Studio is on a deprecation path and will be replaced by the JavaScript project system (*.esproj*). Starting in Visual Studio 2022 version 17.7 Preview 1, you can convert your existing Node.js project to the JavaScript project system. By migrating the project, you can benefit from the latest project system updates related to npm dependency management, unit testing support, launch config settings, et al.

To migrate from a Node.js project to a JavaScript project:

Right-click the project node for your Node.js project. You should see one of two options: **Convert to New JavaScript Project Experience** or **Convert to New TypeScript Project Experience**. Select the available option to migrate your project to the new project system.

:::image type="content" source="media/vs-2022/migrate-convert-to-js-project.png" alt-text="Screenshot of option to convert to a JavaScript project.":::

After you choose **Convert**, a conversion log text file gets created and then it opens. The log file details the steps that occurred during the migration.  

:::image type="content" source="media/vs-2022/migrate-conversion-log.png" alt-text="Screenshot of conversion log.":::

If anything goes wrong during the migration, you can choose the **Revert Project to Old Experience** option so that the conversion will be reverted. If you encounter any problem during this process, please the [Report a problem](../ide/how-to-report-a-problem-with-visual-studio.md) feature in Visual Studio.

:::image type="content" source="media/vs-2022/migrate-revert-to-nodejs.png" alt-text="Screenshot of option to revert to a Node.js project.":::
