
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{    
    public UnityEvent onUiManagerResetData;
   
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
     
    public void SaveButton()
    {
        if (MainManager.Instance != null)
        { 
            MainManager.Instance.SavingDataJson();
        } 
    }
    public void LoadButton()
    {
        if (MainManager.Instance != null)
        {
            MainManager.Instance.LoadingDataJson(); 
        } 
        SceneManager.LoadScene(1);
    }
    public void RestartGame()
    {
        onUiManagerResetData.Invoke();
        SceneManager.LoadScene(1);
    }

    public void ExitButton()
    {
        if (MainManager.Instance != null)
            MainManager.Instance.SavingDataJson();
        Application.Quit();
    }
}
