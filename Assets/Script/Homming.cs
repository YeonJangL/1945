using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homming : MonoBehaviour
{
    GameObject target; // 플레이어
    public float Speed = 3.0f;

    Vector2 dir;
    Vector2 dirNo;

    // Start is called before the first frame update
    void Start()
    {
        // 플레이어 태그로 찾기
        target = GameObject.FindGameObjectWithTag("Player");

        // A - B -> A를 바라보는  벡터가 나옴
        dir = target.transform.position - transform.position;
        // 방향 벡터만 구하기 단위벡터 1의 크기로 만든다
        dirNo = dir.normalized;

        // 유니티에서 구현된 함수가 있음
        //Vector3.MoveTowards
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dirNo * Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            // 미사일 지우기
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
