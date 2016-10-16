---
title: "Test on a lab environment"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 14ba54c8-a158-4a6e-b00a-b00ae960feb8
caps.latest.revision: 50
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
# Test on a lab environment
A *lab environment* is a group of computers that you manage as a single entity. Usually you use them for [system testing](../test/testing-your-application-using-microsoft-test-manager.md). If you’re testing a distributed application such as a web app, you can perform realistic tests by deploying each component on a separate machine.  
  
 Lab environments let you [collect diagnostic data](../test/collect-more-diagnostic-data-in-manual-tests.md) from all the machines in the lab while you’re performing your tests. The data, such as event logs or Intellitrace files, are attached to the test results and to any bug that you create.  
  
 ![Manual testing with lab servers.](../test/media/almt_ws81.png "ALMT_ws81")  
  
 Lab environments also provide a convenient way to manage the assignment of test machines to testers.  
  
## What can I do with lab environments?  
  
|What you can do|Use|Setting up|  
|---------------------|---------|----------------|  
|-   Mark machines as in use by you.<br />-   [Collect diagnostic data](../test/collect-more-diagnostic-data-in-manual-tests.md) from servers while you perform your tests.|[Standard lab environment](../test/standard-lab-environments.md)|You can add any physical or virtual Windows machine to a standard environment.|  
|+<br /><br /> -   Reset the machines in the environment to a fresh state before starting your tests.<br />-   Take a snapshot of the machine states when you find a bug, to help diagnosis.<br />-   Save an environment as a template from which you can create new environments with new virtual machines.|[SCVMM environment](../test/scvmm--virtual--environments.md)|Initial setup: create virtual machines in SCVMM.<br /><br /> Once your SCVMM machines are set up, you can create environments from them. You can also save machines as templates and make fresh copies.|  
|+<br /><br /> -   Create several environments from the same template and perform tests on them at the same time, without network name clashes.|[Network isolated environment](../test/creating-and-using-a-network-isolated-environment.md)|Initial setup: create a library of virtual machines that you can use as templates.|