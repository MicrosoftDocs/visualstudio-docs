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
monikerRange: "visualstudio"
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
| `AccentFillAlt` | Alternative accent background, used when a different hue from Default is needed | :::image type="icon" source="media/visualstudio/swatch-024.svg" alt-text="Color swatch #3F3682 image 001" border="true"::: `#FF3F3682` | :::image type="icon" source="media/visualstudio/swatch-041.svg" alt-text="Color swatch #D2CCF8 image 002" border="true"::: `#FFD2CCF8` | `0000000D` |
| `AccentFillDefault` | Default accent background for interactive elements, calls to action, and selected states | :::image type="icon" source="media/visualstudio/swatch-028.svg" alt-text="Color swatch #5649B0 image 003" border="true"::: `#FF5649B0` | :::image type="icon" source="media/visualstudio/swatch-034.svg" alt-text="Color swatch #9184EE image 004" border="true"::: `#FF9184EE` | `0000000D` |
| `AccentFillDisabled` | Disabled accent background | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 005" border="true"::: `#37000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 006" border="true"::: `#28FFFFFF` | `00000010` |
| `AccentFillSecondary` | Accent background indicating hover state | :::image type="icon" source="media/visualstudio/swatch-028.svg" alt-text="Color swatch #5649B0 image 007" border="true"::: `#E55649B0` | :::image type="icon" source="media/visualstudio/swatch-034.svg" alt-text="Color swatch #9184EE image 008" border="true"::: `#E59184EE` | `0000000D` |
| `AccentFillSelectedTextBackground` | Background for selected text in active text fields | :::image type="icon" source="media/visualstudio/swatch-008.svg" alt-text="Color swatch #0078D4 image 009" border="true"::: `#FF0078D4` | :::image type="icon" source="media/visualstudio/swatch-006.svg" alt-text="Color swatch #005FB7 image 010" border="true"::: `#FF005FB7` | `0000000D` |
| `AccentFillSelectedTextBackgroundSubtle` | Subtle selected text background, used when foreground text color can't be inverted | :::image type="icon" source="media/visualstudio/swatch-008.svg" alt-text="Color swatch #0078D4 image 011" border="true"::: `#4D0078D4` | :::image type="icon" source="media/visualstudio/swatch-029.svg" alt-text="Color swatch #60CDFF image 012" border="true"::: `#6660CDFF` | `0000000D` |
| `AccentFillSenary` | Subtle accent background for states beyond Tertiary | :::image type="icon" source="media/visualstudio/swatch-028.svg" alt-text="Color swatch #5649B0 image 013" border="true"::: `#1F5649B0` | :::image type="icon" source="media/visualstudio/swatch-034.svg" alt-text="Color swatch #9184EE image 014" border="true"::: `#1F9184EE` | `0000000E` |
| `AccentFillTertiary` | Accent background indicating pressed state | :::image type="icon" source="media/visualstudio/swatch-028.svg" alt-text="Color swatch #5649B0 image 015" border="true"::: `#CC5649B0` | :::image type="icon" source="media/visualstudio/swatch-034.svg" alt-text="Color swatch #9184EE image 016" border="true"::: `#CC9184EE` | `0000000D` |
| `AccentTextFillDisabled` | Disabled accent text and glyph color | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 017" border="true"::: `#5C000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 018" border="true"::: `#5DFFFFFF` | `00000011` |
| `AccentTextFillPrimary` | Primary accent text color for foreground text and glyphs requiring emphasis | :::image type="icon" source="media/visualstudio/swatch-024.svg" alt-text="Color swatch #3F3682 image 019" border="true"::: `#FF3F3682` | :::image type="icon" source="media/visualstudio/swatch-041.svg" alt-text="Color swatch #D2CCF8 image 020" border="true"::: `#FFD2CCF8` | `00000002` |
| `AccentTextFillSecondary` | Accent text indicating hover state | :::image type="icon" source="media/visualstudio/swatch-016.svg" alt-text="Color swatch #221D46 image 021" border="true"::: `#FF221D46` | :::image type="icon" source="media/visualstudio/swatch-041.svg" alt-text="Color swatch #D2CCF8 image 022" border="true"::: `#FFD2CCF8` | `00000002` |
| `AccentTextFillTertiary` | Accent text indicating pressed state | :::image type="icon" source="media/visualstudio/swatch-028.svg" alt-text="Color swatch #5649B0 image 023" border="true"::: `#FF5649B0` | :::image type="icon" source="media/visualstudio/swatch-037.svg" alt-text="Color swatch #A79CF1 image 024" border="true"::: `#FFA79CF1` | `00000002` |

### Card

Tokens for card-like surfaces — content blocks that sit on page or layer backgrounds.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `CardBackgroundFillDefault` | Default card background | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 025" border="true"::: `#B2FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 026" border="true"::: `#0DFFFFFF` | `00000005` |
| `CardBackgroundFillSecondary` | Card background indicating hover state | :::image type="icon" source="media/visualstudio/swatch-047.svg" alt-text="Color swatch #F6F6F6 image 027" border="true"::: `#80F6F6F6` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 028" border="true"::: `#08FFFFFF` | `00000005` |
| `CardBackgroundFillTertiary` | Card background indicating pressed state | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 029" border="true"::: `#FFFFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 030" border="true"::: `#12FFFFFF` | `00000005` |
| `CardStrokeDefault` | Default card border | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 031" border="true"::: `#0F000000` | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 032" border="true"::: `#1A000000` | `00000010` |
| `CardStrokeDefaultSolid` | Solid card border, used when semi-transparent strokes cause visibility problems | :::image type="icon" source="media/visualstudio/swatch-044.svg" alt-text="Color swatch #EBEBEB image 033" border="true"::: `#FFEBEBEB` | :::image type="icon" source="media/visualstudio/swatch-013.svg" alt-text="Color swatch #1C1C1C image 034" border="true"::: `#FF1C1C1C` | `00000010` |
| `CardStrokeDefaultSolidAlt` | Alternative solid card border | :::image type="icon" source="media/visualstudio/swatch-042.svg" alt-text="Color swatch #DADADA image 035" border="true"::: `#FFDADADA` | :::image type="icon" source="media/visualstudio/swatch-009.svg" alt-text="Color swatch #0A0A0A image 036" border="true"::: `#FF0A0A0A` | `00000010` |

### Control

Tokens for standard interactive controls like buttons, text boxes, and combo boxes.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `ControlAltFillDisabled` | Disabled alternative control background | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 037" border="true"::: `#00FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 038" border="true"::: `#00FFFFFF` | `0000000F` |
| `ControlAltFillQuaternary` | Fourth-level alternative control background | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 039" border="true"::: `#18000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 040" border="true"::: `#12FFFFFF` | `0000000E` |
| `ControlAltFillSecondary` | Second-level alternative control background | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 041" border="true"::: `#06000000` | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 042" border="true"::: `#1A000000` | `0000000E` |
| `ControlAltFillTertiary` | Third-level alternative control background | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 043" border="true"::: `#0F000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 044" border="true"::: `#0BFFFFFF` | `0000000E` |
| `ControlAltFillTransparent` | Transparent alternative control background | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 045" border="true"::: `#00FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 046" border="true"::: `#00FFFFFF` | `0000000E` |
| `ControlFillActiveInput` | Control background during active text input | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 047" border="true"::: `#FFFFFFFF` | :::image type="icon" source="media/visualstudio/swatch-014.svg" alt-text="Color swatch #1E1E1E image 048" border="true"::: `#B21E1E1E` | `0000000F` |
| `ControlFillDefault` | Default control background (rest state) | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 049" border="true"::: `#B2FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 050" border="true"::: `#0FFFFFFF` | `0000000F` |
| `ControlFillDisabled` | Disabled control background | :::image type="icon" source="media/visualstudio/swatch-049.svg" alt-text="Color swatch #F9F9F9 image 051" border="true"::: `#4DF9F9F9` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 052" border="true"::: `#0BFFFFFF` | `0000000F` |
| `ControlFillQuaternary` | Fourth-level control background | :::image type="icon" source="media/visualstudio/swatch-046.svg" alt-text="Color swatch #F3F3F3 image 053" border="true"::: `#C2F3F3F3` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 054" border="true"::: `#0FFFFFFF` | `0000000E` |
| `ControlFillSecondary` | Second-level control background (hover) | :::image type="icon" source="media/visualstudio/swatch-049.svg" alt-text="Color swatch #F9F9F9 image 055" border="true"::: `#80F9F9F9` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 056" border="true"::: `#15FFFFFF` | `0000000E` |
| `ControlFillTertiary` | Third-level control background (pressed) | :::image type="icon" source="media/visualstudio/swatch-049.svg" alt-text="Color swatch #F9F9F9 image 057" border="true"::: `#4DF9F9F9` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 058" border="true"::: `#08FFFFFF` | `0000000E` |
| `ControlFillTransparent` | Transparent control background | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 059" border="true"::: `#00FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 060" border="true"::: `#00FFFFFF` | `0000000F` |
| `ControlOnImageFillDefault` | Default control background when placed on an image | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 061" border="true"::: `#C9FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-013.svg" alt-text="Color swatch #1C1C1C image 062" border="true"::: `#B21C1C1C` | `0000000F` |
| `ControlOnImageFillDisabled` | Disabled control background when placed on an image | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 063" border="true"::: `#00FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-014.svg" alt-text="Color swatch #1E1E1E image 064" border="true"::: `#001E1E1E` | `0000000F` |
| `ControlOnImageFillSecondary` | Hover control background when placed on an image | :::image type="icon" source="media/visualstudio/swatch-046.svg" alt-text="Color swatch #F3F3F3 image 065" border="true"::: `#FFF3F3F3` | :::image type="icon" source="media/visualstudio/swatch-012.svg" alt-text="Color swatch #1A1A1A image 066" border="true"::: `#FF1A1A1A` | `0000000E` |
| `ControlOnImageFillTertiary` | Pressed control background when placed on an image | :::image type="icon" source="media/visualstudio/swatch-044.svg" alt-text="Color swatch #EBEBEB image 067" border="true"::: `#FFEBEBEB` | :::image type="icon" source="media/visualstudio/swatch-011.svg" alt-text="Color swatch #131313 image 068" border="true"::: `#FF131313` | `0000000E` |
| `ControlSolidFillDefault` | Solid control background, used when transparency causes visibility problems | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 069" border="true"::: `#FFFFFFFF` | :::image type="icon" source="media/visualstudio/swatch-027.svg" alt-text="Color swatch #454545 image 070" border="true"::: `#FF454545` | `0000000F` |
| `ControlStrokeDefault` | Default control border (rest state) | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 071" border="true"::: `#0F000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 072" border="true"::: `#12FFFFFF` | `00000010` |
| `ControlStrokeForStrongFillWhenOnImage` | Control border for strong fills placed on images | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 073" border="true"::: `#59FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 074" border="true"::: `#6B000000` | `0000000A` |
| `ControlStrokeOnAccentDefault` | Default border for controls on accent backgrounds | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 075" border="true"::: `#14FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 076" border="true"::: `#14FFFFFF` | `0000000B` |
| `ControlStrokeOnAccentDisabled` | Disabled border for controls on accent backgrounds | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 077" border="true"::: `#0F000000` | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 078" border="true"::: `#33000000` | `0000000B` |
| `ControlStrokeOnAccentSecondary` | Hover border for controls on accent backgrounds | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 079" border="true"::: `#66000000` | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 080" border="true"::: `#24000000` | `0000000B` |
| `ControlStrokeOnAccentTertiary` | Pressed border for controls on accent backgrounds | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 081" border="true"::: `#37000000` | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 082" border="true"::: `#37000000` | `0000000B` |
| `ControlStrokeSecondary` | Second-level control border | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 083" border="true"::: `#0F000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 084" border="true"::: `#12FFFFFF` | `00000008` |
| `ControlStrokeTransparent` | Transparent control border | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 085" border="true"::: `#00FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 086" border="true"::: `#00FFFFFF` | `0000000F` |
| `ControlStrongFillDefault` | Strong control fill for high-contrast elements like scroll bars | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 087" border="true"::: `#72000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 088" border="true"::: `#8BFFFFFF` | `0000000A` |
| `ControlStrongFillDisabled` | Disabled strong control fill | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 089" border="true"::: `#51000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 090" border="true"::: `#3FFFFFFF` | `0000000F` |
| `ControlStrongStrokeDefault` | Strong control border for checkboxes and radio buttons | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 091" border="true"::: `#9C000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 092" border="true"::: `#9AFFFFFF` | `00000008` |
| `ControlStrongStrokeDisabled` | Disabled strong control border | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 093" border="true"::: `#37000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 094" border="true"::: `#28FFFFFF` | `0000000B` |

### Divider

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `DividerStrokeDefault` | Default divider and separator stroke | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 095" border="true"::: `#14000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 096" border="true"::: `#15FFFFFF` | `00000011` |

### Focus

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `FocusStrokeInner` | Inner focus indicator stroke | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 097" border="true"::: `#FFFFFFFF` | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 098" border="true"::: `#B2000000` | `00000005` |
| `FocusStrokeOuter` | Outer focus indicator stroke | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 099" border="true"::: `#E4000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 100" border="true"::: `#FFFFFFFF` | `00000008` |

### Hyperlink

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `HyperlinkFillDisabled` | Disabled hyperlink text color | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 101" border="true"::: `#5C000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 102" border="true"::: `#5DFFFFFF` | `00000013` |
| `HyperlinkFillPrimary` | Primary hyperlink text color (rest) | :::image type="icon" source="media/visualstudio/swatch-004.svg" alt-text="Color swatch #003E92 image 103" border="true"::: `#FF003E92` | :::image type="icon" source="media/visualstudio/swatch-035.svg" alt-text="Color swatch #99EBFF image 104" border="true"::: `#FF99EBFF` | `0000001A` |
| `HyperlinkFillSecondary` | Hyperlink text color (hover) | :::image type="icon" source="media/visualstudio/swatch-002.svg" alt-text="Color swatch #001A68 image 105" border="true"::: `#FF001A68` | :::image type="icon" source="media/visualstudio/swatch-029.svg" alt-text="Color swatch #60CDFF image 106" border="true"::: `#FF60CDFF` | `0000001A` |
| `HyperlinkFillTertiary` | Hyperlink text color (pressed) | :::image type="icon" source="media/visualstudio/swatch-007.svg" alt-text="Color swatch #005FB8 image 107" border="true"::: `#FF005FB8` | :::image type="icon" source="media/visualstudio/swatch-029.svg" alt-text="Color swatch #60CDFF image 108" border="true"::: `#E560CDFF` | `0000001A` |

### Layer and surface

Tokens for backgrounds, layered surfaces, and page-level containers.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `LayerFillAlt` | Alternative layer fill for surfaces | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 109" border="true"::: `#FFFFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 110" border="true"::: `#0EFFFFFF` | `00000005` |
| `LayerFillDefault` | Default layer fill for surfaces and scroll bars | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 111" border="true"::: `#80FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-023.svg" alt-text="Color swatch #3A3A3A image 112" border="true"::: `#4D3A3A3A` | `00000005` |
| `SolidBackgroundFillBase` | Base solid background for page surfaces | :::image type="icon" source="media/visualstudio/swatch-046.svg" alt-text="Color swatch #F3F3F3 image 113" border="true"::: `#FFF3F3F3` | :::image type="icon" source="media/visualstudio/swatch-015.svg" alt-text="Color swatch #202020 image 114" border="true"::: `#FF202020` | `00000005` |
| `SolidBackgroundFillBaseAlt` | Alternative base solid background | :::image type="icon" source="media/visualstudio/swatch-042.svg" alt-text="Color swatch #DADADA image 115" border="true"::: `#FFDADADA` | :::image type="icon" source="media/visualstudio/swatch-009.svg" alt-text="Color swatch #0A0A0A image 116" border="true"::: `#FF0A0A0A` | `00000005` |
| `SolidBackgroundFillSecondary` | Secondary solid background (one level above Base) | :::image type="icon" source="media/visualstudio/swatch-045.svg" alt-text="Color swatch #EEEEEE image 117" border="true"::: `#FFEEEEEE` | :::image type="icon" source="media/visualstudio/swatch-013.svg" alt-text="Color swatch #1C1C1C image 118" border="true"::: `#FF1C1C1C` | `00000005` |
| `SolidBackgroundFillTertiary` | Tertiary solid background | :::image type="icon" source="media/visualstudio/swatch-049.svg" alt-text="Color swatch #F9F9F9 image 119" border="true"::: `#FFF9F9F9` | :::image type="icon" source="media/visualstudio/swatch-017.svg" alt-text="Color swatch #282828 image 120" border="true"::: `#FF282828` | `00000005` |
| `SolidBackgroundFillQuaternary` | Fourth-level solid background | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 121" border="true"::: `#FFFFFFFF` | :::image type="icon" source="media/visualstudio/swatch-018.svg" alt-text="Color swatch #2C2C2C image 122" border="true"::: `#FF2C2C2C` | `00000005` |
| `SolidBackgroundFillQuinary` | Fifth-level solid background | :::image type="icon" source="media/visualstudio/swatch-052.svg" alt-text="Color swatch #FDFDFD image 123" border="true"::: `#FFFDFDFD` | :::image type="icon" source="media/visualstudio/swatch-020.svg" alt-text="Color swatch #333333 image 124" border="true"::: `#FF333333` | `00000005` |
| `SolidBackgroundFillSenary` | Sixth-level solid background | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 125" border="true"::: `#FFFFFFFF` | :::image type="icon" source="media/visualstudio/swatch-021.svg" alt-text="Color swatch #373737 image 126" border="true"::: `#FF373737` | `00000005` |
| `SurfaceBackgroundFillDefault` | Default background for discrete surfaces above base | :::image type="icon" source="media/visualstudio/swatch-049.svg" alt-text="Color swatch #F9F9F9 image 127" border="true"::: `#FFF9F9F9` | :::image type="icon" source="media/visualstudio/swatch-018.svg" alt-text="Color swatch #2C2C2C image 128" border="true"::: `#FF2C2C2C` | `00000005` |
| `SurfaceStrokeDefault` | Default surface border | :::image type="icon" source="media/visualstudio/swatch-031.svg" alt-text="Color swatch #757575 image 129" border="true"::: `#66757575` | :::image type="icon" source="media/visualstudio/swatch-031.svg" alt-text="Color swatch #757575 image 130" border="true"::: `#66757575` | `0000000A` |
| `SurfaceStrokeFlyout` | Flyout surface border | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 131" border="true"::: `#0F000000` | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 132" border="true"::: `#33000000` | `0000000A` |

### Shadow and smoke

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `ShadowFlyout` | Shadow color for flyout surfaces like popups, tooltips, and context menus | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 133" border="true"::: `#24000000` | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 134" border="true"::: `#42000000` | `00000005` |
| `SmokeFillDefault` | Smoke overlay color for dimming background surfaces | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 135" border="true"::: `#4D000000` | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 136" border="true"::: `#4D000000` | `0000000F` |
| `SmokeFillInverse` | Inverse smoke overlay color | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 137" border="true"::: `#C9FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-013.svg" alt-text="Color swatch #1C1C1C image 138" border="true"::: `#B21C1C1C` | `0000000F` |

### Subtle

Tokens for controls with minimal visual weight, like toolbar buttons and menu items.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `SubtleFillDisabled` | Disabled subtle control fill | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 139" border="true"::: `#00000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 140" border="true"::: `#00FFFFFF` | `00000005` |
| `SubtleFillSecondary` | Subtle control fill (hover) | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 141" border="true"::: `#0F000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 142" border="true"::: `#0FFFFFFF` | `0000000F` |
| `SubtleFillTertiary` | Subtle control fill (pressed) | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 143" border="true"::: `#0A000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 144" border="true"::: `#0BFFFFFF` | `0000000F` |
| `SubtleFillTransparent` | Transparent subtle control fill | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 145" border="true"::: `#00FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 146" border="true"::: `#00FFFFFF` | `00000005` |

### System status

Tokens for status indicators — attention, caution, critical, success, and neutral.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `SystemFillAttention` | Attention indicator border and stroke (informational) | :::image type="icon" source="media/visualstudio/swatch-006.svg" alt-text="Color swatch #005FB7 image 147" border="true"::: `#FF005FB7` | :::image type="icon" source="media/visualstudio/swatch-029.svg" alt-text="Color swatch #60CDFF image 148" border="true"::: `#FF60CDFF` | `00000002` |
| `SystemFillAttentionBackground` | Attention indicator background | :::image type="icon" source="media/visualstudio/swatch-047.svg" alt-text="Color swatch #F6F6F6 image 149" border="true"::: `#80F6F6F6` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 150" border="true"::: `#08FFFFFF` | `00000018` |
| `SystemFillCaution` | Warning indicator border and stroke | :::image type="icon" source="media/visualstudio/swatch-036.svg" alt-text="Color swatch #9D5D00 image 151" border="true"::: `#FF9D5D00` | :::image type="icon" source="media/visualstudio/swatch-050.svg" alt-text="Color swatch #FCE100 image 152" border="true"::: `#FFFCE100` | `00000002` |
| `SystemFillCautionBackground` | Warning indicator background | :::image type="icon" source="media/visualstudio/swatch-054.svg" alt-text="Color swatch #FFF4CE image 153" border="true"::: `#FFFFF4CE` | :::image type="icon" source="media/visualstudio/swatch-025.svg" alt-text="Color swatch #433519 image 154" border="true"::: `#FF433519` | `00000018` |
| `SystemFillCritical` | Error indicator border and stroke | :::image type="icon" source="media/visualstudio/swatch-040.svg" alt-text="Color swatch #C42B1C image 155" border="true"::: `#FFC42B1C` | :::image type="icon" source="media/visualstudio/swatch-053.svg" alt-text="Color swatch #FF99A4 image 156" border="true"::: `#FFFF99A4` | `00000002` |
| `SystemFillCriticalBackground` | Error indicator background | :::image type="icon" source="media/visualstudio/swatch-051.svg" alt-text="Color swatch #FDE7E9 image 157" border="true"::: `#FFFDE7E9` | :::image type="icon" source="media/visualstudio/swatch-026.svg" alt-text="Color swatch #442726 image 158" border="true"::: `#FF442726` | `00000018` |
| `SystemFillNeutral` | Neutral system fill | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 159" border="true"::: `#72000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 160" border="true"::: `#8BFFFFFF` | `00000002` |
| `SystemFillNeutralBackground` | Neutral system background | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 161" border="true"::: `#06000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 162" border="true"::: `#08FFFFFF` | `00000018` |
| `SystemFillSolidAttentionBackground` | Solid attention background, used when transparency causes visibility problems | :::image type="icon" source="media/visualstudio/swatch-048.svg" alt-text="Color swatch #F7F7F7 image 163" border="true"::: `#FFF7F7F7` | :::image type="icon" source="media/visualstudio/swatch-019.svg" alt-text="Color swatch #2E2E2E image 164" border="true"::: `#FF2E2E2E` | `00000018` |
| `SystemFillSolidNeutral` | Solid neutral indicator fill | :::image type="icon" source="media/visualstudio/swatch-033.svg" alt-text="Color swatch #8A8A8A image 165" border="true"::: `#FF8A8A8A` | :::image type="icon" source="media/visualstudio/swatch-033.svg" alt-text="Color swatch #8A8A8A image 166" border="true"::: `#FF8A8A8A` | `00000002` |
| `SystemFillSolidNeutralBackground` | Solid neutral background | :::image type="icon" source="media/visualstudio/swatch-046.svg" alt-text="Color swatch #F3F3F3 image 167" border="true"::: `#FFF3F3F3` | :::image type="icon" source="media/visualstudio/swatch-019.svg" alt-text="Color swatch #2E2E2E image 168" border="true"::: `#FF2E2E2E` | `00000018` |
| `SystemFillSuccess` | Success indicator border and stroke | :::image type="icon" source="media/visualstudio/swatch-010.svg" alt-text="Color swatch #0F7B0F image 169" border="true"::: `#FF0F7B0F` | :::image type="icon" source="media/visualstudio/swatch-030.svg" alt-text="Color swatch #6CCB5F image 170" border="true"::: `#FF6CCB5F` | `00000002` |
| `SystemFillSuccessBackground` | Success indicator background | :::image type="icon" source="media/visualstudio/swatch-043.svg" alt-text="Color swatch #DFF6DD image 171" border="true"::: `#FFDFF6DD` | :::image type="icon" source="media/visualstudio/swatch-022.svg" alt-text="Color swatch #393D1B image 172" border="true"::: `#FF393D1B` | `00000018` |

### Text

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `TextFillDisabled` | Disabled text color | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 173" border="true"::: `#5C000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 174" border="true"::: `#5DFFFFFF` | `00000011` |
| `TextFillPrimary` | Primary text color for general content | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 175" border="true"::: `#E4000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 176" border="true"::: `#FFFFFFFF` | `00000008` |
| `TextFillSecondary` | Secondary text color for supplementary content and hints | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 177" border="true"::: `#9E000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 178" border="true"::: `#C8FFFFFF` | `00000008` |
| `TextFillTertiary` | Tertiary text color (low contrast — don't use for primary content at rest) | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 179" border="true"::: `#72000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 180" border="true"::: `#8BFFFFFF` | `00000008` |
| `TextOnAccentFillDisabled` | Disabled text on accent backgrounds | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 181" border="true"::: `#B2FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 182" border="true"::: `#80000000` | `00000003` |
| `TextOnAccentFillPrimary` | Primary text on accent backgrounds | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 183" border="true"::: `#FFFFFFFF` | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 184" border="true"::: `#FF000000` | `0000000E` |
| `TextOnAccentFillSecondary` | Secondary text on accent backgrounds | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 185" border="true"::: `#B2FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 186" border="true"::: `#80000000` | `0000000E` |
| `TextOnAccentFillSelectedText` | Text color for selected text on accent backgrounds | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 187" border="true"::: `#FFFFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 188" border="true"::: `#FFFFFFFF` | `0000000E` |

## Shell internal colors

These tokens control IDE chrome surfaces — the main window frame, tool window headers, tabs, status bar, and other shell-level elements. They're the primary tokens theme authors use to change the overall feel of the IDE.

### Environment

Tokens that control the main window and shell chrome surfaces.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `EnvironmentBackground` | Main window background and floating tool windows | :::image type="icon" source="media/visualstudio/swatch-045.svg" alt-text="Color swatch #EEEEEE image 189" border="true"::: `#FFEEEEEE` | :::image type="icon" source="media/visualstudio/swatch-013.svg" alt-text="Color swatch #1C1C1C image 190" border="true"::: `#FF1C1C1C` | `00000005` |
| `EnvironmentBadge` | Solution Info Badge background (for example, Live Share indicator) | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 191" border="true"::: `#B2FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 192" border="true"::: `#0FFFFFFF` | `0000000F` |
| `EnvironmentBody` | Body/content area background of the main shell window | :::image type="icon" source="media/visualstudio/swatch-045.svg" alt-text="Color swatch #EEEEEE image 193" border="true"::: `#FFEEEEEE` | :::image type="icon" source="media/visualstudio/swatch-013.svg" alt-text="Color swatch #1C1C1C image 194" border="true"::: `#FF1C1C1C` | `00000005` |
| `EnvironmentBodyText` | Text color in the body/content area of the main shell window | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 195" border="true"::: `#E4000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 196" border="true"::: `#FFFFFFFF` | `00000008` |
| `EnvironmentBorder` | Active main window border | :::image type="icon" source="media/visualstudio/swatch-028.svg" alt-text="Color swatch #5649B0 image 197" border="true"::: `#FF5649B0` | :::image type="icon" source="media/visualstudio/swatch-034.svg" alt-text="Color swatch #9184EE image 198" border="true"::: `#FF9184EE` | `0000000A` |
| `EnvironmentBorderInactive` | Inactive main window border and internal dividers | :::image type="icon" source="media/visualstudio/swatch-038.svg" alt-text="Color swatch #ADADAD image 199" border="true"::: `#FFADADAD` | :::image type="icon" source="media/visualstudio/swatch-027.svg" alt-text="Color swatch #454545 image 200" border="true"::: `#FF454545` | `00000003` |
| `EnvironmentHeader` | Background for active header areas | :::image type="icon" source="media/visualstudio/swatch-049.svg" alt-text="Color swatch #F9F9F9 image 201" border="true"::: `#FFF9F9F9` | :::image type="icon" source="media/visualstudio/swatch-017.svg" alt-text="Color swatch #282828 image 202" border="true"::: `#FF282828` | `00000005` |
| `EnvironmentHeaderInactive` | Background for inactive header areas | :::image type="icon" source="media/visualstudio/swatch-049.svg" alt-text="Color swatch #F9F9F9 image 203" border="true"::: `#FFF9F9F9` | :::image type="icon" source="media/visualstudio/swatch-017.svg" alt-text="Color swatch #282828 image 204" border="true"::: `#FF282828` | `00000005` |
| `EnvironmentIndicator` | Border or indicator for auto-hidden tabs | :::image type="icon" source="media/visualstudio/swatch-031.svg" alt-text="Color swatch #757575 image 205" border="true"::: `#66757575` | :::image type="icon" source="media/visualstudio/swatch-031.svg" alt-text="Color swatch #757575 image 206" border="true"::: `#66757575` | `0000000A` |
| `EnvironmentLayeredBackground` | Background for layered elements like InfoBars and tab groups | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 207" border="true"::: `#80FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-023.svg" alt-text="Color swatch #3A3A3A image 208" border="true"::: `#4D3A3A3A` | `00000005` |
| `EnvironmentLayeredBorder` | Border for layered elements like InfoBars and badges | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 209" border="true"::: `#0F000000` | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 210" border="true"::: `#80000000` | `00000010` |
| `EnvironmentLogo` | Visual Studio logo fill in the system menu | :::image type="icon" source="media/visualstudio/swatch-028.svg" alt-text="Color swatch #5649B0 image 211" border="true"::: `#FF5649B0` | :::image type="icon" source="media/visualstudio/swatch-034.svg" alt-text="Color swatch #9184EE image 212" border="true"::: `#FF9184EE` | `0000000D` |
| `EnvironmentTab` | Tab element background | :::image type="icon" source="media/visualstudio/swatch-049.svg" alt-text="Color swatch #F9F9F9 image 213" border="true"::: `#FFF9F9F9` | :::image type="icon" source="media/visualstudio/swatch-017.svg" alt-text="Color swatch #282828 image 214" border="true"::: `#FF282828` | `00000005` |
| `EnvironmentTabInactive` | Inactive tab element background | :::image type="icon" source="media/visualstudio/swatch-049.svg" alt-text="Color swatch #F9F9F9 image 215" border="true"::: `#FFF9F9F9` | :::image type="icon" source="media/visualstudio/swatch-017.svg" alt-text="Color swatch #282828 image 216" border="true"::: `#FF282828` | `00000005` |

### Caption

Tokens for the window close button specifically.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `CaptionControlCloseFillPrimary` | Close button background (hover) | :::image type="icon" source="media/visualstudio/swatch-040.svg" alt-text="Color swatch #C42B1C image 217" border="true"::: `#FFC42B1C` | :::image type="icon" source="media/visualstudio/swatch-040.svg" alt-text="Color swatch #C42B1C image 218" border="true"::: `#FFC42B1C` | `0000000D` |
| `CaptionControlCloseFillSecondary` | Close button background (pressed) | :::image type="icon" source="media/visualstudio/swatch-040.svg" alt-text="Color swatch #C42B1C image 219" border="true"::: `#E6C42B1C` | :::image type="icon" source="media/visualstudio/swatch-040.svg" alt-text="Color swatch #C42B1C image 220" border="true"::: `#E6C42B1C` | `0000000D` |
| `CaptionControlCloseTextFillPrimary` | Close button icon color (hover) | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 221" border="true"::: `#FFFFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 222" border="true"::: `#FFFFFFFF` | `00000009` |
| `CaptionControlCloseTextFillSecondary` | Close button icon color (pressed) | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 223" border="true"::: `#B3FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 224" border="true"::: `#B3FFFFFF` | `00000009` |

### Status bar

Tokens for the status bar across its different modes.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `StatusBarBackgroundFillBuilding` | Status bar background when building | :::image type="icon" source="media/visualstudio/swatch-028.svg" alt-text="Color swatch #5649B0 image 225" border="true"::: `#FF5649B0` | :::image type="icon" source="media/visualstudio/swatch-024.svg" alt-text="Color swatch #3F3682 image 226" border="true"::: `#FF3F3682` | `00000005` |
| `StatusBarBackgroundFillDebugging` | Status bar background when debugging | :::image type="icon" source="media/visualstudio/swatch-039.svg" alt-text="Color swatch #BC4B09 image 227" border="true"::: `#FFBC4B09` | :::image type="icon" source="media/visualstudio/swatch-032.svg" alt-text="Color swatch #7A2101 image 228" border="true"::: `#FF7A2101` | `00000005` |
| `StatusBarBackgroundFillRest` | Status bar background in default state | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 229" border="true"::: `#8B000000` | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 230" border="true"::: `#4D000000` | `00000005` |
| `StatusBarBackgroundFillSolutionLoading` | Status bar background when loading a solution | :::image type="icon" source="media/visualstudio/swatch-005.svg" alt-text="Color swatch #005BA1 image 231" border="true"::: `#FF005BA1` | :::image type="icon" source="media/visualstudio/swatch-003.svg" alt-text="Color swatch #003B6A image 232" border="true"::: `#FF003B6A` | `00000005` |
| `StatusBarControlFillSecondary` | Secondary control fill on the status bar | :::image type="icon" source="media/visualstudio/swatch-001.svg" alt-text="Color swatch #000000 image 233" border="true"::: `#33000000` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 234" border="true"::: `#20FFFFFF` | `0000000E` |
| `StatusBarTextFillBuilding` | Status bar text when building | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 235" border="true"::: `#FFFFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 236" border="true"::: `#FFFFFFFF` | `00000008` |
| `StatusBarTextFillDebugging` | Status bar text when debugging | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 237" border="true"::: `#FFFFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 238" border="true"::: `#FFFFFFFF` | `00000008` |
| `StatusBarTextFillDisabled` | Disabled status bar text | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 239" border="true"::: `#90FFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 240" border="true"::: `#5DFFFFFF` | `00000011` |
| `StatusBarTextFillRest` | Status bar text in default state | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 241" border="true"::: `#FFFFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 242" border="true"::: `#FFFFFFFF` | `00000008` |
| `StatusBarTextFillSolutionLoading` | Status bar text when loading a solution | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 243" border="true"::: `#FFFFFFFF` | :::image type="icon" source="media/visualstudio/swatch-055.svg" alt-text="Color swatch #FFFFFF image 244" border="true"::: `#FFFFFFFF` | `00000008` |

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

## Related content

- [Color theming tools](../internals/color-theming-tools.md)
- [Modernize theme colors](../migration/modernize-theme-colors.md)
- [Matching Visual Studio themes in Visual Studio extensions](../vsix/recipes/use-themes.md)
- [Change fonts, colors, and themes in Visual Studio](../../ide/how-to-change-fonts-and-colors-in-visual-studio.md)



