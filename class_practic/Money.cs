using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_practic
{
    class Money
    {
        private int note_face_value;
        private int count;
        public Money()
        {
            note_face_value = 0;
            count = 0;
        }
        public Money(int note_face_value,int count)
        {
            SetNoteFaceValue(note_face_value);
            SetCount(count);
        }
        public void SetNoteFaceValue(int note_face_value)
        {
            this.note_face_value = note_face_value;
        }
        public void SetCount(int count)
        {
            this.count = count;
        }
        public int GetNoteFaceValue ()
        {
            return note_face_value;
        }
        public int GetCount()
        {
            return count;
        }
        public bool IsEnought(int sum)
        {
            return count * note_face_value >= sum;
        }
        public int GetCountProduct(int sum)
        {
            return count * note_face_value / sum;
        }
        public int GetSum()
        {
            return count*note_face_value;
        }
        static public bool TryParceStrInt(string str, ref int result)
        {            
            try
            {
                result = int.Parse(str);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
