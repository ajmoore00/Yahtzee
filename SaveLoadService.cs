using System.IO;
using System.Text.Json;

namespace Yahtzee
{
    // Handles saving and loading game state
    public static class SaveLoadService
    {
        public static void Save(GameState state, string path)
        {
            var json = JsonSerializer.Serialize(state);
            File.WriteAllText(path, json);
        }

        public static GameState Load(string path)
        {
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<GameState>(json);
        }
    }
}