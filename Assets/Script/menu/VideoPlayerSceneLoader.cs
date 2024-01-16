using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoPlayerSceneLoader : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nextSceneName;

    private void Start()
    {
        // ע����Ƶ������ɵĻص�
        videoPlayer.loopPointReached += OnVideoPlayerLoopPointReached;
    }

    private void OnVideoPlayerLoopPointReached(VideoPlayer source)
    {
        // ����Ƶ������ɺ������һ������
        SceneManager.LoadScene(nextSceneName);
    }
}