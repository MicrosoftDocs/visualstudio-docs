---
title: "CA2202: Do not dispose objects multiple times"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: fa85349a-cf1e-42c8-a86b-eacae1f8bd96
caps.latest.revision: 20
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
# CA2202: Do not dispose objects multiple times
|||  
|-|-|  
|TypeName|DoNotDisposeObjectsMultipleTimes|  
|CheckId|CA2202|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A method implementation contains code paths that could cause multiple calls to <xref:System.IDisposable.Dispose?qualifyHint=True> or a Dispose equivalent, such as a Close() method on some types, on the same object.  
  
## Rule Description  
 A correctly implemented <xref:System.IDisposable.Dispose?qualifyHint=False> method can be called multiple times without throwing an exception. However, this is not guaranteed and to avoid generating a <xref:System.ObjectDisposedException?qualifyHint=True> you should not call <xref:System.IDisposable.Dispose?qualifyHint=False> more than one time on an object.  
  
## Related Rules  
 [CA2000: Dispose objects before losing scope](../VS_IDE/CA2000--Dispose-objects-before-losing-scope.md)  
  
## How to Fix Violations  
 To fix a violation of this rule, change the implementation so that regardless of the code path, <xref:System.IDisposable.Dispose?qualifyHint=False> is called only one time for the object.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule. Even if <xref:System.IDisposable.Dispose?qualifyHint=False> for the object is known to be safely callable multiple times, the implementation might change in the future.  
  
## Example  
 Nested `using` statements (`Using` in Visual Basic) can cause violations of the CA2202 warning. If the IDisposable resource of the nested inner `using` statement contains the resource of the outer `using` statement, the `Dispose` method of the nested resource releases the contained resource. When this situation occurs, the `Dispose` method of the outer `using` statement attempts to dispose its resource for a second time.  
  
 In the following example, a <xref:System.IO.Stream?qualifyHint=False> object that is created in an outer using statement is released at the end of the inner using statement in the Dispose method of the <xref:System.IO.StreamWriter?qualifyHint=False> object that contains the `stream` object. At the end of the outer `using` statement, the `stream` object is released a second time. The second release is a violation of CA2202.  
  
```  
using (Stream stream = new FileStream("file.txt", FileMode.OpenOrCreate))  
{  
    using (StreamWriter writer = new StreamWriter(stream))  
    {  
        // Use the writer object...  
    }  
}  
  
```  
  
## Example  
 To resolve this issue, use a `try`/`finally` block instead of the outer `using` statement. In the `finally` block, make sure that the `stream` resource is not null.  
  
```  
Stream stream = null;  
try  
{  
    stream = new FileStream("file.txt", FileMode.OpenOrCreate);  
    using (StreamWriter writer = new StreamWriter(stream))  
    {  
        stream = null;  
        // Use the writer object...  
    }  
}  
finally  
{  
    if(stream != null)  
        stream.Dispose();  
}  
  
```  
  
## See Also  
 <xref:System.IDisposable?qualifyHint=True>   
 [Dispose Pattern](../Topic/Dispose%20Pattern.md)