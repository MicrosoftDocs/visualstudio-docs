---
title: Visual Studio theme color token reference
description: Complete reference for Visual Studio 2026 Shell and ShellInternal theme color tokens, including descriptions, usage guidance, and default values for Light, Dark, and High Contrast themes.
ms.date: 05/05/2026
ms.topic: reference
ms.author: rosemalcolm
author: nichmach
manager: mijacobs
ms.subservice: extensibility-integration
monikerRange: ">=vs-2022"
---

# Visual Studio theme color token reference

This reference lists the semantic color tokens used by Visual Studio 2026 themes. Use this page when building community themes or overriding individual color tokens for customization.

Visual Studio 2026 organizes theme colors into two categories:

- **Shell** — tokens that control the primary UI surfaces (backgrounds, text, accents, controls, strokes)
- **ShellInternal** — tokens that control internal environment colors (window background, borders, indicators)

For background on the token system redesign and migration guidance, see [Modernize theme colors](../advanced/modernize-theme-colors.md).

> [!NOTE]
> A comprehensive token reference with color swatches for all Fluent UI tokens is available in the UX Guidelines section: [Theme color token reference ↗](/visualstudio/extensibility/ux-guidelines/theme-color-token-reference). The page below covers the most commonly used Shell and ShellInternal tokens for extension developers.

> [!TIP]
> Users can override individual tokens via **Tools > Options > Environment > Theme Customization** without creating a full theme extension.

## How to read this reference

Each table includes:

| Column | Description |
|--------|-------------|
| **Token name** | The `<Color Name="...">` value used in `.vstheme` files |
| **Description** | What the token controls visually |
| **Usage** | Where this token appears in the Visual Studio UI |
| **Light** | Default hex ARGB value in the Light theme |
| **Dark** | Default hex ARGB value in the Dark theme |
| **High Contrast** | Default hex ARGB value in High Contrast themes |

Color values use the `CT_RAW` ARGB format: `AARRGGBB` (for example, `FF5649B0` = fully opaque purple).

## Shell tokens

**Category GUID:** `{73708ded-2d56-4aad-b8eb-73b20d3f4bff}`

Shell tokens define the primary visual language of Visual Studio — accent colors, text fills, background fills, control fills, and strokes.

### Accent fills

Accent tokens provide the brand color used for interactive elements, focus indicators, and highlights.

| Token name | Description | Usage | Light | Dark | High Contrast |
|------------|-------------|-------|-------|------|---------------|
| `AccentFillDefault` | Primary accent color | Focused borders, active tab indicators, primary buttons | `FF5649B0` | `FF9184EE` | `FF1AEBFF` |
| `AccentFillSecondary` | Accent with reduced opacity | Hover states, secondary highlights | `E55649B0` | `80000000` | `FF1AEBFF` |
| `AccentFillTertiary` | Accent with further reduced opacity | Pressed states, subtle indicators | `CC5649B0` | `CC9184EE` | `FF1AEBFF` |

### Text fills

Text tokens control foreground colors for all text elements.

| Token name | Description | Usage | Light | Dark | High Contrast |
|------------|-------------|-------|-------|------|---------------|
| `TextFillPrimary` | Primary text color | Body text, headings, labels | `E4000000` | `E4FFFFFF` | `FFFFFFFF` |
| `TextFillSecondary` | Secondary text color | Descriptions, placeholders, disabled text | `9E000000` | `C8FFFFFF` | `FF00FF00` |

### Background fills

Background tokens define layered surfaces that create depth and hierarchy.

| Token name | Description | Usage | Light | Dark | High Contrast |
|------------|-------------|-------|-------|------|---------------|
| `SolidBackgroundFillBase` | Base background layer | Main editor area, primary content surfaces | `FFF3F3F3` | `FF1E1E1E` | `FF000000` |
| `SolidBackgroundFillTertiary` | Third-level surface | Tool window backgrounds, panel backgrounds | `FFF9F9F9` | `FF282828` | `FF000000` |
| `SolidBackgroundFillQuaternary` | Fourth-level surface | Flyout backgrounds, dropdown backgrounds | `FFFFFFFF` | `FF2C2C2C` | `FF000000` |
| `SurfaceBackgroundFillDefault` | Default surface fill | General-purpose container backgrounds | `FFF9F9F9` | `FF2C2C2C` | `FF000000` |

### Control fills

Control tokens style interactive elements (buttons, checkboxes, inputs).

| Token name | Description | Usage | Light | Dark | High Contrast |
|------------|-------------|-------|-------|------|---------------|
| `ControlFillDefault` | Default control background | Button rest state, input fields | `B3FFFFFF` | `0FFFFFFF` | `FF000000` |
| `ControlFillSecondary` | Secondary control fill | Hover state for controls | `80F9F9F9` | `15FFFFFF` | `FF000000` |
| `ControlFillTertiary` | Tertiary control fill | Pressed state for controls | `4DF9F9F9` | `08FFFFFF` | `FF000000` |

### Strokes

Stroke tokens define borders and divider lines.

| Token name | Description | Usage | Light | Dark | High Contrast |
|------------|-------------|-------|-------|------|---------------|
| `StrokeDefault` | Default border color | Control borders, separators | `0F000000` | `12FFFFFF` | `FF6B6B6B` |
| `StrokeSecondary` | Secondary border | Subtle dividers, group separators | `29000000` | `18FFFFFF` | `FFFFFFFF` |

### System fills

System tokens provide semantic colors for status indicators.

| Token name | Description | Usage | Light | Dark | High Contrast |
|------------|-------------|-------|-------|------|---------------|
| `SystemFillSuccess` | Success/positive state | Build succeeded, green indicators | `FF107C10` | `FF54B054` | `FF00FF00` |
| `SystemFillCaution` | Warning/caution state | Warnings, amber indicators | `FF797300` | `FFFCE100` | `FFFFFF00` |
| `SystemFillCritical` | Error/critical state | Build errors, red indicators | `FFC50F1F` | `FFFF99A4` | `FFFF0000` |
| `SystemFillAttention` | Information/attention state | Informational markers, blue indicators | `FF005FB7` | `FF60CDFF` | `FF00FFFF` |

## ShellInternal tokens

**Category GUID:** `{5af241b7-5627-4d12-bfb1-2b67d11127d7}`

ShellInternal tokens control the outer shell environment — the frame, title bar area, and chrome that surrounds content windows.

| Token name | Description | Usage | Light | Dark | High Contrast |
|------------|-------------|-------|-------|------|---------------|
| `EnvironmentBackground` | Shell environment background | Area behind tool windows, chrome background | `FFEEEEEE` | `FF1C1C1C` | `FF000000` |
| `EnvironmentBorder` | Environment border accent | Window frame borders, accent lines in chrome | `FF5649B0` | `FF9184EE` | `FF00FFFF` |
| `EnvironmentIndicator` | Subtle indicator color | Scroll track indicators, resize grips | `66757575` | `66757575` | `FFFFFFFF` |
| `EnvironmentLogo` | VS logo/branding color | Title bar logo tint | `FF5649B0` | `FF9184EE` | `FFFFFFFF` |
| `EnvironmentLayeredBackground` | Layered/translucent background | Overlays, glass effects | `80FFFFFF` | `4D3A3A3A` | `FF000000` |

## Use tokens in a theme extension

To use these tokens in a `.vstheme` file:

```xml
<Themes>
  <Theme Name="My Custom Theme" GUID="{your-theme-guid}" FallbackId="{de3dbbcd-f642-433c-8353-8f1df4370aba}">
    <Category Name="Shell" GUID="{73708ded-2d56-4aad-b8eb-73b20d3f4bff}">
      <Color Name="AccentFillDefault">
        <Background Type="CT_RAW" Source="FF0078D4" />
      </Color>
      <!-- Override additional Shell tokens as needed -->
    </Category>
    <Category Name="ShellInternal" GUID="{5af241b7-5627-4d12-bfb1-2b67d11127d7}">
      <Color Name="EnvironmentBackground">
        <Background Type="CT_RAW" Source="FFF0F0F0" />
      </Color>
      <!-- Override additional ShellInternal tokens as needed -->
    </Category>
  </Theme>
</Themes>
```

> [!NOTE]
> You only need to include tokens you want to override. Visual Studio falls back to the base theme (specified by `FallbackId`) for any tokens you don't define.

## Related content

- [Modernize theme colors](../advanced/modernize-theme-colors.md) — migration guidance for existing themes
- [Theme your extension UI](../recipes/themes-colors-fonts.md) — apply theming to your extension's custom UI
- [Colors and styling for Visual Studio ↗](/visualstudio/extensibility/ux-guidelines/colors-and-styling-for-visual-studio) — UX guidelines
- [Shared colors for Visual Studio ↗](/visualstudio/extensibility/ux-guidelines/shared-colors-for-visual-studio) — shared color reference
