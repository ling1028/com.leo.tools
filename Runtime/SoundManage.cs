using UnityEngine;

namespace Leo.Tools
{
    /// <summary>
    /// 音效管理器
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public class SoundManage : MonoBehaviour
    {
        private static SoundManage _instance;
        public static SoundManage instance
        {
            get
            {
                if (_instance == null) _instance = FindObjectOfType<SoundManage>();
                return _instance;
            }
        }

        private AudioSource aud;

        private void Awake()
        {
            aud = GetComponent<AudioSource>();
        }

        /// <summary>
        /// 播放音效
        /// </summary>
        /// <param name="sound">音效</param>
        /// <param name="min">最小音量</param>
        /// <param name="max">最大音量</param>
        public void PlaySound(AudioClip sound, float min = 0.8f, float max = 1.2f)
        {
            float volume = Random.Range(min, max);
            aud.PlayOneShot(sound, volume);
        }

    }
}


