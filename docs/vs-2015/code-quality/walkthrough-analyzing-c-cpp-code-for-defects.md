---
title: "Walkthrough: Analyzing C-C++ Code for Defects | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
helpviewer_keywords: 
  - "C/C++, code analysis"
  - "code analysis, walkthroughs"
  - "code, analyzing C/C++"
  - "code analysis tool, walkthroughs"
ms.assetid: eaee55b8-85fe-47c7-a489-9be0c46ae8af
caps.latest.revision: 37
author: mikeblome
ms.author: mblome
manager: jillfra
---
# Walkthrough: Analyzing C/C++ Code for Defects
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This walkthrough demonstrates how to analyze C/C++ code for potential code defects by using the code analysis tool for C/C++ code.  
  
 In this walkthrough, you step through the process of using code analysis to analyze your C/C++ code for potential code defects.  
  
 You will complete the following steps:  
  
- Run code analysis on native code.  
  
- Analyze code defect warnings.  
  
- Treat warning as an error.  
  
- Annotate source code to improve code defect analysis.  
  
## Prerequisites  
  
- [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)] or [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)].  
  
- A copy of the [Demo Sample](../code-quality/demo-sample.md).  
  
- Basic understanding of C/C++.  
  
### To run code defect analysis on native code  
  
1. Open the Demo solution in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].  
  
     The Demo solution now populates **Solution Explorer**.  
  
2. On the **Build** menu, click **Rebuild Solution**.  
  
     The solution builds without any errors or warnings.  
  
3. In **Solution Explorer**, select the CodeDefects project.  
  
4. On the **Project** menu, click **Properties**.  
  
     The **CodeDefects Property Pages** dialog box is displayed.  
  
5. Click **Code Analysis**.  
  
6. Click the **Enable Code Analysis for C/C++ on Build** check box.  
  
7. Rebuild the CodeDefects project.  
  
     Code analysis warnings are displayed in the **Error List**.  
  
### To analyze code defect warnings  
  
1. On the **View** menu, click **Error List**.  
  
     Depending on the developer profile that you chose in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], you might have to point to **Other Windows** on the **View** menu, and then click **Error List**.  
  
2. In the **Error List**, double-click the following warning:  
  
     warning C6230: Implicit cast between semantically different types: using HRESULT in a Boolean context.  
  
     The code editor displays the line that caused the warning in the function `bool``ProcessDomain()`. This warning indicates that a HRESULT is being used in an 'if' statement where a Boolean result is expected.  
  
3. Correct this warning by using the SUCCEEDED macro. Your code should resemble the following code:  
  
    ```  
    if (SUCCEEDED (ReadUserAccount()) )  
    ```  
  
4. In the **Error List**, double-click the following warning:  
  
     warning C6282: Incorrect operator: assignment to constant in test context. Was == intended?  
  
5. Correct this warning by testing for equality. Your code should look similar to the following code:  
  
    ```  
    if ((len == ACCOUNT_DOMAIN_LEN) || (g_userAccount[len] != '\\'))  
    ```  
  
### To treat warning as an error  
  
1. In the Bug.cpp file, add the following `#pragma` statement to the beginning of the file to treat the warning C6001 as an error:  
  
    ```  
    #pragma warning (error: 6001)  
    ```  
  
2. Rebuild the CodeDefects project.  
  
     In the **Error List**, C6001 now appears as an error.  
  
3. Correct the remaining two C6001 errors in the **Error List** by initializing `i` and `j` to 0.  
  
4. Rebuild the CodeDefects project.  
  
     The project builds without any warnings or errors.  
  
### To correct the source code annotation warnings in annotation.c  
  
1. In Solution Explorer, select the Annotations project.  
  
2. On the **Project** menu, click **Properties**.  
  
     The **Annotations Property Pages** dialog box is displayed.  
  
3. Click **Code Analysis**.  
  
4. Select the **Enable Code Analysis for C/C++ on Build** check box.  
  
5. Rebuild the Annotations project.  
  
6. In the **Error List**, double-click the following warning:  
  
     warning C6011: Dereferencing NULL pointer 'newNode'.  
  
     This warning indicates failure by the caller to check the return value. In this case, a call to **AllocateNode** might return a NULL value (see the annotations.h header file for function declaration for AllocateNode).  
  
7. Open the annotations.cpp file.  
  
8. To correct this warning, use an 'if' statement to test the return value. Your code should resemble the following code:  
  
     `if (NULL != newNode)`  
  
     `{`  
  
     `newNode->data = value;`  
  
     `newNode->next = 0;`  
  
     `node->next = newNode;`  
  
     `}`  
  
9. Rebuild the Annotations project.  
  
     The project builds without any warnings or errors.  
  
### To use source code annotation  
  
1. Annotate formal parameters and return value of the function `AddTail` by using the Pre and Post conditions as shown in this example:  
  
     `[returnvalue:SA_Post (Null=SA_Maybe)] LinkedList* AddTail`  
  
     `(`  
  
     `[SA_Pre(Null=SA_Maybe)] LinkedList* node,`  
  
     `int value`  
  
     `)`  
  
2. Rebuild Annotations project.  
  
3. In the **Error List**, double-click the following warning:  
  
     warning C6011: Dereferencing NULL pointer 'node'.  
  
     This warning indicates that the node passed into the function might be null, and indicates the line number where the warning was raised.  
  
4. To correct this warning, use an 'if' statement to test the return value. Your code should resemble the following code:  
  
    ```  
    . . .  
    LinkedList *newNode = NULL;   
    if (NULL == node)  
    {  
         return NULL;  
        . . .  
    }  
    ```  
  
5. Rebuild Annotations project.  
  
     The project builds without any warnings or errors.  
  
## See Also  
 [Walkthrough: Analyzing Managed Code for Code Defects](../code-quality/walkthrough-analyzing-managed-code-for-code-defects.md)
