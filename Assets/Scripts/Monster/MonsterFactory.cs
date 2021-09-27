using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����Ƽ�� ���� ����ϱ� ���ϰ� ���׸�Ÿ�԰� ���� ��¦ �����߽��ϴ�.
public abstract class MonsterFactory<T> : MonoBehaviour 
{
    public Monster Spawn(Transform parent, Vector3 spawnPoint)
    {
        // ����Ŭ�������� ������ create �Լ� ȣ�� - ����Ŭ������ ������ ��ü�� ��ȯ
        Monster monster = this.Create();
        // �Ű������� �޴� transform�� �θ�� ����
        monster.transform.SetParent(parent, false);
        monster.transform.localRotation = Quaternion.Euler(0f, -90f, 0f);
        // ������ ���� ������ ��ġ�� ����
        monster.transform.localPosition = spawnPoint;

        return monster;
    }
    // �ܺο��� ȣ���ϴ� �Լ� - ���丮���ο��� ó���Ҽ��ִ� ��� ó���� ���⼭����.
    public Monster Spawn(T type, Transform parent, Vector3 spawnPoint)
    {
        // ����Ŭ�������� ������ create �Լ� ȣ�� - ����Ŭ������ ������ ��ü�� ��ȯ
        Monster monster = this.Create(type);

        // �Ű������� �޴� transform�� �θ�� ����
        monster.transform.SetParent(parent, false);

        // ������ ���� ������ ��ġ�� ����
        monster.transform.localPosition = spawnPoint; 
        
        return monster;
    }
    // Ÿ���� �ٸ� ���� ������� ����
    protected abstract Monster Create();
    // Ÿ���� �ٸ� ���� ������� ����
    protected abstract Monster Create(T type); 
}

