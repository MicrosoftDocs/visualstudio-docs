---
title: "Find potential problems using code map analyzers | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
f1_keywords: 
  - "vs.progression.codemapanalyzers"
helpviewer_keywords: 
  - "code analysis, dependency graphs"
  - "dependency graphs, analyzing code"
  - "graph documents, analyzing"
ms.assetid: 9dd799a7-f7eb-42ff-8612-b19dde7ff4eb
caps.latest.revision: 13
author: gewarren
ms.author: gewarren
manager: jillfra
---
# Find potential problems using code map analyzers
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Run analyzers on code maps to help you identify code that might be overly complex or that might need improvement. For example, you can use these analyzers:  
  
|**To find code that has**|**Examine these areas to see whether**|  
|-------------------------------|--------------------------------------------|  
|Loops or circular dependencies|You can simplify them and consider whether you can break these cycles.|  
|Too many dependencies|They are performing too many functions or to determine the impact of changing these areas. A well-formed code map will show a minimal number of dependencies. To make code easier to maintain, change, test, and reuse, consider whether you can refactor these areas so that they are more clearly defined, or whether you can merge code that performs similar functions.|  
|No dependencies|They are necessary or whether you should remove this code.|  
  
## Analyze code maps  
  
1. On the map toolbar, choose **Layout**, **Analyzers**, and then analyzer that you want to run:  
  
   |**Analyzer**|**To identify nodes that**|  
   |------------------|--------------------------------|  
   |**Circular References  Analyzer**|Have circular dependencies on each other. **Note:**  Circular dependencies that are in the **Generics** group are not shown on the map when you expand the group.|  
   |**Find Hubs Analyzer**|Are in the top 25% of highly-connected nodes<br /><br /> **To hide all other nodes on the map**<br /><br /> -   Open the shortcut menu for the map, choose **Advanced**, **Select**, **Hide Unselected**.<br />     The map hides the unselected nodes, and the analyzer identifies new nodes as hubs.|  
   |**Unreferenced Nodes Analyzer**|Do not have references from any other nodes. **Caution:**  Verify each of these cases before assuming that the code is not used. Certain dependencies such as XAML dependencies and run-time dependencies cannot be found statically in the code.|  
  
   Code map analyzers will continue to run after you apply them. If you change the map, any applied analyzers will automatically reprocess the updated map. To stop running an analyzer, on the map toolbar, choose **Layout**, **Analyzers**. Turn off the selected analyzer.  
  
> [!TIP]
> If you have a very large map, running an analyzer might cause an out of memory exception. If this occurs, edit the map to reduce its scope or generate a smaller one, and then run the analyzer.  
  
## See also  
 [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md)   
 [Use code maps to debug your applications](../modeling/use-code-maps-to-debug-your-applications.md)   
 [Map methods on the call stack while debugging](../debugger/map-methods-on-the-call-stack-while-debugging-in-visual-studio.md)
