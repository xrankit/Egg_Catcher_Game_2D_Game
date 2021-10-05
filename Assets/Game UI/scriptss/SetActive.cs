using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject button;

    public void click()
    {
        if(button.activeInHierarchy == true)
        {
            button.SetActive(false);
        }
        else
        {
            button.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
