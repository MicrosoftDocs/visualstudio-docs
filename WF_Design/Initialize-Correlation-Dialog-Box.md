---
title: "Initialize Correlation Dialog Box"
ms.custom: na
ms.date: 10/04/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 2a0a1cd3-7b9e-493e-9264-fcf85289ffcf
caps.latest.revision: 6
manager: erikre
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Initialize Correlation Dialog Box
The **Initialize Correlation** dialog box is used in Windows Workflow Designer to edit the <xref:System.ServiceModel.Activities.InitializeCorrelation.CorrelationData?qualifyHint=False> property of an <xref:System.ServiceModel.Activities.InitializeCorrelation?qualifyHint=False> activity. For more information, see the [InitializeCorrelation](../WF_Design/InitializeCorrelation-Activity-Designer.md) topic.  
  
 The following table describes the user interface (UI) elements of the **Initialize Correlation** dialog box.  
  
|UI Element|Description|  
|----------------|-----------------|  
|**Correlation**|The <xref:System.ServiceModel.Activities.CorrelationHandle?qualifyHint=False> of the correlation to initialize.|  
|**Initialize On**|A key/value pair that contains the data to initialize. This corresponds to the <xref:System.ServiceModel.Activities.InitializeCorrelation.CorrelationData?qualifyHint=False> property. An example of a valid key/value pair would be a key named “OrderID” paired with a variable named OrderID.|  
  
## To launch the Initialize Correlation dialog box  
  
-   Click **View** on the **InitializeCorrelation** activity designer or select an <xref:System.ServiceModel.Activities.InitializeCorrelation?qualifyHint=False> activity in Workflow Designer and then click the ellipsis button next to the <xref:System.ServiceModel.Activities.InitializeCorrelation.CorrelationData?qualifyHint=False> property in the property grid.  
  
## See Also  
 [InitializeCorrelation](../WF_Design/InitializeCorrelation-Activity-Designer.md)