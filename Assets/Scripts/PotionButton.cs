using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionButton : MonoBehaviour
{

    public GameObject InventoryPanel;


    public void OpenInventoryPanel()
    {
        InventoryPanel.SetActive(true);
    }

    public void CloseInventoryPanel()
    {
        InventoryPanel.SetActive(false);
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
