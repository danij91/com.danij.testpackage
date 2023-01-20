using System.Collections;
using System.Collections.Generic;
using TestPackageB;
using UnityEngine;

namespace TestPackage
{
    public class HelloWorld : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Message msg = new Message();
            Debug.Log(msg.GetHello());
        }
    }
}