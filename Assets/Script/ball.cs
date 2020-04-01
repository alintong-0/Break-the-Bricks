using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public float speed;
    public Transform move;
    public static GameManage GM;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameManage.GM.isPlaying!=true) {
            rb.velocity = new Vector3(5f, 5f, 0) * speed * Time.deltaTime;
            GameManage.GM.isPlaying = true;
        }
        if (!GameManage.GM.isPlaying) {
            Vector3 pos = transform.position;
            pos.x = move.position.x;
            pos.y = move.position.y+3.87f;
            transform.position = pos;
        }
    }
    public void OnCollisionExit(Collision collision)
    {
        if (GM.isPlaying) {
            Vector3 v = rb.velocity.normalized;
            rb.velocity = v * speed;
        }
    }
}
