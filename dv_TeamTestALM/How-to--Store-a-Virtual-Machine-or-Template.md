---
title: "How to: Store a Virtual Machine or Template"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4f53c5a0-cec0-43ba-bf5d-6fd74ffa33b7
caps.latest.revision: 27
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
# How to: Store a Virtual Machine or Template
As you create, use, and store SCVMM environments, you might find it necessary or desirable to use a virtual machine from one environment as part of another environment. Although you cannot copy and paste a virtual machine directly from one environment to another, you can save the virtual machine from the first environment into the team project library and then deploy the saved virtual machine into the second environment. Saving virtual machines lets team project members create virtual machines or templates without having to request assistance from system administrators, who use System Center Virtual Machine Manager (SCVMM).  
  
 **Requirements**  
  
-   Visual Studio Enterprise, Visual Studio Test Professional  
  
 You can save a virtual machine in the Library as a template or as a stored virtual machine. The procedure contains three main steps:  
  
 [Step 1: Prepare the Virtual Machine to be Stored in the Team Project Library](#PrepareDeployedVM)  
  
 [Step 2: Create the Template or Stored Virtual Machine in the Library](#CreateTemplateOrStoredVM)  
  
 [Step 3: Restore the Configuration of the Deployed Virtual Machine](#RestoreDeployedVMState)  
  
##  <a name="PrepareDeployedVM"></a> Step 1: Prepare the Virtual Machine to be Stored in the Team Project Library  
  
1.  **Snapshot the environment.** After you have stored the virtual machine, you will want to restore it to its current state. The most reliable way to do this is to take a snapshot. Alternatively, if there are a lot of machines in the environment, you might prefer to simply undo your changes after you have saved the machine.  
  
    1.  In Microsoft Test Manager, choose **Lab Center**, **Lab**. Select the environment and then choose **Connect**.  
  
    2.  In the Environment Viewer, choose **Shut Down**. If the environment is Paused, you must start it first.  
  
    3.  Open the **Snapshots** tab. When the environment has shut down, choose **Take Snapshot**.  
  
2.  If the environment is off or paused, start it.  
  
3.  **Ensure that a test agent is installed.**  
  
     Select the environment in Lab Center, and verify that the status of the virtual machine is **Ready**.  
  
     If the status is not **Ready**, choose **Repair** from the shortcut menu on the environment. This will install and configure a test agent on the virtual machine.  
  
     Alternatively, you can store the virtual machine without a test agent, but then it will be necessary to use the **Repair** command each time it is deployed into an environment.  
  
4.  **Log on to the virtual machine.**  
  
     Select the virtual machine and choose **Connect**.  
  
5.  **Enable remote desktop connections.**  
  
    1.  On the virtual machine, choose **Start**, right-click **Computer** and then choose **Properties**.  
  
    2.  In the **Systems** dialog box, choose **Remote settings**.  
  
    3.  On the **Remote** tab of the **System properties** dialog box, choose the appropriate **Allow connections** option, and then choose **OK**.  
  
6.  **Join the machine to a workgroup.**  
  
     If the virtual machine is joined to a domain, choose **Control Panel**, **System**, **Change settings**, **Change computer name**. Choose **Member of Workgroup** and type a workgroup name.  Restart the machine when you are prompted to do this.  
  
     If you store the machine while it is still joined to a domain, then domain name conflicts might occur when a copy is deployed from the library.  
  
7.  **If you want to save the machine as a template (recommended), clear the administrator password:**  
  
    1.  Open gpedit.msc, and then choose **Local Computer Policy**, **Computer Configuration**, **Windows Settings**, **Security Settings**, **Account Policies**, and then **Password Policy**. Then set the following values:  
  
        |||  
        |-|-|  
        |**Enforce password history**|0|  
        |**Maximum password age**|0|  
        |**Minimum password age**|0|  
        |**Minimum password length**|0|  
        |**Password must meet complexity requirements**|Disabled|  
  
         Close gpedit.msc  
  
    2.  Change the password of the local Administrator account so that it is empty:  
  
         Log in as Administrator and then use CTRL+ALT+DEL to change the password.  
  
##  <a name="CreateTemplateOrStoredVM"></a> Step 2: Store the template or virtual machine in the library  
  
1.  Choose **Lab Center** and then choose the **Lab** tab.  
  
2.  Shut down the environment that contains the virtual machine to be stored. You can only save a virtual machine when it is in the **Stopped** state.  
  
3.  Choose **Store in library** on the shortcut menu of the virtual machine you want. The virtual machines appear in the right-side pane when you select the environment.  
  
> [!NOTE]
>  While a virtual machine from an environment is being stored in library, you cannot start the environment or perform other operations on it. You may store another virtual machine from the same environment in library at the same time.  
  
 ![Creating a  stored VM from a deployed environment](../dv_TeamTestALM/media/LM_TempDeployed.png "LM_TempDeployed")  
  
#### Fill the fields of the storage wizard:  
  
1.  Enter the name and library location for the stored virtual machine or template.  
  
2.  Select the **Store as template** check box to create a template in the library (recommended). Clear the check box to create a stored virtual machine.  
  
3.  Choose the following tabs on the wizard to set additional properties of the stored virtual machine or template. For more information, see the corresponding sections in [(superseded) How to: Set the Properties of a Virtual Machine or Template](assetId:///09964b12-0115-4bfd-95aa-3dea22bc5093).  
  
    |Tab|Properties|  
    |---------|----------------|  
    |**Hardware profile**|Size of memory|  
    |**OS profile**|Templates only. Operating system type, computer name, administrator password, product key, domain and workgroup for virtual machines deployed from the template. Stored virtual machines inherit this information from the source virtual machine.|  
    |**Machine tags**|User defined custom properties to track for the stored virtual machine or template.|  
  
4.  Select **Save and close** to close the dialog box, and to initiate the process of storing the virtual machine into library.  
  
##  <a name="RestoreDeployedVMState"></a> Step 3: Undo the preparations you made in the original virtual machine  
  
1.  Choose **Lab**, select the environment from which you copied the virtual machine, and choose **Connect**.  
  
     The environment viewer opens.  
  
2.  If you took a snapshot before preparing the machine, open the **Snapshots** tab, select the snapshot, and choose **Restore**.  
  
3.  If you did not take a snapshot, choose **Start**. Select the virtual machine.  
  
4.  Restore the virtual machine to its original state by undoing the changes that you made in Step 1.  
  
     Use the following check-list to determine what you might need to restore or remove.  
  
    -   The administrator password.  
  
    -   The administrator and local password policy.  
  
    -   The connection to a domain.  
  
    -   The computer name.  
  
    -   Build or test agents.  
  
         If necessary, you can remove them by using the **Programs and Features** control panel.  
  
    -   Remote desktop connections setting  
  
## See Also  
 [Create and Store Virtual Machines and Templates Ready for Lab Management](../dv_TeamTestALM/Create-and-Store-Virtual-Machines-and-Templates-Ready-for-Lab-Management.md)   
 [Creating Lab Environments](../dv_TeamTestALM/Creating-Lab-Environments.md)