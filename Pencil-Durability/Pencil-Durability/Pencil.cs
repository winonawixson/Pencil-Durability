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
            InitialPointDurability = pointDurability;
            PointDurability = pointDurability;
        }

        public string Paper { get; set; }

        public void Write(string text)
        {
            foreach (var letter in text.ToCharArray())
            {
                if (PointDurability > 0)
                {
                    if (char.IsUpper(letter))
                    {
                        PointDurability = PointDurability - 2;
                    }
                    else if (char.IsLower(letter))
                    {
                        PointDurability--;
                    }

                    Paper += letter.ToString();
                }
            }
        }

        public int PointDurability { get; set; }

        public int InitialPointDurability { get; set; }
    }
}
