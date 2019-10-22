﻿using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class LoadImageHelper : MonoBehaviour
{
    string defaultUrl = "http://avatar.csdnimg.cn/1/E/6/2_u013012420.jpg";
    /// <summary>
    /// use this to load image
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="url"></param>
    public void LoadImage(RawImage rawImage, string url)
    {
        if (string.IsNullOrEmpty(url))
        {
            url = defaultUrl;
        }
        StartCoroutine(LoadTeture(url, (tex) => {
            rawImage.texture = tex;
        }));
    }

    IEnumerator LoadTeture(string url, Action<Texture2D> cb)
    {
        yield return LoadImageMgr.instance.LoadImage(url, cb);
    }
}

