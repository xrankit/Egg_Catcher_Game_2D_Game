using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewFeatures : MonoBehaviour
{
    //public GameObject cube;
    //public GameObject prefab;
    void Awake()
    {
        Debug.Log("hello");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        //cube.transform.position = new Vector3(10, 10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
        //Instantiate(prefab, new Vector3(Random.Range(0, 10), 0, 0), Quaternion.identity);
    }
}
