 
using UnityEngine; 

public class BulletMove : MonoBehaviour
{
    public void Update()
    {   
        transform.position += transform.up * 10 * Time.deltaTime;
    }

}
