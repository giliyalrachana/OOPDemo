using System;


namespace OOP
{
    // This program demo. how to implement multiple inheritance
    class NokiaLumia : MobilePhone, Iwifi
    {
        string Iwifi.StartWifi()
        {
            return "starting WIFI";
        }

        string Iwifi.StopWifi()
        {
            return "Stopping WIFI";
        }

        string Iwifi.TrubleShoot()
        {
            throw new NotImplementedException();
        }
        public string PushMessage()
        {
            return "PushMessage() calling from NokiaLumia";
        }
    }
}
