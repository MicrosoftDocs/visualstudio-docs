---
title: VS Shell deployment
description: Learn how an isolated shell lets you determine which Visual Studio functionality you need to interact with your DSL and how that solution should appear.
ms.date: 11/04/2016
ms.topic: how-to
author: mgoertz-msft
ms.author: mgoertz
manager: jmartens
ms.technology: vs-ide-modeling
ms.workload:
- multiple
---
# VS Shell deployment

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

An isolated shell lets you determine which Visual Studio functionality you need to interact with your domain-specific language and how that solution should appear. For more information about the Visual Studio isolated shell, see [Customizing the Isolated Shell](https://visualstudio.microsoft.com/vs/older-downloads/isolated-shell/).

To set a Visual Studio Shell as the deployment target:

1. In the **DslPackage** project, open **source.extension.tt**.

2. Under `<SupportedProducts>` insert:

   ```xml
   <IsolatedShell Version="1.0">MyIsolatedShell</IsolatedShell>
   ```

   Replace *MyIsolatedShell* with the name of your isolated shell package.