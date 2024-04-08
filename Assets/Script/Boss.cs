using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    int flag = 1;
    int speed = 2;

    public GameObject mb;
    public GameObject mb2;
    public Transform pos1;
    public Transform pos2;

    // Start is called before the first frame update
    void Start()
    {
        // 1�� �ڿ� HIde �Լ� ȣ��
        Invoke("Hide", 1);

        StartCoroutine(BossMissle()); // �ڷ�ƾ ����
        StartCoroutine(CicleFire()); // �ڷ�ƾ ����
    }

    void Hide()
    {
        // ���� �ؽ�Ʈ ��ü �̸� �˻��ؼ� ã��
        GameObject.Find("TextBossWarning").SetActive(false);
    }

    IEnumerator BossMissle()
    {
        while(true)
        {
            // �̻��� �ΰ�
            Instantiate(mb, pos1.position, Quaternion.identity);
            Instantiate(mb, pos2.position, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }

    // ���������� �̻��� �߻�
    IEnumerator CicleFire()
    {
        // ���� �ֱ�
        float attackRate = 3;
        // �߻�ü ���� ����
        int count = 30;
        // �߻�ü ������ ����
        float intervalAngle = 360 / count;
        // ���ߵǴ� ����(�׻� ���� ��ġ�� �߻����� �ʵ��� ����
        float weightAngle = 0f;

        // �� ���·� ����ϴ� �߻�ü ����(count ���� ��ŭ)
        while(true)
        {
            for (int i = 0; i < count; i++)
            {
                // �߻�ü ����
                GameObject clone = Instantiate(mb2, transform.position, Quaternion.identity);

                // �߻�ü �̵� ����(����)
                float angle = weightAngle * intervalAngle * i;
                // �߻�ü �̵� ����(����)
                // Cos(����) ���� ������ ���� ǥ���� ���� pi / 180�� ����
                float x = Mathf.Cos(angle * Mathf.Deg2Rad);
                // sin(����) ���� ������ ���� ǥ���� ���� PI / 100�� ����
                float y = Mathf.Sin(angle * Mathf.Deg2Rad);

                // �߻�ü �̵� ���� ����
                clone.GetComponent<BossBullet>().Move(new Vector2(x, y));
            }

            // �߻�ü�� �����Ǵ� ���� ���� ������ ���� ����
            weightAngle += 1;

            // 3�� ���� �̻��� �߻�
            yield return new WaitForSeconds(attackRate);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 1)
        {
            flag *= -1;
        }
        if (transform.position.x < -1)
        {
            flag *= -1;
        }

        transform.Translate(flag * speed * Time.deltaTime, 0, 0);
    }
}
