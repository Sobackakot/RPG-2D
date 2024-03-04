
using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class UIManager : MonoBehaviour
{
    public Func<int> onEnemyTriggerKill;
    public Func<int> onEnemyTriggerMoney;

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
        UpdateKill();
        UpdateMoney();
    }

    public int UpdateKill()
    {
        if (onEnemyTriggerKill != null)
        {
            return onEnemyTriggerKill.Invoke();
        }
        else return _countKill;
    }
    public int UpdateMoney()
    {   
        if(onEnemyTriggerMoney != null)
        {
            return onEnemyTriggerMoney.Invoke();
        }
        else return _money; 
    }

   
    public void SaveData()
    {
        MainManager.Instance.hp = _hp;
        MainManager.Instance.lvl = _lvl;
        MainManager.Instance.money = _money;
        MainManager.Instance.countKill = _countKill;
    }
    public void ResetHp()
    {
        if (_money >= 100)
        {
            _hp = 100f;
            _money -= 100; 
        }  
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
        } 
    }

    private void ShowTextUI()
    {
        _money = UpdateMoney();
        _hpText.text = _hp.ToString();
        _lvlText.text = "LVL - " + _lvl.ToString(); 
        _moneyText.text = _money.ToString(); 
    }
    private void LVLCalculate()
    {
        _countKill = UpdateKill();
        if ( _countKill >= 20) 
        {
            _countKill -= 20;
            _lvl += 1; 
        }
        ShowTextUI();
    }  
}
