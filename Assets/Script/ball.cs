using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public float speed;
    public Transform move;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameManage.GM.isPlaying!=true) {
            rb.velocity = new Vector3(1f, 1f, 0) * speed * Time.deltaTime;
            GameManage.GM.isPlaying = true;
        }
        if (!GameManage.GM.isPlaying) {
            Vector3 pos = transform.position;
            pos.x = move.position.x;
            pos.y = move.position.y+0.87f;
            transform.position = pos;
        }
    }
}
