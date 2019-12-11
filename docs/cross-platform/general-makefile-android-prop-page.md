---
title: "General Project Properties (Android C++ Makefile) | Microsoft Docs"
ms.custom: ""
ms.date: "10/23/2017"
ms.technology: vs-ide-mobile
ms.topic: "conceptual"
ms.assetid: f76d717c-56ed-4373-8cf9-9bd1a053a4cd
author: "corob-msft"
ms.author: "corob"
manager: jillfra
f1_keywords:
  - VC.Project.VCConfiguration.OutputDirectory
  - VC.Project.VCConfiguration.IntermediateDirectory
  - VC.Project.VCConfiguration.BuildLogFile
  - VC.Project.VCConfiguration.ConfigurationType
ms.workload:
  - "xplat-cplusplus"
---

# General project properties (Android C++ Makefile)

Property | Description | Choices
--- | ---| ---
Output Directory | Specifies a relative path to the output file directory; can include environment variables.
Intermediate Directory | Specifies a relative path to the intermediate file directory; can include environment variables.
Build Log File | Specifies the build log file to write to when build logging is enabled.
Configuration Type | Specifies the type of output this configuration generates. | **Dynamic Library (.so)** - Dynamic Library (*.so*)<br>**Static library (.a)** - Static Library (*.a*)<br>**Utility** - Utility<br>**Makefile** - Makefile<br>
