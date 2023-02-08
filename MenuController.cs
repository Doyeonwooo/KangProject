using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Animator settingBtn;
    public Animator settingCloseBtn;

    public void StartGame() //Start 버튼을 클릭하여 게임 시작
    {
        SceneManager.LoadScene(1);
    }

    public void OpenSetting() // Setting버튼을 클릭해 패널 끌어오기
    {
        settingBtn.SetBool("isHidden", true);
    }
    public void CloseSetting() // 닫기 버튼을 클릭해 패널 되돌리기
    {
        settingBtn.SetBool("isHidden", false);
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
