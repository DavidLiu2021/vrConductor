using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoDisplay : MonoBehaviour
{
    [SerializeField] private GameObject logoObject;
    [SerializeField] private GameObject MainMenu;
    [SerializeField] private GameObject HomePage;
    [SerializeField] private float waitSeconds = 3f;

    void Start()
    {
        MainMenu.SetActive(false);
        HomePage.SetActive(false);
        StartCoroutine(ShowLogoTemporarily());
    }

    IEnumerator ShowLogoTemporarily(){
        logoObject.SetActive(true);

        yield return new WaitForSeconds(waitSeconds);

        logoObject.SetActive(false);

        MainMenu.SetActive(true);
        HomePage.SetActive(true);
    }
}
