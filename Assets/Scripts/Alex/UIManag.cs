 
using UnityEngine;
using UnityEngine.UI;

public class UIManag : MonoBehaviour
{
    public Image forestHP;
    public GameObject gameOverText;
    public float currentHP = 100f;

    public void Start()
    {
        //getting values at startup
        currentHP = MainManag.Instance.CurrentHP; //kltkm zhibrf null reference
    }
    public void UpdateHPforest()
    {
        currentHP -= 5f;
        //saving a value in a variable via a singleton when moving from the game scene to the menu scene and back
        MainManag.Instance.CurrentHP = currentHP; //kltkm zhibrf null reference
        forestHP.fillAmount = currentHP / 100;
        if (currentHP <= 0)
        {
            gameOverText.SetActive(true);
        }
    }
}
