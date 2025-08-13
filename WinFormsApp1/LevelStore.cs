namespace WinFormsApp1
{
    internal static class LevelStore
    {
        private static string level = "Easy";

        public static string GetLevel()
        {
            return level;
        }

        public static void SetLevel(string newLevel)
        {
            if (newLevel == "Easy" || newLevel == "Normal" || newLevel == "Hard")
            {
                level = newLevel;
            }
            else
            {
                throw new ArgumentException("Invalid level. Must be 'Easy', 'Normal', or 'Hard'.");
            }
        }
    }
}
