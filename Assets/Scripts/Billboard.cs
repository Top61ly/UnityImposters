using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityImposters
{
    public class Billboard : MonoBehaviour
    {
        public bool isRotateXYZ = false;
        private void LateUpdate() 
        {            
            transform.LookAt(Camera.main.transform);
            if (!isRotateXYZ)
                transform.rotation = Quaternion.Euler(0,transform.rotation.eulerAngles.y,0);           
        }       
    }
}