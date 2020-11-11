---
title: "Saving Symbol Information with Performance Data Files | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "packsymbols, in profiling tools reports"
  - "profiling tools, packsymbols"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Saving Symbol Information with Performance Data Files

If you are using the Visual Studio IDE to analyze files and you plan to move your VSP file to a different computer, you must set the performance project settings to save or *serialize* symbols in your report file. This increases the size of a report file. Serializing symbols is necessary for two reasons:

- To embed code symbols into a performance report before the target assemblies are lost from their location in temporary storage.

- To preserve symbols, so that the performance report is portable from the profiled computer and outputs the same information if the report is opened for analysis on another computer, which might have different symbols.

You can serialize symbols from the Visual Studio IDE or from the command-line:

- To serialize symbols in the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] IDE, point to **Tools** on the menu bar, and then click **Options**. In the **Options** window, select **Performance Tools**, and then select the **Automatically serialize symbol information** check box.

- PACKSYMBOLS is the equivalent command-line option when you save report files. To serialize symbols, type **vsperfreport /summary:all /packsymbols filename.vsp**.

## Troubleshooting Symbol Problems

If you do not see any symbols in your own code, some common solutions are available:

- Run vsperfreport /debugsympath at a command line to display a complete list of the locations where profiler components are loading symbol information and whether the symbol files that are used match the files that your project is using.

- Make sure that you run vsperfreport with the /PACKSYMBOLS flag or, in the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] IDE, that you have the serialize symbol information option selected in the general performance explorer options.

- If you collected type data, add /SUMMARY:TYPE to the vsperfreport command line.

  If you do not see symbols from Windows or other Microsoft programs:

- Make sure that you have set the path of your Windows symbol cache. Do one of the following to set the symbol cache path:

  - Set the Debugger->Symbols option in the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] IDE to the correct path.

  - Add the -symbolpath option to the VSPerfReport command line to include your symbols.

- If you do not see any symbols in [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)], make sure that you have the symbol server set up correctly for the ASP server.

## Repacking Symbols

If you want to repack symbols into a report, you can do this by using the command line tool VsPerfReport. Use the following command lines:

VsPerfReport -clearpackedsymbols filename.vsp

VsPerfReport -packsymbols -summary:all filename.vsp

## See also

[Saving and Exporting Performance Tools Data](../profiling/saving-and-exporting-performance-tools-data.md)
[How to: Reference Windows Symbol Information](../profiling/how-to-reference-windows-symbol-information.md)
[VSPerfReport](../profiling/vsperfreport.md)
