---
title: Visual Studio Theme Color Tokens
description: Reference for the theme color tokens used in Fluent UI in Visual Studio 2026.
ms.date: 5/12/2026
ms.topic: reference
helpviewer_keywords:
- content_types
- content types
- opc
- vsix
author: chryw
ms.author: cherwan
ms.subservice: extensibility-integration
---

# Visual Studio theme color tokens

Visual Studio uses semantic color tokens to define the appearance of every UI surface. These tokens are part of the Fluent design system introduced in Visual Studio 2026. Instead of referencing specific hex colors, each control and surface references a named token. Themes provide values for these tokens, and the entire IDE updates accordingly.

This reference lists every available theme color token, its intended usage, and its default values in the Light, Dark, and High Contrast themes. Use this reference when creating custom themes or overriding individual tokens in your settings.

## How theme tokens work

Each token is a semantic name that maps to a color value. Tokens are organized into two categories:

- **Shell** (`ShellColors`) — tokens for common controls and surfaces, derived from the [Windows 11 Fluent design system](/windows/apps/develop/platform/xaml/xaml-theme-resources#light-and-dark-theme-colors). These cover buttons, text boxes, backgrounds, borders, status indicators, and more. Use these tokens for general UI styling.
- **Shell internal** (`ShellInternalColors`) — tokens for IDE chrome surfaces like the main window, title bar, status bar, and tool window headers. These are exposed for theme overrides but aren't intended for extension control styling.

### Color value format

Colors are specified in `#AARRGGBB` format (alpha, red, green, blue). For example, `#B2FFFFFF` is white at ~70% opacity.

High Contrast values are system color indices (for example, `00000008` = `WindowText`). Visual Studio resolves these to the user's current High Contrast color scheme at runtime.

## Shell colors

These tokens style common controls and surfaces across Visual Studio. They follow the same naming conventions as Windows 11 Fluent theme resources.

### Accent

Tokens for accent-colored elements like primary buttons, selected checkboxes, and active indicators.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `AccentFillAlt` | Alternative accent background, used when a different hue from Default is needed | ![swatch](https://placehold.co/16x16/3F3682/3F3682.svg) `#FF3F3682` | ![swatch](https://placehold.co/16x16/D2CCF8/D2CCF8.svg) `#FFD2CCF8` | `0000000D` |
| `AccentFillDefault` | Default accent background for interactive elements, calls to action, and selected states | ![swatch](https://placehold.co/16x16/5649B0/5649B0.svg) `#FF5649B0` | ![swatch](https://placehold.co/16x16/9184EE/9184EE.svg) `#FF9184EE` | `0000000D` |
| `AccentFillDisabled` | Disabled accent background | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#37000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#28FFFFFF` | `00000010` |
| `AccentFillSecondary` | Accent background indicating hover state | ![swatch](https://placehold.co/16x16/5649B0/5649B0.svg) `#E55649B0` | ![swatch](https://placehold.co/16x16/9184EE/9184EE.svg) `#E59184EE` | `0000000D` |
| `AccentFillSelectedTextBackground` | Background for selected text in active text fields | ![swatch](https://placehold.co/16x16/0078D4/0078D4.svg) `#FF0078D4` | ![swatch](https://placehold.co/16x16/005FB7/005FB7.svg) `#FF005FB7` | `0000000D` |
| `AccentFillSelectedTextBackgroundSubtle` | Subtle selected text background, used when foreground text color can't be inverted | ![swatch](https://placehold.co/16x16/0078D4/0078D4.svg) `#4D0078D4` | ![swatch](https://placehold.co/16x16/60CDFF/60CDFF.svg) `#6660CDFF` | `0000000D` |
| `AccentFillSenary` | Subtle accent background for states beyond Tertiary | ![swatch](https://placehold.co/16x16/5649B0/5649B0.svg) `#1F5649B0` | ![swatch](https://placehold.co/16x16/9184EE/9184EE.svg) `#1F9184EE` | `0000000E` |
| `AccentFillTertiary` | Accent background indicating pressed state | ![swatch](https://placehold.co/16x16/5649B0/5649B0.svg) `#CC5649B0` | ![swatch](https://placehold.co/16x16/9184EE/9184EE.svg) `#CC9184EE` | `0000000D` |
| `AccentTextFillDisabled` | Disabled accent text and glyph color | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#5C000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#5DFFFFFF` | `00000011` |
| `AccentTextFillPrimary` | Primary accent text color for foreground text and glyphs requiring emphasis | ![swatch](https://placehold.co/16x16/3F3682/3F3682.svg) `#FF3F3682` | ![swatch](https://placehold.co/16x16/D2CCF8/D2CCF8.svg) `#FFD2CCF8` | `00000002` |
| `AccentTextFillSecondary` | Accent text indicating hover state | ![swatch](https://placehold.co/16x16/221D46/221D46.svg) `#FF221D46` | ![swatch](https://placehold.co/16x16/D2CCF8/D2CCF8.svg) `#FFD2CCF8` | `00000002` |
| `AccentTextFillTertiary` | Accent text indicating pressed state | ![swatch](https://placehold.co/16x16/5649B0/5649B0.svg) `#FF5649B0` | ![swatch](https://placehold.co/16x16/A79CF1/A79CF1.svg) `#FFA79CF1` | `00000002` |

### Card

Tokens for card-like surfaces — content blocks that sit on page or layer backgrounds.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `CardBackgroundFillDefault` | Default card background | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#B2FFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#0DFFFFFF` | `00000005` |
| `CardBackgroundFillSecondary` | Card background indicating hover state | ![swatch](https://placehold.co/16x16/F6F6F6/F6F6F6.svg) `#80F6F6F6` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#08FFFFFF` | `00000005` |
| `CardBackgroundFillTertiary` | Card background indicating pressed state | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#12FFFFFF` | `00000005` |
| `CardStrokeDefault` | Default card border | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#0F000000` | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#1A000000` | `00000010` |
| `CardStrokeDefaultSolid` | Solid card border, used when semi-transparent strokes cause visibility problems | ![swatch](https://placehold.co/16x16/EBEBEB/EBEBEB.svg) `#FFEBEBEB` | ![swatch](https://placehold.co/16x16/1C1C1C/1C1C1C.svg) `#FF1C1C1C` | `00000010` |
| `CardStrokeDefaultSolidAlt` | Alternative solid card border | ![swatch](https://placehold.co/16x16/DADADA/DADADA.svg) `#FFDADADA` | ![swatch](https://placehold.co/16x16/0A0A0A/0A0A0A.svg) `#FF0A0A0A` | `00000010` |

### Control

Tokens for standard interactive controls like buttons, text boxes, and combo boxes.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `ControlAltFillDisabled` | Disabled alternative control background | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#00FFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#00FFFFFF` | `0000000F` |
| `ControlAltFillQuaternary` | Fourth-level alternative control background | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#18000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#12FFFFFF` | `0000000E` |
| `ControlAltFillSecondary` | Second-level alternative control background | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#06000000` | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#1A000000` | `0000000E` |
| `ControlAltFillTertiary` | Third-level alternative control background | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#0F000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#0BFFFFFF` | `0000000E` |
| `ControlAltFillTransparent` | Transparent alternative control background | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#00FFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#00FFFFFF` | `0000000E` |
| `ControlFillActiveInput` | Control background during active text input | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | ![swatch](https://placehold.co/16x16/1E1E1E/1E1E1E.svg) `#B21E1E1E` | `0000000F` |
| `ControlFillDefault` | Default control background (rest state) | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#B2FFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#0FFFFFFF` | `0000000F` |
| `ControlFillDisabled` | Disabled control background | ![swatch](https://placehold.co/16x16/F9F9F9/F9F9F9.svg) `#4DF9F9F9` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#0BFFFFFF` | `0000000F` |
| `ControlFillQuaternary` | Fourth-level control background | ![swatch](https://placehold.co/16x16/F3F3F3/F3F3F3.svg) `#C2F3F3F3` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#0FFFFFFF` | `0000000E` |
| `ControlFillSecondary` | Second-level control background (hover) | ![swatch](https://placehold.co/16x16/F9F9F9/F9F9F9.svg) `#80F9F9F9` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#15FFFFFF` | `0000000E` |
| `ControlFillTertiary` | Third-level control background (pressed) | ![swatch](https://placehold.co/16x16/F9F9F9/F9F9F9.svg) `#4DF9F9F9` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#08FFFFFF` | `0000000E` |
| `ControlFillTransparent` | Transparent control background | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#00FFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#00FFFFFF` | `0000000F` |
| `ControlOnImageFillDefault` | Default control background when placed on an image | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#C9FFFFFF` | ![swatch](https://placehold.co/16x16/1C1C1C/1C1C1C.svg) `#B21C1C1C` | `0000000F` |
| `ControlOnImageFillDisabled` | Disabled control background when placed on an image | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#00FFFFFF` | ![swatch](https://placehold.co/16x16/1E1E1E/1E1E1E.svg) `#001E1E1E` | `0000000F` |
| `ControlOnImageFillSecondary` | Hover control background when placed on an image | ![swatch](https://placehold.co/16x16/F3F3F3/F3F3F3.svg) `#FFF3F3F3` | ![swatch](https://placehold.co/16x16/1A1A1A/1A1A1A.svg) `#FF1A1A1A` | `0000000E` |
| `ControlOnImageFillTertiary` | Pressed control background when placed on an image | ![swatch](https://placehold.co/16x16/EBEBEB/EBEBEB.svg) `#FFEBEBEB` | ![swatch](https://placehold.co/16x16/131313/131313.svg) `#FF131313` | `0000000E` |
| `ControlSolidFillDefault` | Solid control background, used when transparency causes visibility problems | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | ![swatch](https://placehold.co/16x16/454545/454545.svg) `#FF454545` | `0000000F` |
| `ControlStrokeDefault` | Default control border (rest state) | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#0F000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#12FFFFFF` | `00000010` |
| `ControlStrokeForStrongFillWhenOnImage` | Control border for strong fills placed on images | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#59FFFFFF` | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#6B000000` | `0000000A` |
| `ControlStrokeOnAccentDefault` | Default border for controls on accent backgrounds | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#14FFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#14FFFFFF` | `0000000B` |
| `ControlStrokeOnAccentDisabled` | Disabled border for controls on accent backgrounds | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#0F000000` | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#33000000` | `0000000B` |
| `ControlStrokeOnAccentSecondary` | Hover border for controls on accent backgrounds | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#66000000` | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#24000000` | `0000000B` |
| `ControlStrokeOnAccentTertiary` | Pressed border for controls on accent backgrounds | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#37000000` | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#37000000` | `0000000B` |
| `ControlStrokeSecondary` | Second-level control border | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#0F000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#12FFFFFF` | `00000008` |
| `ControlStrokeTransparent` | Transparent control border | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#00FFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#00FFFFFF` | `0000000F` |
| `ControlStrongFillDefault` | Strong control fill for high-contrast elements like scroll bars | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#72000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#8BFFFFFF` | `0000000A` |
| `ControlStrongFillDisabled` | Disabled strong control fill | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#51000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#3FFFFFFF` | `0000000F` |
| `ControlStrongStrokeDefault` | Strong control border for checkboxes and radio buttons | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#9C000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#9AFFFFFF` | `00000008` |
| `ControlStrongStrokeDisabled` | Disabled strong control border | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#37000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#28FFFFFF` | `0000000B` |

### Divider

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `DividerStrokeDefault` | Default divider and separator stroke | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#14000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#15FFFFFF` | `00000011` |

### Focus

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `FocusStrokeInner` | Inner focus indicator stroke | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#B2000000` | `00000005` |
| `FocusStrokeOuter` | Outer focus indicator stroke | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#E4000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | `00000008` |

### Hyperlink

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `HyperlinkFillDisabled` | Disabled hyperlink text color | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#5C000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#5DFFFFFF` | `00000013` |
| `HyperlinkFillPrimary` | Primary hyperlink text color (rest) | ![swatch](https://placehold.co/16x16/003E92/003E92.svg) `#FF003E92` | ![swatch](https://placehold.co/16x16/99EBFF/99EBFF.svg) `#FF99EBFF` | `0000001A` |
| `HyperlinkFillSecondary` | Hyperlink text color (hover) | ![swatch](https://placehold.co/16x16/001A68/001A68.svg) `#FF001A68` | ![swatch](https://placehold.co/16x16/60CDFF/60CDFF.svg) `#FF60CDFF` | `0000001A` |
| `HyperlinkFillTertiary` | Hyperlink text color (pressed) | ![swatch](https://placehold.co/16x16/005FB8/005FB8.svg) `#FF005FB8` | ![swatch](https://placehold.co/16x16/60CDFF/60CDFF.svg) `#E560CDFF` | `0000001A` |

### Layer and surface

Tokens for backgrounds, layered surfaces, and page-level containers.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `LayerFillAlt` | Alternative layer fill for surfaces | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#0EFFFFFF` | `00000005` |
| `LayerFillDefault` | Default layer fill for surfaces and scroll bars | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#80FFFFFF` | ![swatch](https://placehold.co/16x16/3A3A3A/3A3A3A.svg) `#4D3A3A3A` | `00000005` |
| `SolidBackgroundFillBase` | Base solid background for page surfaces | ![swatch](https://placehold.co/16x16/F3F3F3/F3F3F3.svg) `#FFF3F3F3` | ![swatch](https://placehold.co/16x16/202020/202020.svg) `#FF202020` | `00000005` |
| `SolidBackgroundFillBaseAlt` | Alternative base solid background | ![swatch](https://placehold.co/16x16/DADADA/DADADA.svg) `#FFDADADA` | ![swatch](https://placehold.co/16x16/0A0A0A/0A0A0A.svg) `#FF0A0A0A` | `00000005` |
| `SolidBackgroundFillSecondary` | Secondary solid background (one level above Base) | ![swatch](https://placehold.co/16x16/EEEEEE/EEEEEE.svg) `#FFEEEEEE` | ![swatch](https://placehold.co/16x16/1C1C1C/1C1C1C.svg) `#FF1C1C1C` | `00000005` |
| `SolidBackgroundFillTertiary` | Tertiary solid background | ![swatch](https://placehold.co/16x16/F9F9F9/F9F9F9.svg) `#FFF9F9F9` | ![swatch](https://placehold.co/16x16/282828/282828.svg) `#FF282828` | `00000005` |
| `SolidBackgroundFillQuaternary` | Fourth-level solid background | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | ![swatch](https://placehold.co/16x16/2C2C2C/2C2C2C.svg) `#FF2C2C2C` | `00000005` |
| `SolidBackgroundFillQuinary` | Fifth-level solid background | ![swatch](https://placehold.co/16x16/FDFDFD/FDFDFD.svg) `#FFFDFDFD` | ![swatch](https://placehold.co/16x16/333333/333333.svg) `#FF333333` | `00000005` |
| `SolidBackgroundFillSenary` | Sixth-level solid background | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | ![swatch](https://placehold.co/16x16/373737/373737.svg) `#FF373737` | `00000005` |
| `SurfaceBackgroundFillDefault` | Default background for discrete surfaces above base | ![swatch](https://placehold.co/16x16/F9F9F9/F9F9F9.svg) `#FFF9F9F9` | ![swatch](https://placehold.co/16x16/2C2C2C/2C2C2C.svg) `#FF2C2C2C` | `00000005` |
| `SurfaceStrokeDefault` | Default surface border | ![swatch](https://placehold.co/16x16/757575/757575.svg) `#66757575` | ![swatch](https://placehold.co/16x16/757575/757575.svg) `#66757575` | `0000000A` |
| `SurfaceStrokeFlyout` | Flyout surface border | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#0F000000` | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#33000000` | `0000000A` |

### Shadow and smoke

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `ShadowFlyout` | Shadow color for flyout surfaces like popups, tooltips, and context menus | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#24000000` | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#42000000` | `00000005` |
| `SmokeFillDefault` | Smoke overlay color for dimming background surfaces | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#4D000000` | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#4D000000` | `0000000F` |
| `SmokeFillInverse` | Inverse smoke overlay color | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#C9FFFFFF` | ![swatch](https://placehold.co/16x16/1C1C1C/1C1C1C.svg) `#B21C1C1C` | `0000000F` |

### Subtle

Tokens for controls with minimal visual weight, like toolbar buttons and menu items.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `SubtleFillDisabled` | Disabled subtle control fill | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#00000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#00FFFFFF` | `00000005` |
| `SubtleFillSecondary` | Subtle control fill (hover) | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#0F000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#0FFFFFFF` | `0000000F` |
| `SubtleFillTertiary` | Subtle control fill (pressed) | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#0A000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#0BFFFFFF` | `0000000F` |
| `SubtleFillTransparent` | Transparent subtle control fill | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#00FFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#00FFFFFF` | `00000005` |

### System status

Tokens for status indicators — attention, caution, critical, success, and neutral.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `SystemFillAttention` | Attention indicator border and stroke (informational) | ![swatch](https://placehold.co/16x16/005FB7/005FB7.svg) `#FF005FB7` | ![swatch](https://placehold.co/16x16/60CDFF/60CDFF.svg) `#FF60CDFF` | `00000002` |
| `SystemFillAttentionBackground` | Attention indicator background | ![swatch](https://placehold.co/16x16/F6F6F6/F6F6F6.svg) `#80F6F6F6` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#08FFFFFF` | `00000018` |
| `SystemFillCaution` | Warning indicator border and stroke | ![swatch](https://placehold.co/16x16/9D5D00/9D5D00.svg) `#FF9D5D00` | ![swatch](https://placehold.co/16x16/FCE100/FCE100.svg) `#FFFCE100` | `00000002` |
| `SystemFillCautionBackground` | Warning indicator background | ![swatch](https://placehold.co/16x16/FFF4CE/FFF4CE.svg) `#FFFFF4CE` | ![swatch](https://placehold.co/16x16/433519/433519.svg) `#FF433519` | `00000018` |
| `SystemFillCritical` | Error indicator border and stroke | ![swatch](https://placehold.co/16x16/C42B1C/C42B1C.svg) `#FFC42B1C` | ![swatch](https://placehold.co/16x16/FF99A4/FF99A4.svg) `#FFFF99A4` | `00000002` |
| `SystemFillCriticalBackground` | Error indicator background | ![swatch](https://placehold.co/16x16/FDE7E9/FDE7E9.svg) `#FFFDE7E9` | ![swatch](https://placehold.co/16x16/442726/442726.svg) `#FF442726` | `00000018` |
| `SystemFillNeutral` | Neutral system fill | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#72000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#8BFFFFFF` | `00000002` |
| `SystemFillNeutralBackground` | Neutral system background | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#06000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#08FFFFFF` | `00000018` |
| `SystemFillSolidAttentionBackground` | Solid attention background, used when transparency causes visibility problems | ![swatch](https://placehold.co/16x16/F7F7F7/F7F7F7.svg) `#FFF7F7F7` | ![swatch](https://placehold.co/16x16/2E2E2E/2E2E2E.svg) `#FF2E2E2E` | `00000018` |
| `SystemFillSolidNeutral` | Solid neutral indicator fill | ![swatch](https://placehold.co/16x16/8A8A8A/8A8A8A.svg) `#FF8A8A8A` | ![swatch](https://placehold.co/16x16/8A8A8A/8A8A8A.svg) `#FF8A8A8A` | `00000002` |
| `SystemFillSolidNeutralBackground` | Solid neutral background | ![swatch](https://placehold.co/16x16/F3F3F3/F3F3F3.svg) `#FFF3F3F3` | ![swatch](https://placehold.co/16x16/2E2E2E/2E2E2E.svg) `#FF2E2E2E` | `00000018` |
| `SystemFillSuccess` | Success indicator border and stroke | ![swatch](https://placehold.co/16x16/0F7B0F/0F7B0F.svg) `#FF0F7B0F` | ![swatch](https://placehold.co/16x16/6CCB5F/6CCB5F.svg) `#FF6CCB5F` | `00000002` |
| `SystemFillSuccessBackground` | Success indicator background | ![swatch](https://placehold.co/16x16/DFF6DD/DFF6DD.svg) `#FFDFF6DD` | ![swatch](https://placehold.co/16x16/393D1B/393D1B.svg) `#FF393D1B` | `00000018` |

### Text

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `TextFillDisabled` | Disabled text color | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#5C000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#5DFFFFFF` | `00000011` |
| `TextFillPrimary` | Primary text color for general content | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#E4000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | `00000008` |
| `TextFillSecondary` | Secondary text color for supplementary content and hints | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#9E000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#C8FFFFFF` | `00000008` |
| `TextFillTertiary` | Tertiary text color (low contrast — don't use for primary content at rest) | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#72000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#8BFFFFFF` | `00000008` |
| `TextOnAccentFillDisabled` | Disabled text on accent backgrounds | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#B2FFFFFF` | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#80000000` | `00000003` |
| `TextOnAccentFillPrimary` | Primary text on accent backgrounds | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#FF000000` | `0000000E` |
| `TextOnAccentFillSecondary` | Secondary text on accent backgrounds | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#B2FFFFFF` | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#80000000` | `0000000E` |
| `TextOnAccentFillSelectedText` | Text color for selected text on accent backgrounds | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | `0000000E` |

## Shell internal colors

These tokens control IDE chrome surfaces — the main window frame, tool window headers, tabs, status bar, and other shell-level elements. They're the primary tokens theme authors use to change the overall feel of the IDE.

### Environment

Tokens that control the main window and shell chrome surfaces.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `EnvironmentBackground` | Main window background and floating tool windows | ![swatch](https://placehold.co/16x16/EEEEEE/EEEEEE.svg) `#FFEEEEEE` | ![swatch](https://placehold.co/16x16/1C1C1C/1C1C1C.svg) `#FF1C1C1C` | `00000005` |
| `EnvironmentBadge` | Solution Info Badge background (for example, Live Share indicator) | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#B2FFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#0FFFFFFF` | `0000000F` |
| `EnvironmentBody` | Body/content area background of the main shell window | ![swatch](https://placehold.co/16x16/EEEEEE/EEEEEE.svg) `#FFEEEEEE` | ![swatch](https://placehold.co/16x16/1C1C1C/1C1C1C.svg) `#FF1C1C1C` | `00000005` |
| `EnvironmentBodyText` | Text color in the body/content area of the main shell window | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#E4000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | `00000008` |
| `EnvironmentBorder` | Active main window border | ![swatch](https://placehold.co/16x16/5649B0/5649B0.svg) `#FF5649B0` | ![swatch](https://placehold.co/16x16/9184EE/9184EE.svg) `#FF9184EE` | `0000000A` |
| `EnvironmentBorderInactive` | Inactive main window border and internal dividers | ![swatch](https://placehold.co/16x16/ADADAD/ADADAD.svg) `#FFADADAD` | ![swatch](https://placehold.co/16x16/454545/454545.svg) `#FF454545` | `00000003` |
| `EnvironmentHeader` | Background for active header areas | ![swatch](https://placehold.co/16x16/F9F9F9/F9F9F9.svg) `#FFF9F9F9` | ![swatch](https://placehold.co/16x16/282828/282828.svg) `#FF282828` | `00000005` |
| `EnvironmentHeaderInactive` | Background for inactive header areas | ![swatch](https://placehold.co/16x16/F9F9F9/F9F9F9.svg) `#FFF9F9F9` | ![swatch](https://placehold.co/16x16/282828/282828.svg) `#FF282828` | `00000005` |
| `EnvironmentIndicator` | Border or indicator for auto-hidden tabs | ![swatch](https://placehold.co/16x16/757575/757575.svg) `#66757575` | ![swatch](https://placehold.co/16x16/757575/757575.svg) `#66757575` | `0000000A` |
| `EnvironmentLayeredBackground` | Background for layered elements like InfoBars and tab groups | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#80FFFFFF` | ![swatch](https://placehold.co/16x16/3A3A3A/3A3A3A.svg) `#4D3A3A3A` | `00000005` |
| `EnvironmentLayeredBorder` | Border for layered elements like InfoBars and badges | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#0F000000` | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#80000000` | `00000010` |
| `EnvironmentLogo` | Visual Studio logo fill in the system menu | ![swatch](https://placehold.co/16x16/5649B0/5649B0.svg) `#FF5649B0` | ![swatch](https://placehold.co/16x16/9184EE/9184EE.svg) `#FF9184EE` | `0000000D` |
| `EnvironmentTab` | Tab element background | ![swatch](https://placehold.co/16x16/F9F9F9/F9F9F9.svg) `#FFF9F9F9` | ![swatch](https://placehold.co/16x16/282828/282828.svg) `#FF282828` | `00000005` |
| `EnvironmentTabInactive` | Inactive tab element background | ![swatch](https://placehold.co/16x16/F9F9F9/F9F9F9.svg) `#FFF9F9F9` | ![swatch](https://placehold.co/16x16/282828/282828.svg) `#FF282828` | `00000005` |

### Caption

Tokens for the window close button specifically.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `CaptionControlCloseFillPrimary` | Close button background (hover) | ![swatch](https://placehold.co/16x16/C42B1C/C42B1C.svg) `#FFC42B1C` | ![swatch](https://placehold.co/16x16/C42B1C/C42B1C.svg) `#FFC42B1C` | `0000000D` |
| `CaptionControlCloseFillSecondary` | Close button background (pressed) | ![swatch](https://placehold.co/16x16/C42B1C/C42B1C.svg) `#E6C42B1C` | ![swatch](https://placehold.co/16x16/C42B1C/C42B1C.svg) `#E6C42B1C` | `0000000D` |
| `CaptionControlCloseTextFillPrimary` | Close button icon color (hover) | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | `00000009` |
| `CaptionControlCloseTextFillSecondary` | Close button icon color (pressed) | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#B3FFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#B3FFFFFF` | `00000009` |

### Status bar

Tokens for the status bar across its different modes.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `StatusBarBackgroundFillBuilding` | Status bar background when building | ![swatch](https://placehold.co/16x16/5649B0/5649B0.svg) `#FF5649B0` | ![swatch](https://placehold.co/16x16/3F3682/3F3682.svg) `#FF3F3682` | `00000005` |
| `StatusBarBackgroundFillDebugging` | Status bar background when debugging | ![swatch](https://placehold.co/16x16/BC4B09/BC4B09.svg) `#FFBC4B09` | ![swatch](https://placehold.co/16x16/7A2101/7A2101.svg) `#FF7A2101` | `00000005` |
| `StatusBarBackgroundFillRest` | Status bar background in default state | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#8B000000` | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#4D000000` | `00000005` |
| `StatusBarBackgroundFillSolutionLoading` | Status bar background when loading a solution | ![swatch](https://placehold.co/16x16/005BA1/005BA1.svg) `#FF005BA1` | ![swatch](https://placehold.co/16x16/003B6A/003B6A.svg) `#FF003B6A` | `00000005` |
| `StatusBarControlFillSecondary` | Secondary control fill on the status bar | ![swatch](https://placehold.co/16x16/000000/000000.svg) `#33000000` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#20FFFFFF` | `0000000E` |
| `StatusBarTextFillBuilding` | Status bar text when building | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | `00000008` |
| `StatusBarTextFillDebugging` | Status bar text when debugging | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | `00000008` |
| `StatusBarTextFillDisabled` | Disabled status bar text | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#90FFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#5DFFFFFF` | `00000011` |
| `StatusBarTextFillRest` | Status bar text in default state | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | `00000008` |
| `StatusBarTextFillSolutionLoading` | Status bar text when loading a solution | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | ![swatch](https://placehold.co/16x16/FFFFFF/FFFFFF.svg) `#FFFFFFFF` | `00000008` |

## High Contrast system color reference

High Contrast values are system color indices. Visual Studio maps these to the user's active High Contrast color scheme. Common indices:

| Index | System color |
|:------|:-------------|
| `00000001` | `ActiveCaption` |
| `00000002` | `ActiveCaptionText` |
| `00000003` | `ActiveBorder` |
| `00000005` | `Window` |
| `00000008` | `WindowText` |
| `00000009` | `HotTrackColor` |
| `0000000A` | `InactiveBorder` |
| `0000000B` | `InactiveCaption` |
| `0000000D` | `Highlight` |
| `0000000E` | `HighlightText` |
| `0000000F` | `ButtonFace` |
| `00000010` | `ButtonShadow` |
| `00000011` | `GrayText` |
| `00000013` | `InactiveCaptionText` |
| `00000018` | `GradientActiveCaption` |
| `0000001A` | `HotLight` |

## See also

- [Color theming tools](color-theming-tools.md)
- [Modernize theme colors](../migration/modernize-theme-colors.md)
- [Matching Visual Studio themes in Visual Studio extensions](../vsix/recipes/use-themes.md)
- [Change fonts, colors, and themes in Visual Studio](../ide/how-to-change-fonts-and-colors-in-visual-studio.md)
