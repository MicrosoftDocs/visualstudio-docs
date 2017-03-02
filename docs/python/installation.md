---
title: "Installing the Python Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "2/14/2017"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-python"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ce3d3656-7ba2-490d-92df-0bb3e3badf92
caps.latest.revision: 11
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

# Installing the Python Tools for Visual Studio

TODO

> [!Tip]
> Visual Studio 2017 includes the helpful Cookiecutter extension that provides a graphical user interface to discover templates, input template options, and create projects and files. Learn more through the [Cookicutter documentation](https://cookiecutter.readthedocs.io/en/latest/).

## PTVS install locations

By default, PTVS is installed for all users on a computer. The full installation paths are as follows:

- 32-bit:
  - Path: `%Program Files(x86)%\Microsoft Visual Studio <VS_ver>\Common7\IDE\Extensions\Microsoft\Python Tools for Visual Studio\<PTVS_ver>`
  - Registry location of path: `HKEY_LOCAL_MACHINE\Software\Microsoft\PythonTools\<VS_ver>\InstallDir`
- 64-bit:
  - Path: `%Program Files%\Microsoft Visual Studio <VS_ver>\Common7\IDE\Extensions\Microsoft\Python Tools for Visual Studio\<PTVS_ver>`
  - Registry location of path: `HKEY_LOCAL_MACHINE\Software\Wow6432Node\Microsoft\PythonTools\<VS_ver>\InstallDir`

where:

- &lt;VS_ver&gt; is:
    - 2017 for Visual Studio 2017
    - 14.0 for Visual Studio 2015
    - 12.0 for Visual Studio 2013
    - 11.0 for Visual Studio 2012
    - 10.0 for Visual Studio 2010
- &lt;PTVS_ver&gt; is the PTVS version number, such as 2.2, 2.1, 2.0, 1.5, 1.1, or 1.0.

### User-specific installations (PTVS 1.5 and earlier)

PTVS 1.5 and earlier, allowed installation for the current user only, in which case the installation path is `%LocalAppData%\Microsoft\VisualStudio\<VS_ver>\Extensions\Microsoft\Python Tools for Visual Studio\<PTVS_ver>` where &lt;VS_ver&gt; and &lt;PTVS_ver&gt; are the same as described above.
