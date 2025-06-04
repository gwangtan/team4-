using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButton : MonoBehaviour
{

    public GameObject HelpPanel;
    public GameObject SettingPanel;

    public void GameStartButtonAction()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OpenPanel()
    {
        HelpPanel.SetActive(true);
    }

    public void CloseHelpPanel()
    {
        HelpPanel.SetActive(false);
    }

    public void OpenSetting()
    {
        SettingPanel.SetActive(true);
    }

    public void CloseSeeting()
    {
        SettingPanel.SetActive(false );
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
