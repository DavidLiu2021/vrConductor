using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordMenu : MonoBehaviour
{
    [SerializeField] private GameObject Record;
    [SerializeField] private GameObject Stop;
    [SerializeField] private GameObject Confirm;
    [SerializeField] private GameObject Library;
    
    public void StartRecord(){
        Record.SetActive(false);
        Stop.SetActive(true);
    }

    public void StopRecord(){
        Stop.SetActive(false);
        Record.SetActive(true);
        Confirm.SetActive(true);
    }

    public void BackToLibrary(){
        Confirm.SetActive(false);
        Library.SetActive(true);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Stop.SetActive(false);
        Confirm.SetActive(false);
        Library.SetActive(false);

        Record.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
