---
title: "Mixed Recommended Rules rule set"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c3186b5b-0149-4a75-826e-e3539e4e703f
caps.latest.revision: 3
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
# Mixed Recommended Rules rule set
The Microsoft Mixed Recommended Rules focus on the most common and critical problems in your C++ projects that support the Common Language Runtime, including potential security holes, application crashes, and other important logic and design errors. You should include this rule set in any custom rule set you create for your C++ projects that support the Common Language Runtime. This ruleset is designed to be configured with the Visual Studio Professional edition and higher.  
  
|Rule|Description|  
|----------|-----------------|  
|[C6001](../VS_IDE/C6001.md)|Using Uninitialized Memory|  
|[C6011](../VS_IDE/C6011.md)|Dereferencing Null Pointer|  
|[C6029](../VS_IDE/C6029.md)|Use Of Unchecked Value|  
|[C6031](../VS_IDE/C6031.md)|Return Value Ignored|  
|[C6053](../VS_IDE/C6053.md)|Zero Termination From Call|  
|[C6054](../VS_IDE/C6054.md)|Zero Termination Missing|  
|[C6059](../VS_IDE/C6059.md)|Bad Concatenation|  
|[C6063](../VS_IDE/C6063.md)|Missing String Argument To Format Function|  
|[C6064](../VS_IDE/C6064.md)|Missing Integer Argument To Format Function|  
|[C6066](../VS_IDE/C6066.md)|Missing Pointer Argument To Format Function|  
|[C6067](../VS_IDE/C6067.md)|Missing String Pointer Argument To Format Function|  
|[C6101](../VS_IDE/C6101.md)|Returning uninitialized memory|  
|[C6200](../VS_IDE/C6200.md)|Index Exceeds Buffer Maximum|  
|[C6201](../VS_IDE/C6201.md)|Index Exceeds Stack Buffer Maximum|  
|[C6214](../VS_IDE/C6214.md)|Invalid Cast HRESULT To BOOL|  
|[C6215](../VS_IDE/C6215.md)|Invalid Cast BOOL To HRESULT|  
|[C6216](../VS_IDE/C6216.md)|Invalid Compiler-Inserted Cast BOOL To HRESULT|  
|[C6217](../VS_IDE/C6217.md)|Invalid HRESULT Test With NOT|  
|[C6220](../VS_IDE/C6220.md)|Invalid HRESULT Compare To -1|  
|[C6226](../VS_IDE/C6226.md)|Invalid HRESULT Assignment To -1|  
|[C6230](../VS_IDE/C6230.md)|Invalid HRESULT Use As Boolean|  
|[C6235](../VS_IDE/C6235.md)|Non-Zero Constant With Logical-Or|  
|[C6236](../VS_IDE/C6236.md)|Logical-Or With Non-Zero Constant|  
|[C6237](../VS_IDE/C6237.md)|Zero With Logical-And Loses Side Effects|  
|[C6242](../VS_IDE/C6242.md)|Local Unwind Forced|  
|[C6248](../VS_IDE/C6248.md)|Creating Null DACL|  
|[C6250](../VS_IDE/C6250.md)|Unreleased Address Descriptors|  
|[C6255](../VS_IDE/C6255.md)|Unprotected Use Of Alloca|  
|[C6258](../VS_IDE/C6258.md)|Using Terminate Thread|  
|[C6259](../VS_IDE/C6259.md)|Dead Code In Bitwise-Or Limited Switch|  
|[C6260](../VS_IDE/C6260.md)|Use Of Byte Arithmetic|  
|[C6262](../VS_IDE/C6262.md)|Excessive Stack Usage|  
|[C6263](../VS_IDE/C6263.md)|Using Alloca In Loop|  
|[C6268](../VS_IDE/C6268.md)|Missing Parentheses In Cast|  
|[C6269](../VS_IDE/C6269.md)|Pointer Dereference Ignored|  
|[C6270](../VS_IDE/C6270.md)|Missing Float Argument To Format Function|  
|[C6271](../VS_IDE/C6271.md)|Extra Argument To Format Function|  
|[C6272](../VS_IDE/C6272.md)|Non-Float Argument To Format Function|  
|[C6273](../VS_IDE/C6273.md)|Non-Integer Argumen To Format Function|  
|[C6274](../VS_IDE/C6274.md)|Non-Character Argument To Format Function|  
|[C6276](../VS_IDE/C6276.md)|Invalid String Cast|  
|[C6277](../VS_IDE/C6277.md)|Invalid CreateProcess Call|  
|[C6278](../VS_IDE/C6278.md)|Array-New Scalar-Delete Mismatch|  
|[C6279](../VS_IDE/C6279.md)|Scalar-New Array-Delete Mismatch|  
|[C6280](../VS_IDE/C6280.md)|Memory Allocation-Deallocation Mismatch|  
|[C6281](../VS_IDE/C6281.md)|Bitwise Relation Precedence|  
|[C6282](../VS_IDE/C6282.md)|Assignment Replaces Test|  
|[C6283](../VS_IDE/C6283.md)|Primitive Array-New Scalar-Delete Mismatch|  
|[C6284](../VS_IDE/C6284.md)|Invalid Object Argument To Format Function|  
|[C6285](../VS_IDE/C6285.md)|Logical-Or Of Constants|  
|[C6286](../VS_IDE/C6286.md)|Non-Zero Logical-Or Losing Side Effects|  
|[C6287](../VS_IDE/C6287.md)|Redundant Test|  
|[C6288](../VS_IDE/C6288.md)|Mutual Inclusion Over Logical-And Is False|  
|[C6289](../VS_IDE/C6289.md)|Mutual Exclusion Over Logical-Or Is True|  
|[C6290](../VS_IDE/C6290.md)|Logical-Not Bitwise-And Precedence|  
|[C6291](../VS_IDE/C6291.md)|Logical-Not Bitwise-Or Precedence|  
|[C6292](../VS_IDE/C6292.md)|Loop Counts Up From Maximum|  
|[C6293](../VS_IDE/C6293.md)|Loop Counts Down From Minimum|  
|[C6294](../VS_IDE/C6294.md)|Loop Body Never Executed|  
|[C6295](../VS_IDE/C6295.md)|Infinite Loop|  
|[C6296](../VS_IDE/C6296.md)|Loop Only Executed Once|  
|[C6297](../VS_IDE/C6297.md)|Result Of Shift Cast To Larger Size|  
|[C6299](../VS_IDE/C6299.md)|Bitfield To Boolean Comparison|  
|[C6302](../VS_IDE/C6302.md)|Invalid Character String Argument To Format Function|  
|[C6303](../VS_IDE/C6303.md)|Invalid Wide Character String Argument To Format Function|  
|[C6305](../VS_IDE/C6305.md)|Mismatched Size And Count Use|  
|[C6306](../VS_IDE/C6306.md)|Incorrect Variable Argument Function Call|  
|[C6308](../VS_IDE/C6308.md)|Realloc Leak|  
|[C6310](../VS_IDE/C6310.md)|Illegal Exception Filter Constant|  
|[C6312](../VS_IDE/C6312.md)|Exception Continue Execution Loop|  
|[C6314](../VS_IDE/C6314.md)|Bitwise-Or Precedence|  
|[C6317](../VS_IDE/C6317.md)|Not Not Complement|  
|[C6318](../VS_IDE/C6318.md)|Exception Continue Search|  
|[C6319](../VS_IDE/C6319.md)|Ignored By Comma|  
|[C6324](../VS_IDE/C6324.md)|String Copy Instead Of String Compare|  
|[C6328](../VS_IDE/C6328.md)|Potential Argument Type Mismatch|  
|[C6331](../VS_IDE/C6331.md)|VirtualFree Invalid Flags|  
|[C6332](../VS_IDE/C6332.md)|VirtualFree Invalid Parameter|  
|[C6333](../VS_IDE/C6333.md)|VirtualFree Invalid Size|  
|[C6335](../VS_IDE/C6335.md)|Leaking Process Handle|  
|[C6381](../VS_IDE/C6381.md)|Shutdown Information Missing|  
|[C6383](../VS_IDE/C6383.md)|Element-Count Byte-Count Buffer Overrun|  
|[C6384](../VS_IDE/C6384.md)|Pointer Size Division|  
|[C6385](../VS_IDE/C6385.md)|Read Overrun|  
|[C6386](../VS_IDE/C6386.md)|Write Overrun|  
|[C6387](../VS_IDE/C6387.md)|Invalid Parameter Value|  
|[C6388](../VS_IDE/C6388.md)|Invalid Parameter Value|  
|[C6500](../VS_IDE/C6500.md)|Invalid Attribute Property|  
|[C6501](../VS_IDE/C6501.md)|Conflicting Attribute Property Values|  
|[C6503](../VS_IDE/C6503.md)|References Cannot Be Null|  
|[C6504](../VS_IDE/C6504.md)|Null On Non-Pointer|  
|[C6505](../VS_IDE/C6505.md)|MustCheck On Void|  
|[C6506](../VS_IDE/C6506.md)|Buffer Size On Non-Pointer Or Array|  
|[C6507](assetId:///18f88cd1-d035-4403-a6a4-12dd0affcf21)|Null Mismatch At Dereference Zero|  
|[C6508](../VS_IDE/C6508.md)|Write Access On Constant|  
|[C6509](../VS_IDE/C6509.md)|Return Used On Precondition|  
|[C6510](../VS_IDE/C6510.md)|Null Terminated On Non-Pointer|  
|[C6511](../VS_IDE/C6511.md)|MustCheck Must Be Yes Or No|  
|[C6513](../VS_IDE/C6513.md)|Element Size Without Buffer Size|  
|[C6514](../VS_IDE/C6514.md)|Buffer Size Exceeds Array Size|  
|[C6515](../VS_IDE/C6515.md)|Buffer Size On Non-Pointer|  
|[C6516](../VS_IDE/C6516.md)|No Properties On Attribute|  
|[C6517](../VS_IDE/C6517.md)|Valid Size On Non-Readable Buffer|  
|[C6518](../VS_IDE/C6518.md)|Writable Size On Non-Writable Buffer|  
|[C6519](assetId:///2b6326b0-0539-4d26-8fb1-720114933232)|Invalid annotation: value of the 'NeedsRelease' property must be Yes or No|  
|[C6521](assetId:///e98d0ae3-6f13-47b2-9a15-15d4055af9ef)|Invalid Size String Dereference|  
|[C6522](../VS_IDE/C6522.md)|Invalid Size String Type|  
|[C6523](assetId:///11397a31-b224-46b0-afb7-d49ca576a3bb)|Invalid Size String Parameter|  
|[C6525](../VS_IDE/C6525.md)|Invalid Size String Unreachable Location|  
|[C6526](assetId:///59c590c7-0098-4166-a1ac-87f324596002)|Invalid Size String Buffer Type|  
|[C6527](../VS_IDE/C6527.md)|Invalid annotation: 'NeedsRelease' property may not be used on values of void type|  
|[C6530](../VS_IDE/C6530.md)|Unrecognized Format String Style|  
|[C6540](../VS_IDE/C6540.md)|The use of attribute annotations on this function will invalidate all of its existing __declspec annotations|  
|[C6551](../VS_IDE/C6551.md)|Invalid size specification: expression not parsable|  
|[C6552](../VS_IDE/C6552.md)|Invalid Deref= or Notref=: expression not parsable|  
|[C6701](../VS_IDE/C6701.md)|The value is not a valid Yes/No/Maybe value|  
|[C6702](../VS_IDE/C6702.md)|The value is not a string value|  
|[C6703](../VS_IDE/C6703.md)|The value is not a number|  
|[C6704](../VS_IDE/C6704.md)|Unexpected Annotation Expression Error|  
|[C6705](../VS_IDE/C6705.md)|Expected number of arguments for annotation does not match actual number of arguments for annotation|  
|[C6706](../VS_IDE/C6706.md)|Unexpected Annotation Error for annotation|  
|[C6995](../VS_IDE/C6995.md)|Failed to save XML Log file|  
|[C26100](../VS_IDE/C26100.md)|Race condition|  
|[C26101](../VS_IDE/C26101.md)|Failing to use interlocked operation properly|  
|[C26110](../VS_IDE/C26110.md)|Caller failing to hold lock|  
|[C26111](../VS_IDE/C26111.md)|Caller failing to release lock|  
|[C26112](../VS_IDE/C26112.md)|Caller cannot hold any lock|  
|[C26115](../VS_IDE/C26115.md)|Failing to release lock|  
|[C26116](../VS_IDE/C26116.md)|Failing to acquire or to hold lock|  
|[C26117](../VS_IDE/C26117.md)|Releasing unheld lock|  
|[C26140](../VS_IDE/C26140.md)|Concurrency SAL annotation error|  
|[C28020](../VS_IDE/C28020.md)|The expression is not true at this call|  
|[C28021](../VS_IDE/C28021.md)|The parameter being annotated must be a pointer|  
|[C28022](../VS_IDE/C28022.md)|The function class(es) on this function do not match the function class(es) on the typedef used to define it.|  
|[C28023](../VS_IDE/C28023.md)|The function being assigned or passed should have a _Function_class\_ annotation for at least one of the class(es)|  
|[C28024](../VS_IDE/C28024.md)|The function pointer being assigned to is annotated with the function class, which is not contained in the function class(es) list.|  
|[C28039](../VS_IDE/C28039.md)|The type of actual parameter should exactly match the type|  
|[C28112](../VS_IDE/C28112.md)|A variable which is accessed via an Interlocked function must always be accessed via an Interlocked function.|  
|[C28113](../VS_IDE/C28113.md)|Accessing a local variable via an Interlocked function|  
|[C28125](../VS_IDE/C28125.md)|The function must be called from within a try/except block|  
|[C28137](../VS_IDE/C28137.md)|The variable argument should instead be a (literal) constant|  
|[C28138](../VS_IDE/C28138.md)|The constant argument should instead be variable|  
|[C28159](../VS_IDE/C28159.md)|Consider using another function instead.|  
|[C28160](../VS_IDE/C28160.md)|Error annotation|  
|[C28163](../VS_IDE/C28163.md)|The function should never be called from within a try/except block|  
|[C28164](../VS_IDE/C28164.md)|The argument is being passed to a function that expects a pointer to an object (not a pointer to a pointer)|  
|[C28182](../VS_IDE/C28182.md)|Dereferencing NULL pointer. The pointer contains the same NULL value as another pointer did.|  
|[C28183](../VS_IDE/C28183.md)|The argument could be one value, and is a copy of the value found in the pointer|  
|[C28193](../VS_IDE/C28193.md)|The variable holds a value that must be examined|  
|[C28196](../VS_IDE/C28196.md)|The requirement is not satisfied. (The expression does not evaluate to true.)|  
|[C28202](../VS_IDE/C28202.md)|Illegal reference to non-static member|  
|[C28203](../VS_IDE/C28203.md)|Ambiguous reference to class member.|  
|[C28205](../VS_IDE/C28205.md)|_Success\_ or _On_failure\_ used in an illegal context|  
|[C28206](../VS_IDE/C28206.md)|Left operand points to a struct, use '->'|  
|[C28207](../VS_IDE/C28207.md)|Left operand is a struct, use '.'|  
|[C28209](../VS_IDE/C28209.md)|The declaration for symbol has a conflicting declaration|  
|[C28210](../VS_IDE/C28210.md)|Annotations for the __on_failure context must not be in explicit pre context|  
|[C28211](../VS_IDE/C28211.md)|Static context name expected for SAL_context|  
|[C28212](../VS_IDE/C28212.md)|Pointer expression expected for annotation|  
|[C28213](../VS_IDE/C28213.md)|The _Use_decl_annotations\_ annotation must be used to reference, without modification, a prior declaration.|  
|[C28214](../VS_IDE/C28214.md)|Attribute parameter names must be p1...p9|  
|[C28215](../VS_IDE/C28215.md)|The typefix cannot be applied to a parameter that already has a typefix|  
|[C28216](../VS_IDE/C28216.md)|The checkReturn annotation only applies to postconditions for the specific function parameter.|  
|[C28217](../VS_IDE/C28217.md)|For function, the number of parameters to annotation does not match that found at file|  
|[C28218](../VS_IDE/C28218.md)|For function paramteer, the annotation's parameter does not match that found at file|  
|[C28219](../VS_IDE/C28219.md)|Member of enumeration expected for annotation the parameter in the annotation|  
|[C28220](../VS_IDE/C28220.md)|Integer expression expected for annotation the parameter in the annotation|  
|[C28221](../VS_IDE/C28221.md)|String expression expected for the parameter in the annotation|  
|[C28222](../VS_IDE/C28222.md)|__yes, \__no, or \__maybe expected for annotation|  
|[C28223](../VS_IDE/C28223.md)|Did not find expected Token/identifier for annotation, parameter|  
|[C28224](../VS_IDE/C28224.md)|Annotation requires parameters|  
|[C28225](../VS_IDE/C28225.md)|Did not find the correct number of required parameters in annotation|  
|[C28226](../VS_IDE/C28226.md)|Annotation cannot also be a PrimOp (in current declaration)|  
|[C28227](../VS_IDE/C28227.md)|Annotation cannot also be a PrimOp (see prior declaration)|  
|[C28228](../VS_IDE/C28228.md)|Annotation parameter: cannot use type in annotations|  
|[C28229](../VS_IDE/C28229.md)|Annotation does not support parameters|  
|[C28230](../VS_IDE/C28230.md)|The type of parameter has no member.|  
|[C28231](../VS_IDE/C28231.md)|Annotation is only valid on array|  
|[C28232](../VS_IDE/C28232.md)|pre, post, or deref not applied to any annotation|  
|[C28233](../VS_IDE/C28233.md)|pre, post, or deref applied to a block|  
|[C28234](../VS_IDE/C28234.md)|__at expression does not apply to current function|  
|[C28235](../VS_IDE/C28235.md)|The function cannot stand alone as an annotation|  
|[C28236](../VS_IDE/C28236.md)|The annotation cannot be used in an expression|  
|[C28237](../VS_IDE/C28237.md)|The annotation on parameter is no longer supported|  
|[C28238](../VS_IDE/C28238.md)|The annotation on parameter has more than one of value, stringValue, and longValue. Use paramn=xxx|  
|[C28239](../VS_IDE/C28239.md)|The annotation on parameter has both value, stringValue, or longValue; and paramn=xxx. Use only paramn=xxx|  
|[C28240](../VS_IDE/C28240.md)|The annotation on parameter has param2 but no param1|  
|[C28241](../VS_IDE/C28241.md)|The annotation for function on parameter is not recognized|  
|[C28243](../VS_IDE/C28243.md)|The annotation for function on parameter requires more dereferences than the actual type annotated allows|  
|[C28244](../VS_IDE/C28244.md)|The annotation for function has an unparseable parameter/external annotation|  
|[C28245](../VS_IDE/C28245.md)|The annotation for function annotates 'this' on a non-member-function|  
|[C28246](../VS_IDE/C28246.md)|The parameter annotation for function does not match the type of the parameter|  
|[C28250](../VS_IDE/C28250.md)|Inconsistent annotation for function: the prior instance has an error.|  
|[C28251](../VS_IDE/C28251.md)|Inconsistent annotation for function: this instance has an error.|  
|[C28252](../VS_IDE/C28252.md)|Inconsistent annotation for function: parameter has another annotations on this instance.|  
|[C28253](../VS_IDE/C28253.md)|Inconsistent annotation for function: parameter has another annotations on this instance.|  
|[C28254](../VS_IDE/C28254.md)|dynamic_cast<>() is not supported in annotations|  
|[C28262](../VS_IDE/C28262.md)|A syntax error in the annotation was found in function, for annotation|  
|[C28263](../VS_IDE/C28263.md)|A syntax error in a conditional annotation was found for Intrinsic annotation|  
|[C28264](assetId:///bf6ea983-a06e-4752-a042-747a7dbf338c)|Result lists values must be constants.|  
|[C28267](../VS_IDE/C28267.md)|A syntax error in the annotations was found annotation in the function.|  
|[C28272](../VS_IDE/C28272.md)|The annotation for function, parameter when examining is inconsistent with the function declaration|  
|[C28273](../VS_IDE/C28273.md)|For function, the clues are inconsistent with the function declaration|  
|[C28275](../VS_IDE/C28275.md)|The parameter to _Macro_value\_ is null|  
|[C28279](../VS_IDE/C28279.md)|For symbol, a 'begin' was found without a matching 'end'|  
|[C28280](../VS_IDE/C28280.md)|For symbol, an 'end' was found without a matching 'begin'|  
|[C28282](../VS_IDE/C28282.md)|Format Strings must be in preconditions|  
|[C28285](../VS_IDE/C28285.md)|For function, syntax error in parameter|  
|[C28286](../VS_IDE/C28286.md)|For function, syntax error near the end|  
|[C28287](../VS_IDE/C28287.md)|For function, syntax Error in _At\_() annotation (unrecognized parameter name)|  
|[C28288](../VS_IDE/C28288.md)|For function, syntax Error in _At\_() annotation (invalid parameter name)|  
|[C28289](../VS_IDE/C28289.md)|For function: ReadableTo or WritableTo did not have a limit-spec as a parameter|  
|[C28290](../VS_IDE/C28290.md)|the annotation for function contains more Externals than the actual number of parameters|  
|[C28291](../VS_IDE/C28291.md)|post null/notnull at deref level 0 is meaningless for function.|  
|[C28300](../VS_IDE/C28300.md)|Expression operands of incompatible types for operator|  
|[C28301](../VS_IDE/C28301.md)|No annotations for first declaration of function.|  
|[C28302](../VS_IDE/C28302.md)|An extra _Deref\_ operator was found on annotation.|  
|[C28303](../VS_IDE/C28303.md)|An ambiguous _Deref\_ operator was found on annotation.|  
|[C28304](../VS_IDE/C28304.md)|An improperly placed _Notref\_ operator was found applied to token.|  
|[C28305](../VS_IDE/C28305.md)|An error while parsing a token was discovered.|  
|[C28306](../VS_IDE/C28306.md)|The annotation on parameter is obsolescent|  
|[C28307](../VS_IDE/C28307.md)|The annotation on parameter is obsolescent|  
|[C28350](../VS_IDE/C28350.md)|The annotation describes a situation that is not conditionally applicable.|  
|[C28351](../VS_IDE/C28351.md)|The annotation describes where a dynamic value (a variable) cannot be used in the condition.|  
|[CA1001](../VS_IDE/CA1001--Types-that-own-disposable-fields-should-be-disposable.md)|Types that own disposable fields should be disposable|  
|[CA1009](../VS_IDE/CA1009--Declare-event-handlers-correctly.md)|Declare event handlers correctly|  
|[CA1016](../VS_IDE/CA1016--Mark-assemblies-with-AssemblyVersionAttribute.md)|Mark assemblies with AssemblyVersionAttribute|  
|[CA1033](../VS_IDE/CA1033--Interface-methods-should-be-callable-by-child-types.md)|Interface methods should be callable by child types|  
|[CA1049](../VS_IDE/CA1049--Types-that-own-native-resources-should-be-disposable.md)|Types that own native resources should be disposable|  
|[CA1060](../VS_IDE/CA1060--Move-P-Invokes-to-NativeMethods-class.md)|Move P/Invokes to NativeMethods class|  
|[CA1061](../VS_IDE/CA1061--Do-not-hide-base-class-methods.md)|Do not hide base class methods|  
|[CA1063](../VS_IDE/CA1063--Implement-IDisposable-correctly.md)|Implement IDisposable correctly|  
|[CA1065](../VS_IDE/CA1065--Do-not-raise-exceptions-in-unexpected-locations.md)|Do not raise exceptions in unexpected locations|  
|[CA1301](../VS_IDE/CA1301--Avoid-duplicate-accelerators.md)|Avoid duplicate accelerators|  
|[CA1400](../VS_IDE/CA1400--P-Invoke-entry-points-should-exist.md)|P/Invoke entry points should exist|  
|[CA1401](../VS_IDE/CA1401--P-Invokes-should-not-be-visible.md)|P/Invokes should not be visible|  
|[CA1403](../VS_IDE/CA1403--Auto-layout-types-should-not-be-COM-visible.md)|Auto layout types should not be COM visible|  
|[CA1404](../VS_IDE/CA1404--Call-GetLastError-immediately-after-P-Invoke.md)|Call GetLastError immediately after P/Invoke|  
|[CA1405](../VS_IDE/CA1405--COM-visible-type-base-types-should-be-COM-visible.md)|COM visible type base types should be COM visible|  
|[CA1410](../VS_IDE/CA1410--COM-registration-methods-should-be-matched.md)|COM registration methods should be matched|  
|[CA1415](../VS_IDE/CA1415--Declare-P-Invokes-correctly.md)|Declare P/Invokes correctly|  
|[CA1821](../VS_IDE/CA1821--Remove-empty-finalizers.md)|Remove empty finalizers|  
|[CA1900](../VS_IDE/CA1900--Value-type-fields-should-be-portable.md)|Value type fields should be portable|  
|[CA1901](../VS_IDE/CA1901--P-Invoke-declarations-should-be-portable.md)|P/Invoke declarations should be portable|  
|[CA2002](../VS_IDE/CA2002--Do-not-lock-on-objects-with-weak-identity.md)|Do not lock on objects with weak identity|  
|[CA2100](../VS_IDE/CA2100--Review-SQL-queries-for-security-vulnerabilities.md)|Review SQL queries for security vulnerabilities|  
|[CA2101](../VS_IDE/CA2101--Specify-marshaling-for-P-Invoke-string-arguments.md)|Specify marshaling for P/Invoke string arguments|  
|[CA2108](../VS_IDE/CA2108--Review-declarative-security-on-value-types.md)|Review declarative security on value types|  
|[CA2111](../VS_IDE/CA2111--Pointers-should-not-be-visible.md)|Pointers should not be visible|  
|[CA2112](../VS_IDE/CA2112--Secured-types-should-not-expose-fields.md)|Secured types should not expose fields|  
|[CA2114](../VS_IDE/CA2114--Method-security-should-be-a-superset-of-type.md)|Method security should be a superset of type|  
|[CA2116](../VS_IDE/CA2116--APTCA-methods-should-only-call-APTCA-methods.md)|APTCA methods should only call APTCA methods|  
|[CA2117](../VS_IDE/CA2117--APTCA-types-should-only-extend-APTCA-base-types.md)|APTCA types should only extend APTCA base types|  
|[CA2122](../VS_IDE/CA2122--Do-not-indirectly-expose-methods-with-link-demands.md)|Do not indirectly expose methods with link demands|  
|[CA2123](../VS_IDE/CA2123--Override-link-demands-should-be-identical-to-base.md)|Override link demands should be identical to base|  
|[CA2124](../VS_IDE/CA2124--Wrap-vulnerable-finally-clauses-in-outer-try.md)|Wrap vulnerable finally clauses in outer try|  
|[CA2126](../VS_IDE/CA2126--Type-link-demands-require-inheritance-demands.md)|Type link demands require inheritance demands|  
|[CA2131](../VS_IDE/CA2131--Security-critical-types-may-not-participate-in-type-equivalence.md)|Security critical types may not participate in type equivalence|  
|[CA2132](../VS_IDE/CA2132--Default-constructors-must-be-at-least-as-critical-as-base-type-default-constructors.md)|Default constructors must be at least as critical as base type default constructors|  
|[CA2133](../VS_IDE/CA2133--Delegates-must-bind-to-methods-with-consistent-transparency.md)|Delegates must bind to methods with consistent transparency|  
|[CA2134](../VS_IDE/CA2134--Methods-must-keep-consistent-transparency-when-overriding-base-methods.md)|Methods must keep consistent transparency when overriding base methods|  
|[CA2137](../VS_IDE/CA2137--Transparent-methods-must-contain-only-verifiable-IL.md)|Transparent methods must contain only verifiable IL|  
|[CA2138](../VS_IDE/CA2138--Transparent-methods-must-not-call-methods-with-the-SuppressUnmanagedCodeSecurity-attribute.md)|Transparent methods must not call methods with the SuppressUnmanagedCodeSecurity attribute|  
|[CA2140](../VS_IDE/CA2140--Transparent-code-must-not-reference-security-critical-items.md)|Transparent code must not reference security critical items|  
|[CA2141](../VS_IDE/CA2141-Transparent-methods-must-not-satisfy-LinkDemands.md)|Transparent methods must not satisfy LinkDemands|  
|[CA2146](../VS_IDE/CA2146--Types-must-be-at-least-as-critical-as-their-base-types-and-interfaces.md)|Types must be at least as critical as their base types and interfaces|  
|[CA2147](../VS_IDE/CA2147--Transparent-methods-may-not-use-security-asserts.md)|Transparent methods may not use security asserts|  
|[CA2149](../VS_IDE/CA2149--Transparent-methods-must-not-call-into-native-code.md)|Transparent methods must not call into native code|  
|[CA2200](../VS_IDE/CA2200--Rethrow-to-preserve-stack-details.md)|Rethrow to preserve stack details|  
|[CA2202](../VS_IDE/CA2202--Do-not-dispose-objects-multiple-times.md)|Do not dispose objects multiple times|  
|[CA2207](../VS_IDE/CA2207--Initialize-value-type-static-fields-inline.md)|Initialize value type static fields inline|  
|[CA2212](../VS_IDE/CA2212--Do-not-mark-serviced-components-with-WebMethod.md)|Do not mark serviced components with WebMethod|  
|[CA2213](../VS_IDE/CA2213--Disposable-fields-should-be-disposed.md)|Disposable fields should be disposed|  
|[CA2214](../VS_IDE/CA2214--Do-not-call-overridable-methods-in-constructors.md)|Do not call overridable methods in constructors|  
|[CA2216](../VS_IDE/CA2216--Disposable-types-should-declare-finalizer.md)|Disposable types should declare finalizer|  
|[CA2220](../VS_IDE/CA2220--Finalizers-should-call-base-class-finalizer.md)|Finalizers should call base class finalizer|  
|[CA2229](../VS_IDE/CA2229--Implement-serialization-constructors.md)|Implement serialization constructors|  
|[CA2231](../VS_IDE/CA2231--Overload-operator-equals-on-overriding-ValueType.Equals.md)|Overload operator equals on overriding ValueType.Equals|  
|[CA2232](../VS_IDE/CA2232--Mark-Windows-Forms-entry-points-with-STAThread.md)|Mark Windows Forms entry points with STAThread|  
|[CA2235](../VS_IDE/CA2235--Mark-all-non-serializable-fields.md)|Mark all non-serializable fields|  
|[CA2236](../VS_IDE/CA2236--Call-base-class-methods-on-ISerializable-types.md)|Call base class methods on ISerializable types|  
|[CA2237](../VS_IDE/CA2237--Mark-ISerializable-types-with-SerializableAttribute.md)|Mark ISerializable types with SerializableAttribute|  
|[CA2238](../VS_IDE/CA2238--Implement-serialization-methods-correctly.md)|Implement serialization methods correctly|  
|[CA2240](../VS_IDE/CA2240--Implement-ISerializable-correctly.md)|Implement ISerializable correctly|  
|[CA2241](../VS_IDE/CA2241--Provide-correct-arguments-to-formatting-methods.md)|Provide correct arguments to formatting methods|  
|[CA2242](../VS_IDE/CA2242--Test-for-NaN-correctly.md)|Test for NaN correctly|