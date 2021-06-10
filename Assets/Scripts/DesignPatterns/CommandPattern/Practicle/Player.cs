using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.DesignPatterns.Command.Practicle
{
    public class Player : MonoBehaviour
    {
        /// Note: Command Pattern is not used for keymapping.
        ///       It should be used for recording steps.
        ///       i.e. tracking the changes of keys during the keymapping process.
        /// 

        ICommand moveUp, moveDown, moveLeft, moveRight;
        [SerializeField]
        private float _speed = 2.0f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                // move up command
                moveUp = new MoveUpCommand(this.transform, _speed);
                moveUp.Execute();
            }
            else if (Input.GetKey(KeyCode.S))
            {
                // move down command
                moveDown = new MoveDownCommand(this.transform, _speed);
                moveDown.Execute();
            }
            else if (Input.GetKey(KeyCode.A))
            {
                // move left command
                moveLeft = new MoveLeftCommand(this.transform, _speed);
                moveLeft.Execute();
            }
            else if (Input.GetKey(KeyCode.D))
            {
                // move right command
                moveRight = new MoveRightCommand(this.transform, _speed);
                moveRight.Execute();
            }
        }
    }
}