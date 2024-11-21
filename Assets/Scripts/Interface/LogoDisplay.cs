using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoDisplay : MonoBehaviour
{
    [SerializeField] private GameObject logoObject;
    [SerializeField] private GameObject nextObjectToActive;
    [SerializeField] private float waitSeconds = 3f;

    void Start()
    {
        StartCoroutine(ShowLogoTemporarily());
    }

    IEnumerator ShowLogoTemporarily(){
        logoObject.SetActive(true);

        yield return new WaitForSeconds(waitSeconds);

        logoObject.SetActive(false);

        nextObjectToActive.SetActive(true);
    }
}
