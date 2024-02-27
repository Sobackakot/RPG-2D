
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButton : MonoBehaviour
{ 
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
     
    public void SaveButton()
    {
        
    }
    public void LoadButton()
    {
        SceneManager.LoadScene(1);
    }
     
    public void ExitButton()
    {
        Application.Quit();
    }
}
