using System;
namespace Curso3.Device
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevide print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevide processing " + document);
        }

        public string Scan()
        {
            return "Combodevice scan result";
        }

    }

}
