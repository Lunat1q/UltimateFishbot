using System.IO;
using TiqUtils.Serialize;

namespace UltimateFishBot.Settings
{
    internal class SettingsController
    {
        private const string StorageFolder = "Config";

        private const string ConfilFileName = "settings.config";

        private static string ConfigPath => Path.Combine(StorageFolder, ConfilFileName);

        public static BotSettings Instance { get; private set; }

        static SettingsController()
        {
            Instance = Json.DeserializeDataFromFile<BotSettings>(ConfigPath) ?? new BotSettings();
        }

        public static void Save()
        {
            Instance.SerializeDataJson(ConfigPath);
        }

        public static void Reset()
        {
           Instance = new BotSettings();
        }
    }
}