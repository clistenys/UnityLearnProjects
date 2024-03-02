using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project01
{
    public class GameManager : MonoBehaviour
    {
        public string PlayerName { get; set; }
        public int Age { get; set; }
        public string Description => $"Name: {PlayerName}; Age: {Age} years";

        // Start is called before the first frame update
        void Start()
        {
            PlayerName = "Dudu";
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }

}
