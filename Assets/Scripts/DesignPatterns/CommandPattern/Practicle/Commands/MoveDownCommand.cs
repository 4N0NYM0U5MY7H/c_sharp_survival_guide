using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.DesignPatterns.Command.Practical
{
    public class MoveDownCommand : ICommand
    {
        private Transform _player;
        private float _speed;

        public MoveDownCommand(Transform player, float speed)
        {
            this._player = player;
            this._speed = speed;
        }

        public void Execute()
        {
            _player.Translate(Vector3.down * _speed * Time.deltaTime);
        }

        public void Undo()
        {
            _player.Translate(Vector3.up * _speed * Time.deltaTime);
        }
    }
}