---
title: "External settings providers"
description: "Back VisualStudio.Extensibility settings with an external store."
ms.date: 09/29/2026
ms.topic: how-to
author: jasonchlus
ms.author: jasonc
---

# External settings providers

The ordinary [settings API](settings.md) is stable. External settings providers are experimental, require opting in to `VSEXTPREVIEW_SETTINGS_EXTERNAL`, and may change in a later SDK. See [Experimental APIs ↗](https://github.com/microsoft/VSExtensibility/blob/main/docs/experimental_apis.md) for guidance on opting in. Ordinary settings do **not** require `VSEXTPREVIEW_SETTINGS`.

## Back settings with an external store

An `ExternalSettingsProvider` supplies values from a store your extension owns instead of using the normal settings store. Its `ExternalSettingsProviderConfiguration` declares a category and externally backed settings that Visual Studio can display without loading the extension merely to discover their metadata.

The [ExternalSettingsSample ↗](https://github.com/microsoft/VSExtensibility/tree/preview_18.12/New_Extensibility_Model/Samples/ExternalSettingsSample) has one **Greeting** setting backed by an in-memory store. Its complete provider demonstrates the `VSEXTPREVIEW_SETTINGS_EXTERNAL` opt-in in that file:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/ExternalSettingsSample/SampleExternalSettingsProvider.cs":::

The provider uses four callbacks and notifications to keep the settings UI and store consistent:

1. `GetValue` reads the current greeting and returns `ExternalSettingOperationResult<string>.Success`.
1. `Validate` returns a `SettingMessage` with error severity for blank or overlong input. `SetValue` also rejects invalid writes with `ExternalSettingOperationResult.Failure`; it never reports an invalid write as successful.
1. A successful `SetValue` changes the backing store. Changes made outside the settings UI raise the store's `Changed` event, which calls `NotifySettingValuesChanged` so Visual Studio refreshes the greeting.
1. `Dispose` removes the store event handler when the provider is no longer needed.

A provider must return explicit failures for unavailable reads and writes, and optionally notify Visual Studio when its backing values change.
