---
title: "Create virtual machines for manual testing"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: aa24ba47-75c7-432c-a86d-d330d25de7b6
caps.latest.revision: 7
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
# Create virtual machines for manual testing
An [SCVMM lab environment](../test/scvmm--virtual--environments.md) is a group of virtual machines (VMs) that you can manage as a single entity. You use a lab environment for [testing](../test/test-apps-early-and-often.md) a web or a network application and run the server components on the lab machines. A typical environment might include one machine configured as a web server and another as a database server. Before you start a series of tests, you have to compose the environment by selecting suitable virtual machines from a library. You can also pick a complete saved environment of several machines and deploy a copy of it.  
  
 But before you can use SCVMM environments, you have to create some virtual machines and import them to the library of your team project collection.  
  
## Do you need to set up SCVMM?  
 System Center Virtual Machine Manager (SCVMM) helps you manage virtual machines and store them in a library. You have to [set up SCVMM and configure lab management in your Team Foundation Server](../test/configure-lab-management-for-scvmm-environments.md) before you can use SCVMM lab environments.  
  
 To verify that SCVMM lab management is configured on your team project collection, start the new lab environment wizard and see whether the SCVMM option is available. If it is enabled, then SCVMM has been configured, and you can go ahead and create virtual machines. Cancel the environment wizard.  
  
## Prepare a virtual machine for the library  
  
1.  [Use SCVMM to create a new virtual machine](http://technet.microsoft.com/library/cc917897.aspx) and install Windows.  
  
     You can install Windows XP, Windows Vista, Windows 7, Windows 8, Windows Server 2008, or Windows Server 2012.  
  
2.  Log in to the new virtual machine and add a user account that has Administrator privileges. Use the same user name and password on every lab machine. It can be either a local or a domain account. This allows Lab Manager to administer the machine.  
  
3.  Enable remote desktop connections to this machine.  
  
4.  Install a test agent. Don’t connect it to a test controller. Lab Manager will connect it when you use the machine in a lab environment.  
  
     You’ll find the test agent installer on the same medium as Team Foundation Server.  
  
5.  Configure Windows and any additional software that you will want when you’re testing. For example, you might enable the Web Server (IIS) role and install SQL Server.  
  
     But don’t install the application you’re testing.  
  
## Make the machine available for lab environments  
 There are three kinds of virtual machine that you can create for use in lab environments:  
  
1.  **Running virtual machine.** You set the machine running now, and add it to a pool of machines. Users can add the machine to an environment, and later return it back to the pool. Creating environments this way is very quick.  
  
2.  **Stored virtual machine.** You save the machine in the library. Users can use a copy in their environments, but can only create one running copy at a time.  
  
3.  **Virtual machine template.** You save a template from which the machine identity has been removed. Users can create environments that have more than one instance of the template machine.  
  
### Running virtual machine  
 In Microsoft Test Manager, open Lab Center, Virtual Machines and Templates. Choose **Import** and select the virtual machine.  
  
### Stored virtual machine  
 Using the SCVMM console:  
  
1.  Shut down the virtual machine.  
  
2.  Store it in the library.  
  
     If there is more than one SCVMM library, select the one that is shared with your team project collection.  
  
 Using Microsoft Test Manager:  
  
-   In Lab Center, Virtual Machines and Templates, import the new virtual machine.  
  
### Virtual machine template  
 On the virtual machine:  
  
1.  If the machine is joined to a domain, remove it from the domain and join it to a workgroup. Restart the machine.  
  
2.  Open the Group Policy Editor gpedit.msc. Open **Local Computer Policy**, **Computer Configuration**, **Windows Settings**, **Security Settings**, **Account Policies**, **Password Policy**.  
  
     Set the following values:  
  
    -   Enforce password history = 0  
  
    -   Minimum password length = 0  
  
    -   Password must meet complexity requirements = Disabled  
  
3.  Change the password of local Administrator account to be empty. You can do this by logging in as .\Administrator and then using CTRL+ALT+DEL to change the password.  
  
4.  Make sure there is no CD or DVD loaded in the virtual machine.  
  
 In SCVMM Administrator console:  
  
1.  Shut down the virtual machine.  
  
2.  Select the virtual machine and create a clone of it. This is recommended because the original virtual machine is destroyed when it is converted into a template.  
  
3.  Remove all the checkpoints on the clone.  
  
     To do this, in the context menu of the clone machine, choose **Manage checkpoints**. The removal operation might take several minutes. Hyper-V merges the disks associated with the checkpoints. To monitor the progress of the merge, use Hyper-V manager on the host where the virtual machine is deployed.  
  
     Wait for the merge to finish.  
  
4.  In the context menu of the clone machine, choose **New Template**.  
  
 Using Microsoft Test Manager:  
  
-   In Lab Center, Virtual Machines and Templates, import the new virtual machine template.  
  
     When you import a template from SCVMM, the secured administrator password and product key in the template are removed. You must re-enter this information. If the operating system is Windows 7, Windows Server 2008 and later, or Windows Vista, leave the password field blank. If the operating system is Windows XP or Windows Server 2003, type an asterisk (*) to indicate a blank password.  
  
## Try this next  
 [SCVMM (virtual) environments](../test/scvmm--virtual--environments.md)