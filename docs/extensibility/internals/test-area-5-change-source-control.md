---
title: 'Test Area 5: Change Source Control'
description: Use this source-control plug-in test to change the source control by using the Change Source Control command in Visual Studio.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- source control [Visual Studio SDK], changing
- source control plug-ins, changing source control
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Test Area 5: Change Source Control

This source-control plug-in test area covers changing the source control via the **Change Source Control** command.

 **Change Source Control** command provides four basic functions for the user:

- **Bind:**

   Allows a user to establish or reestablish a source control link between a solution/project and the version store.

- **Unbind:**

   Removes a project/solution from source control on a per-connection basis.

- **Connect/Disconnect:**

  Toggles connected or offline state of the controlled solution, which is covered in Area 3. For more information, see [Test Area 3: Check Out/Undo Checkout](../../extensibility/internals/test-area-3-check-out-undo-checkout.md).

## Command Menu Access
 The following Visual Studio integrated development environment menu path is used in the test cases.

 Change Source Control:**File**, **Source Control**, **Change Source Control**.

## Test Cases
 The following are specific test cases for the **Change Source Control** command test area.

### Case 5a: Bind
 Bind allows the user to add source code control info to the selected projects and solutions. The user is typically prompted to identify a project in source control to which these are to be added. The user may not create a new project in source control as part of this operation (contrast with Add to Source Control).

| Action | Test Steps | Expected Results to Verify |
| - | - | - |
| Bind to empty location | 1.  Create a project.<br />2.  Add the solution to source control.<br />3.  Open **Change Source Control** dialog box (**File**, **Source Control**, **Change Source Control**).<br />4.  Click **Unbind**.<br />5.  Accept warning dialog box if it appears.<br />6.  Select all items.<br />7.  Click **Bind**.<br />8.  Browse to an empty location in a source control store.<br />9. Click **OK** to close the **Change Source Control** dialog box.<br />10. Click **Continue with these bindings** in confirmation dialog box.<br />11. Click **OK** in the warning dialog box if it appears.<br />12. Check in everything. If this step succeeds, continue to next step.<br />13. Open solution from source control to a new location. | `Result from Step 12:`<br /><br /> Solution and project are bound to and written to the new target in the version store.<br /><br /> Solution and project files are checked in.<br /><br /> Version store project hierarchy matches folder hierarchy of the project on disk.<br /><br /> `Result from Step 13:`<br /><br /> All project items are downloaded. |
| Bind to location that is in sync with client | 1.  Create a project.<br />2.  Add the solution to source control.<br />3.  Create a duplicate of the solution and project in the version store (Share and Branch if using Visual SourceSafe).<br />4.  Open **Change Source Control** dialog box (**File**, **Source Control**, **Change Source Control**).<br />5.  Unbind All.<br />6.  Click **OK** to close **Change Source Control** dialog box.<br />7.  Reopen **Change Source Control** dialog box.<br />8.  Select all.<br />9. Click **Bind**.<br />10. Browse to the branched location of the solution and project (from step 3)<br />11. Click **OK** to close the **Change Source Control** dialog box.<br />12. Get Latest recursively for all items. | File content after the get is the same as before the get. |
| Bind to location that is out of sync with client | 1.  Create a project.<br />2.  Add the solution to source control.<br />3.  Create a duplicate of the solution and project in the version store (Share and Branch if using Visual SourceSafe).<br />4.  Modify files in the branched project in the version store.<br />5.  Open **Change Source Control** dialog box (**File**, **Source Control**, **Change Source Control**).<br />6.  Unbind all.<br />7.  Click **OK** to close **Change Source Control** dialog box.<br />8.  Reopen **Change Source Control** dialog box.<br />9. Select all.<br />10. Click **Bind**.<br />11. Browse to branched location for solution and project.<br />12. Click **OK** to close the **Change Source Control** dialog box.<br />13. Accept Warning dialog box if it appears.<br />14. Get Latest recursive for all items. | Files that were modified in Step 4 are also modified locally. |
| Bind solution that was never under source control | 1.  Create an empty folder in source control.<br />2.  Create a client project.<br />3.  Open **Change Source Control** dialog box (**File**, **Source Control**, **Change Source Control**).<br />4.  Bind the solution to empty location in source control.<br />5.  Click **OK** to close the **Change Source Control** dialog box.<br />6.  Click **Continue with these bindings** in confirmation dialog box.<br />7.  Click **OK** in the warning dialog box if it appears. | Solution is added to source control.<br /><br /> Solution and project are checked out. |
| Cancel Bind | 1.  Create a project.<br />2.  Add the solution to source control.<br />3.  Open the Change Source Control dialog box.<br />4.  Unbind All.<br />5.  Click **OK** button to close the dialog box. If this step succeeds, continue to next step.<br />6.  Reopen the **Change Source Control** dialog box.<br />7.  Bind to unrelated location.<br />8.  Click **Cancel**. | `Result from Step 5:`<br /><br /> The solution is no longer under source control<br /><br /> `Result from Step 8:`<br /><br /> Solution is still NOT under source control. |

### Case 5b: Unbind
 Unbind removes source code control info from projects and their solution. The affected projects and solution are based on a mix of user selection and how the items were added to source control.

|Action|Test Steps|Expected Results to Verify|
|------------|----------------|--------------------------------|
|Unbind solution containing one File System or local IIS Web project and one client project|1.  Create a File System or local IIS Web project.<br />2.  Add the solution to source control.<br />3.  Add a new client project to the solution.<br />4.  Accept Check Out of the solution if prompted.<br />5.  Open the **Change Source Control** dialog box.<br />6.  Click **Unbind**.<br />7.  Click **OK** to close the dialog box.<br />8.  Attempt to check out solution, project, solution items, project items.|Solution and projects are NOT under source control.<br /><br /> Source Control menu commands do not appear.|
|Cancel Unbind|1.  Create a project.<br />2.  Add the solution to source control.<br />3.  Open the **Change Source Control** dialog box.<br />4.  Click **Unbind all**.<br />5.  Click **Cancel**.|Solution is under source control.|

### Case 5c: Rebind
 Rebind is simply a combination of unbind and bind—the process of rebinding a project/solution that was previously under source control and was unbound.

|Action|Test Steps|Expected Results to Verify|
|------------|----------------|--------------------------------|
|Rebind solution and projects without closing the **Change Source Control** dialog box|1.  Create a project.<br />2.  Add the solution to source control.<br />3.  Open the **Change Source Control** dialog box.<br />4.  Click **Unbind**.<br />5.  Select all rows.<br />6.  Click **Bind**.<br />7.  Click **OK** to close the **Change Source Control** dialog box.<br />8.  Accept checkout if prompted.|Solution and project are under source control.|
|Rebind project only without closing **Change Source Control** dialog box|1.  Create a project.<br />2.  Add only the project to source control using (File->Source Control->Add Selected Projects to Source Control.<br />3.  Open the Change Source Control dialog box.<br />4.  Unbind only the project.<br />5.  Bind only the project.|Solution remains uncontrolled.<br /><br /> Project remains controlled.|
|Rebind solution only without closing **Change Source Control** dialog box|1.  Create a project.<br />2.  Add only the solution to source control using (**File**, **Source Control**, **Add Selected Projects to Source Control**.<br />3.  Open the **Change Source Control** dialog box.<br />4.  Unbind only the solution (Do not close **Change Source Control** dialog box.)<br />5.  Bind only the solution.<br />6.  Click **OK** to close the dialog box.<br />7.  Check out solution and solution items (if any.)|Solution remains controlled.<br /><br /> Project remains uncontrolled.|
|Rebind solution/project only when in same directory|1.  Create a project.<br />2.  Add only the project to source control using (**File**, **Source Control**, **Add Selected Projects to Source Control**.<br />3.  Close the solution.<br />4.  Create a new solution with at least two projects.<br />5.  Add the solution to source control.<br />6.  Add the project created in Step 1 from source control.<br />7.  Accept the checkout of the solution if prompted.<br />8.  Check in the entire solution.<br />9. Open the **Change Source Control** dialog box.<br />10. Select the added project (from Step 6) and click **Unbind**.<br />11. Click **OK** to close the dialog box.<br />12. Accept the checkout if prompted.<br />13. Reopen **Change Source Control** dialog box.<br />14. Select the added project (from Step 6) and click **Bind**.<br />15. Select the original location.|Solution and projects remain controlled.|

## Related content
- [Test Guide for Source Control Plug-ins](../../extensibility/internals/test-guide-for-source-control-plug-ins.md)
