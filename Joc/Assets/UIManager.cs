using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    GameObject panel;

    public void clickButton()
    {
        gameObject.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            panel.SetActive(!panel.activeSelf);

            Time.timeScale = (panel.activeSelf) ? 0 : 1;


        }

    }

}
