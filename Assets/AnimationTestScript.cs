using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTestScript : MonoBehaviour
{

    public Animator step1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            step1.SetBool("step1", true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            step1.SetBool("step2", true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            step1.SetBool("step3", true);
        }
    }
}
