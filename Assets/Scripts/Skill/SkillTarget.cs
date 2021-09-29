using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ ����ϴ� ��ų�� ��ǥ������ �����̴� ��ũ��Ʈ

public class SkillTarget : MonoBehaviour
{
    public Transform target;
    int layerMask;

    Ray ray;
    RaycastHit hit;
    public GameObject ground;
    float groundHeight;

    void Start()
    {
        // ���� ���͸� ����Ͽ� ���� ������ �ν���
        layerMask = 1 << LayerMask.NameToLayer("Ground") | ~(1 << LayerMask.NameToLayer("Monster"));
        groundHeight = ground.transform.position.y + 1f;
    }

    void Update()
    {
        // ù ��° ī�޶� ���� ���콺 ��ġ�� ���� ��
        ray = Camera.allCameras[0].ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 1000f, layerMask))
            target.position = new Vector3(hit.point.x, groundHeight, hit.point.z);
    }
}
