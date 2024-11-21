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

    public void ClickGotIt(){
        Screen01.SetActive(false);
        Screen02.SetActive(true);
    }

    public void ClickStart(){
        SceneManager.LoadScene("Scene1");
    }

    public void ClickReturn(){
        Mode.SetActive(false);
    }
    
    void Start(){
        Screen01.SetActive(true);
        Screen02.SetActive(false);
    }
}
