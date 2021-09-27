using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ ������ ���� enum
public enum MONSTER_SKELETON
{

}

public class SkeletonMonsterFactory : MonsterFactory<MONSTER_SKELETON>
{
    // �����Ӱ� ���õ� ��ü�� ��������� ������.
    [SerializeField]
    private GameObject skeletonPrefab = null;
    // [SerializeField] private GameObject goblinBigPrefab = null; 
    // [SerializeField] private GameObject goblinKingPrefab = null; 
    // MonsterFactory���� ��ӹ��� create �Լ��� �ٸ��ش�.

    protected override Monster Create()
    {
        Skeleton skeleton = null;
        skeleton = Instantiate(this.skeletonPrefab).GetComponent<Skeleton>();
        // ���⼭ �ƽôٽ��� goblin�� Monster�� ��ӹ޽��ϴ�.

        return skeleton;
    }
    protected override Monster Create(MONSTER_SKELETON _type)
    {
        Skeleton skeleton = null;

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
        skeleton = Instantiate(this.skeletonPrefab).GetComponent<Skeleton>();
        // ���⼭ �ƽôٽ��� goblin�� Monster�� ��ӹ޽��ϴ�.

        return skeleton;
    }
}
