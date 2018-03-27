---
title: "Sample Project for Creating Unit Tests in Visual Studio | Microsoft Docs"
ms.date: "11/04/2016"
ms.technology: vs-ide-test
ms.topic: "article"
helpviewer_keywords: 
  - "unit test sample [Visual Studio]"
  - "unit tests, samples"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: 
  - "multiple"
---
# Sample Project for Creating Unit Tests

This sample code is provided for use in the following walkthroughs:

- [Walkthrough: Creating and Running Unit Tests for Managed Code](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md). This walkthrough leads you through the steps to create and customize unit tests, run them, and examine the test results.

- [Walkthrough: Using the command-line test utility](http://msdn.microsoft.com/Library/52c11992-9e94-4067-a4b7-59f19d69d867). In this walkthrough, you use the MSTest.exe command-line utility to run tests and view results.

## Sample Code

The only intentional error in this sample is that the in Debit method "m_balance += amount" should have a minus not a plus sign before the equals sign.

```csharp
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

/* The example companies, organizations, products, domain names, e-mail addresses, logos, people, places, and events depicted herein are fictitious. No association with any real company, organization, product, domain name, email address, logo, person, places, or events is intended or should be inferred. \*/

## Working with the Code

To work with this code, you first have to create a project for it in Visual Studio. Follow the steps in the "Prepare the Walkthrough" section in [Walkthrough: Creating and Running Unit Tests for Managed Code](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md).

## See also

- [Walkthrough: Creating and Running Unit Tests for Managed Code](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md)
- [Walkthrough: using the command-line test utility](http://msdn.microsoft.com/Library/52c11992-9e94-4067-a4b7-59f19d69d867)
