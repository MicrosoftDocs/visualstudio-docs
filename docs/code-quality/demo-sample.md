---
title: Sample C++ project for code analysis
ms.date: 11/04/2016
ms.topic: sample
helpviewer_keywords:
  - "demo sample [Visual Studio ALM]"
  - "code analysis, samples"
ms.assetid: 09e1b9f7-5916-4ed6-a001-5c2d7e710682
author: mikeblome
ms.author: mblome
manager: markl
ms.workload:
  - "multiple"
---
# Sample C++ project for code analysis

This following procedures show you how to create the sample for [Walkthrough: Analyze C/C++ code for defects](../code-quality/walkthrough-analyzing-c-cpp-code-for-defects.md). The procedures create:

- A Visual Studio solution named CppDemo.

- A static library project named CodeDefects.

- A static library project named Annotations.

The procedures also provide the code for the header and *.cpp* files for the static libraries.

## Create the CppDemo solution and the CodeDefects project

1. Click the **File** menu, point to **New**, and then click **New Project**.

2. In the **Project types** tree list, if C++ is not your default language in VS expand **Other Languages**.

3. Expand **Visual C++**, and then click **General**.

4. In **Templates**, click **Empty Project**.

5. In the **Name** text box, type **CodeDefects**.

6. Select the **Create directory for solution** check box.

7. In the **Solution Name** text box, type **CppDemo**.

## Configure the CodeDefects project as a static library

1. In Solution Explorer, right-click **CodeDefects** and then click **Properties**.

2. Expand **Configuration Properties** and then click **General**.

3. In the **General** list, select the text in the column next to **Target Extension**, and then type **.lib**.

4. In **Project Defaults**, click the column next to **Configuration Type**, and then click **Static Lib (.lib)**.

## Add the header and source file to the CodeDefects project

1. In Solution Explorer, expand **CodeDefects**, right-click **Header Files**, click **Add**, and then click **New Item**.

2. In the **Add New Item** dialog box, click **Code**, and then click **Header File (.h)**.

3. In the **Name** box, type **Bug.h** and then click **Add**.

4. Copy the following code and paste it into the *Bug.h* file in the Visual Studio editor.

    ```cpp
    #include <windows.h>

    //
    //These 3 functions are consumed by the sample
    //  but are not defined. This project cannot be linked!
    //

    bool CheckDomain( LPCSTR );
    HRESULT ReadUserAccount();

    //
    //These constants define the common sizes of the
    //  user account information throughout the program
    //

    const int USER_ACCOUNT_LEN = 256;
    const int ACCOUNT_DOMAIN_LEN = 128;
    ```

5. In Solution Explorer, right-click **Source Files**, point to **New**, and then click **New Item**.

6. In the **Add New Item** dialog box, click **C++ File (.cpp)**

7. In the **Name** box, type **Bug.cpp** and then click **Add**.

8. Copy the following code and paste it into the *Bug.cpp* file in the Visual Studio editor.

    ```cpp
    #include <stdlib.h>
    #include "Bug.h"

    // the user account
    TCHAR g_userAccount[USER_ACCOUNT_LEN] = "";
    int len = 0;

    bool ProcessDomain()
    {
        TCHAR* domain = new TCHAR[ACCOUNT_DOMAIN_LEN];
        // ReadUserAccount gets a 'domain\user' input from
        //the user into the global 'g_userAccount'
        if (ReadUserAccount() )
        {

            // Copies part of the string prior to the '\'
            // character onto the 'domain' buffer
            for( len = 0 ; (len < ACCOUNT_DOMAIN_LEN) && (g_userAccount[len] != '\0') ; len++  )
            {
                if ( g_userAccount[len] == '\\' )
                {
                    // Stops copying on the domain and user separator ('\')
                    break;
                }
                domain[len] = g_userAccount[len];
            }
            if((len= ACCOUNT_DOMAIN_LEN) || (g_userAccount[len] != '\\'))
            {
                // '\' was not found. Invalid domain\user string.
                delete [] domain;
                return false;
            }
            else
            {
                domain[len]='\0';
            }
            // Process domain string
            bool result = CheckDomain( domain );

            delete[] domain;
            return result;
        }
        return false;
    }

    int path_dependent(int n)
    {
        int i;
        int j;
        if (n == 0)
            i = 1;
        else
            j = 1;
        return i+j;
    }
    ```

9. Click the **File** menu, and then click **Save All**.

## Add the Annotations project and configure it as a static library

1. In Solution Explorer, click **CppDemo**, point to **Add**, and then click **New Project**.

2. In the **Add New Project** dialog box, expand Visual C++, click **General**, and then click **Empty Project**.

3. In the **Name** text box, type **Annotations**, and then click **Add**.

4. In Solution Explorer, right-click **Annotations** and then click **Properties**.

5. Expand **Configuration Properties** and then click **General**.

6. In the **General** list, select the text in the column next to **Target Extension**, and then type **.lib**.

7. In **Project Defaults**, click the column next to **Configuration Type**, and then click **Static Lib (.lib)**.

## Add the header file and source file to the Annotations project

1. In Solution Explorer, expand **Annotations**, right-click **Header Files**, click **Add**, and then click **New Item**.

2. In the **Add New Item** dialog box, click **Header File (.h)**.

3. In the **Name** box, type **annotations.h** and then click **Add**.

4. Copy the following code and paste it into the *annotations.h* file in the Visual Studio editor.

    ```cpp
    #include <CodeAnalysis/SourceAnnotations.h>

    struct LinkedList
    {
        struct LinkedList* next;
        int data;
    };

    typedef struct LinkedList LinkedList;

    [returnvalue:SA_Post( Null=SA_Maybe )] LinkedList* AllocateNode();

    ```

5. In Solution Explorer, right-click **Source Files**, point to **New**, and then click **New Item**.

6. In the **Add New Item** dialog box, click **Code** and then click **C++ File (.cpp)**

7. In the **Name** box, type **annotations.cpp** and then click **Add**.

8. Copy the following code and paste it into the *annotations.cpp* file in the Visual Studio editor.

    ```cpp
    #include <CodeAnalysis/SourceAnnotations.h>
    #include <windows.h>
    #include <stdlib.h>
    #include "annotations.h"

    LinkedList* AddTail( LinkedList *node, int value )
    {
        LinkedList *newNode = NULL;

        // finds the last node
        while ( node->next != NULL )
        {
            node = node->next;
        }

        // appends the new node
        newNode = AllocateNode();
        newNode->data = value;
        newNode->next = 0;
        node->next = newNode;

        return newNode;
    }

    ```

9. Click the **File** menu, and then click **Save All**.
