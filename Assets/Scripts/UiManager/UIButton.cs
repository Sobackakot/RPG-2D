
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
        MainManager.Instance.SavingData();
    }
    public void LoadButton()
    {
        MainManager.Instance.LoadingData();
        SceneManager.LoadScene(1);
    }
     
    public void ExitButton()
    {
        MainManager.Instance.SavingData();
        Application.Quit();
    }
}
