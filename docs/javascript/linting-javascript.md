---
title: "Linting JavaScript in Visual Studio"
description: Use ESLint to lint JavaScript and TypeScript in Visual Studio, install dependencies, configure linting rules, and access troubleshooting support.
ms.date: 05/02/2025
ms.topic: how-to
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.JavaScript.Linting.General"
  - "VS.ToolsOptionsPages.Text_Editor.JavaScript.Linting"
  - "VS.ToolsOptionsPages.Text_Editor.TypeScript.Linting.General"
  - "VS.ToolsOptionsPages.Text_Editor.TypeScript.Linting"
ms.devlang: javascript
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: javascript-typescript
dev_langs:
  - JavaScript
monikerRange: '>= vs-2022'
---

# Linting JavaScript in Visual Studio

Linting JavaScript and TypeScript in Visual Studio is powered by [ESLint](https://eslint.org/). If you're new to ESLint, you can begin by checking their [documentation](https://eslint.org/docs/latest/user-guide/getting-started).

## Enable linting support

To enable linting support in Visual Studio 2022 or later versions, enable the **Enable ESLint** setting in **Tools > Options > Text Editor > JavaScript/TypeScript > Linting**.

:::image type="content" source="media/vs-2022/linting-tools-options.png" alt-text="Screenshot of linting Tools Options page.":::

In the options page, you can also modify the set of files that you want to lint. By default, all file extensions that can be linted (*.js*, *.jsx*, *.ts*, *.tsx*, *.vue*, *.html*) will be linted. The HTML LSP-based editor must be enabled for linting Vue and HTML files. The respective setting can be found in **Tools > Options > Environment > Preview Features** > **HTML LSP-based editor**.

You can override these options in some project types, like the [standalone React project templates](../javascript/tutorial-create-react-app.md). In these projects, you can override the settings from the **Tools > Options** page using project properties:

:::image type="content" source="media/vs-2022/linting-project-properties.png" alt-text="Screenshot of linting project properties.":::

## Install ESLint dependencies

Once linting is enabled, the necessary dependencies need to be installed. Dependencies include the [ESLint `npm` package](https://www.npmjs.com/package/eslint) and other plugins applicable to your project. This package can be installed locally in each project where you want to enable linting, or you can install it globally using `npm install -g eslint`. However, a global installation isn't recommended because plugins and shareable configs always need to be installed locally.

Starting in Visual Studio 2022 version 17.7 Preview 2, you can also use the **ESLint Path** setting in **Tools > Options > Text Editor > JavaScript/TypeScript > Linting** to specify a directory from which to load ESLint. This setting is useful when ESLint is installed globally, where you might set the corresponding path to *C:\Program Files\nodejs\node_modules*.

Depending on the files you want to lint, other [ESLint plugins](https://eslint.org/docs/latest/user-guide/configuring/plugins) may be needed. For example, you may need [TypeScript ESLint](https://typescript-eslint.io/), which enables ESLint to run on TypeScript code and includes rules that are specific to the extra type information.

When ESLint is enabled but the ESLint `npm` package isn't found, a gold bar is displayed. This message allows you to install ESLint as a local `npm` development dependency.

:::image type="content" source="media/vs-2022/no-package-goldbar.png" alt-text="Screenshot of Install ESLint gold bar.":::

Similarly, when an *.eslintrc* file isn't found, a gold bar is displayed. This message allows you to run a configuration wizard that installs the plugins applicable to the current project.

:::image type="content" source="media/vs-2022/no-config-goldbar.png" alt-text="Screenshot of Run ESLint wizard gold bar.":::

## Disable linting rules and autofixes

You can disable linting errors on a [specific line or file](https://eslint.org/docs/latest/user-guide/configuring/rules#disabling-rules). You can disable the errors by using the Quick Actions lightbulb menu:

:::image type="content" source="media/vs-2022/code-actions.png" alt-text="Screenshot of linting Quick Actions.":::

The following illustration shows the result if you disable a linting error for the selected line of code.

:::image type="content" source="media/vs-2022/disabled-rule.png" alt-text="Screenshot of disabled linting rule.":::

In addition, autofix code actions allow you to apply an autofix to address the respective linting error.

## Troubleshooting

You can open the **ESLint Language Extension** pane in the Output window to see any error messages or other logs that might explain the problem.
