using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalTimer : MonoBehaviour
{
    [Header("The Counter")][Tooltip("I am the text")]
    [SerializeField] TextMeshProUGUI CounterText;

    private int m_counter = 0;
    public int counter
    {
        get { return m_counter; }
        set
        {
            if(m_counter != value)
            {
                m_counter = value;
                CounterText.text = m_counter.ToString();
            }
        }
    }

}
