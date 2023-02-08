using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ClearManager : MonoBehaviour
{
    public void RePlay() //GameOver 화면이 송출 되었을때 ReStart 버튼을 눌러 재시작
    {
        SceneManager.LoadScene(2);
    }
    public void GoMain()  // Main 버튼을 클릭하여 메인화면 씬 출력
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame() // Quit 버튼을 클릭해 게임 종료
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
