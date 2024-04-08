using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHead : MonoBehaviour
{
    [SerializeField] // ����ȭ
    GameObject bossbullet; // ���� �̻���

    // �ִϸ��̼ǿ��� �Լ� ����ϱ�
    public void RightDownLaunch()
    {
        GameObject go = Instantiate(bossbullet, transform.position, Quaternion.identity);

        go.GetComponent<BossBullet>().Move(new Vector2(1, -1)); // ������ �밢�� �Ʒ�
    }

    public void LeftDownLaunch()
    {
        GameObject go = Instantiate(bossbullet, transform.position, Quaternion.identity);

        go.GetComponent<BossBullet>().Move(new Vector2(-1, -1)); // ���� �밢�� �Ʒ�
    }

    public void DownLaunch()
    {
        GameObject go = Instantiate(bossbullet, transform.position, Quaternion.identity);

        go.GetComponent<BossBullet>().Move(new Vector2(0, -1)); // ������ �밢�� �Ʒ�
    }
}