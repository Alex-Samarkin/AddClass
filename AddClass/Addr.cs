using System;
using System.Collections.Generic;
using System.Text;

namespace AddClass
{
    public class Addr
    {
        public string City { get; set; } = "Псков";
        public string Street { get; set; } = "Народная";
        public int House { get; set; } = 12;
        public int Corp { get; set; } = 1;
        public int Office { get; set; } = 102;

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString() +
                $" Город - {City},  улица - {Street}, Дом/Корпус - {House} / {Corp} , Квартира/Офис - {Office}" ;
        }
    }
}
