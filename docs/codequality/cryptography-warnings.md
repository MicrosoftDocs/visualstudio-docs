---
title: "Cryptography Warnings"
ms.custom: na
ms.date: "10/14/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: d96723ea-a293-488d-b9db-adb437e50cdd
caps.latest.revision: 7
ms.author: "gregvanl"
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
# Cryptography Warnings
Cryptography warnings support safer libraries and applications through the correct use of cryptography. These warnings help prevent security flaws in your program. If you disable any of these warnings, you should clearly mark the reason in code and also inform the designated security officer for your development project.  
  
|Rule|Description|  
|----------|-----------------|  
|[CA5350: Do Not Use Weak Cryptographic Algorithms](../codequality/ca5350--do-not-use-weak-cryptographic-algorithms.md)|Weak encryption algorithms and hashing functions are used today for a number of reasons, but they should not be used to guarantee the confidentiality or integrity of the data they protect.        This rule triggers when it finds TripleDES, SHA1, or RIPEMD160 algorithms in the code.|  
|[CA5351 Do Not Use Broken Cryptographic Algorithms](../codequality/ca5351-do-not-use-broken-cryptographic-algorithms.md)|Broken cryptographic algorithms are not considered secure and their use should be strongly discouraged. This rule triggers when it finds the MD5 hash algorithm or either the DES or RC2 encryption algorithms in code.|