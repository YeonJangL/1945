using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHead : MonoBehaviour
{
    [SerializeField] // 직렬화
    GameObject bossbullet; // 보스 미사일

    // 애니메이션에서 함수 사용하기
    public void RightDownLaunch()
    {
        GameObject go = Instantiate(bossbullet, transform.position, Quaternion.identity);

        go.GetComponent<BossBullet>().Move(new Vector2(1, -1)); // 오른쪽 대각선 아래
    }

    public void LeftDownLaunch()
    {
        GameObject go = Instantiate(bossbullet, transform.position, Quaternion.identity);

        go.GetComponent<BossBullet>().Move(new Vector2(-1, -1)); // 왼쪽 대각선 아래
    }

    public void DownLaunch()
    {
        GameObject go = Instantiate(bossbullet, transform.position, Quaternion.identity);

        go.GetComponent<BossBullet>().Move(new Vector2(0, -1)); // 오른쪽 대각선 아래
    }
}
