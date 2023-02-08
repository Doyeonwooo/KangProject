using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PotalController : MonoBehaviour
{
    public GameObject player;
    public GameObject potal;

    private int stageCount = 1;

    void Update()
    {  //�÷��̾ ��Ż�� �浹�Ͽ� stageCount�� ���� �����Ҷ����� ���� ��������(��)����
        if(stageCount == 2)
        {
            SceneManager.LoadScene(2);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player") //�÷��̾ �浹�Ѱ��� ���� �ɶ� stageCount 1 ����
        {
            stageCount++;
        }
    }
}
