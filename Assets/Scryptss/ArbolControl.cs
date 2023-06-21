using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class ArbolControl : MonoBehaviour
{
    public Animator animator;
    public Slider slider;
    public GameObject panel;

    public int life = 10;

    public bool vivo = true;

    private static ArbolControl instance;

    private void Awake()
    {
        instance = this;
    }
    public static ArbolControl Instance
    {
        get { return instance; }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Update is called once per frame
    void Update()
    {
        slider.value = life;
        if(life <= 0 && vivo)
        {
            vivo = false;
           animator.Play("ArbolMuriendo");
        }
    }

    public void GameOver()
    {
        panel.SetActive(true);
    }
}
