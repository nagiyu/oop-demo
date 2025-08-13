using WinFormsApp1.Helpers;

namespace WinFormsApp1.Players
{
    internal class PlayerBase
    {
        private readonly int baseHp = 100;

        private int rate = 1;

        protected int GetBaseHp()
        {
            return baseHp;
        }

        protected void SetRate(int rate)
        {
            this.rate = rate;
        }

        public virtual int GetHp()
        {
            return GetBaseHp() * rate * LevelHelper.GetLevelMultiplier();
        }
    }
}
