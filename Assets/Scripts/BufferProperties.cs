using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface BufferProperties
{
    public string name { get; }
    public float changeSpeed { get; }
    public bool staggered { get; }
    public bool dot { get; }
}
