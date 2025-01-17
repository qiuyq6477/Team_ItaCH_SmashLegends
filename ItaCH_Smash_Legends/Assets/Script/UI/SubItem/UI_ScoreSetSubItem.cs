using UnityEngine;

public class UI_ScoreSetSubItem : UIBase
{
    private const int POSITION_X_INTERVAL = -66;
    private const int POSITION_Y_INTERVAL = 10;

    enum Images
    {
        ScoreFill
    }

    enum GameObjects
    {
        ScoreFill
    }

    public override void Init()
    {
        BindImage(typeof(Images));
        BindObject(typeof(GameObjects));
    }

    public void SetInfo(int index)
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector3((index + 1) * POSITION_X_INTERVAL, POSITION_Y_INTERVAL, 0); // index 0 제외        
        GetObject((int)GameObjects.ScoreFill).gameObject.SetActive(false);
    }

    public void ActivateScoreSetSubItem(TeamType teamType)
    {
        GetObject((int)GameObjects.ScoreFill).SetActive(true);
        GetImage((int)Images.ScoreFill).color = Define.UI_PORTRAIT_COLORS[(int)teamType];
    }
}
