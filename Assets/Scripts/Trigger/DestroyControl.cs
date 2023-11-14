 
using UnityEngine;
using UnityEngine.Events;

public class DestroyControl : MonoBehaviour
{
    [SerializeField] private Animator _anim;
    [SerializeField] private UnityEvent _onMoving;
    [SerializeField] private UnityEvent _continueMove;

    private void OnTriggerEnter2D(Collider2D item)
    {
        if (item.CompareTag("Finish") || item.CompareTag("Enemy"))
        {
            _anim.SetBool("isMoving", false);
            _onMoving.Invoke();
        }  
        else Destroy(gameObject);
    }
    private void OnTriggerExit2D(Collider2D item)
    {
        _anim.SetBool("isMoving", true);
        _continueMove.Invoke();
    }
}
    