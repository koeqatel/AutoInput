using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AutoInput
{
    public class SnSConfig
    {
        private static string folder = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1) + @":\Users\" + Environment.UserName + @"\AppData\Roaming\SnSStudio\";
        private static string program = typeof(SnSConfig).Namespace;
        private static string file = @"\config.txt";

        private void createConfigFolder()
        {
            if (!folderExists())
            {
                Directory.CreateDirectory(folder + program);
            }
        }
        private void createConfigFile()
        {
            if (!fileExists())
            {
                var configFile = File.Create(folder + program + file);
                configFile.Close();
            }
        }

        public void setDefaultConfig(Dictionary<string, string> items)
        {
            int i = 0;
            foreach (var item in items)
            {

                string key = item.Key;
                string value = item.Value;
                System.IO.File.WriteAllText(folder + program + file, System.IO.File.ReadAllText(folder + program + file) + key + ":" + value + Environment.NewLine);
                i++;
            }
        }

        public void updateConfig(string key, string value)
        {
            createConfigFolder();
            createConfigFile();

            List<string> config = new List<string>();
            string line;
            bool updated = false;
            System.IO.StreamReader configContent = new System.IO.StreamReader(folder + program + file);
            while ((line = configContent.ReadLine()) != null)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    if (parts[0] == key)
                    {
                        config.Add(parts[0] + ":" + value);
                        updated = true;
                    }
                    else
                    {
                        config.Add(line);
                    }
                }
            }

            if (!updated)
            {
                config.Add(key + ":" + value);
            }
            configContent.Close();

            int i = 0;
            foreach (string conf in config)
            {
                if (i == 0)
                {
                    System.IO.File.WriteAllText(folder + program + file, "");
                }
                i++;
                System.IO.File.WriteAllText(folder + program + file, System.IO.File.ReadAllText(folder + program + file) + conf + Environment.NewLine);
            }


        }

        public List<Dictionary<string, string>> readConfig()
        {
            createConfigFolder();
            createConfigFile();

            List<Dictionary<string, string>> dictList = new List<Dictionary<string, string>>();
            Dictionary<string, string> dict = new Dictionary<string, string>();

            string line;
            System.IO.StreamReader configContent = new System.IO.StreamReader(folder + program + file);
            while ((line = configContent.ReadLine()) != null)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    dict.Add(parts[0], parts[1]);
                }
                dictList.Add(dict);
            }
            configContent.Close();
            return dictList;
        }

        public string getConfigItem(string key)
        {
            createConfigFolder();
            createConfigFile();

            List<Dictionary<string, string>> list = readConfig();
            foreach (Dictionary<string, string> item in list)
            {
                if (item.Keys.Contains(key))
                {
                    return item[key];
                }
                else
                {
                    return "No item found";
                }
            }
            return "No entries in config found.";
        }

        private bool folderExists()
        {
            return Directory.Exists(folder + program);
        }

        private bool fileExists()
        {
            return File.Exists(folder + program + file);
        }

        public bool fileEmpty()
        {
            createConfigFolder();
            createConfigFile();

            if (File.ReadAllText(folder + program + file) == "")
                return true;
            else if (File.ReadAllText(folder + program + file) != "")
                return false;
            else
                return true;
        }
    }
}


