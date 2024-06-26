using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MBullet : MonoBehaviour
{
    public float Speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    // 충돌처리
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            // 플레이어 지우기

            // 미사일 지우기
            Destroy(gameObject);
        }
    }
}
