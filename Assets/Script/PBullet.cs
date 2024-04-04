using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBullet : MonoBehaviour
{
    public float Speed = 4.0f;
    public int Attack = 10;

    // Update is called once per frame
    void Update()
    {
        // �̻��� ���� �������� �����̱�
        // ���� ���� * ���ǵ� * Ÿ��
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
    }

    // ȭ�� ������ ���� ���
    private void OnBecameInvisible()
    {
        // �ڱ� �ڽ� �����
        Destroy(gameObject);
    }

    // �浹 ó��
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            // ������ �����ϰ� ����
            //collision.gameObject.GetComponent<Monster>().ItemDrop();

            // ���� ����
            //Destroy(collision.gameObject);

            collision.gameObject.GetComponent<Monster>().Damage(Attack);

            // ����� �ֱ�

            // ����Ʈ ����

            // �̻��� ����
            Destroy(gameObject);
        }
    }
}
