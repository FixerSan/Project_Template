using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public GameSettingsProfile gameSettings;

    private void Awake()
    {
        GameStart();
    }

    //���� ���� �Ǿ��� ��
    public void GameStart()
    {
        Managers.Resource.LoadAllAsync<Object>("Preload", _completeCallback: () =>                  //�����ε� ���ҽ� �ε�
        {
            gameSettings = Managers.Resource.Load<GameSettingsProfile>("GameSettingsProfile");      //���� ���� ����
            if (gameSettings.isDebuging)                                                            //����� ���� ��
            {
                Debug.Log("y");
                return;
            }
            //����� ���� �ƴ� ��
            Debug.Log("n");
        });
    }
}
