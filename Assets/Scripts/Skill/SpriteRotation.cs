using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // ��ǥ������ �̹����� ȸ���� �������� �ִ� ��ũ��Ʈ

public class SpriteRotation : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward, speed);   
    }
}
