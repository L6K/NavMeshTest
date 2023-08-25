using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed = 5.0f; // �ړ����x

    void Update()
    {
        // Time.deltaTime ���g�p���ăt���[�����[�g�Ɉˑ����Ȃ��ړ����s��
        float moveAmount = speed * Time.deltaTime;

        // �I�u�W�F�N�g�� x �������Ɉړ�������
        transform.Translate(Vector3.right * moveAmount);
    }
}