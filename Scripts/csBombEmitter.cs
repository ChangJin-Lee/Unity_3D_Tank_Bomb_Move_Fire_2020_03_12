using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csBombEmitter : MonoBehaviour
{

    public GameObject bombPrefab;

    float BOMB_DELAY = 5;       // 표시 간격 초깃값

    float bombDelay;            // 표시 간격
    float randomX, rnadomZ;

    Vector3 bombPosition;

    // Start is called before the first frame update
    void Start()
    {
        bombDelay = 0;

    }

    // Update is called once per frame
    void Update()
    {
        bombDelay -= Time.deltaTime;    // 지연시간 계산

        if (bombDelay <= 0)
        {
            float randomX = UnityEngine.Random.Range(720f, 800f);
            float randomZ = UnityEngine.Random.Range(630f, 710f);

            bombPosition = new Vector3(randomX, 30, randomZ);

            // 폭탄 만들기
            Instantiate(bombPrefab, bombPosition, bombPrefab.transform.rotation);

            // 지연시간 감소
            BOMB_DELAY = Mathf.Clamp(BOMB_DELAY * 0.99f, 0.9f, 5); // (value, min, max)
            bombDelay = BOMB_DELAY;
        }
    }
}
