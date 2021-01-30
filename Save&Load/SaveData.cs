using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveData
{
    public static void SavePlayer(Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();//here we create a binaryformatter to convert our data in binary form
        string path = Application.persistentDataPath + "/player.adi";//Locate the loaction in our device where the file will store
        FileStream stream = new FileStream(path, FileMode.Create);//here we create a file 
        PlayerData data = new PlayerData(player);//here we take data what we store in our file
        formatter.Serialize(stream, data);// we put data inside the file 
        stream.Close();// here we close the file
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.adi";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);//here we open the file  
            PlayerData data = formatter.Deserialize(stream) as PlayerData;// here we convert the binary form into readable form
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("File not found in this" + path);
            return null;
        }
       
    }
}
