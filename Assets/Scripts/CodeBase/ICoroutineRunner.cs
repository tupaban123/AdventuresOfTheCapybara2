using System.Collections;
using UnityEngine;

namespace Adventure.CodeBase
{
    public interface ICoroutineRunner
    {
        Coroutine StartCoroutine(IEnumerator enumerator);
    }
}