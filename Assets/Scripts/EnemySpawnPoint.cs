using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour
{
    public GameObject enemyPrefab;       // 프리팹 연결
    public Transform enemySpawnPoint;    // 원하는 생성 위치(빈 오브젝트로 씬에 배치)

    void Start()
    {
        SpawnEnemy();
    }

    public void SpawnEnemy()
    {
        Instantiate(enemyPrefab, enemySpawnPoint.position, Quaternion.identity);
    }
}
