---
title: 'Test Area 7: Share'
description: This source control test area covers sharing items between locations by using the Share command for your Visual Studio source control plug-in.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- source control [Visual Studio SDK], sharing items
- source control plug-ins, sharing items
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Test Area 7: Share

This test area covers sharing items between locations via the **Share** command.

 A share operation is the apparent duplication of files and folder items between two or more locations within a source control file hierarchy. Duplication does not really occur on the server, but the user does see the same file in two or more specified locations. Whenever changes are made to any of the shared items, those changes appear in all other shared locations.

 Sharing into folders works if you select a folder with at least one file under source control in it. The share command is disabled under the following conditions:

- If the selected folder is an empty folder.

- If there is a real folder, but it contains no source control files.

- If there is a virtual folder, whether files under source control are in it or not.

- If there is a Remote Site Web project.

## Command Menu Access
 The following Visual Studio integrated development environment menu paths are used in the test cases.

 Share: **File**->**Source Control**->**Share**.

## Expected Behavior

- Shared file appears in shared location.

- Viewing the source control version store history shows that file(s) are shared.

- Editing a shared file edits both locations of the file.

## Test Cases
 The following are specific test cases for the Share test area.

|Action|Test Steps|Expected Results to Verify|
|------------|----------------|--------------------------------|
|Share a file from one loaded project under source control to another loaded project|1.  Create a new project.<br />2.  Add a second project to the solution.<br />3.  Create a file in the second project with a name that is not in first project.<br />4.  Add the solution to source control.<br />5.  Select the first project.<br />6.  Open **Share** dialog box (**File** -> **Source Control** -> **Share**).<br />7.  Share the file from the second project to the first project.<br />8.  Accept **Check Out** if prompted.|Common Expected Behavior.|
|Share a file from one project to another|1.  Create a new project.<br />2.  Add it to source control.<br />3.  Close the solution.<br />4.  Create a second project (new solution.)<br />5.  Add the solution to source control.<br />6.  Select the project.<br />7.  Open the **Share** dialog box (**File** -> **Source Control** -> **Share**).<br />8.  Share a file from the previously added project to the open project.<br />9. Accept **Check Out** if prompted.|Common Expected Behavior.|
|Share a file not part of project from source control into the currently loaded project|1.  Create a new project.<br />2.  Add the solution to source control.<br />3.  Add a file to source control that is not part of the project or solution.<br />4.  Select the project and open the **Share** dialog box (**File** -> **Source Control** -> **Share**).<br />5.  Select a file within the **Share** dialog box that does not exist within the current project or solution and share it.<br />6.  Accept **Check Out** if prompted.|The source control store has performed a Get, so the file is now at the local location of the project.|
|Share files within the same project to a different folder|1.  Select **Check out automatically** in **Tools** -> **Options** -> **Source Control**.<br />2.  Create a new project and add it to source control.<br />3.  Add a folder to the project.<br />4.  Add a file to the folder and check in the folder.<br />5.  Select the folder.<br />6.  Open **Share** dialog box (**File** -> **Source Control** -> **Share**).<br />7.  Share file to the selected folder.|Common Expected Behavior.<br /><br /> Folder must be checked in with a file in it before it can be used for share.|
|Share a folder into the loaded Project — Recursive|1.  Create a new project.<br />2.  Add the solution to source control.<br />3.  Select the project.<br />4.  Open the **Share** dialog box (**File** -> **Source Control** -> **Share**).<br />5.  Select a folder.<br />6.  Share the folder recursively into the project.|Common Expected Behavior.|
|Share several files from one project to another|1.  Create a new project with several files in it.<br />2.  Add the solution to source control.<br />3.  Close the solution.<br />4.  Create a new project in a new solution.<br />5.  Add the solution to source control.<br />6.  Select the project.<br />7.  Open the **Share** dialog box (**File** -> **Source Control** -> **Share**).<br />8.  Share several files from the previously created project to the currently open project.|Common Expected Behavior.|

## Related content
- [Test Guide for Source Control Plug-ins](../../extensibility/internals/test-guide-for-source-control-plug-ins.md)
