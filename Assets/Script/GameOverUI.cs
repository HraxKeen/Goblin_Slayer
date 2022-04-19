using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Health.OnPlayerDeath += ActivateGameObject;
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDestroy() 
    {
        Health.OnPlayerDeath -= ActivateGameObject;
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
    private void ActivateGameObject()
    {
        this.gameObject.SetActive(true);
        
    }
}
