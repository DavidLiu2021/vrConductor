using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ModeSelection : MonoBehaviour
{
    [SerializeField] private GameObject Mode01;
    [SerializeField] private GameObject Mode02;
    [SerializeField] private GameObject HomePage;


    /// <summary>
    /// HomePage Button01 musical Interpretation
    /// </summary>
    public void ClickSelectMode01(){
        Mode01.SetActive(true);
        HomePage.SetActive(false);
    }

    /// <summary>
    /// Hompage Button02 conducting techniques
    /// </summary>
    public void ClickSelectMode02(){
        Mode02.SetActive(true);
        HomePage.SetActive(false);
    }
    
    void Start(){
        Mode01.SetActive(false);
        Mode02.SetActive(false);
        HomePage.SetActive(true);
    }
}
