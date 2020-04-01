using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManage GM;
    public bool isPlaying = false;
    private void Awake()
    {
        GM = this;
    }
    void Start()
    {
        Cube[] allCubes = GameObject.FindObjectsOfType<Cube>();
        foreach (var item in allCubes) {
            item.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void resetBall() {
        isPlaying = false;
    
    }
}
