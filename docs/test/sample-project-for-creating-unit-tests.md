---
title: "Sample Project for Creating Unit Tests | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "unit test sample [Visual Studio]"
  - "unit tests, samples"
ms.assetid: db80aaf2-0652-4d3f-a8c5-2a98fd8502a2
caps.latest.revision: 30
ms.author: "mlearned"
manager: "douge"
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
# Sample Project for Creating Unit Tests
This sample code is provided for use in the following walkthroughs:  
  
-   [Walkthrough: Creating and Running Unit Tests for Managed Code](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md). This walkthrough leads you through the steps to create and customize unit tests, run them, and examine the test results.  
  
-   [Walkthrough: Run tests and view code coverage](http://msdn.microsoft.com/en-us/d4aab8e2-2140-4975-b4e3-41ef3fa944c8). This walkthrough illustrates  how to view code coverage data, which shows the proportion of your project's code that is being tested.  
  
-   [Walkthrough: using the command-line test utility](../Topic/Walkthrough:%20using%20the%20command-line%20test%20utility.md). In this walkthrough, you use the MSTest.exe command-line utility to run tests and view results.  
  
## Sample Code  
 The only intentional error in this sample is that the in Debit method "m_balance += amount" should have a minus not a plus sign before the equals sign.  
  
```  
using System;   
  
namespace BankAccountNS  
{  
    /// <summary>   
    /// Bank Account demo class.   
    /// </summary>   
    public class BankAccount  
    {  
        private string m_customerName;  
  
        private double m_balance;  
  
        private bool m_frozen = false;  
  
        private BankAccount()  
        {  
        }  
  
        public BankAccount(string customerName, double balance)  
        {  
            m_customerName = customerName;  
            m_balance = balance;  
        }  
  
        public string CustomerName  
        {  
            get { return m_customerName; }  
        }  
  
        public double Balance  
        {  
            get { return m_balance; }  
        }  
  
        public void Debit(double amount)  
        {  
            if (m_frozen)  
            {  
                throw new Exception("Account frozen");  
            }  
  
            if (amount > m_balance)  
            {  
                throw new ArgumentOutOfRangeException("amount");  
            }  
  
            if (amount < 0)  
            {  
                throw new ArgumentOutOfRangeException("amount");  
            }  
  
            m_balance += amount; // intentionally incorrect code  
        }  
  
        public void Credit(double amount)  
        {  
            if (m_frozen)  
            {  
                throw new Exception("Account frozen");  
            }  
  
            if (amount < 0)  
            {  
                throw new ArgumentOutOfRangeException("amount");  
            }  
  
            m_balance += amount;  
        }  
  
        private void FreezeAccount()  
        {  
            m_frozen = true;  
        }  
  
        private void UnfreezeAccount()  
        {  
            m_frozen = false;  
        }  
  
        public static void Main()  
        {  
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);   
  
            ba.Credit(5.77);  
            ba.Debit(11.22);  
            Console.WriteLine("Current balance is ${0}", ba.Balance);  
        }  
  
    }  
}  
```  
  
 /* The example companies, organizations, products, domain names, e-mail addresses, logos, people, places, and events depicted herein are fictitious.  No association with any real company, organization, product, domain name, email address, logo, person, places, or events is intended or should be inferred. \*/  
  
## Working with the Code  
 To work with this code, you first have to create a project for it in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. Follow the steps in the "Prepare the Walkthrough" section in [Walkthrough: Creating and Running Unit Tests for Managed Code](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md).  
  
## See Also  
 [Walkthrough: Creating and Running Unit Tests for Managed Code](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md)   
 [Walkthrough: Run tests and view code coverage](http://msdn.microsoft.com/en-us/d4aab8e2-2140-4975-b4e3-41ef3fa944c8)   
 [Walkthrough: using the command-line test utility](../Topic/Walkthrough:%20using%20the%20command-line%20test%20utility.md)