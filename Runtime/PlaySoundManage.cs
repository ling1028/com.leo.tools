using UnityEngine;

namespace Leo.Tools
{
    /// <summary>
    /// 播放音效管理器
    /// </summary>
    public class PlaySoundManage : MonoBehaviour
    {
        /// <summary>
        /// 播放音效
        /// </summary>
        /// <param name="clip">音效</param>
        private void PlaySound(AudioClip clip)
        {
            SoundManage.instance.PlaySound(clip);
        }
    }
}


