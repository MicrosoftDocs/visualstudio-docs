---
title: "Accessibility"
description: "This article introduces the accessibility features in Visual Studio for Mac and how they can be enabled."
author: conceptdev
ms.author: crdun
ms.date: 04/17/2019
ms.assetid: 2C4AAC2E-3B4A-4496-8BE0-1F5A7F81D1CA
---

# Accessibility

Visual Studio for Mac has the following accessibility features, making it more accessible for people with differing abilities:

- Text enlargement in the solution and editor pads
- Text size options in the editors
- Color customization in the editors
- Keyboard navigation
- Shortcut customization
- Code-completion for methods and parameters

In addition to these features, Apple provides a number of tools to assist users with special needs, such as VoiceOver and Dictation.

For more information on accessibility features in macOS, see [Apple's website](https://www.apple.com/accessibility/mac/).

## Enabling macOS Assistive Technologies in Visual Studio for Mac

Visual Studio for Mac's support for macOS assistive technologies is turned off by default. To enable it follow these steps:

1. Go to **Visual Studio (menu) > Preferences > Other > Accessibility**

2. Check the **Enable Accessibility** checkbox:

   ![Preferences accessibility checkbox](media/accessibility-preferences.png)

3. Select the **Restart Visual Studio** button to restart Visual Studio and enable support for Apple's assistive technologies.

## How to: Use Keyboard Navigation

Keyboard navigation support is built right into macOS, but in order to have the most comprehensive experience you should set macOS to navigate **All controls**:

![System preferences keyboard all controls](media/accessibility-preferences-keyboard.png)

Setting **Full Keyboard Access** to **All controls** allows you to navigate through all controls in a window or dialog. You can then select controls using:

- Tab to go forward through controls
- Shift-Tab to go backwards through controls
- Arrow keys to move between controls in the direction of the arrows
- Control-Tab out of text-area boxes
- Pressing the Space bar activates the control currently in focus.

## How to: Enable and Use VoiceOver

To enable or disable VoiceOver press **&#8984; + F5**

VoiceOver commands appear in this guide as **VO+_key_** whereby **VO** refers to the modifier set in the **VoiceOver Utility** application. The default modifier is **Ctrl + Alt**. For example, depending on your VoiceOver modifier, **VO + M** will mean **Ctrl + Alt + M**. For brevity, cursor keys will be referred to as **Left** and **Right**, etc.

To navigate the Visual Studio for Mac user interface, use the following key combinations:

- **VO + Right / Left**: Navigate between user interface elements
  - VoiceOver will announce the label and type of control, and explain how to interact with it.
- **VO + Shift + Down / Up**: Step into / out of an element
  - Once inside an element you can use **VO + Left / Right** to navigate around elements within it.
- **VO + Space**: Select / interact with a control
- **VO + M**: Interact with the Visual Studio for Mac Menu Bar

For further information on using VoiceOver and a comprehensive list of commands, please refer to the following guides:

- [Apple VoiceOver Getting Started Guide](https://support.apple.com/en-us/guide/voiceover-guide/welcome/web)
- [VoiceOver commands in macOS](http://lab.dotjay.com/notes/voiceover-commands/)

## See also

- [Accessibility features of Visual Studio (on Windows)](/visualstudio/ide/reference/accessibility-features-of-visual-studio)
