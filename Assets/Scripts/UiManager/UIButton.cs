
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class UIButton : MonoBehaviour
{   
    public UnityEvent onUiManagerSaveData;
    public UnityEvent onUiManagerResetData;
    public UnityEvent onManagerUIResetHP;

    [SerializeField] private GameObject menu;
   
    public void Update()
    {
        OpenMenu();
    }
    private void OpenMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void ResetHPButton()
    {
        onManagerUIResetHP.Invoke();
    }
    public void CloseMenu()
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void OpenMenuScene()
    {
        onUiManagerSaveData.Invoke();
        SceneManager.LoadScene(0);
    }
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
     
    public void SaveButton()
    {
        if (MainManag.Instance != null)
            MainManager.Instance.SavingData();
    }
    public void LoadButton()
    {
        if (MainManag.Instance != null)
            MainManager.Instance.LoadingData();
        SceneManager.LoadScene(1);
    }
    public void RestartGame()
    {
        onUiManagerResetData.Invoke();
        SceneManager.LoadScene(1);
    }

    public void ExitButton()
    {
        if (MainManag.Instance != null)
            MainManager.Instance.SavingData();
        Application.Quit();
    }
}
