// Class1.cpp
#include "pch.h"
#include "Class1.h"

using namespace NativeMathWRT;
using namespace Platform;
    
double BasicMathWinMD::multiply(double firstNumber, double secondNumber)
{
    return firstNumber * secondNumber;
}

double BasicMathWinMD::divide(double firstNumber, double secondNumber)
{
    if(0 == secondNumber) 
        return -1;

    return firstNumber / secondNumber;
}