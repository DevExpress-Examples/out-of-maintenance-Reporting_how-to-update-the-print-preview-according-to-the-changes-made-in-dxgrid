using System.Collections.Generic;
// ...

namespace PrintDXGridSample {
    public class MainWindowViewModel {
        public IEnumerable<Person> Persons { get; set; }

        public MainWindowViewModel() {
            Persons = new[] { 
                new Person("John", 25),
                new Person("Mary", 33)
            };
        }
    }
}
