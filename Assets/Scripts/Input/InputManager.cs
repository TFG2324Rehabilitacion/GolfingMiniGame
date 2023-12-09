using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // golpear
            if (GameManager.Instance.BallCreated)
            {
                Debug.Log("Pelota/bomba golpeada");
                GameManager.Instance.BallHit = true;
            }
        }
    }
}
