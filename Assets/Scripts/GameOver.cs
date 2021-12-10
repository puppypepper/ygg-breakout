using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public GameObject Ball;
    public GameObject GameOverUI;
    public GameObject RestartUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) 
    {
        Destroy(Ball);
        GameOverUI.SetActive(true);
        RestartUI.SetActive(true);
    }
}
