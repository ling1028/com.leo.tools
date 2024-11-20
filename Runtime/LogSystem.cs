using UnityEngine;

namespace Leo.Tools
{
    /// <summary>
    /// 輸出系統
    /// </summary>
    public class LogSystem : MonoBehaviour
    {
        /// <summary>
        /// 輸出
        /// </summary>
        /// <param name="message">要輸出的訊息</param>
        /// <param name="color">訊息顏色</param>
        public static void Log(string message, string color = "#fff")
        {
            Debug.Log($"<color={color}>{message}</color>");
        }
    }
}


