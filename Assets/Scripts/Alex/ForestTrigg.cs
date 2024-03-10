 
using UnityEngine;
using UnityEngine.Events; 
//a trigger object with a collider on which this script hangs.  
public class ForestTrigg : MonoBehaviour
{
    //an event that calls the UIManag script and the update Hp function that updates the HP ui
    public UnityEvent onUIManagUpdateHP;
        
    public void OnTriggerEnter(Collider other)
    {   
        if(other.gameObject.tag == "Enemy")
        onUIManagUpdateHP.Invoke();
    }
}


