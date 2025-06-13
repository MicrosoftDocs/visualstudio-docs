---
title: 'Test Area 1: Add To-Open From Source Control'
description: This source-control plug-in test area covers placing solutions or projects under source control and retrieving them from source control.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- source control [Visual Studio SDK], adding and opening solutions
- source control plug-ins, adding and opening solutions
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Test Area 1: Add To/Open From Source Control

This source-control plug-in test area covers placing solutions or projects under source control and retrieving them from source control.

## Command Menu Access
 The following Visual Studio integrated development environment menu paths are used in the test cases:

- For Visual SourceSafe, open from source control: **File**, **Open**, **Project**/**Solution**; look in the Visual SourceSafe location.

- For other source control plug-ins, open from source control: **File**, **Source Control**, **Open from Source Control**.

- Add to source control: **File**, **Source Control**, **Add Solution to Source Control File**, **Source Control**, **Add Selected Projects to Source Control**.

- Shortcut Menu (Project/Solution), **Add Solution to Source Control**.

- Add from source control: **File**, **Source Control**, **Add Project from Source Control**.

- For Visual SourceSafe, add from source control is also available from **File**, **Add**, **Existing Project**; look in the Visual SourceSafe location.

  > [!NOTE]
  > A path of a local file or a local IIS (web server) can be used in this test.

## Expected Behavior

- For each supported project type, a user should be able to "Add to" and "Open from" Source Control.

- When a project is added to Source Control, a corresponding \<*ProjectName*>.vspscc file (Project hint file) is created. It contains exclusion file list and connection information. Do not delete this file because it contains information specific to the project.

- When a solution is added to source control, a corresponding \<*SolutionName*>.vssscc (triple S) file is created. The text file contains connection information and an exclusion file list, similar to the project hint file. This file is temporary and exists only in the source control database.

- When a solution is opened from source control, a \<*SolutionName*>.vsscc (double S) file that exists only in the source control database, is created locally in a temporary file. This file contains the path from the solution connection folder to the solution file. This file is temporary and the local copy is deleted when the "Open from Source Control" operation has completed.

- After a project is added to the source control, you can perform any source control actions on it (Check out, Get, and so on).

## Test Cases
 The following are specific test cases for the Add To/Open From Source Control test area.

### Case 1a: Add Solution to Source Control
 This test case focuses on adding solutions to source control.

|Action|Test Steps|Expected Results to Verify|
|------------|----------------|--------------------------------|
|Add solution containing a client project to source control|1.  Create a client project.<br />2.  Add the solution to source control (**File**, **Source Control**, **Add Solution to Source Control**).|Solution/Project was added to source control.|
|Add solution containing a File System or local IIS Web project to source control|1.  Create a File System or local IIS Web project (use Browse button to point to the project's location; the path determines what type of Web project is created).<br />2.  Add the solution to source control (**File**, **Source Control**, **Add Solution to Source Control**).|Solution/Project was added to source control.|
|Add solution containing a Remote Site Web project to source control|1.  Create a Remote Site Web project.<br />2.  Add the solution to source control (**File**, **Source Control**, **Add Solution to Source Control**).<br />3.  Click **OK** in FrontPage Access warning dialog box.|Solution was added to source control.<br /><br /> Remote Site project is NOT under source control. (Remote Site projects must be controlled from their own IIS server.)|
|Add a single project solution to source control using **Add Selected Projects to Source Control**.|1.  Create a single project solution.<br />2.  Add only solution to source control as a selection (**File**, **Source Control**, **Add Selected Projects to Source Control**). If this step succeeds, continue to next step.<br />3.  Add project to source control as selection (**File**, **Source Control**, **Add Selected Projects to Source Control**).<br />4.  Click **Yes** to add the project to the same location.<br />5.  Click **Check Out** in **Check Out For Edit** dialog box.|`Result from Step 2:`<br /><br /> The project and all files within the project have a checked out source control indicator, and a ToolTip displays "Not under source control".<br /><br /> `Result from Step 5:`<br /><br /> Project and solution file are in the same folder in source control.|
|Cancel adding a solution to source control|1.  Create a single project solution.<br />2.  Attempt to add project and solution to source control. If this step succeeds, continue to next step.<br />3.  Cancel after you are in source control system.|`Result from Step 2:`<br /><br /> The Set project location source control dialog box appears only once.<br /><br /> `Result from Step 3:`<br /><br /> Project add canceled, project/solution is NOT under source control and all Add to source control menus still available.|

### Case 1b. Open Solution from Source Control
 This test case focuses on opening solutions from source control.

|Action|Test Steps|Expected Results to Verify|
|------------|----------------|--------------------------------|
|Open a solution containing a client project from source control|1.  Create a client project.<br />2.  Add the solution to source control.<br />3.  Close the solution.<br />4.  Open the solution from source control to a new location.|Solution/Project opened from source control.|
|Open a solution containing a local or IIS Web project from source control|1.  Create a local or IIS Web project.<br />2.  Add the solution to source control.<br />3.  Close the solution.<br />4.  Open the solution from source control to a new location.|Solution/Project opened from source control.|
|Open a solution containing a Remote Site Web project from source control|1.  Create a Remote Site Web project.<br />2.  Add the solution to source control. If this step succeeds, continue to next step.<br />3.  Close the solution.<br />4.  Open the solution from source control to a new location.|`Result from Step 2:`<br /><br /> Remote Site Web is NOT under source control.<br /><br /> `Result from Step 4:`<br /><br /> Solution opened from source control.<br /><br /> Remote Site project is loaded, but it is NOT under source control.|

### Case 1c: Add Solution from Source Control
 This test case focuses on adding solutions from source control.

|Action|Test Steps|Expected Results to Verify|
|------------|----------------|--------------------------------|
|Add to Empty solution — a single project solution|1.  Create a single project solution.<br />2.  Add the solution to source control.<br />3.  Close the solution.<br />4.  Create a second empty solution.<br />5.  Add the previously controlled solution from source control (**File**, **Source Control**, **Add Project from Source Control**).|The added project appears in **Solution Explorer** and is checked in.|
|Add to solution with single project — single project|1.  Create a solution with a single project.<br />2.  Add the solution to source control.<br />3.  Close the solution.<br />4.  Create a second empty solution.<br />5.  Add the previously controlled solution from source control (**File**, **Source Control**, **Add Project from Source Control**).|The added project appears in **Solution Explorer** and is checked in.|
|Add to solution — solution added to source control by selection|1.  Create a solution with a project.<br />2.  Add only solution to source control as selection. If this step succeeds, continue to next step.<br />3.  Close the solution.<br />4.  Create a new solution.<br />5.  Add the previously controlled solution from source control (**File**, **Source Control**, **Add Project from Source Control**).|`Result from Step 2:`<br /><br /> Project is not under source control.<br /><br /> `Result from Step 5:`<br /><br /> If the first solution had solution items, they cannot be added from source control, so they do not appear.<br /><br /> Project from first solution appears as unavailable.|

## Related content
- [Test Guide for Source Control Plug-ins](../../extensibility/internals/test-guide-for-source-control-plug-ins.md)
