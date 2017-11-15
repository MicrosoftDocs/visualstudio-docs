---
title: "Visual Studio C++ Core Check Reference | Microsoft Docs"
ms.custom: ""
ms.date: "11/15/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-code-analysis"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "code analysis, C++ core check"
ms.assetid: f1429463-136e-41ed-8a75-a8dbf0b4fd89
author: mikeblome
ms.author: mblome
manager: ghogen
---
# C++ Core Check Reference
This section lists C++ Core Guidelines Checker warnings. For information about Code Analysis, see [/analyze (Code Analysis)](/cpp/build/reference/analyze-code-analysis) and [Quick Start: Code Analysis for C/C++](../code-quality/quick-start-code-analysis-for-c-cpp.md).  
  
**Note**: Some warnings belong to more than one group, and not all warnings have a reference topic.

## OWNER_POINTER Group
 	 
[C26403 RESET_OR_DELETE_OWNER](C26403.md):  
  [Reset or explicitly delete an owner<T> pointer '%variable%'](r.3: http://go.microsoft.com/fwlink/?linkid=845471)
 	 
[C26404 DONT_DELETE_INVALID](C26404.md):  
  [Do not delete an owner<T> which may be in invalid state](r.3: http://go.microsoft.com/fwlink/?linkid=845471)

[C26405 DONT_ASSIGN_TO_VALID](C26405.md):  
  [Do not assign to an owner<T> which may be in valid state](r.3: http://go.microsoft.com/fwlink/?linkid=845471)

[C26406 DONT_ASSIGN_RAW_TO_OWNER](C26406.md):  
  [Do not assign a raw pointer to an owner<T>](r.3: http://go.microsoft.com/fwlink/?linkid=845471)
  
[C26407 DONT_HEAP_ALLOCATE_UNNECESSARILY](C26407.md):  
  [Prefer scoped objects, don't heap-allocate unnecessarily](r.5: http://go.microsoft.com/fwlink/?linkid=845473)

[C26429 USE_NOTNULL](C26429.md)  
  [Symbol '%symbol%' is never tested for nullness, it can be marked as not_null](f.23: http://go.microsoft.com/fwlink/?linkid=853921)

[C26430 TEST_ON_ALL_PATHS](C26430.md)  
  [Symbol '%symbol%' is not tested for nullness on all paths](f.23: http://go.microsoft.com/fwlink/?linkid=853921)
  
[C26431 DONT_TEST_NOTNULL](C26431.md)  
  [The type of expression '%expr%' is already gsl::not_null. Do not test it for nullness](f.23: http://go.microsoft.com/fwlink/?linkid=853921)

## RAW_POINTER Group
  
[C26408 NO_MALLOC_FREE](C26408.md):  
  [Avoid malloc() and free(), prefer the nothrow version of new with delete](r.10 http://go.microsoft.com/fwlink/?linkid=845483)
  
[C26409 NO_NEW_DELETE](C26409.md):  
  [Avoid calling new and delete explicitly, use std::make_unique<T> instead](r.11 http://go.microsoft.com/fwlink/?linkid=845485)

[C26429 USE_NOTNULL](C26429.md)  
  [Symbol '%symbol%' is never tested for nullness, it can be marked as not_null](f.23: http://go.microsoft.com/fwlink/?linkid=853921)
  
[C26430 TEST_ON_ALL_PATHS](C26430.md)  
  [Symbol '%symbol%' is not tested for nullness on all paths](f.23: http://go.microsoft.com/fwlink/?linkid=853921)
  
[C26431 DONT_TEST_NOTNULL](C26431.md)  
  [The type of expression '%expr%' is already gsl::not_null. Do not test it for nullness](f.23: http://go.microsoft.com/fwlink/?linkid=853921)
  
[C26481 NO_POINTER_ARITHMETIC](C26481.md):  
  [Don't use pointer arithmetic. Use span instead](bounds.1: http://go.microsoft.com/fwlink/p/?LinkID=620413)

[C26485 NO_ARRAY_TO_POINTER_DECAY](C26485.md) 
  [Expression '%expr%': No array to pointer decay](bounds.3: http://go.microsoft.com/fwlink/p/?LinkID=620415)

## UNIQUE_POINTER Group
  
[C26410 NO_REF_TO_CONST_UNIQUE_PTR](C26410.md):  
  [The parameter '%parameter%' is a reference to const unique pointer, use const T* or const T& instead](r.32 http://go.microsoft.com/fwlink/?linkid=845478)
 	 
[C26411 NO_REF_TO_UNIQUE_PTR](C26411.md):  
  [The parameter '%parameter%' is a reference to unique pointer and it is never reassigned or reset, use T* or T& instead](r.33 http://go.microsoft.com/fwlink/?linkid=845479)
 	 
[C26414 RESET_LOCAL_SMART_PTR](C26414.md)  
  [Move, copy, reassign or reset a local smart pointer '%symbol%'](r.5: http://go.microsoft.com/fwlink/?linkid=845473)
	
[C26415 SMART_PTR_NOT_NEEDED](C26415.md)  
  [Smart pointer parameter '%symbol%' is used only to access contained pointer. Use T* or T& instead](r.30: http://go.microsoft.com/fwlink/?linkid=845475)

## SHARED_POINTER Group

[C26414 RESET_LOCAL_SMART_PTR](C26414.md)  
  [Move, copy, reassign or reset a local smart pointer '%symbol%'](r.5: http://go.microsoft.com/fwlink/?linkid=845473)
	
[C26415 SMART_PTR_NOT_NEEDED](C26415.md)  
  [Smart pointer parameter '%symbol%' is used only to access contained pointer. Use T* or T& instead](r.30: http://go.microsoft.com/fwlink/?linkid=845475)
	
[C26416 NO_RVALUE_REF_SHARED_PTR](C26416.md)  
  [Shared pointer parameter '%symbol%' is passed by rvalue reference. Pass by value instead](r.34: http://go.microsoft.com/fwlink/?linkid=845486)
  
[C26417 NO_LVALUE_REF_SHARED_PTR](C26417.md)  
  [Shared pointer parameter '%symbol%' is passed by reference and not reset or reassigned. Use T* or T& instead](r.35: http://go.microsoft.com/fwlink/?linkid=845488)
  
[C26418 NO_VALUE_OR_CONST_REF_SHARED_PTR](C26418.md)  
  [Shared pointer parameter '%symbol%' is not copied or moved. Use T* or T& instead](r.36: http://go.microsoft.com/fwlink/?linkid=845489)

## DECLARATION Group
	
[C26426 NO_GLOBAL_INIT_CALLS](C26426.md)  
  [Global initializer calls a non-constexpr function '%symbol%'](i.22: http://go.microsoft.com/fwlink/?linkid=853919)
  
[C26427 NO_GLOBAL_INIT_EXTERNS](C26427.md)  
  [Global initializer accesses extern object '%symbol%'](i.22: http://go.microsoft.com/fwlink/?linkid=853919)
  
## CLASS Group
	
[C26432 DEFINE_OR_DELETE_SPECIAL_OPS](C26432.md)  
  [If you define or delete any default operation in the type '%symbol%', define or delete them all](c.21: http://go.microsoft.com/fwlink/?linkid=853922)
  
[C26434 DONT_HIDE_METHODS](C26434.md)  
  [Function '%symbol_1%' hides a non-virtual function '%symbol_2%'](c.128: http://go.microsoft.com/fwlink/?linkid=853923)
  
[C26436 NEED_VIRTUAL_DTOR](C26436.md)  
  [The type '%symbol%' with a virtual function needs either public virtual or protected nonvirtual destructor](c.35: http://go.microsoft.com/fwlink/?linkid=853924)

## TYPE Group
	
[C26437 DONT_SLICE](C26437.md)  
  [Do not slice](es.63: http://go.microsoft.com/fwlink/?linkid=853925).

## STYLE Group	
[C26438 NO_GOTO](C26438.md)  
  [Avoid 'goto'](es.76: http://go.microsoft.com/fwlink/?linkid=853926).
  
## FUNCTION Group
	
[C26439 SPECIAL_NOEXCEPT](C26439.md)  
[This kind of function may not throw. Declare it 'noexcept'](f.6: http://go.microsoft.com/fwlink/?linkid=853927)
  
[C26440 DECLARE_NOEXCEPT](C26440.md)  
[Function '%symbol%' can be declared 'noexcept'](f.6: http://go.microsoft.com/fwlink/?linkid=853927)

## CONCURRENCY Group
	
[C26441 NO_UNNAMED_GUARDS](C26441.md)  
 [Guard objects must be named](cp.44: http://go.microsoft.com/fwlink/?linkid=853928)

## CONST Group
	
C26460 USE_CONST_REFERENCE_ARGUMENTS:  
  [The reference argument '%argument%' for function '%function%' can be marked as const](con.3: https://go.microsoft.com/fwlink/p/?LinkID=786684)
  
C26461 USE_CONST_POINTER_ARGUMENTS: 
  [The pointer argument '%argument%' for function '%function%' can be marked as a pointer to const](con.3: https://go.microsoft.com/fwlink/p/?LinkID=786684) 
  
C26462 USE_CONST_POINTER_FOR_VARIABLE:  
  [The value pointed to by '%variable%' is assigned only once, mark it as a pointer to const](con.4: https://go.microsoft.com/fwlink/p/?LinkID=784969)
  
C26463 USE_CONST_FOR_ELEMENTS:  
  [The elements of array '%array%' are assigned only once, mark elements const](con.4: https://go.microsoft.com/fwlink/p/?LinkID=784969)
  
C26464 USE_CONST_POINTER_FOR_ELEMENTS:  
  [The values pointed to by elements of array '%array%' are assigned only once, mark elements as pointer to const](con.4: https://go.microsoft.com/fwlink/p/?LinkID=784969)

C26496 USE_CONST_FOR_VARIABLE:  
  [The variable '%variable%' is assigned only once, mark it as const](con.4: https://go.microsoft.com/fwlink/p/?LinkID=784969) 
  
C26497 USE_CONSTEXPR_FOR_FUNCTION:  
  [This function %function% could be marked constexpr if compile-time evaluation is desired](f.4: https://go.microsoft.com/fwlink/p/?LinkID=784970)
  
C26498 USE_CONSTEXPR_FOR_FUNCTIONCALL:  
  [This function call %function% can use constexpr if compile-time evaluation is desired](con.5: https://go.microsoft.com/fwlink/p/?LinkID=784974)

## TYPE Group
C26465 NO_CONST_CAST_UNNECESSARY:  
  [Don't use const_cast to cast away const. const_cast is not required; constness or volatility is not being removed by this conversion](type.3: http://go.microsoft.com/fwlink/p/?LinkID=620419)
  
C26466 NO_STATIC_DOWNCAST_POLYMORPHIC:  
  [Don't use static_cast downcasts. A cast from a polymorphic type should use dynamic_cast](type.2: http://go.microsoft.com/fwlink/p/?LinkID=620418)
  
C26471 NO_REINTERPRET_CAST_FROM_VOID_PTR:  
  [Don't use reinterpret_cast. A cast from void* can use static_cast](type.1: http://go.microsoft.com/fwlink/p/?LinkID=620417)
  
[C26472 NO_CASTS_FOR_ARITHMETIC_CONVERSION](C26472.md)  
  [Don't use a static_cast for arithmetic conversions. Use brace initialization, gsl::narrow_cast or gsl::narow](type.1: http://go.microsoft.com/fwlink/p/?LinkID=620417)
  
[C26473 NO_IDENTITY_CAST](C26473.md)  
  [Don't cast between pointer types where the source type and the target type are the same](type.1: http://go.microsoft.com/fwlink/p/?LinkID=620417)
  
[C26474 NO_IMPLICIT_CAST](C26474.md)  
  [Don't cast between pointer types when the conversion could be implicit](type.1: http://go.microsoft.com/fwlink/p/?LinkID=620417)
  
[C26475 NO_FUNCTION_STYLE_CASTS](C26475.md)  
  Do not use function style C-casts (es.49: http://go.microsoft.com/fwlink/?linkid=853930).
 	 
C26490 NO_REINTERPRET_CAST:  
  [Don't use reinterpret_cast](type.1: http://go.microsoft.com/fwlink/p/?LinkID=620417)
  
C26491 NO_STATIC_DOWNCAST:  
  [Don't use static_cast downcasts](type.2: http://go.microsoft.com/fwlink/p/?LinkID=620418)
  
C26492 NO_CONST_CAST:  
  [Don't use const_cast to cast away const](type.3: http://go.microsoft.com/fwlink/p/?LinkID=620419)
	
C26493 NO_CSTYLE_CAST:  
  [Don't use C-style casts](type.4: http://go.microsoft.com/fwlink/p/?LinkID=620420) 
 	 
C26494 VAR_USE_BEFORE_INIT:  
  [Variable '%variable%' is uninitialized. Always initialize an object](type.5: http://go.microsoft.com/fwlink/p/?LinkID=620421)
  
C26495 MEMBER_UNINIT:  
  [Variable '%variable%' is uninitialized. Always initialize a member variable](type.6: http://go.microsoft.com/fwlink/p/?LinkID=620422)
  
## BOUNDS Group

[C26481 NO_POINTER_ARITHMETIC](C26481.md) 
  [Don't use pointer arithmetic. Use span instead](bounds.1: http://go.microsoft.com/fwlink/p/?LinkID=620413)
  
C26482 NO_DYNAMIC_ARRAY_INDEXING:  
  [Only index into arrays using constant expressions](bounds.2: http://go.microsoft.com/fwlink/p/?LinkID=620414)
  
C26483 STATIC_INDEX_OUT_OF_RANGE:  
  [Value %value% is outside the bounds (0, %bound%) of variable '%variable%'. Only index into arrays using constant expressions that are within bounds of the array](bounds.2: http://go.microsoft.com/fwlink/p/?LinkID=620414)

[C26485 NO_ARRAY_TO_POINTER_DECAY](C26485.md) 
  [Expression '%expr%': No array to pointer decay](bounds.3: http://go.microsoft.com/fwlink/p/?LinkID=620415)
  
## See Also  
[Using the C++ Core Guidelines Checker](using-the-cpp-core-guidelines-checker.md)