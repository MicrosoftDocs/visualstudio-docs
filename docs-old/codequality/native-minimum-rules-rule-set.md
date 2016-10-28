---
title: "Native Minimum Rules rule set"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 2d898bc4-fba5-472e-8f09-b0c6b511c5a3
caps.latest.revision: 3
ms.author: "susanno"
manager: "douge"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Native Minimum Rules rule set
The Microsoft Native Minimum Rules focus on the most critical problems in your native code, including potential security holes and  application crashes. You should include this rule set in any custom rule set you create for your native projects.  
  
|Rule|Description|  
|----------|-----------------|  
|[C6001](../codequality/c6001.md)|Using Uninitialized Memory|  
|[C6011](../codequality/c6011.md)|Dereferencing Null Pointer|  
|[C6029](../codequality/c6029.md)|Use Of Unchecked Value|  
|[C6053](../codequality/c6053.md)|Zero Termination From Call|  
|[C6059](../codequality/c6059.md)|Bad Concatenation|  
|[C6063](../codequality/c6063.md)|Missing String Argument To Format Function|  
|[C6064](../codequality/c6064.md)|Missing Integer Argument To Format Function|  
|[C6066](../codequality/c6066.md)|Missing Pointer Argument To Format Function|  
|[C6067](../codequality/c6067.md)|Missing String Pointer Argument To Format Function|  
|[C6101](../codequality/c6101.md)|Returning uninitialized memory|  
|[C6200](../codequality/c6200.md)|Index Exceeds Buffer Maximum|  
|[C6201](../codequality/c6201.md)|Index Exceeds Stack Buffer Maximum|  
|[C6270](../codequality/c6270.md)|Missing Float Argument To Format Function|  
|[C6271](../codequality/c6271.md)|Extra Argument To Format Function|  
|[C6272](../codequality/c6272.md)|Non-Float Argument To Format Function|  
|[C6273](../codequality/c6273.md)|Non-Integer Argumen To Format Function|  
|[C6274](../codequality/c6274.md)|Non-Character Argument To Format Function|  
|[C6276](../codequality/c6276.md)|Invalid String Cast|  
|[C6277](../codequality/c6277.md)|Invalid CreateProcess Call|  
|[C6284](../codequality/c6284.md)|Invalid Object Argument To Format Function|  
|[C6290](../codequality/c6290.md)|Logical-Not Bitwise-And Precedence|  
|[C6291](../codequality/c6291.md)|Logical-Not Bitwise-Or Precedence|  
|[C6302](../codequality/c6302.md)|Invalid Character String Argument To Format Function|  
|[C6303](../codequality/c6303.md)|Invalid Wide Character String Argument To Format Function|  
|[C6305](../codequality/c6305.md)|Mismatched Size And Count Use|  
|[C6306](../codequality/c6306.md)|Incorrect Variable Argument Function Call|  
|[C6328](../codequality/c6328.md)|Potential Argument Type Mismatch|  
|[C6385](../codequality/c6385.md)|Read Overrun|  
|[C6386](../codequality/c6386.md)|Write Overrun|  
|[C6387](../codequality/c6387.md)|Invalid Parameter Value|  
|[C6500](../codequality/c6500.md)|Invalid Attribute Property|  
|[C6501](../codequality/c6501.md)|Conflicting Attribute Property Values|  
|[C6503](../codequality/c6503.md)|References Cannot Be Null|  
|[C6504](../codequality/c6504.md)|Null On Non-Pointer|  
|[C6505](../codequality/c6505.md)|MustCheck On Void|  
|[C6506](../codequality/c6506.md)|Buffer Size On Non-Pointer Or Array|  
|[C6507](assetId:///18f88cd1-d035-4403-a6a4-12dd0affcf21)|Null Mismatch At Dereference Zero|  
|[C6508](../codequality/c6508.md)|Write Access On Constant|  
|[C6509](../codequality/c6509.md)|Return Used On Precondition|  
|[C6510](../codequality/c6510.md)|Null Terminated On Non-Pointer|  
|[C6511](../codequality/c6511.md)|MustCheck Must Be Yes Or No|  
|[C6513](../codequality/c6513.md)|Element Size Without Buffer Size|  
|[C6514](../codequality/c6514.md)|Buffer Size Exceeds Array Size|  
|[C6515](../codequality/c6515.md)|Buffer Size On Non-Pointer|  
|[C6516](../codequality/c6516.md)|No Properties On Attribute|  
|[C6517](../codequality/c6517.md)|Valid Size On Non-Readable Buffer|  
|[C6518](../codequality/c6518.md)|Writable Size On Non-Writable Buffer|  
|[C6519](assetId:///2b6326b0-0539-4d26-8fb1-720114933232)|Invalid annotation: value of the 'NeedsRelease' property must be Yes or No|  
|[C6521](assetId:///e98d0ae3-6f13-47b2-9a15-15d4055af9ef)|Invalid Size String Dereference|  
|[C6522](../codequality/c6522.md)|Invalid Size String Type|  
|[C6523](assetId:///11397a31-b224-46b0-afb7-d49ca576a3bb)|Invalid Size String Parameter|  
|[C6525](../codequality/c6525.md)|Invalid Size String Unreachable Location|  
|[C6526](assetId:///59c590c7-0098-4166-a1ac-87f324596002)|Invalid Size String Buffer Type|  
|[C6527](../codequality/c6527.md)|Invalid annotation: 'NeedsRelease' property may not be used on values of void type|  
|[C6530](../codequality/c6530.md)|Unrecognized Format String Style|  
|[C6540](../codequality/c6540.md)|The use of attribute annotations on this function will invalidate all of its existing __declspec annotations|  
|[C6551](../codequality/c6551.md)|Invalid size specification: expression not parsable|  
|[C6552](../codequality/c6552.md)|Invalid Deref= or Notref=: expression not parsable|  
|[C6701](../codequality/c6701.md)|The value is not a valid Yes/No/Maybe value|  
|[C6702](../codequality/c6702.md)|The value is not a string value|  
|[C6703](../codequality/c6703.md)|The value is not a number|  
|[C6704](../codequality/c6704.md)|Unexpected Annotation Expression Error|  
|[C6705](../codequality/c6705.md)|Expected number of arguments for annotation does not match actual number of arguments for annotation|  
|[C6706](../codequality/c6706.md)|Unexpected Annotation Error for annotation|  
|[C28021](../codequality/c28021.md)|The parameter being annotated must be a pointer|  
|[C28182](../codequality/c28182.md)|Dereferencing NULL pointer. The pointer contains the same NULL value as another pointer did.|  
|[C28202](../codequality/c28202.md)|Illegal reference to non-static member|  
|[C28203](../codequality/c28203.md)|Ambiguous reference to class member.|  
|[C28205](../codequality/c28205.md)|_Success\_ or _On_failure\_ used in an illegal context|  
|[C28206](../codequality/c28206.md)|Left operand points to a struct, use '->'|  
|[C28207](../codequality/c28207.md)|Left operand is a struct, use '.'|  
|[C28210](../codequality/c28210.md)|Annotations for the __on_failure context must not be in explicit pre context|  
|[C28211](../codequality/c28211.md)|Static context name expected for SAL_context|  
|[C28212](../codequality/c28212.md)|Pointer expression expected for annotation|  
|[C28213](../codequality/c28213.md)|The _Use_decl_annotations\_ annotation must be used to reference, without modification, a prior declaration.|  
|[C28214](../codequality/c28214.md)|Attribute parameter names must be p1...p9|  
|[C28215](../codequality/c28215.md)|The typefix cannot be applied to a parameter that already has a typefix|  
|[C28216](../codequality/c28216.md)|The checkReturn annotation only applies to postconditions for the specific function parameter.|  
|[C28217](../codequality/c28217.md)|For function, the number of parameters to annotation does not match that found at file|  
|[C28218](../codequality/c28218.md)|For function paramteer, the annotation's parameter does not match that found at file|  
|[C28219](../codequality/c28219.md)|Member of enumeration expected for annotation the parameter in the annotation|  
|[C28220](../codequality/c28220.md)|Integer expression expected for annotation the parameter in the annotation|  
|[C28221](../codequality/c28221.md)|String expression expected for the parameter in the annotation|  
|[C28222](../codequality/c28222.md)|__yes, \__no, or \__maybe expected for annotation|  
|[C28223](../codequality/c28223.md)|Did not find expected Token/identifier for annotation, parameter|  
|[C28224](../codequality/c28224.md)|Annotation requires parameters|  
|[C28225](../codequality/c28225.md)|Did not find the correct number of required parameters in annotation|  
|[C28226](../codequality/c28226.md)|Annotation cannot also be a PrimOp (in current declaration)|  
|[C28227](../codequality/c28227.md)|Annotation cannot also be a PrimOp (see prior declaration)|  
|[C28228](../codequality/c28228.md)|Annotation parameter: cannot use type in annotations|  
|[C28229](../codequality/c28229.md)|Annotation does not support parameters|  
|[C28230](../codequality/c28230.md)|The type of parameter has no member.|  
|[C28231](../codequality/c28231.md)|Annotation is only valid on array|  
|[C28232](../codequality/c28232.md)|pre, post, or deref not applied to any annotation|  
|[C28233](../codequality/c28233.md)|pre, post, or deref applied to a block|  
|[C28234](../codequality/c28234.md)|__at expression does not apply to current function|  
|[C28235](../codequality/c28235.md)|The function cannot stand alone as an annotation|  
|[C28236](../codequality/c28236.md)|The annotation cannot be used in an expression|  
|[C28237](../codequality/c28237.md)|The annotation on parameter is no longer supported|  
|[C28238](../codequality/c28238.md)|The annotation on parameter has more than one of value, stringValue, and longValue. Use paramn=xxx|  
|[C28239](../codequality/c28239.md)|The annotation on parameter has both value, stringValue, or longValue; and paramn=xxx. Use only paramn=xxx|  
|[C28240](../codequality/c28240.md)|The annotation on parameter has param2 but no param1|  
|[C28241](../codequality/c28241.md)|The annotation for function on parameter is not recognized|  
|[C28243](../codequality/c28243.md)|The annotation for function on parameter requires more dereferences than the actual type annotated allows|  
|[C28245](../codequality/c28245.md)|The annotation for function annotates 'this' on a non-member-function|  
|[C28246](../codequality/c28246.md)|The parameter annotation for function does not match the type of the parameter|  
|[C28250](../codequality/c28250.md)|Inconsistent annotation for function: the prior instance has an error.|  
|[C28251](../codequality/c28251.md)|Inconsistent annotation for function: this instance has an error.|  
|[C28252](../codequality/c28252.md)|Inconsistent annotation for function: parameter has another annotations on this instance.|  
|[C28253](../codequality/c28253.md)|Inconsistent annotation for function: parameter has another annotations on this instance.|  
|[C28254](../codequality/c28254.md)|dynamic_cast<>() is not supported in annotations|  
|[C28262](../codequality/c28262.md)|A syntax error in the annotation was found in function, for annotation|  
|[C28263](../codequality/c28263.md)|A syntax error in a conditional annotation was found for Intrinsic annotation|  
|[C28264](assetId:///bf6ea983-a06e-4752-a042-747a7dbf338c)|Result lists values must be constants.|  
|[C28267](../codequality/c28267.md)|A syntax error in the annotations was found annotation in the function.|  
|[C28272](../codequality/c28272.md)|The annotation for function, parameter when examining is inconsistent with the function declaration|  
|[C28273](../codequality/c28273.md)|For function, the clues are inconsistent with the function declaration|  
|[C28275](../codequality/c28275.md)|The parameter to _Macro_value\_ is null|  
|[C28279](../codequality/c28279.md)|For symbol, a 'begin' was found without a matching 'end'|  
|[C28280](../codequality/c28280.md)|For symbol, an 'end' was found without a matching 'begin'|  
|[C28282](../codequality/c28282.md)|Format Strings must be in preconditions|  
|[C28285](../codequality/c28285.md)|For function, syntax error in parameter|  
|[C28286](../codequality/c28286.md)|For function, syntax error near the end|  
|[C28287](../codequality/c28287.md)|For function, syntax Error in _At\_() annotation (unrecognized parameter name)|  
|[C28288](../codequality/c28288.md)|For function, syntax Error in _At\_() annotation (invalid parameter name)|  
|[C28289](../codequality/c28289.md)|For function: ReadableTo or WritableTo did not have a limit-spec as a parameter|  
|[C28290](../codequality/c28290.md)|the annotation for function contains more Externals than the actual number of parameters|  
|[C28291](../codequality/c28291.md)|post null/notnull at deref level 0 is meaningless for function.|  
|[C28300](../codequality/c28300.md)|Expression operands of incompatible types for operator|  
|[C28301](../codequality/c28301.md)|No annotations for first declaration of function.|  
|[C28302](../codequality/c28302.md)|An extra _Deref\_ operator was found on annotation.|  
|[C28303](../codequality/c28303.md)|An ambiguous _Deref\_ operator was found on annotation.|  
|[C28304](../codequality/c28304.md)|An improperly placed _Notref\_ operator was found applied to token.|  
|[C28305](../codequality/c28305.md)|An error while parsing a token was discovered.|  
|[C28350](../codequality/c28350.md)|The annotation describes a situation that is not conditionally applicable.|  
|[C28351](../codequality/c28351.md)|The annotation describes where a dynamic value (a variable) cannot be used in the condition.|