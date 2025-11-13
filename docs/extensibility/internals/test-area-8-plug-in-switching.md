---
title: 'Test Area 8: Plug-in Switching'
description: This source control test area provides test cases for the process of picking which plug-in to use for solution source control in Visual Studio.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- source control [Visual Studio SDK], switching plug-ins
- source control plug-ins, switching
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Test Area 8: Plug-in Switching

The Visual Studio integrated development environment (IDE) has the user interface (UI) to change the current source control plug-in. This test area provides test cases for the process of picking which plug-in to use for solution source control.

## Command Menu Access
 The following Visual Studio integrated development environment menu paths are used in the test cases.

- Current source control plug-in: **Tools** -> **Options** -> **Source Control** -> **Plug-in Selection**.

- Change source control binding: **File** -> **Source Control** -> **Change Source Control**...

## Common Expected Behavior
 Changing the source control plug-in for a solution is possible without exiting Visual Studio or reloading the solution. In addition, the current source control plug-in automatically changes to the one used by a solution when that solution is loaded.

## Test Cases
 The following are specific test cases for the plug-in switching test area.

### Case 8a: Automatic Change

#### Expected Behavior
 When a user loads  a solution that is under source control, the solution is automatically loaded and the appropriate source control plug-in is selected as current.

| Action | Test Steps | Expected Results to Verify |
| - | - | - |
| Automatic source control plug-in change | 1.  Select plug-in under test as current (**Tools** -> **Options** -> **Source Control** -> **Plug-in Selection**.)<br />2.  Create a new project.<br />3.  Add the solution to source control.<br />4.  Select another plug-in (for example, Visual SourceSafe).<br />5.  Accept unloading solution prompt.<br />6.  Reopen the solution from disk. | Solution is opened.<br /><br /> Plug-in under test is the current source control plug-in. |

### Case 8b: Solution-based Change

#### Expected Behavior
 The solution can have its associated source control plug-in changed.

| Action | Test Steps | Expected Results to Verify |
|----------------------------------| - | - |
| Change of plug-in for a solution | 1.  Select plug-in under test as current (**Tools** -> **Options** -> **Source Control** -> **Plug-in Selection**).<br />2.  Create a new project and solution.<br />3.  Add the solution to source control.<br />4.  Unbind the solution from source control (using the **Change Source Control** dialog box).<br />5.  Select another plug-in (for example, Visual SourceSafe).<br />6.  Reload the solution from disk if unloaded.<br />7.  Add the solution to source control.<br />8.  Unbind the solution from source control (using **Change Source Control** dialog box).<br />9. Select plug-in under test again.<br />10. Reload solution from disk if unloaded.<br />11. Bind the solution to the original location (using the **Change Source Control** dialog box). | Solution is added to source control by using the selected plug-in. |

## Related content
- [Test Guide for Source Control Plug-ins](../../extensibility/internals/test-guide-for-source-control-plug-ins.md)
