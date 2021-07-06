using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csMissile : MonoBehaviour
{

    ParticleSystem testParticle = null;

    // Start is called before the first frame update
    void Start()
    {
        testParticle = GetComponent<ParticleSystem>();
        testParticle.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (testParticle)
            {
                if(testParticle.isPlaying == true)
                {
                    testParticle.Stop();
                    testParticle.Clear();

                    Debug.Log("STOP");
                }
                else
                {
                    testParticle.Play();

                    Debug.Log("PLAY");
                }
            }
        }
    }
}
