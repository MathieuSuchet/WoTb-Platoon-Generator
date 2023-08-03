using System.Collections.Generic;

namespace WotGenC
{
    public static class Settings
    {
        public static Tier Tier;

        public static List<Player> Players;

        public static GameMode GameMode;

        public static string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";

        public static List<Tank> AllTanks = new List<Tank>();
    }
}
