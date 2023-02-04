using System;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace Elements.Utils
{
    public class AppSettings
    {
        public DataFiles Files { get; set; } = new DataFiles();
        public Type CurrentList { get; set; }
        public int SelectedItemIndex { get; set; }
        public int SelectedFieldIndex { get; set; }

        public class DataFiles
        {
            public string Element { get; set; } = "";
            public string GShop { get; set; } = "";
            public string Domain { get; set; } = "";
            public string Task { get; set; } = "";
        }
    }

    class Settings
    {
        public static AppSettings App { get; set; }

        private static readonly string FilePath = Directory.GetCurrentDirectory() + "/appsettings.json";

        public static void Load()
        {

            if (!File.Exists(FilePath))
            {
                App = new AppSettings();
                Save();
            }

          //  var settingsFile = File.ReadAllText(FilePath);
           // App = JsonConvert.DeserializeObject<AppSettings>(settingsFile);
        }

        public static void Save()
        {
            new Task(() =>
            {
                File.WriteAllText(FilePath, JsonConvert.SerializeObject(App));
            }).Start();
        }
    }
}
