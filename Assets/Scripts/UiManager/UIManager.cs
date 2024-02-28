
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _hpText;
    [SerializeField] private TextMeshProUGUI _lvlText;
    [SerializeField] private TextMeshProUGUI _moneyText;

    [SerializeField] private GameObject _gameOverText;

    private float _hp = 100f;
    private int _money = 0;
    private int _countKill = 0;
    private int _lvl = 0;

    public void Start()
    {
        _hp = MainManager.Instance.hp; 
        _lvl = MainManager.Instance.lvl;
        _money = MainManager.Instance.money;
        _countKill = MainManager.Instance.countKill;
    }
    public void Update()
    {
        LVLCalculate(); 
        _money = MainManager.Instance.money;
        _countKill = MainManager.Instance.countKill;
    }

    public void DamageCalculate()
    {
        if (_hp <= 0)
        {
            _gameOverText.SetActive(true);
            Time.timeScale = 0.0f;
        }
        else 
        {
            _hp -= 5f;
            MainManager.Instance.hp = _hp;
        } 
    }

    private void ShowTextUI()
    {
        _hpText.text = _hp.ToString();
        _lvlText.text = "LVL - " + _lvl.ToString();
        _moneyText.text = _money.ToString();
    }
    private void LVLCalculate()
    { 
        if ( _countKill >= 20) 
        {
            MainManager.Instance.countKill -= 20;
            _lvl += 1;
            MainManager.Instance.lvl = _lvl;
        }
        ShowTextUI();
    }  
}
