using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoPlayerSceneLoader : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nextSceneName;

    private void Start()
    {
        // 注册视频播放完成的回调
        videoPlayer.loopPointReached += OnVideoPlayerLoopPointReached;
    }

    private void OnVideoPlayerLoopPointReached(VideoPlayer source)
    {
        // 在视频播放完成后加载下一个场景
        SceneManager.LoadScene(nextSceneName);
    }
}