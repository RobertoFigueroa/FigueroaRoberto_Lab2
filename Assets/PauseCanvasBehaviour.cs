using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseCanvasBehaviour : MonoBehaviour
{

    private bool isPause = false;

    // Start is called before the first frame update
    void Start()
    {
        Continue();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPause)
            {
                Pause();
                isPause = false;
            }
            else
            {
                Continue();
                isPause = true;
            }
        }


    }

    public void Pause()
    {
        transform.Find("PauseMenu").gameObject.SetActive(true);
        Time.timeScale = 0.0f;
        
    }

    public void Continue()
    {

        transform.Find("PauseMenu").gameObject.SetActive(false);
        Time.timeScale = 1.0f;
        
    }

    public void BackToMenu(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

}
