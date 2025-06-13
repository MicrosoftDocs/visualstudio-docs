---
title: 'Test Area 6: Delete'
description: This source control test area covers delete actions in Solution Explorer for your Visual Studio source control plug-in.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- source control [Visual Studio SDK], deleting items
- source control plug-ins, deleting items
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Test Area 6: Delete

This source-control plug-in test area covers delete actions.

 Source control responds to delete actions in **Solution Explorer**.

 Following is a list of items that can be deleted:

- Files

- Folders

- Project

  Depending on the project type, you might have the option to **Remove** the project (leaves the files on disk) or **Delete** the project (removes the files on disk). Either action removes the project or item from **Solution Explorer**.

## Expected Behavior
 The expected behavior for the test cases in the delete test area is:

- Deleted item is no longer visible within **Solution Explorer**.

- The parent of the deleted project or item is checked out as needed (possibly with a prompt.)

- After you delete a checked out or added item, it does NOT appear in the **Pending Checkins** window.

- The item still exists within the source control store, even after the deletion, and must be manually purged.

|Action|Test Steps|Expected Results to Verify|
|------------|----------------|--------------------------------|
|Delete a client project|1.  Create a client project.<br />2.  Add the solution to source control.<br />3.  Remove the entire project from solution|Common Expected Behavior.|
|Delete an empty file|1.  Create a client project.<br />2.  Add a zero byte file to the project.<br />3.  Add the solution to source control.<br />4.  Select the file, delete it.|Common Expected Behavior.|
|Delete a folder with one file|1.  Create single project solution.<br />2.  Add a folder.<br />3.  Add one file to the folder.<br />4.  Add the solution to source control.<br />5.  Check out the project to avoid prompts.<br />6.  Delete the folder.|Common Expected Behavior.|
|Delete a File System Web project|1.  Create a File System Web project (use the Browse button to specify a UNC path).<br />2.  Add the solution to source control.<br />3.  Remove the entire project from the solution.<br />4.  Repeat steps 1 through 3 for a local Web project (exercises different paths through the code but has the same external interface and behavior).|Common Expected Behavior.|
|Delete a file from a File System Web project|1.  Create a File System Web project.<br />2.  Add the solution to source control.<br />3.  Delete a file from the project.<br />4.  Repeat steps 1 through 3 for a local Web project (exercises different paths through the code but has the same external interface and behavior).|Common Expected Behavior.|

## Related content
- [Test Guide for Source Control Plug-ins](../../extensibility/internals/test-guide-for-source-control-plug-ins.md)
