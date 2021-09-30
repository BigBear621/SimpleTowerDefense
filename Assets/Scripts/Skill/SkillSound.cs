using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ų ���� ���� ��� ������Ʈ�� �����ϴ� ��ũ��Ʈ

public class SkillSound : MonoBehaviour
{
    public GameObject soundObject;

    public bool destroyWhenDone = true;
    public bool soundObjectIsChild = false;

    void Start()
    {
        GameObject madeObject = Instantiate(soundObject, transform.position, Quaternion.identity);
        AudioSource madeSource = madeObject.GetComponent<AudioSource>();

        if (soundObjectIsChild)
            madeObject.transform.SetParent(transform);

        if (destroyWhenDone)
        {
            Destroy(madeObject, madeSource.clip.length);
        }
    }
}