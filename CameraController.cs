using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 pos;

    void Update()
    { //�÷��̾ ���� ī�޶� �̵�
        pos = new Vector3(
            player.transform.position.x + 1.0f,
            0,
            player.transform.position.z - 10.0f);
        gameObject.transform.position = Vector3.Lerp(
            gameObject.transform.position,
            pos,
            3 * Time.deltaTime);
    }
}
