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

    // �����͸� ������Ʈ�ϴ� �Լ��� ���� ����� ���
    // �����Ͱ� ������Ʈ �ʰ� ���ÿ� UI ���� ������Ʈ
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
        // UI �̺�Ʈ�� �ν����� â�� �ƴ� �ڵ�� �߰���
        // �������̰� ������� �����ϵ��� �Ѵ�

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

    // ������ �����͸� ����� ���� �����ϰ� �ڵ� �ۼ�
    //
    void UpdateUI()
    {
        _titleTxt.text = _data.title;
        _descTxt.text = _data.description;
        _countTxt.text = _data.count;
        _iconImg.sprite = _data.icon;
        _clearedGo.SetActive(_data.cleared);
    }

    // ���� ����Ʈ �����Ϳ� ������ UI���� ����ϱ� ���� ������ Ŭ������ ���� ����� ���
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
            // UI�� ����ϱ� ���� �ʿ��� ���� ���µ�� ����
            //

            // QuestData Ȥ�� QuestClientData�� ����Ǵ� ��� �ξ� �����ϰ� ������ �� �ִ�
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
    // enum�� �� ������ ���ϱ� ���� LENGTH,
    // ������ �����ϱ� ���� NONE ���� �߰��� ���
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