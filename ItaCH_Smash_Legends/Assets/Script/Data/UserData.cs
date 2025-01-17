using UnityEngine;

public class UserData
{
    public string Name { get; set; }
    public int ID { get; set; }

    private LegendType _selectedLegend;
    public LegendType SelectedLegend
    {
        get
        {
            if (_selectedLegend == LegendType.None)
            {
                _selectedLegend = (LegendType)Random.Range((int)LegendType.Alice, (int)LegendType.MaxCount);
                return _selectedLegend;
            }
            else
            {
                return _selectedLegend;
            }
        }
        set => _selectedLegend = value;
    }

    public TeamType TeamType { get; set; }

    public LegendController OwnedLegend { get; set; }

    public bool isWin { get; set; }

    public UserData GetDefaultUserData(int id)
    {
        UserData defaultUserData = new UserData();
        defaultUserData.Name = $"Bot{id}";
        defaultUserData.ID = id;
        defaultUserData.SelectedLegend = LegendType.None;
        return defaultUserData;
    }
}