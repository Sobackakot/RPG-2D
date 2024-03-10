 
using System.IO;
using UnityEngine;

//save the current HP in MainManag and save and load data via JSON
public class MainManag : MonoBehaviour
{
    public static MainManag Instance;
    public float CurrentHP = 100f;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void DateSave()
    {
        SaveData data = new SaveData();
        data._CurrentHP = CurrentHP;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/saveFile.json", json);
    }
    public void DateLoad()
    {
        string path = Application.persistentDataPath + "/saveFile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            CurrentHP = data._CurrentHP;
        }
    }

    [System.Serializable]
    class SaveData
    {
        public float _CurrentHP;
    }
}
