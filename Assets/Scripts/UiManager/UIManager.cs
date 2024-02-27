using System.Collections; 
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _hpText;
    [SerializeField] private TextMeshProUGUI _lvlText;
    [SerializeField] private TextMeshProUGUI _moneyText;

    [SerializeField] private GameObject _gameOverText;

    private static float _hp = 100f;
    public static int _money = 0;
    public static int _countKill = 0;
    private static int _lvl = 0;
     
 
    public void Update()
    {
        LVLCalculate();
    }

    public void DamageCalculate()
    {
        if (_hp <= 0)
        {
            _gameOverText.SetActive(true);
            Time.timeScale = 0.0f;
        }
        else _hp -= 5f;
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
            _lvl += 1;  
            _countKill = 0;
        }
        ShowTextUI();
    }  
}
