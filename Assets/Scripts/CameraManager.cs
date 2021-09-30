using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera mainCamera;
    public Camera bossCamera;

    // ī�޶� ����
    public float shakeAmount;
    float shakeTime;

    Vector3 initialPosition;

    // �̱��� ������ ����ϱ� ���� �ν��Ͻ� ����
    private static CameraManager _instance;
    // �ν��Ͻ��� �����ϱ� ���� ������Ƽ
    public static CameraManager Instance
    {
        get
        {
            // �ν��Ͻ��� ���� ��쿡 �����Ϸ� �ϸ� �ν��Ͻ��� �Ҵ�.
            if (!_instance)
            {
                _instance = FindObjectOfType(typeof(CameraManager)) as CameraManager;

                if (_instance == null)
                    Debug.Log("no Singleton obj");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        // �ν��Ͻ��� �����ϴ� ��� ���λ���� �ν��Ͻ��� �����Ѵ�.
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
        // �Ʒ��� �Լ��� ����Ͽ� ���� ��ȯ�Ǵ��� ����Ǿ��� �ν��Ͻ��� �ı����� �ʴ´�.
        DontDestroyOnLoad(gameObject);
    }


    public void MainCameraOn()
    {
        mainCamera.enabled = true;
        bossCamera.enabled = false;
    }
    public void BossCameraOn()
    {
        mainCamera.enabled = false;
        bossCamera.enabled = true;
    }

    public void VibrateForTime(float time)
    {
        shakeTime = time;
    }
    // Start is called before the first frame update
    void Start()
    {
        MainCameraOn();
        initialPosition = new Vector3(315.4f, 1160f, -995.8f);
    }

    // Update is called once per frame
    void Update()
    {
        if(shakeTime > 0)
        {
            transform.position = Random.insideUnitSphere * shakeAmount + initialPosition;
            shakeTime -= Time.deltaTime;
        }
        else
        {
            shakeTime = 0.0f;
            transform.position = initialPosition;
        }
    }
}
