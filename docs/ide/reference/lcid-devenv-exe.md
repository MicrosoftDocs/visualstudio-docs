---
title: -LCID (devenv.exe)
description: Learn how to use the LCID devenv command-line switch to set the default language used for text, currency, and other values within the IDE.
ms.date: 11/19/2025
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
author: ghogen
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

Loads the IDE and sets the default natural language for the environment. This change is persisted between sessions.

:::moniker range="visualstudio"

The IDE shows this change in the **Language** option, which is available from the **Tools** > **Options** pane, under the **All Settings** > **Environment** > **International Settings** section.

:::moniker-end
:::moniker range="<=vs-2022"

The IDE shows this change in the **Language** option, which is available from the **Tools** > **Options** dialog, under the **Environment** > **International Settings** section.

:::moniker-end

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
- [International Settings, Environment, Options Dialog Box](/previous-versions/visualstudio/visual-studio-2017/ide/reference/international-settings-environment-options-dialog-box)
- [Customizing window layouts](../../ide/customizing-window-layouts-in-visual-studio.md)
