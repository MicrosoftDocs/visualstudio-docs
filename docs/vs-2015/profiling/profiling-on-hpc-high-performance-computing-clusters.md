---
title: "Profiling on HPC (High Performance Computing) Clusters | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.performance.hpc.wizard.exeoptions"
  - "vs.performance.hpc.wizard.summary"
  - "vs.performance.hpc.wizard.startoptions"
  - "vs.performance.hpc.wizard.intro"
  - "vs.performance.hpc.property.basic"
  - "vs.performance.hpc.wizard.application"
  - "vs.performance.hpc.wizard.clusteroptions"
  - "vs.performance.hpc.property.advanced"
helpviewer_keywords: 
  - "profililng tools,HPC"
  - "HPC profiling"
ms.assetid: 1525bbdb-27da-4088-8487-a486cee5e7b3
caps.latest.revision: 27
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Profiling on HPC (High Performance Computing) Clusters
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can profile on compute nodes of Microsoft Windows HPC clusters by using the sampling method of the [!INCLUDE[vsPreExt](../includes/vspreext-md.md)] or [!INCLUDE[vsUltExt](../includes/vsultext-md.md)] Profiling Tools. For more information about HPC see [Big Compute: HPC & Batch](https://azure.microsoft.com/solutions/big-compute/) on the Microsoft Web site.  
  
## Prerequisites  
 To profile on a HPC compute node, you must do the following:  
  
- Install Microsoft HPC Pack 2008 on the same computer as [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)]. The computer does not have to be part of the HPC cluster. You can install the HPC Pack at the [Microsoft Download Center](https://www.microsoft.com/download/details.aspx?id=2800).  
  
- Install the [!INCLUDE[net_v40_long](../includes/net-v40-long-md.md)] and the stand-alone version of the Profiling Tools on the HPC compute node. Install programs for both the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] and the stand alone profiler are available on the [!INCLUDE[vsPreShort](../includes/vspreshort-md.md)] installation media. **Note** You must restart the compute after you have installed [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] and before you install the Profiling Tools.  
  
  To install the [!INCLUDE[net_v40_long](../includes/net-v40-long-md.md)] and the stand-alone Profiling Tools on an active HPC compute node and enable profiling on the cluster machine, follow these steps:  
  
1. Open the command prompt window that is installed with the HPC pack.  
  
2. Type the following commands at separate command prompts:  
  
    1. `clusrun /all /scheduler:` *%HeadNode% %FxPath%* `/q /norestart`  
  
    2. `clusrun /all /scheduler:` *%HeadNode%* `shutdown /r /t 0 /d u:4:2 /c "Microsoft .NET Framework install required restart"`  
  
    3. `clusrun /all /scheduler:` *%HeadNode% %ProfilerPath%* `/q /norestart`  
  
|||  
|-|-|  
|*%HeadNode%*|Name of the head node for the cluster.|  
|*%FxPath%*|Path to the [!INCLUDE[net_v40_long](../includes/net-v40-long-md.md)] installer. On the [!INCLUDE[vsPreShort](../includes/vspreshort-md.md)] installation media the path is: WCU\dotNetFramework\dotNetFx40_Full_x86_x64.exe|  
|*%ProfilerPath%*|Path to the standalone version of the Profiling Tools installer. On the [!INCLUDE[vsPreShort](../includes/vspreshort-md.md)] installation media the path is: Standalone Profiler\x64\vs_profiler.exe|  
  
## Profiling on an HPC Compute Node  
 You configure a profiling session by using the HPC Performance Wizard to specify the HPC cluster and target information. You can set additional options in the performance session property pages. The Profiling Tools automatically deploy the necessary target binaries and start the profiler and the HPC application.  
  
#### To profile on an HPC compute node  
  
1. On the **Analyze** menu, click **Launch HPC Performance Wizard**. If the command is not available, make sure that you have the prerequisites listed above.  
  
2. Click **Next** on the first page of the wizard.  
  
3. On the second page of the wizard, select the application that you want to profile.  
  
    - To profile a project that is currently open in [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)], select the **One or more available projects** option and then select the project name from the list.  
  
    - To profile a binary that is not in an open project select **An executable (.EXE file)** option.  
  
4. Click **Next**.  
  
5. On the third page of the wizard:  
  
    - If you are profiling an executable that is not in an open project, specify the path to the binary file in **What is the full path to the executable**.  
  
    - If you are profiling an executable that is not in an open project, you can specify any command-line arguments to pass to the process in **Command-line arguments**.  
  
    - In **Remote working directory**, specify the path to the folder that is used by the process instances on the individual compute nodes.  
  
    - In **Deployment location**, specify the path to the directory that the HPC server uses to stage images for deployment.  
  
6. Click **Next**.  
  
7. On the fourth page of the wizard:  
  
    - In the **Head Node** list, click the computer that acts as the HPC head node in the profiling run. The Head Node can be "localhost", which enables you to profile on the local machine without the need for a cluster.  
  
    - In the **Number of processes** list, click the number of instances of the application to run.  
  
    - From the **Profiling options** list, select the profiling target.  
  
         To profile a specific process in the cluster, select the **Profile on rank** option and then select the rank of the process from the drop-down list.  
  
         To profile the process or processes that run on a specific node in the HPC cluster, select the **Profile on node** option and then select the node from the drop-down list.  
  
8. Click **Next**.  
  
9. On the fifth page of the wizard, you can choose to immediately start the profiler and the profiling process or to start profiling later by using Performance Explorer.  
  
    - Select **Launch profiling after the wizard finishes** to start profiling immediately, or clear the check box to start profiling manually.  
  
10. Click **Finish**.  
  
## Setting HPC Profiling Properties By Using Performance Session Property Pages  
 You can change the performance session properties that you set on the HPC Profiling Wizard on the HPC Launch Properties page of the performance session properties page. You set additional options on the HPC Advanced Properties page.  
  
#### To open the performance session property pages  
  
1. If necessary, open the performance session (.psess) file in Performance Explorer. On the **File** menu, click **Open** and locate the file.  
  
2. In Performance Explorer, right-click the performance session name and then click **Properties**.  
  
3. In the Property Pages dialog box, use one of the following methods:  
  
    - Click **General** and then select **Collect on HPC Cluster** to turn HPC profiling on or clear the check box to disable HPC profiling.  
  
    - Click **HPC Launch Properties** to change the properties that start the HPC application.  
  
    - Click **HPC Advanced Properties** to set additional options  
  
### HPC Launch Properties  
  
|Property|Description|  
|--------------|-----------------|  
|**Head node**|Specifies the computer that acts as the HPC head node in the profiling run.|  
|**Number of processes**|Specifies the number of instances of the application to run in the profiled application.|  
|**Profile on rank**|To profile a specific process in the cluster, select the **Profile on rank** option and then select the rank of the process from the drop-down list.|  
|**Profile on node**|To profile the process or processes that run on a specific node in the HPC cluster, select the **Profile on node** option and then select the node from the drop-down list.|  
|**Remote working directory**|Specifies the path to the folder that is used by the process instances on the individual compute nodes.|  
|**Deployment location**|Specifies the path to the directory that the HPC server uses to stage images for deployment.|  
  
### Advanced Properties  
  
|Property|Description|  
|--------------|-----------------|  
|**Project name**|The name of the current [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] project or solution.|  
|**Clean up when profiler is stopped**|When true, removes the binaries that have been deployed to the execution directory. Files and directories created by the user program are not removed in this step. If the execution directory and deployment directory were created by the IDE, the IDE attempts to remove them but does not do so if they have files not deployed by the IDE.|  
|**Additional files to deploy**|Specifies a semicolon separated list of any additional files to deploy on the compute node. You can click the ellipsis button (**...**) to select multiple files by using a dialog box.|  
|**Mpiexec command**|Specifies the application that starts the MPI application. The default value is **mpiexec.exe**|  
|**Mpiexec arguments**|Specifies the arguments to pass to the mpiexec.exe command.|  
|**Requested nodes on the cluster**|Specifies the number of nodes on the cluster on which to run the application.|  
|**Deploy CRT files**|When true, deploys the C/C++ run time on the cluster.|  
|**Pre-profile script**|Specifies the path and file name of a script to run on the local development computer before the profiling session starts.|  
|**Pre-profile script arguments**|Specifies the arguments to pass to the pre-profile script.|  
|**Post-profile script**|Specifies the path and file name of a script to run on the local development computer after the profiling session ends.|  
|**Post-profile script arguments**|Specifies the arguments to pass to the post-profile script.|
