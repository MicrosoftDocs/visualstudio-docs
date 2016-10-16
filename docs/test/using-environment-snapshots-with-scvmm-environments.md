---
title: "Using Environment Snapshots with SCVMM Environments"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: f7e0f56b-1b37-4fde-abf4-e9b588c403e9
caps.latest.revision: 17
ms.author: "ahomer"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Using Environment Snapshots with SCVMM Environments
> [!NOTE]
>  This is about *snapshots* of the memory and state of a [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] environment. If you’re looking for screen snapshots that you make while testing, try [Run manual tests with Microsoft Test Manager](../test/run-manual-tests-with-microsoft-test-manager.md).  
  
 A snapshot of an environment is a file-based copy of the state, disk data, and configuration of all virtual machines in an environment at a specific point in time.  
  
 You typically take snapshots while you’re [testing in a lab environment](../test/test-on-a-lab-environment.md), either when you’ve set up a clean environment that you’ll want to go back to, or to capture the state when you found a bug.  
  
 After you take a snapshot, you can continue to work in the environment, taking more snapshots as needed. You can then restore the environment to a previous state. You can also create a link file to a snapshot that enables other members of your team to connect to or re-create the snapshot. You can also save a copy of the environment and its snapshots to the team project library. When you save an environment to the team project library, both the environment and the snapshots are saved in the team project library.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
 This topic contains the following sections:  
  
 [Creating Snapshots of an Environment](#SnapshotCreate)  
  
 [Restoring an Environment From a Snapshot](#SnapshotRestore)  
  
 [Sharing a Snapshot of an Environment](#SnapshotShare)  
  
 [Storing an Environment With Snapshots in the Library](#SnapshotLibraryStore)  
  
 [Deleting a Snapshot of an Environment](#SnapshotDelete)  
  
##  <a name="SnapshotCreate"></a> Creating Snapshots of an Environment  
 ![Steps to take snapshot](../test/media/takesnapshot.png "TakeSnapshot")  
  
 Snapshots are stored on the Hyper-V hosts of the team project. If a snapshot is frequently used a long time after it was created, you must take steps to make the environment usable for long periods of time.  
  
#### To prepare for a snapshot  
  
1.  Make sure that the virtual machines in the environment have the latest updates for their operating systems.  
  
2.  If any virtual machine in the environment is connected to a domain, open a command prompt and run the command **gpupdate /force**. This command makes sure that any changes to user policies are updated on the virtual machine. If you do not run this command, your deployment scripts might not work correctly or your tests might not run correctly.  
  
    > [!NOTE]
    >  If one or more of the virtual machines in this snapshot are joined to a domain and the snapshot is used for longer than the machine password expiry period, the virtual machines might be unable to join the domain again when the snapshot is restored. One way to avoid this problem is to disable or change the machine password renewal frequency. For more information about password renewal and the security implications for changing or disabling the renewal, see [Machine Account Password Process](http://go.microsoft.com/fwlink/?LinkId=182419).  
  
3.  Make sure that the state of the environment is **Running**.  
  
4.  If you have enabled workflows, make sure that the state of the workflow capability is **Ready** and that the environment is **Running**.  
  
5.  (Optional) If you want to run tests on the restored snapshot, make sure that the testing capability is **Ready**.  
  
    > [!NOTE]
    >  You should take snapshots only when there are no transactions in progress between the virtual machines within the environment or between the virtual machines inside the environment and machines outside the environment. If there are TCP connections between machines at the time that the snapshot is taken, these connections might break when the machines are stopped to take the snapshot. When the snapshot is restored, the old, active connections will have timed out and will no longer be valid. After the snapshot is restored, the TCP connections are reestablished. You cannot always resume the environment exactly from the point the snapshot is taken.  
  
6.  If the build definition for your workflow reverts to a specific snapshot, the virtual machine cannot be locked when you try to run the tests. You must connect to the machine by using a host based connection or by using a console session before you take the snapshot to use for your workflow. For more information about this, see [How to: Connect to machines in a Lab Environment](../test/how-to--connect-to-machines-in-a-lab-environment.md).  
  
 You use the [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] **Environment Viewer** to connect to the environment and take the snapshot.  
  
#### To create a snapshot  
  
1.  In [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], connect to the environment. In the **Lab Center**, on the **Lab** tab, select the environment, and then choose **Connect**.  
  
2.  In **Microsoft Environment Viewer**, choose the **Snapshots** tab.  
  
3.  Choose **Take snapshot**.  
  
4.  In the **Snapshot environment** dialog box, type a name for the snapshot, and then choose **Take snapshot**.  
  
     After the snapshot is completed, you can see the snapshot name in the left pane.  
  
##  <a name="SnapshotRestore"></a> Restoring an Environment From a Snapshot  
 When you restore an SCVMM environment from a snapshot, you return the virtual machines in the environment to the exact states that they were in at the time that the snapshot was taken. You can restore an environment to a snapshot that was created before or after the current state of the environment. For example, you can take two snapshots of an environment, one on Monday and one on Tuesday. On Wednesday, you might restore the environment to the snapshot from Monday. Later, you might restore the same environment to the snapshot from Tuesday.  
  
#### To restore an SCVMM environment to a snapshot  
  
1.  In [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], open the **Lab Center**, an then choose the **Lab** tab.  
  
2.  Choose the environment, and then choose **Connect**.  
  
3.  In **Microsoft Environment Viewer**, choose the **Snapshots** tab.  
  
4.  In the list of snapshots, select the snapshot that you want to restore, and then choose **Restore to selected snapshot** on the **Snapshot** toolbar.  
  
5.  If it is necessary, choose the **Machines** tab, select any disconnected machines, and then choose **Reconnect**.  
  
> [!NOTE]
>  If the status of the environment changes to **Not Ready**, investigate any error messages. Certain settings are not fully restored by restoring a snapshot, because they are stored outside the virtual machines. For example, if you have changed the **Configure for UI Tests** setting since you took the snapshot, the change will not be undone by restoring the snapshot. You should **Open** the environment definition and restore the old setting manually. Alternatively, you can use **Repair** to change the restored environment to the new setting.  
  
##  <a name="SnapshotShare"></a> Sharing a Snapshot of an Environment  
 You can create a link to a snapshot of an environment that you can share with other people. The link (.lvr) file can be opened on any computer on which [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] is installed by any user who has permissions to operate an environment in the team project.  
  
#### To create a link to a SCVMM environment snapshot  
  
1.  In [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], in the **Lab Center**, on the **Lab** tab, make sure that the environment is **Running**.  
  
2.  Choose the environment, and then choose **Connect**.  
  
3.  In **Microsoft Environment Viewer**, choose the **Snapshots** tab.  
  
4.  In the list of snapshots, select the snapshot that you want to link to, and then choose **Share snapshot** on the **Snapshot** toolbar.  
  
5.  Specify a file name for the link (.lvr) file.  
  
6.  You can attach the link file to an e-mail, or place it on a shared directory.  
  
#### To connect to a snapshot from a snapshot link file  
  
1.  Double-click the snapshot link (.lvr) file.  
  
     The Connect to environment dialog box is displayed. Select one of the following options:  
  
    |||  
    |-|-|  
    |**Connect to the snapshot in this environment**|Restores the exact state of the SCVMM environment at which the snapshot was taken. **Note:**  If you select this option, you might disconnect any user who is currently using this environment and this could lead to loss of their work. A warning message is displayed if the environment is in use.|  
    |**Connect to the environment in its current state**|Connects to the environment in its current state and does not revert to the snapshot that was selected when the link file was created. **Note:**  You might still disconnect another user who is connected to this environment. However, you will not change the state of the environment.|  
    |**Connect to a new instance of this environment**|Available only if a copy of the environment in stored the team project library. Creates a copy of the environment on a team project host group and connects to that copy.<br /><br /> You might want to create a copy if the environment is currently in use, or if you do not want to prevent other people from using the environment. **Note:**  Creating a copy can take a long time and can also use significant disk space on the team project library. If multiple copies of the environment are to be run at the same time, the original environment must use network isolation. For more information, see [Creating and using a network isolated environment](../test/creating-and-using-a-network-isolated-environment.md).|  
  
2.  Choose **Connect** to open the environment in **Environment Viewer**.  
  
> [!NOTE]
>  When you restore an environment to a snapshot, the network connections between the machines in the snapshot might stop working for a brief amount of time and any transactions that were in process at the time that the snapshot was taken might fail.  
  
##  <a name="SnapshotLibraryStore"></a> Storing an Environment with Snapshots in the Library  
 Before you can store an environment, the environment must be in the **Stopped** state. You cannot store an environment that is in the **Running** state.  
  
 If you store an environment and do not plan to delete the original active environment immediately, we recommend that you turn on the network isolation capability of the stored environment. This lets another user to deploy a copy of the stored environment. For the steps to turn on the network isolation capability, see [Creating and using a network isolated environment](../test/creating-and-using-a-network-isolated-environment.md).  
  
#### To store the environment in the Library  
  
1.  In [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], in the **Lab Center**, on the **Lab** tab, make sure that the environment is **Stopped**.  
  
2.  Choose the environment that you want to save.  
  
3.  Choose **Store in library**.  
  
4.  In the **Store in library** dialog box, type the **Environment name** and **Description** of the saved environment.  
  
5.  Select the **Project library share** from the drop-down list, and then choose **Store**.  
  
     A progress bar is displayed during the creation process. You can also view the current creation step for each virtual machine. When the process is finished, the stored environment appears in the list of **Environments** on the **Library** tab.  
  
##  <a name="SnapshotDelete"></a> Deleting a Snapshot From an Environment  
 It is easy to accumulate snapshots of an environment. Storing a snapshot requires a significant amount space on the host group. A best practice occasionally reviews the list of snapshots to determine whether there are any that are no longer needed and can be deleted.  
  
#### To delete a snapshot  
  
1.  In [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], in the **Lab Center**, on the **Lab** tab, make sure that the environment is started.  
  
2.  Choose the SCVMM environment, and then choose **Connect**.  
  
3.  In **Microsoft Environment Viewer**, choose the **Snapshots** tab.  
  
4.  Select the snapshot to delete, and then choose **Delete snapshot**.  
  
5.  In the confirmation dialog box, choose **Delete snapshot**.  
  
## See Also  
 [Creating Lab Environments](../test/creating-lab-environments.md)   
 [Test on a lab environment](../test/test-on-a-lab-environment.md)