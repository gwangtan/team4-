using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public GameManager gameManager; // 점수 참조용
    public Player player;           // 플레이어 참조

    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        if (player.target != null && !gameManager.isOver && player.MP >= 1)
        {
            float damage = gameManager.score * 10f; // 점수 × 10
            player.target.TakeDamage(damage);
            player.MP -= 1;

            Debug.Log($"[공격] 점수 {gameManager.score} × 10 = {damage} 데미지 입힘");

            gameManager.score = 0; // 점수 초기화

            gameManager.GameOver();
        }

        else if (player.MP < 1)
        {
            Debug.Log("마나가 부족합니다! (MP < 1)");
        }
        
    }
}