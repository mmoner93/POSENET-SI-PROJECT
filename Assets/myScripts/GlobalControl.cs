using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;
    public int now;
    public bool tirar;
    public AudioSource musica;
    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(musica);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        musica.Play();
        musica.loop = true;
    }
}