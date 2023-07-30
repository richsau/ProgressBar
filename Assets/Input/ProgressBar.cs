using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using UnityEngine.SceneManagement;
//using UnityEngine.UIElements;


public class ProgressBar : MonoBehaviour
{
    private UIInputActions _input;
    [SerializeField]
    private Slider _slider;
    [SerializeField]
    private Image _fillArea;
    [SerializeField]
    private TMP_Text _scoreText;
    [SerializeField]
    private TMP_Text _fillText;
    [SerializeField]
    private AudioSource _startAudio;
    [SerializeField]
    private AudioSource _highScoreAudio;
    [SerializeField]
    private AudioSource _buzzAudio;
    private bool _isFilling = false;
    private float _highScore = 0;
    private float _maxScore = 0.99f;
    

    void Start()
    {
        _input = new UIInputActions();
        _input.ProgressBar.Enable();
        _input.ProgressBar.Fill.started += Fill_started;
        _input.ProgressBar.Fill.canceled += Fill_canceled;
        _input.ProgressBar.Reset.performed += Reset_performed;
        _input.ProgressBar.Quit.performed += Quit_performed;
        _fillText.text = "Fill: 0";
        _scoreText.text = "High Score: 0";
        _fillArea.color = Color.green;
    }

    private void Quit_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    private void Reset_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        SceneManager.LoadScene(0);
    }

    private void Fill_started(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        if (_slider.value == 0)
        {
            _isFilling = true;
            StartCoroutine(ProgressBarLogic());
            _fillArea.color = Color.green;
            _startAudio.Play();
        }
    }

    private void Fill_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        if (_slider.value > _maxScore)
        {
            _fillArea.color = Color.red;
            _buzzAudio.Play();
        }
        if (_slider.value > _highScore && _slider.value < .99 && _fillArea.color != Color.red)
        {
            _highScore = _slider.value;
            _scoreText.text = "High Score: " + _highScore;
            _highScoreAudio.Play();
        }
        _isFilling = false;
    }

    IEnumerator ProgressBarLogic()
    {
        while (_isFilling == true)
        {
            _slider.value += (1.0f * Time.deltaTime) * 2;
            if (_slider.value > _maxScore)
            {
                _isFilling = false;
                _fillArea.color = Color.red;
                _buzzAudio.Play();
            }
            _fillText.text = "Fill: " + _slider.value;
            yield return null;
        }

        while (_slider.value > 0)
        {
            _slider.value -= 1.0f * Time.deltaTime / 5;
            _fillText.text = "Fill: " + _slider.value;
            _isFilling = false;
            yield return null;
        }
    }
}
