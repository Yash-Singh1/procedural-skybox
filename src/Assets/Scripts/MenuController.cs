using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject placeHolder;
    public RectTransform HideButton;
    public TextMeshProUGUI HideText;
    float buttonX = -238.2f;
    float hideY = -208.71f;
    float showY = -23.2f;
    public bool menuShown = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            ControlMenu();
        }
    }

    public void HideMenu()
    {
        placeHolder.SetActive(false);
        HideText.SetText("Show");
        HideButton.localPosition = new Vector2(buttonX + 650, showY + 300);
        menuShown = false;
    }

    public void ShowMenu()
    {
        placeHolder.SetActive(true);
        HideText.SetText("Hide");
        HideButton.localPosition = new Vector2(buttonX + 480, hideY + 300);
        menuShown = true;
    }

    public void ControlMenu()
    {
        if (menuShown)
        {
            HideMenu();
        }
        else
        {
            ShowMenu();
        }
    }
}