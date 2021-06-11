using UnityEngine;

namespace Section.DesignPatterns.Command.Presentation
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

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                // move up command
                moveUp = new MoveUpCommand(this.transform, _speed);
                moveUp.Execute();
                CommandManager.Instance.AddCommand(moveUp);
            }
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                // move down command
                moveDown = new MoveDownCommand(this.transform, _speed);
                moveDown.Execute();
                CommandManager.Instance.AddCommand(moveDown);
            }
            else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                // move left command
                moveLeft = new MoveLeftCommand(this.transform, _speed);
                moveLeft.Execute();
                CommandManager.Instance.AddCommand(moveLeft);
            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                // move right command
                moveRight = new MoveRightCommand(this.transform, _speed);
                moveRight.Execute();
                CommandManager.Instance.AddCommand(moveRight);
            }
        }
    }
}