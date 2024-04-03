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
        // �ѹ� �Լ� ȣ��
        Invoke("CreateBullet", Delay);
    }

    void CreateBullet()
    {
        Instantiate(bullet, ms1.position, Quaternion.identity);
        Instantiate(bullet, ms2.position, Quaternion.identity);

        // ��� ȣ��
        Invoke("CreateBullet", Delay);
    }

    // Update is called once per frame
    void Update()
    {
        // �Ʒ� �������� ��������
        transform.Translate(Vector2.down * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
