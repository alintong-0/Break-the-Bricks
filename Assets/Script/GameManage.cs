using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManage : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManage GM;
    public bool isPlaying = false;
    public int life = 3;
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
        if (life == 0) {
            GameOver();
        }
        win();
        
    }
    public void GameOver() {
        if (life == 0)
        {
            Destroy(GameObject.Find("ball"));
            Destroy(GameObject.Find("move"));
            GameObject.Find("Canvas").transform.Find("lose").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("restart").gameObject.SetActive(true);
        }
        else
        {
            life--;
            GameObject.Find("life").GetComponent<Text>().text = "生命数: " + life;
        }
        isPlaying = false;
    }
    public void win() {
        Cube[] allCubes = GameObject.FindObjectsOfType<Cube>();
        if (allCubes.Length == 0)
        {
            Destroy(GameObject.Find("ball"));
            Destroy(GameObject.Find("move"));
            GameObject.Find("Canvas").transform.Find("win").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("next").gameObject.SetActive(true);
        }
    }
}
