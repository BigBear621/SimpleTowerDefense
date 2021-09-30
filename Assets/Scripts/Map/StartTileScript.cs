using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTileScript : MonoBehaviour
{
    Rigidbody targetRigidBody;
    Collider targetCollider;
    Animator targetAnimator;


    private void OnCollisionEnter(Collision collision)
    {
        GameObject targetObject = collision.gameObject;

        if (targetObject.tag.Equals("Monster")
            && !(targetObject.name.Equals("Body")))
        {
            // ��Ż���� ƨ�ܳ����� ǥ���� ���� �ӽ÷� ������ ������ �ٵ�� �ݶ��̴� ����
            targetRigidBody = targetObject.GetComponent<Rigidbody>();
            targetCollider = targetObject.GetComponent<Collider>();
            targetAnimator = targetObject.GetComponent<Animator>();

            Destroy(targetRigidBody);
            Destroy(targetCollider);

            targetAnimator.SetTrigger("DizzyTrigger");
        }
    }
}
