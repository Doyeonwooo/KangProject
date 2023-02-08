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

    public void Restart() //GameOver 화면이 송출 되었을때 ReStart 버튼을 눌러 재시작
    { 
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Option() // 게임플레이 도중 ESC 키를 입력하여 옵션화면 출력, 플레이어 비활성화
    {
        if (Input.GetButton("Cancel"))
        {
            player.SetActive(false);
            option.SetActive(true);
        }
    }

    public void CloseOption() // 닫기버튼을 누를시 옵션화면 비활성화, 플레이어 활성화
    {
        option.SetActive(false);
        player.SetActive(true);
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
