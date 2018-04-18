---
title: "Change Log (Visual Studio Tools for Unity, Mac) | Microsoft Docs"
ms.custom: ""
ms.date: "04/05/2018"
ms.technology: vs-unity-tools
ms.topic: "conceptual"
ms.assetid: 33a6ac54-d997-4308-b5a0-af7387460849
author: "dantogno"
ms.author: "v-davian"
manager: crdun
ms.workload:
  - "unity"
---
# Change Log (Visual Studio Tools for Unity, Mac)
Visual Studio Tools for Unity change log.

## 1.5.0.1
 Released 2018-03-28
 
### New Features

-   **Integration:**

    -   Added support for extra templates in the Unity Project Explorer.

## 1.5.0.0
 Released 2018-03-21
 
### New Features

-   **Integration:**

    -   Added support for detecting and attaching to Android players connected through USB.

## 1.4.0.3
 Released 2018-03-05
 
### New Features

-   **Project Generation:**

    -   Added support for the new project generator in Unity 2018.1.

-   **Integration:**

    -   Added option panel for dedicated settings.

## 1.4.0.2
 Released 2018-01-24
 
### Bug fixes

-   **Project Generation:**

    -   Fixed Mono version detection.

-   **Integration:**

    -   Fixed timing issues with 2018.1 and plugin activation.

    -   Fixed notifications when detecting a new player.

## 1.4.0.1
 Released 2018-01-23
 
### Bug fixes

-   **Integration:**

    -   Fixed Expand/Collapse folders on double-click

## 1.4.0.0
 Released 2017-12-13
 
### New Features

-   **Project Generation:**

    -   Added support for .NET Standard.

### Bug fixes

-   **Integration:**

    -   Fixed automatic pdb to mdb debug symbol conversion.

## 1.3.0.1
 Released 2017-12-12
 
### Bug fixes

-   **Integration:**

    -   Fixed indirect call to EditorPrefs.GetBool impacting the inspector while trying to change array size.

-   **Wizards:**

    -   Refresh roslyn context before inserting method.

## 1.3.0.0
 Released 2017-11-20
 
### New Features

-   **Wizards:**

    -   Added "Implement Unity message" wizard.

    -   Added support for the new completion API in VS for Mac 7.4.

## 1.2.0.0
 Released 2017-10-23
 
### New Features

-   **Debugger:**

    -   Added support for portable debug symbol files.

### Bug fixes

-   **Project Generation:**

    -   Fixed extra .dll extension wrongly added to the assembly filename.

    -   Do not force the AllowAttachedDebuggingOfEditor Unity flag as the default is now 'true'.

## 1.1.0.3
 Released 2017-10-23
 
### New Features

-   **Project Generation:**

    -   Added support for .NET 4.6 profile.

## 1.1.0.2
 Released 2017-08-08
 
### New Features

-   **Debugger:**

    -   Start the attach to process dialog if not sure which Unity to attach to.

-   **Project Generation:**

    -   Always enable unsafe compilation switch when Unity 5.6 is used.

## 1.1.0.1
 Released 2017-07-20
 
### New Features

-   **Integration:**

    -   Added support for localized resources.

## 1.1.0.0
 Released 2017-07-12
 
### New Features

-   **Integration:**

    -   Added support for attaching to players and editors through the Attach to process window.

-   **Project Generation:**

    -   Fixed assembly name references with mcs.rsp files.

    -   Added support for assembly.json compilation units.    

    -   Fixed defines with API levels.    

### Bug fixes

-   **Integration:**

    -   Fixed shader error message when compiling.

## 1.0.0.1
 Released 2017-05-04
 
### Bug fixes

-   **Integration:**

    -   Fixed active document tracking with hybrid and regular projects.

## 1.0.0.0
 Released 2017-05-03
