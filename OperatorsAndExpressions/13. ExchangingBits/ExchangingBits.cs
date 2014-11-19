//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangingBits
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine());
        Console.WriteLine("{0,-8}" + " " + "(" + Convert.ToString(num, 2).PadLeft(32, '0') + ")",num);
        uint firstMask = 1 << 3;
        uint secMask = 1 << 4;
        uint thirdMask = 1 << 5;
        uint numAndFirMask = num & firstMask;
        uint firstBit = numAndFirMask >> 3;
        uint numAndSecMask = num & secMask;
        uint secondBit = numAndSecMask >> 4;
        uint numAndThirdMask = num & thirdMask;
        uint thirdBit = numAndThirdMask >> 5;

        uint firstMaskTwo = 1 << 24;
        uint secMaskTwo = 1 << 25;
        uint thirdMaskTwo = 1 << 26;
        uint numAndFirMaskTwo = num & firstMaskTwo;
        uint firstBitTwo = numAndFirMaskTwo >> 24;
        uint numAndSecMaskTwo = num & secMaskTwo;
        uint secondBitTwo = numAndSecMaskTwo >> 25;
        uint numAndThirdMaskTwo = num & thirdMaskTwo;
        uint thirdBitTwo = numAndThirdMaskTwo >> 26;
                
        
        if (firstBit == 0)
        {
            int mask = ~((int)1 << 24);            
            int numAndMask = (int)num & (int)mask;
            int result = numAndMask;
            num = (uint)result;
        }
        else
        {
            int mask = ((int)1 << 24);
            int numAndMask = (int)num | (int)mask;
            int result = numAndMask;
            num = (uint)result;
        }
       
        if (secondBit == 0)
        {
            int mask = ~((int)1 << 25);
            int numAndMask = (int)num & (int)mask;
            int result = numAndMask;
            num = (uint)result;            
        }
        else
        {
            int mask = ((int)1 << 25);
            int numAndMask = (int)num | (int)mask;
            int result = numAndMask;
            num = (uint)result;            
        }
       
        if (thirdBit == 0)
        {
            int mask = ~((int)1 << 26);
            int numAndMask = (int)num & (int)mask;
            int result = numAndMask;
            num = (uint)result;            
        }
        else
        {
            int mask = ((int)1 << 26);
            int numAndMask = (int)num | (int)mask;
            int result = numAndMask;
            num = (uint)result;
            
        }
        

        if (firstBitTwo == 0)
        {
            int mask = ~((int)1 << 3);
            int numAndMask = (int)num & (int)mask;
            int result = numAndMask;
            num = (uint)result;
        }
        else
        {
            int mask = ((int)1 << 3);
            int numAndMask = (int)num | (int)mask;
            int result = numAndMask;
            num = (uint)result;
        }

        if (secondBitTwo == 0)
        {
            int mask = ~((int)1 << 4);
            int numAndMask = (int)num & (int)mask;
            int result = numAndMask;
            num = (uint)result;
        }
        else
        {
            int mask = ((int)1 << 4);
            int numAndMask = (int)num | (int)mask;
            int result = numAndMask;
            num = (uint)result;
        }

        if (thirdBitTwo == 0)
        {
            int mask = ~((int)1 << 5);
            int numAndMask = (int)num & (int)mask;
            int result = numAndMask;
            num = (uint)result;
        }
        else
        {
            int mask = ((int)1 << 5);
            int numAndMask = (int)num | (int)mask;
            int result = numAndMask;
            num = (uint)result;

        }
        Console.WriteLine(num + " " + "(" + Convert.ToString(num, 2).PadLeft(32, '0') + ")");

        
       
        



    }
}

