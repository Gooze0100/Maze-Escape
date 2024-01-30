using System.Collections;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    [SerializeField] float exitDelay = 1f;

    GameManager gameManager;

    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(LoadVictory());
        }
    }

    IEnumerator LoadVictory()
    {
        yield return new WaitForSeconds(exitDelay);
        gameManager.LoadVictoryScene();
    }
}
