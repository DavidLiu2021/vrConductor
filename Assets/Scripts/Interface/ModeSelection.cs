using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ModeSelection : MonoBehaviour
{
    [SerializeField] private GameObject Screen01;
    [SerializeField] private GameObject Screen02;
    [SerializeField] private GameObject Mode;
    [SerializeField] private GameObject ThumbUp;

    public void ClickGotIt(){
        Screen01.SetActive(false);
        Screen02.SetActive(true);
    }

    public void ClickStart(){
        // SceneManager.LoadScene("Scene1");
        ThumbUp.SetActive(true);
    }

    public void ClickReturn(){
        Mode.SetActive(false);
    }
    
    void Start(){
        Screen01.SetActive(true);
        Screen02.SetActive(false);
        ThumbUp.SetActive(false);
    }
}
