using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestInfoUI
{
    [SerializeField] Text _titleTxt;
    [SerializeField] Text _descTxt;
    [SerializeField] Text _countTxt;
    [SerializeField] Image _iconImg;
    [SerializeField] GameObject _clearedGo;
    [SerializeField] Button _rewardBtn;
    [SerializeField] Button _closeBtn;

    Data _data;

    public void Initialize()
    {
        InitializeData();
        InitializeUI();
    }

    // 데이터를 업데이트하는 함수를 따로 만들어 사용
    // 데이터가 업데이트 됨과 동시에 UI 또한 업데이트
    //
    public void UpdateData(QuestData questData, QuestClientData questClientData)
    {
        _data = new Data(questData, questClientData);

        UpdateUI();
    }

    void InitializeData()
    {
        _data = null;
    }

    void InitializeUI()
    {
        // UI 이벤트는 인스펙터 창이 아닌 코드로 추가해
        // 안정적이고 디버깅이 용이하도록 한다

        _rewardBtn.onClick.AddListener(OnClickRewardBtn);
        _closeBtn.onClick.AddListener(OnClickCloseBtn);

        void OnClickRewardBtn()
        {
            // ...
        }

        void OnClickCloseBtn()
        {
            // ...
        }
    }

    // 가공된 데이터를 사용해 보다 간결하게 코드 작성
    //
    void UpdateUI()
    {
        _titleTxt.text = _data.title;
        _descTxt.text = _data.description;
        _countTxt.text = _data.count;
        _iconImg.sprite = _data.icon;
        _clearedGo.SetActive(_data.cleared);
    }

    // 실제 퀘스트 데이터와 별개로 UI에서 사용하기 위한 데이터 클래스를 따로 만들어 사용
    //
    class Data
    {
        public string index;
        public string title;
        public string description;
        public string count;
        public string reward;
        public bool cleared;
        public Sprite icon;
        public Color color;

        public Data(QuestData data, QuestClientData clientData)
        {
            // UI에 사용하기 위해 필요한 값의 형태들로 변형
            //

            // QuestData 혹은 QuestClientData가 변경되는 경우 훨씬 수월하게 대응할 수 있다
            //

            index = $"No.{data.index}";
            title = data.title;
            description = data.description;
            count = $"{clientData.count}/{data.target}";
            cleared = clientData.count >= data.target;
            icon = Resources.Load<Sprite>(data.icon);
            color = ToColor(data.type);

            Color ToColor(QuestData.TYPE type)
            {
                switch (type)
                {
                    case QuestData.TYPE.DAILY:
                        return Color.green;

                    case QuestData.TYPE.WEEKLY:
                        return Color.yellow;

                    case QuestData.TYPE.MONTHLY:
                        return Color.blue;

                    case QuestData.TYPE.ACHIEVEMENT:
                        return Color.red;
                }
                return Color.white;
            }
        }
    }
}

public class QuestData
{
    // enum의 총 개수를 구하기 위해 LENGTH,
    // 오류에 대응하기 위해 NONE 값을 추가해 사용
    //
    public enum TYPE { DAILY, WEEKLY, MONTHLY, ACHIEVEMENT, LENGTH, NONE = -1 }   

    public string key;
    public int index;
    public string title;
    public string description;
    public int target;
    public int reward;
    public string icon;
    public TYPE type;
}

public class QuestClientData
{
    public string key;
    public int count;
}