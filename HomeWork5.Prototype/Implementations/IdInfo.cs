using HomeWork5.Prototype.Extensions;
using HomeWork5.Prototype.Interfaces;

namespace HomeWork5.Prototype.Implementations
{
    public class IdInfo: IMyCloneable<IdInfo>,ICloneable
    {
        public string Type {  get; set; }
        public int IdNumber { get; set; }

        public IdInfo(int idNumber, string type)
        {
            IdNumber = idNumber;
            Type = type;
        }

        public IdInfo(IdInfo idInfo)
        {
            IdNumber = idInfo.IdNumber;
            Type = idInfo.Type;
        }


        public object Clone()
        {
            return MemberwiseClone();
        }

        public IdInfo MyClone()
        {
            return new IdInfo(this);
        }

        public IdInfo DeepCopy()
        {
            return CopyHelper.CreateDeepCopy(this);
        }

       
    }
}
