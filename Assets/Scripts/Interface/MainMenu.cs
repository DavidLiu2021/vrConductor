using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject History;
    [SerializeField] private GameObject Home;
    [SerializeField] private GameObject Tutorial;
    
    // public void ClickDiscover(){
    //     if (History != null){
    //         History.SetActive(!History.activeSelf);
    //     }

    //     Home.SetActive(false);
    //     Tutorial.SetActive(false);
    // }
    
    public void ClickHome(){
        // if (Home != null){
        //     Home.SetActive(!Home.activeSelf);
        // }
        Home.SetActive(true);

        // History.SetActive(false);
        Tutorial.SetActive(false);
    }

    public void ClickTutorial(){
        if (Tutorial != null){
            Tutorial.SetActive(!Tutorial.activeSelf);
        }

        Home.SetActive(false);
        // History.SetActive(false);
    }
    

    void Start(){

        // if (History != null){
        //     History.SetActive(false);
        // }

        if (Home = null){
            Home.SetActive(true);
        }
        
        if (Tutorial != null){
            Tutorial.SetActive(false);
        }
    }
}
