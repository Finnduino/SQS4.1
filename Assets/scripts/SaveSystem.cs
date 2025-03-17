using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveSystem{

 public static void SaveCurrency (Currency currency)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/data.lmao";
        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(currency);
        Debug.Log(path);
        formatter.Serialize(stream, data);
        Debug.Log("Data has been logged!");
        stream.Close();
            }
   
    public static PlayerData LoadCurrency()
    {
        string path = Application.persistentDataPath + "/data.lmao";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return data;
            
        }
        else
        {
            Debug.LogError("No file found at" + path);
            return null;
        }
    }

}


