---
title: "Comments"
description: 
author: asb3993
ms.author: amburns
ms.date: 04/14/2017
ms.topic: article
ms.assetid: 0FE5E929-1846-4F48-B5E3-70990FAF9504
---

# Comments

When debugging or experimenting with code, it can be very useful to comment a block of code temporarily.

To comment out an entire block of code:

* Select the code and select **Toggle Line Comment(s)** from the context menu

OR

* Use the `&#8984; + /` keybinding on the selected code.

These methods can be used to comment and uncomment sections of code. In C# files, additional levels of line comments can be added, which allows regions of codes to be commented and uncommented, while still preserving actual comments: 

 ![](Images/source-editor-image8.png)

Comments are also useful for documenting code for future developers that may interact with it. These are usually done in the form of multi-line comments, which is added in the following way in each language:

**C#**

```
/*
 This is a multiline
 comment in C#
*/
```
**F#**

```
(*
 This is a multiline
  comment in F#
*)
```
