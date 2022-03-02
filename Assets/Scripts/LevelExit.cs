﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 1.5f;
    [SerializeField] float levelExitSloMo = 0.2f;


    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(LoadNextLevel());
    }


    IEnumerator LoadNextLevel()
    {
        Time.timeScale = levelExitSloMo;

        yield return new WaitForSecondsRealtime(levelLoadDelay);

        Time.timeScale = 1f;

        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
