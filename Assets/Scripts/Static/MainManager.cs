
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    //public static MainManager Instance;
     

    //private void Awake()
    //{ 
    //    if (Instance != null)
    //    {
    //        Destroy(gameObject);
    //        return;
    //    }  
    //    Instance = this;
    //    DontDestroyOnLoad(gameObject);
    //}

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
