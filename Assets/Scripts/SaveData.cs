// Add System.IO to work with files!
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class SaveData : MonoBehaviour
{
    // Create a field for the save file.
    string saveFile;

    // Create a SaveData field.
    SaveData saveData = new SaveData();

    void Awake()
    {
        // Update the path once the persistent path exists.
        saveFile = Application.persistentDataPath + "/savedata.json";
    }

    public void readFile()
    {
        // Does the file exist?
        if (File.Exists(saveFile))
        {
            // Read the entire file and save its contents.
            string fileContents = File.ReadAllText(saveFile);

            // Deserialize the JSON data 
            //  into a pattern matching the GameData class.
            saveData = JsonUtility.FromJson<SaveData>(fileContents);
        }
    }

    public void writeFile()
    {
        // Serialize the object into JSON and save string.
        string jsonString = JsonUtility.ToJson(saveData);

        // Write JSON to file.
        File.WriteAllText(saveFile, jsonString);
    }
}
