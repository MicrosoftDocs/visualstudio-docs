---
title: "Version Compatibility for Code Analysis Check-In Policies"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1af376e3-3be7-4445-803b-76a858567a5b
caps.latest.revision: 15
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Version Compatibility for Code Analysis Check-In Policies
If you must evaluate and author code analysis check-in policies using different versions of Team Explorer, you must know the differences in how Visual Studio Team System 2008 Team Foundation Server and Team Foundation Server 2010 evaluate check-in policies.  
  
## Version Compatibility for Evaluating Check-In Policies  
  
-   When code analysis check-in policies are evaluated in Team System 2008 Team Foundation Server, any rules that existed in Team Foundation Server 2010 but do not exist in Team System 2008 Team Foundation Server are ignored.  
  
-   When code analysis check-in policies are evaluated in Team Foundation Server 2010, all new rules that are exclusive to Team System 2008 Team Foundation Server are ignored.  
  
-   If the code analysis check-in policy specifies rules assemblies, Team System 2008 Team Foundation Server ignores all rules that are specified by assemblies that it does not recognize.  
  
-   If the code analysis check-in policy specifies rules assemblies that Team Foundation Server 2010 does not recognize, a message is displayed.  
  
## Version Compatibility for Authoring Check-In Policies  
  
-   If you created a code analysis check-in policy by using the Team System 2008 Team Foundation Server version of Team Explorer, you cannot use the Team Foundation Server 2010 version of Team Explorer to modify it. And also, Team Foundation Server 2010 cannot evaluate the policy.  
  
-   If you created a code analysis check-in policy by using Team Explorer in Team Foundation Server 2010, you can use Team Explorer in Team System 2008 Team Foundation Server to modify it, and the policy can also be evaluated by Team System 2008 Team Foundation Server. After you modify the policy by using Team Explorer in Team System 2008 Team Foundation Server, you can no longer edit the policy by using Team Explorer in Team Foundation Server 2010. Team Foundation Server 2010 can evaluate the policies without problems with mismatched strong names.  
  
-   To create a code analysis check-in policy with rule settings that apply for both Team Foundation Server 2010 and Team System 2008 Team Foundation Server, you must create the policy in Team Foundation Server 2010, make all the changes needed, and save the policy. If the changes to rules exist only in Team System 2008 Team Foundation Server, you modify and save the policy in Team System 2008 Team Foundation Server.  
  
     After you save the policy in Team System 2008 Team Foundation Server, you can no longer change settings for rules that exist in Team Foundation Server 2010 only.