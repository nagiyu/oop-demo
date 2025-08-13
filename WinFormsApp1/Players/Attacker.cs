namespace WinFormsApp1.Players
{
    internal class Attacker : PlayerBase
    {
        public Attacker()
        {
            SetRate(12);
            System.Diagnostics.Debug.WriteLine("私が来た！");
        }
    }
}
