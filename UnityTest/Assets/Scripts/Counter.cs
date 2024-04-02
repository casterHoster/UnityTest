using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class Counter : MonoBehaviour
{
    private float _waiting = 0.5f;
    private Text _text;
    private int _counter;
    private Coroutine _coroutine;

    private void Start()
    {
        _counter = 0;
        _text = GetComponent<Text>();
        _coroutine = StartCoroutine(Check());
    }

    private void Update()
    {
        if (_coroutine == null && Input.GetMouseButtonDown(0) == true)
        {
            _coroutine = StartCoroutine(Check());
        } 

        else if (Input.GetMouseButtonDown(0) == true)
        {
            StopCoroutine(_coroutine);
            _coroutine = null;
        }
    }

    private IEnumerator Check()
    {
        while (true)
        {
            _counter++;
            _text.text = _counter.ToString();
            yield return new WaitForSeconds(_waiting);
        }
    }
}
