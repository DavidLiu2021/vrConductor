using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBlinking : MonoBehaviour
{
    [SerializeField] private float IntervalSecond = 2f;
    [SerializeField] private GameObject Image01;
    [SerializeField] private GameObject Image02;   
    private bool isSwitching = false;
    
    public void ToggleSwitching(){
        if (isSwitching){
            StopCoroutine("SwitchImages");
            isSwitching = false;
        }else{
            StartCoroutine(SwitchImages());
            isSwitching = true;
        }
    }

    private IEnumerator SwitchImages(){
        while (true){
            Image01.SetActive(true);
            Image02.SetActive(false);
            yield return new WaitForSeconds(IntervalSecond);

            Image01.SetActive(false);
            Image02.SetActive(true);
            yield return new WaitForSeconds(IntervalSecond);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        ToggleSwitching();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
