---
title: "IApplicationDebuggerUI Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IApplicationDebuggerUI interface"
ms.assetid: b8828817-ca24-4012-802c-7dcaeea65dc8
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IApplicationDebuggerUI Interface
Implemented by the debugger integrated development environment (IDE) (in addition to `IApplicationDebugger`) to give an external component more control over the user interface (UI) of the debugger.  
  
 In addition to the methods inherited from `IUnknown`, the `IApplicationDebuggerUI` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IApplicationDebuggerUI::BringDocumentToTop](../../winscript/reference/iapplicationdebuggerui-bringdocumenttotop.md)|Brings the window containing the specified debug document to the top in the debugger user interface.|  
|[IApplicationDebuggerUI::BringDocumentContextToTop](../../winscript/reference/iapplicationdebuggerui-bringdocumentcontexttotop.md)|Brings the window containing the given document context to the top in the debugger user interface and scrolls the window to the context.|