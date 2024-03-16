
using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public List<Vector3> enemyPosition = new List<Vector3>(); 
      
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
    public void SavingDataJson()
    {
        SaveData data = new SaveData();
        SaveDataPlayer(data);
        SaveDataEnemy(data);
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/saveFile.json", json);
    }
    public void LoadingDataJson()
    {
        string path = Application.persistentDataPath + "/saveFile.json";
        if (File.Exists(path))
        { 
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            LoadDataPlayer(data);
            LoadDataEnemy(data);
        }
    }
    private void SaveDataPlayer(SaveData data)
    { 
        data.hp = hp;
        data.money = countMoney;
        data.countKill = countKill;
        data.lvl = lvl; 
    }
    private void LoadDataPlayer(SaveData data)
    { 
        hp = data.hp;
        countMoney = data.money;
        countKill = data.countKill;
        lvl = data.lvl;
    }
    private void SaveDataEnemy(SaveData data)
    { 
        data._enemyPosition.Clear(); 
        for(int i = 0; i< enemyPosition.Count; i++)
        {
            data._enemyPosition.Add(enemyPosition[i]); 
        }
    }
    private void LoadDataEnemy(SaveData data)
    {
        enemyPosition.Clear(); 
        for(int i = 0; i< data._enemyPosition.Count; i++)
        { 
            enemyPosition.Add(data._enemyPosition[i]); 
        }
    }
    public void ResetData() // Event add restart button menu
    {
       hp = 100f;
       lvl = 0;
       countMoney = 0;
       countKill = 0;
       enemyPosition.Clear(); 
    }

    [System.Serializable]
    class SaveData
    { 
        public List<Vector3> _enemyPosition = new List<Vector3>();  
        public float hp;
        public int money;
        public int countKill;
        public int lvl;
    }
}

