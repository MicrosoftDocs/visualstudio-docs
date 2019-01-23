---
title: "CvCreateMarkerSeriesWithCodePageA Function | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "cvmakers/CvCreateMarkerSeriesWithCodePageA"
helpviewer_keywords: 
  - "CvCreateMarkerSeriesWithCodePageA method"
ms.assetid: 3d7ed601-2222-4be9-a557-f217db008753
caps.latest.revision: 8
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# CvCreateMarkerSeriesWithCodePageA Function
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Creates marker series for a given provider and specified code page. This function can be used to specify the code page explicitly for the text written out by marker API ANSI functions. Setting the code page can be useful in case the trace is captured and then analyzed on different machines with different locales/languages. By default the code page returned by GetACP() function is used.  
  
## Syntax  
  
```  
HRESULT CvCreateMarkerSeriesWithCodePageA(  
   _In_ PCV_PROVIDER pProvider,  
   _In_ LPCSTR pSeriesName,  
   _In_ UINT nTextCodePage,  
   _Out_ PCV_MARKERSERIES* ppMarkerSeries  
);  
```  
  
#### Parameters  
 `pProvider`  
 Provider object previously initialized by CvInitProvider. Cannot be NULL.  
  
 `pSeriesName`  
 Marker series name. Cannot be NULL but empty string is allowed.  
  
 `nTextCodePage`  
 Valid code page.  
  
 `ppMarkerSeries`  
 Address of an output variable which will store marker series context. Cannot be NULL.  
  
## Return Value  
 S_OK when marker series is successfully created or error code in case there were any errors. Use SUCCEEDED/FAILED macros to check for error condition.  
  
## Requirements  
 **Header:** cvmarkers.h  
  
## See Also  
 [C++ Library Reference](../profiling/cpp-library-reference.md)
