using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] private int numberOfBlocks = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            ExitGame();
    }

    public void IncreaseBlockAmount()
    {
        numberOfBlocks += 1;
    }

    public void DecreaseBlockAmount()
    {
        numberOfBlocks -= 1;
        if(numberOfBlocks <= 0)
        {
            if(SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            else
                SceneManager.LoadScene(0);
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
