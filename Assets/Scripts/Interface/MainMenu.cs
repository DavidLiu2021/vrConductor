using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject Library;
    [SerializeField] private GameObject Home;
    
    
    public void ClickHome(){
        Home.SetActive(true);
        Library.SetActive(false);
    }

    public void ClickLibrary(){
        Library.SetActive(true);
        Home.SetActive(false);

    }
    

    void Start(){
        if (Home == null){
            Home.SetActive(true);
        }
        
        if (Library != null){
            Library.SetActive(false);
        }
    }
}
