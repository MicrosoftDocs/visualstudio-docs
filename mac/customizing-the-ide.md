---
title: Customizing the IDE
description: Xamarin Studio can be customized in a variety of ways, allowing users to develop apps in an environment that meets both their efficiency and aesthetic needs. In this guide we will explore the variety of ways Xamarin Studio can be adapted to suit developer's needs.
author: asb3993
ms.author: amburns
ms.date: 04/14/2017
ms.topic: article
ms.assetid: F7C2A28C-0759-4E0D-A28E-B72D5AB73DB6
---


# Dark Theme

![](Images/customizing-the-ide-image7a.png)

Xamarin Studio 6.0 introduced the long-awaited dark theme for Xamarin Studio, in addition to many visual tweaks to make the IDE more pleasant to use.

You can switch themes in Xamarin Studio by browsing to **Preferences > Environment > Visual Style** and selecting your desired theme from the *User Interface Theme* dropdown, as illustrated in the screenshot below:

 ![](Images/customizing-the-ide-image7b.png)

# Localization

Xamarin Studio has now been localized, enabling it to be accessible to more developers. The languages currently are available are listed below:

* Chinese – China
* Chinese – Taiwan
* Czech
* French
* German
* English
* Italian
* Japanese
* Korean
* Portuguese (Brazil)
* Russian
* Spanish
* Turkish

To change the language that Xamarin Studio displays, browse to **Preferences > Environment > Visual Style** and select your desired language from the *User Interface Language* dropdown, as illustrated in the screenshot below:


![](Images/customizing-the-ide-image11a.png)

# Author Information

The author information panel allows you to add relevant information about yourself such as your Name, email address, the copyright owner for your work, your company, and trademark, as illustrated below:

 ![](Images/customizing-the-ide-image9a.png)

This information is used to populate standard file headers, such as a license that you might add to new files created in Xamarin Studio:

 ![](Images/customizing-the-ide-image8a.png)


Populated **Name** and **Email** fields will be used to add information to any commit that is made through Version Control in Xamarin Studio. If you have not populated these fields, Xamarin Studio will prompt you to do so when you try to use Version Control.

# Keybindings

Keybindings allow you to adapt your development environment so that you can move more efficiently throughout Xamarin Studio. For example, Visual Studio users can set the keybindings in Xamarin Studio to give a much more familiar feel to the IDE. 

Keybindings can be set by browsing to **Preferences > Environment > Key Bindings**, as illustrated below:

 ![](Images/customizing-the-ide-image10a.png)

From here you can search for keybinding combinations, view conflicting bindings, add new bindings, and edit the existing bindings.

# Workspace Layout

Xamarin Studio's workspace consists of a main document area (normally the editor, designer surface, or options file), surrounded by complimentary *pads* which contain useful information for accessing and managing application files, testing, and debugging.

 ![](Images/customizing-the-ide-image1a.png)

## Viewing and Arranging Pads

When you open any new solution or file in Xamarin Studio, you should notice a number of *pads* in the workspace, including the Solution Pad, Document Outline, and Errors:

![](Images/customizing-the-ide-image2a.png)

Xamarin Studio provides many pads containing addition information, tools, and navigation aids, all of which can be accessed by browsing to the **View > Pads** menu item and selecting the pad to add it:

 ![](Images/customizing-the-ide-image3a.png)

Pads may also be opened automatically by various commands, such as the **Find in Files** (Shift + Cmd + F) command, which opens a detached pad of search results.

Pads can be moved and arranged throughout your workflow in whatever way is most useful to you. For example, they can be docked on any side of the document editor, adjacent to another pad, above or below another pad, or as a set of tabbed pads enabling you to quickly switch beween them:

![](Images/customizing-the-ide-pads-large.png)

For frequently used pads, you can also completely detach a pad from the Xamarin Studio window, and create a separate window for that pad.
 
Pads can be hidden and closed by the toggles in the top-right corner of each pad:
 
![](Images/customizing-the-ide-image5a.png)

Auto-hidden pads are docked to the sides of the workspace making them easily accessible when they are required. Hovering over the pad will be display it again, and it will be hidden when the mouse and keyboard focus leaves it.


## Organising Layouts

The pads which are displayed at any time are dependent on the current context. For example when using the visual designer, the toolbox and property grid pads are most important; when debugging, it is useful to have the debugger pads for viewing the stack and locals.

The state of the open pads is represented by a *layout*. The layouts can be  switched manually through the View menu, as illustrated below, or it will be switched automatically when you carry out an action, such as debugging, or opening a Storyboard:

![](Images/customizing-the-ide-image6b.png)

There is always one active layout and any change you make in a layout, such as adding or repositioning a pad will only change the active layout. Once you close Xamarin Studio the changes you have made will not be saved. 

However, it is possible to create a new layout suitable for your needs in the **View > New Layout…** menu item. This will add your layout to the menu so that you can select it at any time:

![](Images/customizing-the-ide-image6a.png)

## Side-by-side editing support
 
Xamarin Studio allows you to open text editors side-by-side, or to have an editor as a detached floating window.

2-column mode can be enabled through the View menu item by selecting **View > Editor Layout > 2 columns**, or by dragging an editor tab to one of the edges of the editor area, as shown below:

 ![](Images/customizing-the-ide-sbs.png)
 
Editor tabs can be dragged out of the document area to create a floating editor window. This floating window also supports side-by-side editors, and can contain several editor tabs:

 ![](Images/customizing-the-ide-sbs1.png)
 
 ![](Images/customizing-the-ide-sbs2.png)

To revert back to a single open editor, select **View > Editor Layout > 1 column**.






