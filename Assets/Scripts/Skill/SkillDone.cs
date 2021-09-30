using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillDone : MonoBehaviour
{
    public float duration;

    void Start()
    {
        StartCoroutine(Duration());
    }

    IEnumerator Duration()
    {
        Debug.Log("���ӽð�: " + duration);
        yield return new WaitForSeconds(duration);
        Destroy(gameObject);
    }
}
