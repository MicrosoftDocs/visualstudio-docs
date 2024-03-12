---
title: Use a lab environment for devops
description: Learn about lab environments and how you can use the cloud with Azure Pipelines or Team Foundation Server Build and Release.
ms.date: 08/22/2022
ms.topic: how-to
helpviewer_keywords:
  - lab environment, test lab
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
author: mikejo5000
---
# Use a lab environment for your devops

A lab environment is a collection of virtual and physical machines that you can use to develop and test applications. A lab environment can contain multiple roles needed to test multi-tiered applications, such as workstations, web servers, and database servers. In addition, you can use a build-deploy-test workflow with your lab environment to automate the process of building, deploying, and running automated tests on your application.

> [!IMPORTANT]
> Visual Studio no longer supports [Microsoft Test Manager and Lab Management](/previous-versions/azure/devops/test/mtm/reference-tcm?view=tfs-2017&viewFallbackFrom=azure-devops&preserve-view=true) for automated testing. Similarly, [SCVMM](/system-center/vmm/overview?view=sc-vmm-1801&preserve-view=true) and XAML Builds are no longer supported. We recommend [Azure DevTest Labs](/azure/devtest-labs/devtest-lab-overview) instead.

