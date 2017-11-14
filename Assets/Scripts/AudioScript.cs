using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AudioScript {

    static List<GameObject> audioClips = new List<GameObject>();

    public static GameObject PlayClipAt(AudioClip clip, Vector3 position, float volume = 1, float pitch = 1)
    {
        GameObject obj = FindAudioClip(clip);
        if (obj)
        {
            obj.transform.position = position;
            AudioSource audio = obj.GetComponent<AudioSource>();
            audio.pitch = pitch;
            audio.volume = volume;
            audio.Play();
        }
        else
        {
            obj = new GameObject(clip.ToString() + "Audio");
            GameObject.DontDestroyOnLoad(obj);
            audioClips.Add(obj);
            obj.transform.position = position;
            AudioSource audio = obj.AddComponent<AudioSource>();
            audio.pitch = pitch;
            audio.clip = clip;
            audio.volume = volume;
            audio.Play();
        }
        return obj;
    }

    static GameObject FindAudioClip(AudioClip clip)
    {
        if(AudioScript.audioClips.Count > 0)
            foreach (GameObject source in AudioScript.audioClips)
                if (source.GetComponent<AudioSource>().clip == clip)
                    return source;

        return null;
    }
}
