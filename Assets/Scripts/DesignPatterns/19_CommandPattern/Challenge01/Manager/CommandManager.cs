using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Section.DesignPatterns.Command.Challenge01
{
    public class CommandManager : MonoBehaviour
    {
        /// Challenge:
        /// Create method to "add" commands to command buffer
        /// 
        /// Create play routine triggered by "play" method that plays back all commands
        ///     add a 1 second delay
        ///     
        /// Create a rewind routine triggered by "rewind" method that plays all commands in reverse
        ///     add a 1 second delay
        ///     
        /// Done = Finshed with changing colors. Turn all cubes white.
        /// 
        /// Reset = Clear the command buffer.
        /// 

        private static CommandManager _instance;
        public static CommandManager Instance
        {
            get
            {
                if (_instance == null)
                    Debug.LogError("CommandManager is NULL.");

                return _instance;
            }
        }

        private List<ICommand> _commandBuffer = new List<ICommand>();

        private void Awake()
        {
            _instance = this;
        }

        /// Challenge:
        /// Create method to "add" commands to command buffer
        public void AddCommand(ICommand command)
        {
            _commandBuffer.Add(command);
        }

        /// Create play routine triggered by "play" method that plays back all commands
        ///     add a 1 second delay
        public void Play()
        {
            StartCoroutine(PlayRoutine());
        }

        IEnumerator PlayRoutine()
        {
            Debug.Log("Playing...");

            foreach (var command in _commandBuffer)
            {
                command.Execute();
                yield return new WaitForSeconds(1.0f);
            }

            Debug.Log("Finished...");
        }

        /// Create a rewind routine triggered by "rewind" method that plays all commands in reverse
        ///     add a 1 second delay
        public void Rewind()
        {
            StartCoroutine(RewindRoutine());
        }

        IEnumerator RewindRoutine()
        {
            foreach(var command in Enumerable.Reverse(_commandBuffer))
            {
                command.Undo();
                yield return new WaitForSeconds(1.0f);
            }
        }

        /// Done = Finshed with changing colors. Turn all cubes white.
        public void Done()
        {
            var cubes = GameObject.FindGameObjectsWithTag("Cube");
            foreach (var cube in cubes)
            {
                cube.GetComponent<MeshRenderer>().material.color = Color.white;
            }
        }

        /// Reset = Clear the command buffer.
        public void Reset()
        {
            _commandBuffer.Clear();
        }
    }
}