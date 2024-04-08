using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    public GameObject effect;
    Transform pos;
    int Attack = 10;

    // Start is called before the first frame update
    void Start()
    {
        pos = GameObject.Find("Player").GetComponent<Player>().pos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pos.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Monster")
        {
            collision.gameObject.GetComponent<Monster>().Damage(Attack++);

            // 이펙트 생성
            GameObject go = Instantiate(effect, collision.transform.position, Quaternion.identity);

            // 이펙트 1초뒤 지우기
            Destroy(go, 1);
        }

        if (collision.tag == "Boss")
        {
            // 이펙트 생성
            GameObject go = Instantiate(effect, collision.transform.position, Quaternion.identity);

            // 이펙트 1초뒤 지우기
            Destroy(go, 1);
        }
    }

    // 계속 충돌이 일어날때
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Monster")
        {
            collision.gameObject.GetComponent<Monster>().Damage(Attack++);

            // 이펙트 생성
            GameObject go = Instantiate(effect, collision.transform.position, Quaternion.identity);

            // 이펙트 1초뒤 지우기
            Destroy(go, 1);
        }

        if (collision.tag == "Boss")
        {
            // 이펙트 생성
            GameObject go = Instantiate(effect, collision.transform.position, Quaternion.identity);

            // 이펙트 1초뒤 지우기
            Destroy(go, 1);
        }
    }
}
