using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public static class FileHandler
{

    public static void SaveToJSON(List<Player> toSave, string filename)
    {
        Debug.Log(filename);


        Wrapper<Player> wrapper = new Wrapper<Player>();
        wrapper.Items = toSave.ToArray();

        string content = JsonUtility.ToJson(wrapper, true);
        WriteFile(filename, content);
    }

    public static List<Player> ReadListFromJSON(string filename)
    {
        string content = ReadFile(filename);

        if (string.IsNullOrEmpty(content) || content == "{}")
        {
            return new List<Player>();
        }

        Wrapper<Player> wrapper = JsonUtility.FromJson<Wrapper<Player>>(content);
        List<Player> res = wrapper.Items.ToList();

        return res;

    }

    private static void WriteFile(string path, string content)
    {
        FileStream fileStream = new FileStream(path, FileMode.Create);

        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(content);
        }
    }

    private static string ReadFile(string path)
    {
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string content = reader.ReadToEnd();
                return content;
            }
        }
        return "";
    }

    [Serializable]
    private class Wrapper<Player>
    {
        public Player[] Items;
    }

}