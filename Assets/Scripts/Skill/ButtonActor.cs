using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ��ų��ư�� ������ ���� ������ �����ϴ� ��ũ��Ʈ

public class ButtonActor : MonoBehaviour
{
    Image image;
    Button button;
    public GameObject skill;
    float coolTime;
    float leftTime;
    float fillRatio;

    void Start()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();
        coolTime = skill.GetComponent<Skill>().rate;
        button.onClick.AddListener(UseSkill);
    }

    void UseSkill()
    {
        Debug.Log(gameObject.name + " ���");
        leftTime = coolTime;
        button.enabled = false;
        transform.localScale /= 1.2f;
        image.color = new Color(1f, 1f, 1f, 0.8f);
        StartCoroutine(CoolTime());
    }

    IEnumerator CoolTime()
    {
        Debug.Log("Cooling");
        while (true)
        {
            leftTime -= Time.deltaTime;
            fillRatio = 1f - (leftTime / coolTime);
            image.fillAmount = fillRatio;
            Debug.Log(gameObject.name + ": ��Ÿ�� " + (int)leftTime + "��");
            yield return null;

            if (leftTime <= 0)
            {
                leftTime = 0;
                Cooled();
                yield break;
            }
        }
    }

    void Cooled()
    {
        Debug.Log("Cooled");
        button.enabled = true;
        transform.localScale *= 1.2f;
        image.color = new Color(1f, 1f, 1f, 1f);
    }
}