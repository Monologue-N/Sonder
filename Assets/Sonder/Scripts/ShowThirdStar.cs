﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowThirdStar : MonoBehaviour
{
    private Animator m_animator;
    private int currLevelIdx;
   
    void Awake()
    {
        m_animator = GetComponent<Animator>();
        currLevelIdx = PersistentManagerScript.Instance.LevelIdx;

        if (PersistentManagerScript.Instance.LevelShots[currLevelIdx] <= 3)
        {
            m_animator.SetBool("getThirdStar", true);
        }    
    }
}
