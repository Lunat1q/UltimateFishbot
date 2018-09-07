using System.IO;
using System.Reflection;
using TiqUtils.Serialize;

namespace UltimateFishBot.Settings
{
    internal class SettingsController
    {
        private const string StorageFolder = "Config";

        private const string ConfilFileName = "settings.config";

        internal static string AssemblyDirectory { get; } = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        private static string ConfigPath => Path.Combine(AssemblyDirectory, StorageFolder, ConfilFileName);

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