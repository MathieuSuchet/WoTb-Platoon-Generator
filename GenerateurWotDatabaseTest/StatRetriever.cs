using System.Data.SqlClient;
using System.Data.SqlTypes;
using WotGenC;
using WotGenC.Database;

namespace GenerateurWotDatabaseTest;

public class StatRetriever
{
    public List<KeyValuePair<DateTime, float[]>> RetrieveWinLossOf(int playerId, int tankId)
    {
        SqlConnection cnn = new SqlConnection(Settings.ConnectionString);
        cnn.Open();

        SqlCommand command =
            new SqlCommand(
                $"SELECT Wins, Losses, NumberOfBattles, Date FROM Stats WHERE IDp = {playerId} AND IDt = {tankId}", cnn);

        var reader = command.ExecuteReader();

        List<KeyValuePair<DateTime, float[]>> results = new List<KeyValuePair<DateTime, float[]>>();

        while (reader.Read())
        {
            results.Add(new KeyValuePair<DateTime, float[]>((DateTime)reader[reader.FieldCount - 1], new float[reader.FieldCount - 1]));
            for (int i = 0; i < reader.FieldCount - 1; i++)
            {
                results[^1].Value[i] = (int)reader[i];
            }
        }

        return results;
    }

    public Stats? RetrieveStatsOf(int playerId, int tankId)
    {
        return DbStats.GetFromDb(playerId, tankId);
    }
}