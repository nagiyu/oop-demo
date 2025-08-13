namespace WinFormsApp1.Players
{
    internal class Witch : PlayerBase
    {
        public Witch()
        {
            SetRate(8);
            System.Diagnostics.Debug.WriteLine("魔女が来た！");
        }
    }
}
