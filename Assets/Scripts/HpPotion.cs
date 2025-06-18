using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPotion : MonoBehaviour
{
    public GameObject playerObject;

    public Player player;  // 플레이어 참조

    private void Awake()
    {
        if (playerObject != null)
        {
            player = playerObject.GetComponent<Player>();

        }
 
    }

    // 버튼에서 호출할 함수
    public void UsePotion()
    {
        if (player != null)
        {
            player.HP += 100;
            player.HP = Mathf.Clamp(player.HP, 0, player.MaxHP);
        }  
    } 
}


