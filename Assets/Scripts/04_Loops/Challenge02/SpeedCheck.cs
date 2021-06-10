using System.Collections;
using UnityEngine;

namespace Section.Loops.Challenge02
{
    public class SpeedCheck : MonoBehaviour
    {
        /// Challenge Overview:
        /// Create a program that meets the following:
        ///     increment the value of speed every second
        ///     when speed is greater than MaxSpeed
        ///         stop incrementing (Random between 60 and 120)
        /// 

        public int speed;
        [SerializeField]
        private int _maxSpeed;

        // Start is called before the first frame update
        void Start()
        {
            _maxSpeed = Random.Range(60, 120);
            StartCoroutine(SpeedRoutine());
        }

        IEnumerator SpeedRoutine()
        {
            while (true)
            {
                yield return new WaitForSeconds(0.5f);
                speed += 5;

                if (speed > _maxSpeed)
                {
                    break;
                }
            }

            /// do while variant:

            //do
            //{
            //    speed += 5;
            //    yield return new WaitForSeconds(0.5f);

            //} while (speed > maxSpeed);
        }
    }
}