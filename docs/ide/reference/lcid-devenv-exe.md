---
title: -LCID (devenv.exe)
description: Learn how to use the LCID devenv command-line switch to set the default language used for text, currency, and other values within the IDE.
ms.date: 12/10/2018
ms.topic: reference
helpviewer_keywords:
- language default
- locale IDs, setting for IDE
- Devenv, /L switch
- Devenv, /LCID switch
- locale IDs
- L Devenv switch
- /L Devenv switch
- LCID devenv switch
- /LCID Devenv switch
author:ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# /LCID (devenv.exe)

Sets the default language used for text, currency, and other values within the IDE.

## Syntax

```shell
devenv {/LCID|/L} LocaleID
```

## Arguments

- *LocaleID*

  Required. The locale identifier (LCID) of the language you specify.

## Remarks

Loads the IDE and sets the default natural language for the environment. This change is persisted between sessions, and the IDE shows this change in the **Tools** > **Options** > **Environment** > **International Settings** > **Language** box.

If the specified language isn't available on your system, the `/LCID` switch is ignored.

The following table lists the LCIDs of the languages supported by Visual Studio.

|Language|LCID|
|--------------|----------|
|Chinese (Simplified)|2052|
|Chinese (Traditional)|1028|
|Czech|1029|
|English|1033|
|French|1036|
|German|1031|
|Italian|1040|
|Japanese|1041|
|Korean|1042|
|Polish|1045|
|Portuguese (Brazil)|1046|
|Russian|1049|
|Spanish|3082|
|Turkish|1055

## Example

This example loads the IDE with English resources strings.

```shell
devenv /LCID 1033
```

## See also

- [Devenv command-line switches](../../ide/reference/devenv-command-line-switches.md)
- [International Settings, Environment, Options Dialog Box](../../ide/reference/international-settings-environment-options-dialog-box.md)
- [Customizing window layouts](../../ide/customizing-window-layouts-in-visual-studio.md)
