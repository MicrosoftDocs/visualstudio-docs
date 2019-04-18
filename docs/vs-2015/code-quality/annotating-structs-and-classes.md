---
title: "Annotating Structs and Classes | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
f1_keywords: 
  - "_Field_size_bytes_part_"
  - "_Field_size_bytes_full_opt_"
  - "_Field_size_bytes_"
  - "_Field_size_opt_"
  - "_Field_size_part_"
  - "_Field_size_bytes_part_opt_"
  - "_Field_range_"
  - "_Field_size_part_opt_"
  - "_Field_size_"
  - "_Field_size_bytes_opt_"
  - "_Struct_size_bytes_"
  - "_Field_size_bytes_full_"
  - "_Field_size_full_"
  - "_Field_size_full_opt_"
ms.assetid: b8278a4a-c86e-4845-aa2a-70da21a1dd52
caps.latest.revision: 11
author: mikeblome
ms.author: mblome
manager: jillfra
---
# Annotating Structs and Classes
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can annotate struct and class members by using annotations that act like invariants—they are presumed to be true at any function call or function entry/exit that involves the enclosing structure as a parameter or a result value.  
  
## Struct and Class Annotations  
  
- `_Field_range_(low, high)`  
  
     The field is in the range (inclusive) from `low` to `high`.  Equivalent to `_Satisfies_(_Curr_ >= low && _Curr_ <= high)` applied to the annotated object by using the appropriate pre or post conditions.  
  
- `_Field_size_(size)`, `_Field_size_opt_(size)`, `_Field_size_bytes_(size)`, `_Field_size_bytes_opt_(size)`  
  
     A field that has a writable size in elements (or bytes) as specified by `size`.  
  
- `_Field_size_part_(size, count)`, `_Field_size_part_opt_(size, count)`,         `_Field_size_bytes_part_(size, count)`, `_Field_size_bytes_part_opt_(size, count)`  
  
     A field that has a writable size in elements (or bytes) as specified by `size`, and the `count` of those elements (bytes) that are readable.  
  
- `_Field_size_full_(size)`, `_Field_size_full_opt_(size)`, `_Field_size_bytes_full_(size)`, `_Field_size_bytes_full_opt_(size)`  
  
     A field that has both readable and writable size in elements (or bytes) as specified by `size`.  
  
- `_Struct_size_bytes_(size)`  
  
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
 [Using SAL Annotations to Reduce C/C++ Code Defects](../code-quality/using-sal-annotations-to-reduce-c-cpp-code-defects.md)   
 [Understanding SAL](../code-quality/understanding-sal.md)   
 [Annotating Function Parameters and Return Values](../code-quality/annotating-function-parameters-and-return-values.md)   
 [Annotating Function Behavior](../code-quality/annotating-function-behavior.md)   
 [Annotating Locking Behavior](../code-quality/annotating-locking-behavior.md)   
 [Specifying When and Where an Annotation Applies](../code-quality/specifying-when-and-where-an-annotation-applies.md)   
 [Intrinsic Functions](../code-quality/intrinsic-functions.md)   
 [Best Practices and Examples](../code-quality/best-practices-and-examples-sal.md)
