using UnityEngine;
using UnityEngine.SceneManagement;

namespace Leo.Tools
{
    /// <summary>
    /// 場景控制
    /// </summary>
    public class SceneControl : MonoBehaviour
    {
        /// <summary>
        /// 載入場景
        /// </summary>
        /// <param name="sceneName">場景名稱</param>
        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        /// <summary>
        /// 離開遊戲
        /// </summary>
        public void QuitGame()
        {
            Application.Quit();
        }
    }
}

