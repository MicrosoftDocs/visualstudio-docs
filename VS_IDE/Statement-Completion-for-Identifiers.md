---
title: "Statement Completion for Identifiers"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c2cd4945-c67e-471b-8057-96cfd25f7fb2
caps.latest.revision: 13
manager: ghogen
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
# Statement Completion for Identifiers
JavaScript doesn't allow explicit typing for variable declarations. As a result, IntelliSense can't always provide completion lists for objects. This can occur in various situations. Following are a few common ones.  
  
-   A parameter is declared, but it has not been called elsewhere in the active document, as shown in the following example.  
  
    ```javascript  
    function illuminate(light) {  
             light.  // Accurate statement completion is not available   
                     // unless illuminate is called elsewhere with a   
                     // parameter that has a value. If it is called only  
                     // in a function that is a sibling to   
                     // illuminate(light) in the call hierarchy, the   
                     // IntelliSense engine also cannot determine the   
                     // parameter type.  
         }  
  
    // Sibling function. No statement completion for light   
    // object in preceding code.  
    function lightLamp() {  
        var x = illuminate(1);  
    }  
  
    // Uncomment the next line to obtain statement completion for  
    // light object in preceding code.  
    // var x = illuminate(1);  
    ```  
  
-   An object is in a function that is called in response to an event. At design time, the IntelliSense engine cannot determine the type of the objects used in this situation.  
  
     If the IntelliSense engine can determine that the event should be called, typically through the use of `addEventListener` for the event in the active document, more accurate IntelliSense information is provided.  
  
 When IntelliSense is unable to identify an object, the IntelliSense engine populates the completion list with named entities, or identifiers, that are present in the active document. When the completion list contains these identifiers, information icons appear next to them. In addition, a tooltip for each identifier indicates that the expression is unknown. The following illustration shows statement completion options for an object of type `light` that can't be identified because the object and its properties are undefined. However, the `intensity` property is available in the identifier list because it has been used in the `illuminate` function.  
  
 **Completion options for an object that can't be identified**  
  
 ![JavaScript IntelliSense for identifiers](../VS_IDE/media/js_intellisense_identifiers.png "js_intellisense_identifiers")  
  
 You can override the completion list for an object by using XML documentation comments or JavaScript IntelliSense extensibility features. Using these features, you can provide type information and more descriptive IntelliSense information when it might not otherwise be available. For more information, see [Extending JavaScript IntelliSense](../VS_IDE/Extending-JavaScript-IntelliSense.md) and [Create XML Documentation Comments](../VS_IDE/Create-XML-Documentation-Comments-for-JavaScript-IntelliSense.md).  
  
## See Also  
 [JavaScript IntelliSense](../VS_IDE/JavaScript-IntelliSense.md)