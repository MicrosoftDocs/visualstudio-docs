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
| `AccentFillAlt` | Alternative accent background, used when a different hue from Default is needed | ![Color swatch #3F3682 image 001](media/visualstudio/swatch-024.svg) `#FF3F3682` | ![Color swatch #D2CCF8 image 002](media/visualstudio/swatch-041.svg) `#FFD2CCF8` | `0000000D` |
| `AccentFillDefault` | Default accent background for interactive elements, calls to action, and selected states | ![Color swatch #5649B0 image 003](media/visualstudio/swatch-028.svg) `#FF5649B0` | ![Color swatch #9184EE image 004](media/visualstudio/swatch-034.svg) `#FF9184EE` | `0000000D` |
| `AccentFillDisabled` | Disabled accent background | ![Color swatch #000000 image 005](media/visualstudio/swatch-001.svg) `#37000000` | ![Color swatch #FFFFFF image 006](media/visualstudio/swatch-055.svg) `#28FFFFFF` | `00000010` |
| `AccentFillSecondary` | Accent background indicating hover state | ![Color swatch #5649B0 image 007](media/visualstudio/swatch-028.svg) `#E55649B0` | ![Color swatch #9184EE image 008](media/visualstudio/swatch-034.svg) `#E59184EE` | `0000000D` |
| `AccentFillSelectedTextBackground` | Background for selected text in active text fields | ![Color swatch #0078D4 image 009](media/visualstudio/swatch-008.svg) `#FF0078D4` | ![Color swatch #005FB7 image 010](media/visualstudio/swatch-006.svg) `#FF005FB7` | `0000000D` |
| `AccentFillSelectedTextBackgroundSubtle` | Subtle selected text background, used when foreground text color can't be inverted | ![Color swatch #0078D4 image 011](media/visualstudio/swatch-008.svg) `#4D0078D4` | ![Color swatch #60CDFF image 012](media/visualstudio/swatch-029.svg) `#6660CDFF` | `0000000D` |
| `AccentFillSenary` | Subtle accent background for states beyond Tertiary | ![Color swatch #5649B0 image 013](media/visualstudio/swatch-028.svg) `#1F5649B0` | ![Color swatch #9184EE image 014](media/visualstudio/swatch-034.svg) `#1F9184EE` | `0000000E` |
| `AccentFillTertiary` | Accent background indicating pressed state | ![Color swatch #5649B0 image 015](media/visualstudio/swatch-028.svg) `#CC5649B0` | ![Color swatch #9184EE image 016](media/visualstudio/swatch-034.svg) `#CC9184EE` | `0000000D` |
| `AccentTextFillDisabled` | Disabled accent text and glyph color | ![Color swatch #000000 image 017](media/visualstudio/swatch-001.svg) `#5C000000` | ![Color swatch #FFFFFF image 018](media/visualstudio/swatch-055.svg) `#5DFFFFFF` | `00000011` |
| `AccentTextFillPrimary` | Primary accent text color for foreground text and glyphs requiring emphasis | ![Color swatch #3F3682 image 019](media/visualstudio/swatch-024.svg) `#FF3F3682` | ![Color swatch #D2CCF8 image 020](media/visualstudio/swatch-041.svg) `#FFD2CCF8` | `00000002` |
| `AccentTextFillSecondary` | Accent text indicating hover state | ![Color swatch #221D46 image 021](media/visualstudio/swatch-016.svg) `#FF221D46` | ![Color swatch #D2CCF8 image 022](media/visualstudio/swatch-041.svg) `#FFD2CCF8` | `00000002` |
| `AccentTextFillTertiary` | Accent text indicating pressed state | ![Color swatch #5649B0 image 023](media/visualstudio/swatch-028.svg) `#FF5649B0` | ![Color swatch #A79CF1 image 024](media/visualstudio/swatch-037.svg) `#FFA79CF1` | `00000002` |

### Card

Tokens for card-like surfaces — content blocks that sit on page or layer backgrounds.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `CardBackgroundFillDefault` | Default card background | ![Color swatch #FFFFFF image 025](media/visualstudio/swatch-055.svg) `#B2FFFFFF` | ![Color swatch #FFFFFF image 026](media/visualstudio/swatch-055.svg) `#0DFFFFFF` | `00000005` |
| `CardBackgroundFillSecondary` | Card background indicating hover state | ![Color swatch #F6F6F6 image 027](media/visualstudio/swatch-047.svg) `#80F6F6F6` | ![Color swatch #FFFFFF image 028](media/visualstudio/swatch-055.svg) `#08FFFFFF` | `00000005` |
| `CardBackgroundFillTertiary` | Card background indicating pressed state | ![Color swatch #FFFFFF image 029](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | ![Color swatch #FFFFFF image 030](media/visualstudio/swatch-055.svg) `#12FFFFFF` | `00000005` |
| `CardStrokeDefault` | Default card border | ![Color swatch #000000 image 031](media/visualstudio/swatch-001.svg) `#0F000000` | ![Color swatch #000000 image 032](media/visualstudio/swatch-001.svg) `#1A000000` | `00000010` |
| `CardStrokeDefaultSolid` | Solid card border, used when semi-transparent strokes cause visibility problems | ![Color swatch #EBEBEB image 033](media/visualstudio/swatch-044.svg) `#FFEBEBEB` | ![Color swatch #1C1C1C image 034](media/visualstudio/swatch-013.svg) `#FF1C1C1C` | `00000010` |
| `CardStrokeDefaultSolidAlt` | Alternative solid card border | ![Color swatch #DADADA image 035](media/visualstudio/swatch-042.svg) `#FFDADADA` | ![Color swatch #0A0A0A image 036](media/visualstudio/swatch-009.svg) `#FF0A0A0A` | `00000010` |

### Control

Tokens for standard interactive controls like buttons, text boxes, and combo boxes.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `ControlAltFillDisabled` | Disabled alternative control background | ![Color swatch #FFFFFF image 037](media/visualstudio/swatch-055.svg) `#00FFFFFF` | ![Color swatch #FFFFFF image 038](media/visualstudio/swatch-055.svg) `#00FFFFFF` | `0000000F` |
| `ControlAltFillQuaternary` | Fourth-level alternative control background | ![Color swatch #000000 image 039](media/visualstudio/swatch-001.svg) `#18000000` | ![Color swatch #FFFFFF image 040](media/visualstudio/swatch-055.svg) `#12FFFFFF` | `0000000E` |
| `ControlAltFillSecondary` | Second-level alternative control background | ![Color swatch #000000 image 041](media/visualstudio/swatch-001.svg) `#06000000` | ![Color swatch #000000 image 042](media/visualstudio/swatch-001.svg) `#1A000000` | `0000000E` |
| `ControlAltFillTertiary` | Third-level alternative control background | ![Color swatch #000000 image 043](media/visualstudio/swatch-001.svg) `#0F000000` | ![Color swatch #FFFFFF image 044](media/visualstudio/swatch-055.svg) `#0BFFFFFF` | `0000000E` |
| `ControlAltFillTransparent` | Transparent alternative control background | ![Color swatch #FFFFFF image 045](media/visualstudio/swatch-055.svg) `#00FFFFFF` | ![Color swatch #FFFFFF image 046](media/visualstudio/swatch-055.svg) `#00FFFFFF` | `0000000E` |
| `ControlFillActiveInput` | Control background during active text input | ![Color swatch #FFFFFF image 047](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | ![Color swatch #1E1E1E image 048](media/visualstudio/swatch-014.svg) `#B21E1E1E` | `0000000F` |
| `ControlFillDefault` | Default control background (rest state) | ![Color swatch #FFFFFF image 049](media/visualstudio/swatch-055.svg) `#B2FFFFFF` | ![Color swatch #FFFFFF image 050](media/visualstudio/swatch-055.svg) `#0FFFFFFF` | `0000000F` |
| `ControlFillDisabled` | Disabled control background | ![Color swatch #F9F9F9 image 051](media/visualstudio/swatch-049.svg) `#4DF9F9F9` | ![Color swatch #FFFFFF image 052](media/visualstudio/swatch-055.svg) `#0BFFFFFF` | `0000000F` |
| `ControlFillQuaternary` | Fourth-level control background | ![Color swatch #F3F3F3 image 053](media/visualstudio/swatch-046.svg) `#C2F3F3F3` | ![Color swatch #FFFFFF image 054](media/visualstudio/swatch-055.svg) `#0FFFFFFF` | `0000000E` |
| `ControlFillSecondary` | Second-level control background (hover) | ![Color swatch #F9F9F9 image 055](media/visualstudio/swatch-049.svg) `#80F9F9F9` | ![Color swatch #FFFFFF image 056](media/visualstudio/swatch-055.svg) `#15FFFFFF` | `0000000E` |
| `ControlFillTertiary` | Third-level control background (pressed) | ![Color swatch #F9F9F9 image 057](media/visualstudio/swatch-049.svg) `#4DF9F9F9` | ![Color swatch #FFFFFF image 058](media/visualstudio/swatch-055.svg) `#08FFFFFF` | `0000000E` |
| `ControlFillTransparent` | Transparent control background | ![Color swatch #FFFFFF image 059](media/visualstudio/swatch-055.svg) `#00FFFFFF` | ![Color swatch #FFFFFF image 060](media/visualstudio/swatch-055.svg) `#00FFFFFF` | `0000000F` |
| `ControlOnImageFillDefault` | Default control background when placed on an image | ![Color swatch #FFFFFF image 061](media/visualstudio/swatch-055.svg) `#C9FFFFFF` | ![Color swatch #1C1C1C image 062](media/visualstudio/swatch-013.svg) `#B21C1C1C` | `0000000F` |
| `ControlOnImageFillDisabled` | Disabled control background when placed on an image | ![Color swatch #FFFFFF image 063](media/visualstudio/swatch-055.svg) `#00FFFFFF` | ![Color swatch #1E1E1E image 064](media/visualstudio/swatch-014.svg) `#001E1E1E` | `0000000F` |
| `ControlOnImageFillSecondary` | Hover control background when placed on an image | ![Color swatch #F3F3F3 image 065](media/visualstudio/swatch-046.svg) `#FFF3F3F3` | ![Color swatch #1A1A1A image 066](media/visualstudio/swatch-012.svg) `#FF1A1A1A` | `0000000E` |
| `ControlOnImageFillTertiary` | Pressed control background when placed on an image | ![Color swatch #EBEBEB image 067](media/visualstudio/swatch-044.svg) `#FFEBEBEB` | ![Color swatch #131313 image 068](media/visualstudio/swatch-011.svg) `#FF131313` | `0000000E` |
| `ControlSolidFillDefault` | Solid control background, used when transparency causes visibility problems | ![Color swatch #FFFFFF image 069](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | ![Color swatch #454545 image 070](media/visualstudio/swatch-027.svg) `#FF454545` | `0000000F` |
| `ControlStrokeDefault` | Default control border (rest state) | ![Color swatch #000000 image 071](media/visualstudio/swatch-001.svg) `#0F000000` | ![Color swatch #FFFFFF image 072](media/visualstudio/swatch-055.svg) `#12FFFFFF` | `00000010` |
| `ControlStrokeForStrongFillWhenOnImage` | Control border for strong fills placed on images | ![Color swatch #FFFFFF image 073](media/visualstudio/swatch-055.svg) `#59FFFFFF` | ![Color swatch #000000 image 074](media/visualstudio/swatch-001.svg) `#6B000000` | `0000000A` |
| `ControlStrokeOnAccentDefault` | Default border for controls on accent backgrounds | ![Color swatch #FFFFFF image 075](media/visualstudio/swatch-055.svg) `#14FFFFFF` | ![Color swatch #FFFFFF image 076](media/visualstudio/swatch-055.svg) `#14FFFFFF` | `0000000B` |
| `ControlStrokeOnAccentDisabled` | Disabled border for controls on accent backgrounds | ![Color swatch #000000 image 077](media/visualstudio/swatch-001.svg) `#0F000000` | ![Color swatch #000000 image 078](media/visualstudio/swatch-001.svg) `#33000000` | `0000000B` |
| `ControlStrokeOnAccentSecondary` | Hover border for controls on accent backgrounds | ![Color swatch #000000 image 079](media/visualstudio/swatch-001.svg) `#66000000` | ![Color swatch #000000 image 080](media/visualstudio/swatch-001.svg) `#24000000` | `0000000B` |
| `ControlStrokeOnAccentTertiary` | Pressed border for controls on accent backgrounds | ![Color swatch #000000 image 081](media/visualstudio/swatch-001.svg) `#37000000` | ![Color swatch #000000 image 082](media/visualstudio/swatch-001.svg) `#37000000` | `0000000B` |
| `ControlStrokeSecondary` | Second-level control border | ![Color swatch #000000 image 083](media/visualstudio/swatch-001.svg) `#0F000000` | ![Color swatch #FFFFFF image 084](media/visualstudio/swatch-055.svg) `#12FFFFFF` | `00000008` |
| `ControlStrokeTransparent` | Transparent control border | ![Color swatch #FFFFFF image 085](media/visualstudio/swatch-055.svg) `#00FFFFFF` | ![Color swatch #FFFFFF image 086](media/visualstudio/swatch-055.svg) `#00FFFFFF` | `0000000F` |
| `ControlStrongFillDefault` | Strong control fill for high-contrast elements like scroll bars | ![Color swatch #000000 image 087](media/visualstudio/swatch-001.svg) `#72000000` | ![Color swatch #FFFFFF image 088](media/visualstudio/swatch-055.svg) `#8BFFFFFF` | `0000000A` |
| `ControlStrongFillDisabled` | Disabled strong control fill | ![Color swatch #000000 image 089](media/visualstudio/swatch-001.svg) `#51000000` | ![Color swatch #FFFFFF image 090](media/visualstudio/swatch-055.svg) `#3FFFFFFF` | `0000000F` |
| `ControlStrongStrokeDefault` | Strong control border for checkboxes and radio buttons | ![Color swatch #000000 image 091](media/visualstudio/swatch-001.svg) `#9C000000` | ![Color swatch #FFFFFF image 092](media/visualstudio/swatch-055.svg) `#9AFFFFFF` | `00000008` |
| `ControlStrongStrokeDisabled` | Disabled strong control border | ![Color swatch #000000 image 093](media/visualstudio/swatch-001.svg) `#37000000` | ![Color swatch #FFFFFF image 094](media/visualstudio/swatch-055.svg) `#28FFFFFF` | `0000000B` |

### Divider

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `DividerStrokeDefault` | Default divider and separator stroke | ![Color swatch #000000 image 095](media/visualstudio/swatch-001.svg) `#14000000` | ![Color swatch #FFFFFF image 096](media/visualstudio/swatch-055.svg) `#15FFFFFF` | `00000011` |

### Focus

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `FocusStrokeInner` | Inner focus indicator stroke | ![Color swatch #FFFFFF image 097](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | ![Color swatch #000000 image 098](media/visualstudio/swatch-001.svg) `#B2000000` | `00000005` |
| `FocusStrokeOuter` | Outer focus indicator stroke | ![Color swatch #000000 image 099](media/visualstudio/swatch-001.svg) `#E4000000` | ![Color swatch #FFFFFF image 100](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | `00000008` |

### Hyperlink

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `HyperlinkFillDisabled` | Disabled hyperlink text color | ![Color swatch #000000 image 101](media/visualstudio/swatch-001.svg) `#5C000000` | ![Color swatch #FFFFFF image 102](media/visualstudio/swatch-055.svg) `#5DFFFFFF` | `00000013` |
| `HyperlinkFillPrimary` | Primary hyperlink text color (rest) | ![Color swatch #003E92 image 103](media/visualstudio/swatch-004.svg) `#FF003E92` | ![Color swatch #99EBFF image 104](media/visualstudio/swatch-035.svg) `#FF99EBFF` | `0000001A` |
| `HyperlinkFillSecondary` | Hyperlink text color (hover) | ![Color swatch #001A68 image 105](media/visualstudio/swatch-002.svg) `#FF001A68` | ![Color swatch #60CDFF image 106](media/visualstudio/swatch-029.svg) `#FF60CDFF` | `0000001A` |
| `HyperlinkFillTertiary` | Hyperlink text color (pressed) | ![Color swatch #005FB8 image 107](media/visualstudio/swatch-007.svg) `#FF005FB8` | ![Color swatch #60CDFF image 108](media/visualstudio/swatch-029.svg) `#E560CDFF` | `0000001A` |

### Layer and surface

Tokens for backgrounds, layered surfaces, and page-level containers.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `LayerFillAlt` | Alternative layer fill for surfaces | ![Color swatch #FFFFFF image 109](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | ![Color swatch #FFFFFF image 110](media/visualstudio/swatch-055.svg) `#0EFFFFFF` | `00000005` |
| `LayerFillDefault` | Default layer fill for surfaces and scroll bars | ![Color swatch #FFFFFF image 111](media/visualstudio/swatch-055.svg) `#80FFFFFF` | ![Color swatch #3A3A3A image 112](media/visualstudio/swatch-023.svg) `#4D3A3A3A` | `00000005` |
| `SolidBackgroundFillBase` | Base solid background for page surfaces | ![Color swatch #F3F3F3 image 113](media/visualstudio/swatch-046.svg) `#FFF3F3F3` | ![Color swatch #202020 image 114](media/visualstudio/swatch-015.svg) `#FF202020` | `00000005` |
| `SolidBackgroundFillBaseAlt` | Alternative base solid background | ![Color swatch #DADADA image 115](media/visualstudio/swatch-042.svg) `#FFDADADA` | ![Color swatch #0A0A0A image 116](media/visualstudio/swatch-009.svg) `#FF0A0A0A` | `00000005` |
| `SolidBackgroundFillSecondary` | Secondary solid background (one level above Base) | ![Color swatch #EEEEEE image 117](media/visualstudio/swatch-045.svg) `#FFEEEEEE` | ![Color swatch #1C1C1C image 118](media/visualstudio/swatch-013.svg) `#FF1C1C1C` | `00000005` |
| `SolidBackgroundFillTertiary` | Tertiary solid background | ![Color swatch #F9F9F9 image 119](media/visualstudio/swatch-049.svg) `#FFF9F9F9` | ![Color swatch #282828 image 120](media/visualstudio/swatch-017.svg) `#FF282828` | `00000005` |
| `SolidBackgroundFillQuaternary` | Fourth-level solid background | ![Color swatch #FFFFFF image 121](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | ![Color swatch #2C2C2C image 122](media/visualstudio/swatch-018.svg) `#FF2C2C2C` | `00000005` |
| `SolidBackgroundFillQuinary` | Fifth-level solid background | ![Color swatch #FDFDFD image 123](media/visualstudio/swatch-052.svg) `#FFFDFDFD` | ![Color swatch #333333 image 124](media/visualstudio/swatch-020.svg) `#FF333333` | `00000005` |
| `SolidBackgroundFillSenary` | Sixth-level solid background | ![Color swatch #FFFFFF image 125](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | ![Color swatch #373737 image 126](media/visualstudio/swatch-021.svg) `#FF373737` | `00000005` |
| `SurfaceBackgroundFillDefault` | Default background for discrete surfaces above base | ![Color swatch #F9F9F9 image 127](media/visualstudio/swatch-049.svg) `#FFF9F9F9` | ![Color swatch #2C2C2C image 128](media/visualstudio/swatch-018.svg) `#FF2C2C2C` | `00000005` |
| `SurfaceStrokeDefault` | Default surface border | ![Color swatch #757575 image 129](media/visualstudio/swatch-031.svg) `#66757575` | ![Color swatch #757575 image 130](media/visualstudio/swatch-031.svg) `#66757575` | `0000000A` |
| `SurfaceStrokeFlyout` | Flyout surface border | ![Color swatch #000000 image 131](media/visualstudio/swatch-001.svg) `#0F000000` | ![Color swatch #000000 image 132](media/visualstudio/swatch-001.svg) `#33000000` | `0000000A` |

### Shadow and smoke

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `ShadowFlyout` | Shadow color for flyout surfaces like popups, tooltips, and context menus | ![Color swatch #000000 image 133](media/visualstudio/swatch-001.svg) `#24000000` | ![Color swatch #000000 image 134](media/visualstudio/swatch-001.svg) `#42000000` | `00000005` |
| `SmokeFillDefault` | Smoke overlay color for dimming background surfaces | ![Color swatch #000000 image 135](media/visualstudio/swatch-001.svg) `#4D000000` | ![Color swatch #000000 image 136](media/visualstudio/swatch-001.svg) `#4D000000` | `0000000F` |
| `SmokeFillInverse` | Inverse smoke overlay color | ![Color swatch #FFFFFF image 137](media/visualstudio/swatch-055.svg) `#C9FFFFFF` | ![Color swatch #1C1C1C image 138](media/visualstudio/swatch-013.svg) `#B21C1C1C` | `0000000F` |

### Subtle

Tokens for controls with minimal visual weight, like toolbar buttons and menu items.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `SubtleFillDisabled` | Disabled subtle control fill | ![Color swatch #000000 image 139](media/visualstudio/swatch-001.svg) `#00000000` | ![Color swatch #FFFFFF image 140](media/visualstudio/swatch-055.svg) `#00FFFFFF` | `00000005` |
| `SubtleFillSecondary` | Subtle control fill (hover) | ![Color swatch #000000 image 141](media/visualstudio/swatch-001.svg) `#0F000000` | ![Color swatch #FFFFFF image 142](media/visualstudio/swatch-055.svg) `#0FFFFFFF` | `0000000F` |
| `SubtleFillTertiary` | Subtle control fill (pressed) | ![Color swatch #000000 image 143](media/visualstudio/swatch-001.svg) `#0A000000` | ![Color swatch #FFFFFF image 144](media/visualstudio/swatch-055.svg) `#0BFFFFFF` | `0000000F` |
| `SubtleFillTransparent` | Transparent subtle control fill | ![Color swatch #FFFFFF image 145](media/visualstudio/swatch-055.svg) `#00FFFFFF` | ![Color swatch #FFFFFF image 146](media/visualstudio/swatch-055.svg) `#00FFFFFF` | `00000005` |

### System status

Tokens for status indicators — attention, caution, critical, success, and neutral.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `SystemFillAttention` | Attention indicator border and stroke (informational) | ![Color swatch #005FB7 image 147](media/visualstudio/swatch-006.svg) `#FF005FB7` | ![Color swatch #60CDFF image 148](media/visualstudio/swatch-029.svg) `#FF60CDFF` | `00000002` |
| `SystemFillAttentionBackground` | Attention indicator background | ![Color swatch #F6F6F6 image 149](media/visualstudio/swatch-047.svg) `#80F6F6F6` | ![Color swatch #FFFFFF image 150](media/visualstudio/swatch-055.svg) `#08FFFFFF` | `00000018` |
| `SystemFillCaution` | Warning indicator border and stroke | ![Color swatch #9D5D00 image 151](media/visualstudio/swatch-036.svg) `#FF9D5D00` | ![Color swatch #FCE100 image 152](media/visualstudio/swatch-050.svg) `#FFFCE100` | `00000002` |
| `SystemFillCautionBackground` | Warning indicator background | ![Color swatch #FFF4CE image 153](media/visualstudio/swatch-054.svg) `#FFFFF4CE` | ![Color swatch #433519 image 154](media/visualstudio/swatch-025.svg) `#FF433519` | `00000018` |
| `SystemFillCritical` | Error indicator border and stroke | ![Color swatch #C42B1C image 155](media/visualstudio/swatch-040.svg) `#FFC42B1C` | ![Color swatch #FF99A4 image 156](media/visualstudio/swatch-053.svg) `#FFFF99A4` | `00000002` |
| `SystemFillCriticalBackground` | Error indicator background | ![Color swatch #FDE7E9 image 157](media/visualstudio/swatch-051.svg) `#FFFDE7E9` | ![Color swatch #442726 image 158](media/visualstudio/swatch-026.svg) `#FF442726` | `00000018` |
| `SystemFillNeutral` | Neutral system fill | ![Color swatch #000000 image 159](media/visualstudio/swatch-001.svg) `#72000000` | ![Color swatch #FFFFFF image 160](media/visualstudio/swatch-055.svg) `#8BFFFFFF` | `00000002` |
| `SystemFillNeutralBackground` | Neutral system background | ![Color swatch #000000 image 161](media/visualstudio/swatch-001.svg) `#06000000` | ![Color swatch #FFFFFF image 162](media/visualstudio/swatch-055.svg) `#08FFFFFF` | `00000018` |
| `SystemFillSolidAttentionBackground` | Solid attention background, used when transparency causes visibility problems | ![Color swatch #F7F7F7 image 163](media/visualstudio/swatch-048.svg) `#FFF7F7F7` | ![Color swatch #2E2E2E image 164](media/visualstudio/swatch-019.svg) `#FF2E2E2E` | `00000018` |
| `SystemFillSolidNeutral` | Solid neutral indicator fill | ![Color swatch #8A8A8A image 165](media/visualstudio/swatch-033.svg) `#FF8A8A8A` | ![Color swatch #8A8A8A image 166](media/visualstudio/swatch-033.svg) `#FF8A8A8A` | `00000002` |
| `SystemFillSolidNeutralBackground` | Solid neutral background | ![Color swatch #F3F3F3 image 167](media/visualstudio/swatch-046.svg) `#FFF3F3F3` | ![Color swatch #2E2E2E image 168](media/visualstudio/swatch-019.svg) `#FF2E2E2E` | `00000018` |
| `SystemFillSuccess` | Success indicator border and stroke | ![Color swatch #0F7B0F image 169](media/visualstudio/swatch-010.svg) `#FF0F7B0F` | ![Color swatch #6CCB5F image 170](media/visualstudio/swatch-030.svg) `#FF6CCB5F` | `00000002` |
| `SystemFillSuccessBackground` | Success indicator background | ![Color swatch #DFF6DD image 171](media/visualstudio/swatch-043.svg) `#FFDFF6DD` | ![Color swatch #393D1B image 172](media/visualstudio/swatch-022.svg) `#FF393D1B` | `00000018` |

### Text

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `TextFillDisabled` | Disabled text color | ![Color swatch #000000 image 173](media/visualstudio/swatch-001.svg) `#5C000000` | ![Color swatch #FFFFFF image 174](media/visualstudio/swatch-055.svg) `#5DFFFFFF` | `00000011` |
| `TextFillPrimary` | Primary text color for general content | ![Color swatch #000000 image 175](media/visualstudio/swatch-001.svg) `#E4000000` | ![Color swatch #FFFFFF image 176](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | `00000008` |
| `TextFillSecondary` | Secondary text color for supplementary content and hints | ![Color swatch #000000 image 177](media/visualstudio/swatch-001.svg) `#9E000000` | ![Color swatch #FFFFFF image 178](media/visualstudio/swatch-055.svg) `#C8FFFFFF` | `00000008` |
| `TextFillTertiary` | Tertiary text color (low contrast — don't use for primary content at rest) | ![Color swatch #000000 image 179](media/visualstudio/swatch-001.svg) `#72000000` | ![Color swatch #FFFFFF image 180](media/visualstudio/swatch-055.svg) `#8BFFFFFF` | `00000008` |
| `TextOnAccentFillDisabled` | Disabled text on accent backgrounds | ![Color swatch #FFFFFF image 181](media/visualstudio/swatch-055.svg) `#B2FFFFFF` | ![Color swatch #000000 image 182](media/visualstudio/swatch-001.svg) `#80000000` | `00000003` |
| `TextOnAccentFillPrimary` | Primary text on accent backgrounds | ![Color swatch #FFFFFF image 183](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | ![Color swatch #000000 image 184](media/visualstudio/swatch-001.svg) `#FF000000` | `0000000E` |
| `TextOnAccentFillSecondary` | Secondary text on accent backgrounds | ![Color swatch #FFFFFF image 185](media/visualstudio/swatch-055.svg) `#B2FFFFFF` | ![Color swatch #000000 image 186](media/visualstudio/swatch-001.svg) `#80000000` | `0000000E` |
| `TextOnAccentFillSelectedText` | Text color for selected text on accent backgrounds | ![Color swatch #FFFFFF image 187](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | ![Color swatch #FFFFFF image 188](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | `0000000E` |

## Shell internal colors

These tokens control IDE chrome surfaces — the main window frame, tool window headers, tabs, status bar, and other shell-level elements. They're the primary tokens theme authors use to change the overall feel of the IDE.

### Environment

Tokens that control the main window and shell chrome surfaces.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `EnvironmentBackground` | Main window background and floating tool windows | ![Color swatch #EEEEEE image 189](media/visualstudio/swatch-045.svg) `#FFEEEEEE` | ![Color swatch #1C1C1C image 190](media/visualstudio/swatch-013.svg) `#FF1C1C1C` | `00000005` |
| `EnvironmentBadge` | Solution Info Badge background (for example, Live Share indicator) | ![Color swatch #FFFFFF image 191](media/visualstudio/swatch-055.svg) `#B2FFFFFF` | ![Color swatch #FFFFFF image 192](media/visualstudio/swatch-055.svg) `#0FFFFFFF` | `0000000F` |
| `EnvironmentBody` | Body/content area background of the main shell window | ![Color swatch #EEEEEE image 193](media/visualstudio/swatch-045.svg) `#FFEEEEEE` | ![Color swatch #1C1C1C image 194](media/visualstudio/swatch-013.svg) `#FF1C1C1C` | `00000005` |
| `EnvironmentBodyText` | Text color in the body/content area of the main shell window | ![Color swatch #000000 image 195](media/visualstudio/swatch-001.svg) `#E4000000` | ![Color swatch #FFFFFF image 196](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | `00000008` |
| `EnvironmentBorder` | Active main window border | ![Color swatch #5649B0 image 197](media/visualstudio/swatch-028.svg) `#FF5649B0` | ![Color swatch #9184EE image 198](media/visualstudio/swatch-034.svg) `#FF9184EE` | `0000000A` |
| `EnvironmentBorderInactive` | Inactive main window border and internal dividers | ![Color swatch #ADADAD image 199](media/visualstudio/swatch-038.svg) `#FFADADAD` | ![Color swatch #454545 image 200](media/visualstudio/swatch-027.svg) `#FF454545` | `00000003` |
| `EnvironmentHeader` | Background for active header areas | ![Color swatch #F9F9F9 image 201](media/visualstudio/swatch-049.svg) `#FFF9F9F9` | ![Color swatch #282828 image 202](media/visualstudio/swatch-017.svg) `#FF282828` | `00000005` |
| `EnvironmentHeaderInactive` | Background for inactive header areas | ![Color swatch #F9F9F9 image 203](media/visualstudio/swatch-049.svg) `#FFF9F9F9` | ![Color swatch #282828 image 204](media/visualstudio/swatch-017.svg) `#FF282828` | `00000005` |
| `EnvironmentIndicator` | Border or indicator for auto-hidden tabs | ![Color swatch #757575 image 205](media/visualstudio/swatch-031.svg) `#66757575` | ![Color swatch #757575 image 206](media/visualstudio/swatch-031.svg) `#66757575` | `0000000A` |
| `EnvironmentLayeredBackground` | Background for layered elements like InfoBars and tab groups | ![Color swatch #FFFFFF image 207](media/visualstudio/swatch-055.svg) `#80FFFFFF` | ![Color swatch #3A3A3A image 208](media/visualstudio/swatch-023.svg) `#4D3A3A3A` | `00000005` |
| `EnvironmentLayeredBorder` | Border for layered elements like InfoBars and badges | ![Color swatch #000000 image 209](media/visualstudio/swatch-001.svg) `#0F000000` | ![Color swatch #000000 image 210](media/visualstudio/swatch-001.svg) `#80000000` | `00000010` |
| `EnvironmentLogo` | Visual Studio logo fill in the system menu | ![Color swatch #5649B0 image 211](media/visualstudio/swatch-028.svg) `#FF5649B0` | ![Color swatch #9184EE image 212](media/visualstudio/swatch-034.svg) `#FF9184EE` | `0000000D` |
| `EnvironmentTab` | Tab element background | ![Color swatch #F9F9F9 image 213](media/visualstudio/swatch-049.svg) `#FFF9F9F9` | ![Color swatch #282828 image 214](media/visualstudio/swatch-017.svg) `#FF282828` | `00000005` |
| `EnvironmentTabInactive` | Inactive tab element background | ![Color swatch #F9F9F9 image 215](media/visualstudio/swatch-049.svg) `#FFF9F9F9` | ![Color swatch #282828 image 216](media/visualstudio/swatch-017.svg) `#FF282828` | `00000005` |

### Caption

Tokens for the window close button specifically.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `CaptionControlCloseFillPrimary` | Close button background (hover) | ![Color swatch #C42B1C image 217](media/visualstudio/swatch-040.svg) `#FFC42B1C` | ![Color swatch #C42B1C image 218](media/visualstudio/swatch-040.svg) `#FFC42B1C` | `0000000D` |
| `CaptionControlCloseFillSecondary` | Close button background (pressed) | ![Color swatch #C42B1C image 219](media/visualstudio/swatch-040.svg) `#E6C42B1C` | ![Color swatch #C42B1C image 220](media/visualstudio/swatch-040.svg) `#E6C42B1C` | `0000000D` |
| `CaptionControlCloseTextFillPrimary` | Close button icon color (hover) | ![Color swatch #FFFFFF image 221](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | ![Color swatch #FFFFFF image 222](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | `00000009` |
| `CaptionControlCloseTextFillSecondary` | Close button icon color (pressed) | ![Color swatch #FFFFFF image 223](media/visualstudio/swatch-055.svg) `#B3FFFFFF` | ![Color swatch #FFFFFF image 224](media/visualstudio/swatch-055.svg) `#B3FFFFFF` | `00000009` |

### Status bar

Tokens for the status bar across its different modes.

| Token | Description | Light | Dark | High Contrast |
|:------|:------------|:------|:-----|:--------------|
| `StatusBarBackgroundFillBuilding` | Status bar background when building | ![Color swatch #5649B0 image 225](media/visualstudio/swatch-028.svg) `#FF5649B0` | ![Color swatch #3F3682 image 226](media/visualstudio/swatch-024.svg) `#FF3F3682` | `00000005` |
| `StatusBarBackgroundFillDebugging` | Status bar background when debugging | ![Color swatch #BC4B09 image 227](media/visualstudio/swatch-039.svg) `#FFBC4B09` | ![Color swatch #7A2101 image 228](media/visualstudio/swatch-032.svg) `#FF7A2101` | `00000005` |
| `StatusBarBackgroundFillRest` | Status bar background in default state | ![Color swatch #000000 image 229](media/visualstudio/swatch-001.svg) `#8B000000` | ![Color swatch #000000 image 230](media/visualstudio/swatch-001.svg) `#4D000000` | `00000005` |
| `StatusBarBackgroundFillSolutionLoading` | Status bar background when loading a solution | ![Color swatch #005BA1 image 231](media/visualstudio/swatch-005.svg) `#FF005BA1` | ![Color swatch #003B6A image 232](media/visualstudio/swatch-003.svg) `#FF003B6A` | `00000005` |
| `StatusBarControlFillSecondary` | Secondary control fill on the status bar | ![Color swatch #000000 image 233](media/visualstudio/swatch-001.svg) `#33000000` | ![Color swatch #FFFFFF image 234](media/visualstudio/swatch-055.svg) `#20FFFFFF` | `0000000E` |
| `StatusBarTextFillBuilding` | Status bar text when building | ![Color swatch #FFFFFF image 235](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | ![Color swatch #FFFFFF image 236](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | `00000008` |
| `StatusBarTextFillDebugging` | Status bar text when debugging | ![Color swatch #FFFFFF image 237](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | ![Color swatch #FFFFFF image 238](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | `00000008` |
| `StatusBarTextFillDisabled` | Disabled status bar text | ![Color swatch #FFFFFF image 239](media/visualstudio/swatch-055.svg) `#90FFFFFF` | ![Color swatch #FFFFFF image 240](media/visualstudio/swatch-055.svg) `#5DFFFFFF` | `00000011` |
| `StatusBarTextFillRest` | Status bar text in default state | ![Color swatch #FFFFFF image 241](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | ![Color swatch #FFFFFF image 242](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | `00000008` |
| `StatusBarTextFillSolutionLoading` | Status bar text when loading a solution | ![Color swatch #FFFFFF image 243](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | ![Color swatch #FFFFFF image 244](media/visualstudio/swatch-055.svg) `#FFFFFFFF` | `00000008` |

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

- [Color theming tools](../internals/color-theming-tools.md)
- [Modernize theme colors](../migration/modernize-theme-colors.md)
- [Matching Visual Studio themes in Visual Studio extensions](../vsix/recipes/use-themes.md)
- [Change fonts, colors, and themes in Visual Studio](../../ide/how-to-change-fonts-and-colors-in-visual-studio.md)


