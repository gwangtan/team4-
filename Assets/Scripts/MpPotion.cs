using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MpPotion : MonoBehaviour
{
    public GameObject playerObject;  // 플레이어 오브젝트 직접 할당

    public Player player;// 플레이어 참조

    private void Awake()
    {
        if (playerObject != null)
        {
            player = playerObject.GetComponent<Player>();
        }
    }

    public void UsePotion()
    {
        if (player != null)
        {
            player.MP += 50;
            player.MP = Mathf.Clamp(player.MP, 0, player.MaxMP);
        }
        
    }
}
