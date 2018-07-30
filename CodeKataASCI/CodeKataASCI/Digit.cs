namespace CodeKataASCI
{
    using System;

    public class Digit
    {
        public Digit(int d)
        {
            // ._.   ...   ._.   ._.   ...   ._.   ._.   ._.   ._.   ._.
            // |.|   ..|   ._|   ._|   |_|   |_.   |_.   ..|   |_|   |_|
            // |_|   ..|   |_.   ._|   ..|   ._|   |_|   ..|   |_|   ..|
            switch (d)
            {
                case 0:
                    this.FirstLine = "._. ";
                    this.SecondLine = "|.| ";
                    this.ThirdLine = "|_| ";
                    break;
                case 1:
                    this.FirstLine = "... ";
                    this.SecondLine = "..| ";
                    this.ThirdLine = "..| ";
                    break;
                case 2:
                    this.FirstLine = "._.";
                    this.SecondLine = "._| ";
                    this.ThirdLine = "|_. ";
                    break;
                case 3:
                    this.FirstLine = "... ";
                    this.SecondLine = "|.| ";
                    this.ThirdLine = "|_| ";
                    break;
                case 4:
                    this.FirstLine = "._. ";
                    this.SecondLine = "|_| ";
                    this.ThirdLine = "..| ";
                    break;
                case 5:
                    this.FirstLine = "._. ";
                    this.SecondLine = "|_. ";
                    this.ThirdLine = "._| ";
                    break;
                case 6:
                    this.FirstLine = "._. ";
                    this.SecondLine = "|_. ";
                    this.ThirdLine = "|_| ";
                    break;
                case 7:
                    this.FirstLine = "._. ";
                    this.SecondLine = "..| ";
                    this.ThirdLine = "..| ";
                    break;
                case 8:
                    this.FirstLine = "._. ";
                    this.SecondLine = "|_| ";
                    this.ThirdLine = "|_| ";
                    break;
                case 9:
                    this.FirstLine = "._. ";
                    this.SecondLine = "|_| ";
                    this.ThirdLine = "..| ";
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"source digit {d} - must be a single character representing a digit between 0 and 9");
            }
        }

        public string FirstLine { get; set; }

        public string SecondLine { get; set; }

        public string ThirdLine { get; set; }
    }
}
