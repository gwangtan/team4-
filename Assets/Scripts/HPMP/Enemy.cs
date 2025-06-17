using System.Collections;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class Enemy : Entity
{
    private SpriteRenderer spriteRenderer;

    public Sprite[] enemySprites; //적 스프라이트 배열

    private float maxHP;

    private float currentHP;

    public GameManager gameManager; // GameManager 참조

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        base.Setup();

        ChangeEnemy(); // 처음 적 설정
    }

    private void Update()
    {

    }

    public override float MaxHP => maxHP;
    public override float HPRecovery => 0;
    public override float MaxMP => 0;
    public override float MPRecovery => 0;

    public override void TakeDamage(float damage)
    {

        HP -= damage;
        StartCoroutine("HitAnimation");


        if (HP <= 0)
        {
            if (gameManager != null)
            {
                gameManager.AddKillCount();
                Debug.Log($"죽은 적 수: {gameManager.KillCount}");
            }
            ChangeEnemy();
        }
    }

    private IEnumerator HitAnimation()
    {
        Color color = spriteRenderer.color;

        color.a = 0.2f;
        spriteRenderer.color = color;

        yield return new WaitForSeconds(0.1f);

        color.a = 1;
        spriteRenderer.color = color;
    }
    private void ChangeEnemy()
    {
        transform.position = new Vector3(36.14f, -1.81f, 0f);
        // 무작위 스프라이트 선택
        if (enemySprites.Length > 0)
        {
            int index = Random.Range(0, enemySprites.Length);
            spriteRenderer.sprite = enemySprites[index];

        }

        // HP를 200 ~ 500 랜덤 설정
        maxHP = Random.Range(200, 501);
        HP = maxHP;
    }

}