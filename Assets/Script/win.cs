using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void nextLevel()
    {
        SceneManager.LoadScene("SampleScene");
        GameObject.Find("ball").GetComponent<ball>().speed = GameObject.Find("ball").GetComponent<ball>().speed + 300;
    }
}
