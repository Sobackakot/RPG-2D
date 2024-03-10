
using UnityEngine;
using UnityEngine.SceneManagement;
//functions that belong to the menu scene to launch the game scene,
//here I call the save and load data functions on the buttons
public class BUTTONui : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void SaveButton()
    {
        MainManag.Instance.DateSave(); //kltkm zhibrf null reference
    }
    public void LoadButton()
    {
        MainManag.Instance.DateLoad(); //kltkm zhibrf null reference
        SceneManager.LoadScene(1);
    }
}
