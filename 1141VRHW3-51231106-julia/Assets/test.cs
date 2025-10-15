using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // ����t��

    void Start()
    {
        // �v��v�]�� 60 FPS
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // ���U�ƹ��N�]�w����t��
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        // ����N�̷ӳ]�w���t�ױ���
        transform.Rotate(0, 0, this.rotSpeed);

        // ����N��t(�s�W)
        this.rotSpeed *= 0.96f;
    }
}

