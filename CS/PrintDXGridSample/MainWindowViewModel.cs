using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// ...

namespace PrintDXGridSample {
    public class MainWindowViewModel {
        IEnumerable<Person> persons;

        public IEnumerable<Person> Persons {
            get {
                return persons;
            }
            set {
                persons = value;
            }
        }

        public MainWindowViewModel() {
            persons = new List<Person>(new Person[] { 
                new Person("John", 25),
                new Person("Mary", 33)
            });
        }
    }
}
