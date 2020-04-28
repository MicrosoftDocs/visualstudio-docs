---
title: "Accessibility"
description: "This article introduces the accessibility features in Visual Studio for Mac and how they can be enabled."
author: heiligerdankgesang
ms.author: dominicn
ms.date: 08/15/2017
ms.assetid: 2C4AAC2E-3B4A-4496-8BE0-1F5A7F81D1CA
---

# Accessibility

In addition to features and utilities in macOS, Visual Studio for Mac has the following features, making it more accessible for people with disabilities:

- Text Enlargement in the Solution and Editor Pads
- Text size options in the editors
- Color customization in the editors
- Keyboard shortcut customization
- Code-completion for methods and parameters

For more information on accessibility features in macOS, see [Apple's website](https://www.apple.com/accessibility/mac/).

## Using Accessibility features in Visual Studio for Mac

The Accessibility features in Visual Studio for Mac are turned off by default. To enable them, do the following steps:

1. Go to **Visual Studio > Preferences > Other > Accessibility**.

2. Select the **Enable Accessibility** checkbox, as illustrated in the following diagram:

    ![Enable accessibility checkbox](media/accessibility-image1.png)

3. Press the **Restart Visual Studio** button to allow the accessibility features to take effect.

Alternatively, you can use the command line to enable accessibility features. To do this, enter the following command in terminal:

```bash
defaults write com.microsoft.visual-studio com.monodevelop.AccessibilityEnabled 1
```

After turning on accessibility, you need to restart Visual Studio.

## How to: Use Keyboard Navigation

Keyboard navigation can be enabled by setting the Full Keyboard Access option in **System Preferences > Keyboard > Shortcuts** to **All Controls**:

![Systems preferences panel in macos](media/accessibility-image2.png)

Setting full keyboard access turns on the focus rectangle. You can then select controls using:

- Tab to go forward through controls
- Shift-Tab to go backwards through controls
- Arrow keys to move between controls in the direction of the arrows.

Pressing the Space bar activates the focused control.

## How to: Enable and use Voice Over

Turn VoiceOver on or off press **Cmd + F5**

To navigate through the UI VoiceOver commands, use the following commands:

- Move VoiceOver cursor between Controls: **Ctrl + Alt + Left arrow key / Right arrow key**

   VoiceOver reads out the name of the controls, some details about it, and what you can do with it.

- Enter Groups and controls (such as the Solution Pad, Toolbox, and other Pads): **Ctrl + Alt + Shift + Down Arrow**

   Once inside a control, you can use **Ctrl + Alt + Arrows** to move around inside it.

For general information on using VoiceOver in macOS, refer to the following guides:

- [Getting Started with VoiceOver](https://help.apple.com/voiceover/info/guide/10.12/)
- [VoiceOver commands in macOS](https://lab.dotjay.com/notes/voiceover-commands/)

## See also

- [Accessibility features of Visual Studio (on Windows)](/visualstudio/ide/reference/accessibility-features-of-visual-studio)