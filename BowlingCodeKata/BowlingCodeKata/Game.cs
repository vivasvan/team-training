namespace BowlingCodeKata
{
    using System.Collections.Generic;

    public class Game
    {
        public List<Frame> frames { get; set; }

        public int Score()
        {
            var score = 0;
            var nextFrameIndex = 1;
            foreach (var frame in frames)
            {
                 var nextFrame = nextFrameIndex < frames.Count ? frames[nextFrameIndex] : null;
                 score += frame.Score(nextFrame);
                nextFrameIndex++;
            }

            return score;
        }
    }
}
