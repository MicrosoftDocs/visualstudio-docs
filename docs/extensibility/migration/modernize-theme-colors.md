---
title: "Modernize Visual Studio theme colors"
description: "Learn how to migrate Visual Studio themes from the legacy token-based system to the new streamlined color system introduced in Visual Studio 2026."
ms.date: 10/23/2025
ms.topic: how-to
helpviewer_keywords:
- themes, modernizing
- color tokens, migration
- Visual Studio themes, upgrading
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: extensibility-integration
---
# Modernize Visual Studio theme colors

Visual Studio themes previously relied on granular, feature-specific color tokens. Over time, this approach produced thousands of bespoke values and custom colors, making consistency and accessibility harder to guarantee. To address this, we rebuilt the system around clear design principles: fewer semantic tokens for easier maintenance, predictable color ramps for sustainable accessibility, and a more cohesive experience across Visual Studio, the Windows platform, and other Microsoft tools.

This article explains what changed and how to migrate previous themes to be compatible with Visual Studio 2026.

## What changed

Before Visual Studio 2022, an out‑of‑box Visual Studio theme included about 34 categories and ~1,806 color tokens. Extensions often added more. This density created some challenges:

- Many tokens were nearly identical, differing only slightly in hue or brightness, leading to visual clutter and confusion.
- Individual features (such as CodeAnalysis, Diagnostics, ManifestDesigner, etc.) created their own unique tokens, resulting in fragmented and inconsistent color usage.
- Verifying color contrast for accessibility was challenging due to the large number of custom entries.
- The overall user experience became inconsistent, with surfaces appearing mismatched or out of sync.

Here is an example of categories and color tokens from a Visual Studio 2022 theme:

```xml
<Theme ...>
...
<Category Name="CodeAnalysis" ...>
   <Color Name="RenameError">...</Color>
   <Color Name="RenameResolvableConflict">...</Color>
</Category>
<Category Name="Diagnostics"...>
...
   <Color Name="AdvancedListItemSelected">
      <Background ... />
      <Foreground ... />
   </Color>
   <Color Name="ButtonBackgroundDisabled">...</Color>
   <Color Name="ButtonBorderDisabled">
      <Background ... />
   </Color>
   <Color Name="ButtonTextDisabled">
      <Background ... />
   </Color>
...
</Category>
...
<!-- many more feature-scoped categories and hundreds of tokens -->
</Theme>
```

Visual Studio 2026 consolidates tokens into a handful of intent-first categories with predictable naming tiers. An out-of-box shell theme now contains only four top-level categories and 229 color tokens—an ~87% reduction.

Here is an example of semantic, intent-first tokens from a Visual Studio 2026 theme:

```xml
<Theme ...>
<Category Name="Shell">
...
   <Color Name="ControlFillSecondary"> ... </Color>
   <Color Name="TextFillPrimary"> ... </Color>
   <Color Name="SolidBackgroundFillBase"> ... </Color>
...
</Category>
</Theme>
```

### Why fewer tokens unlock better UX

- **Intent-first naming:** Token names clearly reflect
  their *role* (e.g., ControlFill, TextFill, AccentFill, Stroke,
  SystemFill) and tier (Primary, Secondary, Tertiary), making usage
  intuitive.

- **Simplified palette:** Updating a small set of shared tokens
  instantly improves consistency across both the shell and extensions.

- **Greater consistency:** Fewer customization points mean fewer
  accidental mismatches and eliminate slightly different variants.

- **Improved accessibility:** Centralized color ramps and semantic states (Success, Caution, Critical, Attention) make contrast validation easier and more reliable.

- **Better performance and maintainability:** Semantic layers replace   granular color setters, reducing maintenance overhead and improving UI quality.

:::moniker range="visualstudio"

## Migrate themes to Visual Studio 2026

You can make a previous theme compatible with Visual Studio 2026 by merging its existing tokens with a small set of new semantic tokens. You do not need to recreate every previous token. Visual Studio 2026 reads the new tokens first and then falls back to previous tokens. Here is how:

1. Add `FallbackId="{Light or Dark theme GUID}"` object at the `<Theme />` object.

  |**Theme to base on**|**FallbackId**|
  |-|-|
  |Light|{de3dbbcd-f642-433c-8353-8f1df4370aba}|
  |Dark|{1ded0138-47ce-435e-84ef-9ec1f439b749}|

2. Append the below set of tokens as the last two categories after the previous theme tokens. Make sure the category name and GUID are copied exactly as below.

Minimal migration token overrides for a Light based theme:

```xml
  <Category Name="Shell" GUID="{73708ded-2d56-4aad-b8eb-73b20d3f4bff}">
    <Color Name="AccentFillDefault">
      <Background Type="CT_RAW" Source="FF5649B0" />
    </Color>
    <Color Name="AccentFillSecondary">
      <Background Type="CT_RAW" Source="E55649B0" />
    </Color>
    <Color Name="AccentFillTertiary">
      <Background Type="CT_RAW" Source="CC5649B0" />
    </Color>
    <Color Name="SolidBackgroundFillTertiary">
      <Background Type="CT_RAW" Source="FFF9F9F9" />
    </Color>
    <Color Name="SolidBackgroundFillQuaternary">
      <Background Type="CT_RAW" Source="FFFFFFFF" />
    </Color>
    <Color Name="SurfaceBackgroundFillDefault">
      <Background Type="CT_RAW" Source="FFF9F9F9" />
    </Color>
    <Color Name="TextFillSecondary">
      <Background Type="CT_RAW" Source="9E000000" />
    </Color>
  </Category>
  <Category Name="ShellInternal" GUID="{5af241b7-5627-4d12-bfb1-2b67d11127d7}">
    <Color Name="EnvironmentBackground">
      <Background Type="CT_RAW" Source="FFEEEEEE" />
    </Color>
    <Color Name="EnvironmentBorder">
      <Background Type="CT_RAW" Source="FF5649B0" />
    </Color>
    <Color Name="EnvironmentIndicator">
      <Background Type="CT_RAW" Source="66757575" />
    </Color>
    <Color Name="EnvironmentLogo">
      <Background Type="CT_RAW" Source="FF5649B0" />
    </Color>
    <Color Name="EnvironmentLayeredBackground">
      <Background Type="CT_RAW" Source="80FFFFFF" />
    </Color>
  </Category>
```

Minimal migration token overrides for a Dark based theme:

```xml
<Category Name="Shell" GUID="{73708ded-2d56-4aad-b8eb-73b20d3f4bff}">
    <Color Name="AccentFillDefault">
      <Background Type="CT_RAW" Source="FF9184EE" />
    </Color>
    <Color Name="AccentFillSecondary">
      <Background Type="CT_RAW" Source="80000000" />
    </Color>
    <Color Name="AccentFillTertiary">
      <Background Type="CT_RAW" Source="CC9184EE" />
    </Color>
    <Color Name="SolidBackgroundFillTertiary">
      <Background Type="CT_RAW" Source="FF282828" />
    </Color>
    <Color Name="SolidBackgroundFillQuaternary">
      <Background Type="CT_RAW" Source="FF2C2C2C" />
    </Color>
    <Color Name="SurfaceBackgroundFillDefault">
      <Background Type="CT_RAW" Source="FF2C2C2C" />
    </Color>
    <Color Name="TextFillSecondary">
      <Background Type="CT_RAW" Source="C8FFFFFF" />
    </Color>
  </Category>
  <Category Name="ShellInternal" GUID="{5af241b7-5627-4d12-bfb1-2b67d11127d7}">
    <Color Name="EnvironmentBackground">
      <Background Type="CT_RAW" Source="FF1C1C1C" />
    </Color>
    <Color Name="EnvironmentBorder">
      <Background Type="CT_RAW" Source="FF9184EE" />
    </Color>
    <Color Name="EnvironmentIndicator">
      <Background Type="CT_RAW" Source="66757575" />
    </Color>
    <Color Name="EnvironmentLogo">
      <Background Type="CT_RAW" Source="FF9184EE" />
    </Color>
    <Color Name="EnvironmentLayeredBackground">
      <Background Type="CT_RAW" Source="4D3A3A3A" />
    </Color>
  </Category>
```

3. Adjust the color values to fit the previous theme as needed.

:::moniker-end


### Minimal token set starter for a light based theme

<!-- Minimal compatibility section to append to an existing light based .vstheme -->

```xml
<Theme Name="MyAwesomeLightTheme" ...>
<!-- existing theme categories here -->
<Category Name="Shell" GUID="{73708ded-2d56-4aad-b8eb-73b20d3f4bff}">
   <Color Name="AccentFillDefault">
      <Background Type="CT_RAW" Source="FF5649B0" />
   </Color>
   <Color Name="AccentFillSecondary">
      <Background Type="CT_RAW" Source="E55649B0" />
   </Color>
   <Color Name="AccentFillTertiary">
      <Background Type="CT_RAW" Source="CC5649B0" />
   </Color>
   <Color Name="SolidBackgroundFillTertiary">
      <Background Type="CT_RAW" Source="FFF9F9F9" />
   </Color>
   <Color Name="SolidBackgroundFillQuaternary">
      <Background Type="CT_RAW" Source="FFFFFFFF" />
   </Color>
   <Color Name="SurfaceBackgroundFillDefault">
      <Background Type="CT_RAW" Source="FFF9F9F9" />
   </Color>
   <Color Name="TextFillSecondary">
      <Background Type="CT_RAW" Source="9E000000" />
   </Color>
</Category>
<Category Name="ShellInternal" GUID="{5af241b7-5627-4d12-bfb1-2b67d11127d7}">
   <Color Name="EnvironmentBackground">
      <Background Type="CT_RAW" Source="FFEEEEEE" />
   </Color>
   <Color Name="EnvironmentBorder">
      <Background Type="CT_RAW" Source="FF5649B0" />
   </Color>
   <Color Name="EnvironmentIndicator">
      <Background Type="CT_RAW" Source="66757575" />
   </Color>
   <Color Name="EnvironmentLogo">
      <Background Type="CT_RAW" Source="FF5649B0" />
   </Color>
   <Color Name="EnvironmentLayeredBackground">
      <Background Type="CT_RAW" Source="80FFFFFF" />
   </Color>
</Category>
</Theme>
```

### Minimal token set starter for a dark based theme

<!-- Minimal compatibility section to append to an existing dark based .vstheme -->

```xml
<Theme Name="MyAwesomeDarkTheme" ...>
<!-- existing theme categories here -->
<Category Name="Shell" GUID="{73708ded-2d56-4aad-b8eb-73b20d3f4bff}">
   <Color Name="AccentFillDefault">
      <Background Type="CT_RAW" Source="FF9184EE" />
   </Color>
   <Color Name="AccentFillSecondary">
      <Background Type="CT_RAW" Source="80000000" />
   </Color>
   <Color Name="AccentFillTertiary">
      <Background Type="CT_RAW" Source="CC9184EE" />
   </Color>
   <Color Name="SolidBackgroundFillTertiary">
      <Background Type="CT_RAW" Source="FF282828" />
   </Color>
   <Color Name="SolidBackgroundFillQuaternary">
      <Background Type="CT_RAW" Source="FF2C2C2C" />
   </Color>
   <Color Name="SurfaceBackgroundFillDefault">
      <Background Type="CT_RAW" Source="FF2C2C2C" />
   </Color>
   <Color Name="TextFillSecondary">
      <Background Type="CT_RAW" Source="C8FFFFFF" />
   </Color>
</Category>
<Category Name="ShellInternal" GUID="{5af241b7-5627-4d12-bfb1-2b67d11127d7}">
   <Color Name="EnvironmentBackground">
      <Background Type="CT_RAW" Source="FF1C1C1C" />
   </Color>
   <Color Name="EnvironmentBorder">
      <Background Type="CT_RAW" Source="FF9184EE" />
   </Color>
   <Color Name="EnvironmentIndicator">
      <Background Type="CT_RAW" Source="66757575" />
   </Color>
   <Color Name="EnvironmentLogo">
      <Background Type="CT_RAW" Source="FF9184EE" />
   </Color>
   <Color Name="EnvironmentLayeredBackground">
      <Background Type="CT_RAW" Source="4D3A3A3A" />
   </Color>
</Category>
</Theme>
```

## FAQ

### Why was this a breaking change?

Besides theme color token structure and naming convention changes, most of the UI code has been refactored to use semantic styling tokens from the Fluent Design System, instead of previous feature-scoped tokens or inline styles. While most of the old color and other styling resources remain present in the SDK, they may not reflect the latest design or behave consistently in the modernized UI.

### Can I keep using the previous tokens?

Previous tokens may still resolve for *some* earlier surfaces, but new
and refactored UI paths read the new semantic tokens first. If you rely
on deprecated tokens, you risk incomplete theming.

### Where is the classic Blue theme?

We replaced it with a family of tinted themes and Extra Contrast editor
appearances options. You can also install the community [Blue Steel](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.BlueSteel) theme
if you want a closer homage.

### Do fewer tokens mean less customization?

No---semantic tiers let you create broad visual shifts by adjusting a small palette. You can still craft distinct personalities via accent hue, background luminance steps, and system fills.

### Performance impact?

The refactor reduces style lookups and redundant resources, improving memory locality, and simplifying deferred brush creation.

### Are editor colors changing too?

The editor currently retains most of its syntax colorization. This change targets shell UI shared surfaces such as tool windows, menus and dialogs. You can choose editor appearance (including Extra Contrast) independently.

