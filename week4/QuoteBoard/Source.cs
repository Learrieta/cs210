 public class Source{
        private string name = "";
        private string url = "";

        public Source(string name, string url=""){
            //public Source will be the constroctor of the class because it has the same name.
            
            this.name = name;
            this.url = url;
        }

        public string getName(){
            return name;
        }

        public string getUrl(){
            return url;
        }

    }