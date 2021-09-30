using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Map : MonoBehaviour
{
    public Transform respawnPoint;

    public GameObject parent;

    [SerializeField] 
    private SlimeMonsterFactory slimeFactory = null;
    [SerializeField]
    private SkeletonMonsterFactory skeletonFactory = null;
    [SerializeField]
    private OrcMonsterFactory orcFactory = null;
    [SerializeField]
    private GolemMonsterFactory golemFactory = null;
    [SerializeField]
    private DragonMonsterFactory dragonFactory = null;

    public GameObject[] wayPoint;

    void Start()
    {
        InvokeRepeating("CreateMonster", 1f, GameManager.Instance.monsterRespawnTime);
    }

    void Update()
    {
        
    }

    private void CreateMonster()
    {
        // �������� ��ü ���ͼ� ����

        if (GameManager.Instance.playTime <= 10f)
        {
            this.slimeFactory.Spawn(parent.transform, respawnPoint.localPosition);
            GameManager.Instance.currentMonsterCount++;
        } 
        else if (GameManager.Instance.playTime <= 20f)
        {
            this.skeletonFactory.Spawn(parent.transform, respawnPoint.localPosition);
            GameManager.Instance.currentMonsterCount++;
        }
        else if (GameManager.Instance.playTime <= 30f)
        {
            this.orcFactory.Spawn(parent.transform, respawnPoint.localPosition);
            GameManager.Instance.currentMonsterCount++;
        }
        else if (GameManager.Instance.playTime <= 40f)
        {
            this.golemFactory.Spawn(parent.transform, respawnPoint.localPosition);
            GameManager.Instance.currentMonsterCount++;
        }
        // �巡�� ������ ���� �ִϸ��̼����� ������ ����
        /*else if (GameManager.Instance.playTime <= 50f)
        {
            this.dragonFactory.Spawn(parent.transform, respawnPoint.localPosition);
            GameManager.Instance.currentMonsterCount++;
        }*/
    }
}
