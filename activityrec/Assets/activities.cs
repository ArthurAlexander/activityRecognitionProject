using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activities : MonoBehaviour
{
    public Animator anim;

    //void Awake()
    //{
       // anim = GetComponent<Animator>();
       // foreach (AnimatorControllerParameter parameter in anim.parameters){
           // anim.SetBool(parameter.name, false);
        //}
    //}
    // Start is called before the first frame update
    void Start()
    {
        AnimatorControllerParameter[] parameters = anim.parameters;
        //Debug.Log(parameters.Length);
        int paramIndex = Random.Range(0,parameters.Length);
        Debug.Log(paramIndex);
        anim.SetBool(parameters[paramIndex].name, true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

