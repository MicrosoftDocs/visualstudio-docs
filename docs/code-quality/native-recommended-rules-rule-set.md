---
title: Native Recommended Rules rule set
ms.date: 11/04/2016
ms.topic: reference
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Native Recommended Rules rule set

The Native Recommended Rules focus on the most critical and common problems in native code, including potential security holes and application crashes. This rule set includes all of the rules in the [Native Minimum Rules](native-minimum-rules-rule-set.md) rule set.

Include this rule set in any custom rule set you create for native projects.

|Rule|Description|
|----------|-----------------|
|[C6001](../code-quality/c6001.md)|Using Uninitialized Memory|
|[C6011](../code-quality/c6011.md)|Dereferencing Null Pointer|
|[C6029](../code-quality/c6029.md)|Use Of Unchecked Value|
|[C6031](../code-quality/c6031.md)|Return Value Ignored|
|[C6053](../code-quality/c6053.md)|Zero Termination From Call|
|[C6054](../code-quality/c6054.md)|Zero Termination Missing|
|[C6059](../code-quality/c6059.md)|Bad Concatenation|
|[C6063](../code-quality/c6063.md)|Missing String Argument To Format Function|
|[C6064](../code-quality/c6064.md)|Missing Integer Argument To Format Function|
|[C6066](../code-quality/c6066.md)|Missing Pointer Argument To Format Function|
|[C6067](../code-quality/c6067.md)|Missing String Pointer Argument To Format Function|
|[C6101](../code-quality/c6101.md)|Returning uninitialized memory|
|[C6200](../code-quality/c6200.md)|Index Exceeds Buffer Maximum|
|[C6201](../code-quality/c6201.md)|Index Exceeds Stack Buffer Maximum|
|[C6214](../code-quality/c6214.md)|Invalid Cast HRESULT To BOOL|
|[C6215](../code-quality/c6215.md)|Invalid Cast BOOL To HRESULT|
|[C6216](../code-quality/c6216.md)|Invalid Compiler-Inserted Cast BOOL To HRESULT|
|[C6217](../code-quality/c6217.md)|Invalid HRESULT Test With NOT|
|[C6220](../code-quality/c6220.md)|Invalid HRESULT Compare To -1|
|[C6226](../code-quality/c6226.md)|Invalid HRESULT Assignment To -1|
|[C6230](../code-quality/c6230.md)|Invalid HRESULT Use As Boolean|
|[C6235](../code-quality/c6235.md)|Non-Zero Constant With Logical-Or|
|[C6236](../code-quality/c6236.md)|Logical-Or With Non-Zero Constant|
|[C6237](../code-quality/c6237.md)|Zero With Logical-And Loses Side Effects|
|[C6242](../code-quality/c6242.md)|Local Unwind Forced|
|[C6248](../code-quality/c6248.md)|Creating Null DACL|
|[C6250](../code-quality/c6250.md)|Unreleased Address Descriptors|
|[C6255](../code-quality/c6255.md)|Unprotected Use Of Alloca|
|[C6258](../code-quality/c6258.md)|Using Terminate Thread|
|[C6259](../code-quality/c6259.md)|Dead Code In Bitwise-Or Limited Switch|
|[C6260](../code-quality/c6260.md)|Use Of Byte Arithmetic|
|[C6262](../code-quality/c6262.md)|Excessive Stack Usage|
|[C6263](../code-quality/c6263.md)|Using Alloca In Loop|
|[C6268](../code-quality/c6268.md)|Missing Parentheses In Cast|
|[C6269](../code-quality/c6269.md)|Pointer Dereference Ignored|
|[C6270](../code-quality/c6270.md)|Missing Float Argument To Format Function|
|[C6271](../code-quality/c6271.md)|Extra Argument To Format Function|
|[C6272](../code-quality/c6272.md)|Non-Float Argument To Format Function|
|[C6273](../code-quality/c6273.md)|Non-Integer Argument To Format Function|
|[C6274](../code-quality/c6274.md)|Non-Character Argument To Format Function|
|[C6276](../code-quality/c6276.md)|Invalid String Cast|
|[C6277](../code-quality/c6277.md)|Invalid CreateProcess Call|
|[C6278](../code-quality/c6278.md)|Array-New Scalar-Delete Mismatch|
|[C6279](../code-quality/c6279.md)|Scalar-New Array-Delete Mismatch|
|[C6280](../code-quality/c6280.md)|Memory Allocation-Deallocation Mismatch|
|[C6281](../code-quality/c6281.md)|Bitwise Relation Precedence|
|[C6282](../code-quality/c6282.md)|Assignment Replaces Test|
|[C6283](../code-quality/c6283.md)|Primitive Array-New Scalar-Delete Mismatch|
|[C6284](../code-quality/c6284.md)|Invalid Object Argument To Format Function|
|[C6285](../code-quality/c6285.md)|Logical-Or Of Constants|
|[C6286](../code-quality/c6286.md)|Non-Zero Logical-Or Losing Side Effects|
|[C6287](../code-quality/c6287.md)|Redundant Test|
|[C6288](../code-quality/c6288.md)|Mutual Inclusion Over Logical-And Is False|
|[C6289](../code-quality/c6289.md)|Mutual Exclusion Over Logical-Or Is True|
|[C6290](../code-quality/c6290.md)|Logical-Not Bitwise-And Precedence|
|[C6291](../code-quality/c6291.md)|Logical-Not Bitwise-Or Precedence|
|[C6292](../code-quality/c6292.md)|Loop Counts Up From Maximum|
|[C6293](../code-quality/c6293.md)|Loop Counts Down From Minimum|
|[C6294](../code-quality/c6294.md)|Loop Body Never Executed|
|[C6295](../code-quality/c6295.md)|Infinite Loop|
|[C6296](../code-quality/c6296.md)|Loop Only Executed Once|
|[C6297](../code-quality/c6297.md)|Result Of Shift Cast To Larger Size|
|[C6299](../code-quality/c6299.md)|Bitfield To Boolean Comparison|
|[C6302](../code-quality/c6302.md)|Invalid Character String Argument To Format Function|
|[C6303](../code-quality/c6303.md)|Invalid Wide Character String Argument To Format Function|
|[C6305](../code-quality/c6305.md)|Mismatched Size And Count Use|
|[C6306](../code-quality/c6306.md)|Incorrect Variable Argument Function Call|
|[C6308](../code-quality/c6308.md)|Realloc Leak|
|[C6310](../code-quality/c6310.md)|Illegal Exception Filter Constant|
|[C6312](../code-quality/c6312.md)|Exception Continue Execution Loop|
|[C6314](../code-quality/c6314.md)|Bitwise-Or Precedence|
|[C6317](../code-quality/c6317.md)|Not Not Complement|
|[C6318](../code-quality/c6318.md)|Exception Continue Search|
|[C6319](../code-quality/c6319.md)|Ignored By Comma|
|[C6324](../code-quality/c6324.md)|String Copy Instead Of String Compare|
|[C6328](../code-quality/c6328.md)|Potential Argument Type Mismatch|
|[C6331](../code-quality/c6331.md)|VirtualFree Invalid Flags|
|[C6332](../code-quality/c6332.md)|VirtualFree Invalid Parameter|
|[C6333](../code-quality/c6333.md)|VirtualFree Invalid Size|
|[C6335](../code-quality/c6335.md)|Leaking Process Handle|
|[C6381](../code-quality/c6381.md)|Shutdown Information Missing|
|[C6383](../code-quality/c6383.md)|Element-Count Byte-Count Buffer Overrun|
|[C6384](../code-quality/c6384.md)|Pointer Size Division|
|[C6385](../code-quality/c6385.md)|Read Overrun|
|[C6386](../code-quality/c6386.md)|Write Overrun|
|[C6387](../code-quality/c6387.md)|Invalid Parameter Value|
|[C6388](../code-quality/c6388.md)|Invalid Parameter Value|
|[C6500](../code-quality/c6500.md)|Invalid Attribute Property|
|[C6501](../code-quality/c6501.md)|Conflicting Attribute Property Values|
|[C6503](../code-quality/c6503.md)|References Cannot Be Null|
|[C6504](../code-quality/c6504.md)|Null On Non-Pointer|
|[C6505](../code-quality/c6505.md)|MustCheck On Void|
|[C6506](../code-quality/c6506.md)|Buffer Size On Non-Pointer Or Array|
|[C6508](../code-quality/c6508.md)|Write Access On Constant|
|[C6509](../code-quality/c6509.md)|Return Used On Precondition|
|[C6510](../code-quality/c6510.md)|Null Terminated On Non-Pointer|
|[C6511](../code-quality/c6511.md)|MustCheck Must Be Yes Or No|
|[C6513](../code-quality/c6513.md)|Element Size Without Buffer Size|
|[C6514](../code-quality/c6514.md)|Buffer Size Exceeds Array Size|
|[C6515](../code-quality/c6515.md)|Buffer Size On Non-Pointer|
|[C6516](../code-quality/c6516.md)|No Properties On Attribute|
|[C6517](../code-quality/c6517.md)|Valid Size On Non-Readable Buffer|
|[C6518](../code-quality/c6518.md)|Writable Size On Non-Writable Buffer|
|[C6522](../code-quality/c6522.md)|Invalid Size String Type|
|[C6525](../code-quality/c6525.md)|Invalid Size String Unreachable Location|
|[C6527](../code-quality/c6527.md)|Invalid annotation: 'NeedsRelease' property may not be used on values of void type|
|[C6530](../code-quality/c6530.md)|Unrecognized Format String Style|
|[C6540](../code-quality/c6540.md)|The use of attribute annotations on this function will invalidate all of its existing __declspec annotations|
|[C6551](../code-quality/c6551.md)|Invalid size specification: expression not parsable|
|[C6552](../code-quality/c6552.md)|Invalid Deref= or Notref=: expression not parsable|
|[C6701](../code-quality/c6701.md)|The value is not a valid Yes/No/Maybe value|
|[C6702](../code-quality/c6702.md)|The value is not a string value|
|[C6703](../code-quality/c6703.md)|The value is not a number|
|[C6704](../code-quality/c6704.md)|Unexpected Annotation Expression Error|
|[C6705](../code-quality/c6705.md)|Expected number of arguments for annotation does not match actual number of arguments for annotation|
|[C6706](../code-quality/c6706.md)|Unexpected Annotation Error for annotation|
|[C6995](../code-quality/c6995.md)|Failed to save XML Log file|
|[C26100](../code-quality/c26100.md)|Race condition|
|[C26101](../code-quality/c26101.md)|Failing to use interlocked operation properly|
|[C26110](../code-quality/c26110.md)|Caller failing to hold lock|
|[C26111](../code-quality/c26111.md)|Caller failing to release lock|
|[C26112](../code-quality/c26112.md)|Caller cannot hold any lock|
|[C26115](../code-quality/c26115.md)|Failing to release lock|
|[C26116](../code-quality/c26116.md)|Failing to acquire or to hold lock|
|[C26117](../code-quality/c26117.md)|Releasing unheld lock|
|[C26140](../code-quality/c26140.md)|Concurrency SAL annotation error|
|[C26441](../code-quality/c26441.md)|NO_UNNAMED_GUARDS|
|[C26444](../code-quality/c26444.md)|NO_UNNAMED_RAII_OBJECTS|
|[C26498](../code-quality/c26498.md)|USE_CONSTEXPR_FOR_FUNCTIONCALL|
|[C28020](../code-quality/c28020.md)|The expression is not true at this call|
|[C28021](../code-quality/c28021.md)|The parameter being annotated must be a pointer|
|[C28022](../code-quality/c28022.md)|The function class(es) on this function do not match the function class(es) on the typedef used to define it.|
|[C28023](../code-quality/c28023.md)|The function being assigned or passed should have a \_Function\_class\_ annotation for at least one of the class(es)|
|[C28024](../code-quality/c28024.md)|The function pointer being assigned to is annotated with the function class, which is not contained in the function class(es) list.|
|[C28039](../code-quality/c28039.md)|The type of actual parameter should exactly match the type|
|[C28112](../code-quality/c28112.md)|A variable which is accessed via an Interlocked function must always be accessed via an Interlocked function.|
|[C28113](../code-quality/c28113.md)|Accessing a local variable via an Interlocked function|
|[C28125](../code-quality/c28125.md)|The function must be called from within a try/except block|
|[C28137](../code-quality/c28137.md)|The variable argument should instead be a (literal) constant|
|[C28138](../code-quality/c28138.md)|The constant argument should instead be variable|
|[C28159](../code-quality/c28159.md)|Consider using another function instead.|
|[C28160](../code-quality/c28160.md)|Error annotation|
|[C28163](../code-quality/c28163.md)|The function should never be called from within a try/except block|
|[C28164](../code-quality/c28164.md)|The argument is being passed to a function that expects a pointer to an object (not a pointer to a pointer)|
|[C28182](../code-quality/c28182.md)|Dereferencing NULL pointer. The pointer contains the same NULL value as another pointer did.|
|[C28183](../code-quality/c28183.md)|The argument could be one value, and is a copy of the value found in the pointer|
|[C28193](../code-quality/c28193.md)|The variable holds a value that must be examined|
|[C28196](../code-quality/c28196.md)|The requirement is not satisfied. (The expression does not evaluate to true.)|
|[C28202](../code-quality/c28202.md)|Illegal reference to non-static member|
|[C28203](../code-quality/c28203.md)|Ambiguous reference to class member.|
|[C28205](../code-quality/c28205.md)|\_Success\_ or \_On\_failure\_ used in an illegal context|
|[C28206](../code-quality/c28206.md)|Left operand points to a struct, use '->'|
|[C28207](../code-quality/c28207.md)|Left operand is a struct, use '.'|
|[C28209](../code-quality/c28209.md)|The declaration for symbol has a conflicting declaration|
|[C28210](../code-quality/c28210.md)|Annotations for the __on_failure context must not be in explicit pre context|
|[C28211](../code-quality/c28211.md)|Static context name expected for SAL_context|
|[C28212](../code-quality/c28212.md)|Pointer expression expected for annotation|
|[C28213](../code-quality/c28213.md)|The \_Use\_decl\_annotations\_ annotation must be used to reference, without modification, a prior declaration.|
|[C28214](../code-quality/c28214.md)|Attribute parameter names must be p1...p9|
|[C28215](../code-quality/c28215.md)|The typefix cannot be applied to a parameter that already has a typefix|
|[C28216](../code-quality/c28216.md)|The checkReturn annotation only applies to postconditions for the specific function parameter.|
|[C28217](../code-quality/c28217.md)|For function, the number of parameters to annotation does not match that found at file|
|[C28218](../code-quality/c28218.md)|For function parameter, the annotation's parameter does not match that found at file|
|[C28219](../code-quality/c28219.md)|Member of enumeration expected for annotation the parameter in the annotation|
|[C28220](../code-quality/c28220.md)|Integer expression expected for annotation the parameter in the annotation|
|[C28221](../code-quality/c28221.md)|String expression expected for the parameter in the annotation|
|[C28222](../code-quality/c28222.md)|__yes, \__no, or \__maybe expected for annotation|
|[C28223](../code-quality/c28223.md)|Did not find expected Token/identifier for annotation, parameter|
|[C28224](../code-quality/c28224.md)|Annotation requires parameters|
|[C28225](../code-quality/c28225.md)|Did not find the correct number of required parameters in annotation|
|[C28226](../code-quality/c28226.md)|Annotation cannot also be a PrimOp (in current declaration)|
|[C28227](../code-quality/c28227.md)|Annotation cannot also be a PrimOp (see prior declaration)|
|[C28228](../code-quality/c28228.md)|Annotation parameter: cannot use type in annotations|
|[C28229](../code-quality/c28229.md)|Annotation does not support parameters|
|[C28230](../code-quality/c28230.md)|The type of parameter has no member.|
|[C28231](../code-quality/c28231.md)|Annotation is only valid on array|
|[C28232](../code-quality/c28232.md)|pre, post, or deref not applied to any annotation|
|[C28233](../code-quality/c28233.md)|pre, post, or deref applied to a block|
|[C28234](../code-quality/c28234.md)|__at expression does not apply to current function|
|[C28235](../code-quality/c28235.md)|The function cannot stand alone as an annotation|
|[C28236](../code-quality/c28236.md)|The annotation cannot be used in an expression|
|[C28237](../code-quality/c28237.md)|The annotation on parameter is no longer supported|
|[C28238](../code-quality/c28238.md)|The annotation on parameter has more than one of value, stringValue, and longValue. Use paramn=xxx|
|[C28239](../code-quality/c28239.md)|The annotation on parameter has both value, stringValue, or longValue; and paramn=xxx. Use only paramn=xxx|
|[C28240](../code-quality/c28240.md)|The annotation on parameter has param2 but no param1|
|[C28241](../code-quality/c28241.md)|The annotation for function on parameter is not recognized|
|[C28243](../code-quality/c28243.md)|The annotation for function on parameter requires more dereferences than the actual type annotated allows|
|[C28244](../code-quality/c28244.md)|The annotation for function has an unparsable parameter/external annotation|
|[C28245](../code-quality/c28245.md)|The annotation for function annotates 'this' on a non-member-function|
|[C28246](../code-quality/c28246.md)|The parameter annotation for function does not match the type of the parameter|
|[C28250](../code-quality/c28250.md)|Inconsistent annotation for function: the prior instance has an error.|
|[C28251](../code-quality/c28251.md)|Inconsistent annotation for function: this instance has an error.|
|[C28252](../code-quality/c28252.md)|Inconsistent annotation for function: parameter has another annotations on this instance.|
|[C28253](../code-quality/c28253.md)|Inconsistent annotation for function: parameter has another annotations on this instance.|
|[C28254](../code-quality/c28254.md)|dynamic_cast<>() is not supported in annotations|
|[C28262](../code-quality/c28262.md)|A syntax error in the annotation was found in function, for annotation|
|[C28263](../code-quality/c28263.md)|A syntax error in a conditional annotation was found for Intrinsic annotation|
|[C28267](../code-quality/c28267.md)|A syntax error in the annotations was found annotation in the function.|
|[C28272](../code-quality/c28272.md)|The annotation for function, parameter when examining is inconsistent with the function declaration|
|[C28273](../code-quality/c28273.md)|For function, the clues are inconsistent with the function declaration|
|[C28275](../code-quality/c28275.md)|The parameter to \_Macro\_value\_ is null|
|[C28279](../code-quality/c28279.md)|For symbol, a 'begin' was found without a matching 'end'|
|[C28280](../code-quality/c28280.md)|For symbol, an 'end' was found without a matching 'begin'|
|[C28282](../code-quality/c28282.md)|Format Strings must be in preconditions|
|[C28285](../code-quality/c28285.md)|For function, syntax error in parameter|
|[C28286](../code-quality/c28286.md)|For function, syntax error near the end|
|[C28287](../code-quality/c28287.md)|For function, syntax Error in \_At\_() annotation (unrecognized parameter name)|
|[C28288](../code-quality/c28288.md)|For function, syntax Error in \_At\_() annotation (invalid parameter name)|
|[C28289](../code-quality/c28289.md)|For function: ReadableTo or WritableTo did not have a limit-spec as a parameter|
|[C28290](../code-quality/c28290.md)|the annotation for function contains more Externals than the actual number of parameters|
|[C28291](../code-quality/c28291.md)|post null/notnull at deref level 0 is meaningless for function.|
|[C28300](../code-quality/c28300.md)|Expression operands of incompatible types for operator|
|[C28301](../code-quality/c28301.md)|No annotations for first declaration of function.|
|[C28302](../code-quality/c28302.md)|An extra \_Deref\_ operator was found on annotation.|
|[C28303](../code-quality/c28303.md)|An ambiguous \_Deref\_ operator was found on annotation.|
|[C28304](../code-quality/c28304.md)|An improperly placed \_Notref\_ operator was found applied to token.|
|[C28305](../code-quality/c28305.md)|An error while parsing a token was discovered.|
|[C28306](../code-quality/c28306.md)|The annotation on parameter is obsolescent|
|[C28307](../code-quality/c28307.md)|The annotation on parameter is obsolescent|
|[C28350](../code-quality/c28350.md)|The annotation describes a situation that is not conditionally applicable.|
|[C28351](../code-quality/c28351.md)|The annotation describes where a dynamic value (a variable) cannot be used in the condition.|
