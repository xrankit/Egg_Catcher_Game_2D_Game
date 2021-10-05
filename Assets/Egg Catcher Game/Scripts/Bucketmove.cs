using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucketmove : MonoBehaviour
{
    public GameObject Bucket;
    private Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Handle screen touches.
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {

            }
            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 pos = touch.position;
                Vector3 pos1 = new Vector3(pos.x, 0, 0);
                Bucket.transform.position = pos1;
            }
            if (touch.phase == TouchPhase.Ended)
            {

            }
        }

        //if (Input.GetKey(KeyCode.RightArrow) && (Bucket.transform.position.x < Screen.width))
        // {
        //     Bucket.transform.position += new Vector3(1, 0, 0);
        // }
        // else if (Input.GetKey(KeyCode.LeftArrow) && (Bucket.transform.position.x > 0.0f))
        // {
        //     Bucket.transform.position += new Vector3(-1, 0, 0);
        // }
    }
}
