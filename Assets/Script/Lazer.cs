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

            // ����Ʈ ����
            GameObject go = Instantiate(effect, collision.transform.position, Quaternion.identity);

            // ����Ʈ 1�ʵ� �����
            Destroy(go, 1);
        }

        if (collision.tag == "Boss")
        {
            // ����Ʈ ����
            GameObject go = Instantiate(effect, collision.transform.position, Quaternion.identity);

            // ����Ʈ 1�ʵ� �����
            Destroy(go, 1);
        }
    }

    // ��� �浹�� �Ͼ��
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Monster")
        {
            collision.gameObject.GetComponent<Monster>().Damage(Attack++);

            // ����Ʈ ����
            GameObject go = Instantiate(effect, collision.transform.position, Quaternion.identity);

            // ����Ʈ 1�ʵ� �����
            Destroy(go, 1);
        }

        if (collision.tag == "Boss")
        {
            // ����Ʈ ����
            GameObject go = Instantiate(effect, collision.transform.position, Quaternion.identity);

            // ����Ʈ 1�ʵ� �����
            Destroy(go, 1);
        }
    }
}
