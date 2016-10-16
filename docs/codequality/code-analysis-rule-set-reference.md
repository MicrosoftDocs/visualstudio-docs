---
title: "Code analysis rule set reference"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "code analysis, rule sets"
ms.assetid: 5874e854-e298-4d2e-bbe4-95e899d22587
caps.latest.revision: 43
ms.author: "douge"
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
# Code analysis rule set reference
When you configure code analysis for managed code projects in [!INCLUDE[vsPreLong](../codequality/includes/vsprelong_md.md)], [!INCLUDE[vsUltLong](../codequality/includes/vsultlong_md.md)], or [!INCLUDE[vsPro](../codequality/includes/vspro_md.md)]you are presented with a list of built-in *rule sets*. You can either use one of the standar rule sets, or you can customize a  rule set to fit your project requirements.  
  
## Available Rule Sets  
 The following table lists the default rule sets:  
  
|||  
|-|-|  
|[All Rules rule set](../codequality/all-rules-rule-set.md)|This rule set contains all rules. Running this rule set may result in a large number of warnings being reported. Use this rule set to get a comprehensive picture of all issues in your code. This can help you decide which of the more focused rule sets are most appropriate to run for your projects.|  
|[Basic Correctness Rules rule set for managed code](../codequality/basic-correctness-rules-rule-set-for-managed-code.md)|These rules focus on logic errors and common mistakes made in the usage of framework APIs. Include this rule set to expand on the list of warnings reported by the minimum recommended rules.|  
|[Basic Design Guideline Rules rule set for managed code](../codequality/basic-design-guideline-rules-rule-set-for-managed-code.md)|These rules focus on enforcing best practices to make your code easy to understand and use. Include this rule set if your project includes library code or if you want to enforce best practices for easily maintainable code.|  
|[Extended Correctness Rules rule set for managed code](../codequality/extended-correctness-rules-rule-set-for-managed-code.md)|These rules expand on the basic correctness rules to maximize the logic and framework usage errors that are reported. Extra emphasis is placed on specific scenarios such as COM interop and mobile applications. Consider including this rule set if one of these scenarios applies to your project or to find additional problems in your project.|  
|[Extended Design Guidelines Rules rule set for managed code](../codequality/extended-design-guidelines-rules-rule-set-for-managed-code.md)|These rules expand on the basic design guideline rules to maximize the usability and maintainability issues that are reported. Extra emphasis is placed on naming guidelines. Consider including this rule set if your project includes library code or if you want to enforce the highest standards for writing maintainable code.|  
|[Globalization Rules rule set for managed code](../codequality/globalization-rules-rule-set-for-managed-code.md)|These rules focus on problems that prevent data in your application from displaying correctly when used in different languages, locales, and cultures. Include this rule set if your application is localized or globalized.|  
|[Managed Minimun Rules rule set for managed code](../codequality/managed-minimun-rules-rule-set-for-managed-code.md)|These rules focus on the most critical problems in your code for which Code Analysis is the most accurate.  These rules are small in number and they are intended only to run in limited Visual Studio editions.  Use MinimumRecommendedRules.ruleset with other Visual Studio editions.|  
|[Managed Recommended Rules rule set for managed code](../codequality/managed-recommended-rules-rule-set-for-managed-code.md)|These rules focus on the most critical problems in your code, including potential security holes, application crashes, and other important logic and design errors. You should include this rule set in any custom rule set you create for your projects.|  
|[Mixed Minimum Rules rule set](../codequality/mixed-minimum-rules-rule-set.md)|These rules focus on the most critical problems in your C++ projects that support the Common Language Runtime, including potential security holes and application crashes. You should include this rule set in any custom rule set you create for your C++ projects that support the Common Language Runtime.|  
|[Mixed Recommended Rules rule set](../codequality/mixed-recommended-rules-rule-set.md)|These rules focus on the most common and critical problems in your C++ projects that support the Common Language Runtime, including potential security holes, application crashes, and other important logic and design errors. You should include this rule set in any custom rule set you create for your C++ projects that support the Common Language Runtime.  This ruleset is designed to be configured with the Visual Studio Professional edition and higher.|  
|[Native Minimum Rules rule set](../codequality/native-minimum-rules-rule-set.md)|These rules focus on the most critical problems in your native code, including potential security holes and  application crashes. You should include this rule set in any custom rule set you create for your native projects.|  
|[Native Recommended Rules rule set](../codequality/native-recommended-rules-rule-set.md)|These rules focus on the most critical and common problems in your native code, including potential security holes and application crashes.  You should include this rule set in any custom rule set you create for your native projects.  This ruleset is designed to work with Visual Studio Professional edition and higher.|  
|[Security Rules rule set for managed code](../codequality/security-rules-rule-set-for-managed-code.md)|This rule set contains all Microsoft security rules. Include this rule set to maximize the number of potential security issues that are reported.|