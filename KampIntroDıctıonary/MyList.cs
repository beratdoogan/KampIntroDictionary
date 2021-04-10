using System;
using System.Collections.Generic;
using System.Text;

namespace KampIntroDıctıonary
{
    public class MyList<T>{
        T[] _keys;
        T[] _value;
        public MyList()
        {
            _keys = new T[0];
            _value = new T[0];
        }
        public void Add(T keys,T value){
            T[] tempArray = _keys,_value;
            _keys = new T[_keys.Length+1];
            _value = new T[_keys.Length+1];
            for (var i = 0; i < tempArray.Length; i++){
                _keys[i] = tempArray[1];
                _value[i] = tempArray[1];
                
            }

            _keys[_keys.Length-1] = keys;
            _value[_value.Length-1] = value;

        }
    }
}
