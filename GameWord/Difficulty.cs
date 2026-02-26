namespace GameWord
{
    public class Difficulty
    {
        private readonly DifficultyType _type;

        public Difficulty(DifficultyType type)
        {
            _type = type;

            switch (type)
            {
                case DifficultyType.Easy:
                    Attempts = 10;
                    MinWordLength = 3;
                    MaxWordLength = 5;
                    break;
                case DifficultyType.Normal:
                    Attempts = 8;
                    MinWordLength = 4;
                    MaxWordLength = 6;
                    break;
                case DifficultyType.Hard:
                    Attempts = 6;
                    MinWordLength = 5;
                    MaxWordLength = 8;
                    break;
            }
        }

        public int Attempts { get; private set; }
        public int MinWordLength { get; private set; }
        public int MaxWordLength { get; private set; }
    }

    public enum DifficultyType
    {
        Easy,
        Normal,
        Hard
    }
}