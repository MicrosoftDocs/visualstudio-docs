---
title: "Type Collection Editor Dialog Box"
ms.custom: ""
ms.date: "10/19/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "TypeCollectionEditor.UI"
ms.assetid: 63cdea6b-bca2-4c06-b8b4-c8faabd40726
caps.latest.revision: 4
ms.author: "erikre"
manager: "erikre"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Type Collection Editor Dialog Box
The **Type Collection Editor** dialog box is used to add known types to the **Send** and **Receive** activities. This dialog is also used to add generic type arguments to the **InvokeMethod** activity. When used for the **Send** and **Receive** activities to add known types, the **Type Collection Editor** dialog box requires the type additions to be unique. If a duplicate type is added and the change is committed by clicking **OK**, an error message is returned. When used for the **InvokeMethod** activity to add generic type arguments, the **Type Collection Editor** dialog box allows the addition of duplicate types.  
  
> [!NOTE]
>  [!INCLUDE[crabout](../test/includes/crabout_md.md)] known types, see [Data Contract Known Types](../Topic/Data%20Contract%20Known%20Types.md).  
  
 The following table describes the user interface (UI) elements of the **Type Collection** dialog box.  
  
|UI Element|Description|  
|----------------|-----------------|  
|**Type List**|A list of the types that have been added or removed.|  
  
## To bring up the Type Collection Editor  
  
#### To bring up the Type Collection Editor for the Send and Receive activities  
  
1.  Select the **Send** or **Receive** activity in the design view.  
  
2.  Press **F4** to bring up the **Properties** window.  
  
3.  In the **Properties** window, click the ellipsis button next to the **KnownTypes** property.  
  
#### To bring up the Type Collection Editor for the InvokeMethod activity  
  
1.  Select the **InvokeMethod** activity in the design view.  
  
2.  Press **F4** to bring up the **Properties** window.  
  
3.  In the **Properties** window, click the ellipsis button next to the **GenericTypeArguments** property.