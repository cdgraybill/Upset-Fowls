using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public static bool _levelIsComplete = false;
    public GameObject _levelCompleteScreen;
    private Enemy[] _enemies;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    
    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }

    void Update()
    {
        foreach (Enemy enemy in _enemies)
        {
            if (enemy != null)
            {
                return;
            } 
        }

        CompleteScreen();
    }

    private void CompleteScreen()
    {
        _levelIsComplete = true;
        _levelCompleteScreen.SetActive(true);
    }
}
