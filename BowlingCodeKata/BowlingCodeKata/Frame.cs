namespace BowlingCodeKata
{
    using System.Xml.Schema;

    public class Frame
    {
        public int FirstThrow { get; set; }

        public int SecondThrow { get; set; }

        public virtual int Score(Frame nextFrame = null)
        {
            if (nextFrame == null)
            {
                    return FirstThrow + SecondThrow;
            }
            else if (FirstThrow == 10)
            {
                return FirstThrow + SecondThrow + nextFrame.FirstThrow + nextFrame.SecondThrow;
            }
            else if (FirstThrow + SecondThrow == 10)
            {
                return FirstThrow + SecondThrow + nextFrame.FirstThrow;
            }
            else
            {
                return FirstThrow + SecondThrow;
            }
        }

    }
}
