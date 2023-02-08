using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController2 : MonoBehaviour
{
    public GameObject player;
    private Vector3 pos;

    // Update is called once per frame
    void Update()
    { //�÷��̾ ���� ī�޶� �̵�
        pos = new Vector3(
            player.transform.position.x + 1.0f,
            player.transform.position.y + 0.5f,
            player.transform.position.z - 10.0f);
        gameObject.transform.position = Vector3.Lerp(
            gameObject.transform.position,
            pos,
            3 * Time.deltaTime);
    }
}
