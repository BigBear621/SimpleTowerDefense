using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ ������ ���� enum
public enum MONSTER_SLIME 
{ 

}

public class SlimeMonsterFactory : MonsterFactory<MONSTER_SLIME>
{
    // �����Ӱ� ���õ� ��ü�� ��������� ������.
    [SerializeField] 
    private GameObject slimePrefab = null; 
    // [SerializeField] private GameObject goblinBigPrefab = null; 
    // [SerializeField] private GameObject goblinKingPrefab = null; 
    // MonsterFactory���� ��ӹ��� create �Լ��� �ٸ��ش�.

    protected override Monster Create()
    {
        Slime slime = null;
        slime = Instantiate(this.slimePrefab).GetComponent<Slime>();
        // ���⼭ �ƽôٽ��� goblin�� Monster�� ��ӹ޽��ϴ�.

        return slime;
    }
    protected override Monster Create(MONSTER_SLIME _type) 
    { 
        Slime slime = null; 
        
        /*switch (_type) 
        { 
            // �Ű������� ���� Enum������ �������� ��� ��ü ����
            case MONSTER_GOBLIN.NORMAL : goblin = Instantiate(this.goblinPrefab).GetComponent<Goblin>(); 
                break; 
            case MONSTER_GOBLIN.BIG : goblin = Instantiate(this.goblinBigPrefab).GetComponent<Goblin>(); 
                break; 
            case MONSTER_GOBLIN.KING : goblin = Instantiate(this.goblinKingPrefab).GetComponent<Goblin>(); 
                break; 
        }*/
        slime = Instantiate(this.slimePrefab).GetComponent<Slime>();
        // ���⼭ �ƽôٽ��� goblin�� Monster�� ��ӹ޽��ϴ�.

        return slime; 
    }
}
