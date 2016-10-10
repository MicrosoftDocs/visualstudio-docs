---
title: "Annotating Structs and Classes"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b8278a4a-c86e-4845-aa2a-70da21a1dd52
caps.latest.revision: 9
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Annotating Structs and Classes
You can annotate struct and class members by using annotations that act like invariants—they are presumed to be true at any function call or function entry/exit that involves the enclosing structure as a parameter or a result value.  
  
## Struct and Class Annotations  
  
-   `_Field_range_(low, high)`  
  
     The field is in the range (inclusive) from `low` to `high`.  Equivalent to `_Satisfies_(_Curr_ >= low && _Curr_ <= high)` applied to the annotated object by using the appropriate pre or post conditions.  
  
-   `_Field_size_(size)`, `_Field_size_opt_(size)`, `_Field_size_bytes_(size)`, `_Field_size_bytes_opt_(size)`  
  
     A field that has a writable size in elements (or bytes) as specified by `size`.  
  
-   `_Field_size_part_(size, count)`, `_Field_size_part_opt_(size, count)`,         `_Field_size_bytes_part_(size, count)`, `_Field_size_bytes_part_opt_(size, count)`  
  
     A field that has a writable size in elements (or bytes) as specified by `size`, and the `count` of those elements (bytes) that are readable.  
  
-   `_Field_size_full_(size)`, `_Field_size_full_opt_(size)`, `_Field_size_bytes_full_(size)`, `_Field_size_bytes_full_opt_(size)`  
  
     A field that has both readable and writable size in elements (or bytes) as specified by `size`.  
  
-   `_Struct_size_bytes_(size)`  
  
     A field that has both readable and writable size in elements (or bytes) as specified by `size`.  
  
     Applies to struct or class declaration.  Indicates that a valid object of that type may be larger than the declared type, with the number of bytes being specified by `size`.  For example:  
  
    ```cpp  
  
    typedef _Struct_size_bytes_(nSize)  
    struct MyStruct {  
        size_t nSize;  
        …  
    };  
  
    ```  
  
     The buffer size in bytes of a parameter `pM` of type `MyStruct *` is then taken to be:  
  
    ```cpp  
    min(pM->nSize, sizeof(MyStruct))  
    ```  
  
## See Also  
 [Using SAL Annotations to Reduce C/C++ Code Defects](../VS_IDE/Using-SAL-Annotations-to-Reduce-C-C---Code-Defects.md)   
 [Understanding SAL](../VS_IDE/Understanding-SAL.md)   
 [Annotating Function Parameters and Return Values](../VS_IDE/Annotating-Function-Parameters-and-Return-Values.md)   
 [Annotating Function Behavior](../VS_IDE/Annotating-Function-Behavior.md)   
 [Annotating Locking Behavior](../VS_IDE/Annotating-Locking-Behavior.md)   
 [Specifying When and Where an Annotation Applies](../VS_IDE/Specifying-When-and-Where-an-Annotation-Applies.md)   
 [Intrinsic Functions](../VS_IDE/Intrinsic-Functions.md)   
 [Best Practices and Examples](../VS_IDE/Best-Practices-and-Examples--SAL-.md)