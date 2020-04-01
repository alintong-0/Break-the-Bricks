using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float xmin = -6.13f;
    public float xmax = 6.6f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
         float x = Input.GetAxisRaw("Horizontal");
        
        Vector3 pos = transform.position;
        if (x - pos.x > 0)
        {
            pos.x += x * Time.deltaTime * speed;
            pos.x = Mathf.Clamp(pos.x, xmin, xmax);
            transform.position = pos;

        }
        else {
            pos.x -= x * Time.deltaTime * speed;
            pos.x = Mathf.Clamp(pos.x, xmin, xmax);
            transform.position = pos;
        }
        */
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            float x = touchDeltaPosition.x;

            Vector3 pos = transform.position;
            
                pos.x += x * Time.deltaTime * speed;
                pos.x = Mathf.Clamp(pos.x, xmin, xmax);
                transform.position = pos;

            
        }
    }
  
}
