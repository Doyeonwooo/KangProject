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
    {  //플레이어가 포탈에 충돌하여 stageCount의 값이 증가할때마다 다음 스테이지(씬)으로
        if(stageCount == 2)
        {
            SceneManager.LoadScene(2);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player") //플레이어가 충돌한것이 감지 될때 stageCount 1 증가
        {
            stageCount++;
        }
    }
}
