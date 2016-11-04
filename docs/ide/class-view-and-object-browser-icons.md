---
title: "Class View and Object Browser Icons | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "icons, in Object Browser"
  - "signal icons"
  - "Class View tool, symbols"
  - "graphic symbols"
  - "IntelliSense, icons"
  - "icons, IntelliSense"
  - "symbols, Object Browser icons"
  - "Object Browser, icons in Class View"
ms.assetid: 58cc3f44-c296-4a88-a008-09d28598d9c0
caps.latest.revision: 20
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
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
# Class View and Object Browser Icons
**Class View** and the **Object Browser** display icons that represent code entities, for example, namespaces, classes, functions, and variables. The following table illustrates and describes the icons.  
  
|Icon|Description|Icon|Description|  
|----------|-----------------|----------|-----------------|  
|![Namespace Symbol](../ide/media/vxnamespace_icon.gif "vxNamespace_Icon")|Namespace|![Declaration Symbol](../ide/media/vxmethod_icon.gif "vxMethod_Icon")|Method or Function|  
|![Class Icon](../ide/media/vxclass_icon.gif "vxClass_Icon")|Class|![Operator Symbol](../ide/media/vxoperator_icon.gif "vxOperator_Icon")|Operator|  
|![Lollipop Interface Symbol](../ide/media/vxinterface_icon.gif "vxInterface_Icon")|Interface|![Property Symbol](../ide/media/vxproperty_icon.gif "vxProperty_Icon")|Property|  
|![Structure Symbol](../ide/media/vxstruct_icon.gif "vxStruct_Icon")|Structure|![Field Icon](../ide/media/vxfield_icon.gif "vxField_Icon")|Field or Variable|  
|![Union Symbol](../ide/media/vxunion_icon.gif "vxUnion_Icon")|Union|![Event Symbol](../ide/media/vxevent_icon.gif "vxEvent_Icon")|Event|  
|![Enumeration Symbol](../ide/media/vxenum_icon.gif "vxEnum_Icon")|Enum|![Constant Icon](../ide/media/vxconstant_icon.gif "vxConstant_Icon")|Constant|  
|![Type Definition Symbol](../ide/media/vxtypedef_icon.gif "vxTypeDef_Icon")|TypeDef|![Enumerate Item Symbol](../ide/media/vxenumitem_icon.gif "vxEnumItem_Icon")|Enum Item|  
|![Visual Studio Module Symbol](../ide/media/vxmodule_icon.gif "vxModule_Icon")|Module|![Map Item Symbol](../ide/media/vxmapitem_icon.gif "vxMapItem_Icon")|Map Item|  
|![Extension Method Symbol](../ide/media/extensionmethod.gif "ExtensionMethod")|Extension Method|![Declaration Symbol](../ide/media/vxmethod_icon.gif "vxMethod_Icon")|External Declaration|  
|![Delegate Symbol](../ide/media/vxdelegate_icon.gif "vxDelegate_Icon")|Delegate|![Error Icon for Class View and Object Browser](../ide/media/erroricon.gif "ErrorIcon")|Error|  
|![Exception Symbol](../ide/media/vxexception_icon.gif "vxException_Icon")|Exception|![Template Symbol](../ide/media/vxtemplate_icon.gif "vxTemplate_Icon")|Template|  
|![Map Symbol](../ide/media/vxmap_icon.gif "vxMap_Icon")|Map|![Error Exclamation Point Symbol](../ide/media/vxerror_icon.gif "vxError_Icon")|Unknown|  
|![Type Forwarding Symbol](../ide/media/ob_type_forward.gif "ob_type_forward")|Type Forwarding|||  
  
## Signal Icons  
 The following signal icons apply to all the previous icons and indicate their accessibility.  
  
> [!NOTE]
>  If your project is included in a source control database, additional signal icons may be displayed to indicate source-control status, such as checked in or checked out.  
  
|Icon|Description|  
|----------|-----------------|  
|\<No Signal Icon>|Public. Accessible from anywhere in this component and from any component that references it.|  
|![Signal Protected Symbol](../ide/media/vxsignal_icon_key.gif "vxSignal_Icon_Key")|Protected. Accessible from the containing class or type, or those derived from the containing class or type.|  
|![Signal Private Symbol](../ide/media/vxsignal_icon_lock.gif "vxSignal_Icon_Lock")|Private. Accessible only in the containing class or type.|  
|![Signal Sealed Symbol](../ide/media/vxsignal_icon_envelope.gif "vxSignal_Icon_Envelope")|Sealed.|  
|![Signal Friend&#47;Internal Symbol](../ide/media/vxsignal_icon_diamond.gif "vxSignal_Icon_Diamond")|Friend/Internal. Accessible only from the project.|  
|![Signal Icon Arrow](../ide/media/vxsignal_icon_arrow.gif "vxSignal_Icon_Arrow")|Shortcut. A shortcut to the object.|  
  
## See Also  
 [Viewing the Structure of Code](../ide/viewing-the-structure-of-code.md)