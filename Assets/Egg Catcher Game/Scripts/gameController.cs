using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public GameObject egg;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(egg, transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        Instantiate(egg, transform.position, Quaternion.identity);
    }

}
