---
title: 'Test Area 3: Check Out-Undo Checkout'
description: This source-control plug-in test area covers editing and reverting items from the version store by using the Check Out and Undo Checkout commands.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- source control plug-ins, checkout
- source control plug-ins, undo checkout
- source control [Visual Studio SDK], checking out
- source control [Visual Studio SDK], undo checkout
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Test Area 3: Check Out/Undo Checkout

This source-control plug-in test area covers editing and reverting items from the version store via the **Check Out** and **Undo Checkout** commands.

**Check Out**: Marks an item in the version store as checked out, modifies the local copy to read/write.

**Undo Checkout**: Marks an item in the version store as checked in, reverts local copy to state before the check out (depending on options).

## Command Menu Access

The following Visual Studio integrated development environment menu paths are used in the test cases.

##### Check Out:

- **File**, **Source Control**, **Check Out**.

- **File**, **Check Out**.

- Shortcut Menu, **Check Out**.

- Undo Checkout: **File**, **Source Control**, **Undo Checkout**.

## Common Expected Behavior

- After the check out operation, the target file(s) and/or folder(s) are marked as checked out in the version store.

- The version store attributes the checkout to the correct user.

- The time and date of the checkout are correct (per the user's settings).

## Test Cases

The following are specific test cases for the Checkout/Undo Checkout test area.

### Case 3a: Check Out

This section focuses on the operation of the check-out command.

|Action|Test Steps|Expected Results to Verify|
|------------|----------------|--------------------------------|
|Check Out Exclusive (COE) a client project|1.  Create a client project.<br />2.  Add the solution to source control.<br />3.  Check out the entire project exclusively (**File**, **Check Out**).|Check out occurs.|
|Check Out Exclusive (COE) a File System or local IIS Web project|1.  Set Web Server Connection to File Share in **Tools**, **Options**, **Projects**, **Web Settings**.<br />2.  Create a Web project.<br />3.  Add the solution to source control.<br />4.  Check out the entire project exclusively (**File**, **Source Control**, **Check Out**).|Check out occurs.|
|Check out solution items in a solution (new method for handling other files)|1.  Create a blank solution.<br />2.  Add the solution to source control.<br />3.  Check out the solution.<br />4.  Add several solution items.<br />5.  Check in all the newly added items.<br />6.  Select multiple solution items.<br />7.  Check out the selected items (Shortcut Menu, **Check Out**).|Selected files are checked out.|
|Check Out Local Version (if plug-in under test supports this feature)|1.  User 1: Create a client project.<br />2.  User 1: Add the solution to source control.<br />3.  User 2: Open the solution from source control to another location.<br />4.  User 2: Check out a file.<br />5.  User 2: Modify the file.<br />6.  User 2: Check in the file.<br />7.  User 1: Check out local version of the file (Check the **Check Out Local Version** advanced option in **Check Out** dialog box).|Local version of the file is checked out.<br /><br /> Modifications by user 2 are not applied to User 1 file.|

### Case 3b: Disconnected Check out

Operating in disconnected mode allows users some level of continued source control support when not attached directly to a version store. This is done by locally caching all relevant information about the enlisted solution and projects.

Exclusive check out operations can only occur while connected to the source control store. Shared check out operations can occur at any time, whether connected or disconnected. Therefore, when disconnected from the version store, only the **Check Out Shared** (COS) command is enabled. While disconnected, **Undo Checkout** is disabled because the old version cannot be retrieved to replace changes made by the user.

When the user reconnects to the version store, the checkout states of all of the enlisted solutions and projects are synchronized. This does the necessary updates to the store for the checkouts that the user has performed. Once the synchronization has happened, the user is able to continue working as normal (connected).

#### Expected Behavior

- Cannot use **Check Out Exclusively** command while disconnected from the version store.

- Cannot use **Undo Checkout** command while disconnected from the version store.

- **Shared Check Out** command works.

|Action|Test Steps|Expected Results to Verify|
|------------|----------------|--------------------------------|
|While disconnected, check out a file, then connect for syncing|1.  Disconnect a controlled project using Change Source Control dialog box (**File**, **Source Control**, **Change Source Control**).<br />2.  Check a file out.<br />3.  Click Check Out (disconnected) in the warning dialog box.<br />4.  Edit the file.<br />5.  Connect using the Change Source Control dialog box.<br />6.  Get Latest Version of the edited file.|Common Expected Behavior|

### Case 3c: Query Edit/Query Save (QEQS)
 Items under source control are tracked for edits, changes, and saves to help users easily manage their files. When a controlled item that is "checked in" is edited, QEQS intercepts the attempted edit and asks the user if he wants to check out the file to edit it. Depending on **Tools**, **Options** settings, the user is either forced to check out the file in order to edit or may be allowed to edit a copy in memory and check out later. If the user's **Tools**, **Options** setting is not set to display the check out dialog box and to just check it out, then as the user makes his edit, the file automatically checks out, whenever possible.

#### Expected Behavior

- After the check out operation, the target file(s) and/or folder(s) are marked as checked out in the version store.

- The version store attributes the check out to the correct user.

- The time and date of the check out are correct (per the user's settings).

- The local copy of the target file or folder is writeable.

|Action|Test Steps|Expected Results to Verify|
|------------|----------------|--------------------------------|
|Edit text file that is checked in|1.  Create a new project containing a text file.<br />2.  Add the solution to source control.<br />3.  Set **Tools**, **Options**, **Source Control**, **Allow files to be edited while read-only on disk** to unchecked.<br />4.  Set **Tools**, **Options**, **Source Control**, **Prompt for check out** in the **when checked in files are edited** combo box.<br />5.  Set **Tools**, **Options**, **Source Control**, **Prompt for check out** in the **when checked in files are saved** combo box.<br />6.  Open text file in editor, attempt to type new text into the file. If this step succeeds, continue to next step.<br />7.  Click **Cancel** in the **Check out for Edit** dialog box. If this step succeeds, continue to next step.<br />8.  Set **Tools**, **Options**, **Source Control**, **Allow files to be edited while read-only on disk** to checked.<br />9. Open project file in editor, attempt to type new text in the file. If this step succeeds, continue to next step.<br />10. Click **Edit** in the **Check out for Edit** dialog box. If this step succeeds, continue to next step.<br />11. Edit the text file and attempt to save it.|`Result of step 6:`<br /><br /> Check out for Edit dialog box appears.<br /><br /> `Result of step 7:`<br /><br /> The file is unchanged.<br /><br /> `Result of step 9:`<br /><br /> Check out for Edit dialog box appears.<br /><br /> `Result of step 10:`<br /><br /> You can edit the project file in memory.<br /><br /> `Result of step 11:`<br /><br /> On save, the Check out on save dialog box appears.|
|Edit a solution file that is checked in|Repeat the steps as described in previous test but instead of modifying a text file, modify solution by changing solution properties.|Same as previous test|
|Edit a project file that is checked in|Repeat the steps as described in previous test but instead of modifying a text file, modify project by changing project properties.|Same as previous test.|

### Case 3d: Silent Check Out
 This sub-area covers check out  scenarios where the **Check Out** dialog box does not appear per user's **Tools**, **Options**, **Source Control settings**.

#### Expected Behavior

- After the check out operation, the target file(s) and/or folder(s) are marked as checked out in the version store.

- The version store attributes the check out to the correct user.

- The time and date of the check out is correct (per the user's settings).

- The local copy of the target file or folder is writeable.

|Action|Test Steps|Expected Results to Verify|
|------------|----------------|--------------------------------|
|Silent checkout for a file|1.  Set **Tools**, **Options**, **Source Control** to **checkout files automatically on edit**.<br />2.  Create a new project with a file.<br />3.  Add the solution to source control.<br />4.  Check out the file.|File is checked out silently (no UI).|
|Silent checkout for a project|1.  Set **Tools**, **Options**, **Source Control** to **checkout files automatically on edit**.<br />2.  Create a new project.<br />3.  Add the solution to source control.<br />4.  Check out the project.|File is checked out silently (no UI).|

### Case 3e: Undo Check Out
 **Undo Check Out** is used to cancel a file's checked out status and avoid checking in changes made to the file.

#### Expected Behavior

- The default is based upon the user's **Check out Local Version** setting. If the user has chosen to check out local version, then the default for undo checkout is to always revert to the version checked out.

- Upon acceptance of the undo, the icons in **Solution Explorer** are updated for affected files and the item is removed from the **Pending Checkins** window.

|Action|Test Steps|Expected Results to Verify|
|------------|----------------|--------------------------------|
|Undo Checkout of a single file that is checked out Exclusively|1.  Create a client project.<br />2.  Add the solution to source control.<br />3.  Check out a file exclusively.<br />4.  Modify the file.<br />5.  Undo Checkout (**File**, **Source Control**, **Undo Checkout**).|Common Expected Behavior.|
|Undo Checkout of a single file that is checked out Shared|1.  Create a client project.<br />2.  Add the solution to source control.<br />3.  Check out a file shared.<br />4.  Modify the file.<br />5.  Undo Checkout (**File**, **Source Control**, **Undo Checkout**).|Common Expected Behavior.|
|Undo Checkout of a project after adding file(s) to the project|1.  Create a new project and add it to source control.<br />2.  Check out the project.<br />3.  Add a file to the project.<br />4.  Undo Checkout of the project.|Added file is removed from the project in Solution Explorer.<br /><br /> Project is no longer checked out.|
|Undo Checkout of a project after deleting file(s) from the project|1.  Create a new project and add it to source control.<br />2.  Check out the project.<br />3.  Delete a file from the project.<br />4.  Undo Checkout of the project.|Deleted file appears under the project in Solution Explorer.<br /><br /> Project is no longer checked out.|

## Related content
- [Test Guide for Source Control Plug-ins](../../extensibility/internals/test-guide-for-source-control-plug-ins.md)
