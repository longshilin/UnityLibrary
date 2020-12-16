using System;
using Longshilin.Common;
using UnityEngine;

namespace LibraryTest.Common
{
    public class MemoryStreamUtilityTest : MonoBehaviour
    {
        private void Start()
        {
            byte[] arr = null;
            Item item = new Item() {Id = 1001, Name = "Longshilin"};
            using (MemoryStreamUtility ms = new MemoryStreamUtility())
            {
                ms.WriteInt(item.Id);
                ms.WriteUTF8String(item.Name);

                arr = ms.ToArray();
            }


            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Debug.Log(string.Format("123"));
                }
            }
        }
    }

    public class Item
    {
        public int Id;
        public string Name;
    }
}