using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed = 5.0f; // 移動速度

    void Update()
    {
        // Time.deltaTime を使用してフレームレートに依存しない移動を行う
        float moveAmount = speed * Time.deltaTime;

        // オブジェクトを x 軸方向に移動させる
        transform.Translate(Vector3.right * moveAmount);
    }
}