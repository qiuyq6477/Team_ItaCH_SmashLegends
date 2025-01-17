using UnityEngine;
using UnityEngine.UI;

public class EnablePanelButton : MonoBehaviour
{
    private GameObject _panel;
    private Button _button;
    public Button Button { get => _button; set => _button = value; }

    public void InitEnablePanelButtonSettings(GameObject panel)
    {
        _panel = panel;
        _button = GetComponent<Button>();
        _button.onClick.RemoveAllListeners();
        _button.onClick.AddListener(EnablePanel);
        _button.onClick.AddListener(() => Managers.SoundManager.Play(SoundType.SFX, StringLiteral.SFX_BUTTON));
    }
    public void EnablePanel()
    {
        _panel.SetActive(true);
    }

    private void OnDestroy()
    {
        _button?.onClick.RemoveAllListeners();
    }
 }
