using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kandooz
{
    [CreateAssetMenu(menuName = "Kandooz/Int Field")]

    public class IntField : ScriptableObject
    {
        [SerializeField]
        private String modelName;


        public String Value
        {
            get
            {
                return modelName;
            }

            set
            {
                this.modelName = value;

            }
        }
    }
}