---
title: "Sample Project for Creating Unit Tests | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
helpviewer_keywords:
  - "unit test sample [Visual Studio]"
  - "unit tests, samples"
ms.assetid: db80aaf2-0652-4d3f-a8c5-2a98fd8502a2
caps.latest.revision: 32
ms.author: jillfra
manager: jillfra
---
# Sample Project for Creating Unit Tests
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This sample code is provided for use in the following walkthroughs:

- [Walkthrough: Creating and Running Unit Tests for Managed Code](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md). This walkthrough leads you through the steps to create and customize unit tests, run them, and examine the test results.

- [Walkthrough: Run tests and view code coverage](https://msdn.microsoft.com/d4aab8e2-2140-4975-b4e3-41ef3fa944c8). This walkthrough illustrates  how to view code coverage data, which shows the proportion of your project's code that is being tested.

- [Walkthrough: using the command-line test utility](https://msdn.microsoft.com/library/52c11992-9e94-4067-a4b7-59f19d69d867). In this walkthrough, you use the MSTest.exe command-line utility to run tests and view results.

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
 To work with this code, you first have to create a project for it in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. Follow the steps in the "Prepare the Walkthrough" section in [Walkthrough: Creating and Running Unit Tests for Managed Code](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md).

## See Also
 [Walkthrough: Creating and Running Unit Tests for Managed Code](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md)
 [Walkthrough: Run tests and view code coverage](https://msdn.microsoft.com/d4aab8e2-2140-4975-b4e3-41ef3fa944c8)
 [Walkthrough: using the command-line test utility](https://msdn.microsoft.com/library/52c11992-9e94-4067-a4b7-59f19d69d867)
