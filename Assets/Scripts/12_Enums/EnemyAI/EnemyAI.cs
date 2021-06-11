using UnityEngine;

namespace Section.Enums.EnemyAI
{
    public class EnemyAI : MonoBehaviour
    {
        public enum EnemyState
        {
            Patrolling,
            Attacking,
            Pursuing,
            Death
        }

        public EnemyState currentState;

        // Update is called once per frame
        void Update()
        {
            switch (currentState)
            {
                case EnemyState.Patrolling:
                    Debug.Log("Patrolling");
                    if (Time.time > 5)
                    {
                        currentState = EnemyState.Pursuing;
                    }
                    break;
                case EnemyState.Attacking:
                    Debug.Log("Attacking");
                    break;
                case EnemyState.Pursuing:
                    Debug.Log("Pursuing");
                    break;
                case EnemyState.Death:
                    Debug.Log("Death");
                    break;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                currentState = EnemyState.Attacking;
            }
        }
    }
}

