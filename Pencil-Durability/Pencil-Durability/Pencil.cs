using System;
namespace Pencil_Durability
{
    public class Pencil
    {
        public Pencil()
        {
        }

        public string Paper { get; set; }

        public void Write(string text)
        {
            Paper += text;
        }
    }
}
