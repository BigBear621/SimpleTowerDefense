using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointBehaviour : MonoBehaviour
{
    string currentName;
    float distance;

    public GameObject[] wayPoint;

    private void Start()
    {
        currentName = gameObject.name;
    }

    private void OnTriggerStay(Collider other)
    {
        // Debug.Log($"{other.gameObject.transform.parent.gameObject.name} �浹!!");
        if (other.gameObject.tag == "Monster")
        {
            // targetBodyObject�� ������ body������Ʈ
            GameObject targetBodyObject = other.gameObject;
            Transform targetBodyTransform = targetBodyObject.transform;
            // targetObject�� ���� ��ü ������Ʈ
            GameObject targetObject = targetBodyTransform.parent.gameObject;
            Transform targetTransform = targetObject.transform;

            distance = Vector3.Distance(gameObject.transform.position, targetTransform.position);

            if (distance < 0.1f)
            {
                if (currentName.Equals("Waypoint1"))
                {
                    targetTransform.LookAt(wayPoint[1].transform);
                }
                else if (currentName.Equals("Waypoint2"))
                {
                    // Debug.Log("waypoint2 ���");
                    targetTransform.LookAt(wayPoint[2].transform);
                }
                else if (currentName.Equals("Waypoint3"))
                {
                    // Debug.Log("waypoint3 ���");
                    targetTransform.LookAt(wayPoint[3].transform);
                }
                else if (currentName.Equals("Waypoint4"))
                {
                    // Debug.Log("waypoint4 ���");
                    targetTransform.LookAt(wayPoint[4].transform);
                }
                else if (currentName.Equals("Waypoint5"))
                {
                    // Debug.Log("waypoint5 ���");
                    targetTransform.LookAt(wayPoint[1].transform);
                }
            }
        }
    }
}
