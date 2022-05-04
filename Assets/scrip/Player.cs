using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Animator titanAnimator;


    public KeyCode golpe;
    public KeyCode bloqueo;
    public KeyCode esquivar;

    public string animacionGolpe;
    public string animacionBloqueo;
    public string animacionEsquivar;





    void Update()
    {


        if(Input.GetKeyDown(golpe))
        {
            titanAnimator.Play(animacionGolpe);
        }
        if(Input.GetKeyDown(bloqueo))
        {
            titanAnimator.Play(animacionBloqueo);
        }
        if(Input.GetKeyDown(esquivar))
        {
            titanAnimator.Play(animacionEsquivar);
        }


    }


}
