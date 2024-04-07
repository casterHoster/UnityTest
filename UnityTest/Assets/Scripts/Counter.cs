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
        _coroutine = StartCoroutine(Increase());
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            if (_coroutine == null)
            {
                _coroutine = StartCoroutine(Increase());
            }
            else
            {
                StopCoroutine(_coroutine);
                _coroutine = null;
            }
        }  
    }

    private IEnumerator Increase()
    {
        WaitForSeconds waiting = new WaitForSeconds(_waiting);

        while (true)
        {
            _counter++;
            _text.text = _counter.ToString();
            yield return waiting;
        }
    }
}
