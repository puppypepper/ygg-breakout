using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventSystem : MonoBehaviour
{
    public GameObject Ball;
    public GameObject ClearUI;
    public GameObject RestartUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {

        int count = GameObject.FindGameObjectsWithTag("Block").Length;

        if (count == 0) 
        {
            Destroy(Ball);
            ClearUI.SetActive(true);
            RestartUI.SetActive(true);
        }
        
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
