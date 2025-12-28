using System;

interface Powerable // A contract or signature with method with no body
{
    void PowerOn();
}

class LightBulb : Powerable // derived class with LightBulb implementation
{
    public void PowerOn()
    { Console.WriteLine("Bulb is glowing.\n"); }
}

class Computer : Powerable // derived class with Computer implementation
{
    public void PowerOn()
    { Console.WriteLine("Computer is booting up."); }
}

class Program    // Main class 
{
    static void Main(string[] args)
    {
        Powerable myDevice1 = new LightBulb(); // LightBulb assigned to Powerable
        Powerable myDevice2 = new Computer();  // Computer assigned to Powerable

        myDevice1.PowerOn();  // Calls LightBulb.PowerOn
        myDevice2.PowerOn();  // Calls Computer.PowerOn
    }
}