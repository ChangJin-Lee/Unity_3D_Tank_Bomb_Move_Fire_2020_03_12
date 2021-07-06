using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csBombTest : MonoBehaviour
{
    public GameObject explosionParticlesPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Update is called once per frame
    public void OnCollisionEnter(Collision collision)
    {
        if (explosionParticlesPrefab)
        {
            GameObject explosion = (GameObject)Instantiate(explosionParticlesPrefab, transform.position, transform.rotation);
            Destroy(explosion, explosion.GetComponent<ParticleSystem>().main.startLifetime.constant);

            Destroy(gameObject);
        }

        // 탱크가 부딪치면 탱크를 없애겠다.
        if(collision.gameObject.tag == "TANK")
        {
            Destroy(collision.gameObject);

            // 탱크가 터지면 게임이 끝나겠다
#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
    Application.OpenURL(webplayerQuitURL);
#else
    Application.Quit();
#endif
        }
    }
}
