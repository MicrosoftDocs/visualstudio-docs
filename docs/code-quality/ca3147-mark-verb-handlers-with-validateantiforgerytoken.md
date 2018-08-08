---
title: "CA3147: Mark verb handlers with ValidateAntiforgeryToken"
ms.date: 08/04/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-code-analysis
ms.topic: reference
ms.assetid: 
author: paulming
ms.author: paulming
manager: 
ms.workload:
  - "multiple"
---
# CA3147: Mark verb handlers with ValidateAntiforgeryToken
|||
|-|-|
|TypeName|MarkVerbHandlersWithValidateAntiforgeryToken|
|CheckId|CA3147|
|Category|Microsoft.Security|
|Breaking Change|Non Breaking|

## Cause
 An ASP.NET MVC controller action method isn't marked with [ValidateAntiforgeryTokenAttribute](/previous-versions/aspnet/web-frameworks/dd492108%28v%3dvs.118%29), or an attribute specifying the HTTP verb, such as [HttpGetAttribute](/previous-versions/aspnet/web-frameworks/ee470993%28v%3dvs.118%29) or [AcceptVerbsAttribute](/previous-versions/aspnet/web-frameworks/dd470553%28v%3dvs.118%29).  

## Rule Description
 When designing an ASP.NET MVC controller, be mindful of cross-site request forgery attacks.  A cross-site request forgery attack can send malicious requests from an authenticated user to your ASP.NET MVC controller.  For more information, see [XSRF/CSRF Prevention in ASP.NET MVC and Web Pages](/aspnet/mvc/overview/security/xsrfcsrf-prevention-in-aspnet-mvc-and-web-pages).
 
 This rule checks that ASP.NET MVC controller action methods have either:

- [ValidateAntiforgeryTokenAttribute](/previous-versions/aspnet/web-frameworks/dd492108%28v%3dvs.118%29) and specify allowed HTTP verbs, not including HTTP GET.

- Or, specify HTTP GET as an allowed verb.

## How to Fix Violations

- For ASP.NET MVC controller actions that handle HTTP GET requests and *don't* have potentially harmful side effects, add an [HttpGetAttribute](/previous-versions/aspnet/web-frameworks/ee470993%28v%3dvs.118%29) to the method.

    - If you have an ASP.NET MVC controller action that handles HTTP GET requests and *does* have potentially harmful side effects such as modifying sensitive data, then your application is vulnerable to cross-site request forgery attacks.  You'll need to redesign your application so that only HTTP POST, PUT, or DELETE requests do sensitive operations.

- For ASP.NET MVC controller actions that handle HTTP POST, PUT, or DELETE requests, add [ValidateAntiforgeryTokenAttribute](/previous-versions/aspnet/web-frameworks/dd492108%28v%3dvs.118%29) and attribute(s) specifying the allowed HTTP verbs ([AcceptVerbsAttribute](/previous-versions/aspnet/web-frameworks/dd470553%28v%3dvs.118%29), [HttpPostAttribute](/previous-versions/aspnet/web-frameworks/ee264023%28v%3dvs.118%29), [HttpPutAttribute](/previous-versions/aspnet/web-frameworks/ee470909%28v%3dvs.118%29), or [HttpDeleteAttribute](/previous-versions/aspnet/web-frameworks/ee470917%28v%3dvs.118%29)).  Additionally, you need to call [HtmlHelper.AntiForgeryToken()](/previous-versions/aspnet/web-frameworks/dd504812%28v%3dvs.118%29) from your MVC view or Razor web page (see [Examining the Edit Methods and Edit View](/aspnet/mvc/overview/getting-started/introduction/examining-the-edit-methods-and-edit-view) for an example).

## When to Suppress Warnings

- It is safe to suppress a warning from this rule if the ASP.NET MVC controller action has no harmful side effects.

- It is safe to suppress a warning from this rule if the application is validating the antiforgery token through a different way.

## Pseudo-code Examples

### Violation

```csharp
namespace TestNamespace
{
    using System.Web.Mvc;

    public class TestController : Controller
    {
        public ActionResult TransferMoney(string toAccount, string amount)
        {
            // You don't want an attacker specify to who and how much money to transfer.

            return null;
        }
    }
}
```

### Solution

```csharp
using System;
using System.Xml;

namespace TestNamespace
{
    using System.Web.Mvc;

    public class TestController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TransferMoney(string toAccount, string amount)
        {
            return null;
        }
    }
}
```

### Violation

```csharp
namespace TestNamespace
{
    using System.Web.Mvc;

    public class TestController : Controller
    {
        public ActionResult Help(int topicId)
        {
            // This Help method is an example of a read-only operation with no harmful side effects.
            return null;
        }
    }
}
```

### Solution

```csharp
namespace TestNamespace
{
    using System.Web.Mvc;

    public class TestController : Controller
    {
        [HttpGet]
        public ActionResult Help(int topicId)
        {
            return null;
        }
    }
}
```
