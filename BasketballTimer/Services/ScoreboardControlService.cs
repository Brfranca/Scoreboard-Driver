namespace BasketballTimer.Services
{
    class ScoreboardControlService
    {
        public int Index { get; set; }
        public int Score { get; set; }
        public int Foul { get; set; }

        public ScoreboardControlService()
        {
        }

        public ScoreboardControlService(int index)
        {
            Index = index;
        }

        public void AddIndex()
        {
            Index++;
            if (Index > 7)
            {
                Index = 0;
            }
        }

        public void ReduceIndex()
        {
            Index--;
            if (Index < 0)
            {
                Index = 7;
            }
        }

        public void ReduceScore()
        {
            Score--;
            if (Score < 0)
            {
                Score = 0;
            }
        }
    }
}
