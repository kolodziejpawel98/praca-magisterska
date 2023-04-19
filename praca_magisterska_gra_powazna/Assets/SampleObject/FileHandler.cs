using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public static class FileHandler
{

    public static void SaveToJSON(List<Player> toSave, string filename)
    {
        Debug.Log(GetPath(filename));
        string content = ToJson(toSave.ToArray(), true);
        WriteFile(GetPath(filename), content);
    }

    public static List<Player> ReadListFromJSON(string filename)
    {
        string content = ReadFile(GetPath(filename));

        if (string.IsNullOrEmpty(content) || content == "{}")
        {
            return new List<Player>();
        }

        List<Player> res = FromJson(content).ToList();

        return res;

    }

    public static Player ReadFromJSON(string filename)
    {
        string content = ReadFile(GetPath(filename));

        if (string.IsNullOrEmpty(content) || content == "{}")
        {
            return default(Player);
        }

        Player res = JsonUtility.FromJson<Player>(content);

        return res;

    }

    private static string GetPath(string filename)
    {
        return filename;
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

    public static Player[] FromJson(string json)
    {
        Wrapper<Player> wrapper = JsonUtility.FromJson<Wrapper<Player>>(json);
        return wrapper.Items;
    }

    public static string ToJsonPlayer(Player[] array)
    {
        Wrapper<Player> wrapper = new Wrapper<Player>();
        wrapper.Items = array;
        return JsonUtility.ToJson(wrapper);
    }

    public static string ToJson(Player[] array, bool prettyPrint)
    {
        Wrapper<Player> wrapper = new Wrapper<Player>();
        wrapper.Items = array;
        return JsonUtility.ToJson(wrapper, prettyPrint);
    }

    [Serializable]
    private class Wrapper<Player>
    {
        public Player[] Items;
    }

}