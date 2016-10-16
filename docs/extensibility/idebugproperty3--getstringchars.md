---
title: "IDebugProperty3::GetStringChars"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugProperty3::GetStringChars"
helpviewer_keywords: 
  - "IDebugProperty3::GetStringChars"
ms.assetid: 832c37f3-85cb-4227-8ab2-f27a80eafe90
caps.latest.revision: 7
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
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
# IDebugProperty3::GetStringChars
Retrieves the string associated with this property and stores it in a user-supplied buffer.  
  
## Syntax  
  
```cpp  
HRESULT GetStringChars(  
   ULONG  buflen,  
   WCHAR* rgString,  
   ULONG* pceltFetched  
);  
```  
  
```c#  
int GetStringChars(  
   uint       buflen,   
   out string rgString,   
   out uint   pceltFetched  
);  
```  
  
#### Parameters  
 `buflen`  
 [in] Maximum number of characters the user-supplied buffer can hold.  
  
 `rgString`  
 [out] Returns the string.  
  
 [C++ only], `rgString` is a pointer to a buffer that receives the Unicode characters of the string. This buffer must be at least `buflen` characters (not bytes) in size.  
  
 `pceltFetched`  
 [out] Where the number of characters actually stored in the buffer is returned. (Can be `NULL` in C++.)  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns an error code.  
  
## Remarks  
 In C++, care must be taken to insure that the buffer is at least `buflen` Unicode characters long. Note that a Unicode character is 2 bytes long.  
  
> [!NOTE]
>  In C++, the returned string does not include a terminating null character. If given, `pceltFetched` will specify the number of characters in the string.  
  
## Example  
 [!CODE [[cpp]]([cpp])]  
  
```  
CStringW RetrievePropertyString(IDebugProperty2 *pPropInfo)  
{  
    CStringW returnString = L"";  
    CComQIPtr<IDebugProperty3> pProp3 = pPropInfo->pProperty;  
    If (pProp3 != NULL) {  
        ULONG dwStrLen = 0;  
        HRESULT hr;  
        hr = pProp3->GetStringCharLength(&dwStrLen);  
        if (SUCCEEDED(hr) && dwStrLen > 0) {  
            ULONG dwRead;  
            CStrBufW buf(returnString,dwStrLen,CStrBuf::SET_LENGTH);  
            hr = pProp3->GetStringChars(dwStrLen,  
                                        reinterpret_cast<WCHAR*>(static_cast<CStringW::PXSTR>(buf)),  
                                        &dwRead);  
        }  
    }  
    return(returnString);  
```  
  
 [!CODE [}](})]  
  
## See Also  
 [GetStringCharLength](../extensibility/idebugproperty3--getstringcharlength.md)   
 [IDebugProperty3](../extensibility/idebugproperty3.md)   
 [IDebugProperty2](../extensibility/idebugproperty2.md)