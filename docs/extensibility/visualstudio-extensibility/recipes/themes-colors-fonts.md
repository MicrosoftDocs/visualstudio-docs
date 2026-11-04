---
title: Theme your Visual Studio extension UI
description: Learn how to apply Visual Studio color themes to your extension UI, create theme extensions, and use semantic color tokens for consistent styling.
ms.date: 10/20/2026
ms.topic: how-to
ms.author: tinali
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
monikerRange: ">=vs-2022"
---

# Theme your extension UI

When you build custom UI for tool windows, dialogs, or other surfaces in your extension, you should match Visual Studio's color themes. Properly themed extensions look native and respond automatically when users switch between Light, Dark, and other themes.

Theming your extension's UI and creating a theme for the whole IDE are different tasks. This article shows where to start for both: use Blue Steel as a reference for a theme extension, or use Remote UI theme resources to make your extension follow the user's selected theme.

## Build a theme extension

A theme extension defines a color palette for Visual Studio itself, rather than just styling one extension's UI. It packages `.vstheme` files that users can install and select as their IDE theme.

[Blue Steel ↗](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.BlueSteel) is a community theme pack for Visual Studio 2026. Use its [source project ↗](https://github.com/madskristensen/BlueSteel) as a concrete reference:

- Compare [BlueSteelLight.vstheme ↗](https://github.com/madskristensen/BlueSteel/blob/master/src/BlueSteelLight.vstheme) and [BlueSteelDark.vstheme ↗](https://github.com/madskristensen/BlueSteel/blob/master/src/BlueSteelDark.vstheme) to see how the theme defines light and dark palettes.
- Review the [VSIX manifest ↗](https://github.com/madskristensen/BlueSteel/blob/master/src/source.extension.vsixmanifest) and [project file ↗](https://github.com/madskristensen/BlueSteel/blob/master/src/BlueSteel.csproj) to see how the themes are packaged as an extension.

Visual Studio 2026 uses semantic, intent-first color tokens organized into a small number of categories. To define those tokens or adapt an existing theme, follow [Modernize theme colors](../advanced/modernize-theme-colors.md), which includes the token structure and example light and dark token sets.

## Match your extension UI to the selected theme

> [!NOTE]
> This section uses the **VisualStudio.Extensibility** SDK and Remote UI. See [Choose the right extensibility model](../how-it-works/models/extensibility-models.md) for model comparison.

Without theming, your extension UI may appear jarring — especially in the Dark theme where unthemed controls have white backgrounds and illegible text.

### How theming works in VisualStudio.Extensibility

VisualStudio.Extensibility tool windows and dialogs use the [Remote UI](../how-it-works/remote-ui.md) model. Remote UI is based on WPF and, for out-of-process extensions, communicates with Visual Studio via RPC.

When you use Remote UI, the standard Visual Studio theme is applied automatically to your XAML controls. Your controls inherit the correct background colors, foreground colors, fonts, and styles from the current Visual Studio theme.

> [!NOTE]
> For custom controls or specific color requirements, you may need to explicitly reference theme resource dictionaries. See the [Remote UI documentation](../how-it-works/remote-ui.md) and the [ToolWindowSample ↗](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/ToolWindowSample) for examples of themed Remote UI controls.

#### What you get automatically

- Background and foreground colors for standard controls (buttons, text boxes, labels, list views)
- Font family and size matching the Visual Studio environment
- Automatic switching when the user changes themes

#### When you need to do more

If you use custom colors, hardcoded values, or non-standard controls, you may need to:

- Use Visual Studio theme resource keys for colors instead of hardcoded values
- Test your extension in both Light and Dark themes
- Avoid hardcoding `Background`, `Foreground`, or `FontFamily` in XAML

### Referencing Visual Studio style resources

For custom controls that need specific Visual Studio colors, reference the new Fluent-based `ShellColors` tokens in your XAML using `DynamicResource`:

```xml
<TextBlock Foreground="{DynamicResource {x:Static shell:ShellColors.ToolWindowTextBrushKey}}" />
<Border Background="{DynamicResource {x:Static shell:ShellColors.ToolWindowBackgroundBrushKey}}" />
```

In Visual Studio 2026 (Dev18), the theming system uses semantic, intent-first **ShellColors** tokens. These replace the legacy `EnvironmentColors`, `CommonControlsColors`, and `TreeViewColors` classes.

> [!IMPORTANT]
> Avoid using legacy color token classes (`EnvironmentColors`, `CommonControlsColors`, `TreeViewColors`). Use `ShellColors` tokens instead — they align with the new Fluent design system and will be maintained going forward.

These are in the `Microsoft.VisualStudio.Shell` namespace. Using these keys ensures your controls respond automatically to theme changes.

> [!TIP]
> See the [Theme color token reference](../how-it-works/theme-color-token-reference.md) for the complete list of Shell and ShellInternal tokens, and [Modernize theme colors](../advanced/modernize-theme-colors.md) for migration guidance.

## Visual Studio theme colors and resources

For detailed reference on Visual Studio's color system:

- [Theme color token reference](../how-it-works/theme-color-token-reference.md) — complete list of Shell and ShellInternal tokens with default values
- [Colors and styling for Visual Studio ↗](/visualstudio/extensibility/ux-guidelines/colors-and-styling-for-visual-studio)
- [Shared colors for Visual Studio ↗](/visualstudio/extensibility/ux-guidelines/shared-colors-for-visual-studio)
- [Color value reference ↗](/visualstudio/extensibility/ux-guidelines/color-value-reference-for-visual-studio)

## Tips

### ✅ DO

- Use Remote UI for out-of-process extensions — theming is applied automatically
- Use `DynamicResource` with `ShellColors` keys for custom color needs
- Test your extension in both Light and Dark themes before publishing
- Use Visual Studio's semantic theme resource keys for any custom colors
- Let standard controls inherit theme colors without overriding

### ❌ DON'T

- Don't hardcode colors (`Background="White"`, `Foreground="Black"`) — breaks in Dark theme
- Don't hardcode `FontFamily` or `FontSize` — use environment fonts
- Don't use `Brushes.White` or `Brushes.Black` in code-behind
- Don't forget to test High Contrast mode

### 🔧 Troubleshooting

| Symptom | Fix |
|---------|-----|
| White background in Dark theme | Remove hardcoded Background; let theme apply automatically |
| Text unreadable after theme switch | Don't set explicit Foreground; use theme resource keys |
| Custom colors don't update on theme change | Use `DynamicResource` with theme keys, not `StaticResource` |
| In-process controls not themed | Use `ShellColors` resource keys with `DynamicResource` |

## Next steps

- [Tool windows](tool-windows.md) — create themed tool window UI
- [Remote UI](../how-it-works/remote-ui.md) — how out-of-process UI works
- [Theme color token reference](../how-it-works/theme-color-token-reference.md) — full list of Shell and ShellInternal tokens
- [Modernize theme colors](../advanced/modernize-theme-colors.md) — build a full theme extension
- [Colors and styling for Visual Studio ↗](/visualstudio/extensibility/ux-guidelines/colors-and-styling-for-visual-studio)
- [Shared colors for Visual Studio ↗](/visualstudio/extensibility/ux-guidelines/shared-colors-for-visual-studio)
