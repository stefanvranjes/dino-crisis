using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum _SAVE_STATE 
{
    STATE_00, 
    STATE_01, 
    STATE_02, 
    STATE_03, 
    STATE_04, 
    STATE_05, 
    STATE_06, 
    STATE_07, 
    STATE_08, 
    STATE_09
}

public struct SaveSlot
{
    public string slotName; //0x00
    public uint DAT_18; //0x18

    public void Reset()
    {
        slotName = string.Empty;
        DAT_18 = 0;
    }
}

//0x800C25C8
public class SaveManager : MonoBehaviour 
{
    public static SaveManager instance;
    private static BufferedBinaryReader writer; //0x8015D000
    private static BufferedBinaryReader reader;
    private static string inputFieldName;
    private const string gameSavePath = "/Games/Dino Crisis (Unity)/";
    public GameObject saveSlotPrefab;
    public Button saveButton;
    public ScrollRect scrollRect;
    public RectTransform contentRect;
    public InputField inputField;
    public byte currentSlot; //0x08
    public byte DAT_0A; //0x0A
    public sbyte DAT_0C; //0x0C
    public byte DAT_10; //0x10
    public _SAVE_STATE state; //0x11
    public bool DAT_14; //0x14
    public bool DAT_15; //0x15
    public byte DAT_18; //0x18
    public SaveSlot[] saveSlots; //0x20
    public SaveSlot[] saveSlots2; //0x280

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        saveSlots = new SaveSlot[16];
        saveSlots2 = new SaveSlot[16];
        string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        if (!Directory.Exists(myDocumentsPath + gameSavePath))
            Directory.CreateDirectory(myDocumentsPath + gameSavePath);
    }

    // Update is called once per frame
    void Update()
    {
        if (scrollRect.IsActive() && Input.GetMouseButtonDown(1))
        {
            scrollRect.gameObject.SetActive(false);
            Cancel();
        }
    }

    private bool FUN_23D0C(SaveSlot[] param1, uint param2)
    {
        uint uVar1;

        param2 <<= 13;
        uVar1 = 0;

        do
        {
            param2 += param1[uVar1].DAT_18;
            uVar1++;
        } while (uVar1 < 15);

        return 15 < param2 + 0x1fff >> 13;
    }

    public void SetCurrentSlot(int id)
    {
        currentSlot = (byte)id;
    }

    public int CountSlots()
    {
        int count = 0;

        for (int i = 0; i < saveSlots.Length; i++)
            if (saveSlots[i].slotName != String.Empty)
                count++;

        return count;
    }

    public void SaveGame()
    {
        inputFieldName = inputField.text;

        if (inputFieldName.Length >= 3)
        {
            inputField.interactable = false;
            StartCoroutine(FUN_25748());
        }
    }

    public void LoadSlots(bool isSaving)
    {
        for (int i = 0; i < saveSlots.Length; i++)
        {
            saveSlots[i].Reset();
            saveSlots2[i].Reset();
        }

        RectTransform newSlot = contentRect.GetChild(0) as RectTransform;
        newSlot.gameObject.SetActive(isSaving && CountSlots() < saveSlots.Length);
        string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        int fileIndex = 0;

        while (true)
        {
            int k = fileIndex;
            string fileName = "BASLUS-00922-DINO" + fileIndex + ".BIN";

            if (!File.Exists(myDocumentsPath + gameSavePath + fileName)) break;

            FileStream stream = File.Open(myDocumentsPath + gameSavePath + fileName, FileMode.Open, FileAccess.Read);

            if (stream == null) break;

            saveSlots[fileIndex].slotName = "BASLUS-00922-DINO" + fileIndex;
            saveSlots[fileIndex].DAT_18 = 0x2000;
            saveSlots2[fileIndex].slotName = "BASLUS-00922-DINO" + fileIndex;
            fileIndex++;
            reader = new BufferedBinaryReader(stream, (int)stream.Length);
            reader.FillBuffer();
            reader.Seek(0x8F0, SeekOrigin.Begin);
            RectTransform slotRect = Instantiate(saveSlotPrefab).GetComponent<RectTransform>();
            slotRect.SetParent(contentRect, false);
            slotRect.GetComponentInChildren<Text>().text = reader.ReadString();
            Button slotButton = slotRect.GetComponent<Button>();

            if (isSaving)
            {
                slotButton.onClick.AddListener(() => inputField.gameObject.SetActive(true));
                slotButton.onClick.AddListener(() => scrollRect.gameObject.SetActive(false));
                slotButton.onClick.AddListener(() => SetCurrentSlot(k));
                slotButton.onClick.AddListener(() => DestroySlots());
                reader.Dispose();
            }
            else
            {
                slotButton.onClick.AddListener(() => scrollRect.gameObject.SetActive(false));
                slotButton.onClick.AddListener(() => SetCurrentSlot(k));
                slotButton.onClick.AddListener(() => StartCoroutine(FUN_79138()));
                slotButton.onClick.AddListener(() => DestroySlots());
                reader.Dispose();
            }
        }
    }

    public void DestroySlots()
    {
        for (int i = 1; i < contentRect.childCount; i++)
        {
            RectTransform child = contentRect.GetChild(i) as RectTransform;
            Destroy(child.gameObject);
        }
    }

    public void Cancel()
    {
        if (GameManager.instance.gameStarted)
        {
            saveButton.gameObject.SetActive(true);
            DestroySlots();
        }
        else
        {
            GameObject.Find("Start").GetComponent<Button>().interactable = true;
            GameObject.Find("Load").GetComponent<Button>().interactable = true;
            DestroySlots();
        }
    }

    private IEnumerator FUN_25748()
    {
        sbyte sVar1;
        bool bVar5;
        string acStack64;

        acStack64 = "BASLUS-00922-DINO" + currentSlot;

        BEGIN:
        switch (state)
        {
            case _SAVE_STATE.STATE_00:
                if (saveSlots[0].slotName == acStack64)
                {
                    bVar5 = FUN_23D0C(saveSlots, 1);

                    if (bVar5)
                    {
                        DAT_10 = 5;
                        state = _SAVE_STATE.STATE_00;
                        DAT_0A = 3;
                        yield return null;
                    }

                    state = _SAVE_STATE.STATE_02;
                    DAT_14 = true;
                }
                else
                {
                    DAT_15 = true;
                    DAT_14 = false;
                    state++;
                }

                yield return null;
                goto BEGIN;
            case _SAVE_STATE.STATE_01:
                //...
                state++;
                yield return null;
                goto BEGIN;
            case _SAVE_STATE.STATE_02:
                DAT_0C = 5;
                state++;
                goto case _SAVE_STATE.STATE_03;
            case _SAVE_STATE.STATE_03:
                sVar1 = DAT_0C;
                DAT_0C = (sbyte)(sVar1 - 1);

                if ((sbyte)(sVar1 - 1) == -1)
                {
                    DAT_10 = 5;
                    state = _SAVE_STATE.STATE_00;
                    DAT_0A = 1;
                }
                else
                {
                    FUN_23D40(ref writer);
                    acStack64 = "BASLUS-00922-DINO" + currentSlot;
                    FUN_23A50(acStack64, inputFieldName, ref writer);
                    state++;
                    DAT_18 = 2;
                }

                state = _SAVE_STATE.STATE_00;
                inputField.interactable = true;
                inputField.gameObject.SetActive(false);
                saveButton.gameObject.SetActive(true);
                break;
        }

        yield return null;
    }

    private IEnumerator FUN_79138()
    {
        BEGIN:
        switch (state)
        {
            case _SAVE_STATE.STATE_00:
                DAT_0C = 5;
                state++;
                //...
                goto case _SAVE_STATE.STATE_01;
            case _SAVE_STATE.STATE_01:
                FUN_23938();
                DAT_0C--;

                if (DAT_0C == -1)
                    state = _SAVE_STATE.STATE_04;

                yield return null;
                goto BEGIN;
            case _SAVE_STATE.STATE_04:
                DAT_10 = 5;
                state = _SAVE_STATE.STATE_00;
                DAT_0A = 2;
                saveButton.gameObject.SetActive(true);
                GameManager.instance.gameStarted = true;
                break;
        }

        yield return null;
    }

    private void FUN_23428(ref BufferedBinaryReader param1)
    {
        param1.ReadBytes(8); //padding
        GameManager.instance.DAT_9AA0 = param1.ReadUInt16();
        GameManager.instance.DAT_9AA2 = param1.ReadByte();
        param1.ReadByte(); //padding
        GameManager.instance.DAT_9AA4 = param1.ReadInt32();
        GameManager.instance.difficulty = (_DIFFICULTY)param1.ReadByte();
        GameManager.instance.DAT_9AA9 = param1.ReadByte();
        GameManager.instance.DAT_9AAA = param1.ReadByte();
        GameManager.instance.DAT_9AAB = param1.ReadByte();
        GameManager.instance.DAT_9AAC = param1.ReadInt32();
        param1.ReadBytes(4); //padding
        GameManager.instance.DAT_9AB4 = param1.ReadBytes(8);
        param1.ReadBytes(0x20); //padding
        GameManager.instance.DAT_9ADC = param1.ReadUInt16();
        GameManager.instance.DAT_9ADE = param1.ReadByte();
        GameManager.instance.DAT_9ADF = param1.ReadByte();
        param1.ReadUInt32Array(InventoryManager.DAT_C1500);
        param1.ReadUInt32Array(InventoryManager.DAT_C1520);
        param1.ReadUInt32Array(InventoryManager.DAT_C1540);
        param1.ReadUInt32Array(InventoryManager.DAT_C1560);
        param1.ReadUInt32Array(InventoryManager.DAT_C1580);
        param1.ReadUInt32Array(InventoryManager.DAT_C15A0);
        param1.ReadUInt32Array(InventoryManager.DAT_C15A8);
        param1.ReadUInt32Array(InventoryManager.DAT_C15C8);
        param1.ReadUInt32Array(InventoryManager.DAT_C15D0);
        param1.ReadBytes(0x2dc); //padding
        //GameManager.instance.DAT_9EAC = param1.ReadBytes(GameManager.instance.DAT_9EAC.Length);
        //param1.ReadBytes(0x3c - GameManager.instance.DAT_9EAC.Length); //padding
        GameManager.instance.DAT_9EE8 = param1.ReadByte();
        GameManager.instance.DAT_9EE9 = param1.ReadByte();
        GameManager.instance.DAT_9EEA = param1.ReadByte();
        GameManager.instance.DAT_9EEB = param1.ReadByte();
        param1.ReadBytes(0xf0); //padding
        GameManager.instance.DAT_9FDC.x = param1.ReadInt16();
        GameManager.instance.DAT_9FDC.y = param1.ReadInt16();
        param1.ReadBytes(0xb0); //padding
        GameManager.instance.DAT_A090 = param1.ReadBytes(256);
        GameManager.instance.DAT_A0E0 = param1.ReadUInt16();
        GameManager.instance.DAT_A0E2 = param1.ReadUInt16();
        param1.ReadBytes(4); //padding
        GameManager.instance.DAT_A0E8 = param1.ReadInt16();
        GameManager.instance.DAT_A0EA = param1.ReadSByte();
        GameManager.instance.DAT_A0EC = param1.ReadInt16();
        GameManager.instance.DAT_A0EE = param1.ReadInt16();
        GameManager.instance.playerHealth = param1.ReadInt16();
        GameManager.instance.DAT_A0F2 = param1.ReadUInt16();
        GameManager.instance.DAT_A0F4 = param1.ReadUInt32();
        GameManager.instance.DAT_A0F8 = param1.ReadUInt16Array(4);
        GameManager.instance.DAT_A100 = param1.ReadByte();
        param1.ReadBytes(0x1cc); //padding
        GameManager.instance.DAT_A2CC = param1.ReadBool();
        GameManager.instance.DAT_A2CD = param1.ReadByte();
        GameManager.instance.DAT_A2CE = param1.ReadByte();
        GameManager.instance.DAT_A2CF = param1.ReadByte();
        GameManager.instance.DAT_A2D0 = param1.ReadBool();
        GameManager.instance.DAT_A2D1 = param1.ReadBool();
        GameManager.instance.DAT_A2D2 = param1.ReadBool();
        GameManager.instance.DAT_A2D3 = param1.ReadByte();
        GameManager.instance.DAT_A2D4 = param1.ReadBool();
        param1.ReadBytes(3); //padding
    }

    private void FUN_23938()
    {
        string fileName = "BASLUS-00922-DINO" + currentSlot + ".BIN";
        string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        FileStream stream = File.Open(myDocumentsPath + gameSavePath + fileName, FileMode.Open, FileAccess.Read);
        reader = new BufferedBinaryReader(stream, (int)stream.Length);
        reader.FillBuffer();
        FUN_23428(ref reader);
        reader.Dispose();
    }

    private void FUN_23A50(string param1, string param2, ref BufferedBinaryReader param3)
    {
        param3.Seek(0x8F0, SeekOrigin.Begin);
        param3.Write(param2);
        string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        FileStream stream = File.Create(myDocumentsPath + gameSavePath + param1 + ".BIN");
        stream.Write(param3.GetBuffer());
        stream.Close();
    }

    private void FUN_23D40(ref BufferedBinaryReader param1)
    {
        ushort uVar1;

        uVar1 = GameManager.instance.DAT_9AA0;
        GameManager.instance.DAT_9AA0 = GameManager.instance.DAT_9ADC;
        GameManager.instance.DAT_9AAC = 0x990517;
        byte[] buffer = new byte[0x1000];
        param1 = new BufferedBinaryReader(buffer);
        param1.Write(new byte[8]); //padding
        param1.Write(GameManager.instance.DAT_9AA0);
        param1.Write(GameManager.instance.DAT_9AA2);
        param1.Write((byte)0); //padding
        param1.Write(GameManager.instance.DAT_9AA4);
        param1.Write((byte)GameManager.instance.difficulty);
        param1.Write(GameManager.instance.DAT_9AA9);
        param1.Write(GameManager.instance.DAT_9AAA);
        param1.Write(GameManager.instance.DAT_9AAB);
        param1.Write(GameManager.instance.DAT_9AAC);
        param1.Write(new byte[4]); //padding
        param1.Write(GameManager.instance.DAT_9AB4);
        param1.Write(new byte[0x20]); //padding
        param1.Write(GameManager.instance.DAT_9ADC);
        param1.Write(GameManager.instance.DAT_9ADE);
        param1.Write(GameManager.instance.DAT_9ADF);
        param1.Write(InventoryManager.DAT_C1500);
        param1.Write(InventoryManager.DAT_C1520);
        param1.Write(InventoryManager.DAT_C1540);
        param1.Write(InventoryManager.DAT_C1560);
        param1.Write(InventoryManager.DAT_C1580);
        param1.Write(InventoryManager.DAT_C15A0);
        param1.Write(InventoryManager.DAT_C15A8);
        param1.Write(InventoryManager.DAT_C15C8);
        param1.Write(InventoryManager.DAT_C15D0);
        param1.Write(new byte[0x2dc]); //padding
        //param1.Write(GameManager.instance.DAT_9EAC);
        //param1.Write(new byte[0x3c - GameManager.instance.DAT_9EAC.Length]); //padding
        param1.Write(GameManager.instance.DAT_9EE8);
        param1.Write(GameManager.instance.DAT_9EE9);
        param1.Write(GameManager.instance.DAT_9EEA);
        param1.Write(GameManager.instance.DAT_9EEB);
        param1.Write(new byte[0xf0]); //padding
        param1.Write((short)GameManager.instance.DAT_9FDC.x);
        param1.Write((short)GameManager.instance.DAT_9FDC.y);
        param1.Write(new byte[0xb0]); //padding
        param1.Write(GameManager.instance.DAT_A090);
        param1.Write(GameManager.instance.DAT_A0E0);
        param1.Write(GameManager.instance.DAT_A0E2);
        param1.Write(new byte[4]); //padding
        param1.Write(GameManager.instance.DAT_A0E8);
        param1.Write(GameManager.instance.DAT_A0EA);
        param1.Write(GameManager.instance.DAT_A0EC);
        param1.Write(GameManager.instance.DAT_A0EE);
        param1.Write(GameManager.instance.playerHealth);
        param1.Write(GameManager.instance.DAT_A0F2);
        param1.Write(GameManager.instance.DAT_A0F4);
        param1.Write(GameManager.instance.DAT_A0F8);
        param1.Write(GameManager.instance.DAT_A100);
        param1.Write(new byte[0x1cc]); //padding
        param1.Write(GameManager.instance.DAT_A2CC);
        param1.Write(GameManager.instance.DAT_A2CD);
        param1.Write(GameManager.instance.DAT_A2CE);
        param1.Write(GameManager.instance.DAT_A2CF);
        param1.Write(GameManager.instance.DAT_A2D0);
        param1.Write(GameManager.instance.DAT_A2D1);
        param1.Write(GameManager.instance.DAT_A2D2);
        param1.Write(GameManager.instance.DAT_A2D3);
        param1.Write(GameManager.instance.DAT_A2D4);
        param1.Write(new byte[3]); //padding
        GameManager.instance.DAT_9AA0 = uVar1;
    }
}
