using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Section.DesignPatterns.Command.Practical
{
    public class CommandManager : MonoBehaviour
    {
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

        public void AddCommand(ICommand command)
        {
            _commandBuffer.Add(command);
        }

        public void Rewind()
        {
            StartCoroutine(RewindRoutine());
        }

        IEnumerator RewindRoutine()
        {
            Debug.Log("Rewinding...");
            foreach (var command in Enumerable.Reverse(_commandBuffer))
            {
                command.Undo();
                yield return new WaitForEndOfFrame();
            }
            Debug.Log("Finished Rewinding...");
        }

        public void Playback()
        {
            StartCoroutine(PlaybackRoutine());
        }

        IEnumerator PlaybackRoutine()
        {
            Debug.Log("Playing...");
            foreach (var command in _commandBuffer)
            {
                command.Execute();
                yield return new WaitForEndOfFrame();
            }
            Debug.Log("Finished Playing...");
        }
    }
}