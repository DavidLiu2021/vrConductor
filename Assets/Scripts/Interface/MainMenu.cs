using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject Library;
    [SerializeField] private GameObject Home;
    
    
    public void ClickHome(){
        if (Home != null){
            Home.SetActive(!Home.activeSelf);
        }

        Library.SetActive(false);
    }

    public void ClickLibrary(){
        if (Library != null){
            Library.SetActive(!Library.activeSelf);
        }

        Home.SetActive(false);
    }
    

    void Start(){
        if (Home = null){
            Home.SetActive(true);
        }
        
        if (Library != null){
            Library.SetActive(false);
        }
    }
}
