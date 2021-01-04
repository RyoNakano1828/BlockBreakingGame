using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverChecker : MonoBehaviour
{
    public GameObject ball;

    public GameObject panelOnGameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.tag == "Ball")
        {
            OnGameOver();
        }

    }

    public void OnGameOver()
    {
        panelOnGameOver.SetActive(true);
        ball.SetActive(false);
    }
}
