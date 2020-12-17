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

            #region Write Bytes

            if (arr != null)
            {
                for (var i = 0; i < arr.Length; i++)
                {
                    Debug.Log($"{i} = {arr[i]}");
                }
            }

            #endregion

            #region Read Bytes

            var item2 = new Item();
            using (MemoryStreamUtility ms = new MemoryStreamUtility(arr))
            {
                item2.Id = ms.ReadInt();
                item2.Name = ms.ReadUTF8String();
            }

            Debug.Log($"{item2.Id}   {item2.Name}");

            #endregion
        }
    }

    public class Item
    {
        public int Id;
        public string Name;
    }
}