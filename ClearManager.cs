using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ClearManager : MonoBehaviour
{
    public void RePlay() //GameOver ȭ���� ���� �Ǿ����� ReStart ��ư�� ���� �����
    {
        SceneManager.LoadScene(2);
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
