---
title: "Expand or change your virtual lab"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8d903c83-df24-4776-adf6-48bd2115d659
caps.latest.revision: 44
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Expand or change your virtual lab
As you use and become familiar with a virtual lab, you might want to either expand or change your lab in one or more ways:  
  
-   [Move Team Foundation Server from One Server to Another](#BKMK_MoveTeamFoundationServerfromOneServertoAnother)  
  
     You might have to change or replace the server that is running the Team Foundation Server application-tier.  
  
-   [Move a Team Project Collection from One Team Foundation Server to Another](#BKMK_MoveaTeamProjectCollectionfromOneTeamFoundationServertoAnother)  
  
     You might want to reuse the machines and other resources in your initial team project and move those resources.  
  
-   [Add a New Library Server and Retire an Old Library Server](#BKMK_AddaNewLibraryServerandRetireanOldLibraryServer)  
  
     You might find you need more space to store virtual machines, templates, and environments. You can add more library shares or replace existing library shares with ones on larger SCVMM library servers.  
  
-   [Add a New Hyper-V Host and Retire an Old Hyper-V Host](#BKMK_AddaNewHyper-VHostandRetireanOldHyper-VHost)  
  
     You might find you need more space to run virtual machines and environments. You can add more physical hosts to existing host groups to transparently add more capacity.  
  
-   [Move System Center Virtual Machine Manager from One Server to Another](#BKMK_MoveSystemCenterVirtualMachineManagerfromOneServertoAnother)  
  
     You might have to change or replace the server that is running SCVMM.  
  
-   [Move a Test Controller](#BKMK_MoveaTestController)  
  
     You might have to move or replace the machine that is running the test controller.  
  
 Each of these changes requires some modification to the configuration of Lab Management resources.  
  
##  <a name="BKMK_MoveTeamFoundationServerfromOneServertoAnother"></a> Move Team Foundation Server from One Server to Another  
 If you move Team Foundation Server from one server to another, or otherwise change the name of the server that is running Team Foundation Server, you must update the URL that the Lab Management components use to communicate with Team Foundation Server. For more information about how to move Team Foundation Server, see [Administer](../Topic/Administer%20Team%20Foundation%20Server.md).  
  
 After you have finished moving Team Foundation Server, update the Team Foundation Server URL in the following locations:  
  
-   On the machine that is running the Team Foundation Server application-tier, the URL appears in the Team Foundation Server Administration Console. In the Administration Console, go to the **Lab Management** node, click **Reconfigure Lab Management**, and then click the **Advanced** tab.  In the **Lab URL** text box, type the new server name.  
  
-   On machines where a build agent is installed, the URL is stored in the Hyper-V-managed registry hive. If the server that is running Team Foundation Server is renamed, click **Repair Workflow Capability** for this environment. The setting will be updated automatically in all the virtual machines of this environment. Because .lvr files store the URL of Team Foundation Server internally, you must modify the .lvr file manually to update the XML.  
  
    > [!NOTE]
    >  You do not have to revert snapshots, because the URL is updated in the virtual machines by Team Foundation Server after it reverts to a snapshot.  
  
##  <a name="BKMK_MoveaTeamProjectCollectionfromOneTeamFoundationServertoAnother"></a> Move a Team Project Collection from One Team Foundation Server to Another  
 If you started to explore Lab Management by using composed environments or by creating a small team project to pilot test Team Foundation Server, you might want to migrate the lab assets to a different Team Foundation Server instance later. Because Team Foundation Server does not support merging one team project with another, you must move your lab resources manually. For more information about how to migrate source code, work items, and build definitions, see [Administer](../Topic/Administer%20Team%20Foundation%20Server.md).  
  
> [!NOTE]
>  You can move virtual machines only within the same network location because they are already configured to use that network location. If you move a team project collection between instances of Team Foundation Server that are located in different domains, you must move the project collection, un-configure Lab Management for that project collection, and then configure it from fresh using the settings of the new Team Foundation Server instance and domain.  
  
 Because you are moving between domains, you cannot recover everything.  
  
#### To move from one server that is running Team Foundation Server to another server that is running Team Foundation Server  
  
1.  Move the team project collection to a new application tier. For the steps see [Move a  team project collection](../Topic/Move%20a%20%20team%20project%20collection.md).  
  
2.  Un-configure Lab Management for the team project collection after attaching the collection to the destination Team Foundation Server. For the steps to un-configure, see [TFSConfig Lab /Delete Command](assetId:///62c85c1d-4230-49f5-9572-ff2cf4c55666).  
  
3.  Reconfigure Lab Management for the collection in the destination Team Foundation Server. For the steps to configure Lab Management, see [Configure Lab Management for SCVMM environments](../dv_TeamTestALM/Configure-Lab-Management-for-SCVMM-environments.md).  
  
##  <a name="BKMK_AddaNewLibraryServerandRetireanOldLibraryServer"></a> Add a New Library Server and Retire an Old Library Server  
 If you must expand the storage for System Center Virtual Machine Manager (SCVMM), you can add new library shares. You can also replace existing shares with shares on servers that have faster processors, more hard disks, or both. The process to add or remove library shares to the SCVMM used by Lab Management is as follows:  
  
1.  Prepare to move to a new library share.  
  
2.  Move the templates.  
  
3.  Move the imported virtual machines that are currently not used in virtual environments.  
  
4.  Move the stored environments.  
  
5.  Remove the old library share.  
  
    > [!NOTE]
    >  This scenario will not update existing .lvr files that may be part of active bugs. If there are stored environments that are required for reproducing bugs, those should remain in the source library until the bugs are resolved.  
  
#### To prepare for the move  
  
1.  Make sure that the new library server meets the system requirements for a SCVMM library server. For more information about the system requirements, see [System Requirements: VMM Library Server](http://go.microsoft.com/fwlink/?LinkId=182572).  
  
2.  On the new server, add a new library share:  
  
    1.  In Windows Explorer, create a new folder that uses the name of the new library share.  
  
    2.  Share the new folder with the SCVMM server by adding VMM_MACHINE$ as a contributor to the list of users this folder is shared with.  
  
    3.  In the Virtual Machine Manager Administrators Console, associate this library share.  
  
3.  Add the new library share to the relevant team project collections and team projects.  
  
    1.  In the **TFS Administration Console**, click **TFS Server**. Click **Application Tier**, and then click **Team Project Collections**.  
  
    2.  On the **Lab Management** tab, click **Configure library shares**.  
  
    3.  Add the share that you create in SCVMM.  
  
4.  Back up the original library share. For the steps to back up the library share, see [Backing Up and Restoring the VMM Database](http://go.microsoft.com/fwlink/?LinkID=150302).  
  
5.  Do one of the following:  
  
     Take the project collections offline. It is recommended, although not required, to take the relevant project collections offline during the move.  
  
     —or—  
  
     Contact your system administrator and ask them to notify all users not to deploy environments or import virtual machines or templates during the time of the move.  
  
#### To move templates  
  
1.  Identify the files that are related to the template that you want to move. Move those files from the source to the destination. In the case of differencing-disk VHDs, make sure that you move all the versions of the .vhd. To find the path of the .vhd that this template points to, right-click the template and then click **Properties**. Click **Hardware Configuration**. Move this .vhd to the new library share.  
  
2.  In the **SCVMM Administrators Console**, click **Library**. In the **Action** pane, click **Refresh**. Refresh both the old library share and the new library share.  
  
3.  In **Microsoft Test Manager**, click **Library**. Point to the new **Library Share**, and re-import the templates. Repeat for each team project that is enabled for Lab Management. Make sure that the OS profile and the hardware profile that you define to the new instance of the template are the same as the one that you used for the old template.  
  
4.  If you have environments in the library that are based on templates, you should update the environment definitions manually. In Microsoft Test Manager, click **Library**. Click **Environments** and then click each environment that used the templates. Remove the old template and add the new template.  
  
5.  Delete the old templates from the library. In Microsoft Test Manager, click the **Lab Center**. Click the **Library** tab, and then click **VMs and Templates**.  
  
     You can distinguish between the old and the new templates by looking at the library share column. This does not delete the underlying template.  
  
6.  Confirm the move was successful. If you did not take the team project collection offline, deploy one the templates to a host. It should complete without errors.  
  
 If there are virtual machines in a library that are currently not used in an environment, you must deploy those virtual machines to a host and then save those virtual machines to the new library.  
  
#### To move imported virtual machines  
  
1.  Create a new virtual environment  
  
2.  Add all the virtual machines that must be moved. Do not select any capabilities.  
  
3.  Deploy the environment, but do not start it.  
  
    > [!NOTE]
    >  If you try to start the environment, and there are running virtual machines that are using the same name of the virtual machines you are now moving, name conflicts in the domain might occur.  
  
4.  In **Microsoft Test Manager**, click the first virtual machine in the environment. Click **Store to Library** and then select the target library you want to store to. Repeat for all the virtual machines in the environment.  
  
5.  After all the virtual machines are stored in the library, delete the environment  
  
6.  Delete the virtual machines in the source library.  
  
    > [!NOTE]
    >  After the move, you will not be able to import the virtual machines into other team projects.  
  
#### To move stored environments  
  
1.  In Microsoft Test Manager, deploy the environment.  
  
     You do not have to start the environment.  
  
2.  On the **Environment** tab, click **Store to library** on the destination library share.  
  
3.  Confirm the move was successful:  
  
    1.  Deploy the environment.  
  
    2.  Take a snapshot.  
  
    3.  Revert to an earlier snapshot.  
  
    4.  Revert to the latest snapshot.  
  
4.  If you can successfully revert, delete the environment from the source library share.  
  
 After the move is complete, place the team project collection back online.  
  
 If you have bugs that included snapshots for environments that are in the library, we recommend that you keep the environments in this library until those bugs are resolved. There is no easy way to find which environments has .lvr files pointing to them. Therefore, a practical solution will be to keep environments that were created in the last 60 days.  
  
#### To remove the share  
  
1.  Delete virtual machines and templates from the original library share: In Microsoft Test Manager, click **Lab Center**. Click **Library**, **Virtual Machines and Templates** and then delete the virtual machines in the library share that are still shown at located in the original library share.  
  
     You can easily group the virtual machines by library share, by dragging the **Library Share** column header and dropping it above the header row.  
  
2.  Deleting library share association from team projects:  
  
    1.  Open a command prompt.  
  
         At the command prompt, use the TFSLabConfig command line tool for each project that is associated with the library share that you want to delete.  
  
    2.  Run the command **TFSLabConfig DeleteTeamProjectLibraryShare**, to specify the project collection and project name, in addition to the library share name.  
  
         For more information about the **TFSLabConfig DeleteTeamProjectLibraryShare** command, see [TFSLabConfig DeleteTeamProjectLibraryShare Command](assetId:///4388c79c-98e1-4337-b59c-f9688a599c13).  
  
    3.  Repeat this step for each team project.  
  
3.  In the Team Foundation Server Administration Console, delete the original library share from the team project collections that it was associated with.  
  
##  <a name="BKMK_AddaNewHyper-VHostandRetireanOldHyper-VHost"></a> Add a New Hyper-V Host and Retire an Old Hyper-V Host  
  
#### To add a Hyper-V host  
  
1.  In the SCVMM Administrators Console, add the new Hyper-V server to the host group. For the steps to add a server to the host group, see [Adding Hosts](http://go.microsoft.com/fwlink/?LinkId=182622).  
  
2.  In the **Team Foundation Server Administration Console**, click **TFS Server**. Click **Lab Management** and then click **Host Groups**. Click **Verify**. If you are prompted for a username and password, provide a user who is a member of the Administrators security group on the new host.  
  
3.  Prevent placement of new virtual machines on the host that you are migrating from.  
  
    1.  In the SCVMM Administrators Console, click **Hosts**. Click the name of the host that you are migrating from, and then click **Properties**.  
  
    2.  In the **Host Properties** window, click the **Status** tab. Clear the check box **This host is available for placement**, and then click **OK**.  
  
4.  In the **Host Properties** window, click the **Status** tab. Clear the check box labeled **This host is available for placement** and then click **OK**.  
  
5.  Migrate environments that are not network-isolated:  
  
    1.  In Microsoft Test Manager, click **Lab Center**. Click the **Lab** tab and then click **Environments**. Identify the environments that reside in the host group in which the source and destination hosts are.  
  
    2.  Open each environment and identify which of them have the Network Isolation capability off. The rest of this step applies only to those environments that are not network-isolated.  
  
    3.  In SCVMM Administrators Console, find the virtual machines that are part of the environments that are not network-isolated.  
  
         You can do this by typing the environment name in the search box of the Virtual Machines pane.  
  
    4.  If any of the virtual machines that were found in the previous step reside on the host that is being discontinued, move those virtual machines to the new host.  
  
6.  Migrate environments that are network-isolated:  
  
    1.  In Microsoft Test Manager, click **Lab Center**. Next, click the **Lab** tab and then click **Environments**. Identify the environments that reside in the host group where the source and destination hosts are.  
  
    2.  Open each environment and identify which of them have the **Network isolation** capability on.  
  
    3.  In **SCVMM Administrators Console**, find the virtual machines that are part of network-isolated environments.  
  
         You can do this by typing the environment name in the search box of the Virtual Machines pane.  
  
    4.  If the virtual machines of any network-isolated environment reside on the host being discontinued, store the network-isolated environment in the team project library.  
  
         All virtual machines within a network-isolated environment are located on the same physical host.  
  
    5.  Deploy the environment from the library back to the host group.  
  
7.  In Microsoft Test Manager, pause and then resume each environment. This verifies that the environment was successfully migrated.  
  
8.  In the SCVMM Administrators Console, click **Hosts**, click the name of the old host, and then click **Remove host**.  
  
##  <a name="BKMK_MoveSystemCenterVirtualMachineManagerfromOneServertoAnother"></a> Move System Center Virtual Machine Manager from One Server to Another  
 There are at least two situations in which you might move SCVMM from one server to another. First, you began to use Lab Management on a pilot basis on temporary machines and now want to deploy the functionality to production servers. Because you are starting over in a production mode, it is not important to retain the environments, templates, and other lab assets you had been using during pilot testing. Second, you have to change the server that is running SCVMM because of capacity or availability issues. Because you want to continue operating as before, you have to preserve the same environments and related assets.  
  
#### To move SCVMM without retaining lab assets  
  
1.  Delete the lab objects from each team project collection.  
  
    1.  On the Team Foundation Server application tier, open a command prompt and type the following command **Tfsconfig.exe lab /delete /collectionName:***myCollection*. You must run **TFSConfig** from a server that is running the Team Foundation application tier. By default, **TFSConfig** is located in *Drive*:\Program Files\Microsoft Team Foundation Server 2010\Tools. For more information about the **TfsConfig Lab /Delete** command, see [TFSConfig Lab /Delete Command](assetId:///62c85c1d-4230-49f5-9572-ff2cf4c55666).  
  
    2.  Repeat this command for each team project collection on the server.  
  
2.  Enter the new name in  Team Foundation Server Administration Console.  
  
    1.  In Team Foundation Server Administration Console, click the **Lab Management** node.  
  
    2.  On the **Lab Management** page, click **Reconfigure Lab Management**.  
  
    3.  On the **Virtual Machine Manager** tab, type the fully-qualified domain name of the new server that is running SCVMM. Then click **Test** to confirm that the new server is available.  
  
        1.  If the Team Foundation Server service account does not have the appropriate permissions on the specified SCVMM, a dialog box prompts you for a user name and a password.  
  
        2.  Type the name and the password of a user who is an existing member of the SCVMM Administrator role. The Team Foundation Server service account will be added to the SCVMM Administrator role.  
  
    4.  Click **OK**.  
  
#### To move SCVMM while retaining lab assets  
  
1.  Back up the database of the original SCVMM:  
  
    1.  In the SCVMM Administrators Console, click **Administration** and then click **General**. In the **Actions** pane, click **Back up Virtual Machine Manager**.  
  
    2.  In the **Virtual Machine Manager Backup** dialog box, type the path of a destination folder for the backup file. The folder must not be a root directory and must be accessed by SQL Server.  
  
    > [!NOTE]
    >  You can follow the status of the backup in **Jobs** view.  
  
2.  Copy the database backup files from step 1b to a location on the new SCVMM machine.  
  
3.  Install SCVMM on the new server. Either point the wizard to the current SCVMM database or create a new database. For the steps to restore the backup, see [Backing Up and Restoring the VMM Database](http://go.microsoft.com/fwlink/?LinkID=150302).  
  
4.  Update the SCVMM server name in Team Foundation Server.  
  
    1.  Open a command prompt and run the command: **Tfsconfig.exe lab /settings / scvmmservername:***my_new_scvmmservername* **/force**. You must run **TFSConfig** from a server that is running the Team Foundation application tier. By default, **TFSConfig** is located in *Drive*:\Program Files\Microsoft Team Foundation Server 2010\Tools. You must use the **/force** switch because the library server and host groups are already bound to a team project collection; changing the SCVMM is not allowed unless you use the **/force** option. For more information about the **TFSConfig Lab Settings** command, see [TFSConfig Lab /Settings Commands](assetId:///28149fd2-a111-40f6-968c-3b5a83d2f7bc).  
  
    2.  In the Team Foundation Server Administration Console, click the **Lab Management** node. Click **Reconfigure Lab Management** and then click **Test** near **VMM Server name**. This confirms that Team Foundation Server can connect to the new SCVMM and has the correct permissions.  
  
        1.  If the Team Foundation Server service account does not have the appropriate permissions on the specified SCVMM, a dialog box prompts you for a user name and a password.  
  
        2.  Type the name and the password of a user who is an existing member of the SCVMM Administrator role. The Team Foundation Server service account will be added to the SCVMM Administrator role.  
  
    3.  In the Team Foundation Server Administration Console, do the following for each team project collection.  
  
        1.  Click the **Lab Management** tab and then click **Configure Host Groups**. Select all host groups, and then click **Verify**. This confirms that Team Foundation Server and the new SCVMM can connect to the hosts and have the correct permissions.  
  
        2.  Click , **Lab Management**, and then click **Configure Library shares**. Select all library shares and then click **Verify**. This confirms that Team Foundation Server and the new SCVMM can connect to the library shares and have the correct permissions.  
  
5.  Confirm the move was successful:  
  
    1.  In Microsoft Test Manager, click **Lab Center** and then **Environments**. Confirm that your existing environments appear in the list and that they are in the correct state.  
  
    2.  Click **Library** and then **VMs and Templates**. Confirm that all the existing virtual machines and templates appear in the list and that they do not display new errors.  
  
##  <a name="BKMK_MoveaTestController"></a> Move a Test Controller  
 If you must move or reinstall a test controller that is associated with environments, possibly for a hardware upgrade or because the current server is becoming too old, you must back up the database and reinstall on the new machine. If you are moving a test controller used for load tests, you back up and restore the load test database additionally. You will also have to go to each agent and reregister it with the new controller.  
  
#### To move or reinstall a test controller  
  
1.  Locate the QTControllerConfig.XML file and make a backup copy.  
  
     This file is usually located in your Visual Studio installation in the Common7\\IDE folder.  
  
2.  Rebuild the machine with the same name.  
  
3.  Reinstall the test controller on the new machine.  
  
     Do not configure the Test Controller yet.  
  
4.  Replace the default QTControllerConfig.XML file on the machine with the file that you backed up in step 1.  
  
5.  Configure the Test Controller and connect it to the Project Collection it was connected before.  
  
6.  Restart the machine.  
  
7.  If you change the name of a machine where a test controller is installed and the testing capability is configured for an environment, you must update the name of the test controller in the environments using that test controller. You will use Microsoft Test Manager to modify the environment:  
  
    1.  Stop the environment.  
  
    2.  Edit the environment, and update the Test Controller setting in the **Capabilities** page. Select the Test Controller using its new name.  
  
    3.  Restart the environment.  
  
## See Also  
 [Change the Library Share for Your Team Project Collections](../dv_TeamTestALM/Change-the-Library-Share-for-Your-Team-Project-Collections.md)