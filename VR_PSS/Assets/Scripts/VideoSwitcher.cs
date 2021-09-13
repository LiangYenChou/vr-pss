using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoSwitcher : MonoBehaviour
{
    public List<UnityEngine.Video.VideoClip> VideoClips = new List<UnityEngine.Video.VideoClip>();
    public bool doSwitch = false;
    UnityEngine.Video.VideoPlayer _videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        _videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (doSwitch)
        {
            _videoPlayer.clip = VideoClips[1];
            _videoPlayer.Play();
            doSwitch = false;
        }
    }
}
