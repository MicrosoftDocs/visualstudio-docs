---
title: Migrate testsettings to runsettings
description: Learn how to migrate testsettings to runsettings
ms.date: 03/18/2021
ms.topic: upgrade-and-migration-article
f1_keywords:
- vs.UnitTest.Migrate
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
---
# Upgrade from .testsettings to .runsettings

You can upgrade your test configuration file from *.testsettings* to *.runsettings* with the SettingsMigrator tool that installs along with Visual Studio. Depending on your Visual Studio install location, you can find the settings migrator tool in the following path:
::: moniker range=">=visualstudio"
`C:\Program Files\Microsoft Visual Studio\18\Enterprise\Common7\IDE\Extensions\TestPlatform\SettingsMigrator.exe`
::: moniker-end
::: moniker range="vs-2022"
`C:\Program Files\Microsoft Visual Studio\2022\Enterprise\Common7\IDE\Extensions\TestPlatform\SettingsMigrator.exe`
::: moniker-end
::: moniker range="vs-2019"
`C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\Extensions\TestPlatform\SettingsMigrator.exe`
::: moniker-end

In the correct directory location, you can run the tool with the format below:

```console
SettingsMigrator.exe <Full path to testsettings file to be migrated>
SettingsMigrator.exe <Full path to testsettings file to be migrated> <Full path to runsettings file to be created>
```

## Examples
```console
SettingsMigrator.exe E:\MyTest\MyTestSettings.testsettings
SettingsMigrator.exe E:\MyTest\MyTestSettings.testsettings E:\MyTest\MyNewRunSettings.runsettings
```

If you're interested in reading more on how the *.testsettings* options convert to *.runsettings* you can find more implementation details in the [open source test platform repository](https://github.com/microsoft/vstest-docs/blob/main/RFCs/0023-TestSettings-Deprecation.md#migration) on GitHub.

## Related content

- [Configure test runs with `.runsettings`](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md)
- [Upgrade from MSTestv1 to MSTestv2](../test/mstest-update-to-mstestv2.md)
- [Unit test your code](../test/unit-test-your-code.md)
- [Debug unit tests with Test Explorer](../test/debug-unit-tests-with-test-explorer.md)
