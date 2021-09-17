using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoSwitcher : MonoBehaviour
{
    public List<UnityEngine.Video.VideoClip> VideoClips = new List<UnityEngine.Video.VideoClip>();
    public bool doSwitch = false;
    UnityEngine.Video.VideoPlayer _videoPlayer;

    public static VideoSwitcher Instance { get => _instance; }
    static VideoSwitcher _instance;

    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchVideo(int idx)
    {
        Debug.Log("Switching");
        if (idx > 0 && idx < VideoClips.Count)
        {
            _videoPlayer.isLooping = false;
            _videoPlayer.clip = VideoClips[idx];
            _videoPlayer.Play();
        }
    }
}
