using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public GameObject option;

    private void Update()
    {
        Option();
    }

    public void Restart() //GameOver ȭ���� ���� �Ǿ����� ReStart ��ư�� ���� �����
    { 
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Option() // �����÷��� ���� ESC Ű�� �Է��Ͽ� �ɼ�ȭ�� ���, �÷��̾� ��Ȱ��ȭ
    {
        if (Input.GetButton("Cancel"))
        {
            player.SetActive(false);
            option.SetActive(true);
        }
    }

    public void CloseOption() // �ݱ��ư�� ������ �ɼ�ȭ�� ��Ȱ��ȭ, �÷��̾� Ȱ��ȭ
    {
        option.SetActive(false);
        player.SetActive(true);
    }

    public void GoMain()  // Main ��ư�� Ŭ���Ͽ� ����ȭ�� �� ���
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame() // Quit ��ư�� Ŭ���� ���� ����
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    
}
