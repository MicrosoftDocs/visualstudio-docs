---
title: "Change the Library Share for Your Team Project Collections"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vstf.tfs.mmc.console.labmgmt.tpc.libshares"
helpviewer_keywords: 
  - "library shares [Lab Management]"
ms.assetid: cf847b3f-a342-4f0e-8d85-b32a2e026eb9
caps.latest.revision: 43
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
# Change the Library Share for Your Team Project Collections
You can use the library shares in the System Center Virtual Machine Manager (SCVMM) library as a place to create and store the virtual machines, templates, and environments in your team projects. You use SCVMM to create and manage the library shares and to specify on which computer a library share is located.  
  
 After you have configured [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] for the first time, you might later want to change the library shares that are used by your team project collection.  
  
> [!NOTE]
>  To configure [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] for the first time, see [Configure Lab Management for SCVMM environments](../test/configure-lab-management-for-scvmm-environments.md).  
  
 Using SCVMM, you can create multiple library shares on a single library server. The library shares enable you to allocate the disk space on your library server. If you do this you can allocate disk space for each team project collection. You can add multiple library shares to each team project collection. For example, you can add an extra library share from a different library server to a specific team project collection to provide more disk space for the environments, virtual machines, and templates for the teams that use that team project collection. If you are maximizing the network bandwidth to a specific library server for your team project collection, you may want to add a library share from another library server. Or, you might want to add a library share that has been added to a library server in a different physical location.  
  
> [!NOTE]
>  For improved performance, it is better to locate library shares and host groups in the same physical location. For example, if you have a distributed team with half your team located in one country and the other half in another country, then it is more efficient to have library shares and host groups that are physically located in each of those countries and have the team members use the library shares that are located together in their country. You can change the library shares by using the Administration Console for [!INCLUDE[esprfound](../codequality/includes/esprfound_md.md)]. Or, you can use the command-line to accomplish the same task. For more information about the command-line utility TFSLabConfig, see [Configuring Lab Management with TFSLabConfig](assetId:///28da1061-5a31-4e8b-96a7-116dfed55632).  
  
 Use the following procedure to change the library shares for your team project collection using the Administration Console for [!INCLUDE[esprfound](../codequality/includes/esprfound_md.md)]. For each library share that you add that is located on a different library server, you must also run the steps in the procedure to improve the reliability of WinRM. To expand your virtual lab, see [Expand or change your virtual lab](../test/expand-or-change-your-virtual-lab.md).  
  
### To add or remove library shares for a team project collection  
  
1.  In the Team Foundation Administration Console, under **Application Tier**, click **Team Project Collections**.  
  
2.  In the right-side pane, click the appropriate team project collection from the list of project collections.  
  
3.  Click the **Lab Management** tab, and then click **Configure Library Shares**.  
  
    > [!NOTE]
    >  You must create a library share using SCVMM before you can add this to be used by your team project collection.  
  
4.  To add a library share, on the **Library Shares** tab, click **Add and Verify**.  
  
     The **Select Library Shares** dialog box is displayed.  
  
    1.  Click one or more SCVMM library shares that this team project collection will use, and then click **Add**.  
  
    2.  To add the library share to each team project in the team project collection, select **Auto Provision** for the library share.  
  
        > [!NOTE]
        >  If you select to auto provision the library share, [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] automatically adds the library share to all the team projects in this team project collection. For team projects that have not yet been created, the library share is added when the **New Team Project** wizard creates the project. For team projects that have already been created in this team project collection, the library share is added when these settings are saved. If you clear **Auto Provision** the library share will no longer be added to new team projects that you add to your team project collection.  
  
5.  To delete a library share, on the **Library Shares** tab, select the library share from the list, and then click **Delete**.  
  
    > [!IMPORTANT]
    >  Before you can delete a library share from a team project collection, you must first remove all [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] environments, virtual machines and templates that are stored on this library share using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. Then you must remove the association of this library share from each team project in that project collection by using the command-line utility TFSLabConfig. For more information about how to do this, see [TFSLabConfig DeleteTeamProjectLibraryShare Command](assetId:///4388c79c-98e1-4337-b59c-f9688a599c13).  
  
6.  To confirm that [!INCLUDE[vstsTfsLong](../codequality/includes/vststfslong_md.md)] can connect to the library share, click **Verify**.  
  
7.  Click **OK**.  
  
## Improve the Reliability of WinRM  
 You must make following changes to the default configuration settings for Windows Remote Management for each library server that has library shares that you use for [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)]. The changes to these settings help improve the reliability of WinRM because [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] performs a larger number of operations on Hyper-V hosts than are performed in a typical production scenario for Hyper-V.  
  
#### To change Windows Remote Management configuration settings  
  
1.  Click **Start**, right-click **Command Prompt**, and then click **Run as administrator**.  
  
    > [!NOTE]
    >  You must be a domain user who has been added to the administrators group for this machine.  
  
2.  At the command prompt, run the following command:  
  
     **winrm set winrm/config @{MaxTimeoutms = "1800000"}**  
  
3.  If the host operating system is [!INCLUDE[firstref_longhorn](../test/includes/firstref_longhorn_md.md)] SP2, also run the following command:  
  
     **winrm set winrm/config/Service @{MaxConcurrentOperations="200"} -r:http://\<LibraryServerMachine>**  
  
     (Replace *LibraryServerMachine* with the computer name of the library server.)  
  
    > [!NOTE]
    >  To create a WinRM listener on http://\<LibrayServerMachine>, you might also have to run the following command:  
    >   
    >  **winrm quickconfig**  
  
4.  Restart winrm and the SCVMM agent on the hosts after you make these changes using the following commands:  
  
     **net stop winrm**  
  
     **net start winrm**  
  
     **net start vmmagent**  
  
## See Also  
 [Manage team project collections](../Topic/Manage%20team%20project%20collections.md)   
 [Change Existing Lab Management Configurations](../test/change-existing-lab-management-configurations.md)