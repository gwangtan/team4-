using UnityEngine;

public class PotionItem : MonoBehaviour
{
    public int hpPotionCount = 3;   // HP 포션 개수 (임시 초기값)
    public int mpPotionCount = 3;   // MP 포션 개수 (임시 초기값)

    private Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            UseHPPotion();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            UseMPPotion();
        }
    }

    public void UseHPPotion()
    {
        if (hpPotionCount > 0 && player.HP < player.MaxHP)
        {
            player.HP += 40;
            hpPotionCount--;
            Debug.Log($"HP 포션 사용! 남은 수: {hpPotionCount}, 현재 HP: {player.HP}");
        }
        else
        {
            Debug.Log("HP 포션이 없거나 HP가 이미 가득 찼습니다.");
        }
    }

    public void UseMPPotion()
    {
        if (mpPotionCount > 0 && player.MP < player.MaxMP)
        {
            player.MP += 50;
            mpPotionCount--;
            Debug.Log($"MP 포션 사용! 남은 수: {mpPotionCount}, 현재 MP: {player.MP}");
        }
        else
        {
            Debug.Log("MP 포션이 없거나 MP가 이미 가득 찼습니다.");
        }
    }

    // 상점에서 포션을 구매할 때 이 메소드를 호출하면 됩니다.
    public void AddPotion(string type, int amount)
    {
        if (type == "HP")
            hpPotionCount += amount;
        else if (type == "MP")
            mpPotionCount += amount;
    }
}
