---
title: "Plan your lab"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: f9c9b456-3bed-4957-8a43-e3a7d3eaf363
caps.latest.revision: 29
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
# Plan your lab
As you prepare for widespread use of Lab Management in your test lab, several questions are likely to come to mind:  
  
-   How many physical servers do I need?  
  
-   What kinds of servers should I buy?  
  
-   How much storage capacity do I need?  
  
-   Can I use a SAN for storage?  
  
-   Can I setup everything on one powerful machine?  
  
-   How do I set up an isolated lab?  
  
 This topic provides general guidelines for estimating the numbers and types of physical servers, virtual machines (VMs), and controllers you will need for using [!INCLUDE[vstsLabLong](../test/includes/vstslablong_md.md)]. In general, the number of servers is not as important as the capacity of each server. For example, a server that uses a dual-core or quad-core processor will be able to support more VMs than a server that uses a single-core processor. Similarly, a server that has 32 GB of RAM can host more VMs at the same time than a server that has only 8GB of RAM.  
  
## Planning for Capacity  
 The following sections contain guidelines to help you provide sufficient capacity for your virtual testing lab. The guidelines are expressed as things to do (**Do’s**) and not do (**Don’ts**) when you acquire or configure hardware or when you install and configure the required software.  
  
### Planning for Team Foundation Server  
 **Don’t**  
  
-   **Set up everything on a single machine.** Only if you will use a single machine just for demonstration or proof of concept purposes should you set up all the components on a single machine.  
  
-   **Use the NetworkService account as the service account for [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] if your instance of [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] uses more than one server to run the logical application tier, and you will be using the Lab Management feature of Visual Studio** Using the NetworkService account requires more manual work later to maintain the physical host machines for virtual environments. This extra work is necessary because the NetworkService account for each new application-tier machine has to be added to the local Administrator group on each physical host machine. For example, if you run a virtual lab with 20 physical hosts and add or replace an application-tier machine, you would then have to update each of the 20 host machines with the name of the new application-tier machine and assign permissions. Instead of using the NetworkService account, use a standard domain user account and password for the TFSservice account. By doing this, the domain user account is added once at the initial configuration of the physical host and each subsequent application-tier machine uses the same account. For more information about the limitations of the NetworkService account, see [NetworkService Account](http://go.microsoft.com/fwlink/?LinkID=195387).  
  
### Planning for System Center Virtual Machine Manager  
 **Don’t**  
  
-   **Install SCVMM on a virtual machine.** Installing SCVMM on a virtual machine will make it harder to administer the physical host that virtual machine is running on, and it will slow the performance of the library if you set the library up on the same virtual machine.  
  
-   **Use clustering with the SCVMM 2008 R2 library servers.** Lab Management only supports clustering in SCVMM environments when using SCVMM 2012, not SCVMM 2008 R2.  
  
-   **Set virtual LAN IDs for network adapters.** Lab Management does not support setting and using a virtual LAN ID in System Center Virtual Machine Manager. If you manually set the VLAN ID on a network adapter for a virtual machine and then store the virtual machine in the SCVMM library, the VLAN ID will be cleared when the virtual machine is deployed. For more information about how to use VLAN IDs, see [Configuring Virtual Networks in VMM](http://go.microsoft.com/fwlink/?LinkId=211832).  
  
 **Do**  
  
-   **Provide the SCVMM machine enough resources.** If you expect to have fewer than 50 VMs in your lab, the machine running SCVMM should have at least:  
  
    -   A 64-bit processor  
  
    -   4 GB of memory  
  
    -   A 300 GB hard disk drive  
  
    -   Windows Server 2008 R2 operating system  
  
     If you expect to have more than 50 VMs, increase these resources. If you plan to install SCVMM along with some other software on the same machine, give SCVMM server the amount of resources that were described earlier in this topic. However, be sure to determine the amount after you deduct the resource consumption of the other software. For instance, if you want to install SCVMM on the machine that is running [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)], add the requirements to those of [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)], and then ensure that the machine has enough capacity.  
  
-   **Provide the server that runs the library at least 200GB of free space on the hard disk drive.** In the default installation, make sure that the drive used by the library share has more than 200GB free space.  
  
-   **Create the default library share on D: and not C:.** By default, SCVMM creates the library share on the same machine it is on and creates the library in the C: drive. Changing the default library share to D: makes it easier to upgrade the machine later.  
  
-   **Use a hard disk drive with sufficient speed for the library.** If you plan to use the library lightly, a hard disk with sufficient speed will be sufficient. If you plan to use the library moderately, use a RAID 5 disk configuration with 6 to 12 disks for better throughput. If you plan to use the library heavily, use multiple library servers. You can use direct-attached storage or SAN. When using SAN, create a LUN to be used solely for library machine.  
  
-   **Run [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] under a regular domain user account instead of the network service account.** This is required if you put [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] and SCVMM on the same machine.  
  
-   **If SCVMM is installed on a Hyper-V host, store the Hyper-V hosted virtual machines on a different hard disk drive than the SCVMM library.** For example, use C: from one disk for the library, and D: from another disk for Hyper-V virtual machines. SCVMM server, in this case, will be running in the primary OS in Hyper-V. This ensures that when the primary OS is loaded, all guest OS (VMs deployed in Hyper-V) will be impacted. To reduce this impact, configure the host reserves for that machine by adding the Hyper-V host reserves (described below) to the SCVMM machine requirements mentioned earlier. Host reserves can be configured using the SCVMM Administrator Console.  
  
-   **Provide line-of-sight network routing between SCVMM and [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)], hosts, and other library servers.**  
  
-   **Update the SCVMM machine with all the latest Windows updates and ensure these updates get applied automatically.** If this is not feasible, you should plan to keep track of Windows and SCVMM updates, and apply them manually as they become available.  
  
### Planning for the Hyper-V hosts  
 **Don’t**  
  
-   **Install any additional software such as [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] on the physical host machine.** If you have sufficiently powerful hosts (exceeding the aggregate needs of the hypervisor and virtual machines), then you can have SCVMM or library server co-located on the host, as long as you also account for the resource constraints of those servers. For example, if you want to install SCVMM on a Hyper-V host machine, then add the host requirements, virtual machine requirements, and SCVMM requirements, and then ensure that the machine has enough capacity.  
  
-   **Use clustering with Hyper-V host servers.** Lab Management supports clustering in SCVMM environments.  
  
-   **Schedule tens of VMs deployments simultaneously.** Limit the number of concurrent environment deployments to hosts.  
  
-   **Use physical hosts that are in different geographic locations that the library servers.** If you must use hosts that are in a different geographic location than the SCVMM library servers, the network speed between SCVMM and hosts should be at least 100 Mbps and not subject to high latencies.  
  
-   **Create multiple network adapters on a virtual machine that connects to a specific network.** Lab Management overrides this configuration and creates two adapters. One adapter connects to the lab network and the other adapter handles internal communication between virtual machines.  
  
-   **Configure the MAC address on a network adapter used in a network-isolated environment.** Lab Management clears the MAC address at the time the network-isolated environment is created.  
  
 **Do**  
  
-   **Provide the host machines with enough resources and configure them correctly.** The number of Hyper-V hosts and the capacity of each host depends on the number of VMs that you host in your lab. If you decide to setup a relatively small lab, install the Hyper-V role on machines with the following configuration:  
  
    -   Two, dual-core, 64-bit processors that are Hyper-V capable  
  
    -   16 GB memory  
  
    -   300 GB hard disk space  
  
    -   Windows Server 2008 R2 operating system  
  
    -   The latest updates of the Windows operating system.  
  
     If you have relatively larger number of virtual machines, and you decide to set up a few, powerful hosts, configure each host as follows:  
  
    -   two, quad-core, 64-bit processors that are Hyper-V capable  
  
    -   64 GB memory  
  
    -   1 TB hard disk space  
  
    -   Windows Server 2008 R2 operating system  
  
    -   The latest updates of the Windows operating system.  
  
-   **Reserve enough RAM memory on the host.** Out of the host capacity requirements listed above, you must set aside the following resources for the smooth functioning of the hypervisor. For a 16GB host, set aside 20% for the CPU and 2 GB memory. For a 64 GB host, set aside 30% for the CPU and 4 GB memory. These host reserves must be configured in the host properties pane of SCVMM Administrator Console. Only the resources remaining on the host after deducting the host reserves can be used for virtual machines.  
  
-   **Provide enough storage for virtual machines.** You should use a different disk partition for virtual machine storage than the primary partition of Hyper-V server. For example, use D: for virtual machine storage and C: for the primary partition for the hypervisor. After you decide on the virtual machine storage location, configure that location in Hyper-V Manager or using SCVMM Administrator Console. In Hyper-V Manager, change the Virtual Hard Disks folder and the Virtual Machines folder. In the SCVMM Administrator Console, change the Placement Path under the host properties.  
  
-   **Provide the hosts with fast hard disk drives and configure the drives correctly.** Disk types for hosts: A disk with good speed is necessary. RAID 5 configured disks are highly recommended. The storage for hosts can come from Direct-attached storage or from SAN. However, if you decide to have your host’s disk come from a SAN drive for space and reliability needs, you will have to have separate LUNs mapped to each host. Even if the LUNs are managed by same controller, given that Visual Studio Lab Management does not leverage any of SAN functionalities, the underlying BITS copy during a virtual machine deployment will happen all the way from library to host via your LAN network.  
  
-   For SCVMM to be installed on a Hyper-V host, it is highly recommended that the hard disk drive used for storing Hyper-V hosted virtual machines is different from the disk used for library. SCVMM server, in this case, will be running in the primary OS in Hyper-V. So, when the primary OS is loaded, all Guest OS (VMs deployed in Hyper-V) will have performance impact. To reduce this impact, configure the host reserves for that machine by adding the Hyper-V machine’s host reserves to the SCVMM machine requirements mentioned earlier. Host reserves can be configured using SCVMM administration console.  
  
-   For a Hyper-V host to be used as a library server as well, you must have multiple disks in the machine. You should use separate hard disks on the host for the virtual machines and for the library storage.  
  
-   **Provide the Hyper-V host with line-of-sight networking to [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)], SCVMM, and other library servers.**  
  
-   **If the Hyper-V hosts are in different geographic locations, have a local library server for each location as well.**  
  
-   **Update the hosts regularly.** Hyper-V hosts should be on a network from where operating system updates can be automatically applied. If this is not feasible, you should plan on keeping track of Windows and SCVMM updates, and apply them manually when they become available.  
  
### Planning for Controllers and Agents  
 **Don’t**  
  
-   **Install a test controller inside an environment.** Only the build, test, and lab agents should be installed on the virtual machines inside an environment.  
  
 **Do**  
  
-   **Use more than one build controller when building and deploying an application for testing.** The first controller is used by the build process and is not heavily utilized. The second controller is used to deploy the build to virtual machines and run tests; therefore, it can be heavily used if there are a large number of virtual machines in your lab. The second controller is also used to take snapshots of the environment.  
  
-   **Use test controllers in the same domain as [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)].** If esprtfs and a test controller are in a workgroup or untrusted domain, you must create a local user account with same user name and password on both machines, add this user on Team Foundation Server to the "[Project Collection]\Project Collection Test Service Accounts" security group, and then register the test controller with team project collection using this local account.  
  
## Planning for Topology  
 **Do**  
  
-   **Use a gigabit network to connect the server where SCVMM is installed to the library servers and to the Hyper-V hosts.**  
  
-   **Establish a full, two-way trust relationship among the domains where [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)], the test controller, the build controller, SCVMM, and the physical host of the virtual machines are running.**  
  
 There are several topologies you can use when setting up [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] for testing your application. The simplest topology for using [!INCLUDE[vstsLabShort](../test/includes/vstslabshort_md.md)] requires only two servers: install all [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] components on the same server and install all SCVMM 2008 components on an additional server. Alternatively, you might have complex networking topology requirements that restrict the networks in which [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)], SCVMM, Hyper-V hosts, and virtual machines running the application-under-test can be located. In another alternative, you might want to configure network load balancing for your [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)]. The following list suggests several possible dimensions for your topology and the variations within each dimension.  
  
 **Networking**  
  
-   DNS  
  
-   Firewall  
  
-   Threat Management Gateway  
  
 **Domain**  
  
-   One-way trust  
  
-   Two-way trust  
  
-   No-trust  
  
 **Team Foundation Server logical application tier**  
  
-   Single server  
  
-   Multiple servers without network load balancing  
  
-   Multiple servers with network load balancing  
  
 **Team Foundation Server logical data tier**  
  
-   Single server  
  
-   Multiple servers without clustering  
  
-   Multiple servers with clustering  
  
 **Tests**  
  
-   Inside the environment  
  
-   Outside the environment  
  
 The following four sample topologies are examples of how you can set up combinations of the above dimensions according to your testing needs.  
  
### Sample Topology 1  
 The [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] logical application tier is run on several servers and those servers are controlled by a network load balancer. There is also a separate test network with firewall settings to control the test traffic into and out of the domain network. The following diagram illustrates topology 1.  
  
 ![All machines joined to corporate network](../test/media/labtopology1.png "LabTopology1")  
  
 For instructions to set up this topology, see [Setting up various topologies to test with Visual Studio Lab Management – Part 1](http://go.microsoft.com/fwlink/?LinkId=194998).  
  
### Sample Topology 2  
 The [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] logical application tier and data tiers are run on several servers, but those servers are not controlled by a load balancer. There is also a separate test network with a SAN-based library and host. The following diagram illustrates topology 2.  
  
 ![Machines without load balancer but with SAN](../test/media/labtopology2.png "LabTopology2")  
  
 For instructions to set up this topology, see [Setting up various topologies to test with Visual Studio Lab Management – Part 2](http://go.microsoft.com/fwlink/?LinkId=195001).  
  
### Sample Topology 3  
 The [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] logical application tier is run on several servers and those servers are controlled by a network load balancer. There is also a separate test network. The applications being tested make calls to a database outside the virtual environment. The following diagram illustrates topology 3.  
  
 ![Machines with database outside the environment](../test/media/labtopology3.png "LabTopology3")  
  
 For instructions to set up this topology, see [Setting up various topologies to test with Visual Studio Lab Management – Part 3](http://go.microsoft.com/fwlink/?LinkId=195002).  
  
### Sample Topology 4  
 The [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] logical application tier and data tiers are run on several servers and those servers are controlled by a network load balancer. The test network and environments are in a separate domain. The following diagram illustrates topology 4.  
  
 ![Machines inside two domains](../test/media/labtopology4.png "LabTopology4")  
  
 For instructions to set up this topology, see [Setting up various topologies to test with Visual Studio Lab Management – Part 4](http://go.microsoft.com/fwlink/?LinkId=195004).  
  
## See Also  
 [Team Foundation Server architecture](assetId:///0ba15294-9b0b-48a9-b8ca-1c4723feb60b)   
 [Examples of Simple Topology](../Topic/Examples%20of%20Simple%20Topology.md)   
 [Examples of Moderate Topology](../Topic/Examples%20of%20Moderate%20Topology.md)   
 [Examples of Complex Topology](../Topic/Examples%20of%20Complex%20Topology.md)   
 [Configure and administer Lab Management](../test/configure-and-administer-lab-management.md)