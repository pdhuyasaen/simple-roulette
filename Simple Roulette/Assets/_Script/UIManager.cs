using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    public GameObject UI_Start_Menu;
    public GameObject UI_In_Round;
    // Start is called before the first frame update
    void Start()
    {
        UI_Start_Menu.SetActive(true);
        UI_In_Round.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UI<T>(T obj) where T : Component
    {

    }

    public void OnGameStart()
    {
        UI_Start_Menu.SetActive(true);
        UI_In_Round.SetActive(false);
    }

    public void OnLevelStart()
    {
        UI_Start_Menu.SetActive(false);
        UI_In_Round.SetActive(true);
    }
}
