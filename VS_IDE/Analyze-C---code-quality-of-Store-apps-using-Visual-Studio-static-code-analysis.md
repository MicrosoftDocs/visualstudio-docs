---
title: "Analyze C++ code quality of Store apps using Visual Studio static code analysis"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c5355e43-a37c-4686-a969-18e3dfc59a9c
caps.latest.revision: 13
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pt-br
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - tr-tr
---
# Analyze C++ code quality of Store apps using Visual Studio static code analysis
![Applies to Windows and Windows Phone](../VS_debugger/media/windows_and_phone_content.png "windows_and_phone_content")  
  
 The code analysis tool in Visual Studio express editions examines your code for a set of common problems and violations of good programming practice. Code analysis warnings differ from compiler errors and warnings because code analysis searches for specific code patterns that are valid but could still create issues for you or other people who use your code. Code analysis can also find defects in your code that are difficult to discover through testing. Running the code analysis tool at regular intervals during your development process can enhance the quality of your completed app.  
  
> [!NOTE]
>  In Visual Studio Ultimate, Visual Studio Premium, and Visual Studio Professional, you can use the full functionality of code analysis tools. See [Analyzing Application Quality by Using Code Analysis Tools](http://msdn.microsoft.com/library/dd264897.aspx) in the MSDN Library.  
  
## In this topic  
 You can learn about:  
  
 [Running code analysis](../VS_IDE/Analyze-C---code-quality-of-Store-apps-using-Visual-Studio-static-code-analysis.md#BKMK_Run)  
  
 [Analyzing and resolving code analysis warnings](../VS_IDE/Analyze-C---code-quality-of-Store-apps-using-Visual-Studio-static-code-analysis.md#BKMK_Analyze)  
  
 [Suppressing code analysis warnings](../VS_IDE/Analyze-C---code-quality-of-Store-apps-using-Visual-Studio-static-code-analysis.md#BKMK_Suppress)  
  
 [Searching and filtering code analysis results](../VS_IDE/Analyze-C---code-quality-of-Store-apps-using-Visual-Studio-static-code-analysis.md#BKMK_Search)  
  
 [C++ code analysis warnings](../VS_IDE/Analyze-C---code-quality-of-Store-apps-using-Visual-Studio-static-code-analysis.md#Warnings)  
  
##  <a name="BKMK_Run"></a> Running code analysis  
 To run code analysis on your Visual Studio solution:  
  
-   On the **Build** menu, choose **Run Code Analysis on Solution**.  
  
 To automatically run code analysis each time you build a project:  
  
1.  Choose the project name in Solution Explorer and then choose **Properties**.  
  
2.  In the project property page, choose **Code Analysis** and then choose **Enable Code Analysis for C/C++ on Build**.  
  
 The solution is compiled and code analysis runs. Results appear in the Code Analysis window.  
  
 ![Code Analysis window](../VS_IDE/media/CA_CPP_Collapsed.png "CA_CPP_Collapsed")  
  
##  <a name="BKMK_Analyze"></a> Analyzing and resolving code analysis warnings  
 To analyze a specific warning, choose the title of the warning in the Code Analysis window. The warning expands to display detailed information about the issue. When possible, code analysis displays the line number and analysis logic that led to the warning.  
  
 ![Expanded code analysis warning](../VS_IDE/media/CA_CPP_Expanded_Callout.png "CA_CPP_Expanded_Callout")  
  
 When you expand a warning, the lines of code that caused the warning are highlighted in the Visual Studio code editor.  
  
 ![Highlighted source code](../VS_IDE/media/CA_CPP_SourceLine.png "CA_CPP_SourceLine")  
  
 After you understand the problem, you can resolve it in your code. Then rerun code analysis to make sure that the warning no longer appears in the Code Analysis window, and that your fix has not raised new warnings.  
  
> [!TIP]
>  You can rerun code analysis from the Code Analysis window. Choose the **Analyze** button and then choose the scope of the analysis. You can rerun analysis on the entire solution or on a selected project.  
  
##  <a name="BKMK_Suppress"></a> Suppressing code analysis warnings  
 There are times when you might decide not to fix a code analysis warning. You might decide that resolving the warning requires too much recoding in relation to the probability that the issue will arise in any real-world implementation of your code. Or you might believe that the analysis that is used in the warning is inappropriate for the particular context. You can suppress individual warnings so that they no longer appear in the Code Analysis window.  
  
 To suppress a warning:  
  
1.  If the detailed information is not displayed, expand the title of the warning.  
  
2.  Choose the **Actions** link at the bottom of the warning.  
  
3.  Choose to **Suppress Message** and then choose **In Source**.  
  
 Suppressing a message inserts `#pragma(warning:`*WarningId*`)` that suppresses the warning for the line of code.  
  
##  <a name="BKMK_Search"></a> Searching and filtering code analysis results  
 You can search long lists of warning messages and you can filter warnings in multi-project solutions.  
  
 ![Search and filter the code analysis window](../VS_IDE/media/CA_SearchFilter.png "CA_SearchFilter")  
  
##  <a name="Warnings"></a> C++ code analysis warnings  
 Code analysis raises the following warnings for C++ code:  
  
|Rule|Description|  
|----------|-----------------|  
|[C6001](../VS_IDE/C6001.md)|Using Uninitialized Memory|  
|[C6011](../VS_IDE/C6011.md)|Dereferencing Null Pointer|  
|[C6029](../VS_IDE/C6029.md)|Use Of Unchecked Value|  
|[C6053](../VS_IDE/C6053.md)|Zero Termination From Call|  
|[C6059](../VS_IDE/C6059.md)|Bad Concatenation|  
|[C6063](../VS_IDE/C6063.md)|Missing String Argument To Format Function|  
|[C6064](../VS_IDE/C6064.md)|Missing Integer Argument To Format Function|  
|[C6066](../VS_IDE/C6066.md)|Missing Pointer Argument To Format Function|  
|[C6067](../VS_IDE/C6067.md)|Missing String Pointer Argument To Format Function|  
|[C6101](../VS_IDE/C6101.md)|Returning uninitialized memory|  
|[C6200](../VS_IDE/C6200.md)|Index Exceeds Buffer Maximum|  
|[C6201](../VS_IDE/C6201.md)|Index Exceeds Stack Buffer Maximum|  
|[C6270](../VS_IDE/C6270.md)|Missing Float Argument To Format Function|  
|[C6271](../VS_IDE/C6271.md)|Extra Argument To Format Function|  
|[C6272](../VS_IDE/C6272.md)|Non-Float Argument To Format Function|  
|[C6273](../VS_IDE/C6273.md)|Non-Integer Argumen To Format Function|  
|[C6274](../VS_IDE/C6274.md)|Non-Character Argument To Format Function|  
|[C6276](../VS_IDE/C6276.md)|Invalid String Cast|  
|[C6277](../VS_IDE/C6277.md)|Invalid CreateProcess Call|  
|[C6284](../VS_IDE/C6284.md)|Invalid Object Argument To Format Function|  
|[C6290](../VS_IDE/C6290.md)|Logical-Not Bitwise-And Precedence|  
|[C6291](../VS_IDE/C6291.md)|Logical-Not Bitwise-Or Precedence|  
|[C6302](../VS_IDE/C6302.md)|Invalid Character String Argument To Format Function|  
|[C6303](../VS_IDE/C6303.md)|Invalid Wide Character String Argument To Format Function|  
|[C6305](../VS_IDE/C6305.md)|Mismatched Size And Count Use|  
|[C6306](../VS_IDE/C6306.md)|Incorrect Variable Argument Function Call|  
|[C6328](../VS_IDE/C6328.md)|Potential Argument Type Mismatch|  
|[C6385](../VS_IDE/C6385.md)|Read Overrun|  
|[C6386](../VS_IDE/C6386.md)|Write Overrun|  
|[C6387](../VS_IDE/C6387.md)|Invalid Parameter Value|  
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
|[C28021](../VS_IDE/C28021.md)|The parameter being annotated must be a pointer|  
|[C28182](../VS_IDE/C28182.md)|Dereferencing NULL pointer. The pointer contains the same NULL value as another pointer did.|  
|[C28202](../VS_IDE/C28202.md)|Illegal reference to non-static member|  
|[C28203](../VS_IDE/C28203.md)|Ambiguous reference to class member.|  
|[C28205](../VS_IDE/C28205.md)|_Success\_ or _On_failure\_ used in an illegal context|  
|[C28206](../VS_IDE/C28206.md)|Left operand points to a struct, use '->'|  
|[C28207](../VS_IDE/C28207.md)|Left operand is a struct, use '.'|  
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
|[C28350](../VS_IDE/C28350.md)|The annotation describes a situation that is not conditionally applicable.|  
|[C28351](../VS_IDE/C28351.md)|The annotation describes where a dynamic value (a variable) cannot be used in the condition.|