using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LegendUI : MonoBehaviour
{
    [SerializeField] private float _heightOffset;
    [SerializeField] private TextMeshProUGUI _healthPointText;
    [SerializeField] private Image _healthPointBarFilling;
    [SerializeField] private Transform _healthPointSeperator;

    private Transform _characterTransform;
    //private CharacterStatus _characterStatus; TO DO : floating UI 리팩토링
    private RectTransform[] _healthPointBlocks;
    private Image _healthPointSeperatorMask;

    // 비율 계산을 위해 float으로 설정
    private const float StandardHealthPoint = 3000;
    void Update()
    {
        transform.position = new Vector3(_characterTransform.position.x,
            _characterTransform.position.y + _heightOffset,
            _characterTransform.position.z);        
    }

    private void OnDestroy()
    {
        //_characterStatus.OnPlayerHealthPointChange -= SetHealthPoint;
        //_characterStatus.OnPlayerDie -= DisableLegendUI;
        //_characterStatus.OnPlayerRespawn -= EnableLegendUI; // todo : 사망 및 피격 판정 시 UI 활성화 비활성화 
    }
    public void InitLegendUISettings(Transform characterTransform)
    {
        _characterTransform = characterTransform;

        //CharacterStatus characterStatus = characterTransform.GetComponent<CharacterStatus>();
        //if (characterStatus == null)
        //{
        //    //characterStatus = characterTransform.AddComponent<CharacterStatus>();
        //}

        //_characterStatus = characterStatus;
        //_characterStatus.OnPlayerHealthPointChange -= SetHealthPoint;
        //_characterStatus.OnPlayerHealthPointChange += SetHealthPoint;
        //_characterStatus.OnPlayerDie -= DisableLegendUI;
        //_characterStatus.OnPlayerDie += DisableLegendUI; TODO : 죽었을 때 비활성화를 위한 구독
        //_characterStatus.OnPlayerRespawn -= EnableLegendUI;
        //_characterStatus.OnPlayerRespawn += EnableLegendUI; TODO : 리스폰 시 활성화를 위한 구독

        //SetHealthPointBar(_characterStatus.Stat.HP);
        //SetHealthPoint(_characterStatus.CurrentHP, _characterStatus.CurrentHPRatio);
    }

    public void SetHealthPointBar(int maxHealthPoint)
    {
        if (_healthPointBlocks == null)
        {
            _healthPointBlocks = new RectTransform[_healthPointSeperator.childCount];

            for (int i = 0; i < _healthPointBlocks.Length; ++i)
            {
                _healthPointBlocks[i] = _healthPointSeperator.GetChild(i).GetComponent<RectTransform>();
            }

            _healthPointSeperatorMask = _healthPointSeperator.GetComponentInParent<Image>();
            Debug.Assert(_healthPointSeperatorMask != null);
        }

        Vector3 healthPointBlockScale = new Vector3(StandardHealthPoint / maxHealthPoint, 1, 1);

        foreach (RectTransform rectTransform in _healthPointBlocks)
        {
            rectTransform.localScale = healthPointBlockScale;
        }
    }

    public void SetHealthPoint(int healthPoint, int healthPointPercent)
    {
        _healthPointText.text = healthPoint.ToString();
        float healthPointRatio = healthPointPercent * 0.01f;
        _healthPointBarFilling.fillAmount = healthPointRatio;
        _healthPointSeperatorMask.fillAmount = healthPointRatio;
    }

    //public void DisableLegendUI(CharacterStatus character) => gameObject.SetActive(false);
    //public void EnableLegendUI(CharacterStatus character) => gameObject.SetActive(true);
}
