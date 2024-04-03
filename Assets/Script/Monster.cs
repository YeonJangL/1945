using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float Speed = 3.0f;
    public float Delay = 1.0f;
    public Transform ms1;
    public Transform ms2;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        // 한번 함수 호출
        Invoke("CreateBullet", Delay);
    }

    void CreateBullet()
    {
        Instantiate(bullet, ms1.position, Quaternion.identity);
        Instantiate(bullet, ms2.position, Quaternion.identity);

        // 재귀 호출
        Invoke("CreateBullet", Delay);
    }

    // Update is called once per frame
    void Update()
    {
        // 아래 방향으로 움직여라
        transform.Translate(Vector2.down * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
