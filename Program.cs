using System.Text.Json.Nodes;



namespace InclassActivity {

    private class employee() {

        string department;
        string name;
        int salary;

        public employee(string department, string name, int salary) {
            this.department = department;
            this.name = name;
            this.salary = salary;
        }
    }
 
    static class Main() {

        var data = [new employee("HR", "Alice", 50000), new employee("IT", "Bob", 70000), 
        new employee("HR", "Charlie", 60000), new employee("Marketing", "Eve", 55000), 
        new employee("Marketing", "Frank", 58000)];

        

    }
}
