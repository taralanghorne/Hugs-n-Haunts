using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Events;

[RequireComponent(typeof(VideoPlayer))]
public class Cutscene : MonoBehaviour
{
    VideoPlayer videoplayer;
    public UnityEvent videoComplete;
    public Texture blank;

    private void Awake()
    {
        //videoplayer = GetComponent<VideoPlayer>();
        //videoplayer.targetTexture.DiscardContents();
        //videoplayer.targetTexture.Release();
        //Graphics.Blit(blank, videoplayer.targetTexture);
    }

    // Start is called before the first frame update
    void Start()
    {
        videoplayer = GetComponent<VideoPlayer>();
        videoplayer.targetTexture.DiscardContents();
        videoplayer.targetTexture.Release();
        //Graphics.Blit(blank, videoplayer.targetTexture);
        videoplayer.loopPointReached += VideoComplete;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (!videoplayer.isPlaying) {
            VideoComplete();
        }*/
    }

    void VideoComplete(VideoPlayer video)
    {
        videoComplete.Invoke();
    }
}
