---
title: "Using PyLint in Python Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "2/24/2017"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-python"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: bc668a4b-10ae-4199-90b8-c984456b6003
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
translation.priority.ht:
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---

# Using PyLint to check Python code

[PyLint](https://www.pylint.org/), a widely-used tool that checks for errors in Python code and encourages good Python coding patterns, is integrated into Python Tools for Visual Studio (PTVS).

Just right-click a Python project in Solution Explorer and select **Python > Run PyLint...**:

![PyLint command on context menu for Python projects](media/code-pylint-command.png)

Using the command will prompt you to install PyLint into your active environment if needed.

PyLint warnings and errors appear in the Error List window:

![PyLint error list](media/code-pylint-error-list.png)

Double-clicking an error takes you to directly to the source code that generated the issue.

For details on controlling settings and suppressing warnings, see the [PyLint documentation](http://docs.pylint.org/).