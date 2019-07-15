using System;
namespace Pencil_Durability
{
    public class Pencil
    {
        public Pencil(int pointDurability, int length)
        {
            InitialPointDurability = pointDurability;
            PointDurability = pointDurability;
            Length = length;
        }

        public Pencil(int pointDurability, int length, int eraserDurability)
        {
            InitialPointDurability = pointDurability;
            PointDurability = pointDurability;
            Length = length;
            EraserDurability = eraserDurability;
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

        public void Sharpen()
        {
            if(Length > 0)
            {
                PointDurability = InitialPointDurability;
                Length--;
            }            
        }

        public int Length { get; set; }

        public void Erase(string text)
        {
            if (EraserDurability < text.Length)
            {
                text = text.Substring(text.Length - EraserDurability);
            }

            var spaces = "";
            for (var i = 0; i < text.Length; i++)
            {
                spaces += " ";
            }

            var location = Paper.LastIndexOf(text);
            if (location == -1) //text not found
                return;

            var result = Paper.Remove(location, text.Length).Insert(location, spaces);
            Paper = result;

            EraserDurability -= text.Length;
        }

        public int EraserDurability { get; set; }
    }
}
