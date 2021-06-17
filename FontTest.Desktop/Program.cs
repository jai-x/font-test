using osu.Framework.Platform;
using osu.Framework;
using FontTest.Game;

namespace FontTest.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableHost(@"FontTest"))
            using (osu.Framework.Game game = new FontTestGame())
                host.Run(game);
        }
    }
}
