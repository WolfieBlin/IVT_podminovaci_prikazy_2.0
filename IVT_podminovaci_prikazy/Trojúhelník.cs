﻿using System;
using System.Data;

namespace IVT_podminovaci_prikazy
{
    public class Trojúhelník
    {
        private float _a;
        private float _b;
        private float _c;

        public void Vypocet()
        {
            Console.WriteLine("Zadejte strany a, b, c");
            
            while (!float.TryParse(Console.ReadLine(), out _a))
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");
            while (!float.TryParse(Console.ReadLine(), out _b))
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");
            while (!float.TryParse(Console.ReadLine(), out _c))
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");

            if ((_a + _b) > _c && (_a + _c) > _b && (_c + _b) > _a)
            {
                Console.WriteLine("Trojúhelník lze sestrojit");
            }
            else
            {
                Console.WriteLine("Trojúhelník nelze setrojit");
            }
        }
    }
}