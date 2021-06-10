using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.DesignPatterns.Command.Challenge01
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}