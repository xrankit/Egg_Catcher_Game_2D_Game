using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   // public void OnTriggerEnter2D(Collider2D Other)
   // {
   //     Destroy(Other.gameObject);
   // }

    public void OnTriggerEnter2D(Collider2D other)
    {
       if(other.gameObject.tag == "Egg")
       {
           Destroy(other.gameObject);
       }
       if(other.gameObject.tag == "Bomb")
       {
          Destroy(other.gameObject);
       }
    }
}
