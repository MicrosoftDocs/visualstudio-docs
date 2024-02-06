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

- Choose the change link in a cell of the summary table of the **Memory Usage** tab on the **Diagnostic Tools** window.

   ::: moniker range="<=vs-2019"

   ![Screenshot of Choose a change link in a cell.](../media/vs-2019/dbgdiag-mem-choose-diff-report.png)

   ::: moniker-end

   ::: moniker range=">=vs-2022"

   ![Screenshot of Choose a change link in a cell.](../media/vs-2022/dbgdiag-mem-choose-diff-report.png)

   ::: moniker-end

- Choose a snapshot in the **Compare To** list of a managed or native report.

   ::: moniker range="<=vs-2019"

   ![Screenshot of Choose a snapshot from the Compare To list.](../media/vs-2019/dbgdiag-mem-choose-compare-to.png)

   ::: moniker-end

   ::: moniker range=">=vs-2022"

   ![Screenshot of Choose a snapshot from the Compare with list.](../media/vs-2022/dbgdiag-mem-choose-compare-to.png)

   ::: moniker-end

The change report adds columns (marked with **(Diff)**) to the base report that show the difference between the base snapshot value and the comparison snapshot. Here's how a Native Type View diff report might look:

::: moniker range="<=vs-2019"

![Screenshot of Native Types Diff View.](../media/vs-2019/dbgdiag-mem-native-types-view-diff.png)

::: moniker-end

::: moniker range=">=vs-2022"

[![Screenshot of Native Types Diff View.](../media/vs-2022/dbgdiag-mem-native-types-view-diff.png "Native Types Diff View")](../media/vs-2022/dbgdiag-mem-native-types-view-diff.png#ligtbox)

::: moniker-end