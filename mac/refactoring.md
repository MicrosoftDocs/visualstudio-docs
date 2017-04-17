---
title: Refactoring
description: Re-organising code in Xamarin Studio is simple through the use of Source Analysis.
author: asb3993
ms.author: amburns
ms.date: 04/14/2017
ms.topic: article
ms.assetid: C7782BF3-016F-4B41-8A81-85FC540A1A8F
---

# Overview

Refactoring code is a way to rearrange, restructure, and clarify existing code while still ensuring that the overall behaviour of the code does not change. 

It produces a healthier code base, making it much more useable, readable, and maintainable for you or any other developer or user that may refer to the code.

Xamarin Studio's integration with Roslyn, Microsoft’s open source .NET compiler platform, allows for more refactoring operations, as well as fully supporting C# 6.0.

# Renaming 

The *Rename* refactoring command is extremely useful, and can be used on any code identifier (eg. a class name, property name etc.) to find all occurrences and change them. To rename a symbol, right-click on it and choose **Refactor > Rename**, or the **Cmd + R** keybinding:

![](Images/refactoring-renaming1.png)

This will highlight the symbol in green and any references to it in blue. When you start typing a new name it will automatically change all references in your code, and you can signal your completion of the rename by pressing **Enter**:

 ![](Images/refactoring-renaming2.png)

# Context Actions

Context Actions in Xamarin allow you to inspect any C# code, and see all possible refactoring options. 

The **Resolve** and **Refactor** context items have been combined into a single *Fix* item that will provide you with all the available Context Actions:

![](Images/refactoring-context-action.png)

Alternatively, you can press **Option + Enter** anywhere in your code:

![](Images/refactoring-image2a.png)

To enable these option, you must select *Enable source analysis of open files* in the options **Xamarin Studio > Preferences > Text Editor > Source Analysis**:

 ![](Images/refactoring-options.png)

There are over 100 possible actions that can be suggested, which can be controlled by browsing to **Xamarin Studio > Preferences > Source Analysis > C# > Code Actions**:

 ![](Images/refactoring-image3a.png)



## Common Context Actions

Some of the mostly commonly used context actions are explained below.

### Extract Method

The extract method refactoring operation allows you to create a new method by extracting a selection of code in an existing member. This action will do two things:

* Creates a new method containing the selected code
* Calls the new method in the place where the selected code was.

#### Example

1. Add the following code:

```
    class MainClass
    {

        double CalculatePyramidVolume(double baseArea, double height)
        {

            double volume = (baseArea * height) / 3;

            return volume;
        }
    }
```

2. Highlight the line `double volume = (baseArea * height) / 3;`, right click on it, and select **Refactor > Extract Method**.

3. Use the arrow keys to select where the new method should be placed in your code.


### Encapsulate Field

The Encapsulate Field operation allows you to create a property from an existing field, and updates your code to reference the newly created property. By creating a property that encapsulates your field, you are disallowing direct access to your public field, meaning that other objects can't modify it.

This action will do the following:

* Changes the access modifier to private.
* Generates a getter and setter for the field (unless the field is read-only, in which case it will only create a getter).


# Source Analysis

Source analysis will analyse your code on the fly by underlining potential errors and style violations, and providing auto fixes as context actions. 

You can view all results of the source analysis for any file, at any time by viewing the scroll bar on the right side of the text editor:

 ![](Images/refactoring-image4a.png)

If you click on the circle at the top, you can iterate through each suggestion, with the highest severity issues showing first. Hovering over an individual result or line will display the issue, which can be fixed through context actions:

 ![](Images/refactoring-image5.png)

