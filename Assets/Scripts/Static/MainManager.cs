
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public float hp = 100f;
    public int money = 0;
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

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void SaveData(int _money = 0, int _countKill = 0,int _lvl = 0, float _hp = 0f)
    {
        hp = _hp;
        money = _money;
        countKill = _countKill;
        lvl = _lvl;
    }
   
}
