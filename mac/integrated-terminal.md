---
title: Visual Studio for Mac – Integrated Terminal
description: "Visual Studio for Mac provides an integrated development environment to build .NET applications on macOS, including ASP.NET Core websites and Xamarin projects for iOS, Android, Mac, and Xamarin.Forms."
author: jmatthiesen
ms.author: jomatthi
ms.date: 05/14/2020
ms.assetid: EFD53CE9-8174-4FE4-8863-2984D22FD921
---
# Integrated Terminal
In Visual Studio for Mac you can open an integrated terminal window, initially starting at the root of your solution. This can be useful for a variety of situations – running front-end tasks (e.g. npm, ng, or vue), managing containers, running advanced git commands, scaffolding, automating builds, executing Entity Framework commands, viewing dotnet CLI output, adding NuGet packages, and more. 

To open the terminal:
- Use the **Ctrl + `** keyboard shortcut to show or hide the terminal window.
- Use the **View** \> **Pads** \> **Terminal** menu.
- Use the **terminal** command from the search bar.

![*The Visual Studio for Mac integrated terminal immediately after being launched.*](media/integrated-terminal-intro.png)

By default, when the terminal is launched it will:
- Set the working directory to the path of the current solution
- Load the default system shell

## Search
You can search the content of the terminal window by using the **Search > Find...** menu.

![*Search experience in the Visual Studio for Mac Integrated Terminal*](media/integrated-terminal-search.png)

## Terminal Keyboard Shortcuts
|Commands|Keyboard shortcuts|
|-|-|
|Show/Hide the terminal window|**Ctrl+ `**|
|Create new terminal instance|**Ctrl+'**|
|Scroll page up|**PageUp**|
|Scroll page down|**PageDown**|
|Cycle through previously used commands|**↑**, **↓**|
|Increase font size|**⌘+**|
|Decrease font size|**⌘-**|

## Multiple instances
Multiple instances of the terminal may be running at any time. You can create a new instance by using the **Ctrl+'** keyboard shortcut. You can switch between instances by either clicking on the tab for each instance, or using the **Ctrl+tab** shortcut to bring up the window picker dialog.

![*Multiple terminal instances in Visual Studio for Mac*](media/integrated-terminal-multiple-instances.png) 

## Customizing the terminal window
### Configuring the Terminal Font
You can change the font and size used for Terminal Contents in the Preferences > Environment > Fonts pane. By default, the font will be the same as Output Pad Contents, using Menlo Regular, size 11. You can set it to any font, independent of your editor font.

![*Customizing the font settings for the integrated terminal*](media/integrated-terminal-change-font.png)

### Re-using system terminal customizations
The integrated terminal uses the same defaults and configuration as your macOS system terminal. That means that your terminal customizations (zsh, oh-my-zsh, etc.) also work in the integrated terminal.