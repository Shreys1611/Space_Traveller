using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countDownReady;
    public GameObject countDownGo;
    public GameObject fadeIn;
    public AudioSource readyFX;
    public AudioSource goFX;
    
    void Start()
    {
        StartCoroutine(CountSequence());

    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1);
        countDownReady.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        countDownGo.SetActive(true);
        goFX.Play();
        PlayerMove.canMove = true;

    }

}
