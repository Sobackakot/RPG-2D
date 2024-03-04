 
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EnemyTrigger : MonoBehaviour
{
    [SerializeField] private UIManager manager;

    [SerializeField] private Animator _anim;
    [SerializeField] private UnityEvent _onMoving;
    [SerializeField] private UnityEvent _continueMove;
    [SerializeField] private Image hp; 
    private float currentHpEnemy = 100f;
    private int countMoney = 0;
    private int countKill = 0;

    private void OnEnable()
    {
        manager.onEnemyTriggerKill += GetKill;
        manager.onEnemyTriggerMoney += GetMoney;  
    }

    private void OnDisable()
    {
        manager.onEnemyTriggerKill -= GetKill;
        manager.onEnemyTriggerMoney -= GetMoney;  
    }
    public int GetMoney()
    {
        return countMoney;
    }
    public int GetKill()
    {
        return countKill;
    }

    private void UpdateHpEnemy()
    {
        currentHpEnemy -= 25f;
        if (currentHpEnemy <= 0f)
        {
            countMoney += 5;
            countKill += 1;
            Destroy(gameObject);
        }
        else 
            hp.fillAmount = currentHpEnemy / 100;
    } 
    private void OnTriggerEnter2D(Collider2D other)
    { 
        if(other.CompareTag("Bullet"))
        {
            UpdateHpEnemy();
            Destroy(other.gameObject);
        } 
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Finish") || other.CompareTag("Enemy"))
        {
            _anim.SetBool("isMoving", false);
            _onMoving.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D item)
    {
        _anim.SetBool("isMoving", true);
        _continueMove.Invoke();
    }  
}
    