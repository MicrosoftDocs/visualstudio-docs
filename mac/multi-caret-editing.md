---
title: Multi-caret Editing
description: Multi-caret Editing 
author: cobey
ms.author: cobey
ms.date: 08/19/2019
---
# Multi-caret Editing

Multi-caret editing allows you to add _n_ number of insertion points at a single time. When in multi-caret mode, you can add additional carets to your document either via mouse clicks or via keyboard commands. The primary caret is denoted by a red cursor, while the secondary carets present in a light-blue color. Multi-caret edit mode can be disabled via the `ESC` key.

## Enabling Multi-caret Editing

### Keyboard

You are able to enable multi-caret mode via the keyboard in several ways. The following table provides the keyboard shortcuts available to enter specific modes of multi-caret editing:

| Hotkey  | Action                        | 
|---------| ------------------------------|
|  ⌥⇧.   | Insert next matching caret    | 
|  ⌥⇧;   | Insert carets at all matching | 
|  ⌥⇧,   | Remove last caret             | 
|  ⌥⇧/   | Move last caret down          | 

Each of these behaviors are anchored to the current position of the caret when you invoke the command. For example, if the caret is at the start of the word "name" and you invoke "Insert carets at all matching" (⌥⇧;) each instance of the word "name" in your current document will have a caret inserted at the start of the word. Likewise, if you invoke the command "Insert next matching caret" (⌥⇧.) then a caret will be placed at the next instance of the word "name". This command can be invoked multiple times.

![multi-caret keyboard](media/multi-caret-keyboard.gif)

## Mouse / Touchpad

By using your cursor, you are able to free select specific insertion points for your multiple carets. While the keyboard shortcuts are bound to matching strings, you can manually insert a caret anywhere in the document with the cursor. Once the carets are set,each will echo the key entries you type on your keyboard.

To use the mouse to insert multiple carets, you must press and hold ⌘⌥ and click where you would like the carets to be entered. You will be in insertion mode as long as the ⌘⌥ keys are held. If you insert a caret in an incorrect location, you can remove the caret by continuing to hold ⌘⌥ and clicking in the same area again. Once you have all of the carets located where you would like them, stop pressing the ⌘⌥ keys and start typing. The following GIF demonstrates both selecting a set of insertion points as well as removing erroneously set points.

![multi-caret mouse](media/multi-caret-mouse.gif)

## See also

- [Quick Actions (Visual Studio on Windows)](/visualstudio/ide/quick-actions)
- [Refactor code (Visual Studio on Windows)](/visualstudio/ide/refactoring-in-visual-studio)