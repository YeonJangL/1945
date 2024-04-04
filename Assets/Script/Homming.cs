using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homming : MonoBehaviour
{
    GameObject target; // �÷��̾�
    public float Speed = 3.0f;

    Vector2 dir;
    Vector2 dirNo;

    // Start is called before the first frame update
    void Start()
    {
        // �÷��̾� �±׷� ã��
        target = GameObject.FindGameObjectWithTag("Player");

        // A - B -> A�� �ٶ󺸴�  ���Ͱ� ����
        dir = target.transform.position - transform.position;
        // ���� ���͸� ���ϱ� �������� 1�� ũ��� �����
        dirNo = dir.normalized;

        // ����Ƽ���� ������ �Լ��� ����
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
            // �̻��� �����
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
