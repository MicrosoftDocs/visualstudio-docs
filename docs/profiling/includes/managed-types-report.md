---
title: Managed Types report
 description: Managed Types report in the Memory Usage tool
 services: ""
 author: mikejo5000
 ms.service: ""
 ms.topic: include
 ms.date: 02/06/2024
 ms.author: mikejo
 ms.custom: include file
---

 Choose the current link of an **Objects (Diff)** cell in the Memory Usage summary table.

 ::: moniker range=">=vs-2022"

 [![Screenshot of managed type report.](../media/vs-2022/dbgdiag-mem-managed-types-report-paths-to-root.png "Managed type report")](../media/vs-2022/dbgdiag-mem-managed-types-report-paths-to-root.png#lightbox)

 > [!NOTE]
 > For .NET code, the **View Instances** icon (![The instance icon in the Object Type column](../media/dbg-mma-instances-icon.png "DBG_MMA_InstancesIcon")) is only available while using the [debugger-integrated Memory Usage tool](../../profiling/memory-usage.md) or when you open a [heap snapshot](../../debugger/using-dump-files.md) and choose **Debug Managed Memory**.

 The top pane shows the count and size of the types in the snapshot, including the size of all objects that are referenced by the type (**Inclusive Size**).

 The **Paths to Root** tree in the bottom pane displays the objects that reference the type selected in the upper pane. The .NET garbage collector cleans up the memory for an object only when the last type that references it has been released. For more information on using the **Paths to Root** tree, see [Analyze hot path to root](../../profiling/hot-path-to-root.md).

 ::: moniker-end

 ::: moniker range="vs-2019"

 ![Screenshot of managed type report.](../media/vs-2019/dbgdiag-mem-managed-types-report-paths-to-root.png)

 The top pane shows the count and size of the types in the snapshot, including the size of all objects that are referenced by the type (**Inclusive Size**).

 The **Paths to Root** tree in the bottom pane displays the objects that reference the type selected in the upper pane. The .NET garbage collector cleans up the memory for an object only when the last type that references it has been released.

 ::: moniker-end

 ::: moniker range=">=vs-2022"

 The **Referenced Types** tree displays the references that are held by the type selected in the upper pane.

 ![Screenshot of Referenced Objects report.](../media/vs-2022/dbgdiag-mem-managed-types-report-referenced-types.png)

 ::: moniker-end
 ::: moniker range="vs-2019"

 The **Referenced Types** tree displays the references that are held by the type selected in the upper pane.

 ![Screenshot of Referenced Objects report.](../media/vs-2019/dbgdiag-mem-managed-types-report-referenced-types.png)

 ::: moniker-end