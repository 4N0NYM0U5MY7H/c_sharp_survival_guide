using System;
using System.Collections;
using UnityEngine;

namespace Section.Delegates_Events.CallbackSystem
{
    public class Main : MonoBehaviour
    {


        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(MyRoutine(() =>
            {
                Debug.Log("The Routine has finished!");
                Debug.Log("Wow this is cool!");
            }));
        }

        public IEnumerator MyRoutine(Action onComplete = null)
        {
            yield return new WaitForSeconds(5.0f);

            if (onComplete != null)
                onComplete();
        }
    }
}