using System;

namespace persona {

    class Man : People{
        private bool mustache;

        public bool Mustach {get => mustache; set => mustache = value;}

        public string GetHasMoustach(){
            if( mustache ){
                return "I've a big Mustache";
            }
            return "Sorry! I've just a little Mustache.";
        }
    }
}