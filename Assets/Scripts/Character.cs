using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum CharacterType
{
    Enemy = 1 << 0,
    Mom = 1 << 1,
    Baby = 1 << 2,
}


[RequireComponent(typeof(Move))]
[RequireComponent(typeof(BufferManager))]
public class Character : MonoBehaviour
{
    [SerializeField]
    private int m_controllerID;
    public int m_health = 100;

    public int controllerID
    {
        get
        {
            return m_controllerID;
        }
        set
        {
            m_controllerID = value;
        }
    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
}
