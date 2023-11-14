 
using UnityEngine;

public class EnemyMove : MonoBehaviour
{ 
    void Update()
    {
        SetSpeedMove();
    }
    public void SetSpeedMove()
    { 
        transform.position += -transform.right * 1f * Time.deltaTime;
    }
    public void DisableScriptAfterEvent()
    { 
        enabled = false;
    }
    public void EnableScriptAfterEvent()
    {
        enabled = true;
    }
}
