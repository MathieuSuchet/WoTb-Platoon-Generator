using System.Collections.Generic;
using WotGenC.Modes;

namespace WotGenC
{
    public static class Settings
    {
        public static Tier Tier;

        public static List<Player> Players;

        public static GameMode GameMode;

        public static Mode Mode;

        public static string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
    }
}
