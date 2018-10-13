namespace Day_18_08 {
    using System.Linq;
    public class Person {

        public string midName;
        

        public static int GetMidNameLength(Person p)
        {
            return p.midName?.Length ?? 0;
        }

        public static bool operator ==(Person p, Person a)
        {
            return p.Equals(a)
            
        }

        public override bool Equals(object obj)
            {
                //
                // See the full list of guidelines at
                //   http://go.microsoft.com/fwlink/?LinkID=85237
                // and also the guidance for operator== at
                //   http://go.microsoft.com/fwlink/?LinkId=85238
                //
                
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }
                
                // TODO: write your implementation of Equals() here
                
                return base.Equals (obj);
            }
            
            // override object.GetHashCode
            public override int GetHashCode()
            {
                // TODO: write your implementation of GetHashCode() here
                throw new System.NotImplementedException();
                return base.GetHashCode();
            }
    }
}