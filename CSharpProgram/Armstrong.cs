﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class Armstrong
    {
        public static void ArmstrongNumber()
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter the number = ");
            n=int.Parse(Console.ReadLine());
            temp = n;

            while(n>0)
            {
                r = n % 10;
                sum=sum+(r*r*r);
                n= n/10;
            }
            if (temp == sum)
                Console.Write("Armsrtong Number");
            else
                Console.Write("Not Armstrong Number ");
        
        }
    }
}
