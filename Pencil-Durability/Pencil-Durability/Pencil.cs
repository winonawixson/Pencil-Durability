using System;
namespace Pencil_Durability
{
    public class Pencil
    {
        public Pencil()
        {
        }

        public Pencil(int pointDurability)
        {
            PointDurability = pointDurability;
        }

        public string Paper { get; set; }

        public void Write(string text)
        {
            PointDurability--;
            Paper += text;
        }

        public int PointDurability { get; set; }
    }
}
