using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void StartGame()
  {

SceneManager.LoadScene("GameScene");//加載遊戲場景
  }

public void QuitGame()
  {
  #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // 在 Unity 编辑器内使用
        #else
            Application.Quit(); // 在手機上有效
        #endif
  }
}
  