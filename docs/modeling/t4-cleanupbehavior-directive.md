---
title: T4 CleanUpBehavior directive
ms.date: 11/04/2016
ms.topic: reference
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# T4 CleanUpBehavior directive

To delete the appDomain after processing a text template, include the following line:

```
<#@ CleanupBehavior processor="T4VSHost" CleanupAfterProcessingtemplate="true" #>
```

Text templates are processed in an appDomain that is separate from the host process. In most cases, when one text template has been processed, the appdomain is used again to process the next template. But if you specify CleanupBehavior, the appDomain is deleted and the next template will be processed in a new appDomain.

This slows text processing, but can be useful to make sure that resources are disposed.

This directive works only in the Visual Studio host.