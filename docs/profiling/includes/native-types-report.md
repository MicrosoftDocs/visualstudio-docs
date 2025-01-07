---
title: Native Types report
 description: Native Types report in the Memory Usage tool
 services: ""
 author: mikejo5000
 ms.service: ""
 ms.topic: include
 ms.date: 02/06/2024
 ms.author: mikejo
 ms.custom: include file
---

Choose the current link of an **Allocations (Diff)** or **Heap Size (Diff)** cell in the Memory Usage summary table of the **Diagnostic Tools** window.

::: moniker range=">=vs-2022"

[![Screenshot of Native Type View.](../media/vs-2022/dbgdiag-mem-native-types-view.png)](../media/vs-2022/dbgdiag-mem-native-types-view.png#lightbox)

::: moniker-end
::: moniker range="<=vs-2019"

[![Screenshot of Native Type View.](../media/vs-2019/dbgdiag-mem-native-types-view.png)](../media/vs-2019/dbgdiag-mem-native-types-view.png#lightbox)

::: moniker-end

The **Types View** displays the number and size of the types in the snapshot.

::: moniker range=">=vs-2022"

- Choose the **View Instances** icon next to a selected type to display information about the objects of the selected type in the snapshot.

     The **Instances** view displays each instance of the selected type. Selecting an instance displays the call stack that resulted in the creation of the instance in the **Allocation Call Stack** pane. (This information is only available while debugging.)

     [![Screenshot of the Instances view and Allocation Call Stack pane.](../media/vs-2022/dbgdiag-mem-native-instances.png)](../media/vs-2022/dbgdiag-mem-native-instances.png#lightbox)

::: moniker-end

::: moniker range="<=vs-2019"

- Choose the instances icon (![The instance icon in the Object Type column](../media/dbg-mma-instances-icon.png "DBG_MMA_InstancesIcon")) of a selected type to display information about the objects of the selected type in the snapshot.

     The **Instances** view displays each instance of the selected type. Selecting an instance displays the call stack that resulted in the creation of the instance in the **Allocation Call Stack** pane.

     ![Screenshot of the Instances view and Allocation Call Stack pane.](../media/vs-2019/dbgdiag-mem-native-instances.png)

::: moniker-end

::: moniker range=">=vs-2022"

- Choose **Stacks** to see the allocation stack for the selected type.

     [![Screenshot of Stacks view.](../media/vs-2022/dbgdiag-mem-native-stacks-view.png)](../media/vs-2022/dbgdiag-mem-native-stacks-view.png#lightbox)

::: moniker-end

::: moniker range="<=vs-2019"

- Choose **Stacks View** in the **View Mode** list to see the allocation stack for the selected type.

     ![Screenshot of Stacks view.](../media/vs-2019/dbgdiag-mem-native-stacks-view.png)

::: moniker-end