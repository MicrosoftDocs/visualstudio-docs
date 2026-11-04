---
title: Localize Visual Studio extensions
description: Learn how to localize a Visual Studio extension using string-resources.json files for command display names, tooltips, and other localizable metadata.
ms.date: 10/20/2026
ms.topic: how-to
ms.author: tinali
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
monikerRange: ">=vs-2022"
---

# Localize Visual Studio extensions

VisualStudio.Extensibility extensions use `string-resources.json` files for localization. This approach localizes command display names, tooltips, and other extension metadata that supports localization.

> [!NOTE]
> The `.vsixlangpack` mechanism used by VSSDK extensions is **not supported** for VisualStudio.Extensibility extensions. Use `string-resources.json` instead.

## How localization works

Properties that support localization use `%` delimiters to reference string resource keys. The compiler emits a warning if these properties are set to a non-localizable value. To localize a string, surround the string resource key with `%` characters:

```csharp
public override CommandConfiguration CommandConfiguration => new("%MyExtension.MyCommand.DisplayName%")
{
    TooltipText = "%MyExtension.MyCommand.TooltipText%"
};
```

## string-resources.json

Your extension should provide a `string-resources.json` file for every language your extension supports. This JSON file is a dictionary of key/value pairs where the key is a globally unique identifier for a string resource and the value is the localized string.

**Default (English) — `.vsextension/string-resources.json`:**

```json
{
    "MyExtension.MyCommand.DisplayName": "My Command",
    "MyExtension.MyCommand.TooltipText": "Runs my command"
}
```

**German — `.vsextension/de/string-resources.json`:**

```json
{
    "MyExtension.MyCommand.DisplayName": "Mein Befehl",
    "MyExtension.MyCommand.TooltipText": "Führt meinen Befehl aus"
}
```

## Directory structure

Deploy the `string-resources.json` files under the `.vsextension` directory. Place a default file at the root and locale-specific files in subfolders named by locale code:

```text
.vsextension/
├── string-resources.json          (default / fallback)
├── de/
│   └── string-resources.json      (German)
├── es/
│   └── string-resources.json      (Spanish)
├── fr/
│   └── string-resources.json      (French)
└── ja/
    └── string-resources.json      (Japanese)
```

The `string-resources.json` at the root of `.vsextension` is used as the fallback when Visual Studio is set to a language your extension doesn't provide a localized file for.

## Localize runtime UI strings

The `string-resources.json` approach above covers extension **metadata** (command names, tooltips) that Visual Studio loads automatically. For strings displayed at runtime in your extension's UI — such as tool window labels, dialog text, or status messages — you need to load translations yourself.

### Recommended approach: embedded JSON resource files

1. Create locale-specific JSON files in your project (for example, `Strings/en.json`, `Strings/de.json`):

```json
// Strings/en.json
{
    "ToolWindow.Title": "My Tool Window",
    "Status.Loading": "Loading project data...",
    "Error.NotFound": "The requested item was not found."
}
```

2. Mark them as embedded resources in your `.csproj`:

```xml
<ItemGroup>
  <EmbeddedResource Include="Strings\*.json" />
</ItemGroup>
```

3. Load the correct file at runtime based on the current culture:

```csharp
using System.Globalization;
using System.Reflection;
using System.Text.Json;

public static class LocalizedStrings
{
    private static readonly Dictionary<string, string> Strings = LoadStrings();

    private static Dictionary<string, string> LoadStrings()
    {
        var culture = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
        var assembly = Assembly.GetExecutingAssembly();

        // Try culture-specific, then fall back to English
        var resourceName = $"MyExtension.Strings.{culture}.json";
        var stream = assembly.GetManifestResourceStream(resourceName)
            ?? assembly.GetManifestResourceStream("MyExtension.Strings.en.json");

        if (stream is null) return new();

        using var reader = new StreamReader(stream);
        return JsonSerializer.Deserialize<Dictionary<string, string>>(reader.ReadToEnd()) ?? new();
    }

    public static string Get(string key) =>
        Strings.TryGetValue(key, out var value) ? value : key;
}
```

4. Use the helper in your extension code:

```csharp
// In a tool window, command handler, or dialog
var title = LocalizedStrings.Get("ToolWindow.Title");
```

> [!IMPORTANT]
> Don't mix metadata localization (`string-resources.json` in `.vsextension/`) with runtime string localization. They serve different purposes:
> - **`.vsextension/string-resources.json`** — loaded by the VS host for command names and tooltips
> - **Embedded resource files** — loaded by your extension code for UI strings

## Tips

### ✅ DO

- Keep string keys globally unique and descriptive.
- Always provide an English fallback file.
- Test with a non-English Visual Studio language pack installed.
- Use `CultureInfo.CurrentUICulture` for UI strings.

### ❌ DON'T

- Don't use generic keys like `"Label1"`.
- Don't assume the user's culture will always match a provided locale.
- Don't hardcode user-facing strings directly in code.
- Don't use `CultureInfo.CurrentCulture` for UI strings; it's for number and date formatting.

## Related content

- [Ship your extension overview](overview.md)
- [Publish to the Marketplace](publish-to-marketplace.md)
