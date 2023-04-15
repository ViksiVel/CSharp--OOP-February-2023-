﻿using AnimalFarm.Models;
using System;

string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

try
{
    Chicken chicken = new Chicken(name, age);
    Console.WriteLine(chicken.ToString());
}
catch (ArgumentException ex)
{

    Console.WriteLine(ex.Message);
}
