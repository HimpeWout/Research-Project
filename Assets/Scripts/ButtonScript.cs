using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject GestureScreen;
    private bool isShown = false;
    private bool isDown = false;

    // Start is called before the first frame update
    private Vector3 startposition;
    void Start()
    {
        startposition = transform.position;
        GestureScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //always lerp to start position
        transform.position = Vector3.Lerp(transform.position, startposition, 0.1f);
        if(transform.position.y <= startposition.y - 0.015f && isDown == false)
        {
            if (isShown)
            {
                GestureScreen.SetActive(false);
                isShown = false;
                isDown = true;
            }
            else
            {
                GestureScreen.SetActive(true);
                isShown = true;
                isDown = true;
            }
        }
        if (transform.position.y >= startposition.y - 0.01f && isDown == true)
        {
            isDown = false;
        }
    }
}
