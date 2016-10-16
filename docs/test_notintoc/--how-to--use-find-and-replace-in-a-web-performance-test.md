---
title: "- How to: Use Find and Replace in a Web Performance Test"
ms.custom: na
ms.date: "09/28/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.test.web.dialog.findreplace"
helpviewer_keywords: 
  - "Web performance tests, finding and replacing strings"
  - "find and replace, Web performance tests"
ms.assetid: 7cf0e6d0-8f25-4a0c-9f98-d4dfa528500d
caps.latest.revision: 18
ms.author: "ahomer"
manager: "kamrani"
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
# - How to: Use Find and Replace in a Web Performance Test
You can quickly find and replace text in the Web requests of a Web performance test by using the Web Performance Test Editor.  
  
 You can create a context parameter to easily replace all instances of a string in the Web test with the context parameter by using **Find and Replace in Request**. For example, if you want to parameterize the site portion of `http://servername/``sitename``/sitepage` you could create a context parameter for `sitename` called `{{newsitename}}` and use **Find and Replace in Request** to replace all the instances in the Web performance test of `sitename` with `newsitename`. [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)] [How to: Use Context Parameters in a Web Performance Test](../test_notintoc/how-to--use-context-parameters-in-a-web-performance-test.md).  
  
> [!NOTE]
>  You cannot use CTRL+F for find and replace functionality in a Web performance test. CTRL+F opens the Visual Studio **Find and Replace** dialog box. In a Web performance test, you must use the **Find and Replace in Request** in the shortcut menu of a node.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
### To find and replace in a Web performance test  
  
1.  Open a Web performance test.  
  
     The Web Performance Test Editor opens and the request tree for the Web performance test is displayed.  
  
2.  In the request tree, right-click any node and then choose **Find and Replace in Request**.  
  
     The **Find and Replace in Request** dialog box is displayed.  
  
    > [!NOTE]
    >  You cannot use CTRL+F for find and replace functionality in a Web performance test. CTRL+F opens the Visual Studio **Find and Replace** dialog box. In a Web performance test, you must use the **Find and Replace in Request** in the shortcut menu of a node.  
  
3.  In the **Find what** text box, type the text you want to find.  
  
4.  In the **Replace with** text box, type the text you want to use to replace what you entered in the **Find what** text box.  
  
5.  Choose **Find Next** to locate the first occurrence of the text you entered in the **Find what** text box in a Web request.  
  
6.  If you determine you want to replace the occurrence, choose **Replace**; otherwise, choose **Find Next** to search for the next occurrence.  
  
7.  Repeat steps 5 and 6 until you find all the occurrences in all the Web requests.  
  
     -or-  
  
     Choose **Replace All** to replace all occurrences in all the Web requests of the text you entered in the **Find what** text box with the text you entered in the **Replace with** text box.  
  
## See Also  
 [Refining web performance test recordings](../test_notintoc/refining-web-performance-test-recordings.md)   
 [How to: Use Context Parameters in a Web Performance Test](../test_notintoc/how-to--use-context-parameters-in-a-web-performance-test.md)