---
title: Change (Diff) report
 description: Change (Diff) report in the Memory Usage tool
 services: ""
 author: mikejo5000
 ms.service: ""
 ms.topic: include
 ms.date: 02/06/2024
 ms.author: mikejo
 ms.custom: include file
---

The change report adds columns (marked with **(Diff)**) to the base report that show the difference between the base snapshot value and the comparison snapshot. Here's how a Native Type View diff report might look:

::: moniker range=">=vs-2022"

[![Screenshot of Native Types Diff View.](../media/vs-2022/dbgdiag-mem-native-types-view-diff.png "Native Types Diff View")](../media/vs-2022/dbgdiag-mem-native-types-view-diff.png#lightbox)

::: moniker-end

::: moniker range="vs-2019"

![Screenshot of Native Types Diff View.](../media/vs-2019/dbgdiag-mem-native-types-view-diff.png)

::: moniker-end

The top pane shows the count and size of the types in the snapshot, including the size of all objects that are referenced by the type (**Inclusive Size**).