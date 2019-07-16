---
title: "Logging in MSBuild | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "msbuild, logging"
ms.assetid: 9aea2e76-8f60-4234-913d-598e7bbad808
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Logging in MSBuild
Logging provides a way for you to monitor the progress of a build. Logging captures build events, messages, warnings, and errors in a log file.

## In this section
- [Obtain build logs](../msbuild/obtaining-build-logs-with-msbuild.md)

 Describes the various aspects of logging in [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)].

- [Build loggers](../msbuild/build-loggers.md)

 Outlines the steps required to create a single-processor logger.

- [Logging in a multi-processor environment](../msbuild/logging-in-a-multi-processor-environment.md)

 Describes how logging works in a multi-processor environment and the two multi-processor logging models.

- [Write multi-processor-aware loggers](../msbuild/writing-multi-processor-aware-loggers.md)

 Outlines how to create multi-processor-aware loggers and how to use the ConfigurableForwardingLogger.

- [Create forwarding loggers](../msbuild/creating-forwarding-loggers.md)

 Outlines how to create custom forwarding loggers.

## See also
- [Build multiple projects in parallel](../msbuild/building-multiple-projects-in-parallel-with-msbuild.md)
 Describes how to build multiple projects faster by running them in parallel.