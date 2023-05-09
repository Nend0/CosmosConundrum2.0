using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public GameObject lossUI;
    
    private void OnDestroy()
    {
        if (gameObject.name == "Shippu")
        {
            Time.timeScale = 0f;
            lossUI.SetActive(true);
        }
    }
}
