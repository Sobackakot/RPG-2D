using System.Collections; 
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

    private int _lvl = 0;
    private int _countKill = 0;

    private Coroutine _coroutine;

    public void Start()
    { 
        _coroutine = null;
        Time.timeScale = 1f;
    }

    public void MoneyCalculate()
    {
        _money += 5;
        _moneyText.text = _money.ToString();
    }
    public void LVLCalculate()
    {    
        _countKill += 1;
        if( _countKill >= 20) 
        {
            _lvl += 1;
            _lvlText.text = "LVL - "+_lvl.ToString();
            _countKill = 0;
        } 
    }
    public void DamageCalculate()
    {
        if (_coroutine == null)
            _coroutine = StartCoroutine(TakeDamage());
        else
        {
            StopCoroutine(_coroutine);
            _coroutine = null;
        }     
    }
    
    public void GameOver()
    {
        _gameOverText.SetActive(true);
        Time.timeScale = 0.0f;
    }

    private IEnumerator TakeDamage()
    {
        while (true)
        {
            if (_hp <= 0)
                GameOver();
            yield return new WaitForSeconds(0.5f);
            _hp -= 5f;
            _hpText.text = _hp.ToString();
        }
    }
}
