namespace WinFormsApp1.Helpers
{
    internal static class LevelHelper
    {
        public static int GetLevelMultiplier()
        {
            var level = LevelStore.GetLevel();

            if (level == "Easy")
            {
                return 4;
            }
            else if (level == "Normal")
            {
                return 2;
            }
            else if (level == "Hard")
            {
                return 1;
            }
            else
            {
                throw new ArgumentException("Invalid level. Must be 'Easy', 'Normal', or 'Hard'.");
            }
        }
    }
}
