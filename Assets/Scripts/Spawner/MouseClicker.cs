using UnityEngine;
using UnityEngine.EventSystems;


public class MouseClicker : MonoBehaviour 
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _startPoint;

    private void Update()
    {
        LeftMouseButton();
    }
    //private void Raycasting()
    //{
    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
    //    if(hit.collider != null)
    //    {
    //        LeftMouseButton();
    //    }
    //}
    
    private void LeftMouseButton()
    {   
        if(Input.GetMouseButtonDown(0)) 
        {
            Instantiate(_bulletPrefab, _startPoint.position, transform.rotation);
        } 
    }
}
