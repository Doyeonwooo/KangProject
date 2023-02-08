using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Animator settingBtn;
    public Animator settingCloseBtn;

    public void StartGame() //Start ��ư�� Ŭ���Ͽ� ���� ����
    {
        SceneManager.LoadScene(1);
    }

    public void OpenSetting() // Setting��ư�� Ŭ���� �г� �������
    {
        settingBtn.SetBool("isHidden", true);
    }
    public void CloseSetting() // �ݱ� ��ư�� Ŭ���� �г� �ǵ�����
    {
        settingBtn.SetBool("isHidden", false);
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
