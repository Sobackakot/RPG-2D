
using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public float hp = 100f;
    public int countMoney = 0;
    public int countKill = 0;
    public int lvl = 0;

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
    public void SavingData()
    {
        SaveData data = new SaveData();
        data.hp = hp;
        data.money = countMoney;
        data.countKill = countKill;
        data.lvl = lvl;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/saveFile.json", json);
    }
    public void LoadingData()
    {
        string path = Application.persistentDataPath + "/saveFile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            hp = data.hp;
            countMoney = data.money;
            countKill = data.countKill;
            lvl = data.lvl;
        }
    }

    [System.Serializable]
    class SaveData
    {
        public float hp;
        public int money;
        public int countKill;
        public int lvl;
    }
}

