using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public HingeJoint hinge;
    public GameObject effect;
    // Start is called before the first frame update
    void Start()
    {
        effect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (hinge.angle < -50)
        {
            effect.SetActive(true);
        }
        else
        {
            effect.SetActive(false);
        }
    }
}
