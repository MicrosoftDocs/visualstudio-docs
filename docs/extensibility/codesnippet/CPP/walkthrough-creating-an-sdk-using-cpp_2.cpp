// NativeMath.cpp : Defines the exported functions for the DLL application.
//

#include "pch.h"
#include "NativeMath.h"


BasicMath::BasicMath()
{
}

double BasicMath::add(double firstNumber, double secondNumber)
{
    return firstNumber + secondNumber;
}

double BasicMath::subtract(double firstNumber, double secondNumber)
{
    return firstNumber - secondNumber;
}