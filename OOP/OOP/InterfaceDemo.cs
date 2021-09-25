using System;


namespace OOP
{
    // This program demo. how to call interface with explicit and implicit implementation.
    interface InterfaceDemo
    {
        static void Main()
        {
            // Calling Explicit implementation
            Iwifi wifi = new NokiaLumia();
            Console.WriteLine(wifi.StartWifi());
            Console.WriteLine(wifi.StopWifi());
        }
    }
}
