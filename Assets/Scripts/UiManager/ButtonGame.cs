 
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ButtonGame : MonoBehaviour
{
    public UnityEvent onUiManagerSaveData;
    public UnityEvent onUiManagerResetHP; 

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
        onUiManagerResetHP.Invoke();
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
}
