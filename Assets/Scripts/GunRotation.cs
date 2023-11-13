 
using UnityEngine; 

public class GunRotation : MonoBehaviour 
{
    public float rotationSpeed = 5f; 
    void Update()
    { 
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         
        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg;
         
        angle -= 90f;
         
        Quaternion targetRotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
         
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    } 
}
