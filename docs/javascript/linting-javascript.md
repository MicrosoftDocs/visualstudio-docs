---
title: "Linting JavaScript in Visual Studio"
description: Learn how to lint JavaScript in Visual Studio
ms.date: 09/29/2022
ms.topic: how-to
ms.devlang: javascript
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-javascript
dev_langs:
  - JavaScript
ms.workload:
  - "nodejs"
monikerRange: '>= vs-2022'
---

# Linting JavaScript in Visual Studio

Linting JavaScript and TypeScript in Visual Studio is powered by [ESLint](https://eslint.org/). If you are new to ESLint, you can begin by checking their [documentation](https://eslint.org/docs/latest/user-guide/getting-started).

## Enabling linting support

To enable linting support in Visual Studio 2022 or later versions, enable the **Enable ESLint** setting in **Tools > Options > Text Editor > JavaScript/TypeScript > Linting**.

![Linting tools options page](./images/vs-2022/linting-tools-options.png)

In the options page, you can also modify the set of files that you want to lint. By default, all lintable file extensions (*.js*, *.jsx*, *.ts*, and *.tsx*) will be linted.

You can override these options in some project types, like the [standalone React project templates](../javascript/tutorial-create-react-app.md). In these projects, you can override the settings from the **Tools > Options** page using project properties:

![Linting project properties](./images/vs-2022/linting-proj-properties.png)

## Installing ESLint dependencies

Once linting is enabled, the necessary dependencies need to be installed. This includes the [ESLint `npm` package](https://www.npmjs.com/package/eslint). This package can be installed locally in each project where you want to enable linting, or you can install it globally using `npm install -g eslint`. However, a global installation isn't recommended because plugins and shareable configs always need to be installed locally.

Depending on the files you want to lint, additional [ESLint plugins](https://eslint.org/docs/latest/user-guide/configuring/plugins) may be needed. For example, you may need [TypeScript ESLint](https://typescript-eslint.io/), which enables ESLint to run on TypeScript code and includes rules that are specific to the extra type information.

When ESLint is enabled but the ESLint `npm` package isn't found, a gold bar is displayed that allows you to install ESLint as a local `npm` development dependency. Similarly, when no *.eslintrc* file has been found, a gold bar is displayed to run a configuration wizard that will install the plugins applicable to the current project.

![Install ESLint gold bar](./images/vs-2022/no-package-goldbar.png)
![Run ESLint wizard gold bar](./images/vs-2022/no-config-goldbar.png)

## Disabling linting rules and auto-fixes

You can disable linting errors on a [specific line or file](https://eslint.org/docs/latest/user-guide/configuring/rules#disabling-rules). You can disable the errors by using the Quick Actions menu:

![Linting code actions](./images/vs-2022/code-actions.png)
![Disable linting rule](./images/vs-2022/disabled-rule.png)

In addition, auto-fix code actions allow you to apply an auto-fix to address the respective linting error.

## Troubleshooting

You can open the **ESLint Language Extension** pane in the Output window to see any error messages or other logs that might explain the problem.
