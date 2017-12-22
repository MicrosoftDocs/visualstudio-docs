---
title: Linting R Code with the R Tools for Visual Studio | Microsoft Docs
ms.custom: ""
ms.date: 12/04/2017
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-r"
ms.devlang: r
ms.tgt_pltfrm: ""
f1_keywords: 
  - "vs.toolsoptionspages.text_editor.r.lint"
ms.topic: "article"
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: ghogen
ms.workload: 
  - "data-science"
---

# Linting R code in Visual Studio

Linting is a process that analyzes code to reveal potential errors as well as formatting issues and other noise in code files (such as spurious whitespace). Linting also helps encourage certain coding conventions, such as how identifiers are named, which is very helpful within teams and other collaborative situations.

R Tools for Visual Studio (RTVS) provides built-in linting for R, the behavior of which is controlled through a variety of options. These options are found in **Tool > Options > Text Editor > R > Lint**.

Linting is disabled by default. To enable linting, set the **All > Enable lint** option to true. The sections that follow in this topic describe all the other linting options:

When enabled, linting is applied in the editor while you type. Issues appear as green squiggles. In the following graphic, for example, RTVS has identified six linting issues, including use of `=` instead of `<-` for an assignment, lack of spacing around function arguments, use of Pascal case and uppercase identifiers, and use of a semicolon. Hovering over an issue provides a description.

![Examples of linting for R code](media/linting-01.png)

## Assignment group

| Option | Default value | Linting effect |
| --- | --- | --- |
| Enforce \<- | `True` | Identifies when `<-` isn't used for assignment. |

## Naming group

These options flag identifiers that use different naming conventions:

| Option | Default value | Linting effect |
| --- | --- | --- |
| Flag camelCase | `False` | Flags identifiers that use camelCase. |
| Flag long names | `False` | Flags identifiers whose named exceed the "Max name length" setting. |
| Flag multiple dots | `True` | Flags identifiers that use multiple dots. |
| Flag PascalCase | `True` | Flags identifiers that use PascalCase. |
| Flag snake_case | `False` | Flags identifiers that use underscores. |
| Flag UPPERCASE | `True` | Flags identifiers that use all caps. |
| Max name length | 32 | The length applied with the "Flag long names" setting. |

## Spacing group

These options, all of which are set to `True` by default, control where the linter identifies spacing issues: after function names, around commas, around operators, opening and closing curly positions, space before (, and space inside ().

## Statements group

| Option | Default value | Linting effect |
| --- | --- | --- |
| Multiple | `True` | Identifies when multiple statements are on the same line. |
| Semicolons | `True` | Identifies uses of semicolons. |

## Text group

| Option | Default value | Linting effect |
| --- | --- | --- |
| Line length limit | `False` | Sets whether the linter flags lines longer than the "Max line length" option. |
| Max line length | 80 | Sets the line length applied by the "Line length limit" option. |

## Whitespace group

These options, all of which are set to `True` by default, control where the linter identifies whitespace issues: use of tabs, use of double-quotes, trailing empty lines, and trailing whitespace.