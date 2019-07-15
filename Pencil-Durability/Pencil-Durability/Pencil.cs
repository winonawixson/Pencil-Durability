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
            foreach(var letter in text.ToCharArray())
            {
                if (char.IsUpper(letter))
                {
                    PointDurability = PointDurability - 2;
                }
                else if (char.IsLower(letter))
                {
                    PointDurability--;
                }
            }

            Paper += text;
        }

        public int PointDurability { get; set; }
    }
}
