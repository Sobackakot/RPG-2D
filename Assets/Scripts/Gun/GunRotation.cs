 
using UnityEngine; 

public class GunRotation : MonoBehaviour 
{ 
    public float rotationSpeed = 5f;
    [SerializeField] private Camera myCamera;
    void Update()
    {
        //берем позицию мышки с помошью камеры
        Vector3 mousePos = myCamera.ScreenToWorldPoint(Input.mousePosition); 

        //мы получаем отрезок от точки А к точке Б и переводим в радианы и получаем угол
        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg;
        angle -= 90f;
         // вращаем точку А по заданному углу 
        Quaternion targetRotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
        
        //делавем вращение плавным от текущего угла к заданному углу
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime); 
       
    }
    
}
