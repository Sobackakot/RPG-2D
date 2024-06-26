
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UIManager: MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _hpText;
    [SerializeField] private TextMeshProUGUI _lvlText;
    [SerializeField] private TextMeshProUGUI _moneyText;

    [SerializeField] private GameObject _gameOverText;

    private float _hp = 100f;
    [HideInInspector] public static int _countMoney = 0;
    [HideInInspector] public static int _countKill = 0;
    private int _lvl = 0;
 
    public void Start()
    {
        Time.timeScale = 1.0f;
        LoadData();
    }
    public void Update()
    {
        LVLCalculate();
    }
    private void OnEnable()
    {
        SaveData();
    }

    public void SaveData()
    {   
        if(MainManager.Instance != null)
        {
            MainManager.Instance.hp = _hp;
            MainManager.Instance.lvl = _lvl;
            MainManager.Instance.countMoney = _countMoney;
            MainManager.Instance.countKill = _countKill;
        } 
    }
    public void LoadData()
    {   
        if(MainManager.Instance != null)
        {
            _hp = MainManager.Instance.hp;
            _lvl = MainManager.Instance.lvl;
            _countMoney = MainManager.Instance.countMoney;
            _countKill = MainManager.Instance.countKill;
        } 
    } 
    public void ResetForestHP()
    { 
        if (_countMoney >= 100)
        {
            _hp = 100f;
            _countMoney -= 100; 
        }  
    }

    public void TakeDamageForestHP()
    {
        if (_hp <= 0)
        {
            _gameOverText.SetActive(true);
            Time.timeScale = 0.0f;
        }
        else 
        { 
            _hp -= 5f; 
        } 
    }

    private void ShowTextUI()
    {
        _hpText.text = _hp.ToString();
        _lvlText.text = "LVL - " + _lvl.ToString(); 
        _moneyText.text = _countMoney.ToString(); 
    }
    private void LVLCalculate()
    { 
        if ( _countKill >= 20) 
        {
            _countKill -= 20;
            _lvl += 1; 
        }
        ShowTextUI();
    }  
}
